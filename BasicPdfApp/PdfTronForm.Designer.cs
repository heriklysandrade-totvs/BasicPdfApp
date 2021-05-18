
namespace BasicPdfApp
{
    partial class PdfTronForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfTronForm));
            this.SuspendLayout();
            // 
            // btnNovoPdf
            // 
            this.btnNovoPdf.Click += new System.EventHandler(this.btnNovoPdf_Click);
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
            // tbConvertPdf
            // 
            resources.ApplyResources(this.tbConvertPdf, "tbConvertPdf");
            // 
            // PdfTronForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PdfTronForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}