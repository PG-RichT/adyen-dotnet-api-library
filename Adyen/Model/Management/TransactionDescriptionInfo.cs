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

namespace Adyen.Model.Management
{
    /// <summary>
    /// TransactionDescriptionInfo
    /// </summary>
    [DataContract(Name = "TransactionDescriptionInfo")]
    public partial class TransactionDescriptionInfo : IEquatable<TransactionDescriptionInfo>, IValidatableObject
    {
        /// <summary>
        /// The type of transaction description you want to use: - **fixed**: The transaction description set in this request is used for all payments with this payment method. - **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string. - **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method.
        /// </summary>
        /// <value>The type of transaction description you want to use: - **fixed**: The transaction description set in this request is used for all payments with this payment method. - **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string. - **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Append for value: append
            /// </summary>
            [EnumMember(Value = "append")]
            Append = 1,

            /// <summary>
            /// Enum Dynamic for value: dynamic
            /// </summary>
            [EnumMember(Value = "dynamic")]
            Dynamic = 2,

            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 3

        }


        /// <summary>
        /// The type of transaction description you want to use: - **fixed**: The transaction description set in this request is used for all payments with this payment method. - **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string. - **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method.
        /// </summary>
        /// <value>The type of transaction description you want to use: - **fixed**: The transaction description set in this request is used for all payments with this payment method. - **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string. - **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDescriptionInfo" /> class.
        /// </summary>
        /// <param name="doingBusinessAsName">The text to be shown on the shopper&#39;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#39; _ - ? + * /_**..</param>
        /// <param name="type">The type of transaction description you want to use: - **fixed**: The transaction description set in this request is used for all payments with this payment method. - **append**: The transaction description set in this request is used as a base for all payments with this payment method. The [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string. - **dynamic**: Only the [transaction description set in the request to process the payment](https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement) is used for payments with this payment method. (default to TypeEnum.Dynamic).</param>
        public TransactionDescriptionInfo(string doingBusinessAsName = default(string), TypeEnum? type = TypeEnum.Dynamic)
        {
            this.DoingBusinessAsName = doingBusinessAsName;
            this.Type = type;
        }

        /// <summary>
        /// The text to be shown on the shopper&#39;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#39; _ - ? + * /_**.
        /// </summary>
        /// <value>The text to be shown on the shopper&#39;s bank statement.  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.  Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , &#39; _ - ? + * /_**.</value>
        [DataMember(Name = "doingBusinessAsName", EmitDefaultValue = false)]
        public string DoingBusinessAsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionDescriptionInfo {\n");
            sb.Append("  DoingBusinessAsName: ").Append(DoingBusinessAsName).Append("\n");
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
            return this.Equals(input as TransactionDescriptionInfo);
        }

        /// <summary>
        /// Returns true if TransactionDescriptionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDescriptionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDescriptionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DoingBusinessAsName == input.DoingBusinessAsName ||
                    (this.DoingBusinessAsName != null &&
                    this.DoingBusinessAsName.Equals(input.DoingBusinessAsName))
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
                if (this.DoingBusinessAsName != null)
                {
                    hashCode = (hashCode * 59) + this.DoingBusinessAsName.GetHashCode();
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
            // DoingBusinessAsName (string) maxLength
            if (this.DoingBusinessAsName != null && this.DoingBusinessAsName.Length > 22)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DoingBusinessAsName, length must be less than 22.", new [] { "DoingBusinessAsName" });
            }

            yield break;
        }
    }

}
