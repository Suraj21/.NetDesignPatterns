﻿using AdapterDesignPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new EmployeeAdapter();
            string value = employee.GetAllEmployees();
            Console.ReadLine();
        }
    }
}