﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIO
{


    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1+num2;
        }

        public int Subtrair(int num1, int num2) 
        { 
            return num1-num2; 
        }
        public int Multiplicar(int num1, int num2) 
        {
            return num1*num2;
        }
        public int Divide(int num1, int num2) 
        {
            return num1/num2;
        }

        public List<string> historico()
        {
            return new List<string>();
        }
    }
}
