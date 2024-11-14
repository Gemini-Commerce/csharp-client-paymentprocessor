/*
 * Payment Processor Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = paymentprocessor.Client.OpenAPIDateConverter;

namespace paymentprocessor.Model
{
    /// <summary>
    /// PaymentprocessorPayment
    /// </summary>
    [DataContract(Name = "paymentprocessorPayment")]
    public partial class PaymentprocessorPayment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentprocessorPayment()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorPayment" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="code">payment type stripe, paypal.. (required).</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        /// <param name="transactions">transactions.</param>
        public PaymentprocessorPayment(string id = default(string), string code = default(string), string additionalInfo = default(string), List<PaymentprocessorTransaction> transactions = default(List<PaymentprocessorTransaction>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PaymentprocessorPayment and cannot be null");
            }
            this.Id = id;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for PaymentprocessorPayment and cannot be null");
            }
            this.Code = code;
            this.AdditionalInfo = additionalInfo;
            this.Transactions = transactions;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// payment type stripe, paypal..
        /// </summary>
        /// <value>payment type stripe, paypal..</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<PaymentprocessorTransaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentprocessorPayment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
