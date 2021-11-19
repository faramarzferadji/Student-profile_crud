using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_DB.dataAcess;

namespace Student_DB.business
{
   public class Student
    {
        public int Stusentid { get; set; }
        public string Name { get; set; }
        public string Cours { get; set; }
        public int Fee { get; set; }
    }
}

