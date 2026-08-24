using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor complete los campos de Nombre y Edad.", "Campos incompletos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la edad sea un número entero válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Por favor ingrese una edad válida (número entero).", "Error de formato",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación con los datos ingresados
            string mensaje = $"Estudiante guardado exitosamente:\n\nNombre: {txtNombre.Text}\nEdad: {edad}";
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar las cajas de texto automáticamente después de guardar
            txtNombre.Clear();
            txtEdad.Clear();
            txtNombre.Focus();
        
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();

            // Regresa el cursor a la caja de Nombre para seguir digitando
            txtNombre.Focus();
        
    }
    }
}
