// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BodyAndPath_LowLevel
{
    /// <summary> The BodyAndPath service client. </summary>
    public partial class BodyAndPathClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private Uri endpoint;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of BodyAndPathClient for mocking. </summary>
        protected BodyAndPathClient()
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public BodyAndPathClient(AzureKeyCredential credential, Uri endpoint = null, BodyAndPathClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new BodyAndPathClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            var authPolicy = new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            apiVersion = options.Version;
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateAsync(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRequest(itemName, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Create(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateRequest(itemName, content, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateRequest(string itemName, RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemName, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateStreamAsync(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateStream(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, options);
            if (options.PerCallPolicy != null)
            {
                message.SetProperty("RequestOptionsPerCallPolicyCallback", options.PerCallPolicy);
            }
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateStreamRequest(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemNameStream, true);
            if (excluded != null)
            {
                uri.AppendQueryDelimited("excluded", excluded, ",", true);
            }
            request.Uri = uri;
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            return message;
        }
    }
}
