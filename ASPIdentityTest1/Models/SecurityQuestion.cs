using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPIdentityTest1.Models
{
    public class SecurityQuestion
    {
        public int SelectedQuestionId { get; set; }
        public string Question { get; set; }
        public SecurityQuestion(int SelectedQuestionId, string Question)
        {
            this.SelectedQuestionId = SelectedQuestionId;
            this.Question = Question;
        }
        public SecurityQuestion(string Question)
        {
            this.SelectedQuestionId = SelectedQuestionId;
            this.Question = Question;
        }
    }
    public class SecurityQuestions
    {
        public List<SecurityQuestion> GetQuestions()
        {
            List<SecurityQuestion> question = new List<SecurityQuestion>();
            SecurityQuestion q1 = new SecurityQuestion(1, "What is your first car?");
            SecurityQuestion q2 = new SecurityQuestion(2, "What is your mother's first name?");
            SecurityQuestion q3 = new SecurityQuestion(3, "What is your pet's name?");
            question.Add(q1);
            question.Add(q2);
            question.Add(q3);

            return question;
        }
    }
}
