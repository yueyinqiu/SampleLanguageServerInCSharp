using EmmyLua.LanguageServer.Framework.Server;
using System.Diagnostics;

namespace Server;

internal sealed class Program
{
    public static async Task Main()
    {
        Debugger.Launch();

        var ls = LanguageServer.From(Console.OpenStandardInput(), Console.OpenStandardOutput());
        ls.OnInitialize((c, s) =>
        {
            s.Name = "My Lsp Server";
            s.Version = "1.0.0";
            return Task.CompletedTask;
        });
        _ = ls.AddHandler(new MyHandler());
        await ls.Run();
    }
}
