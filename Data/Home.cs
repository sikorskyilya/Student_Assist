using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Assist.Data
{
    class Home
    { 
    public string Name { get; set; }
    public string Surname { get; set; }
    public Home(string _name, int _surname)
    {
        this.Name = _name;
        this.Surname = _name;
    }
    public Home() { }
    }
}
