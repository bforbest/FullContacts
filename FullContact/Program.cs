using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContact
{
    class Program
    {
        private const string APIKEY = "68783fbb8e76057a";
        private const string FULLCONTACTAPIJSONURL = "https://api.fullcontact.com/v2/person.json?email=";
        static void Main(string[] args)
        {


            try
            {
                var f = new FullContactLibrary.FullContactApi(FULLCONTACTAPIJSONURL, APIKEY);
                Console.WriteLine("Write Email");
                var mail = Console.ReadLine();
                var s = AsyncContext.Run(() => f.LookupPersonByEmailAsync(mail));
                Console.WriteLine("Fullname");
                Console.WriteLine(s.contactInfo.fullName);
                Console.WriteLine("Likelihood: " + s.likelihood);

                Console.WriteLine("Family name: " + s.contactInfo.familyName);
                Console.WriteLine("--------------Social profiles------------");

                foreach (var item in s.socialProfiles)
                {
                    Console.WriteLine(item.type);
                    Console.WriteLine(item.url);
                    Console.WriteLine(item.username);
                }

                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
