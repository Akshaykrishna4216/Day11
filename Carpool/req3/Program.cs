using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string menu = "Menu:\n 1) Valid Car registration Number\n 2) Convert Car registration Number\n "
                      + "3) Valid Driving License";
        Console.WriteLine(menu);
        Console.WriteLine("Enter choice");
        int x = Convert.ToInt32(Console.ReadLine());
        string regnum = "", input = "";
        switch (x)
        {
            case 1:
                Console.WriteLine("car registration number");
                regnum = Console.ReadLine();
                ValidateRegNum(regnum);
                break;
            case 2:
                Console.WriteLine("car registration number");
                regnum = Console.ReadLine();
                ConvertRegNum(regnum);
                break;
            case 3:
                Console.WriteLine("driving license issue date");
                input = Console.ReadLine();
                ValidateDrivingLicense(input);
                break;
        }
        Console.ReadKey();

    }

    public static void ValidateRegNum(string reg)
    {
        string[] str = reg.Split('-');

        if (str.Length != 4)
        {
            Console.WriteLine("{0} is Invalid", reg);
            return;
        }
        //if (str[0].Length != 2 || str[1].Length != 2 || str[2].Length != 2 || str[3].Length != 4)
        //{
        //    Console.WriteLine("{0} is Invalid", reg);
        //    return;
        //}

        if (str[0].Length == 2 && str[1].Length == 2 && str[2].Length == 2 && str[3].Length == 4)
        {
            if ((char.IsLetter(str[0].ToCharArray()[0]) && char.IsLetter(str[0].ToCharArray()[1])) && (char.IsDigit(str[1].ToCharArray()[0]) && char.IsDigit(str[1].ToCharArray()[1])) && (char.IsLetter(str[2].ToCharArray()[0]) && char.IsLetter(str[2].ToCharArray()[1])) && (char.IsDigit(str[3].ToCharArray()[0]) && char.IsDigit(str[3].ToCharArray()[1]) && char.IsDigit(str[3].ToCharArray()[2]) && char.IsDigit(str[3].ToCharArray()[3])))
                Console.WriteLine("{0} is Valid", reg);
        }
        else
        {
            Console.WriteLine("{0} is Invalid", reg);
            return;
        }
    }

    public static void ConvertRegNum(string reg)
    {
        char[] c = reg.ToCharArray();
        if (reg.Length != 13)
        {
            return;
        }
        //if (!char.IsSymbol(c[2]) && !char.IsSymbol(c[5]) && !char.IsSymbol(c[8]))
        //    return;
        c[2] = '-';
        c[5] = '-';
        c[8] = '-';
        reg = new string(c);
        Console.WriteLine(reg.ToUpper());

    }

    public static void ValidateDrivingLicense(string inp)
    {

        DateTime dt1 = new DateTime(2017, 6, 15);
        DateTime dt2 = DateTime.ParseExact(inp, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //int ts = dt1.Year - dt2.Year;
        double time = Math.Round(((dt1 - dt2).TotalDays) / 365, 0);
        if (time <= 10)
        {
            Console.WriteLine("{0} years old license - valid", time);
        }
        else
            Console.WriteLine("{0} years old license - expired", time);
    }

}