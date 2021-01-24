using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeFitness
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var command = Environment.CommandLine.ToLower();
            var app = command.RegexString(@"/app:(?<value>\w+.exe)", "value");
            var height = command.RegexString(@"/height:(?<value>\d+)", "value");
            var width = command.RegexString(@"/width:(?<value>\d+)", "value");
            var top = command.RegexString(@"/top:(?<value>\d+)", "value");
            var left = command.RegexString(@"/left:(?<value>\d+)", "value");
            var create = command.Contains("/c");
            var window = command.Contains("/nowindow");

            if (app is null)
            {
                Console.WriteLine("プロセス名を指定してください。");
            }
            else
            {
                var manager = ProcessManager.GetInstance();
                var setting = Setting.GetInstance();

                try
                {
                    Setting.SetInstance(JsonSerializer.Deserialize<Setting>(File.ReadAllText($"{Application.StartupPath}\\setting.json")));
                }
                catch
                {

                }

                manager.UpdateWindowList();

                var profile = setting.Profiles.FirstOrDefault(target => target.ProcessName.Equals(app));
                var proc = manager.ProcessList.FirstOrDefault(target => app.Equals($"{target.ProcessName}.exe"));         

                try
                {
                    if (proc is not null)
                    {
                        var info = manager.GetWindowInfo(proc);
                        var prof = new ProfileInfo()
                        {
                            ProcessName = app,
                            Width = int.TryParse(width, out var w) ? w : info.Width,
                            Height = int.TryParse(height, out var h) ? h : info.Height,
                            Left = int.TryParse(left, out var l) ? l : info.Left,
                            Top = int.TryParse(top, out var t) ? t : info.Top,
                            Enable = true,
                            Path = proc?.MainModule?.FileName
                        };

                        if (create)
                        {
                            if (profile is null)
                            {
                                setting.Profiles.Add(prof);
                            }
                            else
                            {
                                Utility.SetValues<ProfileInfo>(profile, prof);
                            }
                        }

                        if (app.Equals($"{proc.ProcessName}.exe"))
                        {
                            manager.SetWindowPos(proc, prof);
                        }
                        else
                        {
                            Console.WriteLine("指定したプロセスは存在しません。");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("対象のプロセスを書き換えるには、管理者権限で起動してください。");
                }
            }

            if (!window)
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
