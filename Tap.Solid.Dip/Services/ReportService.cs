using Tap.Solid.Dip.Entities;
using Tap.Solid.Dip.ReportExporters;

namespace Tap.Solid.Dip.Services
{
    public class ReportService : IReportService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IReportExporter _reportExporter;

        public ReportService(IStudentRepository studentRepository, IReportExporter reportExporter)
        {
            _studentRepository = studentRepository;
            _reportExporter = reportExporter;
        }

        public void GenerateReport()
        {
            var students = _studentRepository.GetAll();
            _reportExporter.Export(students);
        }
    }
}
