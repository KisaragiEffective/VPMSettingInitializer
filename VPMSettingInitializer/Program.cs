// See https://aka.ms/new-console-template for more information
using VRC.PackageManagement.Core;

namespace VPMSettingInitializer;

internal class Program
{
    private static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.Error.WriteLine("usage: VPMSettingInitializer [config.json path]");
            return 1;
        }
        var settings = new Settings(args[0]);
        settings.Save();
        
        return 0;
    }
}
