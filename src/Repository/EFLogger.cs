using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EFLogger : ILogger
    {
        private readonly string categoryName;
        private readonly bool isEnabled = false;

        public EFLogger(string categoryName)
        {
            this.categoryName = categoryName;
            if ("Development".Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))) isEnabled = true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return isEnabled;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            LogQuery<TState>(logLevel, eventId, state, exception, formatter);
        }

        private void LogQuery<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if(categoryName == "Microsoft.EntityFrameworkCore.Database.Command" && logLevel == LogLevel.Information)
            {
                var logContent = formatter(state, exception);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(logContent);
                Console.ResetColor();
            }
        }

    }
}
