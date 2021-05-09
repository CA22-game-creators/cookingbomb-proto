package validation_test

import (
	"errors"
	"strings"
	"testing"

	"github.com/stretchr/testify/assert"
	"google.golang.org/protobuf/proto"

	"github.com/CA22-game-creators/cookingbomb-proto/server/validation"

	tdPb "github.com/CA22-game-creators/cookingbomb-proto/test/testdata/pb"
)

func TestValidate(t *testing.T) {
	t.Parallel()

	tests := []struct {
		title    string
		input    proto.Message
		expected error
	}{
		{
			title:    "【正常系】文字列フィールドオプションなし",
			input:    &tdPb.String{Value: "string"},
			expected: nil,
		},
		{
			title:    "【正常系】文字列フィールドで文字数が正常",
			input:    &tdPb.StringLimitLenRange{Value: "string"},
			expected: nil,
		},
		{
			title:    "【正常系】複数文字列フィールドで文字数が正常",
			input:    &tdPb.StringMulti{Value1: "string", Value2: "string"},
			expected: nil,
		},
		{
			title:    "【異常系】文字列フィールドで文字数が短い",
			input:    &tdPb.StringLimitMinLen{Value: "a"},
			expected: errors.New("value:length should be 5 characters or more"),
		},
		{
			title:    "【異常系】文字列フィールドで文字数が長い",
			input:    &tdPb.StringLimitMaxLen{Value: strings.Repeat("a", 100)},
			expected: errors.New("value:length should be 10 characters or less"),
		},
		{
			title: "【異常系】複数文字列フィールドで文字数が異常",
			input: &tdPb.StringMulti{Value1: "a", Value2: "a"},
			expected: errors.New(
				"value1:length should be 5 characters or more; value2:length should be 5 characters or more",
			),
		},
	}

	for _, td := range tests {
		td := td

		t.Run("TestValidate:"+td.title, func(t *testing.T) {
			t.Parallel()

			output := validation.Validate(td.input)

			assert.Equal(t, td.expected, output)
		})
	}
}
