using System.Windows.Forms;
using APToolkitNET;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using APDocConverter;
using System.IO;

namespace BasicPdfApp
{
  public partial class ActivePdfForm : Form
  {
    const float INCH = 72f;

    const string CONVERTER_DEFAULT_OUTPUT_PATH = "C:\\ProgramData\\ActivePDF\\DocConverter\\Watch Folders\\Default\\Output\\";

    public ActivePdfForm()
    {
      InitializeComponent();
    }

    #region Auxiliares

    private string GetFilePath(string fullFileName)
    {
      if (chkGerarWatchFolder.Checked)
        return CONVERTER_DEFAULT_OUTPUT_PATH;
      
      return fullFileName.TrimEnd(fullFileName.Split("\\\\").Last().ToCharArray());
    }

    private string GetNewFileName(OpenFileDialog fileDialog, FileNameOptionEnum nameOptionEnum)
    {
      return this.GetNewFileName(fileDialog.FileName, nameOptionEnum);
    }

    private string GetNewFileName(string fullFileName, FileNameOptionEnum nameOptionEnum)
    {
      switch (nameOptionEnum)
      {
        case FileNameOptionEnum.Edit:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().TrimEnd(".pdf".ToCharArray())}_edit_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Copy:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().TrimEnd(".pdf".ToCharArray())}_copy_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Merge:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().TrimEnd(".pdf".ToCharArray())}_merge_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Encrypt:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().TrimEnd(".pdf".ToCharArray())}_encrypt_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Compress:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().TrimEnd(".pdf".ToCharArray())}_compress_{new Random().Next(0, 200)}.pdf";

        case FileNameOptionEnum.Convert:
          return this.GetFilePath(fullFileName) + $"{fullFileName.Split("\\").Last().Split('.').First()}_convert_{new Random().Next(0, 200)}.pdf";

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
        if (!chkGerarWatchFolder.Checked)
          fbdCaminhoPasta.ShowDialog();

        var caminhoDestino = chkGerarWatchFolder.Checked ? CONVERTER_DEFAULT_OUTPUT_PATH : fbdCaminhoPasta.SelectedPath;

        oTK.OpenOutputFile(caminhoDestino + $"\\new_{new Random().Next(0, 200)}.pdf");

        // Each time a new page is required call NewPage
        oTK.NewPage();

        // Get the current version of Toolkit and save it to print on the PDF
        string tkVer = oTK.ToolkitVersion;

        oTK.SetFont("Helvetica", 24);
        oTK.PrintText(INCH, 10f * INCH, $"Hello! Version {tkVer}");
        oTK.PrintText(INCH, 9.5f * INCH, $"Date: {DateTime.Now}");

        oTK.PrintJPEG(caminhoDestino + "\\autotest.jpg", INCH, 8 * INCH, 110.0f, 107.0f, true);
        oTK.CloseOutputFile();
      }
    }

    private void btnCopiaPdf_Click(object sender, EventArgs e)
    {
      if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
      {
        using (Toolkit oTK = new Toolkit())
        {
          oTK.OpenOutputFile(this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Copy));
          oTK.OpenInputFile(ofdAbrirArquivo.FileName);

          oTK.CopyForm(0, 0);
          oTK.CloseOutputFile();
        }
      }
    }

    //Funções básicas OK
    //Necessita mais testes para validar o preenchimento de campos de 'Formulário'
    private void btnEditPdf_Click(object sender, EventArgs e)
    {
      if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
      {
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
    }

    private void btnCombPdf_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Selecione os arquivos a serem combinados");

      ofdAbrirArquivo.Multiselect = true;

      if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
      {
        using (Toolkit oTK = new Toolkit())
        {
          var mergedFileName = GetFilePath(ofdAbrirArquivo.FileNames[0]) + String.Join('_', ofdAbrirArquivo.SafeFileNames.Select(x => x.TrimEnd(".pdf".ToCharArray())));
          oTK.OpenOutputFile(GetNewFileName(mergedFileName, FileNameOptionEnum.Merge));

          foreach (var item in ofdAbrirArquivo.FileNames)
          {
            oTK.MergeFile(item, 0, 0);
          }

          oTK.CloseOutputFile();
        }
      }
    }

    private void btnProtPdf_Click(object sender, EventArgs e)
    {
      if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
      {
        using (Toolkit oTK = new Toolkit())
        {
          oTK.EncryptPDF(5, ofdAbrirArquivo.FileName, this.GetNewFileName(ofdAbrirArquivo, FileNameOptionEnum.Encrypt), "senhateste", "senhateste", false, false, false, false);
        }
      }
    }

    private void btnCompriPdf_Click(object sender, EventArgs e)
    {
      if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
      {
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
    }

    private void btnConvertToPdf_Click(object sender, EventArgs e)
    {
      ofdAbrirArquivo.Multiselect = false;
      ofdAbrirArquivo.Filter = string.Empty;

      DocConverter oDC = new DocConverter();

      if (string.IsNullOrEmpty(tbConvertPdf.Text))
      {
        if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
        {
          var result = oDC.ConvertToPDF(ofdAbrirArquivo.FileName, GetNewFileName(ofdAbrirArquivo.FileName, FileNameOptionEnum.Convert));

          MessageBox.Show(result.DocConverterStatus.ToString());
        }
      }
      else
      {
        var result = oDC.ConvertToPDF(tbConvertPdf.Text, $"convert_{tbConvertPdf.Text}.pdf");

        MessageBox.Show(result.DocConverterStatus.ToString());
      }

      oDC = null;

      //var byteArrayFile = Teste(ofdAbrirArquivo.FileName);
      //MemoryStream msFile = new MemoryStream(byteArrayFile);

      //var result2 = oDC.ConvertToPDF(msFile, ToPDFFunction.FromTXT, out MemoryStream msResultFile);
      //MessageBox.Show(result.DocConverterStatus.ToString());

      //if (result.DocConverterStatus != DCDK.Results.DocConverterStatus.ConversionFailed)
      //{
      //  File.WriteAllBytes(GetFilePath(ofdAbrirArquivo) + "\\test_convert.docx", msResultFile.ToArray());
      //}
    }

    private byte[] Teste(string filename)
    {
      FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

      // Create a byte array of file stream length
      byte[] bytes = File.ReadAllBytes(filename);


      //Read block of bytes from stream into the byte array
      fs.Read(bytes, 0, Convert.ToInt32(fs.Length));

      //Close the File Stream
      fs.Close();
      return bytes; //return the byte data
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