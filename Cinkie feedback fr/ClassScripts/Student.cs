using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinkie_feedback_fr.Classes
{
    internal class Student
    {
        DAL.DAL dal = new DAL.DAL();
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Streetname { get; set; }
        public string Housenumber { get; set; }
        public string SchoolLocation { get; set; }
        public bool LoginStatus { get; set; }
        public int StudentClassId { get; set; }
        public Class StudentClass { get; set; }
        public List<Student> listStudents = new List<Student>();
        
        // Student object with class index
        public Student(int studentId, string firstName, string lastName,
                       int gender, string email, string phonenumber,
                       string postalcode, string country, string city,
                       string streetname, string housenumber, string schoollocation,
                       bool loginstatus, int studentclassId) 
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Phonenumber = phonenumber;
            PostalCode = postalcode;
            Country = country;
            City = city;
            Streetname = streetname;
            Housenumber = housenumber;
            SchoolLocation = schoollocation;
            LoginStatus = loginstatus;
            StudentClassId = studentclassId;
        }
        // Student object with class object
        public Student(int studentId, string firstName, string lastName,
                       int gender, string email, string phonenumber,
                       string postalcode, string country, string city,
                       string streetname, string housenumber, string schoollocation,
                       bool loginstatus, Class studentclass)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Phonenumber = phonenumber;
            PostalCode = postalcode;
            Country = country;
            City = city;
            Streetname = streetname;
            Housenumber = housenumber;
            SchoolLocation = schoollocation;
            LoginStatus = loginstatus;
            StudentClass = studentclass;
        }

        /// <summary>
        /// Save the list of students from the database into the class
        /// </summary>
        public static void GetStudentsFromDB()
        {
            listStudents.Clear();
            listStudents = dal.ReadStudents();
        }
        
        /// <summary>
        /// Get the saved list of students from the class
        /// </summary>
        /// <return></return>
        public List<Student> GetStudentsFromClass()
        {
            return listStudents;
        }

        /// <summary>
        /// Connect each student with their corresponding class
        /// </summary>
        public void ConnectStudentsWithClasses()
        {

        }
    }
}
