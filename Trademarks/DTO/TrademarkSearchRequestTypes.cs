namespace TrademarkLibrary.DTO.IPONZ.TS.RequestTypes
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

        private ListTrademarksRequest listTrademarksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.iponz.govt.nz/services")]
        public ListTrademarksRequest ListTrademarks
        {
            get
            {
                return this.listTrademarksField;
            }
            set
            {
                this.listTrademarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/services")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iponz.govt.nz/services", IsNullable = false)]
    public partial class ListTrademarksRequest
    {

        private ListTradeMarks listTradeMarksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
        public ListTradeMarks ListTradeMarks
        {
            get
            {
                return this.listTradeMarksField;
            }
            set
            {
                this.listTradeMarksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1", IsNullable = false)]
    public partial class ListTradeMarks
    {

        private ListTrademarksBody listTradeMarksBodyField;

        /// <remarks/>
        public ListTrademarksBody ListTradeMarksBody
        {
            get
            {
                return this.listTradeMarksBodyField;
            }
            set
            {
                this.listTradeMarksBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTrademarksBody
    {

        private ListTradeMarksContentDetails listTradeMarksContentDetailsField;

        /// <remarks/>
        public ListTradeMarksContentDetails ListTradeMarksContentDetails
        {
            get
            {
                return this.listTradeMarksContentDetailsField;
            }
            set
            {
                this.listTradeMarksContentDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class ListTradeMarksContentDetails
    {

        private TrademarkSearchCriteria tradeMarkSearchCriteriaField;

        /// <remarks/>
        public TrademarkSearchCriteria TradeMarkSearchCriteria
        {
            get
            {
                return this.tradeMarkSearchCriteriaField;
            }
            set
            {
                this.tradeMarkSearchCriteriaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.iponz.govt.nz/XMLSchema/trademarks/listv1")]
    public partial class TrademarkSearchCriteria
    {

        private string titleField;

        private ushort[] statusListField;

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("StatusID", IsNullable = false)]
        public ushort[] StatusList
        {
            get
            {
                return this.statusListField;
            }
            set
            {
                this.statusListField = value;
            }
        }
    }
}