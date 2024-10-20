using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Library 
    {
        //A new class is defined with "Class". It is created to bring objects together.

        public string name; 
        public string writername;
        public string writersurname;
        public string pagenumber;
        public string publishhouse;
        public DateTime recorddate;

        public string Name { get { return name; } set { name = value; }}
        public string WriterName { get { return writername; } set { writername = value; }}
        public string Writersurname { get { return writersurname; } set { writersurname = value; }}
        public string Pagenumber { get { return pagenumber; } set { pagenumber = value; }}
        public string Publishhouse { get { return publishhouse; } set { publishhouse = value; }}
        public DateTime Recorddate { get { return recorddate; } set { recorddate = value; }}

       // Properties allow us to control access to data within classes.

        public Library() //Default constructor.
        {
            recorddate = DateTime.Now;
        }

        public Library(string name, string writername, string writersurname, string pagenumber, string publishhouse) //Alternative constructor.
        {
            Name = name;
            this.writername = writername;
            Writersurname = writersurname;
            Pagenumber = pagenumber;
            Publishhouse = publishhouse;
            Recorddate = DateTime.Now;
        }

        //Constructor is used to set the initial state of the class and perform the necessary initialization operations during the instantiation process.

    }
}
