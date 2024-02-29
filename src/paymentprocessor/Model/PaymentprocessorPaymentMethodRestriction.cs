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
    /// PaymentprocessorPaymentMethodRestriction
    /// </summary>
    [DataContract(Name = "paymentprocessorPaymentMethodRestriction")]
    public partial class PaymentprocessorPaymentMethodRestriction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorPaymentMethodRestriction" /> class.
        /// </summary>
        /// <param name="conditions">conditions.</param>
        public PaymentprocessorPaymentMethodRestriction(List<PaymentprocessorPaymentMethodRestrictionCondition> conditions = default(List<PaymentprocessorPaymentMethodRestrictionCondition>))
        {
            this.Conditions = conditions;
        }

        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name = "conditions", EmitDefaultValue = false)]
        public List<PaymentprocessorPaymentMethodRestrictionCondition> Conditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentprocessorPaymentMethodRestriction {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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