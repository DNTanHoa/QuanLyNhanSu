using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
using QuanLyNhanSu.Module.BusinessObjects;

namespace QuanLyNhanSu.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class duyetBoSungGio : ViewController
    {
        public duyetBoSungGio()
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

        private void boSungGio_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            LanBoSungGio lanXinPhep = (LanBoSungGio)View.CurrentObject;

            lanXinPhep.ngayDuyet = DateTime.Now;
            lanXinPhep.nguoiDuyet = lanXinPhep.Session.GetObjectByKey<NguoiDung>(SecuritySystem.CurrentUserId);
            MessageBox.Show("Đã Duyệt Thành Công");

            CriteriaOperator criteriaOperator = CriteriaOperator.And(CriteriaOperator.Parse("[nguoiChamCong] = ?", lanXinPhep.nguoiBoSungGio), CriteriaOperator.Parse("[ngay.ngayChamCong] = ?", lanXinPhep.thoiGianBoSung));
            GioCong gio = ObjectSpace.FindObject<GioCong>(criteriaOperator);
            if (!Equals(gio, null))
            {
                if (!Equals(lanXinPhep.thoiGianVao, null))
                {
                    gio.thoiGianVaoCaSaved = lanXinPhep.thoiGianVao;
                }
                if (!Equals(lanXinPhep.thoiGianRaGiuaCa, null))
                {
                    gio.thoiGianRaGiuaCaSaved = lanXinPhep.thoiGianRaGiuaCa;
                }
                if (!Equals(lanXinPhep.thoiGianVaoGiuaCa, null))
                {
                    gio.thoiGianVaoGiuaCaSaved = lanXinPhep.thoiGianVaoGiuaCa;
                }
                if (!Equals(lanXinPhep.thoiGianTanCa, null))
                {
                    gio.thoiGianTanCaSaved = lanXinPhep.thoiGianTanCa;
                }
                gio.ngayDuyet = lanXinPhep.ngayDuyet;
                lanXinPhep.gioCong = gio;
            }

            ObjectSpace.CommitChanges();
            ObjectSpace.Refresh();
            View.Refresh();
        }
    }
}
