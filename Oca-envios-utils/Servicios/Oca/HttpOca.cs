using Oca.envios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;

namespace Oca.envios.Servicios.Oca
{
    /// <summary>
    /// HtppOca es la clase principal, encargada de todos los metodos referidos al servicio SOAP de Oca
    /// </summary>
    public class HttpOca : OcaGeneral
    {
        public HttpOca() : base()
        {
            
        }
        /// <summary>
        /// Obtiene las sucursales desde el servicio de Oca
        /// </summary>
        /// <param name="tipo">Tipo de servicio que de la sucursal que se quiera restacar, por defecto, devuelve todas</param>
        /// <param name="ConCodigosPostalesAcepta">En el caso de que sea TRUE, rellena la lista "CodigosPostalesQueAcepta" de la clase Sucursal, caso contrario, la deja vacia y sin inicializar</param>
        /// <returns>Lista de sucursales</returns>
        public List<Sucursal> ObtenerSucursalesOca(TipoServicio tipo = TipoServicio.SinFiltro, bool ConCodigosPostalesAcepta = true)
        {
            string xmlResponse = base.wc.DownloadString(base.epak_WebService + "Oep_TrackEPak.asmx/GetCentrosImposicionConServicios?");
            DataSet dataset = Utils.XmlUtils.ToDataSet(xmlResponse);
            return base.DataSetToSucursal(dataset, tipo, ConCodigosPostalesAcepta);
        }

    }
}
