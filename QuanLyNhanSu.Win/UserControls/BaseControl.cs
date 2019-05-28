using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ExpressApp;

namespace QuanLyNhanSu.Win.UserControls
{
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(14, 110, 198);
        }
        public string LinkText
        {
            get { return linkLabel1.Text; }
            set { linkLabel1.Text = value; }
        }
        public string ListViewId { get; set; }
        public bool ShowColor { get; set; }
        private Type type;
        private IObjectSpace objectSpace;
        private XafApplication application;

        public void Setup(IObjectSpace objectSpace, XafApplication application, Type type)
        {
            this.objectSpace = objectSpace;
            this.application = application;
            this.type = type;

            NewMethod();
        }
        public override void Refresh()
        {
            NewMethod();
        }

        private void NewMethod()
        {
            CollectionSourceBase collectionSource = application.CreateCollectionSource(objectSpace, type, ListViewId);
            string criteria = application.Model.Views[ListViewId].GetValue<string>("Criteria");
            collectionSource.SetCriteria("Filter1", criteria);
            var count = collectionSource.GetCount();
            this.label1.Text = count.ToString();
            if (count > 0 && ShowColor)
                this.BackColor = Color.FromArgb(203, 46, 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseControl_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowViewParameters svp = new ShowViewParameters();
            IObjectSpace newObjectSpace = application.CreateObjectSpace();
            CollectionSourceBase collectionSource = application.CreateCollectionSource(newObjectSpace, type, ListViewId);

            DevExpress.ExpressApp.ListView lv = application.CreateListView(ListViewId, collectionSource, true);
            svp.CreatedView = lv;
            application.ShowViewStrategy.ShowView(svp, new ShowViewSource(application.MainWindow, null));
        }
    }
}
