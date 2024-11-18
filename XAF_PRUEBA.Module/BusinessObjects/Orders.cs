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
    public class Orders : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Orders(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string shipCountry;
        string shipPostalCode;
        string shipRegion;
        string shipCity;
        string shipAddress;
        string shipName;
        double freight;
        Shippers shipVia;
        DateTime shipppedDate;
        DateTime requiredDate;
        DateTime orderDate;
        Employees employeeID;
        Customers customerID;
        int orderID;
        [Key]
        public int OrderID { get => orderID; set => SetPropertyValue(nameof(OrderID), ref orderID, value); }

        public Customers CustomerID { get => customerID; set => SetPropertyValue(nameof(CustomerID), ref customerID, value); }

        public Employees EmployeeID { get => employeeID; set => SetPropertyValue(nameof(EmployeeID), ref employeeID, value); }

        public DateTime OrderDate { get => orderDate; set => SetPropertyValue(nameof(OrderDate), ref orderDate, value); }

        public DateTime RequiredDate { get => requiredDate; set => SetPropertyValue(nameof(RequiredDate), ref requiredDate, value); }

        public DateTime ShipppedDate { get => shipppedDate; set => SetPropertyValue(nameof(ShipppedDate), ref shipppedDate, value); }

        public Shippers ShipVia { get => shipVia; set => SetPropertyValue(nameof(ShipVia), ref shipVia, value); }
        [DbType("money")]
        public double Freight { get => freight; set => SetPropertyValue(nameof(Freight), ref freight, value); }

        [Size(40)]
        public string ShipName { get => shipName; set => SetPropertyValue(nameof(ShipName), ref shipName, value); }

        [Size(60)]
        public string ShipAddress { get => shipAddress; set => SetPropertyValue(nameof(ShipAddress), ref shipAddress, value); }

        [Size(15)]
        public string ShipCity { get => shipCity; set => SetPropertyValue(nameof(ShipCity), ref shipCity, value); }

        [Size(15)]
        public string ShipRegion { get => shipRegion; set => SetPropertyValue(nameof(ShipRegion), ref shipRegion, value); }

        [Size(10)]
        public string ShipPostalCode { get => shipPostalCode; set => SetPropertyValue(nameof(ShipPostalCode), ref shipPostalCode, value); }

        [Size(15)]
        public string ShipCountry { get => shipCountry; set => SetPropertyValue(nameof(ShipCountry), ref shipCountry, value); }
    }
}