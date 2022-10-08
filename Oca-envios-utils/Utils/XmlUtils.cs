using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Oca.envios.Utils
{
    public static class XmlUtils
    {
        /// <summary>
        /// Parsea un XML en string a un DataSet
        /// </summary>
        /// <param name="xmlData">XML en formato string</param>
        /// <returns>Xml parseado a un DataSet</returns>
       public static DataSet ToDataSet(string xmlData)
       {
            StringReader theReader = new StringReader(xmlData);
            DataSet dataset = new DataSet();
            dataset.ReadXml(theReader);

            return dataset;
       }
    }
}
