using System;
using System.Collections.Generic;
using System.Text;

namespace Oca.envios.Entidades
{
    /// <summary>
    /// Diferentes tipos de servicio que puede tener una sucursal de OCA.
    /// </summary>
    public enum TipoServicio
    {
        /// <summary>
        /// Retorna todas las sucursales, sin importar qué servicio ofrezca
        /// </summary>
        SinFiltro = 0,
        /// <summary>
        /// Admisión de paquetes hace referencia a que la sucursal puede recibir paquetes
        /// </summary>
        AdmisionDePaquetes = 1,
        /// <summary>
        /// Entrega de paquetes hace referencia a que la sucursal puede encargarse de enviar paquetes.
        /// </summary>
        EntregaDePaquetes = 2,
        /// <summary>
        /// Sin descripción
        /// </summary>
        VentaEstampillas = 3
    }
}
