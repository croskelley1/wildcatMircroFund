using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Admin.ViewModels
{
    public class IntakeApplicationVM
    {

        public int appID { get; set; }
        public QuestionUse? QuestionUse { get; set; }
        public Question? Question { get; set; }
        public QCategory? Category { get; set; }
        public Application? Application { get; set; }
        public ApplicationStatus? AppStatus { get; set; }

        public IEnumerable<AssignedQuestion>? AssignedQuestions { get; set; }
        public Response Question1 { get; set; }
        public Response Question2 { get; set; }
        public Response Question3 { get; set; }
        public Response Question4 { get; set; }
        public Response Question5 { get; set; }

    }
}
