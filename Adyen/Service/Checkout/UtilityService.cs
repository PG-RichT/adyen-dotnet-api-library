/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using Adyen.Model.Checkout;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// UtilityService Interface
    /// </summary>
    public interface IUtilityService
    {
        /// <summary>
        /// Get an Apple Pay session
        /// </summary>
        /// <param name="applePaySessionRequest"><see cref="ApplePaySessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ApplePaySessionResponse"/>.</returns>
        Model.Checkout.ApplePaySessionResponse GetApplePaySession(ApplePaySessionRequest applePaySessionRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get an Apple Pay session
        /// </summary>
        /// <param name="applePaySessionRequest"><see cref="ApplePaySessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ApplePaySessionResponse"/>.</returns>
        Task<Model.Checkout.ApplePaySessionResponse> GetApplePaySessionAsync(ApplePaySessionRequest applePaySessionRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create originKey values for domains
        /// </summary>
        /// <param name="utilityRequest"><see cref="UtilityRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="UtilityResponse"/>.</returns>
        [Obsolete]
        Model.Checkout.UtilityResponse OriginKeys(UtilityRequest utilityRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create originKey values for domains
        /// </summary>
        /// <param name="utilityRequest"><see cref="UtilityRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="UtilityResponse"/>.</returns>
        [Obsolete]
        Task<Model.Checkout.UtilityResponse> OriginKeysAsync(UtilityRequest utilityRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the UtilityService API endpoints
    /// </summary>
    public class UtilityService : AbstractService, IUtilityService
    {
        private readonly string _baseUrl;
        
        public UtilityService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v70");
        }
        
        public Model.Checkout.ApplePaySessionResponse GetApplePaySession(ApplePaySessionRequest applePaySessionRequest = default, RequestOptions requestOptions = default)
        {
            return GetApplePaySessionAsync(applePaySessionRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.ApplePaySessionResponse> GetApplePaySessionAsync(ApplePaySessionRequest applePaySessionRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/applePay/sessions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.ApplePaySessionResponse>(applePaySessionRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        [Obsolete]
        public Model.Checkout.UtilityResponse OriginKeys(UtilityRequest utilityRequest = default, RequestOptions requestOptions = default)
        {
            return OriginKeysAsync(utilityRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        [Obsolete]
        public async Task<Model.Checkout.UtilityResponse> OriginKeysAsync(UtilityRequest utilityRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/originKeys";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.UtilityResponse>(utilityRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}