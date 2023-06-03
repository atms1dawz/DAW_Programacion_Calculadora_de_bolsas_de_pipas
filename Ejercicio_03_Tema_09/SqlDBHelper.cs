using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Ejercicio_03_Tema_09
{
    public class SqlDBHelper
    {

        // MIEMBROS Y PROPIEDADES DE LA CLASE
        // Miembros para guardar el dataSet y el dataAdapter de las películas.
        private DataSet dsPeliculas;
        private SqlDataAdapter daPeliculas;

        // Miembro para guardar el número de peliculas.
        private int numPeliculas;
        // Propiedad de solo lectura.
        public int NumPeliculas { get => numPeliculas;}
        
        // Miembro que obtiene la lista de películas de una saga y duración
        private List<string> listPeliculas = new List<string>();

        // Propiedades de estos miembros
        public List<string> ListaPeliculas { get => listPeliculas;}



        // CONSTRUCTOR
        public SqlDBHelper()
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\angel\\OneDrive\\Documentos\\DAW - 2022-23\\00_Ejercicios_Programacion_1CFS\\Tema_09_Ejercicios\\Ejercicio_03_Tema_09\\BDPeliculas.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(cadenaConexion);

            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Peliculas";
            daPeliculas = new SqlDataAdapter(cadenaSQL, con);
            dsPeliculas = new DataSet();
            daPeliculas.Fill(dsPeliculas, "Peliculas");

            // Obtenemos el número de películas
            numPeliculas = dsPeliculas.Tables["Peliculas"].Rows.Count;

            // Cerramos la conexión.
            con.Close();

        }


        // Método que a partir de una posición en la BD devuelve un objeto película.
        // Devuelve null si pos está fuera de los límites
        public Pelicula devuelvePelicula(int pos)
        {
            Pelicula pelicula = null;
            if (pos >= 0 && pos < numPeliculas)
            {
                // Objeto que permite recoger un registro de la tabla.
                DataRow dRegistro;

                // Método que recoge el registro de la posición pos en la tabla Peliculas
                dRegistro = dsPeliculas.Tables["Peliculas"].Rows[pos];

                // Con el valor de cada una de las columnas del registro se crea el objeto película.
                pelicula = new Pelicula(dRegistro[1].ToString(), Convert.ToInt32(dRegistro[2]), dRegistro[3].ToString(),
                dRegistro[4].ToString());
            }
            return pelicula;
        }

        // A) MÉTODOS CRUD
        // Método que añade una película a la Base de Datos


        // a.1) añadir cursos

        public void anyadirPelicula(Pelicula pelicula)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dsPeliculas.Tables["Peliculas"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[1] = pelicula.Titulo;
            dRegistro[2] = pelicula.Duracion;
            dRegistro[3] = pelicula.Genero;
            dRegistro[4] = pelicula.Saga;


            // Añadimos el registro al Dataset
            dsPeliculas.Tables["Peliculas"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daPeliculas);

            daPeliculas.Update(dsPeliculas, "Peliculas");
            // Actualizamos el número de cursos
            numPeliculas++;
        }

        // a.2.) - actualizar peliculas

        public void actualizarPelicula(Pelicula pelicula, int pos)
        {
            reestablecerConexion();
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistroU = dsPeliculas.Tables["Peliculas"].Rows[pos];



                // Metemos los datos en el registro
            dRegistroU[1] = pelicula.Titulo;
            dRegistroU[2] = pelicula.Duracion;
            dRegistroU[3] = pelicula.Genero;
            dRegistroU[4] = pelicula.Saga;

            SqlCommandBuilder cb = new SqlCommandBuilder(daPeliculas);
            daPeliculas.Update(dsPeliculas, "Peliculas");
        }


        // a.3) - borrar cursos

        public void eliminarPelicula(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dsPeliculas.Tables["Peliculas"].Rows[pos].Delete();
            // Se descuenta la película
            numPeliculas--;
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daPeliculas);
            daPeliculas.Update(dsPeliculas, "Peliculas");
        }









        // MÉTODOS ESPECÍFICOS


        // B) MÉTODO QUE OBTIENE EL RESULTADO A MOSTRAR EN PANTALLA

        // SE LE PASA POR PARÁMETRO LA PROPIEDAD TXT DEL COMBOBOX, SI BIEN LA CONSULTA SQL
        // EVALÚA ESE VALOR CON LIKE EN VEZ DE = PARA QUE SEA MÁS FLEXIBLE

        public List<string> LaLista(string consulta) 
        {
            // VARIABLES PARA OPERAR Y RECOGER LOS RESULTADOS.

            List <string> ResultadoaEnviar = new List <string>();
            string listaDePeliculas = "";
            int duracionSaga = 0;
            int bolsasDePipas = 0;

            // OPERACIONES DE BASE DE DATOS
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\angel\\OneDrive\\Documentos\\DAW - 2022-23\\00_Ejercicios_Programacion_1CFS\\Tema_09_Ejercicios\\Ejercicio_03_Tema_09\\BDPeliculas.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();
            // CONSULTA SQL CON LA PROPIEDAD TXT DEL COMBOBOX
            string cadenaSQL = "SELECT * From Peliculas WHERE Saga LIKE '%" + consulta + "%'";
            daPeliculas = new SqlDataAdapter(cadenaSQL, con);
            dsPeliculas = new DataSet();
            daPeliculas.Fill(dsPeliculas, "Peliculas");

            // SE OBTIENEN LAS PELÍCULAS DE LA SAGA DETERMINADA
            numPeliculas = dsPeliculas.Tables["Peliculas"].Rows.Count;

            DataRow dRegistro;

            // SE RELLENA LA LISTA
            

            for (int i = 0; i < numPeliculas; i++)
            {
                dRegistro = dsPeliculas.Tables["Peliculas"].Rows[i];
                listaDePeliculas += dRegistro[1].ToString()+"\n";
                duracionSaga += (int)dRegistro[2];
            }

            ResultadoaEnviar.Add(listaDePeliculas);
            ResultadoaEnviar.Add("Duracion: " + duracionSaga.ToString() + " minutos");

            // Cálculo de la bolsa de pipas
            bolsasDePipas = duracionSaga / 60;
            ResultadoaEnviar.Add("Bolsas de pipas: " + bolsasDePipas.ToString());


            // Cerramos la conexión.
            con.Close();

            return ResultadoaEnviar;
        }

        

        // C) MÉTODO QUE RELLENA LOS COMBOBOX

        public List<string> RellenoCombos(int tipo)
        {
            List<string> rellenoGenero = new List<string>();
            string columna = "";

            if (tipo == 1)
            {
                columna = "Genero";
            } else { columna = "Saga"; }

            // OPERACIONES DE BASE DE DATOS
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\angel\\OneDrive\\Documentos\\DAW - 2022-23\\00_Ejercicios_Programacion_1CFS\\Tema_09_Ejercicios\\Ejercicio_03_Tema_09\\BDPeliculas.mdf\";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
            //SqlConnection con = new SqlConnection(cadenaConexion);
                // Abrimos la conexión.
                con.Open();
                // CONSULTA DISTINCT
                string cadenaSQLCombos = "SELECT DISTINCT " + columna + " FROM PELICULAS";
                SqlDataAdapter daPeliculasCombo = new SqlDataAdapter(cadenaSQLCombos, con);
                DataSet dsPeliculasCombo = new DataSet();
                daPeliculasCombo.Fill(dsPeliculasCombo, "Peliculas");

                // SE OBTIENEN LAS PELÍCULAS DE LA SAGA DETERMINADA
                int numPeliculasCombos = dsPeliculasCombo.Tables["Peliculas"].Rows.Count;

                DataRow dRegistroRelleno;

                // SE RELLENA LA LISTA


                for (int i = 0; i < numPeliculasCombos; i++)
                {
                    dRegistroRelleno = dsPeliculasCombo.Tables["Peliculas"].Rows[i];
                    rellenoGenero.Add(dRegistroRelleno[0].ToString());

                }



                // Cerramos la conexión.
                con.Close();

            }
            reestablecerConexion();
            return rellenoGenero;
        }


        public void reestablecerConexion()
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\angel\\OneDrive\\Documentos\\DAW - 2022-23\\00_Ejercicios_Programacion_1CFS\\Tema_09_Ejercicios\\Ejercicio_03_Tema_09\\BDPeliculas.mdf\";Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(cadenaConexion);

            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Peliculas";
            daPeliculas = new SqlDataAdapter(cadenaSQL, con);
            dsPeliculas = new DataSet();
            daPeliculas.Fill(dsPeliculas, "Peliculas");

            // Obtenemos el número de películas
            numPeliculas = dsPeliculas.Tables["Peliculas"].Rows.Count;

            // Cerramos la conexión.
            con.Close();
        }


    }
}
