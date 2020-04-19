using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Consulting_Portal
{
    class EntityRecords
    {
        static void Main(string[] args)
        {
            #region Entity Records
            //Entity Record Definitions [Objects]

            var EntityRecord1 = EntityFunctions.CreateAccount("CUSD 200", EntityType.PublicSchoolDistrict, "(555) 555-5555", "cusd200@gmail.com", "cusd200.org");
            EntityRecord1.Purchase(1500);
            Console.WriteLine($"EI: {EntityRecord1.EntityIdentifier}, EN: {EntityRecord1.EntityName}, ET: {EntityRecord1.EntityType}, CD: {EntityRecord1.CreationDate}, CPN: {EntityRecord1.ContactPhoneNumber}, EA: {EntityRecord1.EmailAddress}, WA: {EntityRecord1.WebAddress}, AB: {EntityRecord1.AccountBalance:C}");

            var EntityRecord2 = EntityFunctions.CreateAccount("Morton Academy", EntityType.PublicSchoolDistrict, "(555) 555-7777", "Mortonacademy@gmail.com", "mortonacademy.org");
            EntityRecord2.Purchase(2000);
            EntityRecord2.Use(750);
            Console.WriteLine($"EI: {EntityRecord2.EntityIdentifier}, EN: {EntityRecord2.EntityName}, ET: {EntityRecord2.EntityType}, CD: {EntityRecord2.CreationDate}, CPN: {EntityRecord2.ContactPhoneNumber}, EA: {EntityRecord2.EmailAddress}, WA: {EntityRecord2.WebAddress}, AB: {EntityRecord2.AccountBalance:C}");

            var EntityRecord3 = EntityFunctions.CreateAccount("SAU 92", EntityType.PublicSchoolDistrict, "(555) 555-8888", "sau92@gmail.com", "sau92.org");
            EntityRecord3.Purchase(10000);
            EntityRecord3.Use(5500);
            Console.WriteLine($"EI: {EntityRecord3.EntityIdentifier}, EN: {EntityRecord3.EntityName}, ET: {EntityRecord3.EntityType}, CD: {EntityRecord3.CreationDate}, CPN: {EntityRecord3.ContactPhoneNumber}, EA: {EntityRecord3.EmailAddress}, WA: {EntityRecord3.WebAddress}, AB: {EntityRecord3.AccountBalance:C}");

            var EntityRecord4 = EntityFunctions.CreateAccount("Palatine Townshop", EntityType.Township, "(555) 555-4444", "palatinetownship@gmail.com", "palatinetownship.org");
            EntityRecord4.Use(1000);
            Console.WriteLine($"EI: {EntityRecord4.EntityIdentifier}, EN: {EntityRecord4.EntityName}, ET: {EntityRecord4.EntityType}, CD: {EntityRecord4.CreationDate}, CPN: {EntityRecord4.ContactPhoneNumber}, EA: {EntityRecord4.EmailAddress}, WA: {EntityRecord4.WebAddress}, AB: {EntityRecord4.AccountBalance:C}");
            #endregion
        }
    }
}