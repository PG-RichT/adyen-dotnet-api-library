﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class CurrencyConversion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Amount ConvertedAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal? Commission;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? CommissionSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Declaration;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool? CustomerApprovedFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? Rate;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? RateSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal? Markup;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? MarkupSpecified;
    }
}