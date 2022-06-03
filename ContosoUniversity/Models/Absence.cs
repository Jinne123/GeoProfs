using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Absence
    {
        public int? id { get; set; }
        public int? userId { get; set; }
     
        public DateTime? StartAbsence { get; set; }
        public DateTime? StopAbsence { get; set; }
        public string reason { get; set; }
        public Boolean status { get; set; }






    }
}