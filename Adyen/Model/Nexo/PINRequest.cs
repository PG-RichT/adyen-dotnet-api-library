﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class PINRequest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CardholderPIN CardholderPIN;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PINRequestType PINRequestType;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string PINVerifMethod;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string AdditionalInput;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string PINEncAlgorithm;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public PINFormatType PINFormat;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool? PINFormatSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string KeyReference;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int? MaxWaitingTime;
    }
}