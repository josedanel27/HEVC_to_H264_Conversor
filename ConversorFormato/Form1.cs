using FFMpegCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorFormato.Funciones;
using System.Text.RegularExpressions;



namespace ConversorFormato
{
    public partial class Inicio : Form
    {
        //Instancia
        //private Conversor conver;

        //Funcion para seleccionar archivos individualmente
        private void Archivo()
        {
            //Variables para la seleccion
            var info = new List<string>();
            string ruta = string.Empty;
            int columnas = 0;
            OpenFileDialog buscador = new OpenFileDialog();
            List<string> lista = new List<string>();
            

            //Ajustando filtros para el buscador
            buscador.Filter = "MP4|*.mp4";

            try
            {
                //Iniciando busqueda de archivo
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    ruta = buscador.FileName;

                    //Obteniendo informacion sobre el recurso
                    info = Conversor.InfoVideo(ruta);

                    //Separando nombre del archivo de la ruta
                    lista = Conversor.NombreRuta(ruta);

                    //Obteniendo numero de registros para establecer id
                    columnas = int.Parse(dtg_Videos.RowCount.ToString());

                    dtg_Videos.Rows.Add((columnas + 1).ToString(), lista[0], lista[1], info[1], info[0], "Elija", "Sin procesar", "Quitar");

                }
                
            }
            finally {  
                buscador.Dispose(); 
            }
            

            
            
            
        }
        //Funcion para seleccionar un conjunto de archivos
        private void Archivos()
        {
            //Declarando variables e iniciando metodos
            var rutas = new List<string>();
            List<string> lista = new List<string>();
            List<string> info = new List<string>();
            byte ncolum = 0;
            
            byte i = 0;
            OpenFileDialog buscador = new OpenFileDialog();


            //Ajustando parametros para el buscador
            buscador.Filter = "MP4|*.mp4";
            buscador.Multiselect = true;

            //Obteniendo informacion de estado de datagrid
            ncolum = (byte)dtg_Videos.RowCount;

            try { 
                
                //Iniciando buscador
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    rutas.AddRange(buscador.FileNames);

                    //Buscando informacion sobre archivos
                

                    while (i < rutas.Count)
                    {
                        //Obteniendo informacion sobre el recurso
                        info = Conversor.InfoVideo(rutas[i]);

                        //Separando nombre del archivo de la ruta
                        lista = Conversor.NombreRuta(rutas[i]);

                        dtg_Videos.Rows.Add((ncolum + 1 + i).ToString(), lista[0], lista[1], info[1], info[0], "Elija", "Sin procesar", "Quitar");
                        i++;
                    }

                }
            }
            finally 
            { 
                buscador.Dispose(); 
            }



        } 

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelProc.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Archivo();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo();
        }

        private void dtg_Videos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int InidiceFila = 0;
            if (e.ColumnIndex == 7)
            {
                InidiceFila = e.RowIndex;
                dtg_Videos.Rows.RemoveAt(InidiceFila);
            }
            
            
        }

        private void abrirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivos();
        }

        private void bt_Archivos_Click(object sender, EventArgs e)
        {
            Archivos();
        }

        private void bt_clean_Click(object sender, EventArgs e)
        {
            dtg_Videos.Rows.Clear();
        }

        private void bt_Concertir_Click(object sender, EventArgs e)
        {
            /////Iniciando proceso de conversion/////
            byte filas = 0;
            byte i = 0;
            string rutaArchivo = string.Empty;
            string rutaSalida = string.Empty;

            //Obteniendo cantidad de elementos en la fila
            filas = (byte)dtg_Videos.Rows.Count;

            try
            {
                LabelProc.Enabled = true;
                bt_Concertir.Enabled = false; 
                bt_clean.Enabled = false; 
                bt_Archivos.Enabled = false; 
                bt_aniadir.Enabled = false;
                pb_Proceso.Value = 0;
                foreach (DataGridViewRow fila in dtg_Videos.Rows)
                {
                    i++;
                    if (fila.Cells["FormatoSalida"].Value.ToString() == "MP4 H.264")
                    {

                        rutaArchivo = $"{fila.Cells["ruta"].Value.ToString()}{fila.Cells["Nombre"].Value.ToString()}";
                        rutaSalida = $"{fila.Cells["ruta"].Value.ToString()}Salida{i}.mp4";
                        if(Conversor.Transformador(rutaArchivo, rutaSalida) == true)
                        {
                            Console.WriteLine("Video completado");
                        }

                    }
                    else 
                    {
                        MessageBox.Show("Solo administimos h.264 por el momento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    pb_Proceso.Value = (i * 100)/filas;
                    
                    
                    
                    
                }
            }
            finally 
            {
                LabelProc.Enabled = false;
                bt_Concertir.Enabled = true;
                bt_clean.Enabled = true;
                bt_Archivos.Enabled = true;
                bt_aniadir.Enabled = true;
                pb_Proceso.Value = 0;
            }
            MessageBox.Show("A culminado el proceso", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

    }
}
