﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class PerformedTransaction
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Response Response;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SaleData SaleData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public POIData POIData;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PaymentResult PaymentResult;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoyaltyResult", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LoyaltyResult[] LoyaltyResult;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? ReversedAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ReversedAmountSpecified;
    }
}