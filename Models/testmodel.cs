using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestingWebApp.Models
{
    public class testdetail
    {
        public int Id { get; set; }
        [Required]
        public string testname { get; set; }
        [Required]

        public String testtype { get; set; }
        [Required]

        public string testxpath1 { get; set; }
        [Required]

        public string testxpath2 { get; set; }
        [Required]

        public string teststatus { get; set; }
    }
}