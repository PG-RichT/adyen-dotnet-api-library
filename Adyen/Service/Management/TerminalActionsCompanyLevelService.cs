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
    /// TerminalActionsCompanyLevelService Interface
    /// </summary>
    public interface ITerminalActionsCompanyLevelService
    {
        /// <summary>
        /// Get a list of terminal actions
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="status"><see cref="string"/> - Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**.</param>
        /// <param name="type"><see cref="string"/> - Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListExternalTerminalActionsResponse"/>.</returns>
        Model.Management.ListExternalTerminalActionsResponse ListTerminalActions(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of terminal actions
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
        /// <param name="status"><see cref="string"/> - Returns terminal actions with the specified status.  Allowed values: **pending**, **successful**, **failed**, **cancelled**, **tryLater**.</param>
        /// <param name="type"><see cref="string"/> - Returns terminal actions of the specified type.  Allowed values: **InstallAndroidApp**, **UninstallAndroidApp**, **InstallAndroidCertificate**, **UninstallAndroidCertificate**.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListExternalTerminalActionsResponse"/>.</returns>
        Task<Model.Management.ListExternalTerminalActionsResponse> ListTerminalActionsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get terminal action
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="actionId"><see cref="string"/> - The unique identifier of the terminal action.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ExternalTerminalAction"/>.</returns>
        Model.Management.ExternalTerminalAction GetTerminalAction(string companyId, string actionId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get terminal action
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="actionId"><see cref="string"/> - The unique identifier of the terminal action.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ExternalTerminalAction"/>.</returns>
        Task<Model.Management.ExternalTerminalAction> GetTerminalActionAsync(string companyId, string actionId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TerminalActionsCompanyLevelService API endpoints
    /// </summary>
    public class TerminalActionsCompanyLevelService : AbstractService, ITerminalActionsCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public TerminalActionsCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.ListExternalTerminalActionsResponse ListTerminalActions(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default)
        {
            return ListTerminalActionsAsync(companyId, pageNumber, pageSize, status, type, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ListExternalTerminalActionsResponse> ListTerminalActionsAsync(string companyId, int? pageNumber = default, int? pageSize = default, string status = default, string type = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (status != null) queryParams.Add("status", status);
            if (type != null) queryParams.Add("type", type);
            var endpoint = _baseUrl + $"/companies/{companyId}/terminalActions" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ListExternalTerminalActionsResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.ExternalTerminalAction GetTerminalAction(string companyId, string actionId, RequestOptions requestOptions = default)
        {
            return GetTerminalActionAsync(companyId, actionId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ExternalTerminalAction> GetTerminalActionAsync(string companyId, string actionId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/terminalActions/{actionId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ExternalTerminalAction>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
    }
}