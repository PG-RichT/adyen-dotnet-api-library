/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// PaymentInstrumentRequirement
    /// </summary>
    [DataContract(Name = "PaymentInstrumentRequirement")]
    public partial class PaymentInstrumentRequirement : IEquatable<PaymentInstrumentRequirement>, IValidatableObject
    {
        /// <summary>
        /// The type of the payment instrument. For example, \&quot;BankAccount\&quot; or \&quot;Card\&quot;.
        /// </summary>
        /// <value>The type of the payment instrument. For example, \&quot;BankAccount\&quot; or \&quot;Card\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentInstrumentTypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: BankAccount
            /// </summary>
            [EnumMember(Value = "BankAccount")]
            BankAccount = 1,

            /// <summary>
            /// Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")]
            Card = 2

        }


        /// <summary>
        /// The type of the payment instrument. For example, \&quot;BankAccount\&quot; or \&quot;Card\&quot;.
        /// </summary>
        /// <value>The type of the payment instrument. For example, \&quot;BankAccount\&quot; or \&quot;Card\&quot;.</value>
        [DataMember(Name = "paymentInstrumentType", EmitDefaultValue = false)]
        public PaymentInstrumentTypeEnum? PaymentInstrumentType { get; set; }
        /// <summary>
        /// **paymentInstrumentRequirement**
        /// </summary>
        /// <value>**paymentInstrumentRequirement**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PaymentInstrumentRequirement for value: paymentInstrumentRequirement
            /// </summary>
            [EnumMember(Value = "paymentInstrumentRequirement")]
            PaymentInstrumentRequirement = 1

        }


        /// <summary>
        /// **paymentInstrumentRequirement**
        /// </summary>
        /// <value>**paymentInstrumentRequirement**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentRequirement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInstrumentRequirement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentRequirement" /> class.
        /// </summary>
        /// <param name="description">Specifies the requirements for the payment instrument that need to be included in the request for a particular route..</param>
        /// <param name="issuingCountryCode">The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**..</param>
        /// <param name="paymentInstrumentType">The type of the payment instrument. For example, \&quot;BankAccount\&quot; or \&quot;Card\&quot;..</param>
        /// <param name="type">**paymentInstrumentRequirement** (required) (default to TypeEnum.PaymentInstrumentRequirement).</param>
        public PaymentInstrumentRequirement(string description = default(string), string issuingCountryCode = default(string), PaymentInstrumentTypeEnum? paymentInstrumentType = default(PaymentInstrumentTypeEnum?), TypeEnum type = TypeEnum.PaymentInstrumentRequirement)
        {
            this.Type = type;
            this.Description = description;
            this.IssuingCountryCode = issuingCountryCode;
            this.PaymentInstrumentType = paymentInstrumentType;
        }

        /// <summary>
        /// Specifies the requirements for the payment instrument that need to be included in the request for a particular route.
        /// </summary>
        /// <value>Specifies the requirements for the payment instrument that need to be included in the request for a particular route.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**.
        /// </summary>
        /// <value>The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, **US** or **NL**.</value>
        [DataMember(Name = "issuingCountryCode", EmitDefaultValue = false)]
        public string IssuingCountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInstrumentRequirement {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IssuingCountryCode: ").Append(IssuingCountryCode).Append("\n");
            sb.Append("  PaymentInstrumentType: ").Append(PaymentInstrumentType).Append("\n");
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
            return this.Equals(input as PaymentInstrumentRequirement);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentRequirement instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInstrumentRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentRequirement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IssuingCountryCode == input.IssuingCountryCode ||
                    (this.IssuingCountryCode != null &&
                    this.IssuingCountryCode.Equals(input.IssuingCountryCode))
                ) && 
                (
                    this.PaymentInstrumentType == input.PaymentInstrumentType ||
                    this.PaymentInstrumentType.Equals(input.PaymentInstrumentType)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IssuingCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCountryCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentInstrumentType.GetHashCode();
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
