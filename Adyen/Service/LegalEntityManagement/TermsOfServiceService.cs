/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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
using Adyen.Model.LegalEntityManagement;

namespace Adyen.Service.LegalEntityManagement
{
    /// <summary>
    /// TermsOfServiceService Interface
    /// </summary>
    public interface ITermsOfServiceService
    {
        /// <summary>
        /// Get Terms of Service information for a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GetTermsOfServiceAcceptanceInfosResponse"/>.</returns>
        Model.LegalEntityManagement.GetTermsOfServiceAcceptanceInfosResponse GetTermsOfServiceInformationForLegalEntity(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get Terms of Service information for a legal entity
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GetTermsOfServiceAcceptanceInfosResponse"/>.</returns>
        Task<Model.LegalEntityManagement.GetTermsOfServiceAcceptanceInfosResponse> GetTermsOfServiceInformationForLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get Terms of Service status
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CalculateTermsOfServiceStatusResponse"/>.</returns>
        Model.LegalEntityManagement.CalculateTermsOfServiceStatusResponse GetTermsOfServiceStatus(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get Terms of Service status
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CalculateTermsOfServiceStatusResponse"/>.</returns>
        Task<Model.LegalEntityManagement.CalculateTermsOfServiceStatusResponse> GetTermsOfServiceStatusAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Accept Terms of Service
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="termsofservicedocumentid"><see cref="string"/> - The unique identifier of the Terms of Service document.</param>
        /// <param name="acceptTermsOfServiceRequest"><see cref="AcceptTermsOfServiceRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AcceptTermsOfServiceResponse"/>.</returns>
        Model.LegalEntityManagement.AcceptTermsOfServiceResponse AcceptTermsOfService(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Accept Terms of Service
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="termsofservicedocumentid"><see cref="string"/> - The unique identifier of the Terms of Service document.</param>
        /// <param name="acceptTermsOfServiceRequest"><see cref="AcceptTermsOfServiceRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AcceptTermsOfServiceResponse"/>.</returns>
        Task<Model.LegalEntityManagement.AcceptTermsOfServiceResponse> AcceptTermsOfServiceAsync(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get Terms of Service document
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="getTermsOfServiceDocumentRequest"><see cref="GetTermsOfServiceDocumentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GetTermsOfServiceDocumentResponse"/>.</returns>
        Model.LegalEntityManagement.GetTermsOfServiceDocumentResponse GetTermsOfServiceDocument(string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get Terms of Service document
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner.</param>
        /// <param name="getTermsOfServiceDocumentRequest"><see cref="GetTermsOfServiceDocumentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GetTermsOfServiceDocumentResponse"/>.</returns>
        Task<Model.LegalEntityManagement.GetTermsOfServiceDocumentResponse> GetTermsOfServiceDocumentAsync(string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TermsOfServiceService API endpoints
    /// </summary>
    public class TermsOfServiceService : AbstractService, ITermsOfServiceService
    {
        private readonly string _baseUrl;
        
        public TermsOfServiceService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://kyc-test.adyen.com/lem/v3");
        }
        
        public Model.LegalEntityManagement.GetTermsOfServiceAcceptanceInfosResponse GetTermsOfServiceInformationForLegalEntity(string id, RequestOptions requestOptions = default)
        {
            return GetTermsOfServiceInformationForLegalEntityAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.LegalEntityManagement.GetTermsOfServiceAcceptanceInfosResponse> GetTermsOfServiceInformationForLegalEntityAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/termsOfServiceAcceptanceInfos";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.LegalEntityManagement.GetTermsOfServiceAcceptanceInfosResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.LegalEntityManagement.CalculateTermsOfServiceStatusResponse GetTermsOfServiceStatus(string id, RequestOptions requestOptions = default)
        {
            return GetTermsOfServiceStatusAsync(id, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.LegalEntityManagement.CalculateTermsOfServiceStatusResponse> GetTermsOfServiceStatusAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/termsOfServiceStatus";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.LegalEntityManagement.CalculateTermsOfServiceStatusResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.LegalEntityManagement.AcceptTermsOfServiceResponse AcceptTermsOfService(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest = default, RequestOptions requestOptions = default)
        {
            return AcceptTermsOfServiceAsync(id, termsofservicedocumentid, acceptTermsOfServiceRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.LegalEntityManagement.AcceptTermsOfServiceResponse> AcceptTermsOfServiceAsync(string id, string termsofservicedocumentid, AcceptTermsOfServiceRequest acceptTermsOfServiceRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/termsOfService/{termsofservicedocumentid}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.LegalEntityManagement.AcceptTermsOfServiceResponse>(acceptTermsOfServiceRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.LegalEntityManagement.GetTermsOfServiceDocumentResponse GetTermsOfServiceDocument(string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest = default, RequestOptions requestOptions = default)
        {
            return GetTermsOfServiceDocumentAsync(id, getTermsOfServiceDocumentRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.LegalEntityManagement.GetTermsOfServiceDocumentResponse> GetTermsOfServiceDocumentAsync(string id, GetTermsOfServiceDocumentRequest getTermsOfServiceDocumentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/legalEntities/{id}/termsOfService";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.LegalEntityManagement.GetTermsOfServiceDocumentResponse>(getTermsOfServiceDocumentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}