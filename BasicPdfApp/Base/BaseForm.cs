using System.Windows.Forms;
using System;
using System.Linq;

namespace BasicPdfApp
{
    public partial class BaseForm : Form
    {
        protected const float INCH = 72f;

        protected const string CONVERTER_DEFAULT_OUTPUT_PATH = "C:\\ProgramData\\ActivePDF\\DocConverter\\Watch Folders\\Default\\Output\\";

        protected const string _MSOfficeFileExtensions = ".odt;.ods;.odp;.odg;.odf;.ott;.emf;.fods;.fodt;.stw;.lwp;.wps;.xml;.xls;.xlsx;.xlsm;.xlt;.csv;" +
                                                       ".doc;.docx;.docm;.dotm;.dot;.dotx;.eml;.msg;.rtf;.ppt;.pptx;.pptm;.pps;.ppsx;.pot;.potx;.potm";

        protected const string _HtmlFileExtensions = ".html;.htm;.mht;.mhtml";

        protected const string _OtherFileExtensions = ".bmp;.jpg;.jpeg;.cdr;.dcx;.ico;.gif;.pct;.pcx;.pic;.png;.rgb;.sam;.tif;.tiff;.tga;.wpg;.txt";

        public BaseForm()
        {
            InitializeComponent();
        }

        #region Auxiliares

        protected string GetFilePath(string fullFileName)
        {
            if (chkGerarWatchFolder.Checked)
                return CONVERTER_DEFAULT_OUTPUT_PATH;

            return fullFileName.TrimEnd(fullFileName.Split("\\").Last().ToCharArray());
        }

        protected string GetNewFileName(OpenFileDialog fileDialog, FileNameOptionEnum nameOptionEnum)
        {
            return this.GetNewFileName(fileDialog.FileName, nameOptionEnum);
        }

        protected string GetNewFileName(string fullFileName, FileNameOptionEnum nameOptionEnum)
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

        protected FileType GetFileType(string path)
        {
            var extension = GetFileExtension(path);

            if (_MSOfficeFileExtensions.Split(";").Contains(extension))
            {
                return FileType.MSOffice;
            }
            else if (_HtmlFileExtensions.Split(";").Contains(extension))
            {
                return FileType.HTML;
            }
            else if (_OtherFileExtensions.Split(";").Contains(extension))
            {
                return FileType.Other;
            }
            else
            {
                return FileType.NotMapped;
            }
        }

        protected string GetFileExtension(string path)
        {
            return ("." + path.Split("\\").Last().Split(".").Last()).ToLower();
        }

        #endregion

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

    public enum FileType
    {
        MSOffice = 1,
        HTML = 2,
        Other = 3,
        NotMapped = 99
    }
}