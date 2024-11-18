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
    public class Employees : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Employees(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string lastName;
        string photoPath;
        int reportsTo;
        string notes;
        byte[] photo;
        string extension;
        string homePhone;
        string country;
        string postalCode;
        string region;
        string city;
        string address;
        DateTime hireDay;
        DateTime birthDay;
        string titleOfCourtesy;
        string title;
        string firstName;
        int employeeID;

        [Key]
        public int EmployeeID { get => employeeID; set => SetPropertyValue(nameof(EmployeeID), ref employeeID, value); }

        [Size(10)]
        public string FirstName { get => firstName; set => SetPropertyValue(nameof(FirstName), ref firstName, value); }

        [Size(20)]
        public string LastName { get => lastName; set => SetPropertyValue(nameof(LastName), ref lastName, value); }

        [Size(30)]
        public string Title { get => title; set => SetPropertyValue(nameof(Title), ref title, value); }

        [Size(25)]
        public string TitleOfCourtesy { get => titleOfCourtesy; set => SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value); }

        public DateTime BirthDay { get => birthDay; set => SetPropertyValue(nameof(BirthDay), ref birthDay, value); }

        public DateTime HireDay { get => hireDay; set => SetPropertyValue(nameof(HireDay), ref hireDay, value); }

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
        public string HomePhone { get => homePhone; set => SetPropertyValue(nameof(HomePhone), ref homePhone, value); }

        [Size(4)]
        public string Extension { get => extension; set => SetPropertyValue(nameof(Extension), ref extension, value); }

        [VisibleInListView(true)]
        [ImageEditor(
    ListViewImageEditorMode = ImageEditorMode.PictureEdit,
    DetailViewImageEditorMode = ImageEditorMode.PictureEdit,
    ListViewImageEditorCustomHeight = 200,
    DetailViewImageEditorFixedHeight = 300)]
        public byte[] Photo { get => photo; set => SetPropertyValue(nameof(Photo), ref photo, value); }


        [Size(SizeAttribute.Unlimited)]
        public string Notes { get => notes; set => SetPropertyValue(nameof(Notes), ref notes, value); }

        public int ReportsTo { get => reportsTo; set => SetPropertyValue(nameof(ReportsTo), ref reportsTo, value); }

        [Size(255)]
        public string PhotoPath { get => photoPath; set => SetPropertyValue(nameof(PhotoPath), ref photoPath, value); }

    }
}