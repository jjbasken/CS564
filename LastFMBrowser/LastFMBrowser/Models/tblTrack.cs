//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LastFMBrowser.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTrack
    {
        public long ArtistID { get; set; }
        public string mbID { get; set; }
        public string TrackTitle { get; set; }
        public Nullable<long> PlayCount { get; set; }
        public string TrackURL { get; set; }
    
        public virtual tblArtist tblArtist { get; set; }
    }
}