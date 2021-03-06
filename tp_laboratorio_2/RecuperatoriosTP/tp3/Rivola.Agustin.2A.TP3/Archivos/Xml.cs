﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Excepciones;


namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T:class 
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno;
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                TextWriter tw = new StreamWriter(archivo);
                xmls.Serialize(tw, datos);
                retorno = true;
                tw.Close();
            }
            catch (Exception e)
            {
                retorno = false;
                Console.WriteLine("No se a podido guardar el archivo xml");
                throw new ArchivosException(e);
            }
            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool retorno;
            datos = default(T);
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                StreamReader sr = new StreamReader(archivo);
                datos = (T)xmls.Deserialize(sr);
                retorno = true;
                sr.Close();
            }
            catch(Exception e)
            {
                retorno = false;
                Console.WriteLine("No se a podido leer el archivo xml");
                throw new ArchivosException(e); 
            }

            return retorno;
        }
    }
}
