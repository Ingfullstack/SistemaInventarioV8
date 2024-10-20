using SistemaInventario.Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IAlmacenRepositorio : IRepositorio<Almacen>
    {
        Task Actualizar(Almacen almacen);
    }
}
