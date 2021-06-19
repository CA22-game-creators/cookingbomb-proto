package game_test

import (
	"testing"

	"github.com/stretchr/testify/assert"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/status"

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
			expected: status.Error(codes.InvalidArgument, "sessionTokenが不正な形式です"),
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
