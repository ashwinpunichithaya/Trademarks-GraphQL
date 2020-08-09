namespace TrademarkLibrary.DTO.IPONZ.TS.ResponseTypes
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private ListTrademarksResponse listTrademarksResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.iponz.govt.nz/services")]
        public ListTrademarksResponse ListTrademarksResponse
        {
            get
            {
                return this.listTrademarksResponseField;
            }
            set
            {
                this.listTrademarksResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iponz.govt.nz/services", IsNullable = false)]
    public partial class ListTrademarksResponse
    {

        private ListTMsResponse listTMsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
        public ListTMsResponse ListTMsResponse
        {
            get
            {
                return this.listTMsResponseField;
            }
            set
            {
                this.listTMsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1", IsNullable = false)]
    public partial class ListTMsResponse
    {

        private ListTMsResponseFees feesField;

        private bool appErrorEncounteredField;

        private bool faultErrorEncounteredField;

        private ListTMsResponseListTradeMarksResponse listTradeMarksResponseField;

        /// <remarks/>
        public ListTMsResponseFees fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }

        /// <remarks/>
        public bool appErrorEncountered
        {
            get
            {
                return this.appErrorEncounteredField;
            }
            set
            {
                this.appErrorEncounteredField = value;
            }
        }

        /// <remarks/>
        public bool faultErrorEncountered
        {
            get
            {
                return this.faultErrorEncounteredField;
            }
            set
            {
                this.faultErrorEncounteredField = value;
            }
        }

        /// <remarks/>
        public ListTMsResponseListTradeMarksResponse ListTradeMarksResponse
        {
            get
            {
                return this.listTradeMarksResponseField;
            }
            set
            {
                this.listTradeMarksResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseFees
    {

        private object feeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Fee
        {
            get
            {
                return this.feeField;
            }
            set
            {
                this.feeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseListTradeMarksResponse
    {

        private ListTMsResponseListTradeMarksResponseListTradeMarksResponseBody listTradeMarksResponseBodyField;

        /// <remarks/>
        public ListTMsResponseListTradeMarksResponseListTradeMarksResponseBody ListTradeMarksResponseBody
        {
            get
            {
                return this.listTradeMarksResponseBodyField;
            }
            set
            {
                this.listTradeMarksResponseBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseListTradeMarksResponseListTradeMarksResponseBody
    {

        private ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetails listTradeMarksResponseContentDetailsField;

        /// <remarks/>
        public ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetails ListTradeMarksResponseContentDetails
        {
            get
            {
                return this.listTradeMarksResponseContentDetailsField;
            }
            set
            {
                this.listTradeMarksResponseContentDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetails
    {

        private string listTradeMarksIdentifierField;

        private ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseData listTradeMarksResponseDataField;

        /// <remarks/>
        public string ListTradeMarksIdentifier
        {
            get
            {
                return this.listTradeMarksIdentifierField;
            }
            set
            {
                this.listTradeMarksIdentifierField = value;
            }
        }

        /// <remarks/>
        public ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseData ListTradeMarksResponseData
        {
            get
            {
                return this.listTradeMarksResponseDataField;
            }
            set
            {
                this.listTradeMarksResponseDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseData
    {

        private ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseDataTradeMark[] tradeMarksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TradeMark", IsNullable = false)]
        public ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseDataTradeMark[] TradeMarks
        {
            get
            {
                return this.tradeMarksField;
            }
            set
            {
                this.tradeMarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTMsResponseListTradeMarksResponseListTradeMarksResponseBodyListTradeMarksResponseContentDetailsListTradeMarksResponseDataTradeMark
    {

        private uint applicationNumberField;

        private string markTitleField;

        private object goodsAndServicesField;

        private string markImageNameField;

        private ushort markCurrentStatusCodeField;

        private System.DateTime filingDateField;

        /// <remarks/>
        public uint ApplicationNumber
        {
            get
            {
                return this.applicationNumberField;
            }
            set
            {
                this.applicationNumberField = value;
            }
        }

        /// <remarks/>
        public string MarkTitle
        {
            get
            {
                return this.markTitleField;
            }
            set
            {
                this.markTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object GoodsAndServices
        {
            get
            {
                return this.goodsAndServicesField;
            }
            set
            {
                this.goodsAndServicesField = value;
            }
        }

        /// <remarks/>
        public string MarkImageName
        {
            get
            {
                return this.markImageNameField;
            }
            set
            {
                this.markImageNameField = value;
            }
        }

        /// <remarks/>
        public ushort MarkCurrentStatusCode
        {
            get
            {
                return this.markCurrentStatusCodeField;
            }
            set
            {
                this.markCurrentStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FilingDate
        {
            get
            {
                return this.filingDateField;
            }
            set
            {
                this.filingDateField = value;
            }
        }
    }
}