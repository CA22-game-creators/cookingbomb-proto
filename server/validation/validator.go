package validation

import (
	"fmt"

	"google.golang.org/protobuf/proto"
	"google.golang.org/protobuf/reflect/protoreflect"
	"google.golang.org/protobuf/types/descriptorpb"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/common"
)

func Validate(pb proto.Message) error {
	return validate(pb.ProtoReflect())
}

func validate(m protoreflect.Message) error {
	var errs error

	fields := m.Descriptor().Fields()
	for i := 0; i < fields.Len(); i++ {
		field := fields.Get(i)

		// フィールドがmessage型なら再起的にバリデーション
		if field.Kind() == protoreflect.MessageKind {
			errs = appendErr(errs, validate(m.Get(field).Message()))
			continue
		}

		// フィールドオプション取得
		options := field.Options().(*descriptorpb.FieldOptions)

		// 文字列型のバリデーション
		stringOptions, ok := proto.GetExtension(options, pb.E_StringOpts).(*pb.StringOpts)
		if ok && stringOptions != nil {
			strVal := m.Get(field).Interface().(string)
			errs = appendErr(errs, validateString(field.Name(), stringOptions, strVal))
			continue
		}

		// TODO 数値型などのバリデーション
	}

	return errs
}

func appendErr(stack, new error) error {
	if new == nil {
		return stack
	}
	if stack == nil {
		return new
	}
	return fmt.Errorf("%v; %v", stack, new)
}
