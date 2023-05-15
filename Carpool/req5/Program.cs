using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Members:");
        int i, n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the member details:");
        ArrayList memberList = new ArrayList();

        for (i = 0; i < n; i++)
        {
            try
            {
                string s = Console.ReadLine();
                Member mm = Member.CreateInstance(s);
                if (mm != null)
                    memberList.Add(mm);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType() + " : " + e.Message);
            }
        }
        Console.WriteLine("\nThe member details are:");
        memberList.Sort();
        foreach (Member m in memberList)
        {
            Console.WriteLine(m.Id + "," + m.FirstName + "," + m.LastName + "," + m.Email + "," + m.ContactNumber);
        }

    }
}