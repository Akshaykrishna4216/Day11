using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MemberCar
{
    private long _id;

    public long Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private Member _member;

    public Member Mem
    {
        get { return _member; }
        set { _member = value; }
    }
    private Car _car;

    public Car Car
    {
        get { return _car; }
        set { _car = value; }
    }
    private string _carRegistrationNumber;

    public string CarRegistrationNumber
    {
        get { return _carRegistrationNumber; }
        set { _carRegistrationNumber = value; }
    }
    private string _carColor;

    public string CarColor
    {
        get { return _carColor; }
        set { _carColor = value; }
    }
    public MemberCar()
    {
    }
    public MemberCar(long id, Member member, Car car, string carRegistrationNumber, string carColor)
    {
        this._id = id;
        this._member = member;
        this._car = car;
        this._carRegistrationNumber = carRegistrationNumber;
        this._carColor = carColor;
    }
    public static MemberCar createInstance(string s, List<Member> memberList, List<Car> carList)
    {
        string[] s1 = s.Split(',');
        MemberCar mc = new MemberCar();
        mc._id = long.Parse(s1[0]);
        foreach (Member m in memberList)
        {
            if (m.Id == long.Parse(s1[1]))
            {
                mc._member = m;
            }
        }
        foreach (Car c in carList)
        {
            if (c.Id == long.Parse(s1[2]))
            {
                mc._car = c;
            }
        }

        mc._carRegistrationNumber = s1[3];
        mc._carColor = s1[4];
        return mc;
    }
    public static Dictionary<string, List<MemberCar>> groupByColor(List<MemberCar> memberCarList)
    {

        Dictionary<string, List<MemberCar>> aa = new Dictionary<string, List<MemberCar>>();
        foreach (MemberCar mc in memberCarList)
        {


            if (!aa.ContainsKey(mc._carColor))
            {


                aa.Add(mc._carColor, new List<MemberCar>());
                aa[mc._carColor].Add(mc);
            }
            else
            {
                aa[mc._carColor].Add(mc);
            }


        }
        return aa;
    }
}