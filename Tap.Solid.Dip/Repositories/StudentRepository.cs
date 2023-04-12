namespace Tap.Solid.Dip.Services
{
    public interface IReportService
    {
        void GenerateReport();
    }

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

namespace Tap.Solid.Dip
{
    public interface IReportExporter
    {
        void Export(List<Student> students);
    }

    public interface IStudentRepository
    {
        List<Student> GetAll();
    }

    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAll()
        {
            return new List<Student>();
        }
    }
}
