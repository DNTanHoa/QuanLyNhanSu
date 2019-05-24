namespace QuanLyNhanSu.Module.Controllers
{
    partial class DuyetDiTreVeSom
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
            this.diTreVeSom = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // diTreVeSom
            // 
            this.diTreVeSom.Caption = "Duyệt Đơn";
            this.diTreVeSom.ConfirmationMessage = null;
            this.diTreVeSom.Id = "867013c9-0a3b-4c88-b274-2273d0fb31c6";
            this.diTreVeSom.ImageName = "Task";
            this.diTreVeSom.TargetObjectType = typeof(QuanLyNhanSu.Module.BusinessObjects.LanXinDiTre);
            this.diTreVeSom.ToolTip = null;
            this.diTreVeSom.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.diTreVeSom_Execute);
            // 
            // DuyetDiTreVeSom
            // 
            this.Actions.Add(this.diTreVeSom);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction diTreVeSom;
    }
}
