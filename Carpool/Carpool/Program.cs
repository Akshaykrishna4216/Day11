using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member[] m = new Member[2];
            for(int i=0; i<2; i++)
            { 
                Console.WriteLine("Member {0}",i+1 +"details");
                Console.WriteLine("id");
                long a=long.Parse(Console.ReadLine());
                Console.WriteLine("FirstName:");
                string b=Console.ReadLine();
                Console.WriteLine("LastName:");
                string c = Console.ReadLine();
                Console.WriteLine("Email");
                string d = Console.ReadLine();
                Console.WriteLine("Phone number");
                int e= int.Parse(Console.ReadLine());
                Console.WriteLine("License Number");
                string f = Console.ReadLine();
                Console.WriteLine("License Start Date");
                DateTime dt = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",null);
                Console.WriteLine("License Expiry Date");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

                m[i] = new Member(a, b, c, d, e, f, dt, dt1);


            }
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Member{0}",i+1);
                Console.WriteLine(m[i]);
            }
            if (m[0].Equals(m[1]))
            {
                Console.WriteLine("Members are same");
            }
            else
            {
                Console.WriteLine("Members are different");
            }
        }
    }
}
