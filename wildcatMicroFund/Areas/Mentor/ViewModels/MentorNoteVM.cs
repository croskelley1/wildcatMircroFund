using Microsoft.AspNetCore.Mvc.Rendering;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Areas.Mentor.ViewModels
{
    public class MentorNoteVM
    {
        public Application? Application { get; set; }
        public Note? Note { get; set; }
        public NoteType? NoteType { get; set; }
        public IEnumerable<SelectListItem> NoteTypeList { get; set; }
    }
}
