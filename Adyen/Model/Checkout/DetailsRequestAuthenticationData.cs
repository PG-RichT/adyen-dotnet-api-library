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
    /// DetailsRequestAuthenticationData
    /// </summary>
    [DataContract(Name = "DetailsRequestAuthenticationData")]
    public partial class DetailsRequestAuthenticationData : IEquatable<DetailsRequestAuthenticationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequestAuthenticationData" /> class.
        /// </summary>
        /// <param name="authenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. Default: *false**. (default to false).</param>
        public DetailsRequestAuthenticationData(bool? authenticationOnly = false)
        {
            this.AuthenticationOnly = authenticationOnly;
        }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. Default: *false**.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. Default: *false**.</value>
        [DataMember(Name = "authenticationOnly", EmitDefaultValue = false)]
        public bool? AuthenticationOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailsRequestAuthenticationData {\n");
            sb.Append("  AuthenticationOnly: ").Append(AuthenticationOnly).Append("\n");
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
            return this.Equals(input as DetailsRequestAuthenticationData);
        }

        /// <summary>
        /// Returns true if DetailsRequestAuthenticationData instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailsRequestAuthenticationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailsRequestAuthenticationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationOnly == input.AuthenticationOnly ||
                    this.AuthenticationOnly.Equals(input.AuthenticationOnly)
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
                hashCode = (hashCode * 59) + this.AuthenticationOnly.GetHashCode();
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
