﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Component
{
    //interface IEmployee
    //{
    //    void GetDetails();
    //}
    public interface IEmployee
    {
        void GetDetails(int indentation);
    }
}
