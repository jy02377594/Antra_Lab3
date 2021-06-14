using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        public int realNum { get; set; }
        public int imaginaryNum { get; set; }
        public ComplexNumber(int realnum, int imaginarynum)
        {
            this.realNum = realnum;
            this.imaginaryNum = imaginarynum;
        }

        public void SetImaginary(int imaginary_num)
        {
            imaginaryNum = imaginary_num;
        }

        public string ToString()
        {
            return $"({realNum},{imaginaryNum})";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(realNum * realNum + imaginaryNum * imaginaryNum);
        }

        public void Add(ComplexNumber cn)
        {
            realNum = realNum + cn.realNum;
            imaginaryNum = imaginaryNum + cn.imaginaryNum;
        }
    }
}
