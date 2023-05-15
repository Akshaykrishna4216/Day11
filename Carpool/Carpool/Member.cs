using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Carpool
{
    public class Member
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
			get { return  _lastName; }
			set {  _lastName = value; }
		}
		private string _email;
		public string Email
		{ get { return _email; } set {  _email = value; } }

		private int _phone;
			public int Phone
		{ get { return _phone; } set { _phone = value; } }

		private string _licenseNumber;
		public string LicenseNumber
		{ get { return _licenseNumber; }
            set
            {
                _licenseNumber = value;
            } }
		private DateTime _licenseStartDate;
		public DateTime LicenseStartDate
		{ get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            } }
		private DateTime _licenseExpiryDate;
		public DateTime LicenseExpiryDate
		{ get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            } }
		public Member(long id,  string firstName,  string lastName,  string email,  int phone,  string licenseNumber,  DateTime licenseStartDate,  DateTime licenseExpiryDate)
        {
            Id = id;
           
            FirstName = firstName;
           
            LastName = lastName;
           
            Email = email;
          
            Phone = phone;
           
            LicenseNumber = licenseNumber;
           
            LicenseStartDate = licenseStartDate;
            LicenseExpiryDate = licenseExpiryDate;
           
        }

        public override string ToString()
        {
            return "Name:"+_firstName+" " + _lastName + "\n" + "Email:" + _email + "\n" + "ContactDetails" + _phone;
        }
        public override bool Equals(object obj)
        {
            Member m=obj as Member;
            if (this._email.Equals(m._email)&& this._phone.Equals(m._phone)) 
            {
                return true;
            }
            else
            {
                return false;
            }
           
           
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }





    }
}