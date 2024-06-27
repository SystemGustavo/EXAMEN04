using Examen04.Datos;
using Examen04.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen04.Negocio
{
    public  class NRegion
    {
        public void Registrar(ERegion objRegion)
        {
            DRegion region = new DRegion();
            region.Registrar(objRegion);
        }

        public void Actualizar(ERegion objRegion)
        {
            DRegion region = new DRegion();
            region.Actualizar(objRegion);
        }

        public void Eliminar(int RegionId)
        {
            DRegion region = new DRegion();
            region.Eliminar(RegionId);
        }

        public List<ERegion> ListarRegiones()
        {
            DRegion region = new DRegion();
            return region.ListarRegiones();
        }

    }
}
