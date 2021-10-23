package api_test

import (
	"errors"
	"testing"

	"github.com/stretchr/testify/assert"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/match"
	"github.com/CA22-game-creators/cookingbomb-proto/server/validation"
)

func TestSignupRequest(t *testing.T) {
	t.Parallel()

	tests := []struct {
		title    string
		input    *pb.MatchRequest
		expected error
	}{
		{
			title: "【正常系】マッチング開始",
			input: &pb.MatchRequest{
				UserId:       "00000000000000000000000001",
				SessionToken: "00000000-0000-0000-0000-000000000001",
			},
			expected: nil,
		},
		{
			title: "【異常系】不正なUserID",
			input: &pb.MatchRequest{
				UserId:       "1",
				SessionToken: "00000000-0000-0000-0000-000000000001",
			},
			expected: errors.New("ユーザーIDが不正な形式です"),
		},
		{
			title: "【異常系】不正なSessionToken",
			input: &pb.MatchRequest{
				UserId:       "00000000000000000000000001",
				SessionToken: "1",
			},
			expected: errors.New("sessionTokenが不正な形式です"),
		},
	}

	for _, td := range tests {
		td := td

		t.Run("MatchRequest:"+td.title, func(t *testing.T) {
			t.Parallel()

			output := validation.Validate(td.input)

			assert.Equal(t, td.expected, output)
		})
	}
}
