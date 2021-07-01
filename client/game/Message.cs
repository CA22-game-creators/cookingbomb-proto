// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/game/message.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from proto/game/message.proto</summary>
  public static partial class MessageReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/game/message.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhwcm90by9nYW1lL21lc3NhZ2UucHJvdG8SBXByb3RvGh9nb29nbGUvcHJv",
            "dG9idWYvdGltZXN0YW1wLnByb3RvGhZwcm90by9nYW1lL21vZGVsLnByb3Rv",
            "Ghlwcm90by9jb21tb24vb3B0aW9uLnByb3RvIpgBChFDb25uZWN0aW9uUmVx",
            "dWVzdBKCAQoMc2Vzc2lvblRva2VuGAEgASgJQmyCtRhoCkBeKFswLTlhLWZd",
            "ezh9LVswLTlhLWZdezR9LVswLTlhLWZdezR9LVswLTlhLWZdezR9LVswLTlh",
            "LWZdezEyfSkkEiRzZXNzaW9uVG9rZW7jgYzkuI3mraPjgarlvaLlvI/jgafj",
            "gZkiQQoSQ29ubmVjdGlvblJlc3BvbnNlEisKBnN0YXR1cxgBIAEoDjIbLnBy",
            "b3RvLkNvbm5lY3Rpb25TdGF0dXNFbnVtIs8BCg9HYW1lRGF0YVJlcXVlc3QS",
            "ggEKDHNlc3Npb25Ub2tlbhgBIAEoCUJsgrUYaApAXihbMC05YS1mXXs4fS1b",
            "MC05YS1mXXs0fS1bMC05YS1mXXs0fS1bMC05YS1mXXs0fS1bMC05YS1mXXsx",
            "Mn0pJBIkc2Vzc2lvblRva2Vu44GM5LiN5q2j44Gq5b2i5byP44Gn44GZEiwK",
            "EGNoYXJhY3Rlcl91cGRhdGUYAiABKAsyEC5wcm90by5DaGFyYWN0ZXJIAEIJ",
            "CgdtZXNzYWdlInwKEEdhbWVEYXRhUmVzcG9uc2USLAoPY2hhcmFjdGVyX2Rh",
            "dGFzGAEgASgLMhEucHJvdG8uQ2hhcmFjdGVyc0gAEi8KC3NlcnZlcl90aW1l",
            "GAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEIJCgdtZXNzYWdl",
            "QjxaOmdpdGh1Yi5jb20vQ0EyMi1nYW1lLWNyZWF0b3JzL2Nvb2tpbmdib21i",
            "LXByb3RvL3Byb3RvL2dhbWViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Proto.ModelReflection.Descriptor, global::Proto.OptionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ConnectionRequest), global::Proto.ConnectionRequest.Parser, new[]{ "SessionToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.ConnectionResponse), global::Proto.ConnectionResponse.Parser, new[]{ "Status" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.GameDataRequest), global::Proto.GameDataRequest.Parser, new[]{ "SessionToken", "CharacterUpdate" }, new[]{ "Message" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.GameDataResponse), global::Proto.GameDataResponse.Parser, new[]{ "CharacterDatas", "ServerTime" }, new[]{ "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ConnectionRequest : pb::IMessage<ConnectionRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConnectionRequest> _parser = new pb::MessageParser<ConnectionRequest>(() => new ConnectionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionRequest(ConnectionRequest other) : this() {
      sessionToken_ = other.sessionToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionRequest Clone() {
      return new ConnectionRequest(this);
    }

    /// <summary>Field number for the "sessionToken" field.</summary>
    public const int SessionTokenFieldNumber = 1;
    private string sessionToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SessionToken {
      get { return sessionToken_; }
      set {
        sessionToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SessionToken != other.SessionToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SessionToken.Length != 0) hash ^= SessionToken.GetHashCode();
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
      if (SessionToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SessionToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SessionToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SessionToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SessionToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SessionToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectionRequest other) {
      if (other == null) {
        return;
      }
      if (other.SessionToken.Length != 0) {
        SessionToken = other.SessionToken;
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
            SessionToken = input.ReadString();
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
            SessionToken = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ConnectionResponse : pb::IMessage<ConnectionResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConnectionResponse> _parser = new pb::MessageParser<ConnectionResponse>(() => new ConnectionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConnectionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionResponse(ConnectionResponse other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConnectionResponse Clone() {
      return new ConnectionResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Proto.ConnectionStatusEnum status_ = global::Proto.ConnectionStatusEnum.ConnectionUnspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.ConnectionStatusEnum Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConnectionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConnectionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::Proto.ConnectionStatusEnum.ConnectionUnspecified) hash ^= Status.GetHashCode();
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
      if (Status != global::Proto.ConnectionStatusEnum.ConnectionUnspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Status != global::Proto.ConnectionStatusEnum.ConnectionUnspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != global::Proto.ConnectionStatusEnum.ConnectionUnspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConnectionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::Proto.ConnectionStatusEnum.ConnectionUnspecified) {
        Status = other.Status;
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
          case 8: {
            Status = (global::Proto.ConnectionStatusEnum) input.ReadEnum();
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
          case 8: {
            Status = (global::Proto.ConnectionStatusEnum) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GameDataRequest : pb::IMessage<GameDataRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameDataRequest> _parser = new pb::MessageParser<GameDataRequest>(() => new GameDataRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameDataRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataRequest(GameDataRequest other) : this() {
      sessionToken_ = other.sessionToken_;
      switch (other.MessageCase) {
        case MessageOneofCase.CharacterUpdate:
          CharacterUpdate = other.CharacterUpdate.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataRequest Clone() {
      return new GameDataRequest(this);
    }

    /// <summary>Field number for the "sessionToken" field.</summary>
    public const int SessionTokenFieldNumber = 1;
    private string sessionToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SessionToken {
      get { return sessionToken_; }
      set {
        sessionToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "character_update" field.</summary>
    public const int CharacterUpdateFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Character CharacterUpdate {
      get { return messageCase_ == MessageOneofCase.CharacterUpdate ? (global::Proto.Character) message_ : null; }
      set {
        message_ = value;
        messageCase_ = value == null ? MessageOneofCase.None : MessageOneofCase.CharacterUpdate;
      }
    }

    private object message_;
    /// <summary>Enum of possible cases for the "message" oneof.</summary>
    public enum MessageOneofCase {
      None = 0,
      CharacterUpdate = 2,
    }
    private MessageOneofCase messageCase_ = MessageOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageOneofCase MessageCase {
      get { return messageCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMessage() {
      messageCase_ = MessageOneofCase.None;
      message_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameDataRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameDataRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SessionToken != other.SessionToken) return false;
      if (!object.Equals(CharacterUpdate, other.CharacterUpdate)) return false;
      if (MessageCase != other.MessageCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SessionToken.Length != 0) hash ^= SessionToken.GetHashCode();
      if (messageCase_ == MessageOneofCase.CharacterUpdate) hash ^= CharacterUpdate.GetHashCode();
      hash ^= (int) messageCase_;
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
      if (SessionToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SessionToken);
      }
      if (messageCase_ == MessageOneofCase.CharacterUpdate) {
        output.WriteRawTag(18);
        output.WriteMessage(CharacterUpdate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SessionToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SessionToken);
      }
      if (messageCase_ == MessageOneofCase.CharacterUpdate) {
        output.WriteRawTag(18);
        output.WriteMessage(CharacterUpdate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SessionToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SessionToken);
      }
      if (messageCase_ == MessageOneofCase.CharacterUpdate) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CharacterUpdate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameDataRequest other) {
      if (other == null) {
        return;
      }
      if (other.SessionToken.Length != 0) {
        SessionToken = other.SessionToken;
      }
      switch (other.MessageCase) {
        case MessageOneofCase.CharacterUpdate:
          if (CharacterUpdate == null) {
            CharacterUpdate = new global::Proto.Character();
          }
          CharacterUpdate.MergeFrom(other.CharacterUpdate);
          break;
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
            SessionToken = input.ReadString();
            break;
          }
          case 18: {
            global::Proto.Character subBuilder = new global::Proto.Character();
            if (messageCase_ == MessageOneofCase.CharacterUpdate) {
              subBuilder.MergeFrom(CharacterUpdate);
            }
            input.ReadMessage(subBuilder);
            CharacterUpdate = subBuilder;
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
            SessionToken = input.ReadString();
            break;
          }
          case 18: {
            global::Proto.Character subBuilder = new global::Proto.Character();
            if (messageCase_ == MessageOneofCase.CharacterUpdate) {
              subBuilder.MergeFrom(CharacterUpdate);
            }
            input.ReadMessage(subBuilder);
            CharacterUpdate = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GameDataResponse : pb::IMessage<GameDataResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameDataResponse> _parser = new pb::MessageParser<GameDataResponse>(() => new GameDataResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameDataResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.MessageReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataResponse(GameDataResponse other) : this() {
      serverTime_ = other.serverTime_ != null ? other.serverTime_.Clone() : null;
      switch (other.MessageCase) {
        case MessageOneofCase.CharacterDatas:
          CharacterDatas = other.CharacterDatas.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameDataResponse Clone() {
      return new GameDataResponse(this);
    }

    /// <summary>Field number for the "character_datas" field.</summary>
    public const int CharacterDatasFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.Characters CharacterDatas {
      get { return messageCase_ == MessageOneofCase.CharacterDatas ? (global::Proto.Characters) message_ : null; }
      set {
        message_ = value;
        messageCase_ = value == null ? MessageOneofCase.None : MessageOneofCase.CharacterDatas;
      }
    }

    /// <summary>Field number for the "server_time" field.</summary>
    public const int ServerTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp serverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    private object message_;
    /// <summary>Enum of possible cases for the "message" oneof.</summary>
    public enum MessageOneofCase {
      None = 0,
      CharacterDatas = 1,
    }
    private MessageOneofCase messageCase_ = MessageOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageOneofCase MessageCase {
      get { return messageCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMessage() {
      messageCase_ = MessageOneofCase.None;
      message_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameDataResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameDataResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CharacterDatas, other.CharacterDatas)) return false;
      if (!object.Equals(ServerTime, other.ServerTime)) return false;
      if (MessageCase != other.MessageCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (messageCase_ == MessageOneofCase.CharacterDatas) hash ^= CharacterDatas.GetHashCode();
      if (serverTime_ != null) hash ^= ServerTime.GetHashCode();
      hash ^= (int) messageCase_;
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
      if (messageCase_ == MessageOneofCase.CharacterDatas) {
        output.WriteRawTag(10);
        output.WriteMessage(CharacterDatas);
      }
      if (serverTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ServerTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (messageCase_ == MessageOneofCase.CharacterDatas) {
        output.WriteRawTag(10);
        output.WriteMessage(CharacterDatas);
      }
      if (serverTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ServerTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (messageCase_ == MessageOneofCase.CharacterDatas) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CharacterDatas);
      }
      if (serverTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ServerTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameDataResponse other) {
      if (other == null) {
        return;
      }
      if (other.serverTime_ != null) {
        if (serverTime_ == null) {
          ServerTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ServerTime.MergeFrom(other.ServerTime);
      }
      switch (other.MessageCase) {
        case MessageOneofCase.CharacterDatas:
          if (CharacterDatas == null) {
            CharacterDatas = new global::Proto.Characters();
          }
          CharacterDatas.MergeFrom(other.CharacterDatas);
          break;
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
            global::Proto.Characters subBuilder = new global::Proto.Characters();
            if (messageCase_ == MessageOneofCase.CharacterDatas) {
              subBuilder.MergeFrom(CharacterDatas);
            }
            input.ReadMessage(subBuilder);
            CharacterDatas = subBuilder;
            break;
          }
          case 18: {
            if (serverTime_ == null) {
              ServerTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ServerTime);
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
            global::Proto.Characters subBuilder = new global::Proto.Characters();
            if (messageCase_ == MessageOneofCase.CharacterDatas) {
              subBuilder.MergeFrom(CharacterDatas);
            }
            input.ReadMessage(subBuilder);
            CharacterDatas = subBuilder;
            break;
          }
          case 18: {
            if (serverTime_ == null) {
              ServerTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ServerTime);
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
