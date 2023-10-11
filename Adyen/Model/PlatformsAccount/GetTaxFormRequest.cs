/*
* Account API
*
*
* The version of the OpenAPI document: 6
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

namespace Adyen.Model.PlatformsAccount
{
    /// <summary>
    /// GetTaxFormRequest
    /// </summary>
    [DataContract(Name = "GetTaxFormRequest")]
    public partial class GetTaxFormRequest : IEquatable<GetTaxFormRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaxFormRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTaxFormRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaxFormRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The account holder code you provided when you created the account holder. (required).</param>
        /// <param name="formType">Type of the requested tax form. For example, 1099-K. (required).</param>
        /// <param name="year">Applicable tax year in the YYYY format. (required).</param>
        public GetTaxFormRequest(string accountHolderCode = default(string), string formType = default(string), int? year = default(int?))
        {
            this.AccountHolderCode = accountHolderCode;
            this.FormType = formType;
            this.Year = year;
        }

        /// <summary>
        /// The account holder code you provided when you created the account holder.
        /// </summary>
        /// <value>The account holder code you provided when you created the account holder.</value>
        [DataMember(Name = "accountHolderCode", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// Type of the requested tax form. For example, 1099-K.
        /// </summary>
        /// <value>Type of the requested tax form. For example, 1099-K.</value>
        [DataMember(Name = "formType", IsRequired = false, EmitDefaultValue = false)]
        public string FormType { get; set; }

        /// <summary>
        /// Applicable tax year in the YYYY format.
        /// </summary>
        /// <value>Applicable tax year in the YYYY format.</value>
        [DataMember(Name = "year", IsRequired = false, EmitDefaultValue = false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTaxFormRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  FormType: ").Append(FormType).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as GetTaxFormRequest);
        }

        /// <summary>
        /// Returns true if GetTaxFormRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTaxFormRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTaxFormRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderCode == input.AccountHolderCode ||
                    (this.AccountHolderCode != null &&
                    this.AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    this.FormType == input.FormType ||
                    (this.FormType != null &&
                    this.FormType.Equals(input.FormType))
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
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
                if (this.AccountHolderCode != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderCode.GetHashCode();
                }
                if (this.FormType != null)
                {
                    hashCode = (hashCode * 59) + this.FormType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
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