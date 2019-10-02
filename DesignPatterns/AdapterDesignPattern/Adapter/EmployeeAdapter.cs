using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterDesignPattern.Adapter
{
    class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXML = base.GetAllEmployees();
            XmlDocument document = new XmlDocument();
            document.LoadXml(returnXML);
            return JsonConvert.SerializeObject(document, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
