/*
* Configuration webhooks
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

namespace Adyen.Model.ConfigurationWebhooks
{
    /// <summary>
    /// BalanceAccount
    /// </summary>
    [DataContract(Name = "BalanceAccount")]
    public partial class BalanceAccount : IEquatable<BalanceAccount>, IValidatableObject
    {
        /// <summary>
        /// The status of the balance account, set to **Active** by default.  
        /// </summary>
        /// <value>The status of the balance account, set to **Active** by default.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,

            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Suspended for value: Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended = 4

        }


        /// <summary>
        /// The status of the balance account, set to **Active** by default.  
        /// </summary>
        /// <value>The status of the balance account, set to **Active** by default.  </value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BalanceAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceAccount" /> class.
        /// </summary>
        /// <param name="accountHolderId">The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account. (required).</param>
        /// <param name="balances">List of balances with the amount and currency..</param>
        /// <param name="defaultCurrencyCode">The default three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) of the balance account. The default value is **EUR**..</param>
        /// <param name="description">A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder..</param>
        /// <param name="id">The unique identifier of the balance account. (required).</param>
        /// <param name="metadata">A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs..</param>
        /// <param name="migratedAccountCode">The unique identifier of the account of the migrated account holder in the classic integration..</param>
        /// <param name="paymentInstruments">List of [payment instruments](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/paymentInstruments) associated with the balance account..</param>
        /// <param name="platformPaymentConfiguration">platformPaymentConfiguration.</param>
        /// <param name="reference">Your reference for the balance account, maximum 150 characters..</param>
        /// <param name="status">The status of the balance account, set to **Active** by default.  .</param>
        /// <param name="sweepConfigurations">Contains key-value pairs that specify configurations for balance sweeps per currency code. A sweep pulls in or pushes out funds based on a defined schedule, amount, and a source (for pulling funds) or a destination (for pushing funds).  The key must be a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**. The value must be an object containing the sweep configuration..</param>
        /// <param name="timeZone">The time zone of the balance account. For example, **Europe/Amsterdam**. Defaults to the time zone of the account holder if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)..</param>
        public BalanceAccount(string accountHolderId = default(string), List<Balance> balances = default(List<Balance>), string defaultCurrencyCode = default(string), string description = default(string), string id = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string migratedAccountCode = default(string), List<PaymentInstrumentReference> paymentInstruments = default(List<PaymentInstrumentReference>), PlatformPaymentConfiguration platformPaymentConfiguration = default(PlatformPaymentConfiguration), string reference = default(string), StatusEnum? status = default(StatusEnum?), Dictionary<string, SweepConfiguration> sweepConfigurations = default(Dictionary<string, SweepConfiguration>), string timeZone = default(string))
        {
            this.AccountHolderId = accountHolderId;
            this.Id = id;
            this.Balances = balances;
            this.DefaultCurrencyCode = defaultCurrencyCode;
            this.Description = description;
            this.Metadata = metadata;
            this.MigratedAccountCode = migratedAccountCode;
            this.PaymentInstruments = paymentInstruments;
            this.PlatformPaymentConfiguration = platformPaymentConfiguration;
            this.Reference = reference;
            this.Status = status;
            this.SweepConfigurations = sweepConfigurations;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account.
        /// </summary>
        /// <value>The unique identifier of the [account holder](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/accountHolders__resParam_id) associated with the balance account.</value>
        [DataMember(Name = "accountHolderId", IsRequired = false, EmitDefaultValue = false)]
        public string AccountHolderId { get; set; }

        /// <summary>
        /// List of balances with the amount and currency.
        /// </summary>
        /// <value>List of balances with the amount and currency.</value>
        [DataMember(Name = "balances", EmitDefaultValue = false)]
        public List<Balance> Balances { get; set; }

        /// <summary>
        /// The default three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) of the balance account. The default value is **EUR**.
        /// </summary>
        /// <value>The default three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) of the balance account. The default value is **EUR**.</value>
        [DataMember(Name = "defaultCurrencyCode", EmitDefaultValue = false)]
        public string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder.
        /// </summary>
        /// <value>A human-readable description of the balance account, maximum 300 characters. You can use this parameter to distinguish between multiple balance accounts under an account holder.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier of the balance account.
        /// </summary>
        /// <value>The unique identifier of the balance account.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
        /// </summary>
        /// <value>A set of key and value pairs for general use. The keys do not have specific names and may be used for storing miscellaneous data as desired. &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The unique identifier of the account of the migrated account holder in the classic integration.
        /// </summary>
        /// <value>The unique identifier of the account of the migrated account holder in the classic integration.</value>
        [DataMember(Name = "migratedAccountCode", EmitDefaultValue = false)]
        public string MigratedAccountCode { get; set; }

        /// <summary>
        /// List of [payment instruments](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/paymentInstruments) associated with the balance account.
        /// </summary>
        /// <value>List of [payment instruments](https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/paymentInstruments) associated with the balance account.</value>
        [DataMember(Name = "paymentInstruments", EmitDefaultValue = false)]
        public List<PaymentInstrumentReference> PaymentInstruments { get; set; }

        /// <summary>
        /// Gets or Sets PlatformPaymentConfiguration
        /// </summary>
        [DataMember(Name = "platformPaymentConfiguration", EmitDefaultValue = false)]
        public PlatformPaymentConfiguration PlatformPaymentConfiguration { get; set; }

        /// <summary>
        /// Your reference for the balance account, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the balance account, maximum 150 characters.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Contains key-value pairs that specify configurations for balance sweeps per currency code. A sweep pulls in or pushes out funds based on a defined schedule, amount, and a source (for pulling funds) or a destination (for pushing funds).  The key must be a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**. The value must be an object containing the sweep configuration.
        /// </summary>
        /// <value>Contains key-value pairs that specify configurations for balance sweeps per currency code. A sweep pulls in or pushes out funds based on a defined schedule, amount, and a source (for pulling funds) or a destination (for pushing funds).  The key must be a three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes) in uppercase. For example, **EUR**. The value must be an object containing the sweep configuration.</value>
        [DataMember(Name = "sweepConfigurations", EmitDefaultValue = false)]
        public Dictionary<string, SweepConfiguration> SweepConfigurations { get; set; }

        /// <summary>
        /// The time zone of the balance account. For example, **Europe/Amsterdam**. Defaults to the time zone of the account holder if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).
        /// </summary>
        /// <value>The time zone of the balance account. For example, **Europe/Amsterdam**. Defaults to the time zone of the account holder if no time zone is set. For possible values, see the [list of time zone codes](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceAccount {\n");
            sb.Append("  AccountHolderId: ").Append(AccountHolderId).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  DefaultCurrencyCode: ").Append(DefaultCurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MigratedAccountCode: ").Append(MigratedAccountCode).Append("\n");
            sb.Append("  PaymentInstruments: ").Append(PaymentInstruments).Append("\n");
            sb.Append("  PlatformPaymentConfiguration: ").Append(PlatformPaymentConfiguration).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SweepConfigurations: ").Append(SweepConfigurations).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as BalanceAccount);
        }

        /// <summary>
        /// Returns true if BalanceAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolderId == input.AccountHolderId ||
                    (this.AccountHolderId != null &&
                    this.AccountHolderId.Equals(input.AccountHolderId))
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.DefaultCurrencyCode == input.DefaultCurrencyCode ||
                    (this.DefaultCurrencyCode != null &&
                    this.DefaultCurrencyCode.Equals(input.DefaultCurrencyCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MigratedAccountCode == input.MigratedAccountCode ||
                    (this.MigratedAccountCode != null &&
                    this.MigratedAccountCode.Equals(input.MigratedAccountCode))
                ) && 
                (
                    this.PaymentInstruments == input.PaymentInstruments ||
                    this.PaymentInstruments != null &&
                    input.PaymentInstruments != null &&
                    this.PaymentInstruments.SequenceEqual(input.PaymentInstruments)
                ) && 
                (
                    this.PlatformPaymentConfiguration == input.PlatformPaymentConfiguration ||
                    (this.PlatformPaymentConfiguration != null &&
                    this.PlatformPaymentConfiguration.Equals(input.PlatformPaymentConfiguration))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SweepConfigurations == input.SweepConfigurations ||
                    this.SweepConfigurations != null &&
                    input.SweepConfigurations != null &&
                    this.SweepConfigurations.SequenceEqual(input.SweepConfigurations)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.AccountHolderId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderId.GetHashCode();
                }
                if (this.Balances != null)
                {
                    hashCode = (hashCode * 59) + this.Balances.GetHashCode();
                }
                if (this.DefaultCurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCurrencyCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MigratedAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.MigratedAccountCode.GetHashCode();
                }
                if (this.PaymentInstruments != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentInstruments.GetHashCode();
                }
                if (this.PlatformPaymentConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformPaymentConfiguration.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SweepConfigurations != null)
                {
                    hashCode = (hashCode * 59) + this.SweepConfigurations.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
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

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}