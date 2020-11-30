/* 
 * Handelsregister bevragen
 *
 * D.m.v. deze toepassing worden meerdere, korte bevragingen op het Handelsregister beschikbaar gesteld.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CorrespondentieAdresEigenaarHalBasis
    /// </summary>
    [DataContract]
    public partial class CorrespondentieAdresEigenaarHalBasis :  IEquatable<CorrespondentieAdresEigenaarHalBasis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrespondentieAdresEigenaarHalBasis" /> class.
        /// </summary>
        /// <param name="rsin">rsin.</param>
        /// <param name="identificatieHandelsregisterNatuurlijkPersoon">identificatieHandelsregisterNatuurlijkPersoon.</param>
        /// <param name="aanschrijfwijze">Samengestelde naam zoals die in communicatie met de eigenaar dient te worden. Hoe het samenstellen van een aanschrijfwijze te werk gaat is beschreven in de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-HR-Bevragen/blob/master/features/aanschrijfwijze.feature).</param>
        /// <param name="adres">adres.</param>
        /// <param name="links">links.</param>
        public CorrespondentieAdresEigenaarHalBasis(string rsin = default(string), string identificatieHandelsregisterNatuurlijkPersoon = default(string), string aanschrijfwijze = default(string), Adres adres = default(Adres), CorrespondentieAdresEigenaarLinks links = default(CorrespondentieAdresEigenaarLinks))
        {
            this.Rsin = rsin;
            this.IdentificatieHandelsregisterNatuurlijkPersoon = identificatieHandelsregisterNatuurlijkPersoon;
            this.Aanschrijfwijze = aanschrijfwijze;
            this.Adres = adres;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Rsin
        /// </summary>
        [DataMember(Name="rsin", EmitDefaultValue=false)]
        public string Rsin { get; set; }

        /// <summary>
        /// Gets or Sets IdentificatieHandelsregisterNatuurlijkPersoon
        /// </summary>
        [DataMember(Name="identificatieHandelsregisterNatuurlijkPersoon", EmitDefaultValue=false)]
        public string IdentificatieHandelsregisterNatuurlijkPersoon { get; set; }

        /// <summary>
        /// Samengestelde naam zoals die in communicatie met de eigenaar dient te worden. Hoe het samenstellen van een aanschrijfwijze te werk gaat is beschreven in de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-HR-Bevragen/blob/master/features/aanschrijfwijze.feature)
        /// </summary>
        /// <value>Samengestelde naam zoals die in communicatie met de eigenaar dient te worden. Hoe het samenstellen van een aanschrijfwijze te werk gaat is beschreven in de [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-HR-Bevragen/blob/master/features/aanschrijfwijze.feature)</value>
        [DataMember(Name="aanschrijfwijze", EmitDefaultValue=false)]
        public string Aanschrijfwijze { get; set; }

        /// <summary>
        /// Gets or Sets Adres
        /// </summary>
        [DataMember(Name="adres", EmitDefaultValue=false)]
        public Adres Adres { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public CorrespondentieAdresEigenaarLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrespondentieAdresEigenaarHalBasis {\n");
            sb.Append("  Rsin: ").Append(Rsin).Append("\n");
            sb.Append("  IdentificatieHandelsregisterNatuurlijkPersoon: ").Append(IdentificatieHandelsregisterNatuurlijkPersoon).Append("\n");
            sb.Append("  Aanschrijfwijze: ").Append(Aanschrijfwijze).Append("\n");
            sb.Append("  Adres: ").Append(Adres).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CorrespondentieAdresEigenaarHalBasis);
        }

        /// <summary>
        /// Returns true if CorrespondentieAdresEigenaarHalBasis instances are equal
        /// </summary>
        /// <param name="input">Instance of CorrespondentieAdresEigenaarHalBasis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrespondentieAdresEigenaarHalBasis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rsin == input.Rsin ||
                    (this.Rsin != null &&
                    this.Rsin.Equals(input.Rsin))
                ) && 
                (
                    this.IdentificatieHandelsregisterNatuurlijkPersoon == input.IdentificatieHandelsregisterNatuurlijkPersoon ||
                    (this.IdentificatieHandelsregisterNatuurlijkPersoon != null &&
                    this.IdentificatieHandelsregisterNatuurlijkPersoon.Equals(input.IdentificatieHandelsregisterNatuurlijkPersoon))
                ) && 
                (
                    this.Aanschrijfwijze == input.Aanschrijfwijze ||
                    (this.Aanschrijfwijze != null &&
                    this.Aanschrijfwijze.Equals(input.Aanschrijfwijze))
                ) && 
                (
                    this.Adres == input.Adres ||
                    (this.Adres != null &&
                    this.Adres.Equals(input.Adres))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Rsin != null)
                    hashCode = hashCode * 59 + this.Rsin.GetHashCode();
                if (this.IdentificatieHandelsregisterNatuurlijkPersoon != null)
                    hashCode = hashCode * 59 + this.IdentificatieHandelsregisterNatuurlijkPersoon.GetHashCode();
                if (this.Aanschrijfwijze != null)
                    hashCode = hashCode * 59 + this.Aanschrijfwijze.GetHashCode();
                if (this.Adres != null)
                    hashCode = hashCode * 59 + this.Adres.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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

}