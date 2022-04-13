using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritosCompra.RemoteModel;

namespace TiendaServicios.Api.CarritosCompra.RemoteInterface
{
    public interface ILibrosService
    {
        Task<(bool resultado, LibroRemote Libro, string ErrorMessage )> GetLibro(Guid LibroId);

    }
}
