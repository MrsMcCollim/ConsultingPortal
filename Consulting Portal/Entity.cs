using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Consulting_Portal
{
    #region Enums
    /// <summary>
    /// Provides values for Entity Type array
    /// </summary>
    enum EntityType
    {
        PublicSchoolDistrict,
        Township,
        IVConsultant,
        IVUser,
        }
    #endregion

    #region Entity
    /// <summary>
    /// Entity = IC, IM, District User, District
    /// </summary>
    class Entity
    {
        /// <summary>
        /// Last Entity Identifier = Last Entity Indentifier to be assigned to an Entity upon the creation of a new Entity Record
        /// </summary>
        private static int LastEntityIdentifier = 0;
        private static object entities;

        /// <summary>
        /// Unique Identifier for an Entity Record, Autopopulated, Sequential Assignment
        /// </summary>
        public int EntityIdentifier { get; private set; }

        /// <summary>
        /// Entity Name = Legal Name
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Entity Type = Entity / Person
        /// </summary>
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Creation Date = Creation Date of Entity Record
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Contact Phone Number = Entity's Contact Phone Number
        /// </summary>
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Email Address = Entity's Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Web Address = Entity's Web Address
        /// </summary>
        public string WebAddress { get; set; }

        /// <summary>
        /// Account Balance = Entity's Account Balance in USD
        /// </summary>
        public decimal AccountBalance { get; private set; }
        #endregion

    #region Constructors

    /// <summary>
    /// Entity Identifier is assigned upon creation of new Entity Record, Pre-increment assignment
    /// Creation Date = Time and date stamp of Entity's creation
    /// </summary>
    public Entity()
    {
       EntityIdentifier = ++LastEntityIdentifier;
       CreationDate = DateTime.Now;
    }
    #endregion

    #region Methods

    /// <summary>
    /// Purchase = Addition to Account Balance
    /// </summary>
    /// <param name="amount">Amount of Entity Purchase</param>
    public decimal Purchase(decimal amount)
    {
       AccountBalance += amount;
       return AccountBalance;
    }
        
    /// <summary>
    /// Use = Reduction of Account Balance
    /// </summary>
    /// <param name="amount">Amount of Entity Use</param>
    public decimal Use(decimal amount)
    {
       AccountBalance -= amount;
       return AccountBalance;
    }
    #endregion

    }
}