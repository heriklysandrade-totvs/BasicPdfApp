
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
      this.btnNovoPdf = new System.Windows.Forms.Button();
      this.fbdCaminhoPasta = new System.Windows.Forms.FolderBrowserDialog();
      this.btnEditPdf = new System.Windows.Forms.Button();
      this.ofdAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
      this.btnCopiaPdf = new System.Windows.Forms.Button();
      this.lbKeyFormFields = new System.Windows.Forms.ListBox();
      this.lbValueFormFields = new System.Windows.Forms.ListBox();
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
      this.btnNovoPdf.Click += new System.EventHandler(this.btnNovoPdf_Click);
      // 
      // btnEditPdf
      // 
      resources.ApplyResources(this.btnEditPdf, "btnEditPdf");
      this.btnEditPdf.Name = "btnEditPdf";
      this.btnEditPdf.UseVisualStyleBackColor = true;
      this.btnEditPdf.Click += new System.EventHandler(this.btnEditPdf_Click);
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
      this.btnCopiaPdf.Click += new System.EventHandler(this.btnCopiaPdf_Click);
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
      // btnCombPdf
      // 
      resources.ApplyResources(this.btnCombPdf, "btnCombPdf");
      this.btnCombPdf.Name = "btnCombPdf";
      this.btnCombPdf.UseVisualStyleBackColor = true;
      this.btnCombPdf.Click += new System.EventHandler(this.btnCombPdf_Click);
      // 
      // btnCompriPdf
      // 
      resources.ApplyResources(this.btnCompriPdf, "btnCompriPdf");
      this.btnCompriPdf.Name = "btnCompriPdf";
      this.btnCompriPdf.UseVisualStyleBackColor = true;
      this.btnCompriPdf.Click += new System.EventHandler(this.btnCompriPdf_Click);
      // 
      // btnProtPdf
      // 
      resources.ApplyResources(this.btnProtPdf, "btnProtPdf");
      this.btnProtPdf.Name = "btnProtPdf";
      this.btnProtPdf.UseVisualStyleBackColor = true;
      this.btnProtPdf.Click += new System.EventHandler(this.btnProtPdf_Click);
      // 
      // btnConvertToPdf
      // 
      resources.ApplyResources(this.btnConvertToPdf, "btnConvertToPdf");
      this.btnConvertToPdf.Name = "btnConvertToPdf";
      this.btnConvertToPdf.UseVisualStyleBackColor = true;
      this.btnConvertToPdf.Click += new System.EventHandler(this.btnConvertToPdf_Click);
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
      // ActivePdfForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.chkGerarWatchFolder);
      this.Controls.Add(this.tbConvertPdf);
      this.Controls.Add(this.btnConvertToPdf);
      this.Controls.Add(this.btnProtPdf);
      this.Controls.Add(this.btnCompriPdf);
      this.Controls.Add(this.btnCombPdf);
      this.Controls.Add(this.lbValueFormFields);
      this.Controls.Add(this.lbKeyFormFields);
      this.Controls.Add(this.btnCopiaPdf);
      this.Controls.Add(this.btnEditPdf);
      this.Controls.Add(this.btnNovoPdf);
      this.Name = "ActivePdfForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnNovoPdf;
    private System.Windows.Forms.FolderBrowserDialog fbdCaminhoPasta;
    private System.Windows.Forms.Button btnEditPdf;
    private System.Windows.Forms.OpenFileDialog ofdAbrirArquivo;
    private System.Windows.Forms.Button btnCopiaPdf;
    private System.Windows.Forms.ListBox lbKeyFormFields;
    private System.Windows.Forms.ListBox lbValueFormFields;
    private System.Windows.Forms.Button btnCombPdf;
    private System.Windows.Forms.Button btnCompriPdf;
    private System.Windows.Forms.Button btnProtPdf;
    private System.Windows.Forms.Button btnConvertToPdf;
    private System.Windows.Forms.TextBox tbConvertPdf;
    private System.Windows.Forms.CheckBox chkGerarWatchFolder;
  }
}

