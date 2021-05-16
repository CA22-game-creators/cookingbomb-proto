.PHONY: run
run: setup-server setup-game-server setup-client setup-server-test

.PHONY: setup-server
setup-server:
	protoc \
	--go_out=./server/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	--go-grpc_out=./server/pb \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	./proto/*.proto
	go mod tidy

.PHONY: setup-game-server
setup-game-server:
	protoc \
	--go_out=./server/game/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	--go-grpc_out=./server/game/pb \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	./proto/game/*.proto
	go mod tidy

.PHONY: setup-server-test
setup-server-test:
	protoc \
	--go_out=./test/testdata/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/test/testdata \
	--go_opt=Mproto/option.proto=github.com/CA22-game-creators/cookingbomb-proto/server/pb \
	./test/testdata/*.proto

.PHONY: setup-client
setup-client:
	protoc --csharp_out=./client/pb ./proto/*.proto
	protoc --csharp_out=./client/pb/game ./proto/game/*.proto

.PHONY: test
test:
	go test ./test/server/... -count=1
