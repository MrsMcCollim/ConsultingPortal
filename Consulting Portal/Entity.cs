using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Consulting_Portal
{
    /// <summary>
    /// Entity = IC, IM, District User, District
    /// </summary>
    class Entity
    {       
        /// <summary>
        /// Unique Identifier for Entity Record
        /// </summary>
        public int EntityIdentifier { get; set; }

        /// <summary>
        /// Entity Name = Legal Name
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Entity Type = Entity / Person
        /// </summary>
        public string EntityType { get; set; }
        /// <summary>
        /// Creation Date = Creation Date of Entity Record
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Contact Phone Number = Entity's Contact Phone Number
        /// </summary>
        public PhoneAttribute ContactPhoneNumber { get; set; }
        /// <summary>
        /// Email Address = Entity's Email Address
        /// </summary>
        public EmailAddressAttribute EmailAddress { get; set; }
        /// <summary>
        /// Web Address = Entity's Web Address
        /// </summary>
        public UrlAttribute WebAddress { get; set; }
    }
}
