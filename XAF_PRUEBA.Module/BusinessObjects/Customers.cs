using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAF_PRUEBA.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Customers : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Customers(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string fax;
        string phone;
        string country;
        string postalCode;
        string region;
        string city;
        string address;
        string contactTittle;
        string contactName;
        string companyName;
        string customerID;

        [Key]
        [Size(5)]
        public string CustomerID { get => customerID; set => SetPropertyValue(nameof(CustomerID), ref customerID, value); }

        [Size(40)]
        public string CompanyName { get => companyName; set => SetPropertyValue(nameof(CompanyName), ref companyName, value); }

        [Size(30)]
        public string ContactName { get => contactName; set => SetPropertyValue(nameof(ContactName), ref contactName, value); }

        [Size(30)]
        public string ContactTitle { get => contactTittle; set => SetPropertyValue(nameof(ContactTitle), ref contactTittle, value); }

        [Size(60)]
        public string Address { get => address; set => SetPropertyValue(nameof(Address), ref address, value); }

        [Size(15)]
        public string City { get => city; set => SetPropertyValue(nameof(City), ref city, value); }

        [Size(15)]
        public string Region { get => region; set => SetPropertyValue(nameof(Region), ref region, value); }

        [Size(10)]
        public string PostalCode { get => postalCode; set => SetPropertyValue(nameof(PostalCode), ref postalCode, value); }

        [Size(15)]
        public string Country { get => country; set => SetPropertyValue(nameof(Country), ref country, value); }

        [Size(24)]
        public string Phone { get => phone; set => SetPropertyValue(nameof(Phone), ref phone, value); }

        [Size(24)]
        public string Fax { get => fax; set => SetPropertyValue(nameof(Fax), ref fax, value); }
    }
}