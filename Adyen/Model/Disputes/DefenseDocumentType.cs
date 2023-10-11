/*
* Disputes API
*
*
* The version of the OpenAPI document: 30
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

namespace Adyen.Model.Disputes
{
    /// <summary>
    /// DefenseDocumentType
    /// </summary>
    [DataContract(Name = "DefenseDocumentType")]
    public partial class DefenseDocumentType : IEquatable<DefenseDocumentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefenseDocumentType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefenseDocumentType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefenseDocumentType" /> class.
        /// </summary>
        /// <param name="available">When **true**, you&#39;ve successfully uploaded this type of defense document. When **false**, you haven&#39;t uploaded this defense document type. (required).</param>
        /// <param name="defenseDocumentTypeCode">The document type code of the defense document. (required).</param>
        /// <param name="requirementLevel">Indicates to what extent the defense document is required in the defense process.  Possible values:   * **Required**: You must supply the document.   * **OneOrMore**: You must supply at least one of the documents with this label.  * **Optional**: You can choose to supply the document.  * **AlternativeRequired**: You must supply a generic defense document. To enable this functionality, contact our Support Team. When enabled, you can supply a generic defense document for all schemes. (required).</param>
        public DefenseDocumentType(bool? available = default(bool?), string defenseDocumentTypeCode = default(string), string requirementLevel = default(string))
        {
            this.Available = available;
            this.DefenseDocumentTypeCode = defenseDocumentTypeCode;
            this.RequirementLevel = requirementLevel;
        }

        /// <summary>
        /// When **true**, you&#39;ve successfully uploaded this type of defense document. When **false**, you haven&#39;t uploaded this defense document type.
        /// </summary>
        /// <value>When **true**, you&#39;ve successfully uploaded this type of defense document. When **false**, you haven&#39;t uploaded this defense document type.</value>
        [DataMember(Name = "available", IsRequired = false, EmitDefaultValue = false)]
        public bool? Available { get; set; }

        /// <summary>
        /// The document type code of the defense document.
        /// </summary>
        /// <value>The document type code of the defense document.</value>
        [DataMember(Name = "defenseDocumentTypeCode", IsRequired = false, EmitDefaultValue = false)]
        public string DefenseDocumentTypeCode { get; set; }

        /// <summary>
        /// Indicates to what extent the defense document is required in the defense process.  Possible values:   * **Required**: You must supply the document.   * **OneOrMore**: You must supply at least one of the documents with this label.  * **Optional**: You can choose to supply the document.  * **AlternativeRequired**: You must supply a generic defense document. To enable this functionality, contact our Support Team. When enabled, you can supply a generic defense document for all schemes.
        /// </summary>
        /// <value>Indicates to what extent the defense document is required in the defense process.  Possible values:   * **Required**: You must supply the document.   * **OneOrMore**: You must supply at least one of the documents with this label.  * **Optional**: You can choose to supply the document.  * **AlternativeRequired**: You must supply a generic defense document. To enable this functionality, contact our Support Team. When enabled, you can supply a generic defense document for all schemes.</value>
        [DataMember(Name = "requirementLevel", IsRequired = false, EmitDefaultValue = false)]
        public string RequirementLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DefenseDocumentType {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  DefenseDocumentTypeCode: ").Append(DefenseDocumentTypeCode).Append("\n");
            sb.Append("  RequirementLevel: ").Append(RequirementLevel).Append("\n");
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
            return this.Equals(input as DefenseDocumentType);
        }

        /// <summary>
        /// Returns true if DefenseDocumentType instances are equal
        /// </summary>
        /// <param name="input">Instance of DefenseDocumentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefenseDocumentType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Available == input.Available ||
                    this.Available.Equals(input.Available)
                ) && 
                (
                    this.DefenseDocumentTypeCode == input.DefenseDocumentTypeCode ||
                    (this.DefenseDocumentTypeCode != null &&
                    this.DefenseDocumentTypeCode.Equals(input.DefenseDocumentTypeCode))
                ) && 
                (
                    this.RequirementLevel == input.RequirementLevel ||
                    (this.RequirementLevel != null &&
                    this.RequirementLevel.Equals(input.RequirementLevel))
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
                hashCode = (hashCode * 59) + this.Available.GetHashCode();
                if (this.DefenseDocumentTypeCode != null)
                {
                    hashCode = (hashCode * 59) + this.DefenseDocumentTypeCode.GetHashCode();
                }
                if (this.RequirementLevel != null)
                {
                    hashCode = (hashCode * 59) + this.RequirementLevel.GetHashCode();
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