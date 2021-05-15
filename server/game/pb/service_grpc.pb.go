// Code generated by protoc-gen-go-grpc. DO NOT EDIT.

package game

import (
	context "context"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
)

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
// Requires gRPC-Go v1.32.0 or later.
const _ = grpc.SupportPackageIsVersion7

// AccountServicesClient is the client API for AccountServices service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://pkg.go.dev/google.golang.org/grpc/?tab=doc#ClientConn.NewStream.
type AccountServicesClient interface {
	Connect(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error)
	Disconnect(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error)
	GetConnectionStatus(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error)
	CharacterDataStream(ctx context.Context, opts ...grpc.CallOption) (AccountServices_CharacterDataStreamClient, error)
}

type accountServicesClient struct {
	cc grpc.ClientConnInterface
}

func NewAccountServicesClient(cc grpc.ClientConnInterface) AccountServicesClient {
	return &accountServicesClient{cc}
}

func (c *accountServicesClient) Connect(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error) {
	out := new(ConnectionStatus)
	err := c.cc.Invoke(ctx, "/proto.AccountServices/Connect", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *accountServicesClient) Disconnect(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error) {
	out := new(ConnectionStatus)
	err := c.cc.Invoke(ctx, "/proto.AccountServices/Disconnect", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *accountServicesClient) GetConnectionStatus(ctx context.Context, in *ConnectRequest, opts ...grpc.CallOption) (*ConnectionStatus, error) {
	out := new(ConnectionStatus)
	err := c.cc.Invoke(ctx, "/proto.AccountServices/GetConnectionStatus", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *accountServicesClient) CharacterDataStream(ctx context.Context, opts ...grpc.CallOption) (AccountServices_CharacterDataStreamClient, error) {
	stream, err := c.cc.NewStream(ctx, &AccountServices_ServiceDesc.Streams[0], "/proto.AccountServices/CharacterDataStream", opts...)
	if err != nil {
		return nil, err
	}
	x := &accountServicesCharacterDataStreamClient{stream}
	return x, nil
}

type AccountServices_CharacterDataStreamClient interface {
	Send(*CharacterData) error
	Recv() (*CharacterDataList, error)
	grpc.ClientStream
}

type accountServicesCharacterDataStreamClient struct {
	grpc.ClientStream
}

func (x *accountServicesCharacterDataStreamClient) Send(m *CharacterData) error {
	return x.ClientStream.SendMsg(m)
}

func (x *accountServicesCharacterDataStreamClient) Recv() (*CharacterDataList, error) {
	m := new(CharacterDataList)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

// AccountServicesServer is the server API for AccountServices service.
// All implementations should embed UnimplementedAccountServicesServer
// for forward compatibility
type AccountServicesServer interface {
	Connect(context.Context, *ConnectRequest) (*ConnectionStatus, error)
	Disconnect(context.Context, *ConnectRequest) (*ConnectionStatus, error)
	GetConnectionStatus(context.Context, *ConnectRequest) (*ConnectionStatus, error)
	CharacterDataStream(AccountServices_CharacterDataStreamServer) error
}

// UnimplementedAccountServicesServer should be embedded to have forward compatible implementations.
type UnimplementedAccountServicesServer struct {
}

func (UnimplementedAccountServicesServer) Connect(context.Context, *ConnectRequest) (*ConnectionStatus, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Connect not implemented")
}
func (UnimplementedAccountServicesServer) Disconnect(context.Context, *ConnectRequest) (*ConnectionStatus, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Disconnect not implemented")
}
func (UnimplementedAccountServicesServer) GetConnectionStatus(context.Context, *ConnectRequest) (*ConnectionStatus, error) {
	return nil, status.Errorf(codes.Unimplemented, "method GetConnectionStatus not implemented")
}
func (UnimplementedAccountServicesServer) CharacterDataStream(AccountServices_CharacterDataStreamServer) error {
	return status.Errorf(codes.Unimplemented, "method CharacterDataStream not implemented")
}

// UnsafeAccountServicesServer may be embedded to opt out of forward compatibility for this service.
// Use of this interface is not recommended, as added methods to AccountServicesServer will
// result in compilation errors.
type UnsafeAccountServicesServer interface {
	mustEmbedUnimplementedAccountServicesServer()
}

func RegisterAccountServicesServer(s grpc.ServiceRegistrar, srv AccountServicesServer) {
	s.RegisterService(&AccountServices_ServiceDesc, srv)
}

func _AccountServices_Connect_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(ConnectRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(AccountServicesServer).Connect(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/proto.AccountServices/Connect",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(AccountServicesServer).Connect(ctx, req.(*ConnectRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _AccountServices_Disconnect_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(ConnectRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(AccountServicesServer).Disconnect(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/proto.AccountServices/Disconnect",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(AccountServicesServer).Disconnect(ctx, req.(*ConnectRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _AccountServices_GetConnectionStatus_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(ConnectRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(AccountServicesServer).GetConnectionStatus(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/proto.AccountServices/GetConnectionStatus",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(AccountServicesServer).GetConnectionStatus(ctx, req.(*ConnectRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _AccountServices_CharacterDataStream_Handler(srv interface{}, stream grpc.ServerStream) error {
	return srv.(AccountServicesServer).CharacterDataStream(&accountServicesCharacterDataStreamServer{stream})
}

type AccountServices_CharacterDataStreamServer interface {
	Send(*CharacterDataList) error
	Recv() (*CharacterData, error)
	grpc.ServerStream
}

type accountServicesCharacterDataStreamServer struct {
	grpc.ServerStream
}

func (x *accountServicesCharacterDataStreamServer) Send(m *CharacterDataList) error {
	return x.ServerStream.SendMsg(m)
}

func (x *accountServicesCharacterDataStreamServer) Recv() (*CharacterData, error) {
	m := new(CharacterData)
	if err := x.ServerStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

// AccountServices_ServiceDesc is the grpc.ServiceDesc for AccountServices service.
// It's only intended for direct use with grpc.RegisterService,
// and not to be introspected or modified (even as a copy)
var AccountServices_ServiceDesc = grpc.ServiceDesc{
	ServiceName: "proto.AccountServices",
	HandlerType: (*AccountServicesServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "Connect",
			Handler:    _AccountServices_Connect_Handler,
		},
		{
			MethodName: "Disconnect",
			Handler:    _AccountServices_Disconnect_Handler,
		},
		{
			MethodName: "GetConnectionStatus",
			Handler:    _AccountServices_GetConnectionStatus_Handler,
		},
	},
	Streams: []grpc.StreamDesc{
		{
			StreamName:    "CharacterDataStream",
			Handler:       _AccountServices_CharacterDataStream_Handler,
			ServerStreams: true,
			ClientStreams: true,
		},
	},
	Metadata: "proto/game/service.proto",
}
