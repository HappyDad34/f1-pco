﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace F1toPCO.Model.F1 {

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRoot("attributes")]
    public class peopleAttributes {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attribute")]
        public List<peopleAttribute> peopleAttribute { get; set; }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class peopleAttribute {

        private string _id;

        private string _uri;

        private person _person;

        private attributeGroup _attributeGroup;

        private string _startDate;

        private string _endDate;

        private string _comment;

        private string _createdDate;

        private string _lastUpdatedDate;

        public peopleAttribute() {

        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "id")]
        public string id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "uri")]
        public string uri {
            get {
                return this._uri;
            }
            set {
                this._uri = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "person", IsNullable = true)]
        public person person {
            get {
                return this._person;
            }
            set {
                this._person = value;
            }
        }
    
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attributeGroup", IsNullable = true)]
        public attributeGroup attributeGroup {
            get {
                return this._attributeGroup;
            }
            set {
                this._attributeGroup = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "startDate", IsNullable = true)]
        public string startDate {
            get {
                return this._startDate;
            }
            set {
                this._startDate = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "endDate", IsNullable = true)]
        public string endDate {
            get {
                return this._endDate;
            }
            set {
                this._endDate = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "comment", IsNullable = true)]
        public string comment {
            get {
                return this._comment;
            }
            set {
                this._comment = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "createDate", IsNullable = true)]
        public string createdDate {
            get {
                return this._createdDate;
            }
            set {
                this._createdDate = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "lastUpdatedDate", IsNullable = true)]
        public string lastUpdatedDate {
            get {
                return this._lastUpdatedDate;
            }
            set {
                this._lastUpdatedDate = value;
            }
        }
    }
}