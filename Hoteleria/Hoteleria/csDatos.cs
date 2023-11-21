/* Autor: Daniel Moreno,Kevin Gutierrez
 * Fecha: 19/10/2014 - 21/10/2014 
 * Comentario: Capa de datos modulo Hoteleria Hotel San Carlos
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteleria
{
    class csDatos
    {
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public ArrayList alConsultarRegistro(string sQuery)
        {
            ArrayList alDatosSalida = new ArrayList();
            if (sQuery != null)
            {
                alDatosSalida = ODBCconnector.csFunciones.alConsultar(sQuery);
            }
            return alDatosSalida;
        }

        public void vInsertarRegistro(ArrayList alDatos)
        {
            string sQuery = "insert into " + sNombreTabla + " values (";
            bool bComa = false;
            foreach (string sDato in alDatos)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += "'" + sDato + "'";
            }
            sQuery += ")";
            ODBCconnector.csFunciones.vInsertar(sQuery);
        }

        public void vModificarRegistro(ArrayList alCampos, ArrayList alDatos, int iCantCodigos)
        {
            string sQuery = "update " + sNombreTabla + " set ";
            bool bComa = false;
            for (int iPosicion = iCantCodigos; iPosicion < alDatos.Count; iPosicion++)
            {
                if (!bComa)
                {
                    bComa = true;
                }
                else
                {
                    sQuery += ",";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            sQuery += " where ";
            bool bAnd = false;
            for (int iPosicion = 0; iPosicion < iCantCodigos; iPosicion++)
            {
                if (!bAnd)
                {
                    bAnd = true;
                }
                else
                {
                    sQuery += " and ";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            ODBCconnector.csFunciones.vModificar(sQuery);
        }

        public void vEliminarRegistro(ArrayList alCampos, ArrayList alDatos, int iCantCodigos)
        {
            string sQuery = "update " + sNombreTabla + " set " + alCampos[alCampos.Count - 1].ToString() + "=0 where ";
            bool bAnd = false;
            for (int iPosicion = 0; iPosicion < iCantCodigos; iPosicion++)
            {
                if (!bAnd)
                {
                    bAnd = true;
                }
                else
                {
                    sQuery += " and ";
                }
                sQuery += alCampos[iPosicion].ToString() + "='" + alDatos[iPosicion].ToString() + "'";
            }
            ODBCconnector.csFunciones.vEliminar(sQuery);
        }   
    }
}
