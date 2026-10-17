
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesaDePartesVirtual
{
    public partial class FrmLicencias : Form
    {
        const int CantidadMax = 100;

        string[] rucs = new string[CantidadMax];
        string[] nombres = new string[CantidadMax];
        string[] giros = new string[CantidadMax];
        double[] areas = new double[CantidadMax];

        int totalExpedientes = 0;

        public FrmLicencias()
        {
            InitializeComponent();

            // AGREGADO: mostrar el contador al abrir el formulario
            lblTotalRegistrados.Text = "Total Registrados: 0";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string rucIn = txtRuc.Text.Trim();
            string nombreIn = txtNombreComercial.Text.Trim();
            string giroIn = cboGiro.Text;
            string areaTexto = txtArea.Text.Trim();

            // Validar longitud del RUC
            if (rucIn.Length != 11)
            {
                MessageBox.Show("El RUC debe tener exactamente 11 digitos",
                    "Error de Validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtRuc.Focus();
                return;
            }

            // Validar inicio del RUC
            if (!rucIn.StartsWith("10") && !rucIn.StartsWith("20"))
            {
                MessageBox.Show("El RUC debe iniciar con '10' (Persona Natural) o '20' (Persona Jurídica)",
                    "Error de Validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtRuc.Focus();
                return;
            }

            // Validar nombre y giro
            if (string.IsNullOrEmpty(nombreIn) ||
                string.IsNullOrEmpty(giroIn))
            {
                MessageBox.Show("Debe ingresar el Nombre Comercial y seleccionar un Giro.",
                    "Datos Incompletos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar área
            double areaIn;

            if (!double.TryParse(areaTexto, out areaIn) || areaIn <= 0)
            {
                MessageBox.Show("Ingrese un valor de área válido y mayor a cero.",
                    "Error de Validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtArea.Focus();
                return;
            }

            // Validar límite máximo
            if (totalExpedientes >= CantidadMax)
            {
                MessageBox.Show("Se ha alcanzado el límite máximo de expedientes.",
                    "Límite Alcanzado", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Guardar expediente en memoria
            rucs[totalExpedientes] = rucIn;
            nombres[totalExpedientes] = nombreIn;
            giros[totalExpedientes] = giroIn;
            areas[totalExpedientes] = areaIn;

            totalExpedientes++;

            ActualizarCuadricula();
            LimpiarFormulario();

            MessageBox.Show("Expediente registrado con éxito en la memoria.",
                "Registro Completo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ActualizarCuadricula()
        {
            dgvExpedientes.Rows.Clear();

            double mayorArea = 0;

            for (int i = 0; i < totalExpedientes; i++)
            {
                dgvExpedientes.Rows.Add(
                    rucs[i],
                    nombres[i],
                    giros[i],
                    areas[i].ToString("N2")
                );

                if (areas[i] > mayorArea)
                {
                    mayorArea = areas[i];
                }
            }

            // CONTADOR: mostrar la cantidad actual de expedientes
            lblTotalRegistrados.Text =
                "Total Registrados: " + totalExpedientes;

            lblMayorArea.Text =
                "Mayor Área: " + mayorArea.ToString("N2") + " m²";
        }

        private void LimpiarFormulario()
        {
            txtRuc.Clear();
            txtNombreComercial.Clear();
            cboGiro.SelectedIndex = -1;
            txtArea.Clear();
            txtRuc.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalRegistrados_Click(object sender, EventArgs e)
        {
        }
    }
}
