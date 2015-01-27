using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name:");
            string companyName= string.Format(Console.ReadLine());
            Console.WriteLine("Company address:");
            string companyAdress = string.Format(Console.ReadLine());
            Console.WriteLine("Phone number:");
            string CompanyPhone = string.Format(Console.ReadLine());
            Console.WriteLine("Fax number:");
            string fax = string.Format(Console.ReadLine());
            Console.WriteLine("Web site:");
            string webSite = string.Format(Console.ReadLine());

            Console.WriteLine("Enter a manager first name:");
            string managerFirstName = string.Format(Console.ReadLine());
            Console.WriteLine("Enter a manager last name:");
            string managerLastName = string.Format(Console.ReadLine());
            Console.WriteLine("Enter a manager age:");
            string age = string.Format(Console.ReadLine());
            Console.WriteLine("Enter a manager phone:");
            string managerPhone = string.Format(Console.ReadLine());
            string managerName = managerFirstName + " " + managerLastName;

            Console.WriteLine("Company: {0} \n\r  Adress: {1} \n\r Tel: {2} \n\r  Fax:{3}", companyName, companyAdress, CompanyPhone, fax);
            Console.WriteLine("Manager: {0} (age :{1} ,  tel: {2})", managerName, age, managerPhone);
        }
    }
}
