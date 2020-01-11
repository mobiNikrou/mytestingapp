using System;
using System.ComponentModel.DataAnnotations;

namespace MyTestingWebApp.Models
{
    public class testdetail
    {
        public int Id { get; set; }
        public string testname { get; set; }
        public String testtype { get; set; }
        public string testxpath1 { get; set; }
        public string testxpath2 { get; set; }
        public string teststatus { get; set; }
    }
}