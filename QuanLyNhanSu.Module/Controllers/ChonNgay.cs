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
using QuanLyNhanSu.Module.BusinessObjects;

namespace QuanLyNhanSu.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ChonNgay : ViewController
    {
        private ChoiceActionItem tenBoPhan;
        private ChoiceActionItem ngayChon;
        public ChonNgay()
        {
            InitializeComponent();
            chonBoPhan.Items.Clear();
            chonNgayBaoCao.Items.Clear();
            chonNgayKetThuc.Items.Clear();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            IList<BoPhan> boPhans = ObjectSpace.GetObjects<BoPhan>();
            if (!Equals(boPhans, null))
            {
                foreach (BoPhan boPhan in boPhans)
                {
                    tenBoPhan = new ChoiceActionItem();
                    tenBoPhan.Caption = boPhan.tenBoPhan;
                    chonBoPhan.Items.Add(tenBoPhan);
                }
            }
            IList<NgayTinhCong> ngayTinhCongs = ObjectSpace.GetObjects<NgayTinhCong>();
            if (!Equals(ngayTinhCongs, null))
            {
                foreach(NgayTinhCong ngay in ngayTinhCongs)
                {
                    ngayChon = new ChoiceActionItem();
                    ngayChon.Caption = ngay.ngayChamCong.ToString();
                    chonNgayBaoCao.Items.Add(ngayChon);
                    chonNgayKetThuc.Items.Add(ngayChon);
                }
            }
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

        private void chonNgayBaoCao_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {

        }

        private void chonNgayKetThuc_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {

        }

        private void chonBoPhan_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {

        }
    }
}
