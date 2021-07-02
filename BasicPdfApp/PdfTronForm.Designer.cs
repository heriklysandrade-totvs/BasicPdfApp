
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
            this.tbxDefaultNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumMaxArquivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovoPdf
            // 
            resources.ApplyResources(this.btnNovoPdf, "btnNovoPdf");
            this.btnNovoPdf.Click += new System.EventHandler(this.btnNovoPdf_Click);
            // 
            // btnEditPdf
            // 
            resources.ApplyResources(this.btnEditPdf, "btnEditPdf");
            // 
            // btnCopiaPdf
            // 
            resources.ApplyResources(this.btnCopiaPdf, "btnCopiaPdf");
            this.btnCopiaPdf.Click += new System.EventHandler(this.btnCopiaPdf_Click);
            // 
            // btnCombPdf
            // 
            resources.ApplyResources(this.btnCombPdf, "btnCombPdf");
            this.btnCombPdf.Click += new System.EventHandler(this.btnCombPdf_Click);
            // 
            // btnCompriPdf
            // 
            resources.ApplyResources(this.btnCompriPdf, "btnCompriPdf");
            this.btnCompriPdf.Click += new System.EventHandler(this.btnCompriPdf_Click);
            // 
            // btnProtPdf
            // 
            resources.ApplyResources(this.btnProtPdf, "btnProtPdf");
            this.btnProtPdf.Click += new System.EventHandler(this.btnProtPdf_Click);
            // 
            // btnConvertToPdf
            // 
            resources.ApplyResources(this.btnConvertToPdf, "btnConvertToPdf");
            this.btnConvertToPdf.Click += new System.EventHandler(this.btnConvertToPdf_Click);
            // 
            // tbConvertPdf
            // 
            resources.ApplyResources(this.tbConvertPdf, "tbConvertPdf");
            // 
            // tbxDefaultNewName
            // 
            resources.ApplyResources(this.tbxDefaultNewName, "tbxDefaultNewName");
            this.tbxDefaultNewName.Name = "tbxDefaultNewName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbxNumMaxArquivos
            // 
            resources.ApplyResources(this.tbxNumMaxArquivos, "tbxNumMaxArquivos");
            this.tbxNumMaxArquivos.Name = "tbxNumMaxArquivos";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // PdfTronForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNumMaxArquivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDefaultNewName);
            this.Name = "PdfTronForm";
            this.Controls.SetChildIndex(this.btnNovoPdf, 0);
            this.Controls.SetChildIndex(this.btnEditPdf, 0);
            this.Controls.SetChildIndex(this.btnCopiaPdf, 0);
            this.Controls.SetChildIndex(this.btnCombPdf, 0);
            this.Controls.SetChildIndex(this.btnCompriPdf, 0);
            this.Controls.SetChildIndex(this.btnProtPdf, 0);
            this.Controls.SetChildIndex(this.btnConvertToPdf, 0);
            this.Controls.SetChildIndex(this.tbConvertPdf, 0);
            this.Controls.SetChildIndex(this.chkGerarWatchFolder, 0);
            this.Controls.SetChildIndex(this.tbxDefaultNewName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxNumMaxArquivos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDefaultNewName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumMaxArquivos;
        private System.Windows.Forms.Label label2;
    }
}