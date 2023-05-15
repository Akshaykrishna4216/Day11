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

        List<Member> memberList = new List<Member>();
        List<Car> carList = new List<Car>();
        List<MemberCar> memberCarList = new List<MemberCar>();
        Console.WriteLine("Color to search");
        string color = Console.ReadLine();
        Console.WriteLine("Number of member cars");
        string no_of_cars = Console.ReadLine();
        int i, n = Convert.ToInt32(no_of_cars);
        Console.WriteLine("Enter the member car details");
        for (i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            memberCarList.Add(MemberCar.createInstance(s, memberList, carList));
        }

        Dictionary<string, List<MemberCar>> hm = MemberCar.groupByColor(memberCarList);
        Console.WriteLine(color + " car registration numbers:");
        foreach (MemberCar mc in hm[color])
        {
            Console.WriteLine(mc.CarRegistrationNumber);
        }
    }


    public static void initData(List<Member> memberList, List<Car> carList)
    {

        try
        {
            memberList.Add(new Member(1L, "joe", "root", "joe.root@a.com", "1234567890", "AH1", Convert.ToDateTime("12-12-2001"), Convert.ToDateTime("12-12-2010")));
            memberList.Add(new Member(2L, "ben", "stokes", "ben.stokes@a.com", "2345678901", "AH2", Convert.ToDateTime("12-12-2002"), Convert.ToDateTime("12-12-2011")));
            memberList.Add(new Member(3L, "virat", "kohli", "virat.kohli@a.com", "3456789012", "AH3", Convert.ToDateTime("12-12-2003"), Convert.ToDateTime("12-12-2012")));

            carList.Add(new Car(1L, "i10", "sports", 2007, "Hyundai", 8));
            carList.Add(new Car(1L, "alto", "kx1", 2008, "Maruti", 6));
            carList.Add(new Car(1L, "polo", "topline", 2010, "Volks", 5));
            carList.Add(new Car(1L, "kwid", "lxi", 2010, "Renault", 5));

        }
        catch (Exception)
        {
            Console.WriteLine("Could not init Data");
        }

    }

}