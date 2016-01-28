using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.FuncionesGlobales
{
    public static class MovimientoS
    {
        public static List<MovimientoN> ListarMovimientosPorIdTipoMov(int p_idtipomov)
        {
            Datos.MovimientoD _D = new Datos.MovimientoD();
            DataTable _DT = _D.ListarMovimientosPorIdTipoMov(p_idtipomov);
            if (_DT != null) 
            {
                List<MovimientoN> _ListadoMovimientos = new List<MovimientoN>();
                for (int a = 0; a < _DT.Rows.Count; a++) 
                {
                    //IdTipoMov,PuntoVenta,NroMov,IdCuenta
                    DataRow _DR = _DT.Rows[a];
                    MovimientoN _M = new MovimientoN(int.Parse(_DR["IdTipoMov"].ToString()), int.Parse(_DR["PuntoVenta"].ToString()), int.Parse(_DR["NroMov"].ToString()), int.Parse(_DR["IdCuenta"].ToString()));
                    _ListadoMovimientos.Add(_M);

                    

                }
                return _ListadoMovimientos;
            } else { return null; }


        }
    }
}
