package validation

import (
	"errors"
	"fmt"
	"regexp"

	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/status"
	"google.golang.org/protobuf/proto"
	"google.golang.org/protobuf/reflect/protoreflect"
	"google.golang.org/protobuf/types/descriptorpb"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/common"
)

func Validate(pb proto.Message) error {
	return validate(pb.ProtoReflect())
}

func validate(message protoreflect.Message) error {
	var errs error

	fields := message.Descriptor().Fields()
	for i := 0; i < fields.Len(); i++ {
		field := fields.Get(i)

		// フィールドがmessage型なら再起的にバリデーション
		if field.Kind() == protoreflect.MessageKind {
			errs = appendErr(errs, validate(message.Get(field).Message()))
			continue
		}

		// フィールドオプションからバリデーション取得
		options := field.Options().(*descriptorpb.FieldOptions)
		validations, ok := proto.GetExtension(options, pb.E_Opts).(*pb.Opts)
		if !ok || validations == nil {
			continue
		}

		// フィールドデータ取得
		value := message.Get(field).Interface().(string)

		// 正規表現バリデーション
		if validations.Regexp != nil {
			isValid, err := regexp.MatchString(*validations.Regexp, value)
			if err != nil {
				return status.Error(codes.Internal, err.Error())
			}
			if !isValid {
				if validations.Message != nil {
					errs = appendErr(errs, errors.New(*validations.Message))
					continue
				}
				errs = appendErr(errs, errors.New("request invalid"))
				continue
			}
		}
	}

	if errs != nil {
		return status.Error(codes.InvalidArgument, errs.Error())
	}
	return nil
}

func appendErr(stack, new error) error {
	if new == nil {
		return stack
	}
	if stack == nil {
		return new
	}
	return fmt.Errorf("%v\n%v", stack, new)
}
