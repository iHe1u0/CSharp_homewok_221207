using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Complex : Number, Operation
    {
        private double a, b;
        private double _a, _b;
        public Complex(double a, double b)
        {
            _a = a;
            _b = b;
            this.a = a;
            this.b = b;
        }

        public override string Value
        {
            get
            {
                if (_a == 0)
                {
                    return "(" + _b.ToString() + "i)";
                }
                if (_b == 0)
                {
                    return _a.ToString();
                }
                if (_a == 0 && _b == 0)
                {
                    return "0i";
                }
                if (_b > 0)
                {
                    return "(" + _a.ToString("0.##") + "+" + _b.ToString("0.##") + "i)";
                }
                return "(" + _a.ToString("0.##") + _b.ToString("0.##") + "i)";
            }
            set => throw new NotImplementedException();
        }

        public Number Add(Number n)
        {
            Complex complex = (Complex)n;
            a = complex.a;
            b = complex.b;
            return new Complex(_a + a, _b + b);
        }

        public Number Divide(Number n)
        {
            Complex complex = (Complex)n;
            double c = complex.a;
            double d = complex.b;
            double _div = c * c + d * d;
            if (_div == 0)
            {
                throw new DivideByZeroException();
            }
            return new Complex(((_a * c) + (_b * d)) / _div, (_b * c - _a * d) / _div);
        }

        public Number Multiply(Number n)
        {
            Complex complex = (Complex)n;
            double c = complex.a;
            double d = complex.b;
            return new Complex(_a * c - _b * d, _a * d + _b * c);
        }

        public Number Subtract(Number n)
        {
            Complex complex = (Complex)n;
            double c = complex.a;
            double d = complex.b;
            return new Complex(_a - c, _b - d);
        }
    }
}
