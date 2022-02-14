using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions <DatabaseContext>options ):base(options)
        {

        }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Personel> Personller{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Suplier> Supliers{ get; set; }
        public DbSet<SuplierProduct> suplierProducts{ get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firma>().ToTable("Tbl_Firma");
            modelBuilder.Entity<Personel>().ToTable("Tbl_Personel");
            modelBuilder.Entity<Firma>().Property(X => X.Unvan).HasColumnName("FirmaUnvan");
            //modelBuilder.Entity<Firma>().Property(X => X.Anahtar).HasColumnName("Anahtar");

            modelBuilder.Entity<Firma>().HasKey(x => x.Anahtar);//birincil anahtar tanımlama
            modelBuilder.Entity<Personel>().Property(x => x.İsim).HasColumnName("Ad");
            modelBuilder.Entity<Personel>().Property(x => x.Soyisim).HasColumnName("Soyad");
            modelBuilder.Entity<Personel>().Property(x => x.Telefon).HasColumnName("TelefonNumarası");
            modelBuilder.Entity<Personel>().HasKey(x => x.Anahtar);
            //Notmapped burdakı karsılıgı
            modelBuilder.Entity<Firma>().Ignore(x => x.FirmaLisansKey);

            //REquired ın burda kullanımı
            modelBuilder.Entity<Personel>().Property(x => x.İsim).IsRequired();

            //max length
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).IsRequired().HasMaxLength(100);

            //birecok ilişki

            //modelBuilder.Entity<Personel>().HasOne(x => x.Firma).WithMany(x => x.personeller).HasForeignKey(x => x.firID);

            modelBuilder.Entity<Firma>().HasMany(x => x.personeller).WithOne(x => x.Firma).HasForeignKey(x => x.firID).OnDelete(DeleteBehavior.Cascade);//baglı olan butun alanlarla sıler

            //coka cok ilişki
            modelBuilder.Entity<SuplierProduct>().HasKey(x => new { x.ProductID, x.SuplierID });//composite key oluşturdum
            modelBuilder.Entity<SuplierProduct>().HasOne(x => x.Product).WithMany(x => x.SuplierProducts).HasForeignKey(x => x.ProductID);
            modelBuilder.Entity<SuplierProduct>().HasOne(X => X.Suplier).WithMany(x => x.SuplierProducts).HasForeignKey(X => X.SuplierID);

            //birebir ilişki
            modelBuilder.Entity<Product>().HasOne(x => x.ProductDEtails).WithOne(x => x.Product).HasForeignKey<ProductDEtails>(x => x.prtID);

            

        }

    }
}
