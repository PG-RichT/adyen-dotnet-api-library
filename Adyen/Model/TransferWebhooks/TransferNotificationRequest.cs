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
    /// TransferNotificationRequest
    /// </summary>
    [DataContract(Name = "TransferNotificationRequest")]
    public partial class TransferNotificationRequest : IEquatable<TransferNotificationRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of webhook.
        /// </summary>
        /// <value>The type of webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Created for value: balancePlatform.transfer.created
            /// </summary>
            [EnumMember(Value = "balancePlatform.transfer.created")]
            Created = 1,

            /// <summary>
            /// Enum Updated for value: balancePlatform.transfer.updated
            /// </summary>
            [EnumMember(Value = "balancePlatform.transfer.updated")]
            Updated = 2

        }


        /// <summary>
        /// The type of webhook.
        /// </summary>
        /// <value>The type of webhook.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNotificationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferNotificationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNotificationRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="environment">The environment from which the webhook originated.  Possible values: **test**, **live**. (required).</param>
        /// <param name="type">The type of webhook..</param>
        public TransferNotificationRequest(TransferData data = default(TransferData), string environment = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Data = data;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = false, EmitDefaultValue = false)]
        public TransferData Data { get; set; }

        /// <summary>
        /// The environment from which the webhook originated.  Possible values: **test**, **live**.
        /// </summary>
        /// <value>The environment from which the webhook originated.  Possible values: **test**, **live**.</value>
        [DataMember(Name = "environment", IsRequired = false, EmitDefaultValue = false)]
        public string Environment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferNotificationRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TransferNotificationRequest);
        }

        /// <summary>
        /// Returns true if TransferNotificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferNotificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferNotificationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
