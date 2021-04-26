.PHONY: run
run: setup-server #setup-client

.PHONY: setup-server
setup-server: protoc-for-go install-go-module

.PHONY: protoc-for-go
protoc-for-go:
	protoc -I ./proto \
	--go_out=./server/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	--go-grpc_out=./server/pb \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	./proto/*.proto

.PHONY: install-go-module
install-go-module:
	(cd server && go mod tidy)


# .PHONY: setup-client
# setup-client: protoc-for-csharp

# .PHONY: protoc-for-csharp
#  protoc-for-csharp:
# 	protoc -I ./proto --csharp_out=./client/pb ./proto/*.proto
