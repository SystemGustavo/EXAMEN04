using Examen04.Entidades;
using Examen04.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN04.PRESENTACION
{
    public partial class FrmRegion : Form
    {
        NRegion objNRegion = new NRegion();

        public FrmRegion()
        {
            InitializeComponent();
        }

        private void FrmRegion_Load(object sender, EventArgs e)
        {
            dgvRegion.DataSource = objNRegion.ListarRegiones();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                NRegion objNRegion = new NRegion();
                ERegion region = new ERegion();
                region.RegionName = txtRegionName.Text;
                region.Enabled = true;
                objNRegion.Registrar(region);
                MessageBox.Show("Registro Exitoso");
                dgvRegion.DataSource = objNRegion.ListarRegiones();
                Limpiar();

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                NRegion objNRegion = new NRegion();
                ERegion region = new ERegion();
                region.RegionId = Convert.ToInt32(txtRegionID.Text);
                region.RegionName = txtRegionName.Text;
                region.Enabled=true;
                objNRegion.Actualizar(region);
                MessageBox.Show("Actualizacion Exitoso");
                dgvRegion.DataSource = objNRegion.ListarRegiones();
                Limpiar();

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                NRegion objNRegion = new NRegion();

                int RegionId = Convert.ToInt32(txtRegionID.Text);

                objNRegion.Eliminar(RegionId);
                MessageBox.Show("Eliminacion Exitoso");
                dgvRegion.DataSource = objNRegion.ListarRegiones();
                Limpiar();

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
        }

        private void dgvRegion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegionID.Text = dgvRegion.CurrentRow.Cells[0].Value.ToString();
            txtRegionName.Text = dgvRegion.CurrentRow.Cells[1].Value.ToString();
        }

        public void Limpiar()
        {
            txtRegionID.Text = string.Empty;
            txtRegionName.Text = string.Empty;
        }
    }
}
