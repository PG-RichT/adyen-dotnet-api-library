/*
* Notification Configuration API
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

namespace Adyen.Model.PlatformsNotificationConfiguration
{
    /// <summary>
    /// NotificationConfigurationDetails
    /// </summary>
    [DataContract(Name = "NotificationConfigurationDetails")]
    public partial class NotificationConfigurationDetails : IEquatable<NotificationConfigurationDetails>, IValidatableObject
    {
        /// <summary>
        /// The SSL protocol employed by the endpoint. &gt;Permitted values: &#x60;TLSv12&#x60;, &#x60;TLSv13&#x60;.
        /// </summary>
        /// <value>The SSL protocol employed by the endpoint. &gt;Permitted values: &#x60;TLSv12&#x60;, &#x60;TLSv13&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SslProtocolEnum
        {
            /// <summary>
            /// Enum TLSv12 for value: TLSv12
            /// </summary>
            [EnumMember(Value = "TLSv12")]
            TLSv12 = 1,

            /// <summary>
            /// Enum TLSv13 for value: TLSv13
            /// </summary>
            [EnumMember(Value = "TLSv13")]
            TLSv13 = 2

        }


        /// <summary>
        /// The SSL protocol employed by the endpoint. &gt;Permitted values: &#x60;TLSv12&#x60;, &#x60;TLSv13&#x60;.
        /// </summary>
        /// <value>The SSL protocol employed by the endpoint. &gt;Permitted values: &#x60;TLSv12&#x60;, &#x60;TLSv13&#x60;.</value>
        [DataMember(Name = "sslProtocol", EmitDefaultValue = false)]
        public SslProtocolEnum? SslProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationConfigurationDetails" /> class.
        /// </summary>
        /// <param name="active">Indicates whether the notification subscription is active..</param>
        /// <param name="apiVersion">The version of the notification to which you are subscribing. To make sure that your integration can properly process the notification, subscribe to the same version as the API that you&#39;re using..</param>
        /// <param name="description">A description of the notification subscription configuration..</param>
        /// <param name="eventConfigs">Contains objects that define event types and their subscription settings..</param>
        /// <param name="hmacSignatureKey">A string with which to salt the notification(s) before hashing. If this field is provided, a hash value will be included under the notification header &#x60;HmacSignature&#x60; and the hash protocol will be included under the notification header &#x60;Protocol&#x60;. A notification body along with its &#x60;hmacSignatureKey&#x60; and &#x60;Protocol&#x60; can be used to calculate a hash value; matching this hash value with the &#x60;HmacSignature&#x60; will ensure that the notification body has not been tampered with or corrupted.  &gt;Must be a 32-byte hex-encoded string (i.e. a string containing 64 hexadecimal characters; e.g. \&quot;b0ea55c2fe60d4d1d605e9c385e0e7f7e6cafbb939ce07010f31a327a0871f27\&quot;).  The omission of this field will preclude the provision of the &#x60;HmacSignature&#x60; and &#x60;Protocol&#x60; headers in notification(s)..</param>
        /// <param name="notificationId">Adyen-generated ID for the entry, returned in the response when you create a notification configuration. Required when updating an existing configuration using [&#x60;/updateNotificationConfiguration&#x60;](https://docs.adyen.com/api-explorer/#/NotificationConfigurationService/latest/post/updateNotificationConfiguration)..</param>
        /// <param name="notifyPassword">The password to use when accessing the notifyURL with the specified username..</param>
        /// <param name="notifyURL">The URL to which the notifications are to be sent..</param>
        /// <param name="notifyUsername">The username to use when accessing the notifyURL..</param>
        /// <param name="sslProtocol">The SSL protocol employed by the endpoint. &gt;Permitted values: &#x60;TLSv12&#x60;, &#x60;TLSv13&#x60;..</param>
        public NotificationConfigurationDetails(bool? active = default(bool?), int? apiVersion = default(int?), string description = default(string), List<NotificationEventConfiguration> eventConfigs = default(List<NotificationEventConfiguration>), string hmacSignatureKey = default(string), long? notificationId = default(long?), string notifyPassword = default(string), string notifyURL = default(string), string notifyUsername = default(string), SslProtocolEnum? sslProtocol = default(SslProtocolEnum?))
        {
            this.Active = active;
            this.ApiVersion = apiVersion;
            this.Description = description;
            this.EventConfigs = eventConfigs;
            this.HmacSignatureKey = hmacSignatureKey;
            this.NotificationId = notificationId;
            this.NotifyPassword = notifyPassword;
            this.NotifyURL = notifyURL;
            this.NotifyUsername = notifyUsername;
            this.SslProtocol = sslProtocol;
        }

        /// <summary>
        /// Indicates whether the notification subscription is active.
        /// </summary>
        /// <value>Indicates whether the notification subscription is active.</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The version of the notification to which you are subscribing. To make sure that your integration can properly process the notification, subscribe to the same version as the API that you&#39;re using.
        /// </summary>
        /// <value>The version of the notification to which you are subscribing. To make sure that your integration can properly process the notification, subscribe to the same version as the API that you&#39;re using.</value>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public int? ApiVersion { get; set; }

        /// <summary>
        /// A description of the notification subscription configuration.
        /// </summary>
        /// <value>A description of the notification subscription configuration.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Contains objects that define event types and their subscription settings.
        /// </summary>
        /// <value>Contains objects that define event types and their subscription settings.</value>
        [DataMember(Name = "eventConfigs", EmitDefaultValue = false)]
        public List<NotificationEventConfiguration> EventConfigs { get; set; }

        /// <summary>
        /// A string with which to salt the notification(s) before hashing. If this field is provided, a hash value will be included under the notification header &#x60;HmacSignature&#x60; and the hash protocol will be included under the notification header &#x60;Protocol&#x60;. A notification body along with its &#x60;hmacSignatureKey&#x60; and &#x60;Protocol&#x60; can be used to calculate a hash value; matching this hash value with the &#x60;HmacSignature&#x60; will ensure that the notification body has not been tampered with or corrupted.  &gt;Must be a 32-byte hex-encoded string (i.e. a string containing 64 hexadecimal characters; e.g. \&quot;b0ea55c2fe60d4d1d605e9c385e0e7f7e6cafbb939ce07010f31a327a0871f27\&quot;).  The omission of this field will preclude the provision of the &#x60;HmacSignature&#x60; and &#x60;Protocol&#x60; headers in notification(s).
        /// </summary>
        /// <value>A string with which to salt the notification(s) before hashing. If this field is provided, a hash value will be included under the notification header &#x60;HmacSignature&#x60; and the hash protocol will be included under the notification header &#x60;Protocol&#x60;. A notification body along with its &#x60;hmacSignatureKey&#x60; and &#x60;Protocol&#x60; can be used to calculate a hash value; matching this hash value with the &#x60;HmacSignature&#x60; will ensure that the notification body has not been tampered with or corrupted.  &gt;Must be a 32-byte hex-encoded string (i.e. a string containing 64 hexadecimal characters; e.g. \&quot;b0ea55c2fe60d4d1d605e9c385e0e7f7e6cafbb939ce07010f31a327a0871f27\&quot;).  The omission of this field will preclude the provision of the &#x60;HmacSignature&#x60; and &#x60;Protocol&#x60; headers in notification(s).</value>
        [DataMember(Name = "hmacSignatureKey", EmitDefaultValue = false)]
        public string HmacSignatureKey { get; set; }

        /// <summary>
        /// Adyen-generated ID for the entry, returned in the response when you create a notification configuration. Required when updating an existing configuration using [&#x60;/updateNotificationConfiguration&#x60;](https://docs.adyen.com/api-explorer/#/NotificationConfigurationService/latest/post/updateNotificationConfiguration).
        /// </summary>
        /// <value>Adyen-generated ID for the entry, returned in the response when you create a notification configuration. Required when updating an existing configuration using [&#x60;/updateNotificationConfiguration&#x60;](https://docs.adyen.com/api-explorer/#/NotificationConfigurationService/latest/post/updateNotificationConfiguration).</value>
        [DataMember(Name = "notificationId", EmitDefaultValue = false)]
        public long? NotificationId { get; set; }

        /// <summary>
        /// The password to use when accessing the notifyURL with the specified username.
        /// </summary>
        /// <value>The password to use when accessing the notifyURL with the specified username.</value>
        [DataMember(Name = "notifyPassword", EmitDefaultValue = false)]
        public string NotifyPassword { get; set; }

        /// <summary>
        /// The URL to which the notifications are to be sent.
        /// </summary>
        /// <value>The URL to which the notifications are to be sent.</value>
        [DataMember(Name = "notifyURL", EmitDefaultValue = false)]
        public string NotifyURL { get; set; }

        /// <summary>
        /// The username to use when accessing the notifyURL.
        /// </summary>
        /// <value>The username to use when accessing the notifyURL.</value>
        [DataMember(Name = "notifyUsername", EmitDefaultValue = false)]
        public string NotifyUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationConfigurationDetails {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EventConfigs: ").Append(EventConfigs).Append("\n");
            sb.Append("  HmacSignatureKey: ").Append(HmacSignatureKey).Append("\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  NotifyPassword: ").Append(NotifyPassword).Append("\n");
            sb.Append("  NotifyURL: ").Append(NotifyURL).Append("\n");
            sb.Append("  NotifyUsername: ").Append(NotifyUsername).Append("\n");
            sb.Append("  SslProtocol: ").Append(SslProtocol).Append("\n");
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
            return this.Equals(input as NotificationConfigurationDetails);
        }

        /// <summary>
        /// Returns true if NotificationConfigurationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationConfigurationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationConfigurationDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    this.ApiVersion.Equals(input.ApiVersion)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EventConfigs == input.EventConfigs ||
                    this.EventConfigs != null &&
                    input.EventConfigs != null &&
                    this.EventConfigs.SequenceEqual(input.EventConfigs)
                ) && 
                (
                    this.HmacSignatureKey == input.HmacSignatureKey ||
                    (this.HmacSignatureKey != null &&
                    this.HmacSignatureKey.Equals(input.HmacSignatureKey))
                ) && 
                (
                    this.NotificationId == input.NotificationId ||
                    this.NotificationId.Equals(input.NotificationId)
                ) && 
                (
                    this.NotifyPassword == input.NotifyPassword ||
                    (this.NotifyPassword != null &&
                    this.NotifyPassword.Equals(input.NotifyPassword))
                ) && 
                (
                    this.NotifyURL == input.NotifyURL ||
                    (this.NotifyURL != null &&
                    this.NotifyURL.Equals(input.NotifyURL))
                ) && 
                (
                    this.NotifyUsername == input.NotifyUsername ||
                    (this.NotifyUsername != null &&
                    this.NotifyUsername.Equals(input.NotifyUsername))
                ) && 
                (
                    this.SslProtocol == input.SslProtocol ||
                    this.SslProtocol.Equals(input.SslProtocol)
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.ApiVersion.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EventConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.EventConfigs.GetHashCode();
                }
                if (this.HmacSignatureKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacSignatureKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NotificationId.GetHashCode();
                if (this.NotifyPassword != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyPassword.GetHashCode();
                }
                if (this.NotifyURL != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyURL.GetHashCode();
                }
                if (this.NotifyUsername != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUsername.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SslProtocol.GetHashCode();
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
