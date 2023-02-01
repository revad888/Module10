using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public interface ILogger
    {
        void Anser(double anser);
        void Error(string message);

    }
    public interface IAddition
    {
        void Addition(string value1, string value2);
    }
}
