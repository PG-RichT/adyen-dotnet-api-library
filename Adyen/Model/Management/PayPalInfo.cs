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
    /// PayPalInfo
    /// </summary>
    [DataContract(Name = "PayPalInfo")]
    public partial class PayPalInfo : IEquatable<PayPalInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayPalInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalInfo" /> class.
        /// </summary>
        /// <param name="directCapture">Indicates if direct (immediate) capture for PayPal is enabled. If set to **true**, this setting overrides the [capture](https://docs.adyen.com/online-payments/capture) settings of your merchant account. Default value: **true**..</param>
        /// <param name="payerId">PayPal Merchant ID. Character length and limitations: 13 single-byte alphanumeric characters. (required).</param>
        /// <param name="subject">Your business email address. (required).</param>
        public PayPalInfo(bool? directCapture = default(bool?), string payerId = default(string), string subject = default(string))
        {
            this.PayerId = payerId;
            this.Subject = subject;
            this.DirectCapture = directCapture;
        }

        /// <summary>
        /// Indicates if direct (immediate) capture for PayPal is enabled. If set to **true**, this setting overrides the [capture](https://docs.adyen.com/online-payments/capture) settings of your merchant account. Default value: **true**.
        /// </summary>
        /// <value>Indicates if direct (immediate) capture for PayPal is enabled. If set to **true**, this setting overrides the [capture](https://docs.adyen.com/online-payments/capture) settings of your merchant account. Default value: **true**.</value>
        [DataMember(Name = "directCapture", EmitDefaultValue = false)]
        public bool? DirectCapture { get; set; }

        /// <summary>
        /// PayPal Merchant ID. Character length and limitations: 13 single-byte alphanumeric characters.
        /// </summary>
        /// <value>PayPal Merchant ID. Character length and limitations: 13 single-byte alphanumeric characters.</value>
        [DataMember(Name = "payerId", IsRequired = false, EmitDefaultValue = false)]
        public string PayerId { get; set; }

        /// <summary>
        /// Your business email address.
        /// </summary>
        /// <value>Your business email address.</value>
        [DataMember(Name = "subject", IsRequired = false, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayPalInfo {\n");
            sb.Append("  DirectCapture: ").Append(DirectCapture).Append("\n");
            sb.Append("  PayerId: ").Append(PayerId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as PayPalInfo);
        }

        /// <summary>
        /// Returns true if PayPalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PayPalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPalInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DirectCapture == input.DirectCapture ||
                    this.DirectCapture.Equals(input.DirectCapture)
                ) && 
                (
                    this.PayerId == input.PayerId ||
                    (this.PayerId != null &&
                    this.PayerId.Equals(input.PayerId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                hashCode = (hashCode * 59) + this.DirectCapture.GetHashCode();
                if (this.PayerId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerId.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
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
            // PayerId (string) maxLength
            if (this.PayerId != null && this.PayerId.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayerId, length must be less than 13.", new [] { "PayerId" });
            }

            // PayerId (string) minLength
            if (this.PayerId != null && this.PayerId.Length < 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayerId, length must be greater than 13.", new [] { "PayerId" });
            }

            yield break;
        }
    }

}
