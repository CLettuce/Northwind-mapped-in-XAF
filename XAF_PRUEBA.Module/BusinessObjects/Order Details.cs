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
    public struct PK_Order_Details
    {
        [Persistent("OrderID")]
        public int OrderID;
        [Persistent("ProductID")]
        public int ProductID;
    }

    [DefaultClassOptions]
    [Persistent("Order Details"), OptimisticLocking(false)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Order_Details : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Order_Details(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        short quantity;
        double unitPrice;
        Products productID;
        Orders orderID;
        float discount;

        [Key, Persistent, Browsable(false)]
        public PK_Order_Details PK_Order_Details { get; set; }
        public Orders OrderID { get => orderID; set => SetPropertyValue(nameof(OrderID), ref orderID, value); }
        public Products ProductID { get => productID; set => SetPropertyValue(nameof(ProductID), ref productID, value); }
        [DbType("money")]
        public double UnitPrice { get => unitPrice; set => SetPropertyValue(nameof(UnitPrice), ref unitPrice, value); }

        public short Quantity { get => quantity; set => SetPropertyValue(nameof(Quantity), ref quantity, value); }
        [DbType("real")]
        public float Discount { get => discount; set => SetPropertyValue(nameof(Discount), ref discount, value); }
        

    }
}