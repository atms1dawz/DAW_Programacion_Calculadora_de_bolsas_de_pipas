using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_03_Tema_09
{
    public partial class Form1_Ejercicio_03_Tema_09 : Form
    {

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;

        // Variable que indica en el registro actual.
        private int pos;

        public Form1_Ejercicio_03_Tema_09()
        {
            InitializeComponent();
        }

        private void Form1_Ejercicio_03_Tema_09_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();

            // Se comprueba que la tabla tiene registros.
            // Si no tiene registros, bloquea todos los botones salvo los de añadir un registro
            // en caso contrario, el funcionamiento es normal
            if (sqlDBHelper.NumPeliculas <= 0)
            {
                bloquearBotones(true);
            }
            else
            {
                bloquearBotones(false);
                pos = 0;
                mostrarRegistro(pos);
                control();
                RellenoCombos();
            }

            // Labels de salia

            lblResultado.Text = "Resultado total en minutos.\nUna bolsa de pipas cada 60 minutos.";
            lblListaPeliculas.Text = "Selecciona una saga existente\nde la lista de arriba\n\nNavega, edita y añade películas\nen el panel de la izquierda.\n\nAbajo obtendrás el resultado.";
           
        }



        // Botones del grupo Navegar
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            mostrarRegistro(pos);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            mostrarRegistro(pos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            mostrarRegistro(pos);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pos = ((sqlDBHelper.NumPeliculas) - 1);
            mostrarRegistro(pos);
        }



        // Botones del grupo Nuevo registro

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            RellenoCombos();
            txtTitulo.Clear();
            txtDuracion.Clear();
            cmbGenero.Text = "";
            cmbSaga.Text = "";
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            // Creamos el alumno con los datos del formulario
            int loquedura = LaDuracionEsUnNumero();
            Pelicula pelicula = new Pelicula(txtTitulo.Text, loquedura, cmbGenero.Text, cmbSaga.Text);
            sqlDBHelper.anyadirPelicula(pelicula);

            // Actualizamos la posición
            pos = sqlDBHelper.NumPeliculas - 1;
            bloquearBotones(false); // al haber un registro devuelve la funcionalidad a los botones
            mostrarRegistro(pos);
            RellenoCombos();
        }


        // Botones del grupo Actualizar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Bloque condicional para preguntar al usuario si está seguro de completar su acción
            DialogResult result = MessageBox.Show("Confirme la acción", "Esta acción no puede deshacerse", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Pelicula pelicula = new Pelicula(txtTitulo.Text, int.Parse(txtDuracion.Text), cmbGenero.Text, cmbSaga.Text);
                sqlDBHelper.actualizarPelicula(pelicula, pos);
                mostrarRegistro(pos);
                RellenoCombos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Bloque condicional para preguntar al usuario si está seguro de completar su acción
            DialogResult result = MessageBox.Show("Confirme la acción", "Esta acción no puede deshacerse", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                sqlDBHelper.eliminarPelicula(pos);
                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);
                RellenoCombos();
            }

            // Este código se encarga de modificar el flujo si se ha eliminado el último registro
            if (sqlDBHelper.NumPeliculas <= 0)
            {
                bloquearBotones(true);
            }
            else
            {
                bloquearBotones(false);
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        // Subprograma que muestra el registro situado en la posición pos
        private void mostrarRegistro(int pos)
        {
            Pelicula pelicula;
            pelicula = sqlDBHelper.devuelvePelicula(pos);
            RellenoCombos();

            // Primero comprobamos que hay registros
            if (sqlDBHelper.NumPeliculas <= 0)
            {
                bloquearBotones(true);

            }
            else
            {
                // Ahora sí se pueden poner los valores en los textBox y combos correspondientes

                txtTitulo.Text = pelicula.Titulo;
                txtDuracion.Text = pelicula.Duracion.ToString();
                cmbGenero.Text = pelicula.Genero;
                cmbSaga.Text = pelicula.Saga;
                lblInfo.Text = "Posición actual: " + (pos + 1).ToString() + "/ Total: " + sqlDBHelper.NumPeliculas.ToString() + " películas.";
                control();
            }

        }


        private void RellenoCombos()
        {
            cmbGenero.Items.Clear();
            cmbSaga.Items.Clear();
            cmbEligeSaga.Items.Clear();

            List<string> ResultadoGenero = new List<string>();
            ResultadoGenero.AddRange(sqlDBHelper.RellenoCombos(1));

            for (int i  = 0; i < ResultadoGenero.Count; i++)
            {
                cmbGenero.Items.Add(ResultadoGenero[i].ToString());
            }

            List<string> ResultadoSaga = new List<string>();
            ResultadoSaga.AddRange(sqlDBHelper.RellenoCombos(2));

            for (int i = 0; i < ResultadoSaga.Count; i++)
            {
                cmbSaga.Items.Add(ResultadoSaga[i].ToString());
            }

            List<string> ResultadoEligeSaga = new List<string>();
            ResultadoEligeSaga.AddRange(sqlDBHelper.RellenoCombos(3));

            for (int i = 0; i < ResultadoEligeSaga.Count; i++)
            {
                cmbEligeSaga.Items.Add(ResultadoEligeSaga[i].ToString());
            }

        }

        private void cmbEligeSaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Resultado = new List<string>();
            Resultado.AddRange(sqlDBHelper.LaLista(cmbEligeSaga.Text));
            lblListaPeliculas.Text = Resultado[0];
            lblResultado.Text = Resultado[1] + "\n" + Resultado[2];
        }





        // Funcion para habilitar o deshabilitar los botones en función de si hay un registro anterior o posterior
        private void control()
        {
            
            lblInfo.Text = "Posición actual: " + (pos + 1).ToString() +
                "/ Total: " + sqlDBHelper.NumPeliculas.ToString() + " películas.";

            if (pos == (sqlDBHelper.NumPeliculas) - 1)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
            if (pos == 0)
            {
                btnAnterior.Enabled = false;
            }
            else
            {
                btnAnterior.Enabled = true;
            }
        }

        // Funcion para bloquear los botones correspondientes si la tabla se queda sin registros
        public void bloquearBotones(bool tipo)
        {
            if (tipo == true)
            {
                lblInfo .Text = "No hay registros aún.\nIntroduzca registros para operar.";
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnPrimero.Enabled = true;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }


        public int LaDuracionEsUnNumero()
        {
            string duracionIntroducida = txtDuracion.Text;
            int numero;

            if (int.TryParse(duracionIntroducida, out numero))
            {
                return numero;
            }
            else
            {
                lblInfo.Text = "La duración debe ser un valor numérico";
                return 0;
            }

        }

    }
}
