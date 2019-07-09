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
    public class DALCliente
    {
        public DALCliente()
        {
           
        }

      
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool Insertar(Cliente cliente)
        {

            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    conexion.Insert(cliente);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("CInsert Clietne", ex.Message);
                return false;
            }
        }
        public bool Modificar(Cliente cliente)
        {

            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    conexion.Query<Cliente>("update cliente set nombre=? ,Direccion=?,Telefono=? where Id=? ", cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.Id);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("Modificar Clietne", ex.Message);
                return false;
            }
        }
        public bool Eliminar(Cliente cliente)
        {

            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    conexion.Delete(cliente);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("Modificar Clietne", ex.Message);
                return false;
            }
        }
        public List<Cliente> Listar()
        {

            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    return conexion.Table<Cliente>().ToList();
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("CInsert Clietne", ex.Message);
                return new List<Cliente>();
            }
        }
        public bool ObtenerCliente(string id)
        {

            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                     conexion.Query<Cliente>("Select * from cliente where id=?", id);
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("CInsert Clietne", ex.Message);
                return true;
            }
        }
        public bool CrearBaseDatos()
        {
            try
            {
                using (var conexion = new SQLiteConnection(System.IO.Path.Combine(folder, "cliente.db")))
                {
                    conexion.CreateTable<Cliente>();
                    return true;
                }

            }
            catch (SQLiteException ex)
            {
                Log.Info("Crear Base DAtos", ex.Message);
                return false;
            }
        }
    }
}