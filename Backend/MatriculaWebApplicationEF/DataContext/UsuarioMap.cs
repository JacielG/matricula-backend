using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatriculaWebApplicationEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatriculaWebApplicationEF.DataContext
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios", "dbo");
            builder.HasKey(q => q.UsuarioId);
            builder.Property(e => e.UsuarioId).IsRequired();
            builder.Property(e => e.Contrasena).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();
            builder.Property(e => e.EstaActivo);
        }
    }
}