package api_test

import (
	"testing"

	"github.com/stretchr/testify/assert"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/status"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/api"
	"github.com/CA22-game-creators/cookingbomb-proto/server/validation"
)

func TestSignupRequest(t *testing.T) {
	t.Parallel()

	tests := []struct {
		title    string
		input    *pb.SignupRequest
		expected error
	}{
		{
			title:    "【正常系】",
			input:    &pb.SignupRequest{Name: "山田太郎"},
			expected: nil,
		},
		{
			title:    "【異常系】ユーザー名が短すぎる",
			input:    &pb.SignupRequest{Name: ""},
			expected: status.Error(codes.InvalidArgument, "ユーザー名は半角英数字か日本語の1-10文字である必要があります"),
		},
		{
			title:    "【異常系】ユーザー名が長すぎる",
			input:    &pb.SignupRequest{Name: "12345678901"},
			expected: status.Error(codes.InvalidArgument, "ユーザー名は半角英数字か日本語の1-10文字である必要があります"),
		},
		{
			title:    "【異常系】ユーザー名に記号が入っている",
			input:    &pb.SignupRequest{Name: "山田_太郎"},
			expected: status.Error(codes.InvalidArgument, "ユーザー名は半角英数字か日本語の1-10文字である必要があります"),
		},
	}

	for _, td := range tests {
		td := td

		t.Run("SignupRequest:"+td.title, func(t *testing.T) {
			t.Parallel()

			output := validation.Validate(td.input)

			assert.Equal(t, td.expected, output)
		})
	}
}
