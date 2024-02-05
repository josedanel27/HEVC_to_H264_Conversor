using FFMpegCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FFMpegCore.Enums;
using System.Text.RegularExpressions;

namespace ConversorFormato.Funciones
{
    internal class Conversor
    {

        public static List<string> InfoVideo(string _ruta)
        {
            //Declarando variables para recoleccion de informacion
            List<string> list = new List<string>();
            var mediaInfo = FFProbe.Analyse(_ruta);
            
            //Cargando informacion deseada
            list.Add(mediaInfo.PrimaryVideoStream.CodecName);
            list.Add(mediaInfo.Duration.ToString());
            return list;
        }

        public static bool Transformador( string _archivo, string _ruta) {
            bool flag = false;
            
            try
            {
                FFMpegArguments.FromFileInput(_archivo)
                                .OutputToFile(_ruta, false, options => options
                                .WithVideoCodec(VideoCodec.LibX264)
                                .WithConstantRateFactor(21)
                                .WithAudioCodec(AudioCodec.Aac)
                                .WithVariableBitrate(4)
                                .WithFastStart())
                                .ProcessSynchronously();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return flag;
        }
        
        //Funcion para separar ruta y nombre del archivo
        public static List<string> NombreRuta(string _ruta)
        {
            //Declarando variables locales para separacion
            string archivo = string.Empty;
            List<string> lista = new List<string>();
            
            //Iniciando separacion
            archivo = Regex.Match(_ruta, @"(?<=[/\\])[^/\\]+\.[^/\\]+$").ToString();

            //Añadiendo elementos a la lista para enviarlos la funcion que realizo la peticion
            lista.Add(archivo);
            lista.Add(_ruta.Replace(archivo, ""));
            return lista;
        }
    }
}
