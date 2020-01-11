using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestingWebApp.Models
{
    public class testdetail
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Test Name")]
        public string testname { get; set; }
        [Required]
        [Display(Name = "Test Type")]
        public String testtype { get; set; }
        [Required]
        [Display(Name = "Test Xpath1")]
        public string testxpath1 { get; set; }
        [Required]
        [Display(Name = "Test Xpath2")]
        public string testxpath2 { get; set; }
        [Required]
        [Display(Name = "Test Status")]
        public string teststatus { get; set; }
    }
}