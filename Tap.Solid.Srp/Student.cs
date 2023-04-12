using Dapper;
using Microsoft.Data.Sqlite;
using System.Net.Mail;

namespace Tap.Solid.Srp
{
    namespace Tap.Solid.Srp
    {
        public class StudentRepository
        {
            public string AddStudent(Student student)
            {
                if (student == null)
                    return "Invalid student data!";

                if (string.IsNullOrEmpty(student.Email) || !student.Email.Contains("@uaic.ro"))
                    return "Invalid email. Please use your uaic email!";

                if (string.IsNullOrEmpty(student.SocialSecurityNumber) || student.SocialSecurityNumber.Length != 13)
                    return "Invalid social security number!";

                var sqlCommand = "INSERT INTO students (Name, Email, SocialSecurityNumber) values (@Name, @Email, @SocialSecurityNumber)";
                using (var connection = new SqliteConnection("Data Source=:memory:"))
                {
                    var affectedRows = connection.Execute(sqlCommand, student);
                }

                return "Student enrolled!";
            }
        }

        public class StudentEmailService
        {
            public void SendWelcomeEmail(Student student)
            {
                var mail = new MailMessage("demo@solid.principles.srp", student.Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    Host = "smtp.demo.exercise"
                };

                mail.Subject = "Welcome to the lab!";
                mail.Body = $"Hey {student.Name}! Glad to have you!";
                client.Send(mail);
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string SocialSecurityNumber { get; set; }
        }
    }
}