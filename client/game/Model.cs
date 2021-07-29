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
namespace Proto.Game {

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
            "YnVmL3RpbWVzdGFtcC5wcm90bxoacHJvdG8vZ2FtZS9zdHJ1Y3R1cmUucHJv",
            "dG8iMgoKQ2hhcmFjdGVycxIkCgpjaGFyYWN0ZXJzGAEgAygLMhAucHJvdG8u",
            "Q2hhcmFjdGVyIsQBCglDaGFyYWN0ZXISCgoCaWQYASABKAkSEQoJaXNfYWN0",
            "aXZlGAIgASgIEiEKCHBvc2l0aW9uGAMgASgLMg8ucHJvdG8uUG9zaXRpb24S",
            "IQoIcm90YXRpb24YBCABKAsyDy5wcm90by5Sb3RhdGlvbhIhCgh2ZXJvY2l0",
            "eRgFIAEoCzIPLnByb3RvLlZlcm9jaXR5Ei8KC3VwZGF0ZV90aW1lGAYgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcCqwAQoUQ29ubmVjdGlvblN0",
            "YXR1c0VudW0SGgoWQ09OTkVDVElPTl9VTlNQRUNJRklFRBAAEg4KCkNPTk5F",
            "Q1RJTkcQARINCglDT05ORUNURUQQAhIaChZESVNDT05ORUNURURfQllfQ0xJ",
            "RU5UEAMSGgoWRElTQ09OTkVDVEVEX0JZX1NFUlZFUhAEEhAKDERJU0NPTk5F",
            "Q1RFRBAFEhMKD0NPTk5FQ1RJT05fRkFJTBAGQklaOmdpdGh1Yi5jb20vQ0Ey",
            "Mi1nYW1lLWNyZWF0b3JzL2Nvb2tpbmdib21iLXByb3RvL3Byb3RvL2dhbWWq",
            "AgpQcm90by5HYW1lYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Proto.Game.StructureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Proto.Game.ConnectionStatusEnum), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Game.Characters), global::Proto.Game.Characters.Parser, new[]{ "Characters_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Game.Character), global::Proto.Game.Character.Parser, new[]{ "Id", "IsActive", "Position", "Rotation", "Verocity", "UpdateTime" }, null, null, null, null)
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
  public sealed partial class Characters : pb::IMessage<Characters>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Characters> _parser = new pb::MessageParser<Characters>(() => new Characters());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Characters> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.Game.ModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Characters() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Characters(Characters other) : this() {
      characters_ = other.characters_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Characters Clone() {
      return new Characters(this);
    }

    /// <summary>Field number for the "characters" field.</summary>
    public const int Characters_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Proto.Game.Character> _repeated_characters_codec
        = pb::FieldCodec.ForMessage(10, global::Proto.Game.Character.Parser);
    private readonly pbc::RepeatedField<global::Proto.Game.Character> characters_ = new pbc::RepeatedField<global::Proto.Game.Character>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Proto.Game.Character> Characters_ {
      get { return characters_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Characters);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Characters other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!characters_.Equals(other.characters_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= characters_.GetHashCode();
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
      characters_.WriteTo(output, _repeated_characters_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      characters_.WriteTo(ref output, _repeated_characters_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += characters_.CalculateSize(_repeated_characters_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Characters other) {
      if (other == null) {
        return;
      }
      characters_.Add(other.characters_);
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
            characters_.AddEntriesFrom(input, _repeated_characters_codec);
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
            characters_.AddEntriesFrom(ref input, _repeated_characters_codec);
            break;
          }
        }
      }
    }
    #endif

  }

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
      get { return global::Proto.Game.ModelReflection.Descriptor.MessageTypes[1]; }
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
      isActive_ = other.isActive_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      verocity_ = other.verocity_ != null ? other.verocity_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
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

    /// <summary>Field number for the "is_active" field.</summary>
    public const int IsActiveFieldNumber = 2;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 3;
    private global::Proto.Game.Position position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Game.Position Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 4;
    private global::Proto.Game.Rotation rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Game.Rotation Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "verocity" field.</summary>
    public const int VerocityFieldNumber = 5;
    private global::Proto.Game.Verocity verocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Game.Verocity Verocity {
      get { return verocity_; }
      set {
        verocity_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
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
      if (IsActive != other.IsActive) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (!object.Equals(Verocity, other.Verocity)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (verocity_ != null) hash ^= Verocity.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
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
      if (IsActive != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsActive);
      }
      if (position_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Rotation);
      }
      if (verocity_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Verocity);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
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
      if (IsActive != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsActive);
      }
      if (position_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Position);
      }
      if (rotation_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Rotation);
      }
      if (verocity_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Verocity);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(UpdateTime);
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
      if (IsActive != false) {
        size += 1 + 1;
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (verocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Verocity);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
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
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Proto.Game.Position();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::Proto.Game.Rotation();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.verocity_ != null) {
        if (verocity_ == null) {
          Verocity = new global::Proto.Game.Verocity();
        }
        Verocity.MergeFrom(other.Verocity);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
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
          case 16: {
            IsActive = input.ReadBool();
            break;
          }
          case 26: {
            if (position_ == null) {
              Position = new global::Proto.Game.Position();
            }
            input.ReadMessage(Position);
            break;
          }
          case 34: {
            if (rotation_ == null) {
              Rotation = new global::Proto.Game.Rotation();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 42: {
            if (verocity_ == null) {
              Verocity = new global::Proto.Game.Verocity();
            }
            input.ReadMessage(Verocity);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
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
          case 16: {
            IsActive = input.ReadBool();
            break;
          }
          case 26: {
            if (position_ == null) {
              Position = new global::Proto.Game.Position();
            }
            input.ReadMessage(Position);
            break;
          }
          case 34: {
            if (rotation_ == null) {
              Rotation = new global::Proto.Game.Rotation();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 42: {
            if (verocity_ == null) {
              Verocity = new global::Proto.Game.Verocity();
            }
            input.ReadMessage(Verocity);
            break;
          }
          case 50: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
