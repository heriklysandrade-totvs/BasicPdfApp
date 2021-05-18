
namespace BasicPdfApp
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.btnNovoPdf = new System.Windows.Forms.Button();
            this.fbdCaminhoPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEditPdf = new System.Windows.Forms.Button();
            this.ofdAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnCopiaPdf = new System.Windows.Forms.Button();
            this.btnCombPdf = new System.Windows.Forms.Button();
            this.btnCompriPdf = new System.Windows.Forms.Button();
            this.btnProtPdf = new System.Windows.Forms.Button();
            this.btnConvertToPdf = new System.Windows.Forms.Button();
            this.tbConvertPdf = new System.Windows.Forms.TextBox();
            this.chkGerarWatchFolder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNovoPdf
            // 
            resources.ApplyResources(this.btnNovoPdf, "btnNovoPdf");
            this.btnNovoPdf.Name = "btnNovoPdf";
            this.btnNovoPdf.UseVisualStyleBackColor = true;
            // 
            // btnEditPdf
            // 
            resources.ApplyResources(this.btnEditPdf, "btnEditPdf");
            this.btnEditPdf.Name = "btnEditPdf";
            this.btnEditPdf.UseVisualStyleBackColor = true;
            // 
            // ofdAbrirArquivo
            // 
            resources.ApplyResources(this.ofdAbrirArquivo, "ofdAbrirArquivo");
            // 
            // btnCopiaPdf
            // 
            resources.ApplyResources(this.btnCopiaPdf, "btnCopiaPdf");
            this.btnCopiaPdf.Name = "btnCopiaPdf";
            this.btnCopiaPdf.UseVisualStyleBackColor = true;
            // 
            // btnCombPdf
            // 
            resources.ApplyResources(this.btnCombPdf, "btnCombPdf");
            this.btnCombPdf.Name = "btnCombPdf";
            this.btnCombPdf.UseVisualStyleBackColor = true;
            // 
            // btnCompriPdf
            // 
            resources.ApplyResources(this.btnCompriPdf, "btnCompriPdf");
            this.btnCompriPdf.Name = "btnCompriPdf";
            this.btnCompriPdf.UseVisualStyleBackColor = true;
            // 
            // btnProtPdf
            // 
            resources.ApplyResources(this.btnProtPdf, "btnProtPdf");
            this.btnProtPdf.Name = "btnProtPdf";
            this.btnProtPdf.UseVisualStyleBackColor = true;
            // 
            // btnConvertToPdf
            // 
            resources.ApplyResources(this.btnConvertToPdf, "btnConvertToPdf");
            this.btnConvertToPdf.Name = "btnConvertToPdf";
            this.btnConvertToPdf.UseVisualStyleBackColor = true;
            // 
            // tbConvertPdf
            // 
            resources.ApplyResources(this.tbConvertPdf, "tbConvertPdf");
            this.tbConvertPdf.Name = "tbConvertPdf";
            // 
            // chkGerarWatchFolder
            // 
            resources.ApplyResources(this.chkGerarWatchFolder, "chkGerarWatchFolder");
            this.chkGerarWatchFolder.Checked = true;
            this.chkGerarWatchFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGerarWatchFolder.Name = "chkGerarWatchFolder";
            this.chkGerarWatchFolder.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkGerarWatchFolder);
            this.Controls.Add(this.tbConvertPdf);
            this.Controls.Add(this.btnConvertToPdf);
            this.Controls.Add(this.btnProtPdf);
            this.Controls.Add(this.btnCompriPdf);
            this.Controls.Add(this.btnCombPdf);
            this.Controls.Add(this.btnCopiaPdf);
            this.Controls.Add(this.btnEditPdf);
            this.Controls.Add(this.btnNovoPdf);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnNovoPdf;
        protected System.Windows.Forms.FolderBrowserDialog fbdCaminhoPasta;
        protected System.Windows.Forms.Button btnEditPdf;
        protected System.Windows.Forms.OpenFileDialog ofdAbrirArquivo;
        protected System.Windows.Forms.Button btnCopiaPdf;
        protected System.Windows.Forms.Button btnCombPdf;
        protected System.Windows.Forms.Button btnCompriPdf;
        protected System.Windows.Forms.Button btnProtPdf;
        protected System.Windows.Forms.Button btnConvertToPdf;
        protected System.Windows.Forms.TextBox tbConvertPdf;
        protected System.Windows.Forms.CheckBox chkGerarWatchFolder;
    }
}