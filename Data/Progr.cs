using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.Data
{
    class Progr
    {
        public string Name { get; set; }
        public double Count { get; set; }
        public Progr(string _name, int _count)
        {
            this.Name = _name;
            this.Count = _count;
        }
        public Progr() { }
    }
}
