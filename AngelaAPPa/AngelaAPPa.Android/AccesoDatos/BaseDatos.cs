using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AngelaAPPa.Droid.Modelo;
using SQLite;


namespace AngelaAPPa.Droid.AccesoDatos
{
   public  class BaseDatos
    {
       static string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static bool CrearBaseDatos()
        {
            try
            {
                using (var conexion=new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    conexion.DropTable<Cliente>();
                   // conexion.CreateTable<Clientes>();
                    return true;
                }
              
            }
            catch ( SQLiteException ex)
            {
                Log.Info("Crear Base DAtos", ex.Message);
                return false;
            }
        }
    }
}