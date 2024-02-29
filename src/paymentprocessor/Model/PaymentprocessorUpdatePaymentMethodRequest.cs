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
    /// PaymentprocessorUpdatePaymentMethodRequest
    /// </summary>
    [DataContract(Name = "paymentprocessorUpdatePaymentMethodRequest")]
    public partial class PaymentprocessorUpdatePaymentMethodRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public PaymentprocessorCurrency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorUpdatePaymentMethodRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentprocessorUpdatePaymentMethodRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorUpdatePaymentMethodRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="title">title.</param>
        /// <param name="label">label.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="amount">amount.</param>
        /// <param name="currency">currency.</param>
        /// <param name="varConfiguration">varConfiguration.</param>
        /// <param name="isUpfront">isUpfront.</param>
        /// <param name="description">description.</param>
        /// <param name="restrictions">restrictions.</param>
        /// <param name="fieldMask">fieldMask.</param>
        public PaymentprocessorUpdatePaymentMethodRequest(string tenantId = default(string), string code = default(string), PaymentprocessorLocalizedText title = default(PaymentprocessorLocalizedText), PaymentprocessorLocalizedText label = default(PaymentprocessorLocalizedText), bool enabled = default(bool), PaymentprocessorMoney amount = default(PaymentprocessorMoney), PaymentprocessorCurrency? currency = default(PaymentprocessorCurrency?), Object varConfiguration = default(Object), bool isUpfront = default(bool), PaymentprocessorLocalizedText description = default(PaymentprocessorLocalizedText), List<PaymentprocessorPaymentMethodRestriction> restrictions = default(List<PaymentprocessorPaymentMethodRestriction>), string fieldMask = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for PaymentprocessorUpdatePaymentMethodRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for PaymentprocessorUpdatePaymentMethodRequest and cannot be null");
            }
            this.Code = code;
            this.Title = title;
            this.Label = label;
            this.Enabled = enabled;
            this.Amount = amount;
            this.Currency = currency;
            this.VarConfiguration = varConfiguration;
            this.IsUpfront = isUpfront;
            this.Description = description;
            this.Restrictions = restrictions;
            this.FieldMask = fieldMask;
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public PaymentprocessorLocalizedText Title { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public PaymentprocessorLocalizedText Label { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public PaymentprocessorMoney Amount { get; set; }

        /// <summary>
        /// Gets or Sets VarConfiguration
        /// </summary>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public Object VarConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets IsUpfront
        /// </summary>
        [DataMember(Name = "isUpfront", EmitDefaultValue = true)]
        public bool IsUpfront { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public PaymentprocessorLocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name = "restrictions", EmitDefaultValue = false)]
        public List<PaymentprocessorPaymentMethodRestriction> Restrictions { get; set; }

        /// <summary>
        /// Gets or Sets FieldMask
        /// </summary>
        [DataMember(Name = "fieldMask", EmitDefaultValue = false)]
        public string FieldMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentprocessorUpdatePaymentMethodRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  VarConfiguration: ").Append(VarConfiguration).Append("\n");
            sb.Append("  IsUpfront: ").Append(IsUpfront).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
            sb.Append("  FieldMask: ").Append(FieldMask).Append("\n");
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
