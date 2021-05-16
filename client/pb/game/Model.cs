// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/game/model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from proto/game/model.proto</summary>
  public static partial class ModelReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/game/model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZwcm90by9nYW1lL21vZGVsLnByb3RvEgVwcm90bxofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90byLtAQoJQ2hhcmFjdGVyEgoKAmlkGAEgASgJ",
            "EgwKBG5hbWUYAiABKAkSEQoJaXNfYWN0aXZlGAMgASgIEi8KC3VwZGF0ZV90",
            "aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIqCghwb3Np",
            "dGlvbhgFIAEoCzIYLnByb3RvLkNoYXJhY3Rlci5WZWN0b3IzEioKCHJvdGF0",
            "aW9uGAYgASgLMhgucHJvdG8uQ2hhcmFjdGVyLlZlY3RvcjMaKgoHVmVjdG9y",
            "MxIJCgF4GAEgASgCEgkKAXkYAiABKAISCQoBehgDIAEoAiqwAQoUQ29ubmVj",
            "dGlvblN0YXR1c0VudW0SGgoWQ09OTkVDVElPTl9VTlNQRUNJRklFRBAAEg4K",
            "CkNPTk5FQ1RJTkcQARINCglDT05ORUNURUQQAhIaChZESVNDT05ORUNURURf",
            "QllfQ0xJRU5UEAMSGgoWRElTQ09OTkVDVEVEX0JZX1NFUlZFUhAEEhAKDERJ",
            "U0NPTk5FQ1RFRBAFEhMKD0NPTk5FQ1RJT05fRkFJTBAGQjxaOmdpdGh1Yi5j",
            "b20vQ0EyMi1nYW1lLWNyZWF0b3JzL2Nvb2tpbmdib21iLXByb3RvL3Byb3Rv",
            "L2dhbWViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Proto.ConnectionStatusEnum), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Character), global::Proto.Character.Parser, new[]{ "Id", "Name", "IsActive", "UpdateTime", "Position", "Rotation" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Character.Types.Vector3), global::Proto.Character.Types.Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Enums
  public enum ConnectionStatusEnum {
    /// <summary>
    ///初期値 正常でない値 接続できていないと考えて良い
    /// </summary>
    [pbr::OriginalName("CONNECTION_UNSPECIFIED")] ConnectionUnspecified = 0,
    /// <summary>
    ///接続を試行中 
    /// </summary>
    [pbr::OriginalName("CONNECTING")] Connecting = 1,
    /// <summary>
    ///接続済み 各種APIにアクセスする準備が整っている
    /// </summary>
    [pbr::OriginalName("CONNECTED")] Connected = 2,
    /// <summary>
    ///クライアント側からの要求によって、切断された
    /// </summary>
    [pbr::OriginalName("DISCONNECTED_BY_CLIENT")] DisconnectedByClient = 3,
    /// <summary>
    ///ゲーム終了等の理由により、サーバー側から切断された
    /// </summary>
    [pbr::OriginalName("DISCONNECTED_BY_SERVER")] DisconnectedByServer = 4,
    /// <summary>
    ///上記以外の理由により、切断された
    /// </summary>
    [pbr::OriginalName("DISCONNECTED")] Disconnected = 5,
    /// <summary>
    ///CONNECTINGから遷移する 接続要求は失敗した
    /// </summary>
    [pbr::OriginalName("CONNECTION_FAIL")] ConnectionFail = 6,
  }

  #endregion

  #region Messages
  public sealed partial class Character : pb::IMessage<Character>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Character> _parser = new pb::MessageParser<Character>(() => new Character());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Character> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Character() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Character(Character other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      isActive_ = other.isActive_;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Character Clone() {
      return new Character(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_active" field.</summary>
    public const int IsActiveFieldNumber = 3;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 5;
    private global::Proto.Character.Types.Vector3 position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Character.Types.Vector3 Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 6;
    private global::Proto.Character.Types.Vector3 rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Character.Types.Vector3 Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Character);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Character other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (IsActive != other.IsActive) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (IsActive != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsActive);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (position_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Rotation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (IsActive != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsActive);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateTime);
      }
      if (position_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Rotation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (IsActive != false) {
        size += 1 + 1;
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Character other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Proto.Character.Types.Vector3();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::Proto.Character.Types.Vector3();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            IsActive = input.ReadBool();
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 42: {
            if (position_ == null) {
              Position = new global::Proto.Character.Types.Vector3();
            }
            input.ReadMessage(Position);
            break;
          }
          case 50: {
            if (rotation_ == null) {
              Rotation = new global::Proto.Character.Types.Vector3();
            }
            input.ReadMessage(Rotation);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            IsActive = input.ReadBool();
            break;
          }
          case 34: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 42: {
            if (position_ == null) {
              Position = new global::Proto.Character.Types.Vector3();
            }
            input.ReadMessage(Position);
            break;
          }
          case 50: {
            if (rotation_ == null) {
              Rotation = new global::Proto.Character.Types.Vector3();
            }
            input.ReadMessage(Rotation);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Character message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Vector3 : pb::IMessage<Vector3>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Proto.Character.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Vector3() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Vector3(Vector3 other) : this() {
          x_ = other.x_;
          y_ = other.y_;
          z_ = other.z_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Vector3 Clone() {
          return new Vector3(this);
        }

        /// <summary>Field number for the "x" field.</summary>
        public const int XFieldNumber = 1;
        private float x_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float X {
          get { return x_; }
          set {
            x_ = value;
          }
        }

        /// <summary>Field number for the "y" field.</summary>
        public const int YFieldNumber = 2;
        private float y_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Y {
          get { return y_; }
          set {
            y_ = value;
          }
        }

        /// <summary>Field number for the "z" field.</summary>
        public const int ZFieldNumber = 3;
        private float z_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Z {
          get { return z_; }
          set {
            z_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Vector3);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Vector3 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
          if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
          if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (X != 0F) {
            output.WriteRawTag(13);
            output.WriteFloat(X);
          }
          if (Y != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(Y);
          }
          if (Z != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Z);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (X != 0F) {
            output.WriteRawTag(13);
            output.WriteFloat(X);
          }
          if (Y != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(Y);
          }
          if (Z != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Z);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (X != 0F) {
            size += 1 + 4;
          }
          if (Y != 0F) {
            size += 1 + 4;
          }
          if (Z != 0F) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Vector3 other) {
          if (other == null) {
            return;
          }
          if (other.X != 0F) {
            X = other.X;
          }
          if (other.Y != 0F) {
            Y = other.Y;
          }
          if (other.Z != 0F) {
            Z = other.Z;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 13: {
                X = input.ReadFloat();
                break;
              }
              case 21: {
                Y = input.ReadFloat();
                break;
              }
              case 29: {
                Z = input.ReadFloat();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 13: {
                X = input.ReadFloat();
                break;
              }
              case 21: {
                Y = input.ReadFloat();
                break;
              }
              case 29: {
                Z = input.ReadFloat();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
