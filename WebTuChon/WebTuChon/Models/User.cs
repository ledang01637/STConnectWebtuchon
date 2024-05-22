using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTuChon.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public List<string> Subject {  get; set; }
        public DateTime BirthDay { get; set; }

    }
}