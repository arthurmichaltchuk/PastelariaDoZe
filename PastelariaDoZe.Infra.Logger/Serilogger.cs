using Serilog;
using System;

namespace PastelariaDoZe.Infra.Logger
{
    public static class Serilogger
    {
        public static ILogger Logger;
        static Serilogger()
        {

            Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("..\\..\\..\\..\\PastelariaDoZe.Infra.Logger//logs//log.txt")
                 .Enrich.FromLogContext()
                .Enrich.WithProperty("ApplicationName", "Locadora de Veículos")
                .Enrich.WithProperty("MachineName", Environment.MachineName)
                .Enrich.WithProperty("ApplicationName", Environment.ProcessId)
                .Enrich.WithProperty("ThreadId", Environment.CurrentManagedThreadId)
                .Enrich.WithProperty("UserName", Environment.UserName)
                .CreateLogger();
        }
    }
}
