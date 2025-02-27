/*
* Management Webhooks
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

namespace Adyen.Model.ManagementWebhooks
{
    /// <summary>
    /// CapabilityProblemEntityRecursive
    /// </summary>
    [DataContract(Name = "CapabilityProblemEntity-recursive")]
    public partial class CapabilityProblemEntityRecursive : IEquatable<CapabilityProblemEntityRecursive>, IValidatableObject
    {
        /// <summary>
        /// The type of entity.  Possible values: **LegalEntity**, **BankAccount**, or **Document**.
        /// </summary>
        /// <value>The type of entity.  Possible values: **LegalEntity**, **BankAccount**, or **Document**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: BankAccount
            /// </summary>
            [EnumMember(Value = "BankAccount")]
            BankAccount = 1,

            /// <summary>
            /// Enum Document for value: Document
            /// </summary>
            [EnumMember(Value = "Document")]
            Document = 2,

            /// <summary>
            /// Enum LegalEntity for value: LegalEntity
            /// </summary>
            [EnumMember(Value = "LegalEntity")]
            LegalEntity = 3

        }


        /// <summary>
        /// The type of entity.  Possible values: **LegalEntity**, **BankAccount**, or **Document**.
        /// </summary>
        /// <value>The type of entity.  Possible values: **LegalEntity**, **BankAccount**, or **Document**.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityProblemEntityRecursive" /> class.
        /// </summary>
        /// <param name="documents">List of document IDs to which the verification errors related to the capabilities correspond to..</param>
        /// <param name="id">The ID of the entity..</param>
        /// <param name="type">The type of entity.  Possible values: **LegalEntity**, **BankAccount**, or **Document**..</param>
        public CapabilityProblemEntityRecursive(List<string> documents = default(List<string>), string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Documents = documents;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// List of document IDs to which the verification errors related to the capabilities correspond to.
        /// </summary>
        /// <value>List of document IDs to which the verification errors related to the capabilities correspond to.</value>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<string> Documents { get; set; }

        /// <summary>
        /// The ID of the entity.
        /// </summary>
        /// <value>The ID of the entity.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilityProblemEntityRecursive {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CapabilityProblemEntityRecursive);
        }

        /// <summary>
        /// Returns true if CapabilityProblemEntityRecursive instances are equal
        /// </summary>
        /// <param name="input">Instance of CapabilityProblemEntityRecursive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapabilityProblemEntityRecursive input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Documents != null)
                {
                    hashCode = (hashCode * 59) + this.Documents.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
            yield break;
        }
    }

}
