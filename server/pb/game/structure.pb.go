// Code generated by protoc-gen-go. DO NOT EDIT.
// versions:
// 	protoc-gen-go v1.26.0
// 	protoc        v3.15.8
// source: proto/game/structure.proto

package game

import (
	protoreflect "google.golang.org/protobuf/reflect/protoreflect"
	protoimpl "google.golang.org/protobuf/runtime/protoimpl"
	reflect "reflect"
	sync "sync"
)

const (
	// Verify that this generated code is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(20 - protoimpl.MinVersion)
	// Verify that runtime/protoimpl is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(protoimpl.MaxVersion - 20)
)

type Position struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	X float32 `protobuf:"fixed32,1,opt,name=x,proto3" json:"x,omitempty"`
	Y float32 `protobuf:"fixed32,2,opt,name=y,proto3" json:"y,omitempty"`
	Z float32 `protobuf:"fixed32,3,opt,name=z,proto3" json:"z,omitempty"`
}

func (x *Position) Reset() {
	*x = Position{}
	if protoimpl.UnsafeEnabled {
		mi := &file_proto_game_structure_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Position) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Position) ProtoMessage() {}

func (x *Position) ProtoReflect() protoreflect.Message {
	mi := &file_proto_game_structure_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Position.ProtoReflect.Descriptor instead.
func (*Position) Descriptor() ([]byte, []int) {
	return file_proto_game_structure_proto_rawDescGZIP(), []int{0}
}

func (x *Position) GetX() float32 {
	if x != nil {
		return x.X
	}
	return 0
}

func (x *Position) GetY() float32 {
	if x != nil {
		return x.Y
	}
	return 0
}

func (x *Position) GetZ() float32 {
	if x != nil {
		return x.Z
	}
	return 0
}

type Rotation struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	X float32 `protobuf:"fixed32,1,opt,name=x,proto3" json:"x,omitempty"`
	Y float32 `protobuf:"fixed32,2,opt,name=y,proto3" json:"y,omitempty"`
	Z float32 `protobuf:"fixed32,3,opt,name=z,proto3" json:"z,omitempty"`
	W float32 `protobuf:"fixed32,4,opt,name=w,proto3" json:"w,omitempty"`
}

func (x *Rotation) Reset() {
	*x = Rotation{}
	if protoimpl.UnsafeEnabled {
		mi := &file_proto_game_structure_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Rotation) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Rotation) ProtoMessage() {}

func (x *Rotation) ProtoReflect() protoreflect.Message {
	mi := &file_proto_game_structure_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Rotation.ProtoReflect.Descriptor instead.
func (*Rotation) Descriptor() ([]byte, []int) {
	return file_proto_game_structure_proto_rawDescGZIP(), []int{1}
}

func (x *Rotation) GetX() float32 {
	if x != nil {
		return x.X
	}
	return 0
}

func (x *Rotation) GetY() float32 {
	if x != nil {
		return x.Y
	}
	return 0
}

func (x *Rotation) GetZ() float32 {
	if x != nil {
		return x.Z
	}
	return 0
}

func (x *Rotation) GetW() float32 {
	if x != nil {
		return x.W
	}
	return 0
}

type Verocity struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	X float32 `protobuf:"fixed32,1,opt,name=x,proto3" json:"x,omitempty"`
	Y float32 `protobuf:"fixed32,2,opt,name=y,proto3" json:"y,omitempty"`
	Z float32 `protobuf:"fixed32,3,opt,name=z,proto3" json:"z,omitempty"`
}

func (x *Verocity) Reset() {
	*x = Verocity{}
	if protoimpl.UnsafeEnabled {
		mi := &file_proto_game_structure_proto_msgTypes[2]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Verocity) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Verocity) ProtoMessage() {}

func (x *Verocity) ProtoReflect() protoreflect.Message {
	mi := &file_proto_game_structure_proto_msgTypes[2]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Verocity.ProtoReflect.Descriptor instead.
func (*Verocity) Descriptor() ([]byte, []int) {
	return file_proto_game_structure_proto_rawDescGZIP(), []int{2}
}

func (x *Verocity) GetX() float32 {
	if x != nil {
		return x.X
	}
	return 0
}

func (x *Verocity) GetY() float32 {
	if x != nil {
		return x.Y
	}
	return 0
}

func (x *Verocity) GetZ() float32 {
	if x != nil {
		return x.Z
	}
	return 0
}

var File_proto_game_structure_proto protoreflect.FileDescriptor

var file_proto_game_structure_proto_rawDesc = []byte{
	0x0a, 0x1a, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x61, 0x6d, 0x65, 0x2f, 0x73, 0x74, 0x72,
	0x75, 0x63, 0x74, 0x75, 0x72, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x05, 0x70, 0x72,
	0x6f, 0x74, 0x6f, 0x22, 0x34, 0x0a, 0x08, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x12,
	0x0c, 0x0a, 0x01, 0x78, 0x18, 0x01, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x78, 0x12, 0x0c, 0x0a,
	0x01, 0x79, 0x18, 0x02, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x79, 0x12, 0x0c, 0x0a, 0x01, 0x7a,
	0x18, 0x03, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x7a, 0x22, 0x42, 0x0a, 0x08, 0x52, 0x6f, 0x74,
	0x61, 0x74, 0x69, 0x6f, 0x6e, 0x12, 0x0c, 0x0a, 0x01, 0x78, 0x18, 0x01, 0x20, 0x01, 0x28, 0x02,
	0x52, 0x01, 0x78, 0x12, 0x0c, 0x0a, 0x01, 0x79, 0x18, 0x02, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01,
	0x79, 0x12, 0x0c, 0x0a, 0x01, 0x7a, 0x18, 0x03, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x7a, 0x12,
	0x0c, 0x0a, 0x01, 0x77, 0x18, 0x04, 0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x77, 0x22, 0x34, 0x0a,
	0x08, 0x56, 0x65, 0x72, 0x6f, 0x63, 0x69, 0x74, 0x79, 0x12, 0x0c, 0x0a, 0x01, 0x78, 0x18, 0x01,
	0x20, 0x01, 0x28, 0x02, 0x52, 0x01, 0x78, 0x12, 0x0c, 0x0a, 0x01, 0x79, 0x18, 0x02, 0x20, 0x01,
	0x28, 0x02, 0x52, 0x01, 0x79, 0x12, 0x0c, 0x0a, 0x01, 0x7a, 0x18, 0x03, 0x20, 0x01, 0x28, 0x02,
	0x52, 0x01, 0x7a, 0x42, 0x3c, 0x5a, 0x3a, 0x67, 0x69, 0x74, 0x68, 0x75, 0x62, 0x2e, 0x63, 0x6f,
	0x6d, 0x2f, 0x43, 0x41, 0x32, 0x32, 0x2d, 0x67, 0x61, 0x6d, 0x65, 0x2d, 0x63, 0x72, 0x65, 0x61,
	0x74, 0x6f, 0x72, 0x73, 0x2f, 0x63, 0x6f, 0x6f, 0x6b, 0x69, 0x6e, 0x67, 0x62, 0x6f, 0x6d, 0x62,
	0x2d, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x61, 0x6d,
	0x65, 0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_proto_game_structure_proto_rawDescOnce sync.Once
	file_proto_game_structure_proto_rawDescData = file_proto_game_structure_proto_rawDesc
)

func file_proto_game_structure_proto_rawDescGZIP() []byte {
	file_proto_game_structure_proto_rawDescOnce.Do(func() {
		file_proto_game_structure_proto_rawDescData = protoimpl.X.CompressGZIP(file_proto_game_structure_proto_rawDescData)
	})
	return file_proto_game_structure_proto_rawDescData
}

var file_proto_game_structure_proto_msgTypes = make([]protoimpl.MessageInfo, 3)
var file_proto_game_structure_proto_goTypes = []interface{}{
	(*Position)(nil), // 0: proto.Position
	(*Rotation)(nil), // 1: proto.Rotation
	(*Verocity)(nil), // 2: proto.Verocity
}
var file_proto_game_structure_proto_depIdxs = []int32{
	0, // [0:0] is the sub-list for method output_type
	0, // [0:0] is the sub-list for method input_type
	0, // [0:0] is the sub-list for extension type_name
	0, // [0:0] is the sub-list for extension extendee
	0, // [0:0] is the sub-list for field type_name
}

func init() { file_proto_game_structure_proto_init() }
func file_proto_game_structure_proto_init() {
	if File_proto_game_structure_proto != nil {
		return
	}
	if !protoimpl.UnsafeEnabled {
		file_proto_game_structure_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Position); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_proto_game_structure_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Rotation); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_proto_game_structure_proto_msgTypes[2].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Verocity); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
	}
	type x struct{}
	out := protoimpl.TypeBuilder{
		File: protoimpl.DescBuilder{
			GoPackagePath: reflect.TypeOf(x{}).PkgPath(),
			RawDescriptor: file_proto_game_structure_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   3,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_proto_game_structure_proto_goTypes,
		DependencyIndexes: file_proto_game_structure_proto_depIdxs,
		MessageInfos:      file_proto_game_structure_proto_msgTypes,
	}.Build()
	File_proto_game_structure_proto = out.File
	file_proto_game_structure_proto_rawDesc = nil
	file_proto_game_structure_proto_goTypes = nil
	file_proto_game_structure_proto_depIdxs = nil
}
