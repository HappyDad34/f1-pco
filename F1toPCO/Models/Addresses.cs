﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using F1toPCO.Model;
using System.Collections.Generic;
using F1toPCO.Models;

namespace F1toPCO.Model.F1{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRoot("addresses")]
    public class addresses {
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "address")]
        public List<address> items { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class address : BaseModel {

        private household householdField;

        private person personField;

        private addressType addressTypeField;

        private string address1Field;

        private string address2Field;

        private string address3Field;

        private string cityField;

        private string postalCodeField;

        private string countyField;

        private string countryField;

        private string stProvinceField;

        private string carrierRouteField;

        private string deliveryPointField;

        private string addressDateField;

        private string addressCommentField;

        private string uspsVerifiedField;

        private string addressVerifiedDateField;

        private string lastVerificationAttemptDateField;

        private string createdDateField;

        private string lastUpdatedDateField;

        private string uriField;

        private string idField;

        public address() {
           
        }

        /// <remarks/>
        public household household {
            get {
                return this.householdField;
            }
            set {
                SetField(ref householdField, value, "household");
            }
        }

        /// <remarks/>
        public person person {
            get {
                return this.personField;
            }
            set {
                SetField(ref personField, value, "person");
            }
        }

        /// <remarks/>
        public addressType addressType {
            get {
                return this.addressTypeField;
            }
            set {
                SetField(ref addressTypeField, value, "addressType");
            }
        }

        /// <remarks/>
        public string address1 {
            get {
                return this.address1Field;
            }
            set {
                SetField(ref address1Field, value, "address1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string address2 {
            get {
                return this.address2Field;
            }
            set {
                SetField(ref address2Field, value, "address2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string address3 {
            get {
                return this.address3Field;
            }
            set {
                SetField(ref address3Field, value, "address3");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                SetField(ref cityField, value, "city");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                SetField(ref postalCodeField, value, "postalCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string county {
            get {
                return this.countyField;
            }
            set {
                SetField(ref countyField, value, "county");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string country {
            get {
                return this.countryField;
            }
            set {
                SetField(ref countryField, value, "country");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string stProvince {
            get {
                return this.stProvinceField;
            }
            set {
                SetField(ref stProvinceField, value, "stProvince");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string carrierRoute {
            get {
                return this.carrierRouteField;
            }
            set {
                SetField(ref carrierRouteField, value, "carrierRoute");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string deliveryPoint {
            get {
                return this.deliveryPointField;
            }
            set {
                SetField(ref deliveryPointField, value, "deliveryPoint");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressDate {
            get {
                return this.addressDateField;
            }
            set {
                SetField(ref addressDateField, value, "addressDate");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressComment {
            get {
                return this.addressCommentField;
            }
            set {
                SetField(ref addressCommentField, value, "addressComment");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string uspsVerified {
            get {
                return this.uspsVerifiedField;
            }
            set {
                SetField(ref uspsVerifiedField, value, "uspsVerified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressVerifiedDate {
            get {
                return this.addressVerifiedDateField;
            }
            set {
                this.addressVerifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string lastVerificationAttemptDate {
            get {
                return this.lastVerificationAttemptDateField;
            }
            set {
                this.lastVerificationAttemptDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string lastUpdatedDate {
            get {
                return this.lastUpdatedDateField;
            }
            set {
                this.lastUpdatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                SetField(ref idField, value, "id");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class addressType : BaseModel {

        private string nameField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri {
            get {
                return this.uriField;
            }
            set {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string id {
            get {
                return this.idField;
            }
            set {
                SetField(ref idField, value, "id");
            }
        }
    }
}