﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomestayDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HomestayEntities1 : DbContext
    {
        public HomestayEntities1()
            : base("name=HomestayEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<RatingLog> RatingLogs { get; set; }
        public virtual DbSet<ScoreLog> ScoreLogs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ImageSaver> ImageSavers { get; set; }
    }
}
