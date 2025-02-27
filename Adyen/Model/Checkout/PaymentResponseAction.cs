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
using System.Reflection;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// Action to be taken for completing the payment.
    /// </summary>
    [JsonConverter(typeof(PaymentResponseActionJsonConverter))]
    [DataContract(Name = "PaymentResponse_action")]
    public partial class PaymentResponseAction : AbstractOpenAPISchema, IEquatable<PaymentResponseAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutAwaitAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutAwaitAction.</param>
        public PaymentResponseAction(CheckoutAwaitAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutDelegatedAuthenticationAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutDelegatedAuthenticationAction.</param>
        public PaymentResponseAction(CheckoutDelegatedAuthenticationAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutNativeRedirectAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutNativeRedirectAction.</param>
        public PaymentResponseAction(CheckoutNativeRedirectAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutQrCodeAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutQrCodeAction.</param>
        public PaymentResponseAction(CheckoutQrCodeAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutRedirectAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutRedirectAction.</param>
        public PaymentResponseAction(CheckoutRedirectAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutSDKAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutSDKAction.</param>
        public PaymentResponseAction(CheckoutSDKAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutThreeDS2Action" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutThreeDS2Action.</param>
        public PaymentResponseAction(CheckoutThreeDS2Action actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResponseAction" /> class
        /// with the <see cref="CheckoutVoucherAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CheckoutVoucherAction.</param>
        public PaymentResponseAction(CheckoutVoucherAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CheckoutAwaitAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutDelegatedAuthenticationAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutNativeRedirectAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutQrCodeAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutRedirectAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutSDKAction))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutThreeDS2Action))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CheckoutVoucherAction))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CheckoutAwaitAction, CheckoutDelegatedAuthenticationAction, CheckoutNativeRedirectAction, CheckoutQrCodeAction, CheckoutRedirectAction, CheckoutSDKAction, CheckoutThreeDS2Action, CheckoutVoucherAction");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CheckoutAwaitAction`. If the actual instance is not `CheckoutAwaitAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutAwaitAction</returns>
        public CheckoutAwaitAction GetCheckoutAwaitAction()
        {
            return (CheckoutAwaitAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutDelegatedAuthenticationAction`. If the actual instance is not `CheckoutDelegatedAuthenticationAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutDelegatedAuthenticationAction</returns>
        public CheckoutDelegatedAuthenticationAction GetCheckoutDelegatedAuthenticationAction()
        {
            return (CheckoutDelegatedAuthenticationAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutNativeRedirectAction`. If the actual instance is not `CheckoutNativeRedirectAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutNativeRedirectAction</returns>
        public CheckoutNativeRedirectAction GetCheckoutNativeRedirectAction()
        {
            return (CheckoutNativeRedirectAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutQrCodeAction`. If the actual instance is not `CheckoutQrCodeAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutQrCodeAction</returns>
        public CheckoutQrCodeAction GetCheckoutQrCodeAction()
        {
            return (CheckoutQrCodeAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutRedirectAction`. If the actual instance is not `CheckoutRedirectAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutRedirectAction</returns>
        public CheckoutRedirectAction GetCheckoutRedirectAction()
        {
            return (CheckoutRedirectAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutSDKAction`. If the actual instance is not `CheckoutSDKAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutSDKAction</returns>
        public CheckoutSDKAction GetCheckoutSDKAction()
        {
            return (CheckoutSDKAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutThreeDS2Action`. If the actual instance is not `CheckoutThreeDS2Action`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutThreeDS2Action</returns>
        public CheckoutThreeDS2Action GetCheckoutThreeDS2Action()
        {
            return (CheckoutThreeDS2Action)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CheckoutVoucherAction`. If the actual instance is not `CheckoutVoucherAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CheckoutVoucherAction</returns>
        public CheckoutVoucherAction GetCheckoutVoucherAction()
        {
            return (CheckoutVoucherAction)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResponseAction {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PaymentResponseAction.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PaymentResponseAction
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PaymentResponseAction</returns>
        public static PaymentResponseAction FromJson(string jsonString)
        {
            PaymentResponseAction newPaymentResponseAction = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPaymentResponseAction;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            JToken typeToken = JObject.Parse(jsonString).GetValue("type");
            string type = typeToken?.Value<string>();
            // Throw exception if jsonString does not contain type param
            if (type == null)
            {
                throw new InvalidDataException("JsonString does not contain required enum type for deserialization.");
            }
            try
            {
                // Check if the jsonString type enum matches the CheckoutAwaitAction type enums
                if (ContainsValue<CheckoutAwaitAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutAwaitAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutAwaitAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutDelegatedAuthenticationAction type enums
                if (ContainsValue<CheckoutDelegatedAuthenticationAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutDelegatedAuthenticationAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutDelegatedAuthenticationAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutNativeRedirectAction type enums
                if (ContainsValue<CheckoutNativeRedirectAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutNativeRedirectAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutNativeRedirectAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutQrCodeAction type enums
                if (ContainsValue<CheckoutQrCodeAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutQrCodeAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutQrCodeAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutRedirectAction type enums
                if (ContainsValue<CheckoutRedirectAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutRedirectAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutRedirectAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutSDKAction type enums
                if (ContainsValue<CheckoutSDKAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutSDKAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutSDKAction");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutThreeDS2Action type enums
                if (ContainsValue<CheckoutThreeDS2Action.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutThreeDS2Action>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutThreeDS2Action");
                    match++;
                }
                // Check if the jsonString type enum matches the CheckoutVoucherAction type enums
                if (ContainsValue<CheckoutVoucherAction.TypeEnum>(type))
                {
                    newPaymentResponseAction = new PaymentResponseAction(JsonConvert.DeserializeObject<CheckoutVoucherAction>(jsonString, PaymentResponseAction.SerializerSettings));
                    matchedTypes.Add("CheckoutVoucherAction");
                    match++;
                }
            } 
            catch (Exception ex)
            {
                if (!(ex is JsonSerializationException))
                {
                     throw new InvalidDataException(string.Format("Failed to deserialize `{0}` into target: {1}", jsonString, ex.ToString()));
                }
            }

            if (match != 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined. MatchedTypes are: " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
            return newPaymentResponseAction;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentResponseAction);
        }

        /// <summary>
        /// Returns true if PaymentResponseAction instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResponseAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponseAction input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for PaymentResponseAction
    /// </summary>
    public class PaymentResponseActionJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PaymentResponseAction).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PaymentResponseAction.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
