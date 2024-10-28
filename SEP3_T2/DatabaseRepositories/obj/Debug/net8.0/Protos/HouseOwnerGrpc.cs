// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/HouseOwner.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DatabaseRepositories {
  public static partial class HouseOwnerService
  {
    static readonly string __ServiceName = "en.via.sep3_t3.HouseOwnerService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatabaseRepositories.HouseOwnerRequest> __Marshaller_en_via_sep3_t3_HouseOwnerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatabaseRepositories.HouseOwnerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatabaseRepositories.HouseOwnerResponse> __Marshaller_en_via_sep3_t3_HouseOwnerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatabaseRepositories.HouseOwnerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatabaseRepositories.CreateHouseOwnerRequest> __Marshaller_en_via_sep3_t3_CreateHouseOwnerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatabaseRepositories.CreateHouseOwnerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::DatabaseRepositories.UpdateHouseOwnerRequest> __Marshaller_en_via_sep3_t3_UpdateHouseOwnerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::DatabaseRepositories.UpdateHouseOwnerRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatabaseRepositories.HouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse> __Method_GetHouseOwner = new grpc::Method<global::DatabaseRepositories.HouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetHouseOwner",
        __Marshaller_en_via_sep3_t3_HouseOwnerRequest,
        __Marshaller_en_via_sep3_t3_HouseOwnerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatabaseRepositories.CreateHouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse> __Method_CreateHouseOwner = new grpc::Method<global::DatabaseRepositories.CreateHouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateHouseOwner",
        __Marshaller_en_via_sep3_t3_CreateHouseOwnerRequest,
        __Marshaller_en_via_sep3_t3_HouseOwnerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatabaseRepositories.UpdateHouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse> __Method_UpdateHouseOwner = new grpc::Method<global::DatabaseRepositories.UpdateHouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateHouseOwner",
        __Marshaller_en_via_sep3_t3_UpdateHouseOwnerRequest,
        __Marshaller_en_via_sep3_t3_HouseOwnerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::DatabaseRepositories.HouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse> __Method_DeleteHouseOwner = new grpc::Method<global::DatabaseRepositories.HouseOwnerRequest, global::DatabaseRepositories.HouseOwnerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteHouseOwner",
        __Marshaller_en_via_sep3_t3_HouseOwnerRequest,
        __Marshaller_en_via_sep3_t3_HouseOwnerResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DatabaseRepositories.HouseOwnerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for HouseOwnerService</summary>
    public partial class HouseOwnerServiceClient : grpc::ClientBase<HouseOwnerServiceClient>
    {
      /// <summary>Creates a new client for HouseOwnerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HouseOwnerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HouseOwnerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public HouseOwnerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HouseOwnerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected HouseOwnerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse GetHouseOwner(global::DatabaseRepositories.HouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHouseOwner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse GetHouseOwner(global::DatabaseRepositories.HouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> GetHouseOwnerAsync(global::DatabaseRepositories.HouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetHouseOwnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> GetHouseOwnerAsync(global::DatabaseRepositories.HouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse CreateHouseOwner(global::DatabaseRepositories.CreateHouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHouseOwner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse CreateHouseOwner(global::DatabaseRepositories.CreateHouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> CreateHouseOwnerAsync(global::DatabaseRepositories.CreateHouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateHouseOwnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> CreateHouseOwnerAsync(global::DatabaseRepositories.CreateHouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse UpdateHouseOwner(global::DatabaseRepositories.UpdateHouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateHouseOwner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse UpdateHouseOwner(global::DatabaseRepositories.UpdateHouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> UpdateHouseOwnerAsync(global::DatabaseRepositories.UpdateHouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateHouseOwnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> UpdateHouseOwnerAsync(global::DatabaseRepositories.UpdateHouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse DeleteHouseOwner(global::DatabaseRepositories.HouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteHouseOwner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::DatabaseRepositories.HouseOwnerResponse DeleteHouseOwner(global::DatabaseRepositories.HouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteHouseOwner, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> DeleteHouseOwnerAsync(global::DatabaseRepositories.HouseOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteHouseOwnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::DatabaseRepositories.HouseOwnerResponse> DeleteHouseOwnerAsync(global::DatabaseRepositories.HouseOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteHouseOwner, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override HouseOwnerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HouseOwnerServiceClient(configuration);
      }
    }

  }
}
#endregion
