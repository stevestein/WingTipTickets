//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tenant.Mvc.Core.Contexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venue
    {
        public int VenueId { get; set; }
        public string VenueName { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Description { get; set; }
        public Nullable<int> CityId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}