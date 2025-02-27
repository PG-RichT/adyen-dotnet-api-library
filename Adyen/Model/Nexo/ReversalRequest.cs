﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class ReversalRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OriginalPOITransaction OriginalPOITransaction;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CustomerOrder CustomerOrderID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string SaleReferenceID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public ReversalReasonType ReversalReason;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? ReversedAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? ReversedAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public SaleData SaleData;
    }
}