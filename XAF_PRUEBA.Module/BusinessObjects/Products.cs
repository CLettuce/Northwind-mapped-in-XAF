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
    public class Products : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Products(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        bool discontinued;
        short reorderLevel;
        short unitsOnOrder;
        short unitsInStock;
        double unitPrice;
        string quantityPerUnit;
        Categories categoryID;
        Suppliers supplierID;
        string productName;
        int productID;
        [Key]
        public int ProductID { get => productID; set => SetPropertyValue(nameof(ProductID), ref productID, value); }

        [Size(40)]
        public string ProductName { get => productName; set => SetPropertyValue(nameof(ProductName), ref productName, value); }

        public Suppliers SupplierID { get => supplierID; set => SetPropertyValue(nameof(SupplierID), ref supplierID, value); }

        public Categories CategoryID { get => categoryID; set => SetPropertyValue(nameof(CategoryID), ref categoryID, value); }

        [Size(20)]
        public string QuantityPerUnit { get => quantityPerUnit; set => SetPropertyValue(nameof(QuantityPerUnit), ref quantityPerUnit, value); }
        [DbType("money")]
        public double UnitPrice { get => unitPrice; set => SetPropertyValue(nameof(UnitPrice), ref unitPrice, value); }
        [DbType("smallint")]
        public short UnitsInStock { get => unitsInStock; set => SetPropertyValue(nameof(UnitsInStock), ref unitsInStock, value); }
        [DbType("smallint")]
        public short UnitsOnOrder { get => unitsOnOrder; set => SetPropertyValue(nameof(UnitsOnOrder), ref unitsOnOrder, value); }

        public short ReorderLevel { get => reorderLevel; set => SetPropertyValue(nameof(ReorderLevel), ref reorderLevel, value); }

        public bool Discontinued { get => discontinued; set => SetPropertyValue(nameof(Discontinued), ref discontinued, value); }
    }
}