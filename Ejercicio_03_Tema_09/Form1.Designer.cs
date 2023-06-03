namespace Ejercicio_03_Tema_09
{
    partial class Form1_Ejercicio_03_Tema_09
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lblPeliculaTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cmbSaga = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblTituloMinutos = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblPeliculaSaga = new System.Windows.Forms.Label();
            this.lblPeliculaGenero = new System.Windows.Forms.Label();
            this.lblPeliculaDuracion = new System.Windows.Forms.Label();
            this.grpNavegar = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.grpEditar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lblListaPeliculas = new System.Windows.Forms.Label();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.cmbEligeSaga = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.grpNavegar.SuspendLayout();
            this.grpNuevo.SuspendLayout();
            this.grpEditar.SuspendLayout();
            this.grpListado.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(28, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(494, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestor de maratones de películas";
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPrimero.ForeColor = System.Drawing.Color.Black;
            this.btnPrimero.Location = new System.Drawing.Point(11, 33);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(125, 43);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // lblPeliculaTitulo
            // 
            this.lblPeliculaTitulo.AutoSize = true;
            this.lblPeliculaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaTitulo.Location = new System.Drawing.Point(16, 46);
            this.lblPeliculaTitulo.Name = "lblPeliculaTitulo";
            this.lblPeliculaTitulo.Size = new System.Drawing.Size(82, 32);
            this.lblPeliculaTitulo.TabIndex = 0;
            this.lblPeliculaTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(104, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(424, 34);
            this.txtTitulo.TabIndex = 1;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cmbSaga);
            this.grpDatos.Controls.Add(this.cmbGenero);
            this.grpDatos.Controls.Add(this.lblTituloMinutos);
            this.grpDatos.Controls.Add(this.txtDuracion);
            this.grpDatos.Controls.Add(this.lblPeliculaSaga);
            this.grpDatos.Controls.Add(this.lblPeliculaGenero);
            this.grpDatos.Controls.Add(this.lblPeliculaDuracion);
            this.grpDatos.Controls.Add(this.lblPeliculaTitulo);
            this.grpDatos.Controls.Add(this.txtTitulo);
            this.grpDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(36, 66);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(549, 235);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Película:";
            // 
            // cmbSaga
            // 
            this.cmbSaga.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSaga.FormattingEnabled = true;
            this.cmbSaga.Location = new System.Drawing.Point(142, 185);
            this.cmbSaga.Name = "cmbSaga";
            this.cmbSaga.Size = new System.Drawing.Size(386, 36);
            this.cmbSaga.TabIndex = 4;
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(142, 134);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(386, 36);
            this.cmbGenero.TabIndex = 3;
            // 
            // lblTituloMinutos
            // 
            this.lblTituloMinutos.AutoSize = true;
            this.lblTituloMinutos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMinutos.Location = new System.Drawing.Point(282, 91);
            this.lblTituloMinutos.Name = "lblTituloMinutos";
            this.lblTituloMinutos.Size = new System.Drawing.Size(134, 32);
            this.lblTituloMinutos.TabIndex = 4;
            this.lblTituloMinutos.Text = "en minutos";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(142, 91);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(125, 34);
            this.txtDuracion.TabIndex = 2;
            // 
            // lblPeliculaSaga
            // 
            this.lblPeliculaSaga.AutoSize = true;
            this.lblPeliculaSaga.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaSaga.Location = new System.Drawing.Point(16, 185);
            this.lblPeliculaSaga.Name = "lblPeliculaSaga";
            this.lblPeliculaSaga.Size = new System.Drawing.Size(74, 32);
            this.lblPeliculaSaga.TabIndex = 0;
            this.lblPeliculaSaga.Text = "Saga:";
            // 
            // lblPeliculaGenero
            // 
            this.lblPeliculaGenero.AutoSize = true;
            this.lblPeliculaGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaGenero.Location = new System.Drawing.Point(16, 137);
            this.lblPeliculaGenero.Name = "lblPeliculaGenero";
            this.lblPeliculaGenero.Size = new System.Drawing.Size(97, 32);
            this.lblPeliculaGenero.TabIndex = 0;
            this.lblPeliculaGenero.Text = "Género:";
            // 
            // lblPeliculaDuracion
            // 
            this.lblPeliculaDuracion.AutoSize = true;
            this.lblPeliculaDuracion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaDuracion.Location = new System.Drawing.Point(16, 91);
            this.lblPeliculaDuracion.Name = "lblPeliculaDuracion";
            this.lblPeliculaDuracion.Size = new System.Drawing.Size(120, 32);
            this.lblPeliculaDuracion.TabIndex = 0;
            this.lblPeliculaDuracion.Text = "Duración:";
            // 
            // grpNavegar
            // 
            this.grpNavegar.Controls.Add(this.btnUltimo);
            this.grpNavegar.Controls.Add(this.btnAnterior);
            this.grpNavegar.Controls.Add(this.btnSiguiente);
            this.grpNavegar.Controls.Add(this.btnPrimero);
            this.grpNavegar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNavegar.Location = new System.Drawing.Point(36, 307);
            this.grpNavegar.Name = "grpNavegar";
            this.grpNavegar.Size = new System.Drawing.Size(549, 86);
            this.grpNavegar.TabIndex = 0;
            this.grpNavegar.TabStop = false;
            this.grpNavegar.Text = "Navegar:";
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Location = new System.Drawing.Point(404, 33);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(125, 43);
            this.btnUltimo.TabIndex = 8;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Location = new System.Drawing.Point(142, 33);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(125, 43);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(273, 33);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(125, 43);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.btnGuardarNuevo);
            this.grpNuevo.Controls.Add(this.btnAnadir);
            this.grpNuevo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevo.Location = new System.Drawing.Point(36, 412);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(282, 96);
            this.grpNuevo.TabIndex = 0;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Añadir registro:";
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGuardarNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(151, 36);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(125, 43);
            this.btnGuardarNuevo.TabIndex = 10;
            this.btnGuardarNuevo.Text = "Guardar";
            this.btnGuardarNuevo.UseVisualStyleBackColor = false;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAnadir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.Black;
            this.btnAnadir.Location = new System.Drawing.Point(11, 36);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(125, 43);
            this.btnAnadir.TabIndex = 9;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // grpEditar
            // 
            this.grpEditar.Controls.Add(this.btnEliminar);
            this.grpEditar.Controls.Add(this.btnActualizar);
            this.grpEditar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditar.Location = new System.Drawing.Point(324, 412);
            this.grpEditar.Name = "grpEditar";
            this.grpEditar.Size = new System.Drawing.Size(261, 96);
            this.grpEditar.TabIndex = 0;
            this.grpEditar.TabStop = false;
            this.grpEditar.Text = "Edición/Borrar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(137, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 43);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(6, 36);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 43);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lblListaPeliculas);
            this.grpListado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListado.Location = new System.Drawing.Point(609, 112);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(350, 264);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Lista de películas:";
            // 
            // lblListaPeliculas
            // 
            this.lblListaPeliculas.AutoSize = true;
            this.lblListaPeliculas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPeliculas.Location = new System.Drawing.Point(13, 43);
            this.lblListaPeliculas.Name = "lblListaPeliculas";
            this.lblListaPeliculas.Size = new System.Drawing.Size(27, 28);
            this.lblListaPeliculas.TabIndex = 0;
            this.lblListaPeliculas.Text = "...";
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblResultado);
            this.grpResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultado.Location = new System.Drawing.Point(609, 382);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(350, 96);
            this.grpResultado.TabIndex = 0;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(5, 30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(63, 28);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.cmbEligeSaga);
            this.grpSeleccion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeleccion.Location = new System.Drawing.Point(609, 27);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(350, 79);
            this.grpSeleccion.TabIndex = 0;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Selecciona una saga:";
            // 
            // cmbEligeSaga
            // 
            this.cmbEligeSaga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEligeSaga.FormattingEnabled = true;
            this.cmbEligeSaga.ItemHeight = 25;
            this.cmbEligeSaga.Location = new System.Drawing.Point(18, 31);
            this.cmbEligeSaga.Name = "cmbEligeSaga";
            this.cmbEligeSaga.Size = new System.Drawing.Size(317, 33);
            this.cmbEligeSaga.TabIndex = 7;
            this.cmbEligeSaga.SelectedIndexChanged += new System.EventHandler(this.cmbEligeSaga_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(613, 487);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 21);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "ddddddd";
            // 
            // Form1_Ejercicio_03_Tema_09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(992, 535);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grpSeleccion);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpNuevo);
            this.Controls.Add(this.grpEditar);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpNavegar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1_Ejercicio_03_Tema_09";
            this.Text = "Ejercicio_03_Tema_09";
            this.Load += new System.EventHandler(this.Form1_Ejercicio_03_Tema_09_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpNavegar.ResumeLayout(false);
            this.grpNuevo.ResumeLayout(false);
            this.grpEditar.ResumeLayout(false);
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpSeleccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPeliculaTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblPeliculaDuracion;
        private System.Windows.Forms.ComboBox cmbSaga;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblTituloMinutos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblPeliculaSaga;
        private System.Windows.Forms.Label lblPeliculaGenero;
        private System.Windows.Forms.GroupBox grpNavegar;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox grpEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Label lblListaPeliculas;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.GroupBox grpSeleccion;
        private System.Windows.Forms.ComboBox cmbEligeSaga;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblInfo;
    }
}

