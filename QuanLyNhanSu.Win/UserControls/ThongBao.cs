using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp;
using QuanLyNhanSu.Module.BusinessObjects;

namespace QuanLyNhanSu.Win.UserControls
{
    public partial class ThongBao : UserControl,IComplexControl
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        void IComplexControl.Refresh()
        {
            baseControl1.Refresh();
            baseControl2.Refresh();
            baseControl3.Refresh();
            baseControl4.Refresh();
            baseControl5.Refresh();
            baseControl6.Refresh();
            baseControl7.Refresh();
            baseControl8.Refresh();

        }

        void IComplexControl.Setup(IObjectSpace objectSpace, XafApplication application)
        {
            baseControl1.Setup(objectSpace, application, typeof(LanTangCa));
            baseControl2.Setup(objectSpace, application, typeof(LanTangCa));
            baseControl3.Setup(objectSpace, application, typeof(LanXinDiTre));
            baseControl4.Setup(objectSpace, application, typeof(LanXinDiTre));
            baseControl5.Setup(objectSpace, application, typeof(LanNghiPhep));
            baseControl6.Setup(objectSpace, application, typeof(LanNghiPhep));
            baseControl7.Setup(objectSpace, application, typeof(LanBoSungGio));
            baseControl8.Setup(objectSpace, application, typeof(LanBoSungGio));

        }

        private void baseControl1_Load(object sender, EventArgs e)
        {

        }

        private void baseControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
