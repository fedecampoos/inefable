using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace proyectoinefrable.Models
{
    public partial class INEFABLEContext : DbContext
    {
        public INEFABLEContext()
        {
        }

        public INEFABLEContext(DbContextOptions<INEFABLEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Clienteproducto> Clienteproductos { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NB-CONSUL-117;Database=INEFABLE;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdC)
                    .HasName("PK__CLIENTES__B87EA509088986BE");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fechanac)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHANAC");

                entity.Property(e => e.Nombreusuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREUSUARIO");

                entity.Property(e => e.Telefono).HasColumnName("TELEFONO");
            });

            modelBuilder.Entity<Clienteproducto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLIENTEPRODUCTO");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.Preciototal).HasColumnName("PRECIOTOTAL");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdC)
                    .HasConstraintName("FK_DEP");

                entity.HasOne(d => d.IdPNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdP)
                    .HasConstraintName("FK_DEPA");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCo)
                    .HasName("PK__COMPRA__8B622F984A656FCF");

                entity.ToTable("COMPRA");

                entity.Property(e => e.IdCo).HasColumnName("ID_CO");

                entity.Property(e => e.Fechacomppra)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHACOMPPRA");

                entity.Property(e => e.IdC).HasColumnName("ID_C");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdC)
                    .HasConstraintName("FK_DEPAT");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PK__PRODUCTO__B87EA51CD3307488");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.IdP).HasColumnName("ID_P");

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEN");

                entity.Property(e => e.Nombreproducto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOMBREPRODUCTO");

                entity.Property(e => e.Precio).HasColumnName("PRECIO");

                entity.Property(e => e.Stock).HasColumnName("STOCK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
