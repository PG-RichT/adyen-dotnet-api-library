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
    /// TransactionRulesResult
    /// </summary>
    [DataContract(Name = "TransactionRulesResult")]
    public partial class TransactionRulesResult : IEquatable<TransactionRulesResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRulesResult" /> class.
        /// </summary>
        /// <param name="advice">The advice given by the Risk analysis..</param>
        /// <param name="allRulesPassed">Indicates whether the transaction passed the evaluation for all transaction rules..</param>
        /// <param name="failedTransactionRules">Array containing all the transaction rules that the transaction violated. This list is only sent when &#x60;allRulesPassed&#x60; is **false**..</param>
        /// <param name="score">The score of the Risk analysis..</param>
        public TransactionRulesResult(string advice = default(string), bool? allRulesPassed = default(bool?), List<TransactionEventViolation> failedTransactionRules = default(List<TransactionEventViolation>), int? score = default(int?))
        {
            this.Advice = advice;
            this.AllRulesPassed = allRulesPassed;
            this.FailedTransactionRules = failedTransactionRules;
            this.Score = score;
        }

        /// <summary>
        /// The advice given by the Risk analysis.
        /// </summary>
        /// <value>The advice given by the Risk analysis.</value>
        [DataMember(Name = "advice", EmitDefaultValue = false)]
        public string Advice { get; set; }

        /// <summary>
        /// Indicates whether the transaction passed the evaluation for all transaction rules.
        /// </summary>
        /// <value>Indicates whether the transaction passed the evaluation for all transaction rules.</value>
        [DataMember(Name = "allRulesPassed", EmitDefaultValue = false)]
        public bool? AllRulesPassed { get; set; }

        /// <summary>
        /// Array containing all the transaction rules that the transaction violated. This list is only sent when &#x60;allRulesPassed&#x60; is **false**.
        /// </summary>
        /// <value>Array containing all the transaction rules that the transaction violated. This list is only sent when &#x60;allRulesPassed&#x60; is **false**.</value>
        [DataMember(Name = "failedTransactionRules", EmitDefaultValue = false)]
        public List<TransactionEventViolation> FailedTransactionRules { get; set; }

        /// <summary>
        /// The score of the Risk analysis.
        /// </summary>
        /// <value>The score of the Risk analysis.</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRulesResult {\n");
            sb.Append("  Advice: ").Append(Advice).Append("\n");
            sb.Append("  AllRulesPassed: ").Append(AllRulesPassed).Append("\n");
            sb.Append("  FailedTransactionRules: ").Append(FailedTransactionRules).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as TransactionRulesResult);
        }

        /// <summary>
        /// Returns true if TransactionRulesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRulesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRulesResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Advice == input.Advice ||
                    (this.Advice != null &&
                    this.Advice.Equals(input.Advice))
                ) && 
                (
                    this.AllRulesPassed == input.AllRulesPassed ||
                    this.AllRulesPassed.Equals(input.AllRulesPassed)
                ) && 
                (
                    this.FailedTransactionRules == input.FailedTransactionRules ||
                    this.FailedTransactionRules != null &&
                    input.FailedTransactionRules != null &&
                    this.FailedTransactionRules.SequenceEqual(input.FailedTransactionRules)
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
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
                if (this.Advice != null)
                {
                    hashCode = (hashCode * 59) + this.Advice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllRulesPassed.GetHashCode();
                if (this.FailedTransactionRules != null)
                {
                    hashCode = (hashCode * 59) + this.FailedTransactionRules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
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
