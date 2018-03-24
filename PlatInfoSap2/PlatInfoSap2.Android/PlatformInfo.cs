using System;
using Android.OS;

namespace PlatInfoSap2
{
    class PlatformInfo
    {
        public string GetModel()
        {
            return String.Format("{0} {1}", Build.Manufacturer, Build.Model);
        }
        public string GetVersion()
        {
            return Build.VERSION.Release.ToString();
        }
    }
}