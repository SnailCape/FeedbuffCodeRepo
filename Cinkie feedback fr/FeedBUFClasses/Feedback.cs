using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.FeedBUFClasses
{
    internal class Feedback
    {
        DAL.DAL dal = new DAL.DAL();
        public int FeedbackId { get; set; }
        public StudyUnit studyUnit { get; set; }
        public string Description { get; set; }
        public List<Feedback> listFeedback = new List<Feedback>();

        public Feedback() { }
        public Feedback(int feedbackId, StudyUnit studyUnit, string description)
        {
            FeedbackId = feedbackId;
            this.studyUnit = studyUnit;
            Description = description;
        }

        /// <summary>
        /// Save the list of all feedback from the database into the class
        /// </summary>
        public void GetFeedbackFromDB()
        {
            listFeedback.Clear();
            listFeedback = dal.ReadFeedback();
        }

        /// <summary>
        /// Get the saved list of feedback from the class
        /// </summary>
        /// <return></return>
        public List<Feedback> GetFeedbackFromClass()
        {
            listFeedback.Clear();
            listFeedback = dal.ReadFeedback();
            return listFeedback;
        }

        /// <summary>
        /// Create new feedback and add it to the list AND database
        /// </summary>
        public void CreateFeedback()
        {

        }

        /// <summary>
        /// Delete feedback based on id from the list AND database
        /// </summary>
        public void DeleteFeedback()
        {

        }

        /// <summary>
        /// Update feedback from the list AND database
        /// </summary>
        public void UpdateFeedback()
        {

        }
    }
}
