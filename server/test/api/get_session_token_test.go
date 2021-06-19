package api_test

import (
	"testing"

	"github.com/stretchr/testify/assert"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/status"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/api"
	"github.com/CA22-game-creators/cookingbomb-proto/server/validation"
)

func TestGetSessionTokenRequest(t *testing.T) {
	t.Parallel()

	tests := []struct {
		title    string
		input    *pb.GetSessionTokenRequest
		expected error
	}{
		{
			title:    "【正常系】",
			input:    &pb.GetSessionTokenRequest{UserId: "00000000000000000000000001", AuthToken: "00000000-0000-0000-0000-000000000001"},
			expected: nil,
		},
		{
			title:    "【異常系】ユーザーIDがULIDの形式でない",
			input:    &pb.GetSessionTokenRequest{UserId: "invalid", AuthToken: "00000000-0000-0000-0000-000000000001"},
			expected: status.Error(codes.InvalidArgument, "ユーザーIDが不正な形式です"),
		},
		{
			title:    "【異常系】authTokenがUUIDの形式でない",
			input:    &pb.GetSessionTokenRequest{UserId: "00000000000000000000000001", AuthToken: "invalid"},
			expected: status.Error(codes.InvalidArgument, "authTokenが不正な形式です"),
		},
		{
			title:    "【異常系】ユーザーIDもauthTokenも不正値",
			input:    &pb.GetSessionTokenRequest{UserId: "invalid", AuthToken: "invalid"},
			expected: status.Error(codes.InvalidArgument, "ユーザーIDが不正な形式です\nauthTokenが不正な形式です"),
		},
	}

	for _, td := range tests {
		td := td

		t.Run("GetSessionTokenRequest:"+td.title, func(t *testing.T) {
			t.Parallel()

			output := validation.Validate(td.input)

			assert.Equal(t, td.expected, output)
		})
	}
}
