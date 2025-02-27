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
    /// AccountStoreLevelService Interface
    /// </summary>
    public interface IAccountStoreLevelService
    {
        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference"><see cref="string"/> - The reference of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListStoresResponse"/>.</returns>
        Model.Management.ListStoresResponse ListStoresByMerchantId(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference"><see cref="string"/> - The reference of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListStoresResponse"/>.</returns>
        Task<Model.Management.ListStoresResponse> ListStoresByMerchantIdAsync(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store GetStore(string merchantId, string storeId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> GetStoreAsync(string merchantId, string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference"><see cref="string"/> - The reference of the store.</param>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListStoresResponse"/>.</returns>
        Model.Management.ListStoresResponse ListStores(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of stores
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="reference"><see cref="string"/> - The reference of the store.</param>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListStoresResponse"/>.</returns>
        Task<Model.Management.ListStoresResponse> ListStoresAsync(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store GetStoreById(string storeId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a store
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> GetStoreByIdAsync(string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"><see cref="UpdateStoreRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store UpdateStore(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"><see cref="UpdateStoreRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> UpdateStoreAsync(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"><see cref="UpdateStoreRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store UpdateStoreById(string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a store
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="updateStoreRequest"><see cref="UpdateStoreRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> UpdateStoreByIdAsync(string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"><see cref="StoreCreationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store CreateStoreByMerchantId(string merchantId, StoreCreationRequest storeCreationRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="storeCreationRequest"><see cref="StoreCreationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> CreateStoreByMerchantIdAsync(string merchantId, StoreCreationRequest storeCreationRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="storeCreationWithMerchantCodeRequest"><see cref="StoreCreationWithMerchantCodeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Store"/>.</returns>
        Model.Management.Store CreateStore(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a store
        /// </summary>
        /// <param name="storeCreationWithMerchantCodeRequest"><see cref="StoreCreationWithMerchantCodeRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Store"/>.</returns>
        Task<Model.Management.Store> CreateStoreAsync(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the AccountStoreLevelService API endpoints
    /// </summary>
    public class AccountStoreLevelService : AbstractService, IAccountStoreLevelService
    {
        private readonly string _baseUrl;
        
        public AccountStoreLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.ListStoresResponse ListStoresByMerchantId(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default)
        {
            return ListStoresByMerchantIdAsync(merchantId, pageNumber, pageSize, reference, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ListStoresResponse> ListStoresByMerchantIdAsync(string merchantId, int? pageNumber = default, int? pageSize = default, string reference = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (reference != null) queryParams.Add("reference", reference);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ListStoresResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store GetStore(string merchantId, string storeId, RequestOptions requestOptions = default)
        {
            return GetStoreAsync(merchantId, storeId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> GetStoreAsync(string merchantId, string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{storeId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.ListStoresResponse ListStores(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default)
        {
            return ListStoresAsync(pageNumber, pageSize, reference, merchantId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ListStoresResponse> ListStoresAsync(int? pageNumber = default, int? pageSize = default, string reference = default, string merchantId = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (reference != null) queryParams.Add("reference", reference);
            if (merchantId != null) queryParams.Add("merchantId", merchantId);
            var endpoint = _baseUrl + "/stores" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ListStoresResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store GetStoreById(string storeId, RequestOptions requestOptions = default)
        {
            return GetStoreByIdAsync(storeId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> GetStoreByIdAsync(string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/stores/{storeId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store UpdateStore(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default)
        {
            return UpdateStoreAsync(merchantId, storeId, updateStoreRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> UpdateStoreAsync(string merchantId, string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{storeId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(updateStoreRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store UpdateStoreById(string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default)
        {
            return UpdateStoreByIdAsync(storeId, updateStoreRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> UpdateStoreByIdAsync(string storeId, UpdateStoreRequest updateStoreRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/stores/{storeId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(updateStoreRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store CreateStoreByMerchantId(string merchantId, StoreCreationRequest storeCreationRequest = default, RequestOptions requestOptions = default)
        {
            return CreateStoreByMerchantIdAsync(merchantId, storeCreationRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> CreateStoreByMerchantIdAsync(string merchantId, StoreCreationRequest storeCreationRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(storeCreationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.Store CreateStore(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest = default, RequestOptions requestOptions = default)
        {
            return CreateStoreAsync(storeCreationWithMerchantCodeRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.Store> CreateStoreAsync(StoreCreationWithMerchantCodeRequest storeCreationWithMerchantCodeRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/stores";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.Store>(storeCreationWithMerchantCodeRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}