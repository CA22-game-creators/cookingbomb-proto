.PHONY: run
run: setup-server setup-client setup-server-test

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

.PHONY: setup-server-test
setup-server-test:
	protoc \
	--go_out=test/testdata/pb \
	--go_opt=module=github.com/CA22-game-creators/cookingbomb-proto/test/testdata \
	./test/testdata/*.proto
	sed -i '' -e \
	's|github.com/CA22-game-creators/cookingbomb-proto/proto|\
	github.com/CA22-game-creators/cookingbomb-proto/server/pb|' \
	./test/testdata/pb/*.go

# TODO クライアントコードの自動生成コマンド実装
.PHONY: setup-client
setup-client:
#	protoc -I ./proto --csharp_out=./client/pb ./proto/*.proto


.PHONY: test
test:
	go test ./test/server/... -count=1
