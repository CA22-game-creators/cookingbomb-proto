module github.com/CA22-game-creators/cookingbomb-proto

go 1.16

require (
	google.golang.org/grpc v1.37.0
	google.golang.org/protobuf v1.26.0
)

replace github.com/CA22-game-creators/cookingbomb-proto v0.1.0 => ./server/pb
