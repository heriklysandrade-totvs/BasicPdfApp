using System.Windows.Forms;
using APToolkitNET;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using APDocConverter;

namespace BasicPdfApp
{
  public partial class MainForm : Form
  {
    const float INCH = 72f;

    public MainForm()
    {
      InitializeComponent();
    }

    #region Auxiliares

    private string GetFilePath(OpenFileDialog fileDialog)
    {
      return fileDialog.FileName.TrimEnd(fileDialog.SafeFileName.ToCharArray());
    }

    private string GetNewFileName(OpenFileDialog fileDialog, FileNameOptionEnum nameOptionEnum)
    {
      switch (nameOptionEnum)
      {
        case FileNameOptionEnum.Edit:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_edit_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Copy:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_copy_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Merge:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_merge_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Encrypt:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_encrypt_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Compress:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_compress_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Convert:
          return this.GetFilePath(fileDialog) + $"{ofdAbrirArquivo.SafeFileName.TrimEnd(".pdf".ToCharArray())}_convert_{new Random().Next(0, 200)}.pdf";

        default:
          return string.Empty;
      }
    }

    #endregion

    private void btnNovoPdf_Click(object sender, System.EventArgs e)
    {
      using (Toolkit oTK = new Toolkit
      {
        // Set the PDF page Height and Width (72 = 1")
        OutputPageHeight = 11f * INCH,
        OutputPageWidth = 8.5f * INCH
      })
      {

        fbdCaminhoPasta.ShowDialog();

        int intOpenOutputFile = oTK.OpenOutputFile(fbdCaminhoPasta.SelectedPath + "\\new.pdf");

        // Each time a new page is required call NewPage
        oTK.NewPage();

        // Get the current version of Toolkit and save it to print on the PDF
        string tkVer = oTK.ToolkitVersion;

        oTK.SetFont("Helvetica", 24);
        oTK.PrintText(INCH, 10f * INCH, $"Hello! Version {tkVer}");
        oTK.PrintText(INCH, 9.5f * INCH, $"Date: {DateTime.Now}");

        oTK.PrintJPEG(fbdCaminhoPasta.SelectedPath + "\\autotest.jpg", INCH, 8 * INCH, 110.0f, 107.0f, true);
        oTK.CloseOutputFile();
      }
    }

    private void btnCopiaPdf_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.ShowDialog();

      using (Toolkit oTK = new Toolkit())
      {
        oTK.OpenOutputFile(this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Copy));
        oTK.OpenInputFile(ofdAbrirArquivo.FileName);

        oTK.CopyForm(0, 0);
        oTK.CloseOutputFile();
      }
    }

    private void btnEditPdf_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.ShowDialog();

      using (Toolkit oTK = new Toolkit())
      {
        oTK.OpenOutputFile(this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Edit));
        oTK.OpenInputFile(ofdAbrirArquivo.FileName);

        BindingList<object> blFormFieldValues = new BindingList<object>();

        foreach (DictionaryEntry item in oTK.GetInputFields())
        {
          lbKeyFormFields.Items.Add(item.Key);
          blFormFieldValues.Add(item.Value);
        }

        oTK.DoFormFormatting = 1;
        oTK.FormNumbering = 1;
        oTK.SetFormFieldData("topmostSubform[0].Page1[0].f1_1[0]", "Jeremy Likness", 1);
        //oTK.SetFormFieldData("topmostSubform[0].Page1[0].Address[0].f1_7[0]", "28202 Cabot Rd Ste 155", 1);
        //oTK.SetFormFieldData("topmostSubform[0].Page1[0].Address[0].f1_8[0]", "Laguna Niguel, CA 92677", 1);

        oTK.CopyForm(0, 0);

        blFormFieldValues.ToList().ForEach(x => lbValueFormFields.Items.Add(x));

        oTK.CloseOutputFile();
      }
    }

    private void btnCombPdf_Click(object sender, EventArgs e)
    {
      fbdCaminhoPasta.ShowDialog();

      using (Toolkit oTK = new Toolkit())
      {
        oTK.OpenOutputFile(fbdCaminhoPasta.SelectedPath + "\\teste_merge.pdf");
        oTK.MergeFile(fbdCaminhoPasta.SelectedPath + "\\new.pdf", 0, 0);
        oTK.MergeFile(fbdCaminhoPasta.SelectedPath + "\\fw9.pdf", 0, 0);
        oTK.MergeFile(fbdCaminhoPasta.SelectedPath + "\\CertificadoCODEC.pdf", 0, 0);
        oTK.CloseOutputFile();
      }
    }

    private void btnProtPdf_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.ShowDialog();

      using (Toolkit oTK = new Toolkit())
      {
        oTK.EncryptPDF(5, ofdAbrirArquivo.FileName, this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Encrypt), "senhateste", "senhateste", false, false, false, false);
      }
    }

    private void btnCompriPdf_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.ShowDialog();

      using (Toolkit oTK = new Toolkit())
      {
        oTK.OpenInputFile(ofdAbrirArquivo.FileName);
        
        var compressor = oTK.GetCompressor();
        compressor.CompressImages = true;
        compressor.CompressObjects = true;
        compressor.CompressionQuality = 20;
        compressor.Activate();

        oTK.OpenOutputFile(this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Compress));

        oTK.CopyForm(0, 0);

        oTK.CloseOutputFile();
      }
    }

    private void btnConverHtml_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.ShowDialog();

      DocConverter oDC = new DocConverter();

      var result = oDC.ConvertToPDF(ofdAbrirArquivo.FileName, this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Convert));

      MessageBox.Show(result.DocConverterStatus.ToString());
    }
  }

  public enum FileNameOptionEnum : int
  {
    Edit = 1,
    Copy = 2,
    Merge = 3,
    Encrypt = 4,
    Compress = 5,
    Convert = 6
  }
}