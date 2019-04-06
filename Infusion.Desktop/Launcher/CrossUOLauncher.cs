﻿using Infusion.Proxy;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Infusion.Desktop.Launcher
{
    public static class CrossUOLauncher
    {
        public static void Launch(LauncherOptions options, ushort proxyPort)
        {
            var ultimaExecutablePath = options.Cross.ClientExePath;
            if (!File.Exists(ultimaExecutablePath))
            {
                Program.Console.Error($"File {ultimaExecutablePath} doesn't exist.");

                return;
            }

            var account = options.UserName;
            var password = options.Password;

            var info = new ProcessStartInfo(ultimaExecutablePath);
            info.WorkingDirectory = Path.GetDirectoryName(ultimaExecutablePath);

            string insensitiveArguments = $"--host 127.0.0.1 --port {proxyPort} --login {account}";
            string sensitiveArguments = $" --password {password}";
            info.Arguments = insensitiveArguments + sensitiveArguments;

            string argumentsInfo = insensitiveArguments + " --password <censored>";

            Program.Console.Info($"Staring {ultimaExecutablePath} {argumentsInfo}");

            var ultimaClientProcess = Process.Start(info);
            if (ultimaClientProcess == null)
            {
                Program.Console.Error($"Cannot start {ultimaExecutablePath}.");
                return;
            }

            Program.SetClientWindowHandle(ultimaClientProcess);
        }
    }
}
