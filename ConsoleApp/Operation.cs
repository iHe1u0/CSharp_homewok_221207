using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface Operation
    {
        Number Add(Number n);
        Number Subtract(Number n);
        Number Multiply(Number n);
        Number Divide(Number n);
    }
}
