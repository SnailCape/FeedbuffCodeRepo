using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    internal class Class
    {
        DAL.DAL dal = new DAL.DAL();
        public int ClassId { get; set; }
        public Teacher teacher { get; set; }
        public int Year { get; set; }
        public List<Class> listClasses = new List<Class>();

        public Class(int classId, Teacher teacher, int year)
        {
            ClassId = classId;
            this.teacher = teacher;
            Year = year;
        }

        /// <summary>
        /// Save the list of classes from the database into the class
        /// </summary>
        public static void GetClassesFromDB()
        {
            listClasses.Clear();
            listClasses = dal.ReadClasses();
        }

        /// <summary>
        /// Get the saved list of students from the class
        /// </summary>
        /// <return></return>
        public List<Class> GetClassesFromClass()
        {
            return listClasses;
        }
    }
}
