//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CityDetail
    {
        public int city_id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Nullable<int> tourist_rating { get; set; }
        public string date_established { get; set; }
        public Nullable<int> estimated_population { get; set; }
    }
}
