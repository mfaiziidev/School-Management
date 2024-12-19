using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Entity
    {

    }

    public class clsSubjects
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string SubjectStandard { get; set; }
        public string SubjectCategory { get; set; }
    }
    public class clsClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassStandard { get; set; }
        public string ClassSection { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }

    public class clsStudents
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }

    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

        public class clsConnection
        {
            private static String connectionString = "Data Source=DELL_LATTITUDE_;Initial Catalog=SchoolManagement;Integrated Security=True";

            public static string connection
            {
                get
                {
                    return connectionString;
                }

                set
                {
                    connectionString = value;
                }

            }

        }
}

