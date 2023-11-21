/* Autor: Kevin Gutierrez
 * Fecha: 18/10/2014 - 19/10/2014 
 * Comentario: Capa de datos modulo Hoteleria Hotel San Carlos
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    class csEntidades
    {
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public int iObtenerCodigo()
        {
            string sQuery = "select * from " + sNombreTabla;
            int iCodigo = 0;
            ArrayList alDatosEntrada = ODBCconnector.csFunciones.alConsultar(sQuery);
            if (alDatosEntrada != null && alDatosEntrada.Count != 0)
            {
                ArrayList alFila = (ArrayList)alDatosEntrada[alDatosEntrada.Count - 1];
                iCodigo = Convert.ToInt32(alFila[0]) + 1;
            }
            else
            {
                iCodigo = 1;
            }
            return iCodigo;
        }

        public ArrayList alObtenerCamposTabla()
        {
            string sQuery = "select column_name from information_schema.columns where table_name = '" + sNombreTabla + "'";
            ArrayList alDatosEntrada = ODBCconnector.csFunciones.alConsultar(sQuery);
            ArrayList alCampos = new ArrayList();
            if (alDatosEntrada != null)
            {
                foreach (ArrayList alFila in alDatosEntrada)
                {
                    alCampos.Add(alFila[0].ToString());
                }
            }
            return alCampos;
        }
    }
}
