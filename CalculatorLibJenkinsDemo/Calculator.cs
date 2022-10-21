using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibJenkinsDemo
{
    
    public class Calculator
    {
        
       
        public int Add(int x,int y)
        {
            return x + y;
            
        }
        public int Subtract(int x,int y)
        {
            return x - y;
            
        }
        public int Multiply(int x,int y)
        {
            return x * y;
            
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
