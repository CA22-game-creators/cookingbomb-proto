package validation

import (
	"errors"
	"fmt"
	"regexp"
	"unicode/utf8"

	"google.golang.org/protobuf/reflect/protoreflect"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/common"
)

func validateString(fieldName protoreflect.Name, opts *pb.StringOpts, v string) error {
	var errs error

	errs = appendErr(errs, validateLength(opts, v))
	errs = appendErr(errs, validateRegexp(opts, v))
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

func validateRegexp(opts *pb.StringOpts, v string) error {
	if opts.Regexp == nil {
		return nil
	}

	isValid, err := regexp.MatchString(*opts.Regexp, v)
	if err != nil {
		return errors.New(err.Error())
	}
	if !isValid {
		return errors.New("invalid format")
	}

	return nil
}
