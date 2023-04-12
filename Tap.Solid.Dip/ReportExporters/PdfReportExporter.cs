using System.Collections.Generic;
using Tap.Solid.Dip.Entities;

namespace Tap.Solid.Dip.ReportExporters
{
    public interface IReportExporter
    {
        void Export(List<Student> students);
    }

    public class PdfReportExporter : IReportExporter
    {
        public void Export(List<Student> students)
        {
            Console.WriteLine("PDF Exported!");
        }
    }
}
