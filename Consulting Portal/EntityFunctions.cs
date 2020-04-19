using System;
using System.Collections.Generic;
using System.Text;

namespace Consulting_Portal
{
    static class EntityFunctions
    {
        /// <summary>
        /// Factory, Encapcilation
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
            return Entity;
        }
    }
}
