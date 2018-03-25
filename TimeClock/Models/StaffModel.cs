﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClock.Models
{
    public class StaffModel
    {
        public string staffID { get; set; }
        // FirstName
        public string name { get; set; }      
        public string pass { get; set; }

        //State (Logged In or Logged Out
        public bool state { get; set; }

        public StaffModel()
        {

        }

        public StaffModel(string fName, string p, bool torf)
        {
            name = fName;           
            pass = p;
            state = torf;
        }
    }
}