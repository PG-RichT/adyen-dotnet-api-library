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
    /// CreateMerchantRequest
    /// </summary>
    [DataContract(Name = "CreateMerchantRequest")]
    public partial class CreateMerchantRequest : IEquatable<CreateMerchantRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMerchantRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMerchantRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMerchantRequest" /> class.
        /// </summary>
        /// <param name="businessLineId">The unique identifier of the [business line](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines). Required for an Adyen for Platforms Manage integration..</param>
        /// <param name="companyId">The unique identifier of the company account. (required).</param>
        /// <param name="description">Your description for the merchant account, maximum 300 characters..</param>
        /// <param name="legalEntityId">The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities). Required for an Adyen for Platforms Manage integration..</param>
        /// <param name="pricingPlan">Sets the pricing plan for the merchant account. Required for an Adyen for Platforms Manage integration. Your Adyen contact will provide the values that you can use..</param>
        /// <param name="reference">Your reference for the merchant account. To make this reference the unique identifier of the merchant account, your Adyen contact can set up a template on your company account. The template can have 6 to 255 characters with upper- and lower-case letters, underscores, and numbers. When your company account has a template, then the &#x60;reference&#x60; is required and must be unique within the company account..</param>
        /// <param name="salesChannels">List of sales channels that the merchant will process payments with.</param>
        public CreateMerchantRequest(string businessLineId = default(string), string companyId = default(string), string description = default(string), string legalEntityId = default(string), string pricingPlan = default(string), string reference = default(string), List<string> salesChannels = default(List<string>))
        {
            this.CompanyId = companyId;
            this.BusinessLineId = businessLineId;
            this.Description = description;
            this.LegalEntityId = legalEntityId;
            this.PricingPlan = pricingPlan;
            this.Reference = reference;
            this.SalesChannels = salesChannels;
        }

        /// <summary>
        /// The unique identifier of the [business line](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines). Required for an Adyen for Platforms Manage integration.
        /// </summary>
        /// <value>The unique identifier of the [business line](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines). Required for an Adyen for Platforms Manage integration.</value>
        [DataMember(Name = "businessLineId", EmitDefaultValue = false)]
        public string BusinessLineId { get; set; }

        /// <summary>
        /// The unique identifier of the company account.
        /// </summary>
        /// <value>The unique identifier of the company account.</value>
        [DataMember(Name = "companyId", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Your description for the merchant account, maximum 300 characters.
        /// </summary>
        /// <value>Your description for the merchant account, maximum 300 characters.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities). Required for an Adyen for Platforms Manage integration.
        /// </summary>
        /// <value>The unique identifier of the [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities). Required for an Adyen for Platforms Manage integration.</value>
        [DataMember(Name = "legalEntityId", EmitDefaultValue = false)]
        public string LegalEntityId { get; set; }

        /// <summary>
        /// Sets the pricing plan for the merchant account. Required for an Adyen for Platforms Manage integration. Your Adyen contact will provide the values that you can use.
        /// </summary>
        /// <value>Sets the pricing plan for the merchant account. Required for an Adyen for Platforms Manage integration. Your Adyen contact will provide the values that you can use.</value>
        [DataMember(Name = "pricingPlan", EmitDefaultValue = false)]
        public string PricingPlan { get; set; }

        /// <summary>
        /// Your reference for the merchant account. To make this reference the unique identifier of the merchant account, your Adyen contact can set up a template on your company account. The template can have 6 to 255 characters with upper- and lower-case letters, underscores, and numbers. When your company account has a template, then the &#x60;reference&#x60; is required and must be unique within the company account.
        /// </summary>
        /// <value>Your reference for the merchant account. To make this reference the unique identifier of the merchant account, your Adyen contact can set up a template on your company account. The template can have 6 to 255 characters with upper- and lower-case letters, underscores, and numbers. When your company account has a template, then the &#x60;reference&#x60; is required and must be unique within the company account.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// List of sales channels that the merchant will process payments with
        /// </summary>
        /// <value>List of sales channels that the merchant will process payments with</value>
        [DataMember(Name = "salesChannels", EmitDefaultValue = false)]
        public List<string> SalesChannels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateMerchantRequest {\n");
            sb.Append("  BusinessLineId: ").Append(BusinessLineId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LegalEntityId: ").Append(LegalEntityId).Append("\n");
            sb.Append("  PricingPlan: ").Append(PricingPlan).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SalesChannels: ").Append(SalesChannels).Append("\n");
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
            return this.Equals(input as CreateMerchantRequest);
        }

        /// <summary>
        /// Returns true if CreateMerchantRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateMerchantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMerchantRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessLineId == input.BusinessLineId ||
                    (this.BusinessLineId != null &&
                    this.BusinessLineId.Equals(input.BusinessLineId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LegalEntityId == input.LegalEntityId ||
                    (this.LegalEntityId != null &&
                    this.LegalEntityId.Equals(input.LegalEntityId))
                ) && 
                (
                    this.PricingPlan == input.PricingPlan ||
                    (this.PricingPlan != null &&
                    this.PricingPlan.Equals(input.PricingPlan))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SalesChannels == input.SalesChannels ||
                    this.SalesChannels != null &&
                    input.SalesChannels != null &&
                    this.SalesChannels.SequenceEqual(input.SalesChannels)
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
                if (this.BusinessLineId != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLineId.GetHashCode();
                }
                if (this.CompanyId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.LegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityId.GetHashCode();
                }
                if (this.PricingPlan != null)
                {
                    hashCode = (hashCode * 59) + this.PricingPlan.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.SalesChannels != null)
                {
                    hashCode = (hashCode * 59) + this.SalesChannels.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            yield break;
        }
    }

}
