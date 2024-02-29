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
    /// PaymentprocessorGetAvailablePaymentMethodRequest
    /// </summary>
    [DataContract(Name = "paymentprocessorGetAvailablePaymentMethodRequest")]
    public partial class PaymentprocessorGetAvailablePaymentMethodRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorGetAvailablePaymentMethodRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentprocessorGetAvailablePaymentMethodRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorGetAvailablePaymentMethodRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="context">context (required).</param>
        /// <param name="authenticateMethod">authenticateMethod.</param>
        public PaymentprocessorGetAvailablePaymentMethodRequest(string tenantId = default(string), string code = default(string), PaymentprocessorAvailabilityContext context = default(PaymentprocessorAvailabilityContext), bool authenticateMethod = default(bool))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for PaymentprocessorGetAvailablePaymentMethodRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for PaymentprocessorGetAvailablePaymentMethodRequest and cannot be null");
            }
            this.Code = code;
            // to ensure "context" is required (not null)
            if (context == null)
            {
                throw new ArgumentNullException("context is a required property for PaymentprocessorGetAvailablePaymentMethodRequest and cannot be null");
            }
            this.Context = context;
            this.AuthenticateMethod = authenticateMethod;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", IsRequired = true, EmitDefaultValue = true)]
        public PaymentprocessorAvailabilityContext Context { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticateMethod
        /// </summary>
        [DataMember(Name = "authenticateMethod", EmitDefaultValue = true)]
        public bool AuthenticateMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentprocessorGetAvailablePaymentMethodRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  AuthenticateMethod: ").Append(AuthenticateMethod).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
