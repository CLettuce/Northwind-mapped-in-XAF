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

    public struct PK_CustomerCustomerDemo
    {
        [Persistent("OrderID")]
        public string CustomerID;
        [Persistent("ProductID")]
        public string CustomerTypeID;
    }
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CustomerCustomerDemo : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CustomerCustomerDemo(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        [Key, Persistent, Browsable(false)]
        public PK_CustomerCustomerDemo PK_CustomerCustomerDemo { get; set; }

        string customerTypeID;
        string customerID;

        [Size(5)]
        public string CustomerID { get => customerID; set => SetPropertyValue(nameof(CustomerID), ref customerID, value); }

        [Size(10)]
        public string CustomerTypeID { get => customerTypeID; set => SetPropertyValue(nameof(CustomerTypeID), ref customerTypeID, value); }

    }
}