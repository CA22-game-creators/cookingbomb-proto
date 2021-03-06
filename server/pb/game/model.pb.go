// Code generated by protoc-gen-go. DO NOT EDIT.
// versions:
// 	protoc-gen-go v1.26.0
// 	protoc        v3.17.3
// source: proto/game/model.proto

package game

import (
	protoreflect "google.golang.org/protobuf/reflect/protoreflect"
	protoimpl "google.golang.org/protobuf/runtime/protoimpl"
	timestamppb "google.golang.org/protobuf/types/known/timestamppb"
	reflect "reflect"
	sync "sync"
)

const (
	// Verify that this generated code is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(20 - protoimpl.MinVersion)
	// Verify that runtime/protoimpl is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(protoimpl.MaxVersion - 20)
)

type Character struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	Id         string                 `protobuf:"bytes,1,opt,name=id,proto3" json:"id,omitempty"`
	Position   *Position              `protobuf:"bytes,2,opt,name=position,proto3" json:"position,omitempty"`
	Rotation   *Rotation              `protobuf:"bytes,3,opt,name=rotation,proto3" json:"rotation,omitempty"`
	Velocity   *Velocity              `protobuf:"bytes,4,opt,name=velocity,proto3" json:"velocity,omitempty"`
	KeyInput   *KeyInput              `protobuf:"bytes,5,opt,name=key_input,json=keyInput,proto3" json:"key_input,omitempty"`
	UpdateTime *timestamppb.Timestamp `protobuf:"bytes,6,opt,name=update_time,json=updateTime,proto3" json:"update_time,omitempty"`
}

func (x *Character) Reset() {
	*x = Character{}
	if protoimpl.UnsafeEnabled {
		mi := &file_proto_game_model_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *Character) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*Character) ProtoMessage() {}

func (x *Character) ProtoReflect() protoreflect.Message {
	mi := &file_proto_game_model_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use Character.ProtoReflect.Descriptor instead.
func (*Character) Descriptor() ([]byte, []int) {
	return file_proto_game_model_proto_rawDescGZIP(), []int{0}
}

func (x *Character) GetId() string {
	if x != nil {
		return x.Id
	}
	return ""
}

func (x *Character) GetPosition() *Position {
	if x != nil {
		return x.Position
	}
	return nil
}

func (x *Character) GetRotation() *Rotation {
	if x != nil {
		return x.Rotation
	}
	return nil
}

func (x *Character) GetVelocity() *Velocity {
	if x != nil {
		return x.Velocity
	}
	return nil
}

func (x *Character) GetKeyInput() *KeyInput {
	if x != nil {
		return x.KeyInput
	}
	return nil
}

func (x *Character) GetUpdateTime() *timestamppb.Timestamp {
	if x != nil {
		return x.UpdateTime
	}
	return nil
}

var File_proto_game_model_proto protoreflect.FileDescriptor

var file_proto_game_model_proto_rawDesc = []byte{
	0x0a, 0x16, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x61, 0x6d, 0x65, 0x2f, 0x6d, 0x6f, 0x64,
	0x65, 0x6c, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x05, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a,
	0x1f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66,
	0x2f, 0x74, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f,
	0x1a, 0x1a, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x61, 0x6d, 0x65, 0x2f, 0x73, 0x74, 0x72,
	0x75, 0x63, 0x74, 0x75, 0x72, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x22, 0x8d, 0x02, 0x0a,
	0x09, 0x43, 0x68, 0x61, 0x72, 0x61, 0x63, 0x74, 0x65, 0x72, 0x12, 0x0e, 0x0a, 0x02, 0x69, 0x64,
	0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x02, 0x69, 0x64, 0x12, 0x2b, 0x0a, 0x08, 0x70, 0x6f,
	0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x18, 0x02, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x0f, 0x2e, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x2e, 0x50, 0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x52, 0x08, 0x70,
	0x6f, 0x73, 0x69, 0x74, 0x69, 0x6f, 0x6e, 0x12, 0x2b, 0x0a, 0x08, 0x72, 0x6f, 0x74, 0x61, 0x74,
	0x69, 0x6f, 0x6e, 0x18, 0x03, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x0f, 0x2e, 0x70, 0x72, 0x6f, 0x74,
	0x6f, 0x2e, 0x52, 0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x52, 0x08, 0x72, 0x6f, 0x74, 0x61,
	0x74, 0x69, 0x6f, 0x6e, 0x12, 0x2b, 0x0a, 0x08, 0x76, 0x65, 0x6c, 0x6f, 0x63, 0x69, 0x74, 0x79,
	0x18, 0x04, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x0f, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2e, 0x56,
	0x65, 0x6c, 0x6f, 0x63, 0x69, 0x74, 0x79, 0x52, 0x08, 0x76, 0x65, 0x6c, 0x6f, 0x63, 0x69, 0x74,
	0x79, 0x12, 0x2c, 0x0a, 0x09, 0x6b, 0x65, 0x79, 0x5f, 0x69, 0x6e, 0x70, 0x75, 0x74, 0x18, 0x05,
	0x20, 0x01, 0x28, 0x0b, 0x32, 0x0f, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2e, 0x4b, 0x65, 0x79,
	0x49, 0x6e, 0x70, 0x75, 0x74, 0x52, 0x08, 0x6b, 0x65, 0x79, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x12,
	0x3b, 0x0a, 0x0b, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x5f, 0x74, 0x69, 0x6d, 0x65, 0x18, 0x06,
	0x20, 0x01, 0x28, 0x0b, 0x32, 0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x70, 0x72,
	0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70,
	0x52, 0x0a, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x54, 0x69, 0x6d, 0x65, 0x42, 0x49, 0x5a, 0x3a,
	0x67, 0x69, 0x74, 0x68, 0x75, 0x62, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x43, 0x41, 0x32, 0x32, 0x2d,
	0x67, 0x61, 0x6d, 0x65, 0x2d, 0x63, 0x72, 0x65, 0x61, 0x74, 0x6f, 0x72, 0x73, 0x2f, 0x63, 0x6f,
	0x6f, 0x6b, 0x69, 0x6e, 0x67, 0x62, 0x6f, 0x6d, 0x62, 0x2d, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f,
	0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x61, 0x6d, 0x65, 0xaa, 0x02, 0x0a, 0x50, 0x72, 0x6f,
	0x74, 0x6f, 0x2e, 0x47, 0x61, 0x6d, 0x65, 0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_proto_game_model_proto_rawDescOnce sync.Once
	file_proto_game_model_proto_rawDescData = file_proto_game_model_proto_rawDesc
)

func file_proto_game_model_proto_rawDescGZIP() []byte {
	file_proto_game_model_proto_rawDescOnce.Do(func() {
		file_proto_game_model_proto_rawDescData = protoimpl.X.CompressGZIP(file_proto_game_model_proto_rawDescData)
	})
	return file_proto_game_model_proto_rawDescData
}

var file_proto_game_model_proto_msgTypes = make([]protoimpl.MessageInfo, 1)
var file_proto_game_model_proto_goTypes = []interface{}{
	(*Character)(nil),             // 0: proto.Character
	(*Position)(nil),              // 1: proto.Position
	(*Rotation)(nil),              // 2: proto.Rotation
	(*Velocity)(nil),              // 3: proto.Velocity
	(*KeyInput)(nil),              // 4: proto.KeyInput
	(*timestamppb.Timestamp)(nil), // 5: google.protobuf.Timestamp
}
var file_proto_game_model_proto_depIdxs = []int32{
	1, // 0: proto.Character.position:type_name -> proto.Position
	2, // 1: proto.Character.rotation:type_name -> proto.Rotation
	3, // 2: proto.Character.velocity:type_name -> proto.Velocity
	4, // 3: proto.Character.key_input:type_name -> proto.KeyInput
	5, // 4: proto.Character.update_time:type_name -> google.protobuf.Timestamp
	5, // [5:5] is the sub-list for method output_type
	5, // [5:5] is the sub-list for method input_type
	5, // [5:5] is the sub-list for extension type_name
	5, // [5:5] is the sub-list for extension extendee
	0, // [0:5] is the sub-list for field type_name
}

func init() { file_proto_game_model_proto_init() }
func file_proto_game_model_proto_init() {
	if File_proto_game_model_proto != nil {
		return
	}
	file_proto_game_structure_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_proto_game_model_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*Character); i {
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
			RawDescriptor: file_proto_game_model_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   1,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_proto_game_model_proto_goTypes,
		DependencyIndexes: file_proto_game_model_proto_depIdxs,
		MessageInfos:      file_proto_game_model_proto_msgTypes,
	}.Build()
	File_proto_game_model_proto = out.File
	file_proto_game_model_proto_rawDesc = nil
	file_proto_game_model_proto_goTypes = nil
	file_proto_game_model_proto_depIdxs = nil
}
