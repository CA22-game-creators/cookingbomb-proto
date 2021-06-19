.PHONY: run
run: setup-common-server setup-api-server setup-game-server # setup-client
	go mod tidy
.PHONY: setup-common-server
setup-common-server:
	protoc \
	--go_out=./server/pb/common \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/common \
	--go-grpc_out=./server/pb/common \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/common \
	./proto/common/*.proto

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

.PHONY: setup-game-server
setup-game-server:
	protoc \
	--go_out=./server/pb/game \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	--go_opt=Mproto/common/option.proto=github.com/CA22-game-creators/cookingbomb-proto/server/pb/common \
	--go-grpc_out=./server/pb/game \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/game \
	./proto/game/*.proto

# .PHONY: setup-client
# setup-client:
# 	protoc --csharp_out=./client/api/pb ./proto/api/*.proto
# 	protoc --csharp_out=./client/game/pb ./proto/game/*.proto
# 	protoc --csharp_out=./client/common/pb ./proto/common/*.proto

.PHONY: test
test:
	go test ./server/test/... -count=1
