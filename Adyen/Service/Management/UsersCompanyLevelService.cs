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
    /// UsersCompanyLevelService Interface
    /// </summary>
    public interface IUsersCompanyLevelService
    {
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to return.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page.</param>
        /// <param name="username"><see cref="string"/> - The partial or complete username to select all users that match.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListCompanyUsersResponse"/>.</returns>
        Model.Management.ListCompanyUsersResponse ListUsers(string companyId, int? pageNumber = default, int? pageSize = default, string username = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to return.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page.</param>
        /// <param name="username"><see cref="string"/> - The partial or complete username to select all users that match.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListCompanyUsersResponse"/>.</returns>
        Task<Model.Management.ListCompanyUsersResponse> ListUsersAsync(string companyId, int? pageNumber = default, int? pageSize = default, string username = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="userId"><see cref="string"/> - The unique identifier of the user.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CompanyUser"/>.</returns>
        Model.Management.CompanyUser GetUserDetails(string companyId, string userId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="userId"><see cref="string"/> - The unique identifier of the user.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CompanyUser"/>.</returns>
        Task<Model.Management.CompanyUser> GetUserDetailsAsync(string companyId, string userId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update user details
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="userId"><see cref="string"/> - The unique identifier of the user.</param>
        /// <param name="updateCompanyUserRequest"><see cref="UpdateCompanyUserRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CompanyUser"/>.</returns>
        Model.Management.CompanyUser UpdateUserDetails(string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update user details
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="userId"><see cref="string"/> - The unique identifier of the user.</param>
        /// <param name="updateCompanyUserRequest"><see cref="UpdateCompanyUserRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CompanyUser"/>.</returns>
        Task<Model.Management.CompanyUser> UpdateUserDetailsAsync(string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="createCompanyUserRequest"><see cref="CreateCompanyUserRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreateCompanyUserResponse"/>.</returns>
        Model.Management.CreateCompanyUserResponse CreateNewUser(string companyId, CreateCompanyUserRequest createCompanyUserRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="companyId"><see cref="string"/> - The unique identifier of the company account.</param>
        /// <param name="createCompanyUserRequest"><see cref="CreateCompanyUserRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreateCompanyUserResponse"/>.</returns>
        Task<Model.Management.CreateCompanyUserResponse> CreateNewUserAsync(string companyId, CreateCompanyUserRequest createCompanyUserRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the UsersCompanyLevelService API endpoints
    /// </summary>
    public class UsersCompanyLevelService : AbstractService, IUsersCompanyLevelService
    {
        private readonly string _baseUrl;
        
        public UsersCompanyLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Model.Management.ListCompanyUsersResponse ListUsers(string companyId, int? pageNumber = default, int? pageSize = default, string username = default, RequestOptions requestOptions = default)
        {
            return ListUsersAsync(companyId, pageNumber, pageSize, username, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.ListCompanyUsersResponse> ListUsersAsync(string companyId, int? pageNumber = default, int? pageSize = default, string username = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            if (username != null) queryParams.Add("username", username);
            var endpoint = _baseUrl + $"/companies/{companyId}/users" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.ListCompanyUsersResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.CompanyUser GetUserDetails(string companyId, string userId, RequestOptions requestOptions = default)
        {
            return GetUserDetailsAsync(companyId, userId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.CompanyUser> GetUserDetailsAsync(string companyId, string userId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/users/{userId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.CompanyUser>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.CompanyUser UpdateUserDetails(string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest = default, RequestOptions requestOptions = default)
        {
            return UpdateUserDetailsAsync(companyId, userId, updateCompanyUserRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.CompanyUser> UpdateUserDetailsAsync(string companyId, string userId, UpdateCompanyUserRequest updateCompanyUserRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/users/{userId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.CompanyUser>(updateCompanyUserRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Management.CreateCompanyUserResponse CreateNewUser(string companyId, CreateCompanyUserRequest createCompanyUserRequest = default, RequestOptions requestOptions = default)
        {
            return CreateNewUserAsync(companyId, createCompanyUserRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Management.CreateCompanyUserResponse> CreateNewUserAsync(string companyId, CreateCompanyUserRequest createCompanyUserRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/companies/{companyId}/users";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Management.CreateCompanyUserResponse>(createCompanyUserRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}