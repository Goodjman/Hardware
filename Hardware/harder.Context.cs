﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hardware
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hardlife : DbContext
    {
        public Hardlife()
            : base("name=Hardlife")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Computers> Computers { get; set; }
        public virtual DbSet<Configurations> Configurations { get; set; }
        public virtual DbSet<CPUs> CPUs { get; set; }
        public virtual DbSet<GPUs> GPUs { get; set; }
        public virtual DbSet<Monitors> Monitors { get; set; }
        public virtual DbSet<Motherboards> Motherboards { get; set; }
    }
}