using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using AngelaAPPa.Droid.Modelo;
using AngelaAPPa.Droid.AccesoDatos;
using AngelaAPPa.Droid.Adaptadores;

namespace AngelaAPPa.Droid
{
    [Activity(Label = "ActivityCliente")]
    public class ActivityCliente : Activity
    {
        ListView lstDatos;
        List<Cliente> ltsClientes = new List<Cliente>();
        DALCliente DALCliente;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            BaseDatos.CrearBaseDatos();
            DALCliente = new DALCliente();
            DALCliente.CrearBaseDatos();


            SetContentView(Resource.Layout.MainCliente);
            lstDatos = FindViewById<ListView>(Resource.Id.listview);


            var txtNombre = FindViewById<EditText>(Resource.Id.txtNombre);
            var txtDireccion = FindViewById<EditText>(Resource.Id.txtDireccion);
            var txtTelefono = FindViewById<EditText>(Resource.Id.txtTelefono);
            var lblID = FindViewById<TextView>(Resource.Id.txtID);


            var btnAgregar = FindViewById<Button>(Resource.Id.btnAgregar);
            var btnEditar = FindViewById<Button>(Resource.Id.btnEditar);
            var btnEliminar = FindViewById<Button>(Resource.Id.btnEliminar);
            CargarDatos();

            btnAgregar.Click += delegate
            {
                Cliente cliente = new Cliente()
                {

                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };

                DALCliente.Insertar(cliente);
                CargarDatos();
            };

            btnEditar.Click += delegate
            {
                Cliente cliente = new Cliente()
                {
                    Id = Convert.ToInt32(lblID.Text == "" ? "0" : lblID.Text),
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text

                };

                DALCliente.Modificar(cliente);
                CargarDatos();
            };
            btnEliminar.Click += delegate
            {
                Cliente cliente = new Cliente()
                {
                    Id = Convert.ToInt32(lblID.Text),
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text

                };
                DALCliente.Eliminar(cliente);
                CargarDatos();
            };
            lstDatos.ItemClick += (s, e) => {




                var txtNombre1 = e.View.FindViewById<TextView>(Resource.Id.txtNombre);
                var txtDireccion1 = e.View.FindViewById<TextView>(Resource.Id.txtDireccion);
                var txtTelefono1 = e.View.FindViewById<TextView>(Resource.Id.txtTelefono);
                var txtID = e.View.FindViewById<TextView>(Resource.Id.txtID);
                txtDireccion.Text = txtDireccion1.Text;
                txtNombre.Text = txtNombre1.Text;
                lblID.Text = txtID.Text;
                txtTelefono.Text = txtTelefono1.Text;


            };
        }



        private void CargarDatos()
        {
            ltsClientes = DALCliente.Listar();
            var adaptador = new AdaptadorCliente(this, ltsClientes);
            lstDatos.Adapter = adaptador;
        }
    }
}
