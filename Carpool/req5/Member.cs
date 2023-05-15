using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Member : IComparable
{
    private long _id;

    public long Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _firstName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    private string _lastName;

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    private string _email;

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private string _contactNumber;

    public string ContactNumber
    {
        get { return _contactNumber; }
        set { _contactNumber = value; }
    }
    private string _licenseNumber;

    public string LicenseNumber
    {
        get { return _licenseNumber; }
        set { _licenseNumber = value; }
    }
    private DateTime _LicenseStartDate;

    public DateTime LicenseStartDate
    {
        get { return _LicenseStartDate; }
        set { _LicenseStartDate = value; }
    }
    private DateTime _licenseExpiryDate;

    public DateTime LicenseExpiryDate
    {
        get { return _licenseExpiryDate; }
        set { _licenseExpiryDate = value; }
    }

    public Member()
    {
    }
    public Member(long id, string firstName, string lastName, string email, string contactNumber, string licenseNumber, DateTime licenseStartDate, DateTime licenseExpiryDate)
    {
        this._id = id;
        this._firstName = firstName;
        this._lastName = lastName;
        this._email = email;
        this._contactNumber = contactNumber;
        this._licenseNumber = licenseNumber;
        this._LicenseStartDate = licenseStartDate;
        this._licenseExpiryDate = licenseExpiryDate;
    }

    public static Member CreateInstance(string s)
    {
        string[] ss = s.Split(',');
        Member mm = new Member();
        mm._id = long.Parse(ss[0]);
        mm._firstName = ss[1];
        mm._lastName = ss[2];
        mm._email = ss[3];
        mm._contactNumber = ss[4];
        mm._licenseNumber = ss[5];
        mm._LicenseStartDate = DateTime.ParseExact(ss[6], "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None);
        mm._licenseExpiryDate = DateTime.ParseExact(ss[7], "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None);
        try
        {
            if ((mm._email.EndsWith(".com") || mm._email.EndsWith(".org")) && mm._email.Contains('@'))
                return mm;
            else

                throw new CustomException();
        }
        catch (CustomException ex)
        {
            ex.Message();
            Console.Write(mm.FirstName);
            Console.WriteLine();
            return null;
        }
    }

    public int CompareTo(object obj)
    {
        Member m = (Member)obj;
        return this._firstName.CompareTo(m._firstName);
    }
}