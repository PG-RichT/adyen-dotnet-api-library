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
    /// TerminalsTerminalLevelService Interface
    /// </summary>
    public interface ITerminalsTerminalLevelService
    {
        /// <summary>
        /// Get a list of terminals
        /// </summary>
        /// <param name="searchQuery"><see cref="string"/> - Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored.</param>
        /// <param name="otpQuery"><see cref="string"/> - Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored.</param>
        /// <param name="countries"><see cref="string"/> - Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).</param>
        /// <param name="merchantIds"><see cref="string"/> - Returns terminals that belong to the merchant accounts specified by their unique merchant account ID.</param>
        /// <param name="storeIds"><see cref="string"/> - Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID.</param>
        /// <param name="brandModels"><see cref="string"/> - Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListTerminalsResponse"/>.</returns>
        Model.Management.ListTerminalsResponse ListTerminals(string searchQuery = default, string otpQuery = default, string countries = default, string merchantIds = default, string storeIds = default, string brandModels = default, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of terminals
        /// </summary>
        /// <param name="searchQuery"><see cref="string"/> - Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored.</param>
        /// <param name="otpQuery"><see cref="string"/> - Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored.</param>
        /// <param name="countries"><see cref="string"/> - Returns terminals located in the countries specified by their [two-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).</param>
        /// <param name="merchantIds"><see cref="string"/> - Returns terminals that belong to the merchant accounts specified by their unique merchant account ID.</param>
        /// <param name="storeIds"><see cref="string"/> - Returns terminals that are assigned to the [stores](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores) specified by their unique store ID.</param>
        /// <param name="brandModels"><see cref="string"/> - Returns terminals of the [models](https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels) specified in the format *brand.model*.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListTerminalsResponse"/>.</returns>
        Task<Model.Management.ListTerminalsResponse> ListTerminalsAsync(string searchQuery = default, string otpQuery = default, string countries = default, string merchantIds = default, string storeIds = default, string brandModels = default, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TerminalsTerminalLevelService API endpoints
    /// </summary>
    public class TerminalsTerminalLevelService : AbstractService, ITerminalsTerminalLevelService
    {
        private readonly string _baseUrl;
        
        public TerminalsTerminalLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.ListTerminalsResponse ListTerminals(string searchQuery = default, string otpQuery = default, string countries = default, string merchantIds = default, string storeIds = default, string brandModels = default, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListTerminalsAsync(searchQuery, otpQuery, countries, merchantIds, storeIds, brandModels, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ListTerminalsResponse> ListTerminalsAsync(string searchQuery = default, string otpQuery = default, string countries = default, string merchantIds = default, string storeIds = default, string brandModels = default, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (searchQuery != null) queryParams.Add("searchQuery", searchQuery);
            if (otpQuery != null) queryParams.Add("otpQuery", otpQuery);
            if (countries != null) queryParams.Add("countries", countries);
            if (merchantIds != null) queryParams.Add("merchantIds", merchantIds);
            if (storeIds != null) queryParams.Add("storeIds", storeIds);
            if (brandModels != null) queryParams.Add("brandModels", brandModels);
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + "/terminals" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ListTerminalsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
    }
}