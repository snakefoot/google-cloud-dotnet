// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/webhook.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Dialogflow.Cx.V3 {
  /// <summary>
  /// Service for managing [Webhooks][google.cloud.dialogflow.cx.v3.Webhook].
  /// </summary>
  public static partial class Webhooks
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.Webhooks";

    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListWebhooksRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListWebhooksResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetWebhookRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> __Marshaller_google_cloud_dialogflow_cx_v3_Webhook = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.Webhook.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest> __Marshaller_google_cloud_dialogflow_cx_v3_CreateWebhookRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest> __Marshaller_google_cloud_dialogflow_cx_v3_UpdateWebhookRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest> __Marshaller_google_cloud_dialogflow_cx_v3_DeleteWebhookRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse> __Method_ListWebhooks = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListWebhooks",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListWebhooksRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListWebhooksResponse);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook> __Method_GetWebhook = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWebhook",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetWebhookRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Webhook);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook> __Method_CreateWebhook = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateWebhook",
        __Marshaller_google_cloud_dialogflow_cx_v3_CreateWebhookRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Webhook);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook> __Method_UpdateWebhook = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateWebhook",
        __Marshaller_google_cloud_dialogflow_cx_v3_UpdateWebhookRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Webhook);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteWebhook = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteWebhook",
        __Marshaller_google_cloud_dialogflow_cx_v3_DeleteWebhookRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.WebhookReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Webhooks</summary>
    [grpc::BindServiceMethod(typeof(Webhooks), "BindService")]
    public abstract partial class WebhooksBase
    {
      /// <summary>
      /// Returns the list of all webhooks in the specified agent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse> ListWebhooks(global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified webhook.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> GetWebhook(global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a webhook in the specified agent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> CreateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified webhook.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> UpdateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified webhook.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWebhook(global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Webhooks</summary>
    public partial class WebhooksClient : grpc::ClientBase<WebhooksClient>
    {
      /// <summary>Creates a new client for Webhooks</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WebhooksClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Webhooks that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WebhooksClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WebhooksClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WebhooksClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all webhooks in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse ListWebhooks(global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWebhooks(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all webhooks in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse ListWebhooks(global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListWebhooks, null, options, request);
      }
      /// <summary>
      /// Returns the list of all webhooks in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse> ListWebhooksAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWebhooksAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all webhooks in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse> ListWebhooksAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListWebhooks, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook GetWebhook(global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWebhook(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook GetWebhook(global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWebhook, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> GetWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWebhookAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> GetWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWebhook, null, options, request);
      }
      /// <summary>
      /// Creates a webhook in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook CreateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWebhook(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a webhook in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook CreateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateWebhook, null, options, request);
      }
      /// <summary>
      /// Creates a webhook in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> CreateWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWebhookAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a webhook in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> CreateWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateWebhook, null, options, request);
      }
      /// <summary>
      /// Updates the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook UpdateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWebhook(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Webhook UpdateWebhook(global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateWebhook, null, options, request);
      }
      /// <summary>
      /// Updates the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> UpdateWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWebhookAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Webhook> UpdateWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateWebhook, null, options, request);
      }
      /// <summary>
      /// Deletes the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteWebhook(global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWebhook(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteWebhook(global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteWebhook, null, options, request);
      }
      /// <summary>
      /// Deletes the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWebhookAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified webhook.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWebhookAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteWebhook, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WebhooksClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WebhooksClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WebhooksBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListWebhooks, serviceImpl.ListWebhooks)
          .AddMethod(__Method_GetWebhook, serviceImpl.GetWebhook)
          .AddMethod(__Method_CreateWebhook, serviceImpl.CreateWebhook)
          .AddMethod(__Method_UpdateWebhook, serviceImpl.UpdateWebhook)
          .AddMethod(__Method_DeleteWebhook, serviceImpl.DeleteWebhook).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WebhooksBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListWebhooks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListWebhooksResponse>(serviceImpl.ListWebhooks));
      serviceBinder.AddMethod(__Method_GetWebhook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(serviceImpl.GetWebhook));
      serviceBinder.AddMethod(__Method_CreateWebhook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.CreateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(serviceImpl.CreateWebhook));
      serviceBinder.AddMethod(__Method_UpdateWebhook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.UpdateWebhookRequest, global::Google.Cloud.Dialogflow.Cx.V3.Webhook>(serviceImpl.UpdateWebhook));
      serviceBinder.AddMethod(__Method_DeleteWebhook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.DeleteWebhookRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteWebhook));
    }

  }
}
#endregion
