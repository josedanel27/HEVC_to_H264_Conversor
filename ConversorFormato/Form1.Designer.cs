namespace ConversorFormato
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesDeConversiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.dtg_Videos = new System.Windows.Forms.DataGridView();
            this.bt_Concertir = new System.Windows.Forms.Button();
            this.bt_aniadir = new System.Windows.Forms.Button();
            this.bt_Archivos = new System.Windows.Forms.Button();
            this.bt_clean = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormatoSalida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarBoton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pb_Proceso = new System.Windows.Forms.ProgressBar();
            this.LabelProc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Videos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.tareasToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.abrirCarpetaToolStripMenuItem,
            this.limpiarListaToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.abrirCarpetaToolStripMenuItem.Text = "Abrir carpeta";
            this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.abrirCarpetaToolStripMenuItem_Click);
            // 
            // limpiarListaToolStripMenuItem
            // 
            this.limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            this.limpiarListaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.limpiarListaToolStripMenuItem.Text = "Limpiar lista";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirToolStripMenuItem,
            this.ajustesDeConversiónToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // convertirToolStripMenuItem
            // 
            this.convertirToolStripMenuItem.Name = "convertirToolStripMenuItem";
            this.convertirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.convertirToolStripMenuItem.Text = "Convertir";
            // 
            // ajustesDeConversiónToolStripMenuItem
            // 
            this.ajustesDeConversiónToolStripMenuItem.Name = "ajustesDeConversiónToolStripMenuItem";
            this.ajustesDeConversiónToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ajustesDeConversiónToolStripMenuItem.Text = "Ajustes de conversión";
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDesarrolladorToolStripMenuItem});
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de";
            // 
            // informaciónDesarrolladorToolStripMenuItem
            // 
            this.informaciónDesarrolladorToolStripMenuItem.Name = "informaciónDesarrolladorToolStripMenuItem";
            this.informaciónDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.informaciónDesarrolladorToolStripMenuItem.Text = "Información Desarrollador";
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.Location = new System.Drawing.Point(12, 35);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(266, 31);
            this.Titulo1.TabIndex = 1;
            this.Titulo1.Text = "Convertir de Codec";
            // 
            // dtg_Videos
            // 
            this.dtg_Videos.AllowUserToAddRows = false;
            this.dtg_Videos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Videos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Ruta,
            this.Duracion,
            this.Formato,
            this.FormatoSalida,
            this.Estado,
            this.EliminarBoton});
            this.dtg_Videos.Location = new System.Drawing.Point(269, 88);
            this.dtg_Videos.Name = "dtg_Videos";
            this.dtg_Videos.Size = new System.Drawing.Size(845, 414);
            this.dtg_Videos.TabIndex = 2;
            this.dtg_Videos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Videos_CellContentClick);
            // 
            // bt_Concertir
            // 
            this.bt_Concertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Concertir.Location = new System.Drawing.Point(943, 508);
            this.bt_Concertir.Name = "bt_Concertir";
            this.bt_Concertir.Size = new System.Drawing.Size(133, 40);
            this.bt_Concertir.TabIndex = 3;
            this.bt_Concertir.Text = "Convertir";
            this.bt_Concertir.UseVisualStyleBackColor = true;
            this.bt_Concertir.Click += new System.EventHandler(this.bt_Concertir_Click);
            // 
            // bt_aniadir
            // 
            this.bt_aniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aniadir.Location = new System.Drawing.Point(30, 99);
            this.bt_aniadir.Name = "bt_aniadir";
            this.bt_aniadir.Size = new System.Drawing.Size(215, 34);
            this.bt_aniadir.TabIndex = 4;
            this.bt_aniadir.Text = "Añadir Videos";
            this.bt_aniadir.UseVisualStyleBackColor = true;
            this.bt_aniadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Archivos
            // 
            this.bt_Archivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Archivos.Location = new System.Drawing.Point(30, 156);
            this.bt_Archivos.Name = "bt_Archivos";
            this.bt_Archivos.Size = new System.Drawing.Size(215, 45);
            this.bt_Archivos.TabIndex = 5;
            this.bt_Archivos.Text = "Lista de Archivos";
            this.bt_Archivos.UseVisualStyleBackColor = true;
            this.bt_Archivos.Click += new System.EventHandler(this.bt_Archivos_Click);
            // 
            // bt_clean
            // 
            this.bt_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clean.Location = new System.Drawing.Point(30, 224);
            this.bt_clean.Name = "bt_clean";
            this.bt_clean.Size = new System.Drawing.Size(215, 46);
            this.bt_clean.TabIndex = 6;
            this.bt_clean.Text = "Limpiar Lista";
            this.bt_clean.UseVisualStyleBackColor = true;
            this.bt_clean.Click += new System.EventHandler(this.bt_clean_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID recurso";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Archivo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta Archivo";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Codec Nativo";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // FormatoSalida
            // 
            this.FormatoSalida.HeaderText = "Codec/Formato de Salida";
            this.FormatoSalida.Items.AddRange(new object[] {
            "Elija",
            "MP4 H.264",
            "MP4 H.265",
            "AVI",
            "MOV"});
            this.FormatoSalida.Name = "FormatoSalida";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.HeaderText = "Quitar";
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.ReadOnly = true;
            // 
            // pb_Proceso
            // 
            this.pb_Proceso.Location = new System.Drawing.Point(907, 37);
            this.pb_Proceso.Name = "pb_Proceso";
            this.pb_Proceso.Size = new System.Drawing.Size(206, 28);
            this.pb_Proceso.TabIndex = 7;
            // 
            // LabelProc
            // 
            this.LabelProc.AutoSize = true;
            this.LabelProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProc.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelProc.Location = new System.Drawing.Point(716, 38);
            this.LabelProc.Name = "LabelProc";
            this.LabelProc.Size = new System.Drawing.Size(187, 25);
            this.LabelProc.TabIndex = 8;
            this.LabelProc.Text = "Proceso corriendo";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 645);
            this.Controls.Add(this.LabelProc);
            this.Controls.Add(this.pb_Proceso);
            this.Controls.Add(this.bt_clean);
            this.Controls.Add(this.bt_Archivos);
            this.Controls.Add(this.bt_aniadir);
            this.Controls.Add(this.bt_Concertir);
            this.Controls.Add(this.dtg_Videos);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "ConversorCodec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Videos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesDeConversiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.DataGridView dtg_Videos;
        private System.Windows.Forms.Button bt_Concertir;
        private System.Windows.Forms.Button bt_aniadir;
        private System.Windows.Forms.Button bt_Archivos;
        private System.Windows.Forms.Button bt_clean;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewComboBoxColumn FormatoSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarBoton;
        private System.Windows.Forms.ProgressBar pb_Proceso;
        private System.Windows.Forms.Label LabelProc;
    }
}

