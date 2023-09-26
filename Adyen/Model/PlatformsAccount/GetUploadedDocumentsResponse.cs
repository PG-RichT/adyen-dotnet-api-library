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
    /// GetUploadedDocumentsResponse
    /// </summary>
    [DataContract(Name = "GetUploadedDocumentsResponse")]
    public partial class GetUploadedDocumentsResponse : IEquatable<GetUploadedDocumentsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUploadedDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documentDetails">A list of the documents and their details..</param>
        /// <param name="invalidFields">Contains field validation errors that would prevent requests from being processed..</param>
        /// <param name="pspReference">The reference of a request. Can be used to uniquely identify the request..</param>
        /// <param name="resultCode">The result code..</param>
        public GetUploadedDocumentsResponse(List<DocumentDetail> documentDetails = default(List<DocumentDetail>), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), string pspReference = default(string), string resultCode = default(string))
        {
            this.DocumentDetails = documentDetails;
            this.InvalidFields = invalidFields;
            this.PspReference = pspReference;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// A list of the documents and their details.
        /// </summary>
        /// <value>A list of the documents and their details.</value>
        [DataMember(Name = "documentDetails", EmitDefaultValue = false)]
        public List<DocumentDetail> DocumentDetails { get; set; }

        /// <summary>
        /// Contains field validation errors that would prevent requests from being processed.
        /// </summary>
        /// <value>Contains field validation errors that would prevent requests from being processed.</value>
        [DataMember(Name = "invalidFields", EmitDefaultValue = false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// The reference of a request. Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request. Can be used to uniquely identify the request.</value>
        [DataMember(Name = "pspReference", EmitDefaultValue = false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUploadedDocumentsResponse {\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(input as GetUploadedDocumentsResponse);
        }

        /// <summary>
        /// Returns true if GetUploadedDocumentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUploadedDocumentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUploadedDocumentsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentDetails == input.DocumentDetails ||
                    this.DocumentDetails != null &&
                    input.DocumentDetails != null &&
                    this.DocumentDetails.SequenceEqual(input.DocumentDetails)
                ) && 
                (
                    this.InvalidFields == input.InvalidFields ||
                    this.InvalidFields != null &&
                    input.InvalidFields != null &&
                    this.InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    this.PspReference == input.PspReference ||
                    (this.PspReference != null &&
                    this.PspReference.Equals(input.PspReference))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
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
                if (this.DocumentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentDetails.GetHashCode();
                }
                if (this.InvalidFields != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidFields.GetHashCode();
                }
                if (this.PspReference != null)
                {
                    hashCode = (hashCode * 59) + this.PspReference.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
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
            yield break;
        }
    }

}
