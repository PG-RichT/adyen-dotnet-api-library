/*
* Management API
*
*
* The version of the OpenAPI document: 1
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// ClientKeyMerchantLevelService Interface
    /// </summary>
    public interface IClientKeyMerchantLevelService
    {
        /// <summary>
        /// Generate new client key
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GenerateClientKeyResponse"/>.</returns>
        Model.Management.GenerateClientKeyResponse GenerateNewClientKey(string merchantId, string apiCredentialId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Generate new client key
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId"><see cref="string"/> - Unique identifier of the API credential.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GenerateClientKeyResponse"/>.</returns>
        Task<Model.Management.GenerateClientKeyResponse> GenerateNewClientKeyAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the ClientKeyMerchantLevelService API endpoints
    /// </summary>
    public class ClientKeyMerchantLevelService : AbstractService, IClientKeyMerchantLevelService
    {
        private readonly string _baseUrl;
        
        public ClientKeyMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.GenerateClientKeyResponse GenerateNewClientKey(string merchantId, string apiCredentialId, RequestOptions requestOptions = default)
        {
            return GenerateNewClientKeyAsync(merchantId, apiCredentialId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.GenerateClientKeyResponse> GenerateNewClientKeyAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateClientKey";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.GenerateClientKeyResponse>(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}