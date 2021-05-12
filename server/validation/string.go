package validation

import (
	"fmt"
	"unicode/utf8"

	"google.golang.org/protobuf/reflect/protoreflect"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb"
)

func validateString(fieldName protoreflect.Name, opts *pb.StringOpts, v string) error {
	var errs error

	errs = appendErr(errs, validateLength(opts, v))
	// TODO その他の文字列フィールドバリデーション
	if errs != nil {
		errs = fmt.Errorf("%v:%v", fieldName, errs)
	}

	return errs
}

func validateLength(opts *pb.StringOpts, v string) error {
	actualLen := utf8.RuneCountInString(v)

	if opts.MinLen != nil && actualLen < int(*opts.MinLen) {
		return fmt.Errorf("length should be %d characters or more", int(*opts.MinLen))
	}
	if opts.MaxLen != nil && actualLen > int(*opts.MaxLen) {
		return fmt.Errorf("length should be %d characters or less", int(*opts.MaxLen))
	}

	return nil
}
