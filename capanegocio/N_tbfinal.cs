using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidad;
using capadatos;
namespace capanegocio
{
    public class N_tbfinal
    {

        D_tbfinal obj_Datos = new D_tbfinal();

        public List<E_tbfinal> Listartbfinal(string buscar)
        {
            return obj_Datos.Listartbfinal(buscar);
        }

        public void Insertartbfinal(E_tbfinal tbfinal)
        {
            obj_Datos.Insertartbfinal(tbfinal);
        }

        public void Editandotbfinal(E_tbfinal tbfinal)
        {
            obj_Datos.Editartbfinal(tbfinal);
        }

        public void Eliminartbfinal(E_tbfinal tbfinal)
        {
            obj_Datos.Eliminartbfinal(tbfinal);
        }


    }
}
