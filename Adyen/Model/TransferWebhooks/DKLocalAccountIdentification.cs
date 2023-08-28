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
    /// DKLocalAccountIdentification
    /// </summary>
    [DataContract(Name = "DKLocalAccountIdentification")]
    public partial class DKLocalAccountIdentification : IEquatable<DKLocalAccountIdentification>, IValidatableObject
    {
        /// <summary>
        /// **dkLocal**
        /// </summary>
        /// <value>**dkLocal**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DkLocal for value: dkLocal
            /// </summary>
            [EnumMember(Value = "dkLocal")]
            DkLocal = 1

        }


        /// <summary>
        /// **dkLocal**
        /// </summary>
        /// <value>**dkLocal**</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DKLocalAccountIdentification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DKLocalAccountIdentification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DKLocalAccountIdentification" /> class.
        /// </summary>
        /// <param name="accountNumber">The 4-10 digits bank account number (Kontonummer) (without separators or whitespace). (required).</param>
        /// <param name="bankCode">The 4-digit bank code (Registreringsnummer) (without separators or whitespace). (required).</param>
        /// <param name="type">**dkLocal** (required) (default to TypeEnum.DkLocal).</param>
        public DKLocalAccountIdentification(string accountNumber = default(string), string bankCode = default(string), TypeEnum type = TypeEnum.DkLocal)
        {
            this.AccountNumber = accountNumber;
            this.BankCode = bankCode;
            this.Type = type;
        }

        /// <summary>
        /// The 4-10 digits bank account number (Kontonummer) (without separators or whitespace).
        /// </summary>
        /// <value>The 4-10 digits bank account number (Kontonummer) (without separators or whitespace).</value>
        [DataMember(Name = "accountNumber", IsRequired = false, EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The 4-digit bank code (Registreringsnummer) (without separators or whitespace).
        /// </summary>
        /// <value>The 4-digit bank code (Registreringsnummer) (without separators or whitespace).</value>
        [DataMember(Name = "bankCode", IsRequired = false, EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DKLocalAccountIdentification {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
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
            return this.Equals(input as DKLocalAccountIdentification);
        }

        /// <summary>
        /// Returns true if DKLocalAccountIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of DKLocalAccountIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DKLocalAccountIdentification input)
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
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
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
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
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
            if (this.AccountNumber != null && this.AccountNumber.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 10.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 4.", new [] { "AccountNumber" });
            }

            // BankCode (string) maxLength
            if (this.BankCode != null && this.BankCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be less than 4.", new [] { "BankCode" });
            }

            // BankCode (string) minLength
            if (this.BankCode != null && this.BankCode.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankCode, length must be greater than 4.", new [] { "BankCode" });
            }

            yield break;
        }
    }

}
