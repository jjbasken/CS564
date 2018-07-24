﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LastFMDataEntities : DbContext
    {
        public LastFMDataEntities()
            : base("name=LastFMDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lnkUserArtist> lnkUserArtists { get; set; }
        public virtual DbSet<lnkUserTagArtist> lnkUserTagArtists { get; set; }
        public virtual DbSet<tblArtist> tblArtists { get; set; }
        public virtual DbSet<tblTag> tblTags { get; set; }
        public virtual DbSet<tblTrack> tblTracks { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<sysMenuList> sysMenuLists { get; set; }
    
        public virtual ObjectResult<GET_SIMILAR_ARTISTS_Result> GET_SIMILAR_ARTISTS(Nullable<long> artistID)
        {
            var artistIDParameter = artistID.HasValue ?
                new ObjectParameter("ArtistID", artistID) :
                new ObjectParameter("ArtistID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_SIMILAR_ARTISTS_Result>("GET_SIMILAR_ARTISTS", artistIDParameter);
        }
    
        public virtual int TAG_ARTIST(Nullable<long> uSERID, Nullable<long> aRTIST, string tAGVALUE)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(long));
    
            var aRTISTParameter = aRTIST.HasValue ?
                new ObjectParameter("ARTIST", aRTIST) :
                new ObjectParameter("ARTIST", typeof(long));
    
            var tAGVALUEParameter = tAGVALUE != null ?
                new ObjectParameter("TAGVALUE", tAGVALUE) :
                new ObjectParameter("TAGVALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TAG_ARTIST", uSERIDParameter, aRTISTParameter, tAGVALUEParameter);
        }
    
        public virtual int REMOVE_TAG(Nullable<long> uSERID, Nullable<long> aRTIST, string tAGVALUE)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(long));
    
            var aRTISTParameter = aRTIST.HasValue ?
                new ObjectParameter("ARTIST", aRTIST) :
                new ObjectParameter("ARTIST", typeof(long));
    
            var tAGVALUEParameter = tAGVALUE != null ?
                new ObjectParameter("TAGVALUE", tAGVALUE) :
                new ObjectParameter("TAGVALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("REMOVE_TAG", uSERIDParameter, aRTISTParameter, tAGVALUEParameter);
        }
    
        public virtual ObjectResult<FIND_ARTIST_LISTENERS_Result> FIND_ARTIST_LISTENERS(Nullable<long> uSERID, Nullable<long> aRTIST)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(long));
    
            var aRTISTParameter = aRTIST.HasValue ?
                new ObjectParameter("ARTIST", aRTIST) :
                new ObjectParameter("ARTIST", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FIND_ARTIST_LISTENERS_Result>("FIND_ARTIST_LISTENERS", uSERIDParameter, aRTISTParameter);
        }
    }
}
