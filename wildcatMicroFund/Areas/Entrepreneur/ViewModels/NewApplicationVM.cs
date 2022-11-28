using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Entrepreneur.ViewModels
{
    public class NewApplicationVM
    {
        public UserApplicationAssignmentType? UserApplicationAssignmentType { get; set; }
        public UserAssignment? Entrepreneur { get; set; }
        public ApplicationStatus? ReviewApplication { get; set; }
        public ApplicationStatus? ApplicationStatus { get; set; }
        public Application? Application { get; set; }
        public Status? Status { get; set; }
    }
}