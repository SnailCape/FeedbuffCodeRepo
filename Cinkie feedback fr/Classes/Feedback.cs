using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinkie_feedback_fr.Classes
{
    internal class Feedback
    {
        DAL.DAL dal = new DAL.DAL();
        public int FeedbackId { get; set; }
        public StudyUnit studyUnit { get; set; }
        public string Description { get; set; }
        public List<Feedback> listFeedback = new List<Feedback>();


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
    }
}
