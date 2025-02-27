/*
* Transfers API
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
using Adyen.Model.Transfers;

namespace Adyen.Service.Transfers
{
    /// <summary>
    /// TransfersService Interface
    /// </summary>
    public interface ITransfersService
    {
        /// <summary>
        /// Transfer funds
        /// </summary>
        /// <param name="transferInfo"><see cref="TransferInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Transfer"/>.</returns>
        Model.Transfers.Transfer TransferFunds(TransferInfo transferInfo = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Transfer funds
        /// </summary>
        /// <param name="transferInfo"><see cref="TransferInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Transfer"/>.</returns>
        Task<Model.Transfers.Transfer> TransferFundsAsync(TransferInfo transferInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TransfersService API endpoints
    /// </summary>
    public class TransfersService : AbstractService, ITransfersService
    {
        private readonly string _baseUrl;
        
        public TransfersService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/btl/v3");
        }
        
        public Model.Transfers.Transfer TransferFunds(TransferInfo transferInfo = default, RequestOptions requestOptions = default)
        {
            return TransferFundsAsync(transferInfo, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Transfers.Transfer> TransferFundsAsync(TransferInfo transferInfo = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/transfers";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Transfers.Transfer>(transferInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}