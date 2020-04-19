using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Consulting_Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Entity Records
            //Entity Record Definitions [Objects]

            var EntityRecord1 = Factory.CreateAccount("CUSD 200", EntityType.PublicSchoolDistrict, "(555) 555-5555", "cusd200@gmail.com", "cusd200.org");

            EntityRecord1.Purchase(1500);
            //Console.WriteLine($"EI: {EntityRecord1.EntityIdentifier}, EN: {EntityRecord1.EntityName}, ET: {EntityRecord1.EntityType}, CD: {EntityRecord1.CreationDate}, CPN: {EntityRecord1.ContactPhoneNumber}, EA: {EntityRecord1.EmailAddress}, WA: {EntityRecord1.WebAddress}, AB: {EntityRecord1.AccountBalance:C}");
           
            //Program recording Purchase for EntityRecord 1001 for $6000.00 USD
            Factory.Purchase(1001, 6000);

            var EntityRecord2 = Factory.CreateAccount("Morton Academy", EntityType.PublicSchoolDistrict, "(555) 555-7777", "Mortonacademy@gmail.com", "mortonacademy.org");
            Factory.Purchase(1002, 2000);
            //Console.WriteLine($"EI: {EntityRecord2.EntityIdentifier}, EN: {EntityRecord2.EntityName}, ET: {EntityRecord2.EntityType}, CD: {EntityRecord2.CreationDate}, CPN: {EntityRecord2.ContactPhoneNumber}, EA: {EntityRecord2.EmailAddress}, WA: {EntityRecord2.WebAddress}, AB: {EntityRecord2.AccountBalance:C}");

            var EntityRecord3 = Factory.CreateAccount("SAU 92", EntityType.PublicSchoolDistrict, "(555) 555-8888", "sau92@gmail.com", "sau92.org");
            Factory.Purchase(1003, 10000);
            //Console.WriteLine($"EI: {EntityRecord3.EntityIdentifier}, EN: {EntityRecord3.EntityName}, ET: {EntityRecord3.EntityType}, CD: {EntityRecord3.CreationDate}, CPN: {EntityRecord3.ContactPhoneNumber}, EA: {EntityRecord3.EmailAddress}, WA: {EntityRecord3.WebAddress}, AB: {EntityRecord3.AccountBalance:C}");

            var EntityRecord4 = Factory.CreateAccount("Palatine Townshop", EntityType.Township, "(555) 555-4444", "palatinetownship@gmail.com", "palatinetownship.org");
            //Console.WriteLine($"EI: {EntityRecord4.EntityIdentifier}, EN: {EntityRecord4.EntityName}, ET: {EntityRecord4.EntityType}, CD: {EntityRecord4.CreationDate}, CPN: {EntityRecord4.ContactPhoneNumber}, EA: {EntityRecord4.EmailAddress}, WA: {EntityRecord4.WebAddress}, AB: {EntityRecord4.AccountBalance:C}");

            //Requesting List
            var Entities = Factory.GetEntities();
            //Looping Construct - WriteLine is looping Entity Records to create a listing rather than reading the WriteLine at each Entity Instance
            foreach (var entity in Entities)
            {
                Console.WriteLine($"EI: {entity.EntityIdentifier}, EN: {entity.EntityName}, ET: {entity.EntityType}, CD: {entity.CreationDate}, CPN: {entity.ContactPhoneNumber}, EA: {entity.EmailAddress}, WA: {entity.WebAddress}, AB: {entity.AccountBalance:C}");
            }
            #endregion

        }
    }
}