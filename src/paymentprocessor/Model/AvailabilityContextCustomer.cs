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
    /// AvailabilityContextCustomer
    /// </summary>
    [DataContract(Name = "AvailabilityContextCustomer")]
    public partial class AvailabilityContextCustomer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityContextCustomer" /> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        /// <param name="email">email.</param>
        public AvailabilityContextCustomer(List<string> segments = default(List<string>), string email = default(string))
        {
            this.Segments = segments;
            this.Email = email;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name = "segments", EmitDefaultValue = false)]
        public List<string> Segments { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

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
            sb.Append("class AvailabilityContextCustomer {\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
