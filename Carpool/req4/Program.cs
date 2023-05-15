using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("id");
        long id = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("name");
        String name = Console.ReadLine();
        Console.WriteLine("type");
        String ct = Console.ReadLine();
        Console.WriteLine("distance");
        Double dist = Convert.ToDouble(Console.ReadLine());

        Car carObj = null;
        if (ct.Equals("hatchback"))
        {
            Console.WriteLine("power windows");
            Boolean pw = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("automatic");
            Boolean am = Convert.ToBoolean(Console.ReadLine());
            carObj = new HatchBack(id, name, pw, am);
        }
        else if (ct.Equals("sedan"))
        {
            Console.WriteLine("abs enabled");
            Boolean pw = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("boot space");
            Int32 am = Convert.ToInt32(Console.ReadLine());
            carObj = new Sedan(id, name, pw, am);
        }
        else
        {
            Console.WriteLine("rear cooling vents");
            Boolean pw = Convert.ToBoolean(Console.ReadLine());
            carObj = new UtilityCar(id, name, pw);

        }

        Console.WriteLine("Cost is Rs " + Math.Round(carObj.CalculateDriveCost(dist)));

    }
}
