namespace QuanLyNhanSu.Module.Controllers
{
    partial class ChonNgay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chonNgayBaoCao = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            this.chonNgayKetThuc = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            this.chonBoPhan = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // chonNgayBaoCao
            // 
            this.chonNgayBaoCao.Caption = "Từ Ngày";
            this.chonNgayBaoCao.ConfirmationMessage = null;
            this.chonNgayBaoCao.EmptyItemsBehavior = DevExpress.ExpressApp.Actions.EmptyItemsBehavior.None;
            this.chonNgayBaoCao.Id = "chonNgayBaoCao";
            this.chonNgayBaoCao.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.CaptionAndImage;
            this.chonNgayBaoCao.TargetViewId = "GioCong_ListView";
            this.chonNgayBaoCao.ToolTip = null;
            this.chonNgayBaoCao.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.chonNgayBaoCao_Execute);
            // 
            // chonNgayKetThuc
            // 
            this.chonNgayKetThuc.Caption = "Đến Ngày";
            this.chonNgayKetThuc.ConfirmationMessage = null;
            this.chonNgayKetThuc.EmptyItemsBehavior = DevExpress.ExpressApp.Actions.EmptyItemsBehavior.None;
            this.chonNgayKetThuc.Id = "chonNgayKetThuc";
            this.chonNgayKetThuc.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.CaptionAndImage;
            this.chonNgayKetThuc.TargetViewId = "GioCong_ListView";
            this.chonNgayKetThuc.ToolTip = null;
            this.chonNgayKetThuc.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.chonNgayKetThuc_Execute);
            // 
            // chonBoPhan
            // 
            this.chonBoPhan.Caption = "Bộ Phận";
            this.chonBoPhan.ConfirmationMessage = null;
            this.chonBoPhan.EmptyItemsBehavior = DevExpress.ExpressApp.Actions.EmptyItemsBehavior.None;
            this.chonBoPhan.Id = "chonBoPhan";
            this.chonBoPhan.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.CaptionAndImage;
            this.chonBoPhan.TargetViewId = "GioCong_ListView";
            this.chonBoPhan.ToolTip = null;
            this.chonBoPhan.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.chonBoPhan_Execute);
            // 
            // ChonNgay
            // 
            this.Actions.Add(this.chonNgayBaoCao);
            this.Actions.Add(this.chonNgayKetThuc);
            this.Actions.Add(this.chonBoPhan);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SingleChoiceAction chonNgayBaoCao;
        private DevExpress.ExpressApp.Actions.SingleChoiceAction chonNgayKetThuc;
        private DevExpress.ExpressApp.Actions.SingleChoiceAction chonBoPhan;
    }
}
