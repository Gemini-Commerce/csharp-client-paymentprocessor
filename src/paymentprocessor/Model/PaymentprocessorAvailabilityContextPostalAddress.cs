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
    /// PaymentprocessorAvailabilityContextPostalAddress
    /// </summary>
    [DataContract(Name = "paymentprocessorAvailabilityContextPostalAddress")]
    public partial class PaymentprocessorAvailabilityContextPostalAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentprocessorAvailabilityContextPostalAddress" /> class.
        /// </summary>
        /// <param name="regionCode">regionCode.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="firstname">firstname.</param>
        /// <param name="lastname">lastname.</param>
        /// <param name="addressLines">addressLines.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        public PaymentprocessorAvailabilityContextPostalAddress(string regionCode = default(string), string postalCode = default(string), string firstname = default(string), string lastname = default(string), List<string> addressLines = default(List<string>), Object additionalInfo = default(Object))
        {
            this.RegionCode = regionCode;
            this.PostalCode = postalCode;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.AddressLines = addressLines;
            this.AdditionalInfo = additionalInfo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets RegionCode
        /// </summary>
        [DataMember(Name = "regionCode", EmitDefaultValue = false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name = "firstname", EmitDefaultValue = false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name = "lastname", EmitDefaultValue = false)]
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or Sets AddressLines
        /// </summary>
        [DataMember(Name = "addressLines", EmitDefaultValue = false)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public Object AdditionalInfo { get; set; }

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
            sb.Append("class PaymentprocessorAvailabilityContextPostalAddress {\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
