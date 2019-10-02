using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDesignPattern
{
    [Serializable]
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }

    public class EmployeeManager: IEmployee
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "Suraj"));
            this.employees.Add(new Employee(2, "Deepak"));
            this.employees.Add(new Employee(3, "Alok"));
            this.employees.Add(new Employee(4, "Saket"));
        }

        public virtual string GetAllEmployees()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
