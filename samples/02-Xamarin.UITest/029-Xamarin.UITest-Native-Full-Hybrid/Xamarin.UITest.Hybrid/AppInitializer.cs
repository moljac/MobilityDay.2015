﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.UITest.Hybrid
{
	public class AppInitializer
	{
		private static string  app_file_android_apk = 
			"/Users/moljac/Projects/Samples/Samples.Xamarin.UITest/samples/Native-Full-Hybrid/app-files-hybrid/Untappd - Discover Beer v2.3.4.apk"
			;
		private static string  app_file_ios_ipa = 
			""
			;

		public static IApp StartApp (Platform platform)
		{
			IApp app = null;

			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if (platform == Platform.Android)
			{
				app = 
					ConfigureApp
						.Android
						.Debug()
						// TODO: Update this path to point to your Android app and uncomment the
						// code if the app is not included in the solution.
						.ApkFile (app_file_android_apk)
						.StartApp ()
						;

				app.Repl ();
			}
			else if (platform == Platform.iOS)
			{
				app = 
					ConfigureApp
						.iOS
						.Debug()
						.AppBundle (app_file_ios_ipa)
						.StartApp ()
						;

				app.Repl ();
			}

			return app;
		}
	}
}

