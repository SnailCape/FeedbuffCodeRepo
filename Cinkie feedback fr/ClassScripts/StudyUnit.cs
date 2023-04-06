using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    // Onderwijseenheid
    internal class StudyUnit
    {
        DAL.DAL dal = new DAL.DAL();
        public string StudyUnitId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int EuropeanCredits { get; set; }
        public int HoursAmount { get; set; }
        public List<StudyUnit> listStudyUnits = new List<StudyUnit>();

        public StudyUnit(string studyUnitId, string name, string department, int europeanCredits, int hoursAmount)
        {
            StudyUnitId = studyUnitId;
            Name = name;
            Department = department;
            EuropeanCredits = europeanCredits;
            HoursAmount = hoursAmount;
        }

        /// <summary>
        /// Save the list of studyunits from the database into the class
        /// </summary>
        public void GetStudyUnitsFromDB()
        {
            listStudyUnits.Clear();
            listStudyUnits = dal.ReadStudyUnits();
        }

        /// <summary>
        /// Get the saved list of studyunits from the class
        /// </summary>
        /// <return></return>
        public List<StudyUnit> GetStudyUnitsFromClass()
        {
            return listStudyUnits;
        }
    }
}
