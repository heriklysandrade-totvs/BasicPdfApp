
namespace BasicPdfApp
{
    partial class ActivePdfForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivePdfForm));
            this.lbKeyFormFields = new System.Windows.Forms.ListBox();
            this.lbValueFormFields = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNovoPdf
            // 
            this.btnNovoPdf.Click += new System.EventHandler(this.btnNovoPdf_Click);
            // 
            // btnEditPdf
            // 
            this.btnEditPdf.Click += new System.EventHandler(this.btnEditPdf_Click);
            // 
            // btnCopiaPdf
            // 
            this.btnCopiaPdf.Click += new System.EventHandler(this.btnCopiaPdf_Click);
            // 
            // btnCombPdf
            // 
            this.btnCombPdf.Click += new System.EventHandler(this.btnCombPdf_Click);
            // 
            // btnCompriPdf
            // 
            this.btnCompriPdf.Click += new System.EventHandler(this.btnCompriPdf_Click);
            // 
            // btnProtPdf
            // 
            this.btnProtPdf.Click += new System.EventHandler(this.btnProtPdf_Click);
            // 
            // btnConvertToPdf
            // 
            this.btnConvertToPdf.Click += new System.EventHandler(this.btnConvertToPdf_Click);
            // 
            // lbKeyFormFields
            // 
            this.lbKeyFormFields.FormattingEnabled = true;
            resources.ApplyResources(this.lbKeyFormFields, "lbKeyFormFields");
            this.lbKeyFormFields.Name = "lbKeyFormFields";
            // 
            // lbValueFormFields
            // 
            this.lbValueFormFields.FormattingEnabled = true;
            resources.ApplyResources(this.lbValueFormFields, "lbValueFormFields");
            this.lbValueFormFields.Name = "lbValueFormFields";
            // 
            // ActivePdfForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbValueFormFields);
            this.Controls.Add(this.lbKeyFormFields);
            this.Name = "ActivePdfForm";
            this.Deactivate += new System.EventHandler(this.ActivePdfForm_Deactivate);
            this.Controls.SetChildIndex(this.lbKeyFormFields, 0);
            this.Controls.SetChildIndex(this.lbValueFormFields, 0);
            this.Controls.SetChildIndex(this.btnNovoPdf, 0);
            this.Controls.SetChildIndex(this.btnEditPdf, 0);
            this.Controls.SetChildIndex(this.btnCopiaPdf, 0);
            this.Controls.SetChildIndex(this.btnCombPdf, 0);
            this.Controls.SetChildIndex(this.btnCompriPdf, 0);
            this.Controls.SetChildIndex(this.btnProtPdf, 0);
            this.Controls.SetChildIndex(this.btnConvertToPdf, 0);
            this.Controls.SetChildIndex(this.tbConvertPdf, 0);
            this.Controls.SetChildIndex(this.chkGerarWatchFolder, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKeyFormFields;
        private System.Windows.Forms.ListBox lbValueFormFields;
    }
}

