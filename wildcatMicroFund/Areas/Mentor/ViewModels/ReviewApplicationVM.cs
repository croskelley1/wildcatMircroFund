using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Mentor.ViewModels
{
    public class ReviewApplicationVM
    {
        public UserAssignment? UserAssignment { get; set; }
        public IEnumerable<UserAssignment>? AssignedUsers { get; set; }
        public ApplicationStatus? ReviewApplication { get; set; }
        public ApplicationStatus? ApplicationStatus { get; set; }
        public Application? Application { get; set; }
        public Status? Status { get; set; }
        public IEnumerable<SelectListItem>? StatusList { get; set; }
        public IEnumerable<SelectListItem>? MentorList { get; set; }
        public IEnumerable<SelectListItem>? JudgeList { get; set; }
        public IEnumerable<Response>? Responses { get; set; }

    }
}
