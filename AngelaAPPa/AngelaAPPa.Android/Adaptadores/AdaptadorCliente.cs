using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AngelaAPPa.Droid.Modelo;
using Java.Lang;

namespace AngelaAPPa.Droid.Adaptadores
{
    public class ViewCliente : Java.Lang.Object
    {
        public TextView txtID { get; set; }
        public TextView txtNombre { get; set; }
        public TextView txtDireccion { get; set; }
        public TextView txtTelefono { get; set; }
    }
    public class AdaptadorCliente:BaseAdapter
    {
        private Activity activity;
        private List<Cliente> ltsClientes;
        public AdaptadorCliente(Activity activity,List<Cliente>ltsClientes)
        {
            this.activity = activity;
            this.ltsClientes = ltsClientes;
        }

        public override int Count => ltsClientes.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return ltsClientes[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListaCliente,parent,false);
            var txtnombre = view.FindViewById<TextView>(Resource.Id.txtNombre);
            var txtdireccion = view.FindViewById<TextView>(Resource.Id.txtDireccion);
            var txttelefono = view.FindViewById<TextView>(Resource.Id.txtTelefono);
            var txtID = view.FindViewById<TextView>(Resource.Id.txtID);



            txtnombre.Text = ltsClientes[position].Nombre;
            txtID.Text= ltsClientes[position].Id.ToString();
            txtdireccion.Text = ltsClientes[position].Direccion;
            txttelefono.Text = ltsClientes[position].Telefono;
            return  view;
        }
    }
}