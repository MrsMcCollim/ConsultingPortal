using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consulting_Portal
{
    static class Factory
    {
        #region Attic
        /// <summary>
        /// Creates empty list in Attic (i.e. reserves Temporary storage)
        /// </summary>
        private static FactoryContext db = new FactoryContext();
        #endregion

        #region Create New Entity
        /// <summary>
        /// [Factory] Function = Creates new instance of an Entity Record
        /// </summary>
        /// <param name="entityName">Name of Entity</param>
        /// <param name="entityType">Type of Entity</param>
        /// <param name="contactPhoneNumber">Entity's Phone Number</param>
        /// <param name="emailAddress">Entity's Email Address</param>
        /// <param name="webAddress">Entity's Web Address</param>
        /// <returns></returns>
        public static Entity CreateAccount(string entityName, EntityType entityType, string contactPhoneNumber, string emailAddress, string webAddress)
        {
            var Entity = new Entity
            {
                EntityName = entityName,
                EntityType = entityType,
                ContactPhoneNumber = contactPhoneNumber,
                EmailAddress = emailAddress,
                WebAddress = webAddress
            };
            db.Entities.Add(Entity);
            db.SaveChanges();
            return Entity;
        }
        #endregion

        #region IEnumerable
        //Allows for read-only return of Entities List for testing/data validation
        public static IEnumerable<Entity> GetEntities()
        {
            return db.Entities;
        }
        #endregion

    #region Purchase
        public static void Purchase(int entityIdentifier, decimal amount)
        {
            //LINQ
            var entity = db.Entities.SingleOrDefault(Entity => Entity.EntityIdentifier == entityIdentifier);
            if (entity == null)
                return;
            
            //Call Purchase Method from Entity Class
            entity.Purchase(amount);
            
            //Initiate a Transaction
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                Description = "Service Hours Purchase",
                Amount = amount,
                TransactionType = TypeOfTransaction.Credit,
                EntityIdentifier = entityIdentifier
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();
            return Transaction;
            #endregion
        }
    }
}
