/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Contains information about a billing invoice.
    /// </summary>
    [DataContract]
    public partial class BillingInvoice :  IEquatable<BillingInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoice" /> class.
        /// </summary>
        /// <param name="Amount">Reserved: TBD.</param>
        /// <param name="Balance">Reserved: TBD.</param>
        /// <param name="DueDate">Reserved: TBD.</param>
        /// <param name="InvoiceId">Reserved: TBD.</param>
        /// <param name="InvoiceItems">Reserved: TBD.</param>
        /// <param name="InvoiceNumber">Reserved: TBD.</param>
        /// <param name="InvoiceUri">Contains a URI for an endpoint that you can use to retrieve invoice information..</param>
        /// <param name="NonTaxableAmount">.</param>
        /// <param name="PdfAvailable">.</param>
        /// <param name="TaxableAmount">.</param>
        public BillingInvoice(string Amount = default(string), string Balance = default(string), string DueDate = default(string), string InvoiceId = default(string), List<BillingInvoiceItem> InvoiceItems = default(List<BillingInvoiceItem>), string InvoiceNumber = default(string), string InvoiceUri = default(string), string NonTaxableAmount = default(string), string PdfAvailable = default(string), string TaxableAmount = default(string))
        {
            this.Amount = Amount;
            this.Balance = Balance;
            this.DueDate = DueDate;
            this.InvoiceId = InvoiceId;
            this.InvoiceItems = InvoiceItems;
            this.InvoiceNumber = InvoiceNumber;
            this.InvoiceUri = InvoiceUri;
            this.NonTaxableAmount = NonTaxableAmount;
            this.PdfAvailable = PdfAvailable;
            this.TaxableAmount = TaxableAmount;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public string DueDate { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="invoiceId", EmitDefaultValue=false)]
        public string InvoiceId { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="invoiceItems", EmitDefaultValue=false)]
        public List<BillingInvoiceItem> InvoiceItems { get; set; }
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// Contains a URI for an endpoint that you can use to retrieve invoice information.
        /// </summary>
        /// <value>Contains a URI for an endpoint that you can use to retrieve invoice information.</value>
        [DataMember(Name="invoiceUri", EmitDefaultValue=false)]
        public string InvoiceUri { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="nonTaxableAmount", EmitDefaultValue=false)]
        public string NonTaxableAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pdfAvailable", EmitDefaultValue=false)]
        public string PdfAvailable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="taxableAmount", EmitDefaultValue=false)]
        public string TaxableAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInvoice {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  InvoiceItems: ").Append(InvoiceItems).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceUri: ").Append(InvoiceUri).Append("\n");
            sb.Append("  NonTaxableAmount: ").Append(NonTaxableAmount).Append("\n");
            sb.Append("  PdfAvailable: ").Append(PdfAvailable).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BillingInvoice);
        }

        /// <summary>
        /// Returns true if BillingInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInvoice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) && 
                (
                    this.InvoiceId == other.InvoiceId ||
                    this.InvoiceId != null &&
                    this.InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    this.InvoiceItems == other.InvoiceItems ||
                    this.InvoiceItems != null &&
                    this.InvoiceItems.SequenceEqual(other.InvoiceItems)
                ) && 
                (
                    this.InvoiceNumber == other.InvoiceNumber ||
                    this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    this.InvoiceUri == other.InvoiceUri ||
                    this.InvoiceUri != null &&
                    this.InvoiceUri.Equals(other.InvoiceUri)
                ) && 
                (
                    this.NonTaxableAmount == other.NonTaxableAmount ||
                    this.NonTaxableAmount != null &&
                    this.NonTaxableAmount.Equals(other.NonTaxableAmount)
                ) && 
                (
                    this.PdfAvailable == other.PdfAvailable ||
                    this.PdfAvailable != null &&
                    this.PdfAvailable.Equals(other.PdfAvailable)
                ) && 
                (
                    this.TaxableAmount == other.TaxableAmount ||
                    this.TaxableAmount != null &&
                    this.TaxableAmount.Equals(other.TaxableAmount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.InvoiceId != null)
                    hash = hash * 59 + this.InvoiceId.GetHashCode();
                if (this.InvoiceItems != null)
                    hash = hash * 59 + this.InvoiceItems.GetHashCode();
                if (this.InvoiceNumber != null)
                    hash = hash * 59 + this.InvoiceNumber.GetHashCode();
                if (this.InvoiceUri != null)
                    hash = hash * 59 + this.InvoiceUri.GetHashCode();
                if (this.NonTaxableAmount != null)
                    hash = hash * 59 + this.NonTaxableAmount.GetHashCode();
                if (this.PdfAvailable != null)
                    hash = hash * 59 + this.PdfAvailable.GetHashCode();
                if (this.TaxableAmount != null)
                    hash = hash * 59 + this.TaxableAmount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}