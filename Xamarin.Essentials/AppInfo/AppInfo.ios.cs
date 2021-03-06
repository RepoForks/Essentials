﻿using Foundation;

namespace Xamarin.Essentials
{
    public static partial class AppInfo
    {
        static string GetPackageName() => GetBundleValue("CFBundleIdentifier");

        static string GetName() => GetBundleValue("CFBundleDisplayName") ?? GetBundleValue("CFBundleName");

        static string GetVersionString() => GetBundleValue("CFBundleShortVersionString");

        static string GetBuild() => GetBundleValue("CFBundleVersion");

        static string GetBundleValue(string key)
           => NSBundle.MainBundle.ObjectForInfoDictionary(key).ToString();
    }
}
