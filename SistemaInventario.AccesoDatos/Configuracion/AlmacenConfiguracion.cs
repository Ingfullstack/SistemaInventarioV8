using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventario.Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Configuracion
{
    public class AlmacenConfiguracion : IEntityTypeConfiguration<Almacen>
    {
        public void Configure(EntityTypeBuilder<Almacen> builder)
        {
            builder.Property(x => x.Id).IsRequired(true);
            builder.Property(x => x.Nombre).IsRequired();
            builder.Property(x => x.Descripcion).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
        }
    }
}
