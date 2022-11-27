using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Mentor.ViewModels
{
    public class ReviewApplicationVM
    {
        public UserApplicationAssignmentType? UserApplicationAssignmentType { get; set; }
        public UserAssignment? Entrepreneur { get; set; }
        public UserAssignment? Mentor { get; set; }
        public UserAssignment? Judge { get; set; }
        public ApplicationStatus? ReviewApplication { get; set; }
        public ApplicationStatus? ApplicationStatus { get; set; }
        public Application? Application { get; set; }
        public Status? Status { get; set; }
        public IEnumerable<SelectListItem>? StatusList { get; set; }
        public IEnumerable<SelectListItem>? MentorList { get; set; }
        public IEnumerable<SelectListItem>? JudgeList { get; set; }
    }
}
