.PHONY: run
run: setup-common-server setup-api-server setup-game-server setup-server-test # setup-client

.PHONY: setup-common-server
setup-common-server:
	protoc \
	--go_out=./server/pb/common \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/common \
	--go-grpc_out=./server/pb/common \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/common \
	./proto/common/*.proto
	go mod tidy

.PHONY: setup-api-server
setup-api-server:
	protoc \
	--go_out=./server/pb/api \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/api \
	--go_opt=Mproto/common/option.proto=github.com/CA22-game-creators/cookingbomb-proto/server/pb/common \
	--go-grpc_out=./server/pb/api \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/api \
	./proto/api/*.proto
	go mod tidy

.PHONY: setup-game-server
setup-game-server:
	protoc \
	--go_out=./server/pb/game \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	--go-grpc_out=./server/pb/game \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	./proto/game/*.proto
	go mod tidy

.PHONY: setup-server-test
setup-server-test:
	protoc \
	--go_out=./test/testdata/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/test/testdata \
	--go_opt=Mproto/common/option.proto=github.com/CA22-game-creators/cookingbomb-proto/server/pb/common \
	./test/testdata/*.proto

# .PHONY: setup-client
# setup-client:
# 	protoc --csharp_out=./client/api/pb ./proto/api/*.proto
# 	protoc --csharp_out=./client/game/pb ./proto/game/*.proto
# 	protoc --csharp_out=./client/common/pb ./proto/common/*.proto

.PHONY: test
test:
	go test ./test/server/... -count=1
