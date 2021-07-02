using pdftron;
using pdftron.Common;
using pdftron.PDF;
using pdftron.SDF;
using System;
using System.Windows.Forms;
using System.Linq;

namespace BasicPdfApp
{
    public partial class PdfTronForm : BaseForm
    {
        public PdfTronForm()
        {
            InitializeComponent();

            PDFNetLoader loader = PDFNetLoader.Instance();
            PDFNet.SetTempPath("C:\\ProgramData\\ActivePDF\\DocConverter\\Watch Folders\\Default\\Temp");
            PDFNet.Initialize();
            HTML2PDF.SetModulePath(Environment.CurrentDirectory + "\\html2pdf.dll");
        }

        private void btnNovoPdf_Click(object sender, System.EventArgs e)
        {
            // Using PDFNet related classes and methods, must 
            // catch or throw PDFNetException
            try
            {
                using (PDFDoc doc = new PDFDoc())
                {
                    using (Stamper s = new Stamper(Stamper.SizeType.e_relative_scale, 0.5, 0.5))
                    {
                        var randomNumber = new Random().Next(0, System.Convert.ToInt32(tbxNumMaxArquivos.Text));
                        doc.InitSecurityHandler();

                        // An example of creating a new page and adding it to
                        // doc's sequence of pages
                        Page newPg = doc.PageCreate();
                        doc.PagePushBack(newPg);

                        s.SetAlignment(Stamper.HorizontalAlignment.e_horizontal_center, Stamper.VerticalAlignment.e_vertical_center);
                        s.SetFontColor(new ColorPt(1, 0, 0)); // set text color to red 
                        s.StampText(doc, $"{tbxDefaultNewName.Text} document {randomNumber}", new PageSet(1, doc.GetPageCount()));

                        var caminhoDestino = chkGerarWatchFolder.Checked ? CONVERTER_DEFAULT_OUTPUT_PATH : fbdCaminhoPasta.SelectedPath;

                        // Save as a linearized file which is most popular 
                        // and effective format for quick PDF Viewing.
                        doc.Save(caminhoDestino + $"\\{tbxDefaultNewName.Text}_{randomNumber}.pdf", SDFDoc.SaveOptions.e_linearized);
                    }
                }
            }
            catch (PDFNetException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCopiaPdf_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                using (PDFDoc in_doc = new PDFDoc(ofdAbrirArquivo.FileName))
                {
                    using (PDFDoc copy_doc = new PDFDoc())
                    {
                        copy_doc.InitSecurityHandler();

                        copy_doc.InsertPages(copy_doc.GetPageCount() + 1, in_doc, 1, in_doc.GetPageCount(), PDFDoc.InsertFlag.e_none);

                        copy_doc.Save(GetNewFileName(ofdAbrirArquivo.FileName, FileNameOptionEnum.Copy), SDFDoc.SaveOptions.e_linearized);
                    }
                }
            }
        }

        private void btnCombPdf_Click(object sender, EventArgs e)
        {
            ofdAbrirArquivo.Multiselect = true;

            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                var mergedFileName = GetFilePath(ofdAbrirArquivo.FileNames[0]) + string.Join('_', ofdAbrirArquivo.SafeFileNames.Select(x => x.TrimEnd(".pdf".ToCharArray())));

                try
                {
                    using (PDFDoc new_doc = new PDFDoc())
                    {
                        new_doc.InitSecurityHandler();

                        foreach (var input_doc in ofdAbrirArquivo.FileNames)
                        {
                            using (PDFDoc in_doc = new PDFDoc(input_doc))
                            {
                                in_doc.InitSecurityHandler();

                                new_doc.InsertPages(new_doc.GetPageCount() + 1, in_doc, 1, in_doc.GetPageCount(), PDFDoc.InsertFlag.e_none);
                            }
                        }

                        //Era pra funcionar, mas lança uma exceção no método "new_doc.ImportPages"

                        //ArrayList copy_pages = new ArrayList();

                        //for (PageIterator itr = in_doc.GetPageIterator(); itr.HasNext(); itr.Next())
                        //{
                        //    copy_pages.Add(itr.Current());
                        //}

                        //var imported_pages = new_doc.ImportPages(copy_pages, false);

                        //for (int i = 0; i != imported_pages.Count; ++i)
                        //{
                        //    new_doc.PagePushBack((Page)imported_pages[i]);
                        //}

                        new_doc.Save(GetNewFileName(mergedFileName, FileNameOptionEnum.Merge), SDFDoc.SaveOptions.e_linearized);
                    }
                }
                catch (PDFNetException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCompriPdf_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                using (PDFDoc doc = new PDFDoc(ofdAbrirArquivo.FileName))
                {
                    Optimizer.Optimize(doc);

                    using (PDFDoc newDoc = new PDFDoc())
                    {
                        newDoc.InsertPages(newDoc.GetPageCount() + 1, doc, 1, doc.GetPageCount(), PDFDoc.InsertFlag.e_none);
                        newDoc.Save(GetNewFileName(ofdAbrirArquivo.FileName, FileNameOptionEnum.Compress), SDFDoc.SaveOptions.e_linearized);

                    }
                }
            }
        }

        private void btnProtPdf_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                using (PDFDoc doc = new PDFDoc(ofdAbrirArquivo.FileName))
                {
                    //Apply a new security handler with given security settings.
                    // In order to open saved PDF you will need a user password 'test'.
                    SecurityHandler new_handler = new SecurityHandler(SecurityHandler.AlgorithmType.e_AES_256);

                    // Set a new password required to open a document
                    string my_password = "senhateste";
                    new_handler.ChangeUserPassword(my_password);

                    // Set Permissions
                    new_handler.SetPermission(SecurityHandler.Permission.e_print, true);
                    new_handler.SetPermission(SecurityHandler.Permission.e_extract_content, false);

                    // Note: document takes the ownership of new_handler.
                    doc.SetSecurityHandler(new_handler);

                    doc.Save(GetNewFileName(ofdAbrirArquivo.FileName, FileNameOptionEnum.Encrypt), SDFDoc.SaveOptions.e_linearized);
                }
            }
        }

        private void btnConvertToPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConvertPdf.Text))
            {

                ofdAbrirArquivo.Multiselect = false;
                ofdAbrirArquivo.Filter = string.Empty;

                if (ofdAbrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    using (PDFDoc doc = new PDFDoc())
                    {
                        try
                        {
                            switch (GetFileType(ofdAbrirArquivo.FileName))
                            {
                                case FileType.MSOffice:
                                    pdftron.PDF.Convert.OfficeToPDF(doc, ofdAbrirArquivo.FileName, null);
                                    break;

                                case FileType.HTML:
                                    HTML2PDF converter = new HTML2PDF();

                                    var htmlString = System.IO.File.ReadAllText(ofdAbrirArquivo.FileName);

                                    converter.InsertFromHtmlString(htmlString);

                                    converter.Convert(doc);
                                    break;

                                case FileType.Other:
                                    pdftron.PDF.Convert.ToPdf(doc, ofdAbrirArquivo.FileName);
                                    break;

                                case FileType.NotMapped:
                                    MessageBox.Show($"Extensão {GetFileExtension(ofdAbrirArquivo.FileName)} não mapeada");
                                    return;

                                default:
                                    break;
                            }

                            doc.Save(GetNewFileName(ofdAbrirArquivo.FileName, FileNameOptionEnum.Convert), SDFDoc.SaveOptions.e_linearized);
                        }
                        catch (PDFNetException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                using (PDFDoc doc = new PDFDoc())
                {
                    //HTML2PDF.Convert(doc, tbConvertPdf.Text);

                    HTML2PDF converter = new HTML2PDF();

                    converter.InsertFromURL(tbConvertPdf.Text);

                    converter.Convert(doc);

                    MessageBox.Show(converter.GetLog());

                    doc.Save(GetNewFileName("teste_convert-from-html", FileNameOptionEnum.Convert), SDFDoc.SaveOptions.e_linearized);
                }
            }
        }
    }
}