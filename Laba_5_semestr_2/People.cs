using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5_semestr_2
{
    public class People
    {
        public int V_Count { get; set; }
        public string Name { get; set; }
        public string ame 
        {
            get {  return $"[{V_Count}]  {Name}"; }
        }
        public People(string name, int v_Count) 
        {
            V_Count = v_Count;
            Name = name;
        }
    }
}
