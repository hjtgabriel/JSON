using System.ComponentModel;
using System.Text.Json;

namespace JSON
{
    public partial class Form1 : Form
    {
        // Ruta predeterminada para almacenar el archivo JSON
        private string ruta = @"C:\Users\DELL 5590\source\repos\JSON\estudiante.json";

        // Lista vinculante (BindingList) para mantener actualizados los datos en el DataGridView
        private BindingList<Estudiantes> estudiantes;
        public Form1()
        {
            InitializeComponent();
            estudiantes = new BindingList<Estudiantes>();
            dataGridView1.DataSource = estudiantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtCarnet.Text) ||
               string.IsNullOrWhiteSpace(txtnombre.Text) ||
               string.IsNullOrWhiteSpace(txtedad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que el carnet sea un número válido
            if (!int.TryParse(txtCarnet.Text, out int carnet))
            {
                MessageBox.Show("El número de carnet debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que la edad sea un número válido
            if (!int.TryParse(txtedad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea un nuevo objeto Estudiantes con los valores ingresados
            Estudiantes nuevoEstudiante = new Estudiantes
            {
                Carnet = carnet,
                Nombre = txtnombre.Text,
                Edad = edad
            };

            estudiantes.Add(nuevoEstudiante);
            GuardarEnJSON(estudiantes, ruta);
            LimpiarCampos();

            MessageBox.Show("Se guardó correctamente.");
        }
        
        //Metodo para limpiar campos de entrada
        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtnombre.Clear();
            txtedad.Clear();
        }
        // Metodo Guardar serializa la lista de estudiantes y la guarda en un archivo JSON.
        private void GuardarEnJSON(BindingList<Estudiantes> estudiantes, string ruta)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(estudiantes, opciones);// Serializa la lista en formato JSON
            File.WriteAllText(ruta, json);
        }
        //Metodo Leer, lee y deserializa una lista de estudiantes desde un archivo JSON.
        private BindingList<Estudiantes> LeerDesdeJSON(string ruta)
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta); // Lee el contenido del archivo JSON
                return JsonSerializer.Deserialize<BindingList<Estudiantes>>(json); // Deserializa el JSON a una lista
            }
            return new BindingList<Estudiantes>(); // Devuelve una lista vacía si el archivo no existe
        }

        //Metodo mostrar carga los datos del archivo JSON y los muestra en el DataGridView.
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                estudiantes = LeerDesdeJSON(ruta);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Metodo Eliminar, elimina el estudiante seleccionado de la lista y actualiza el archivo JSON.
        private void btnElimanar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                estudiantes.RemoveAt(index);
                GuardarEnJSON(estudiantes, ruta); // Guarda los cambios en JSON
                MessageBox.Show("Elemento eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
