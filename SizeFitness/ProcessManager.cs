using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SizeFitness
{
    public class ProcessManager
    {
        #region シングルトン

        private static ProcessManager instance;
        public static ProcessManager GetInstance() => instance ?? (instance = new());

        #endregion

        private List<string> blackList = new(new[] { "Microsoft Text Input Application", "Program Manager", "Microsoft Store", "Mail", "電卓" });

        public string[] BlackList => blackList.ToArray();

        public Process[] ProcessList { get; private set; }

        #region BlackList

        /// <summary>
        /// ブラックリストに追加する
        /// </summary>
        /// <param name="processName"></param>
        public void AddBlackList(string processName)
        {
            if (!blackList.Contains(processName))
                blackList.Add(processName);
        }

        /// <summary>
        /// ブラックリストから削除する
        /// </summary>
        public void RemoveBlackList(string processName)
        {
            if (blackList.Contains(processName))
                blackList.Remove(processName);
        }

        /// <summary>
        /// ブラックリストを読み込む
        /// </summary>
        /// <param name="path">読み込みパス</param>
        private void ReadBlackList(string path)
        {
            using (var file = new StreamReader(path))
            {
                var line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    blackList.Add(line);
                }
            }
        }

        /// <summary>
        /// ブラックリストを保存する
        /// </summary>
        /// <param name="path">保存パス</param>
        private void SaveBlackList(string path)
        {
            using (var file = new StreamWriter(path))
            {
                foreach (var list in blackList)
                    file.WriteLine(list);
            }
        }

        #endregion

        /// <summary>
        /// ウィンドウリストをウィンドウオーダー順に沿って更新します。
        /// 
        /// </summary>
        public void UpdateWindowList()
        {
            List<Process> process = new();

            foreach (var p in Process.GetProcesses())
            {
                if (p.MainWindowTitle.Length != 0 && Win32API.IsWindowVisible(p.MainWindowHandle) && !blackList.Contains(p.MainWindowTitle))
                {
                    process.Add(p);
                }
            }
            process.Sort((x, y) => GetWindowOrder(x.MainWindowHandle) - GetWindowOrder(y.MainWindowHandle));

            ProcessList = process.ToArray();
        }

        /// <summary>
        /// ウィンドウ情報を取得します。
        /// </summary>
        /// <param name="process">取得するプロセス</param>
        /// <returns></returns>
        public WindowInfo GetWindowInfo(Process process)
        {
            Win32API.GetWindowInfo(process.MainWindowHandle, out var info);

            return new()
            {
                Left = info.rcWindow.left,
                Top = info.rcWindow.top,
                Width = info.rcWindow.right - info.rcWindow.left,
                Height = info.rcWindow.bottom - info.rcWindow.top,
                IsMaximize = (info.dwStyle & Win32API.WS_MAXIMIZE) == Win32API.WS_MAXIMIZE,
                IsMinimize = (info.dwStyle & Win32API.WS_MINIMIZE) == Win32API.WS_MINIMIZE
            };
        }

        /// <summary>
        /// ウィンドウ情報を設定します。
        /// </summary>
        /// <param name="process">設定するプロセス</param>
        /// <param name="info">設定する内容</param>
        /// <returns></returns>
        public bool SetWindowPos(Process process, ProfileInfo info)
        {
            if (info.Enable)
            {
                return Win32API.SetWindowPos(process.MainWindowHandle, IntPtr.Zero, info.Left, info.Top, info.Width, info.Height, 0);
            }

            return false;
        }

        /// <summary>
        /// ウィンドウのオーダーを取得します。
        /// </summary>
        /// <param name="handle">オーダーを取得するウィンドウハンドル</param>
        /// <returns></returns>
        private int GetWindowOrder(IntPtr handle)
        {
            var count = 0;

            var window = Win32API.GetWindow(handle, Win32API.GW_HWNDFIRST);

            while (true)
            {
                window = Win32API.GetWindow(window, Win32API.GW_HWNDNEXT);

                if (window == handle)
                    break;

                count++;
            }

            return count;
        }
    }
}
