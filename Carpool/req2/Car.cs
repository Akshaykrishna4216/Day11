using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    private long _id;

    public long Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    private int _makeYear;

    public int MakeYear
    {
        get { return _makeYear; }
        set { _makeYear = value; }
    }

    private string _company;

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    private int _comfortLevel;

    public int ComfortLevel
    {
        get { return _comfortLevel; }
        set { _comfortLevel = value; }
    }

    public Car() { }

    public Car(long id, string name, string model, int year, string company, int comfort)
    {
        Id = id;
        Name = name;
        Model = model;
        MakeYear = year;
        Company = company;
        ComfortLevel = comfort;
    }

    public static Car FindCar(long carId, ArrayList carList)
    {
        Car c = null;
        foreach (Object o in carList)
        {
            if (o is Car)
            {
                c = (Car)o;
                if (c._id == carId)
                {
                    return c;
                }
            }
        }
        return c;
    }
    public static ArrayList InitCar()
    {
        return new ArrayList();
    }
}

