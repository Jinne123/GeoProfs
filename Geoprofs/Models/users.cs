using System;
using System.Collections.Generic;

namespace Geoprofs.Models
{
    public class users
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }                      
        public int Role_id { get; set; }
        public int Team_id { get; set; }

    }
}