﻿using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class EmailTemplate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="TemplateName")]
        public string? EmailTemplateName { get; set; }
        [Required]
        [Display(Name = "TemplateContent")]
        public string? TemplateContent { get; set; }
    }
}
