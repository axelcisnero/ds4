using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmConvertidor : Form
    {
        private const double GALONES_A_LITROS = 3.785;
        private List<string> historial = new List<string>();

        public frmConvertidor()
        {
            InitializeComponent();
            btnGalLit.Click += btnGalLit_Click;
            btnLitGal.Click += btnLitGal_Click;
            btnRegistro.Click += btnRegistro_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnGalLit_Click(object sender, EventArgs e)
        {
            try
            {
                double galones = Convert.ToDouble(textBox1.Text);
                double litros = galones * GALONES_A_LITROS;
                textBox3.Text = litros.ToString("F2");

                string registro = $"{galones} galones = {litros:F2} litros";
                historial.Add(registro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para galones.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLitGal_Click(object sender, EventArgs e)
        {
            try
            {
                double litros = Convert.ToDouble(textBox2.Text);
                double galones = litros / GALONES_A_LITROS;
                textBox4.Text = galones.ToString("F2");

                string registro = $"{litros} litros = {galones:F2} galones";
                historial.Add(registro);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para litros.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            lbRegistro.Items.Clear();
            foreach (string registro in historial)
            {
                lbRegistro.Items.Add(registro);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            // No se limpia lbRegistro ni historial
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        
        }
    }
}