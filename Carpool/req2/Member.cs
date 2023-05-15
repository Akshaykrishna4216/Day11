using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Member
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

    private DateTime _licenseStartDate;

    public DateTime LicenseStartDate
    {
        get { return _licenseStartDate; }
        set { _licenseStartDate = value; }
    }

    private DateTime _licenseExpiryDate;

    public DateTime LicenseExpiryDate
    {
        get { return _licenseExpiryDate; }
        set { _licenseExpiryDate = value; }
    }
    ArrayList CarList;

    public ArrayList CarList1
    {
        get { return CarList; }
        set { CarList = value; }
    }

    public Member() { }

    public Member(long id, string first, string last, string email, string contact, string license, DateTime start, DateTime expiry)
    {
        Id = id;
        FirstName = first;
        LastName = last;
        Email = email;
        ContactNumber = contact;
        LicenseNumber = license;
        LicenseStartDate = start;
        LicenseExpiryDate = expiry;
    }

    public override string ToString()
    {
        return string.Format("Name: " + this._firstName + " , " + this._lastName + "\n" + "Member contact details: " + this._contactNumber + " , " + this._email);
    }
    public override bool Equals(object obj)
    {
        Member m = null;
        bool flag = false;
        if (obj is Member)
            m = (Member)obj;
        if (m == null)
            return false;
        if (this._email.ToUpper().Equals(m._email.ToUpper()) && this._contactNumber.ToUpper().Equals(m._contactNumber.ToUpper()))
        {
            flag = true;
        }
        return flag;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public static Member FindMember(long Id, ArrayList memberList)
    {
        Member m = null;
        foreach (Object o in memberList)
        {
            if (o is Member)
            {
                m = (Member)o;
                if (m.Id == Id)
                {
                    return m;
                }
            }
        }
        return m;
    }

}

