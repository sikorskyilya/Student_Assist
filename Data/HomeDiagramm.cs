using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assist.Data
{
    class HomeDiagramm
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public HomeDiagramm() { }
        public HomeDiagramm(string _name, int _count)
        {
            this.Name = _name;
            this.Count = _count;
        }
    }
}
