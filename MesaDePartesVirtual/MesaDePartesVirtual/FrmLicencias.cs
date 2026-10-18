
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

        //indice para selección de fila
        int indiceSeleccionado = 0;

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
            
            // Validación de Ruc Duplicado
            for (int i = 0; i < totalExpedientes; i++)
            {
                if (rucs[i] == rucIn)
                {
                    MessageBox.Show($"El RUC {rucIn} ya cuenta con un expediente en trámite activo. No se permiten duplicados.",
                                    "Expediente Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRuc.Focus();
                    return;
                }
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

        //Seleccionar fila de la tabla
        private void dgvExpedientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < totalExpedientes)
            {
                indiceSeleccionado = e.RowIndex;
            }
        }

        //Eliminar fila seleccionada
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado < 0)
            {
                MessageBox.Show("Por favor, seleccione un expediente de la tabla haciendo clic sobre él.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea anular el expediente de la empresa: {nombres[indiceSeleccionado]}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                for (int i = indiceSeleccionado; i < totalExpedientes - 1; i++)
                {
                    rucs[i] = rucs[i + 1];
                    nombres[i] = nombres[i + 1];
                    giros[i] = giros[i + 1];
                    areas[i] = areas[i + 1];
                }

                totalExpedientes--;
                indiceSeleccionado = -1; 

                ActualizarCuadricula();

                MessageBox.Show("El expediente ha sido eliminado exitosamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Cargar "Base de datos" de prueba
        private void btnCargarPrueba_Click(object sender, EventArgs e)
        {
            if (totalExpedientes > 0)
            {
                DialogResult r = MessageBox.Show("Ya hay expedientes registrados. ¿Desea sobrescribir la memoria con la base de datos de prueba?", "Confirmar Carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No) return;
            }

            rucs[0] = "10456789123"; nombres[0] = "Bodega Don Pepe"; giros[0] = "Bodega"; areas[0] = 45.50;
            rucs[1] = "20765432199"; nombres[1] = "Ferretería El Chalaco"; giros[1] = "Ferretería"; areas[1] = 120.00;
            rucs[2] = "10987654321"; nombres[2] = "Peluquería Bella"; giros[2] = "Servicios"; areas[2] = 25.00;
            rucs[3] = "20123456789"; nombres[3] = "Restaurante El Pez"; giros[3] = "Restaurante"; areas[3] = 85.75;
            rucs[4] = "10111222333"; nombres[4] = "Farmacia Salud"; giros[4] = "Farmacia"; areas[4] = 60.20;
            rucs[5] = "20555666777"; nombres[5] = "Minimarket Los Andes"; giros[5] = "Bodega"; areas[5] = 90.00;
            rucs[6] = "10444333222"; nombres[6] = "Cevichería El Puerto"; giros[6] = "Restaurante"; areas[6] = 150.00;
            rucs[7] = "20999888777"; nombres[7] = "Librería Estudiantil"; giros[7] = "Comercio"; areas[7] = 35.00;
            rucs[8] = "10121212121"; nombres[8] = "Panadería El Trigo"; giros[8] = "Panadería"; areas[8] = 70.00;
            rucs[9] = "20343434343"; nombres[9] = "Botica San Juan"; giros[9] = "Farmacia"; areas[9] = 55.00;
            rucs[10] = "10565656565"; nombres[10] = "Vidriería Clara"; giros[10] = "Ferretería"; areas[10] = 40.00;
            rucs[11] = "20787878787"; nombres[11] = "Pollería El Buen Sabor"; giros[11] = "Restaurante"; areas[11] = 200.00;
            rucs[12] = "10909090909"; nombres[12] = "Bazar La Esquina"; giros[12] = "Comercio"; areas[12] = 20.00;
            rucs[13] = "20212223242"; nombres[13] = "Centro Odontológico"; giros[13] = "Servicios"; areas[13] = 65.00;
            rucs[14] = "10515253545"; nombres[14] = "Spa Relax"; giros[14] = "Servicios"; areas[14] = 80.00;

            totalExpedientes = 15;
            ActualizarCuadricula();

            MessageBox.Show("Base de datos de prueba (15 registros) cargada exitosamente.", "Carga Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
