package game_test

import (
	"errors"
	"testing"

	"github.com/stretchr/testify/assert"

	pb "github.com/CA22-game-creators/cookingbomb-proto/server/pb/game"
	"github.com/CA22-game-creators/cookingbomb-proto/server/validation"
)

func TestConnectionRequest(t *testing.T) {
	t.Parallel()

	tests := []struct {
		title    string
		input    *pb.ConnectionRequest
		expected error
	}{
		{
			title:    "【正常系】",
			input:    &pb.ConnectionRequest{SessionToken: "00000000-0000-0000-0000-000000000001"},
			expected: nil,
		},
		{
			title:    "【異常系】sessionTokenがUUIDの形式でない",
			input:    &pb.ConnectionRequest{SessionToken: "invalid"},
			expected: errors.New("sessionTokenが不正な形式です"),
		},
	}

	for _, td := range tests {
		td := td

		t.Run("ConnectionRequest:"+td.title, func(t *testing.T) {
			t.Parallel()

			output := validation.Validate(td.input)

			assert.Equal(t, td.expected, output)
		})
	}
}
