//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueOfLegends_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Friendship
    {
        public int id { get; set; }
        public string naam { get; set; }
        public int SpelerId { get; set; }
        public int Friendid { get; set; }
    
        public virtual Speler Speler { get; set; }
        public virtual Speler Speler1 { get; set; }
    }
}
