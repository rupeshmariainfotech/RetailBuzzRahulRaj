﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace CodeFirstEntities
{
    [Serializable]
    public class CashierSalesOrder
    {
        [Key]
        public int Id { get; set; }
        public string CashierCode { get; set; }
        public string OrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? CashierDate { get; set; }
        public string ClientName { get; set; }
        public string ClientContact { get; set; }
        public string ClientState { get; set; }
        public string ClientType { get; set; }
        public string ClientFormType { get; set; }
        public double? TotalAmount { get; set; }
        public double? AdvancePayment { get; set; }
        public double? TotalAdvancePayment { get; set; }
        public double? PackAndForwd { get; set; }
        public double? TotalTaxAmount { get; set; }
        public double? GrandTotal { get; set; }
        public double? Balance { get; set; }
        public string PaymentType { get; set; }
        public int? Cash_1000 { get; set; }
        public int? Cash_500 { get; set; }
        public int? Cash_100 { get; set; }
        public int? Cash_50 { get; set; }
        public int? Cash_20 { get; set; }
        public int? Cash_10 { get; set; }
        public double? Cash_1 { get; set; }
        public double? Cash_1000_Amt { get; set; }
        public double? Cash_500_Amt { get; set; }
        public double? Cash_100_Amt { get; set; }
        public double? Cash_50_Amt { get; set; }
        public double? Cash_20_Amt { get; set; }
        public double? Cash_10_Amt { get; set; }
        public double? Cash_1_Amt { get; set; }
        public double? TotalCash { get; set; }
        public double? Refund { get; set; }
        public string SelectedCard { get; set; }
        public string CreditCardNo { get; set; }
        public string CreditCardType { get; set; }
        public double? CreditCardAmount { get; set; }
        public string CreditCardBank { get; set; }
        public string DebitCardName { get; set; }
        public string DebitCardNo { get; set; }
        public string DebitCardType { get; set; }
        public double? DebitCardAmount { get; set; }
        public string DebitCardBank { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeAccNo { get; set; }
        public double? ChequeAmount { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string ChequeBank { get; set; }
        public string ChequeBranch { get; set; }
        public string Status { get; set; }
        public string SavingFrom { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string HandoverStatus { get; set; }
        public double? HandoverCreditAmt { get; set; }
        public double? HandoverDebitAmt { get; set; }
        public double? HandoverChequeAmt { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
    }
}
