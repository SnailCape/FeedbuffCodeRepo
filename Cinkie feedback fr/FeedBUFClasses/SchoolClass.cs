using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.FeedBUFClasses
{
    internal class SchoolClass
    {
        DAL.DAL dal = new DAL.DAL();
        public int ClassId { get; set; }
        public Teacher teacher { get; set; }
        public int Year { get; set; }
        public List<SchoolClass> listClasses = new List<SchoolClass>();

        public SchoolClass(int classId, Teacher teacher, int year)
        {
            ClassId = classId;
            this.teacher = teacher;
            Year = year;
        }

        /// <summary>
        /// Save the list of classes from the database into the class
        /// </summary>
        public void GetClassesFromDB()
        {
            listClasses.Clear();
            listClasses = dal.ReadClasses();
        }

        /// <summary>
        /// Get the saved list of students from the class
        /// </summary>
        /// <return></return>
        public List<SchoolClass> GetClassesFromClass()
        {
            return listClasses;
        }
    }
}
