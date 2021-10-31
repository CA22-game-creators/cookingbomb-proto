.PHONY: run
run: setup-common-server setup-api-server setup-game-server setup-match-server setup-client
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

.PHONY: setup-match-server
setup-match-server:
	protoc \
	--go_out=./server/pb/match \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/match \
	--go-grpc_out=./server/pb/match \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto/match \
	./proto/match/*.proto

.PHONY: setup-client
setup-client:
	protoc \
	--csharp_out=./client/api \
	--grpc_out=./client/api \
	--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
	--csharp_opt=base_namespace=Proto.Api \
	./proto/api/*.proto
	protoc \
	--csharp_out=./client/game \
	--grpc_out=./client/game \
	--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
	--csharp_opt=base_namespace=Proto.Game \
	./proto/game/*.proto
	protoc \
	--experimental_allow_proto3_optional \
	--csharp_out=./client/common \
	--grpc_out=./client/common \
	--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
	--csharp_opt=base_namespace=Proto.Common \
	./proto/common/*.proto
	protoc \
	--experimental_allow_proto3_optional \
	--csharp_out=./client/match \
	--grpc_out=./client/match \
	--plugin=protoc-gen-grpc=/usr/local/bin/grpc_csharp_plugin \
	--csharp_opt=base_namespace=Proto.Match \
	./proto/match/*.proto

.PHONY: test
test:
	go test ./server/test/... -count=1
