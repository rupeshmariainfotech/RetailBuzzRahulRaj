﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEntities
{
    [Serializable]
    public class Quotation
    {
        [Key]
        public int Id { get; set; }
        public string QuotNo { get; set; }
        public DateTime? QuotDate { get; set; }
        [Required]
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientContactNo { get; set; }
        public string ClientState { get; set; }
        public string ClientType { get; set; }
        public string ConsumeResell { get; set; }
        public string FormType { get; set; }
        public string ClientEmail { get; set; }
        public string TotalAmount { get; set; }
        public string TotalTaxAmount { get; set; }
        public string GrandTotal { get; set; }
        [Required]
        public string TransportMode { get; set; }
        [Required]
        public string TransportName { get; set; }
        public string TransportContactNo { get; set; }
        public string RefNo { get; set; }
        public string Status { get; set; }
        public string PackAndForwd { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [Required]
        public string PreparedBy { get; set; }
        public string PreparedEmail { get; set; }
        public string PreparedContact { get; set; }
        public string PreparedTime { get; set; }
        public string SendingStatus { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopContactPerson { get; set; }
        public string ShopEmail { get; set; }
        [Required]
        public string SalesPersonName { get; set; }
        public string SalesPersonAddress { get; set; }
        public string SalesPersonEmail { get; set; }
        public string SalesPersonContact { get; set; }
        public string SalesPersonDesignation { get; set; }
        public string ProcessedIn { get; set; }
        public string TotalDiscount { get; set; }
        public string Editable { get; set; }
    }
}
