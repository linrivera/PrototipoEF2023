/* Autor: Anthony Molineros,Jennifer López
 * Fecha: 17/10/2014 - 19/10/2014 
 * Comentario: Capa de presentación modulo Hoteleria Hotel San Carlos
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
    public partial class wfReservacion : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsDetalleReservacion = new BindingSource();
        DataTable dtDetalleReservacion = new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable dtAmbientes = new DataTable();
        BindingSource bsAmbientes = new BindingSource();
        private string sCod_rsva = string.Empty;
        private bool bModificarRegistro = false;
        private string sCodigo = string.Empty;
        private bool bCheckIn = false;
        private bool bCheckOut = false;

        public string SCod_rsva
        {
            get { return sCod_rsva; }
            set { sCod_rsva = value; }
        }


        public wfReservacion()
        {
            InitializeComponent();
        }
        
        private void wfReservacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_rsva);
            alDatosEnviados.Add(txtCod_cte);
            alDatosEnviados.Add(txtFechres_rsva);
            alDatosEnviados.Add(txtFechent_rsva);
            alDatosEnviados.Add(txtFechsal_rsva);           
            alDatosEnviados.Add(txtAdultos_rsva);
            alDatosEnviados.Add(txtNinos_rsva);
            alDatosEnviados.Add(txtDias_rsva);
            alDatosEnviados.Add(txtTotal_rsva);
            alDatosEnviados.Add(txtConfent_rsva);
            alDatosEnviados.Add(txtConfsal_rsva);
            alDatosEnviados.Add(txtEstado_rsva);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
            bsDetalleReservacion.DataSource = dtDetalleReservacion;
            dgvDetalleReservacion.DataSource = bsDetalleReservacion;
        }
        
        private void dtpFechres_rsva_ValueChanged(object sender, EventArgs e)
        {
            txtFechres_rsva.Text = dtpFechres_rsva.Text;
        }

        private void txtFechres_rsva_TextChanged(object sender, EventArgs e)
        {
            dtpFechres_rsva.Text = txtFechres_rsva.Text;
        }

        private void dtpFechent_rsva_ValueChanged(object sender, EventArgs e)
        {
            txtFechent_rsva.Text = dtpFechent_rsva.Text;
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
        }

        private void txtFechent_rsva_TextChanged(object sender, EventArgs e)
        {
            dtpFechent_rsva.Text = txtFechent_rsva.Text;
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
        }

        private void dtpFechsal_rsva_ValueChanged(object sender, EventArgs e)
        {
            txtFechsal_rsva.Text = dtpFechsal_rsva.Text;
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
        }

        private void txtFechsal_rsva_TextChanged(object sender, EventArgs e)
        {
            dtpFechsal_rsva.Text = txtFechsal_rsva.Text;
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
        }

        private void cboConfent_rsva_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboConfent_rsva.SelectedIndex)
            {
                case 0: txtConfent_rsva.Text = "1"; break;
                case 1: txtConfent_rsva.Text = "0"; break;
                default: txtConfent_rsva.Text = string.Empty; break;
            }
        }

        private void txtConfent_rsva_TextChanged(object sender, EventArgs e)
        {
            switch (txtConfent_rsva.Text)
            {
                case "1": cboConfent_rsva.SelectedIndex = 0; break;
                case "0": cboConfent_rsva.SelectedIndex = 1; break;
                default: cboConfent_rsva.SelectedIndex = -1; break;
            }
        }

        private void cboConfsal_rsva_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboConfsal_rsva.SelectedIndex)
            {
                case 0: txtConfsal_rsva.Text = "1"; break;
                case 1: txtConfsal_rsva.Text = "0"; break;
                default: txtConfsal_rsva.Text = string.Empty; break;
            }        
        }

        private void txtConfsal_rsva_TextChanged(object sender, EventArgs e)
        {
            switch (txtConfsal_rsva.Text)
            {
                case "1": cboConfsal_rsva.SelectedIndex = 0; break;
                case "0": cboConfsal_rsva.SelectedIndex = 1; break;
                default: cboConfsal_rsva.SelectedIndex = -1; break;
            }        
        }

        private void txtCod_rsva_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_rsva.Enabled = false;
        }

        private void txtFechres_rsva_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechres_rsva.Enabled = txtFechres_rsva.Enabled;
        }

        private void txtFechent_rsva_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechent_rsva.Enabled = txtFechent_rsva.Enabled;
        }

        private void txtFechsal_rsva_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechsal_rsva.Enabled = txtFechsal_rsva.Enabled;
            dgvDetalleReservacion.Enabled = txtFechsal_rsva.Enabled;
            cboCodigos.Enabled = txtFechsal_rsva.Enabled;
            btnBuscarAmbientes.Enabled = txtFechsal_rsva.Enabled;
            btnAgregar.Enabled = txtFechsal_rsva.Enabled;
        }

        private void txtConfent_rsva_EnabledChanged(object sender, EventArgs e)
        {
            if (cboConfent_rsva.SelectedIndex == 1)
            {
                cboConfent_rsva.Enabled = txtConfent_rsva.Enabled;
            }
            else
            {
                cboConfent_rsva.Enabled = false;
            }
        }

        private void txtConfsal_rsva_EnabledChanged(object sender, EventArgs e)
        {
            if (cboConfsal_rsva.SelectedIndex == 1)
            {
                cboConfsal_rsva.Enabled = txtConfsal_rsva.Enabled;
            }
            else
            {
                cboConfsal_rsva.Enabled = false;
            }
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_rsva.Text = sCodigo;
            txtFechres_rsva.Text = dtpFechres_rsva.Text;
            txtFechent_rsva.Text = dtpFechent_rsva.Text;
            txtFechsal_rsva.Text = dtpFechsal_rsva.Text;
            cboConfent_rsva.SelectedIndex = 1;
            cboConfsal_rsva.SelectedIndex = 1;
            cboEstado_rsva.SelectedIndex = 0;
            dtpFechsal_rsva.Value = dtpFechent_rsva.Value.AddDays(1);
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
            vLlenarDgvDetalleReservacion();
            cboCodigos.DataSource = null;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtFechres_rsva.Text = dtpFechres_rsva.Text;
            txtFechent_rsva.Text = dtpFechent_rsva.Text;
            txtFechsal_rsva.Text = dtpFechsal_rsva.Text;
            cboConfent_rsva.SelectedIndex = 1;
            cboConfsal_rsva.SelectedIndex = 1;
            cboEstado_rsva.SelectedIndex = 0;
            dtpFechsal_rsva.Value = dtpFechent_rsva.Value.AddDays(1);
            txtDias_rsva.Text = (dtpFechsal_rsva.Value - dtpFechent_rsva.Value).Days.ToString();
            vLlenarDgvDetalleReservacion();
            cboCodigos.DataSource = null;
        }

        private void txtAdultos_rsva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtNinos_rsva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtDias_rsva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtTotal_rsva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCod_cte_Enter(object sender, EventArgs e)
        {
            wfCliente Clientes = new wfCliente();
            Clientes.ShowDialog();
            txtCod_cte.Text = Clientes.SCod_cte;
        }

        private void txtCod_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtDias_rsva_EnabledChanged(object sender, EventArgs e)
        {
            txtDias_rsva.Enabled = false;
        }

        private void txtTotal_rsva_EnabledChanged(object sender, EventArgs e)
        {
            txtTotal_rsva.Enabled = false;
        }

        private void btnBuscarAmbientes_Click(object sender, EventArgs e)
        {
            dtAmbientes = Negocio.dtConsultarRegistros("select distinct b.cod_amb, concat(b.cod_amb,'-',a.ambiente_tamb), b.precio_amb from tabm_fetambiente a, tabm_feambiente b, tabt_fedrsva c, tabm_fereservacion d where a.cod_tamb=b.cod_tamb and b.cod_amb=c.cod_amb and c.cod_rsva=d.cod_rsva and d.fechsal_rsva < '" + dtpFechent_rsva.Text + "' and b.estado_amb=1 union select distinct b.cod_amb, concat(b.cod_amb,'-',a.ambiente_tamb), b.precio_amb from  tabm_fetambiente a, tabm_feambiente b where a.cod_tamb=b.cod_tamb and b.cod_amb not in (select cod_amb from tabt_fedrsva)");
            if (dtAmbientes.Rows.Count != 0)
            {
                dtAmbientes.Columns[0].ColumnName = "Codigo";
                dtAmbientes.Columns[1].ColumnName = "Ambiente";
                dtAmbientes.Columns[2].ColumnName = "Precio";
                bsAmbientes.DataSource = dtAmbientes;
                cboCodigos.DataSource = bsAmbientes;
                cboCodigos.DisplayMember = "Ambiente";
                cboCodigos.ValueMember = "Codigo";
                cboCodigos.SelectedIndex = -1;
                cboCodigos.SelectedIndex = 0;
            }
        }

        private void vLlenarDgvDetalleReservacion()
        {
            dtDetalleReservacion = Negocio.dtConsultarRegistros("select * from tabt_fedrsva where cod_rsva = '" + txtCod_rsva.Text + "'");
            if (dtDetalleReservacion.Rows.Count != 0)
            {
                dtDetalleReservacion.Columns.RemoveAt(0);
                dtDetalleReservacion.Columns[0].ColumnName = "Código";
                dtDetalleReservacion.Columns[1].ColumnName = "Días";
                dtDetalleReservacion.Columns[2].ColumnName = "Total";
                dtDetalleReservacion.Columns[3].ColumnName = "Estado";
            }
            else
            {
                dtDetalleReservacion.Columns.Add("Código");
                dtDetalleReservacion.Columns.Add("Días");
                dtDetalleReservacion.Columns.Add("Total");
                dtDetalleReservacion.Columns.Add("Estado");
            }
            bsDetalleReservacion.DataSource = dtDetalleReservacion;
            dgvDetalleReservacion.DataSource = bsDetalleReservacion;
        }

        private void txtCod_rsva_TextChanged(object sender, EventArgs e)
        {
            SCod_rsva = txtCod_rsva.Text;
            vLlenarDgvDetalleReservacion();
            bCheckIn = false;
            bCheckOut = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtDetalleReservacion.Rows.Add(cboCodigos.SelectedValue, txtDias_rsva.Text, txtTotalAmbiente.Text,"1");
            dgvDetalleReservacion.Refresh();
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtDetalleReservacion;
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
            else
            {
                if (dtDetalleReservacion.Rows.Count == 0)
                {
                    MessageBox.Show("Seleccione los ambientes deseados.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    navegador1.bEjecutarEvento = false;
                } 
                else
                {
                    if ((cboConfent_rsva.SelectedIndex == 0) && (cboConfent_rsva.Enabled == true))
                    {
                        bCheckIn = true;
                    }
                    if ((cboConfsal_rsva.SelectedIndex == 0) && (cboConfsal_rsva.Enabled == true))
                    {
                        bCheckOut = true;
                    }
                }
            }
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarDgvDetalleReservacion();
            dgvDetalleReservacion.ReadOnly = false;
            dgvDetalleReservacion.AllowUserToDeleteRows = false;
            dgvDetalleReservacion.Columns[0].ReadOnly = true;
            dgvDetalleReservacion.Columns[1].ReadOnly = false;
            dgvDetalleReservacion.Columns[2].ReadOnly = false;
            dgvDetalleReservacion.Columns[3].ReadOnly = false;
            vLlenarDgvDetalleReservacion();
            btnBuscarAmbientes.Enabled = false;
            cboCodigos.Enabled = false;
            txtTotalAmbiente.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void cboCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigos.SelectedIndex != -1)
            {
                float fPrecio = 0;
                foreach (DataRow drFila in dtAmbientes.Rows)
                {
                    if (string.Compare(cboCodigos.SelectedValue.ToString(), drFila[0].ToString()) == 0)
                    {
                        fPrecio = Convert.ToSingle(drFila[2].ToString());
                    }
                }
                float fTotal = fPrecio * Convert.ToSingle(txtDias_rsva.Text);
                txtTotalAmbiente.Text = fTotal.ToString();
            }
            else
            {
                txtTotalAmbiente.Text = string.Empty;
            }
        }
        
        private void dgvDetalleReservacion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            float fTotalReservacion = 0;
            for (int iPosicion = 0; iPosicion < dgvDetalleReservacion.Rows.Count; iPosicion++)
            {
                fTotalReservacion += Convert.ToSingle(dgvDetalleReservacion.Rows[iPosicion].Cells[2].Value);
            }
            txtTotal_rsva.Text = fTotalReservacion.ToString();
        }

        private void dgvDetalleReservacion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float fTotalReservacion = 0;
            for (int iPosicion = 0; iPosicion < dgvDetalleReservacion.Rows.Count; iPosicion++)
            {
                fTotalReservacion += Convert.ToSingle(dgvDetalleReservacion.Rows[iPosicion].Cells[2].Value);
            }
            txtTotal_rsva.Text = fTotalReservacion.ToString();
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_rsva.Text);
            Negocio.SNombreTabla = "tabt_fedrsva";
            if (bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvDetalleReservacion();
            if (bCheckIn == true)
            {
                bCheckIn = false;
                wfFolioCliente FolioCliente = new wfFolioCliente();
                FolioCliente.ShowDialog();
            }
            if (bCheckOut == true)
            {
                bCheckOut = false;
                Facturacion.wfFactura Factura = new Facturacion.wfFactura();
                Factura.ShowDialog();
            }
        }

        private void cboEstado_rsva_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_rsva.SelectedIndex)
            {
                case 0: txtEstado_rsva.Text = "1"; break;
                case 1: txtEstado_rsva.Text = "0"; break;
                default: txtEstado_rsva.Text = string.Empty; break;
            }
        }

        private void txtEstado_rsva_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_rsva.Text)
            {
                case "1": cboEstado_rsva.SelectedIndex = 0; break;
                case "0": cboEstado_rsva.SelectedIndex = 1; break;
                default: cboEstado_rsva.SelectedIndex = -1; break;
            }
        }

        private void txtEstado_rsva_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_rsva.Enabled = txtEstado_rsva.Enabled;
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            Negocio.SNombreTabla = "tabt_fedrsva";
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_rsva.Text);
            Negocio.vEliminarRegistros(alCodigos, dtDetalleReservacion);
            vLlenarDgvDetalleReservacion(); 
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_rsva.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Reservaciones";
            Reporteador.ShowDialog();
        }
    }
}
