﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    internal class Teacher
    {
        DAL.DAL dal = new DAL.DAL();
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string Housenumber { get; set; }
        public string SchoolLocation { get; set; }
        public bool LoginStatus { get; set; }
        public StudyUnit studyUnit { get; set; }
        public List<Teacher> listTeachers = new List<Teacher>();

        public Teacher(int teacherId, string firstName, string lastName,
                       string gender, string email, string phonenumber,
                       string postalCode, string country, string streetname,
                       string city, string housenumber, string schoolLocation,
                       bool loginStatus, StudyUnit studyUnit)
        {
            TeacherId = teacherId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Phonenumber = phonenumber;
            PostalCode = postalCode;
            Country = country;
            Streetname = streetname;
            City = city;
            Housenumber = housenumber;
            SchoolLocation = schoolLocation;
            LoginStatus = loginStatus;
            this.studyUnit = studyUnit;
        }

        /// <summary>
        /// Save the list of teachers from the database into the class
        /// </summary>
        public void GetTeachersFromDB()
        {
            listTeachers.Clear();
            listTeachers = dal.ReadTeachers();
        }
        
        /// <summary>
        /// Get the list of teachers saved into the class
        /// </summary>
        /// <return></return>
        public List<Teacher> GetTeachersFromClass()
        {
            return listTeachers;
        }
    }
}
