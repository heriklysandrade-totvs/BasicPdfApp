
namespace BasicPdfApp
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
      this.btnConverHtml = new System.Windows.Forms.Button();
      this.btnConverDoc = new System.Windows.Forms.Button();
      this.tbConverHtml = new System.Windows.Forms.TextBox();
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
      // btnConverHtml
      // 
      resources.ApplyResources(this.btnConverHtml, "btnConverHtml");
      this.btnConverHtml.Name = "btnConverHtml";
      this.btnConverHtml.UseVisualStyleBackColor = true;
      this.btnConverHtml.Click += new System.EventHandler(this.btnConverHtml_Click);
      // 
      // btnConverDoc
      // 
      resources.ApplyResources(this.btnConverDoc, "btnConverDoc");
      this.btnConverDoc.Name = "btnConverDoc";
      this.btnConverDoc.UseVisualStyleBackColor = true;
      // 
      // tbConverHtml
      // 
      resources.ApplyResources(this.tbConverHtml, "tbConverHtml");
      this.tbConverHtml.Name = "tbConverHtml";
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tbConverHtml);
      this.Controls.Add(this.btnConverDoc);
      this.Controls.Add(this.btnConverHtml);
      this.Controls.Add(this.btnProtPdf);
      this.Controls.Add(this.btnCompriPdf);
      this.Controls.Add(this.btnCombPdf);
      this.Controls.Add(this.lbValueFormFields);
      this.Controls.Add(this.lbKeyFormFields);
      this.Controls.Add(this.btnCopiaPdf);
      this.Controls.Add(this.btnEditPdf);
      this.Controls.Add(this.btnNovoPdf);
      this.Name = "MainForm";
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
    private System.Windows.Forms.Button btnConverHtml;
    private System.Windows.Forms.Button btnConverDoc;
    private System.Windows.Forms.TextBox tbConverHtml;
  }
}

