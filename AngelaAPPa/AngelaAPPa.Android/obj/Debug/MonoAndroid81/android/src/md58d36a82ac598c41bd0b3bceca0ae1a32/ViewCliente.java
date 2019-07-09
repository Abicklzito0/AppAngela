package md58d36a82ac598c41bd0b3bceca0ae1a32;


public class ViewCliente
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AngelaAPPa.Droid.Adaptadores.ViewCliente, AngelaAPPa.Android", ViewCliente.class, __md_methods);
	}


	public ViewCliente ()
	{
		super ();
		if (getClass () == ViewCliente.class)
			mono.android.TypeManager.Activate ("AngelaAPPa.Droid.Adaptadores.ViewCliente, AngelaAPPa.Android", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
