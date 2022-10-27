using System;
using System.Collections.Generic;
using System.Text;

namespace Oca.envios.Entidades.Estados
{
    public class EstadoEnvio
    {
        /// <summary>
        /// Estado principal 
        /// </summary>
        public string Estado { get; set; }
        /// <summary>
        /// Motivo del por qué se eligió este estado. Generalmente, Sin Motivo.
        /// </summary>
        public string MotivoEstado { get; set; }
        /// <summary>
        /// Nombre de la sucursal donde se encuentra.
        /// </summary>
        public string Sucursal { get; set; }
        /// <summary>
        /// Fecha en que se cambio al estado actual
        /// </summary>
        public DateTime fecha { get; set; }
    }
}
