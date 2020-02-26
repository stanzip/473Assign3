using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3
{
    public class School : Property
    {
        private string name;
        enum SchoolType { Elementary, HighSchool, CommunityCollege, University };
        string yearEstablished;
        uint enrolled;

        //default constructor
        public School()
        {
            name = "";
            yearEstablished = "";
            enrolled = 0;
        }

        //constructor with parameters
        public School(string[] fileInput) : base(fileInput)
        {
            name = stringParser();
            yearEstablished = stringParser();
            enrolled = uintParser();
        }

        //accessor method for the string name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //accessor method for the string yearEstablished
        public string YearEstablished
        {
            get { return yearEstablished; }
            set { yearEstablished = value; }
        }

        //accessor method for the uint enrolled
        public uint Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }

        protected override void residenceInfo()
        {
            Console.Write($"{name} ");
        }

    }
}

