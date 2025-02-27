/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// BacsDirectDebitDetails
    /// </summary>
    [DataContract(Name = "BacsDirectDebitDetails")]
    public partial class BacsDirectDebitDetails : IEquatable<BacsDirectDebitDetails>, IValidatableObject
    {
        /// <summary>
        /// **directdebit_GB**
        /// </summary>
        /// <value>**directdebit_GB**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DirectdebitGB for value: directdebit_GB
            /// </summary>
            [EnumMember(Value = "directdebit_GB")]
            DirectdebitGB = 1

        }


        /// <summary>
        /// **directdebit_GB**
        /// </summary>
        /// <value>**directdebit_GB**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BacsDirectDebitDetails" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">The bank account number (without separators)..</param>
        /// <param name="bankLocationId">The bank routing number of the account..</param>
        /// <param name="checkoutAttemptId">The checkout attempt identifier..</param>
        /// <param name="holderName">The name of the bank account holder..</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**directdebit_GB** (default to TypeEnum.DirectdebitGB).</param>
        public BacsDirectDebitDetails(string bankAccountNumber = default(string), string bankLocationId = default(string), string checkoutAttemptId = default(string), string holderName = default(string), string recurringDetailReference = default(string), string storedPaymentMethodId = default(string), TypeEnum? type = TypeEnum.DirectdebitGB)
        {
            this.BankAccountNumber = bankAccountNumber;
            this.BankLocationId = bankLocationId;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.HolderName = holderName;
            this.RecurringDetailReference = recurringDetailReference;
            this.StoredPaymentMethodId = storedPaymentMethodId;
            this.Type = type;
        }

        /// <summary>
        /// The bank account number (without separators).
        /// </summary>
        /// <value>The bank account number (without separators).</value>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The bank routing number of the account.
        /// </summary>
        /// <value>The bank routing number of the account.</value>
        [DataMember(Name = "bankLocationId", EmitDefaultValue = false)]
        public string BankLocationId { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        /// <value>The checkout attempt identifier.</value>
        [DataMember(Name = "checkoutAttemptId", EmitDefaultValue = false)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        /// <value>The name of the bank account holder.</value>
        [DataMember(Name = "holderName", EmitDefaultValue = false)]
        public string HolderName { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "recurringDetailReference", EmitDefaultValue = false)]
        [Obsolete]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name = "storedPaymentMethodId", EmitDefaultValue = false)]
        public string StoredPaymentMethodId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BacsDirectDebitDetails {\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  BankLocationId: ").Append(BankLocationId).Append("\n");
            sb.Append("  CheckoutAttemptId: ").Append(CheckoutAttemptId).Append("\n");
            sb.Append("  HolderName: ").Append(HolderName).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
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
            return this.Equals(input as BacsDirectDebitDetails);
        }

        /// <summary>
        /// Returns true if BacsDirectDebitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BacsDirectDebitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BacsDirectDebitDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) && 
                (
                    this.BankLocationId == input.BankLocationId ||
                    (this.BankLocationId != null &&
                    this.BankLocationId.Equals(input.BankLocationId))
                ) && 
                (
                    this.CheckoutAttemptId == input.CheckoutAttemptId ||
                    (this.CheckoutAttemptId != null &&
                    this.CheckoutAttemptId.Equals(input.CheckoutAttemptId))
                ) && 
                (
                    this.HolderName == input.HolderName ||
                    (this.HolderName != null &&
                    this.HolderName.Equals(input.HolderName))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
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
                if (this.BankAccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccountNumber.GetHashCode();
                }
                if (this.BankLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.BankLocationId.GetHashCode();
                }
                if (this.CheckoutAttemptId != null)
                {
                    hashCode = (hashCode * 59) + this.CheckoutAttemptId.GetHashCode();
                }
                if (this.HolderName != null)
                {
                    hashCode = (hashCode * 59) + this.HolderName.GetHashCode();
                }
                if (this.RecurringDetailReference != null)
                {
                    hashCode = (hashCode * 59) + this.RecurringDetailReference.GetHashCode();
                }
                if (this.StoredPaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.StoredPaymentMethodId.GetHashCode();
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
            // StoredPaymentMethodId (string) maxLength
            if (this.StoredPaymentMethodId != null && this.StoredPaymentMethodId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StoredPaymentMethodId, length must be less than 64.", new [] { "StoredPaymentMethodId" });
            }

            yield break;
        }
    }

}
