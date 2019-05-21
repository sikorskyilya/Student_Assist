using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assist.Data
{
    class Notes
    {
        public string UserId { get; }
        public string Lab1 { get; }
        public string Lab2 { get; }
        public string LK { get; }
        public string Pz { get; }
        public string KP { get; }
        public string Important { get; }
        public Notes(string _lab1, string _lab2, string _lk, string _pz, string _kp, string _imp)
        {
            this.Lab1 = _lab1;
            this.Lab2 = _lab2;
            this.LK = _lk;
            this.Pz = _pz;
            this.KP = _kp;
            this.Important = _imp;
        }
        public Notes() { }
    }
}
