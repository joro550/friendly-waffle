using System;
using System.IO;
using System.Reflection;

namespace Tabber.Core.Tests.Scripts
{
    public static class Loader
    {
        public static string SimpleScript => "SimpleScript.txt";

        public static string LoadFileContents(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"Tabber.Core.Tests.Scripts.{fileName}";

            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream ?? throw new InvalidOperationException());
            return reader.ReadToEnd();
        }
    }
}
