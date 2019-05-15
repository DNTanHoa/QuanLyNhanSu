using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.XtraReports.UI;
using QuanLyNhanSu.Module.BusinessObjects;
using QuanLyNhanSu.Module.Reports;

namespace QuanLyNhanSu.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class XuatBaoCaoGioCong : ViewController
    {
        public XuatBaoCaoGioCong()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void xuatGioCong_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            BaoCaoGioCong formBaoCao = new BaoCaoGioCong();
            FormChonNgayBaoCaoGioCong formChonNgay = new FormChonNgayBaoCaoGioCong();
            formChonNgay.ShowDialog();
            //IList<NgayTinhCong> gioCongs = ObjectSpace.GetObjects<NgayTinhCong>();
            //formBaoCao.DataSource = gioCongs;
            //ReportPrintTool tool = new ReportPrintTool(formBaoCao);
            //tool.ShowPreviewDialog();
        }
    }
}
