package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("TuFarmaApp.Droid.MainApplication, TuFarmaApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64f52356829222320a.MainApplication.class, crc64f52356829222320a.MainApplication.__md_methods);
		
	}
}
