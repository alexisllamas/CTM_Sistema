using System;

/////Add the references (new)
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using Ctm_Col.Models;
using Novacode;
using System.Windows.Forms;
using System.Linq;

namespace Ctm_Col
{
    public class Imprimir
    {
        private static Random random = new Random();
        private static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace("file:\\", "");
       
        public static void Credencial(Credencial credencial, Form win)
        {
            string fileName = path + @"\Reportes\credencial.docx";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error");
                return;
            }
            var doc = DocX.Load(fileName);

            doc.ReplaceText("<<nombre>>", credencial.Chofer.Nombres);
            doc.ReplaceText("<<apellidoPaterno>>", credencial.Chofer.ApellidoPaterno);
            doc.ReplaceText("<<apellidoMaterno>>", credencial.Chofer.ApellidoMaterno);
            doc.ReplaceText("<<edad>>", getEdad(credencial.Chofer.FechaNacimiento).ToString());
            doc.ReplaceText("<<id>>", credencial.Id.ToString());
            doc.ReplaceText("<<calle>>", credencial.Chofer.Domicilio);
            doc.ReplaceText("<<colonia>>", credencial.Chofer.Colonia);
            doc.ReplaceText("<<licencia>>", credencial.Chofer.Licencia);
            doc.ReplaceText("<<fechaIni>>", credencial.FechaInicioVigencia.ToShortDateString());
            doc.ReplaceText("<<fechaFin>>", credencial.FechaFinalVigencia.ToShortDateString());
            doc.ReplaceText("<<fecha>>", DateTime.Today.ToShortDateString());

            
            string saveAs = string.Format(@"{0}\Reportes\tmp\credencial{1}.docx", path, credencial.Id);
            doc.SaveAs(saveAs);
            printWord(saveAs);
            deleteFile(saveAs);
        }

        public static void ReciboCredencial(ReciboCredencial recibo)
        {
            string fileName = path + @"\Reportes\reciboCredencial.docx";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error");
                return;
            }
            var doc = DocX.Load(fileName);

            doc.ReplaceText("<<id>>", recibo.Id.ToString());
            doc.ReplaceText("<<nombre>>", recibo.Chofer.Nombres);
            doc.ReplaceText("<<apellidoPaterno>>", recibo.Chofer.ApellidoPaterno);
            doc.ReplaceText("<<apellidoMaterno>>", recibo.Chofer.ApellidoMaterno);
            doc.ReplaceText("<<fecha>>", recibo.Fecha.ToShortDateString());
            doc.ReplaceText("<<cantidad>>", recibo.Cantidad.ToString("C2"));

            string saveAs = string.Format(@"{0}\Reportes\tmp\reciboCredencial{1}.docx", path, recibo.Id);
            doc.SaveAs(saveAs);
            printWord(saveAs);
            deleteFile(saveAs);
        }

        public static void ReciboPoliza(ReciboPoliza recibo, Taxi taxi)
        {
            string fileName = path + @"\Reportes\recibo.docx";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error");
                return;
            }
            var doc = DocX.Load(fileName);

            doc.ReplaceText("<<id>>", recibo.Id.ToString());
            doc.ReplaceText("<<nombre>>", recibo.Concesionario.Nombres);
            doc.ReplaceText("<<apellidoPaterno>>", recibo.Concesionario.ApellidoPaterno);
            doc.ReplaceText("<<apellidoMaterno>>", recibo.Concesionario.ApellidoMaterno);
            doc.ReplaceText("<<fecha>>", recibo.Fecha.ToShortDateString());
            doc.ReplaceText("<<cantidad>>", recibo.Cantidad.ToString("C2"));
            doc.ReplaceText("<<numero>>", taxi.NumeroEconomico);
            doc.ReplaceText("<<sitio>>", taxi.Sitio);
            doc.ReplaceText("<<tipo>>", "Póliza");

            string saveAs = string.Format(@"{0}\Reportes\tmp\reciboPoliza{1}.docx", path, recibo.Id);
            doc.SaveAs(saveAs);
            printWord(saveAs);
            deleteFile(saveAs);
        }

        public static void ReciboDeducible(ReciboDeducible recibo)
        {
            string fileName = path + @"\Reportes\recibo.docx";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error");
                return;
            }
            var doc = DocX.Load(fileName);

            doc.ReplaceText("<<id>>", recibo.Id.ToString());
            doc.ReplaceText("<<nombre>>", recibo.Chofer.Nombres);
            doc.ReplaceText("<<apellidoPaterno>>", recibo.Chofer.ApellidoPaterno);
            doc.ReplaceText("<<apellidoMaterno>>", recibo.Chofer.ApellidoMaterno);
            doc.ReplaceText("<<fecha>>", recibo.Fecha.ToShortDateString());
            doc.ReplaceText("<<cantidad>>", recibo.Cantidad.ToString("C2"));
            doc.ReplaceText("<<numero>>", recibo.Taxi.NumeroEconomico);
            doc.ReplaceText("<<sitio>>", recibo.Taxi.Sitio);
            doc.ReplaceText("<<tipo>>", "Deducible");

            string saveAs = string.Format(@"{0}\Reportes\tmp\reciboDeducible{1}.docx", path, recibo.Id);
            doc.SaveAs(saveAs);
            printWord(saveAs);
            deleteFile(saveAs);
        }
        public static void ReciboPrimerIngreso(ReciboPrimerIngreso recibo, Taxi taxi)
        {
            string fileName = path + @"\Reportes\recibo.docx";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error");
                return;
            }
            var doc = DocX.Load(fileName);

            doc.ReplaceText("<<id>>", recibo.Id.ToString());
            doc.ReplaceText("<<nombre>>", recibo.Concesionario.Nombres);
            doc.ReplaceText("<<apellidoPaterno>>", recibo.Concesionario.ApellidoPaterno);
            doc.ReplaceText("<<apellidoMaterno>>", recibo.Concesionario.ApellidoMaterno);
            doc.ReplaceText("<<fecha>>", recibo.Fecha.ToShortDateString());
            doc.ReplaceText("<<cantidad>>", recibo.Cantidad.ToString("C2"));
            doc.ReplaceText("<<numero>>", taxi.NumeroEconomico);
            doc.ReplaceText("<<sitio>>", taxi.Sitio);
            doc.ReplaceText("<<tipo>>", "Primer ingreso");

            string saveAs = string.Format(@"{0}\Reportes\tmp\reciboPrimerIngreso{1}.docx", path, recibo.Id);
            doc.SaveAs(saveAs);
            printWord(saveAs);
            deleteFile(saveAs);
        }

        private static void deleteFile(string saveAs)
        {
            File.Delete(saveAs);

        }

        public static void closeWord(Word.Document document)
        {
            object saveOption = Word.WdSaveOptions.wdDoNotSaveChanges;
            object originalFormat = Word.WdOriginalFormat.wdOriginalDocumentFormat;
            object routeDocument = false;
            document.Close(ref saveOption, ref originalFormat, ref routeDocument);
        }

        public static void printWord(object fileName)
        {
            object missing = Missing.Value;
            object copies = "1";
            object pages = "1";
            object range = Word.WdPrintOutRange.wdPrintCurrentPage;
            object items = Word.WdPrintOutItem.wdPrintDocumentContent;
            object pageType = Word.WdPrintOutPages.wdPrintAllPages;
            object oTrue = true;
            object oFalse = false;
            object readOnly = true;

            Word.Application wordApp = new Word.Application();
            Word.Document document = wordApp.Documents.Open(ref fileName, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);
            object nullobj = Missing.Value;
            int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
            wordApp.Visible = false;
            if (dialogResult == 1)
            {
                document.PrintOut(
                ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
            }

            closeWord(document);
        }

        public static int getEdad(DateTime bday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;

            if (bday > today.AddYears(-age))
                age-=1;

            return age;
        }

    }
}
