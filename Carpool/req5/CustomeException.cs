using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CustomException : Exception
{
    public CustomException()
    {
        Console.Write("InvalidEmailException:");
    }
    public new void Message()
    {
        Console.Write(" Invalid Email for ");
    }
}