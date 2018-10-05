using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Web
{
    public class ComputerSystem
    {
        public string RAM { get; set; }
        public string HDDSize { get; set; }
        public string KeyBoard { get; set; }
        public string Mouse { get; set; }
        public string TouchScreen { get; set; }

        public ComputerSystem()
        {

        }
        //public ComputerSystem(string RAM,string HDD)
        //{
        //    _RAM = RAM;
        //    _HDDSize = HDD;
        //}

        //public string Build()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.Append(string.Format("RAM : {0}", RAM));
        //    stringBuilder.Append(string.Format("HDDSize : {0}", HDDSize));
        //    return stringBuilder.ToString();
        //}
    }
}