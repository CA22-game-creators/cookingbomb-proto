// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/api/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Proto.Api {
  public static partial class AccountServices
  {
    static readonly string __ServiceName = "proto.AccountServices";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Proto.Api.SignupRequest> __Marshaller_proto_SignupRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.SignupRequest.Parser));
    static readonly grpc::Marshaller<global::Proto.Api.SignupResponse> __Marshaller_proto_SignupResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.SignupResponse.Parser));
    static readonly grpc::Marshaller<global::Proto.Api.GetSessionTokenRequest> __Marshaller_proto_GetSessionTokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.GetSessionTokenRequest.Parser));
    static readonly grpc::Marshaller<global::Proto.Api.GetSessionTokenResponse> __Marshaller_proto_GetSessionTokenResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.GetSessionTokenResponse.Parser));
    static readonly grpc::Marshaller<global::Proto.Api.GetAccountInfoRequest> __Marshaller_proto_GetAccountInfoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.GetAccountInfoRequest.Parser));
    static readonly grpc::Marshaller<global::Proto.Api.GetAccountInfoResponse> __Marshaller_proto_GetAccountInfoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Proto.Api.GetAccountInfoResponse.Parser));

    static readonly grpc::Method<global::Proto.Api.SignupRequest, global::Proto.Api.SignupResponse> __Method_Signup = new grpc::Method<global::Proto.Api.SignupRequest, global::Proto.Api.SignupResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Signup",
        __Marshaller_proto_SignupRequest,
        __Marshaller_proto_SignupResponse);

    static readonly grpc::Method<global::Proto.Api.GetSessionTokenRequest, global::Proto.Api.GetSessionTokenResponse> __Method_GetSessionToken = new grpc::Method<global::Proto.Api.GetSessionTokenRequest, global::Proto.Api.GetSessionTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSessionToken",
        __Marshaller_proto_GetSessionTokenRequest,
        __Marshaller_proto_GetSessionTokenResponse);

    static readonly grpc::Method<global::Proto.Api.GetAccountInfoRequest, global::Proto.Api.GetAccountInfoResponse> __Method_GetAccountInfo = new grpc::Method<global::Proto.Api.GetAccountInfoRequest, global::Proto.Api.GetAccountInfoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountInfo",
        __Marshaller_proto_GetAccountInfoRequest,
        __Marshaller_proto_GetAccountInfoResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Proto.Api.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountServices</summary>
    [grpc::BindServiceMethod(typeof(AccountServices), "BindService")]
    public abstract partial class AccountServicesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Proto.Api.SignupResponse> Signup(global::Proto.Api.SignupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Proto.Api.GetSessionTokenResponse> GetSessionToken(global::Proto.Api.GetSessionTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Proto.Api.GetAccountInfoResponse> GetAccountInfo(global::Proto.Api.GetAccountInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountServices</summary>
    public partial class AccountServicesClient : grpc::ClientBase<AccountServicesClient>
    {
      /// <summary>Creates a new client for AccountServices</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountServicesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountServices that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountServicesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountServicesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountServicesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Proto.Api.SignupResponse Signup(global::Proto.Api.SignupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Signup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.Api.SignupResponse Signup(global::Proto.Api.SignupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Signup, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.SignupResponse> SignupAsync(global::Proto.Api.SignupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.SignupResponse> SignupAsync(global::Proto.Api.SignupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Signup, null, options, request);
      }
      public virtual global::Proto.Api.GetSessionTokenResponse GetSessionToken(global::Proto.Api.GetSessionTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSessionToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.Api.GetSessionTokenResponse GetSessionToken(global::Proto.Api.GetSessionTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSessionToken, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.GetSessionTokenResponse> GetSessionTokenAsync(global::Proto.Api.GetSessionTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSessionTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.GetSessionTokenResponse> GetSessionTokenAsync(global::Proto.Api.GetSessionTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSessionToken, null, options, request);
      }
      public virtual global::Proto.Api.GetAccountInfoResponse GetAccountInfo(global::Proto.Api.GetAccountInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Proto.Api.GetAccountInfoResponse GetAccountInfo(global::Proto.Api.GetAccountInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccountInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.GetAccountInfoResponse> GetAccountInfoAsync(global::Proto.Api.GetAccountInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Proto.Api.GetAccountInfoResponse> GetAccountInfoAsync(global::Proto.Api.GetAccountInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccountInfo, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccountServicesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountServicesClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AccountServicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Signup, serviceImpl.Signup)
          .AddMethod(__Method_GetSessionToken, serviceImpl.GetSessionToken)
          .AddMethod(__Method_GetAccountInfo, serviceImpl.GetAccountInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountServicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Signup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.Api.SignupRequest, global::Proto.Api.SignupResponse>(serviceImpl.Signup));
      serviceBinder.AddMethod(__Method_GetSessionToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.Api.GetSessionTokenRequest, global::Proto.Api.GetSessionTokenResponse>(serviceImpl.GetSessionToken));
      serviceBinder.AddMethod(__Method_GetAccountInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Proto.Api.GetAccountInfoRequest, global::Proto.Api.GetAccountInfoResponse>(serviceImpl.GetAccountInfo));
    }

  }
}
#endregion
