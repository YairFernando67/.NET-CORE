using Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria")
                .HasKey(x => x.idcategoria);
            builder.Property(x => x.nombre)
                .HasMaxLength(50);
            builder.Property(x => x.descripcion)
                .HasMaxLength(256);

        }
    }
}
