﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorWcfService1 : ICalculatorWcfService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public double Addition(double x, double y)
        {
           CalculatorApplication.Calculator calculator = new CalculatorApplication.Calculator();
            return x + y;
        }
        public double Substraction(double x, double y)
        {
            CalculatorApplication.Calculator calculator = new CalculatorApplication.Calculator();
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            CalculatorApplication.Calculator calculator = new CalculatorApplication.Calculator();
            return x * y;
        }
        public double Division(double x, double y)
        {
            CalculatorApplication.Calculator calculator = new CalculatorApplication.Calculator();
            return x / y;
        }

       public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
