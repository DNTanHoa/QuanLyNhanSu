using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Persistent(@"LanBoSungGio")]
    [XafDisplayName("Lần Bổ Sung Giờ")]
    [Appearance("ngayDuyet", BackColor = "red", FontColor = "white", Context = "ListView", TargetItems = "nguoiBoSungGio", Criteria = "ngayDuyet = null")]
    public class LanBoSungGio:XPLiteObject
    {
        public LanBoSungGio(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        protected override void OnSaved()
        {
            base.OnSaved();
            if (this.thoiGianBoSung == null)
            {
                this.Delete();
            }
        }
        int fId;
        [Key(true)]
        [XafDisplayName("STT")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue("Id", ref fId, value); }
        }
        NhanVien fnguoiBoSungGio;
        [XafDisplayName("Người Bổ Sung Giờ")]
        [Association(@"NhanVien-LanBoSungGio")]
        public NhanVien nguoiBoSungGio
        {
            get { return fnguoiBoSungGio; }
            set { SetPropertyValue("nguoiBoSungGio", ref fnguoiBoSungGio, value); }
        }
        DateTime? fThoiGianBoSung;
        [XafDisplayName("Ngày Tạo Bổ Sung")]
        public DateTime? thoiGianBoSung
        {
            get { return fThoiGianBoSung;}
            set { SetPropertyValue("thoiGianBoSung", ref fThoiGianBoSung, value); }
        }
        DateTime? fThoiGianVao;
        [XafDisplayName("Thời Gian Vào")]
        [ModelDefault("DisplayFormat", "{0:HH:mm}")]
        [ModelDefault("EditMask", "{HH:mm}")]
        public DateTime? thoiGianVao
        {
            get { return fThoiGianVao; }
            set { SetPropertyValue("thoiGianVao", ref fThoiGianVao, value); }
        }
        DateTime? fThoiGianRaGiuaCa;
        [XafDisplayName("Thời Gian Ra Giữa Ca")]
        [ModelDefault("DisplayFormat", "{0:HH:mm}")]
        [ModelDefault("EditMask", "{HH:mm}")]
        public DateTime? thoiGianRaGiuaCa
        {
            get { return fThoiGianRaGiuaCa; }
            set { SetPropertyValue("thoiGianRaGiuaCa", ref fThoiGianRaGiuaCa, value); }
        }
        DateTime? fThoiGianVaoGiuaCa;
        [XafDisplayName("Thời Gian Vào Giữa Ca")]
        [ModelDefault("DisplayFormat", "{0:HH:mm}")]
        [ModelDefault("EditMask", "{HH:mm}")]
        public DateTime? thoiGianVaoGiuaCa
        {
            get { return fThoiGianVaoGiuaCa; }
            set { SetPropertyValue("thoiGianVaoGiuaCa", ref fThoiGianVaoGiuaCa, value); }
        }
        DateTime? fThoiGianTanCa;
        [XafDisplayName("Thời Gian Tan Ca")]
        [ModelDefault("DisplayFormat", "{0:HH:mm}")]
        [ModelDefault("EditMask", "{HH:mm}")]
        public DateTime? thoiGianTanCa
        {
            get { return fThoiGianTanCa; }
            set { SetPropertyValue("thoiGianTanCa", ref fThoiGianTanCa, value); }
        }
        NguoiDung fNguoiDuyet;
        [XafDisplayName("Người Duyệt")]
        [ModelDefault("AllowEdit","false")]
        public NguoiDung nguoiDuyet
        {
            get { return fNguoiDuyet; }
            set { SetPropertyValue("nguoiDuyet", ref fNguoiDuyet, value); }
        }
        DateTime? fNgayDuyet;
        [XafDisplayName("Ngày Duyệt")]
        [ModelDefault("AllowEdit", "false")]
        public DateTime? ngayDuyet
        {
            get { return fNgayDuyet; }
            set { SetPropertyValue("ngayDuyet", ref fNgayDuyet, value); }
        }
        string fLyDo;
        [XafDisplayName("Lý Do")]
        public string lyDo
        {
            get { return fLyDo; }
            set { SetPropertyValue("lyDo", ref fLyDo, value); }
        }
        string fGhiChu;
        [XafDisplayName("Ghi Chú")]
        public string ghiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue("ghiChu", ref fGhiChu, value); }
        }
        GioCong fgioCong;
        [XafDisplayName("Giờ Công")]
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        [Association(@"GiocCong-LanBoSungGio")]
        public GioCong gioCong
        {
            get { return fgioCong; }
            set { SetPropertyValue("gioCong", ref fgioCong, value); }
        }
    }
}
