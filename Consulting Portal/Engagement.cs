using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Consulting_Portal
{
    /// <summary>
    /// Engagement = Consulting Session
    /// </summary>
    class Engagement
    {
        /// <summary>
        /// Engagement Name = Given Name for Engagement
        /// </summary>
        public string EngagementName { get; set; }
        /// <summary>
        /// Description = Description of Engagement
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Scheduled Date Time = Date and Time Engagement was scheduled
        /// </summary>
        public DateTime ScheduledDateTime { get; set; }
        /// <summary>
        /// Engagement Date Time = Date and Time of Engagement
        /// </summary>
        public DateTime EngagementDateTime { get; set; }
        /// <summary>
        /// Engagement Hours = Engagement duration in hours
        /// </summary>
        public int EngagementHours { get; set; }
        /// <summary>
        /// Consultant = Consultant Entity assigned to Engagement
        /// </summary>
        public string Consultant { get; set; }
        /// <summary>
        /// Client = Cleint Entity receiving services
        /// </summary>
        public string Client { get; set; }
    }
}
