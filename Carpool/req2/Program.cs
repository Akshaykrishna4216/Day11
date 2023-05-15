using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ArrayList memberList = new ArrayList();
        ArrayList carList = new ArrayList();
        ArrayList memberCarList = new ArrayList();
        carList = Car.InitCar();
        InitData(memberList, carList);
        while (true)
        {
            Console.WriteLine("Menu: \n 1) Add a Member \n 2) Add a Car \n 3) Assign Car to Member (Assume valid data is supplied) \n 4) Cars Owned \n 5) Exit");
            Int32 option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Member m = AddMember();
                memberList.Add(m);
            }
            if (option == 2)
            {
                Car c = AddCar();
                carList.Add(c);
            }
            if (option == 3)
            {
                AssignCar(memberList, carList);
            }
            if (option == 4)
            {
                Console.WriteLine("member id");
                string memid = Console.ReadLine();
                CarsOwned(memid, memberList);
            }
            if (option == 5)
            {
                break;
            }
        }

    }

    //Dont change the specification of this method
    public static void CarsOwned(string memberId, ArrayList memberList)
    {
        Member m = null;
        foreach (Object o in memberList)
        {
            if (o is Member)
            {
                m = (Member)o;
                if (m.Id == long.Parse(memberId))
                {
                    Console.WriteLine("Number of cars : " + m.CarList1.Count);
                    Console.WriteLine("Registration Numbers :");
                    MemberCar c = null;
                    foreach (Object obj in m.CarList1)
                    {
                        if (obj is MemberCar)
                        {
                            c = (MemberCar)obj;
                        }
                        Console.WriteLine(c.CarRegistrationNumber);

                    }
                }
            }

        }
    }

    public static void AssignCar(ArrayList memberList, ArrayList carList)
    {
        long memberId, carId;
        string id, regNum, color;
        try
        {
            Console.WriteLine("member car id");
            id = Console.ReadLine();
            Console.WriteLine("member id");
            memberId = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("car id");
            carId = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("car registration");
            regNum = Console.ReadLine();
            Console.WriteLine("color");
            color = Console.ReadLine();
            Car c = Car.FindCar(carId, carList);
            Member m = Member.FindMember(memberId, memberList);
            MemberCar mc = new MemberCar(carId, c, m, regNum, color);
            if (m.CarList1 == null)
            {
                m.CarList1 = new ArrayList();
            }
            m.CarList1.Add(mc);

        }
        catch (Exception e)
        {
            Console.WriteLine("Could not assign");
        }
    }

    public static Car AddCar()
    {

        string id, name, model, makeYear, company, comfortLevel;
        Car c = null;
        try
        {
            Console.WriteLine("id: ");
            id = Console.ReadLine();
            Console.WriteLine("name: ");
            name = Console.ReadLine();
            Console.WriteLine("model: ");
            model = Console.ReadLine();
            Console.WriteLine("makeYear: ");
            makeYear = Console.ReadLine();
            Console.WriteLine("company: ");
            company = Console.ReadLine();
            Console.WriteLine("comfort level: ");
            comfortLevel = Console.ReadLine();
            c = new Car(Convert.ToInt64(id), name, model, Convert.ToInt32(makeYear), company, Convert.ToInt32(comfortLevel));

        }
        catch (Exception e)
        {
            Console.WriteLine("Could not create Car");
        }
        return c;

    }

    public static Member AddMember()
    {
        string id, firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate;
        Member m = null;
        Console.WriteLine("id: ");
        id = Console.ReadLine();
        Console.WriteLine("first name: ");
        firstName = Console.ReadLine();
        Console.WriteLine("last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine("email: ");
        email = Console.ReadLine();
        Console.WriteLine("contact number: ");
        contactNumber = Console.ReadLine();
        Console.WriteLine("license number: ");
        licenseNumber = Console.ReadLine();
        Console.WriteLine("license start date: ");
        licenseStartDate = Console.ReadLine();
        Console.WriteLine("license expiry date: ");
        licenseExpiryDate = Console.ReadLine();
        m = new Member(Convert.ToInt64(id), firstName, lastName, email, contactNumber, licenseNumber,
          DateTime.ParseExact(licenseStartDate, "dd-MM-yyyy", null), DateTime.ParseExact(licenseExpiryDate, "dd-MM-yyyy", null));
        return m;


    }

    public static void InitData(ArrayList memberList, ArrayList carList)
    {
        memberList.Add(new Member(1L, "joe", "root", "joe.root@a.com", "1234567890", "AH1", DateTime.ParseExact("12-12-2001", "dd-MM-yyyy", null), DateTime.ParseExact("12-12-2010", "dd-MM-yyyy", null)));
        memberList.Add(new Member(2L, "ben", "stokes", "ben.stokes@a.com", "2345678901", "AH2", DateTime.ParseExact("12-12-2002", "dd-MM-yyyy", null), DateTime.ParseExact("12-12-2011", "dd-MM-yyyy", null)));
        memberList.Add(new Member(3L, "virat", "kohli", "virat.kohli@a.com", "3456789012", "AH3", DateTime.ParseExact("12-12-2003", "dd-MM-yyyy", null), DateTime.ParseExact("12-12-2012", "dd-MM-yyyy", null)));

        carList.Add(new Car(1L, "i10", "sports", 2007, "Hyundai", 8));
        carList.Add(new Car(2L, "alto", "kx1", 2008, "Maruti", 6));
        carList.Add(new Car(3L, "polo", "topline", 2010, "Volks", 5));
        carList.Add(new Car(4L, "kwid", "lxi", 2010, "Renault", 5));

    }
}
