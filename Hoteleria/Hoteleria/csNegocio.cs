/* Autor: Andrea Perez, Marlon Aldana
 * Fecha: 21/10/2014 - 23/10/2014 
 * Comentario: Capa de datos modulo Hoteleria Hotel San Carlos
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Hoteleria
{
    class csNegocio
    {
        csDatos Datos = new csDatos();
        csEntidades Entidades = new csEntidades();
        private string sNombreTabla = string.Empty;

        public string SNombreTabla
        {
            get { return sNombreTabla; }
            set { sNombreTabla = value; }
        }

        public void vValidarTexto(KeyPressEventArgs e, string sCadena)
        {
            sCadena = sCadena + (char)8;
            if (!sCadena.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public bool bValidarTextBoxes(ArrayList alDatosEntrada)
        {
            for (int iPosicion = 1; iPosicion < alDatosEntrada.Count; iPosicion++)
            {
                TextBox txtTextBoxes = (TextBox)alDatosEntrada[iPosicion];
                if (string.Compare(txtTextBoxes.Text, string.Empty) == 0)
                {
                    MessageBox.Show("Ingrese todos los campos.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTextBoxes.Focus();
                    return false;
                }
            }
            return true;
        }

        public void vInsertarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Datos.SNombreTabla = SNombreTabla;
                Datos.vInsertarRegistro(alFila);
            }
        }

        public DataTable dtConsultarRegistros(string sQuery)
        {
            DataTable dtDatosSalida = new DataTable();
            ArrayList alDatosEntrada = new ArrayList();
            if (sQuery != null)
            {
                alDatosEntrada = Datos.alConsultarRegistro(sQuery);
                if (alDatosEntrada != null)
                {
                    if (alDatosEntrada.Count != 0)
                    {
                        ArrayList alColumnas = (ArrayList)alDatosEntrada[0];
                        for (int iPosicion = 0; iPosicion < alColumnas.Count; iPosicion++)
                        {
                            dtDatosSalida.Columns.Add("Columna" + iPosicion);
                        }
                        if (alDatosEntrada != null)
                        {
                            foreach (ArrayList alFilas in alDatosEntrada)
                            {
                                DataRow drFila = dtDatosSalida.NewRow();
                                for (int iPosicion = 0; iPosicion < alFilas.Count; iPosicion++)
                                {
                                    drFila["Columna" + iPosicion] = alFilas[iPosicion];
                                }
                                dtDatosSalida.Rows.Add(drFila);
                            }
                        }
                    }
                }
            }
            return dtDatosSalida;
        }

        public void vModificarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();
            int iCantCodigos = alCodigos.Count + 1;
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Entidades.SNombreTabla = SNombreTabla;
                ArrayList alCampos = Entidades.alObtenerCamposTabla();
                Datos.SNombreTabla = SNombreTabla;
                Datos.vModificarRegistro(alCampos, alFila, iCantCodigos);
            }
        }

        public void vEliminarRegistros(ArrayList alCodigos, DataTable dtDatos)
        {
            ArrayList alFila = new ArrayList();
            int iCantCodigos = alCodigos.Count + 1;
            for (int iContadorFila = 0; iContadorFila < dtDatos.Rows.Count; iContadorFila++)
            {
                alFila.Clear();
                foreach (string sCodigo in alCodigos)
                {
                    alFila.Add(sCodigo);
                }
                for (int iContadorColum = 0; iContadorColum < dtDatos.Columns.Count; iContadorColum++)
                {
                    alFila.Add(dtDatos.Rows[iContadorFila][iContadorColum].ToString());
                }
                Entidades.SNombreTabla = SNombreTabla;
                ArrayList alCampos = Entidades.alObtenerCamposTabla();
                Datos.SNombreTabla = SNombreTabla;
                Datos.vEliminarRegistro(alCampos, alFila, iCantCodigos);
            }
        }
    }
}
