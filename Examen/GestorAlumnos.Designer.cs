namespace Examen
{
    partial class GestorAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.nombres = new System.Windows.Forms.Label();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.nota = new System.Windows.Forms.Label();
            this.textNota = new System.Windows.Forms.TextBox();
            this.agregarAlumno = new System.Windows.Forms.Button();
            this.btnListarAlumnos = new System.Windows.Forms.Button();
            this.listaAlumnos = new System.Windows.Forms.ListBox();
            this.btnAlumnosSuspensos = new System.Windows.Forms.Button();
            this.btnAlumnosAprobados = new System.Windows.Forms.Button();
            this.btnAlumnosMH = new System.Windows.Forms.Button();
            this.txtBuscarIdentificacion = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTOR DE CALIFICACIONES DE ALUMNOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación (DNI, Cédula, etc)";
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(69, 190);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(160, 26);
            this.textIdentificacion.TabIndex = 2;
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Location = new System.Drawing.Point(65, 232);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(73, 20);
            this.nombres.TabIndex = 3;
            this.nombres.Text = "Nombres";
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(69, 255);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(229, 26);
            this.textNombres.TabIndex = 4;
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Location = new System.Drawing.Point(65, 305);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(73, 20);
            this.apellidos.TabIndex = 5;
            this.apellidos.Text = "Apellidos";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(69, 328);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(229, 26);
            this.textApellidos.TabIndex = 6;
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.Location = new System.Drawing.Point(65, 377);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(43, 20);
            this.nota.TabIndex = 7;
            this.nota.Text = "Nota";
            // 
            // textNota
            // 
            this.textNota.Location = new System.Drawing.Point(69, 402);
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(100, 26);
            this.textNota.TabIndex = 8;
            // 
            // agregarAlumno
            // 
            this.agregarAlumno.Location = new System.Drawing.Point(69, 450);
            this.agregarAlumno.Name = "agregarAlumno";
            this.agregarAlumno.Size = new System.Drawing.Size(229, 43);
            this.agregarAlumno.TabIndex = 9;
            this.agregarAlumno.Text = "Agregar Alumno";
            this.agregarAlumno.UseVisualStyleBackColor = true;
            this.agregarAlumno.Click += new System.EventHandler(this.agregarAlumno_Click);
            // 
            // btnListarAlumnos
            // 
            this.btnListarAlumnos.Location = new System.Drawing.Point(427, 111);
            this.btnListarAlumnos.Name = "btnListarAlumnos";
            this.btnListarAlumnos.Size = new System.Drawing.Size(164, 31);
            this.btnListarAlumnos.TabIndex = 10;
            this.btnListarAlumnos.Text = "Todos los Alumnos";
            this.btnListarAlumnos.UseVisualStyleBackColor = true;
            this.btnListarAlumnos.Click += new System.EventHandler(this.btnListarAlumnos_Click);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.FormattingEnabled = true;
            this.listaAlumnos.ItemHeight = 20;
            this.listaAlumnos.Location = new System.Drawing.Point(427, 250);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(726, 384);
            this.listaAlumnos.TabIndex = 11;
            this.listaAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaAlumnos_SelectedIndexChanged);
            // 
            // btnAlumnosSuspensos
            // 
            this.btnAlumnosSuspensos.Location = new System.Drawing.Point(613, 111);
            this.btnAlumnosSuspensos.Name = "btnAlumnosSuspensos";
            this.btnAlumnosSuspensos.Size = new System.Drawing.Size(185, 31);
            this.btnAlumnosSuspensos.TabIndex = 12;
            this.btnAlumnosSuspensos.Text = "Alumnos Suspensos";
            this.btnAlumnosSuspensos.UseVisualStyleBackColor = true;
            this.btnAlumnosSuspensos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlumnosAprobados
            // 
            this.btnAlumnosAprobados.Location = new System.Drawing.Point(819, 111);
            this.btnAlumnosAprobados.Name = "btnAlumnosAprobados";
            this.btnAlumnosAprobados.Size = new System.Drawing.Size(170, 31);
            this.btnAlumnosAprobados.TabIndex = 13;
            this.btnAlumnosAprobados.Text = "Alumnos Aprobados";
            this.btnAlumnosAprobados.UseVisualStyleBackColor = true;
            this.btnAlumnosAprobados.Click += new System.EventHandler(this.btnAlumnosAprobados_Click);
            // 
            // btnAlumnosMH
            // 
            this.btnAlumnosMH.Location = new System.Drawing.Point(1010, 111);
            this.btnAlumnosMH.Name = "btnAlumnosMH";
            this.btnAlumnosMH.Size = new System.Drawing.Size(143, 31);
            this.btnAlumnosMH.TabIndex = 14;
            this.btnAlumnosMH.Text = "Alumnos MH";
            this.btnAlumnosMH.UseVisualStyleBackColor = true;
            this.btnAlumnosMH.Click += new System.EventHandler(this.btnAlumnosMH_Click);
            // 
            // txtBuscarIdentificacion
            // 
            this.txtBuscarIdentificacion.Location = new System.Drawing.Point(536, 162);
            this.txtBuscarIdentificacion.Name = "txtBuscarIdentificacion";
            this.txtBuscarIdentificacion.Size = new System.Drawing.Size(186, 26);
            this.txtBuscarIdentificacion.TabIndex = 15;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(746, 162);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(153, 31);
            this.btnBuscarAlumno.TabIndex = 16;
            this.btnBuscarAlumno.Text = "Buscar Alumno";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Identificacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "AGREGAR, MODIFICAR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(69, 504);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(229, 43);
            this.btnModificarAlumno.TabIndex = 19;
            this.btnModificarAlumno.Text = "Modificar Nota";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(69, 554);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(229, 43);
            this.btnEliminarAlumno.TabIndex = 20;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Y ELIMINAR ALUMNO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(69, 603);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(229, 43);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(723, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Para modificar la nota de un alumno o eliminar el alumno, debe seleccionar al alu" +
    "mno desde el listado.";
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(1010, 162);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(143, 31);
            this.btnLimpiarLista.TabIndex = 24;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // GestorAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 716);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtBuscarIdentificacion);
            this.Controls.Add(this.btnAlumnosMH);
            this.Controls.Add(this.btnAlumnosAprobados);
            this.Controls.Add(this.btnAlumnosSuspensos);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.btnListarAlumnos);
            this.Controls.Add(this.agregarAlumno);
            this.Controls.Add(this.textNota);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.textNombres);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "GestorAlumnos";
            this.Text = "Gestor de Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label nombres;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.TextBox textNota;
        private System.Windows.Forms.Button agregarAlumno;
        private System.Windows.Forms.Button btnListarAlumnos;
        private System.Windows.Forms.ListBox listaAlumnos;
        private System.Windows.Forms.Button btnAlumnosSuspensos;
        private System.Windows.Forms.Button btnAlumnosAprobados;
        private System.Windows.Forms.Button btnAlumnosMH;
        private System.Windows.Forms.TextBox txtBuscarIdentificacion;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiarLista;
    }
}

