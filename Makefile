.PHONY: run
run: setup-server setup-client

.PHONY: setup-server
setup-server:
	protoc -I ./proto \
	--go_out=. \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	--go-grpc_out=. \
	--go-grpc_opt=require_unimplemented_servers=false \
	--go-grpc_opt=module=github.com/CA22-game-creators/cookingbomb-proto/proto \
	./proto/*.proto
	go mod tidy

# TODO クライアントコードの自動生成コマンド実装
.PHONY: setup-client
setup-client:
#	protoc -I ./proto --csharp_out=./client/pb ./proto/*.proto
