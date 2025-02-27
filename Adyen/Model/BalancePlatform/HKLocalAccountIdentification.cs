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
    /// HKLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "HKLocalAccountIdentification")]
    public partial class HKLocalAccountIdentification : IEquatable<HKLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **hkLocal**
        /// </summary>
        /// <value>**hkLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum HkLocal for value: hkLocal
            /// </summary>
            [EnumMember(Value = "hkLocal")]
            HkLocal = 1

        }


        /// <summary>
        /// **hkLocal**
        /// </summary>
        /// <value>**hkLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HKLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HKLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HKLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 9- to 12-character bank account number (alphanumeric), without separators or whitespace. Starts with the 3-digit branch code. (required).</param>
        /// <param name="clearingCode">The 3-digit clearing code, without separators or whitespace. (required).</param>
        /// <param name="type">**hkLocal** (required) (default to TypeEnum.HkLocal).</param>
        public HKLocalAccountIdentification(string accountNumber = default(string), string clearingCode = default(string), TypeEnum type = TypeEnum.HkLocal)
        {
            this.AccountNumber = accountNumber;
            this.ClearingCode = clearingCode;
            this.Type = type;
        }

        /// <summary>
        /// The 9- to 12-character bank account number (alphanumeric), without separators or whitespace. Starts with the 3-digit branch code.
        /// </summary>
        /// <value>The 9- to 12-character bank account number (alphanumeric), without separators or whitespace. Starts with the 3-digit branch code.</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 3-digit clearing code, without separators or whitespace.
        /// </summary>
        /// <value>The 3-digit clearing code, without separators or whitespace.</value>
        [DataMember(Name = "clearingCode", IsRequired = false, EmitDefaultValue = false)]
        public string ClearingCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HKLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ClearingCode: ").Append(ClearingCode).Append("\n");
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
            return this.Equals(input as HKLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if HKLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of HKLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HKLocalAccountIdentification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.ClearingCode == input.ClearingCode ||
                    (this.ClearingCode != null &&
                    this.ClearingCode.Equals(input.ClearingCode))
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.ClearingCode != null)
                {
                    hashCode = (hashCode * 59) + this.ClearingCode.GetHashCode();
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
            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 12.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 9.", new [] { "AccountNumber" });
            }

            // ClearingCode (string) maxLength
            if (this.ClearingCode != null && this.ClearingCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClearingCode, length must be less than 3.", new [] { "ClearingCode" });
            }

            // ClearingCode (string) minLength
            if (this.ClearingCode != null && this.ClearingCode.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClearingCode, length must be greater than 3.", new [] { "ClearingCode" });
            }

            yield break;
        }
    }

}
