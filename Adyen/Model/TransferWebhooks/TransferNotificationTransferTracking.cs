/*
* Transfer webhooks
*
*
* The version of the OpenAPI document: 3
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.TransferWebhooks
{
    /// <summary>
    /// TransferNotificationTransferTracking
    /// </summary>
    [DataContract(Name = "TransferNotificationTransferTracking")]
    public partial class TransferNotificationTransferTracking : IEquatable<TransferNotificationTransferTracking>, IValidatableObject
    {
        /// <summary>
        /// The tracking status of the transfer.
        /// </summary>
        /// <value>The tracking status of the transfer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Credited for value: credited
            /// </summary>
            [EnumMember(Value = "credited")]
            Credited = 1

        }


        /// <summary>
        /// The tracking status of the transfer.
        /// </summary>
        /// <value>The tracking status of the transfer.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNotificationTransferTracking" /> class.
        /// </summary>
        /// <param name="estimatedArrivalTime">The estimated time the beneficiary should have access to the funds..</param>
        /// <param name="status">The tracking status of the transfer..</param>
        public TransferNotificationTransferTracking(DateTime estimatedArrivalTime = default(DateTime), StatusEnum? status = default(StatusEnum?))
        {
            this.EstimatedArrivalTime = estimatedArrivalTime;
            this.Status = status;
        }

        /// <summary>
        /// The estimated time the beneficiary should have access to the funds.
        /// </summary>
        /// <value>The estimated time the beneficiary should have access to the funds.</value>
        [DataMember(Name = "estimatedArrivalTime", EmitDefaultValue = false)]
        public DateTime EstimatedArrivalTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferNotificationTransferTracking {\n");
            sb.Append("  EstimatedArrivalTime: ").Append(EstimatedArrivalTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferNotificationTransferTracking);
        }

        /// <summary>
        /// Returns true if TransferNotificationTransferTracking instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferNotificationTransferTracking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferNotificationTransferTracking input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EstimatedArrivalTime == input.EstimatedArrivalTime ||
                    (this.EstimatedArrivalTime != null &&
                    this.EstimatedArrivalTime.Equals(input.EstimatedArrivalTime))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EstimatedArrivalTime != null)
                {
                    hashCode = (hashCode * 59) + this.EstimatedArrivalTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
