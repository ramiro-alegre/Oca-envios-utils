using Oca.envios.Entidades;
using Oca.envios.Entidades.Estados;
using Oca.envios.Entidades.Provincia;
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
        /// Obtiene las sucursales con servicios activas al momento desde el servicio de Oca
        /// </summary>
        /// <param name="tipo">Tipo de servicio que de la sucursal que se quiera restacar, por defecto, devuelve todas</param>
        /// <param name="ConCodigosPostalesAcepta">En el caso de que sea TRUE, rellena la lista "CodigosPostalesQueAcepta" de la clase Sucursal, caso contrario, la deja vacia y sin inicializar</param>
        /// <returns>Lista de sucursales</returns>
        public List<Sucursal> ObtenerSucursalesActivasConServicios(TipoServicio tipo = TipoServicio.SinFiltro, bool ConCodigosPostalesAcepta = true)
        {
            string xmlResponse = base.wc.DownloadString(base.epak_WebService + "Oep_TrackEPak.asmx/GetCentrosImposicionConServicios?");
            DataSet dataset = Utils.XmlUtils.ToDataSet(xmlResponse);
            return base.DataSetToSucursal(dataset, tipo, ConCodigosPostalesAcepta);
        }
        /// <summary>
        /// Obtiene todos los estados que tuvo el envío.
        /// </summary>
        /// <param name="numeroEnvio">Numero de envio dado por Oca</param>
        /// <returns>Lista con todos los estados</returns>
        public List<EstadoEnvio> TrackingPieza(string numeroEnvio)
        {
            string xmlResponse = this.wc.DownloadString(base.epak_WebService + "Oep_TrackEPak.asmx/Tracking_Pieza?NroDocumentoCliente=0&CUIT=0&Pieza=" + numeroEnvio);
            DataSet dataset = Utils.XmlUtils.ToDataSet(xmlResponse);
            return base.DataSetToEstado(dataset);
        }
        public List<Provincia> ObtenerProvinciasOca()
        {
            string xmlResponse = base.wc.DownloadString(base.epak_WebService + "Oep_TrackEPak.asmx/GetProvincias");
            DataSet dataset = Utils.XmlUtils.ToDataSet(xmlResponse);
            return base.DataSetToProvincia(dataset);
        }
    }
}
