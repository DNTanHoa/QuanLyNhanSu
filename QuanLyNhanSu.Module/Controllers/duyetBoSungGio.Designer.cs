namespace QuanLyNhanSu.Module.Controllers
{
    partial class duyetBoSungGio
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
            this.boSungGio = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // boSungGio
            // 
            this.boSungGio.Caption = "Duyệt Đơn";
            this.boSungGio.ConfirmationMessage = null;
            this.boSungGio.Id = "f8de6fa6-9f85-45e1-8762-c796bf77de30";
            this.boSungGio.ImageName = "Task";
            this.boSungGio.TargetObjectType = typeof(QuanLyNhanSu.Module.BusinessObjects.LanBoSungGio);
            this.boSungGio.ToolTip = null;
            this.boSungGio.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.boSungGio_Execute);
            // 
            // duyetBoSungGio
            // 
            this.Actions.Add(this.boSungGio);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction boSungGio;
    }
}
