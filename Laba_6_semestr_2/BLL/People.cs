﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_semestr_2.BLL
{
    public class People
    {
        public int V_Count { get; set; }
        public string Name { get; set; }
        public int ReV_Count 
        {
            get { return V_Count; }
        }
        public People(string name, int v_Count) 
        {
            V_Count = v_Count;
            Name = name;
        }
    }
}
