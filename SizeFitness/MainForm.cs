﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeFitness
{
    public partial class MainForm : Form
    {
        private TargetWindow targetWindow = new();
        private BorderWindow borderWindow = new();
        private ProcessManager manager = ProcessManager.GetInstance();
        private Setting setting = Setting.GetInstance();

        private int x, y;
        private Process activeProcess;

        public MainForm()
        {
            InitializeComponent();

            // init
            Initialize();
        }

        private void Initialize()
        {
            // 最大サイズ
            NumericUpDown_Top.Maximum = int.MaxValue;
            NumericUpDown_Left.Maximum = int.MaxValue;
            NumericUpDown_Height.Maximum = int.MaxValue;
            NumericUpDown_Width.Maximum = int.MaxValue;

            // 最小サイズ
            NumericUpDown_Top.Minimum = int.MinValue;
            NumericUpDown_Left.Minimum = int.MinValue;

            // イベント
            targetWindow.MouseDown += TargetWindow_MouseDown;
            targetWindow.MouseMove += TargetWindow_MouseMove;
            targetWindow.MouseUp += TargetWindow_MouseUp;
            targetWindow.Show(this);


            try
            {
                setting = JsonSerializer.Deserialize<Setting>(File.ReadAllText($"{Application.StartupPath}\\setting.json"));
            }
            catch
            {

            }

            ComboBox_Profile.DataSource = setting.Profiles;
            ComboBox_Profile.DisplayMember = "ProcessName";
            manager.UpdateWindowList();
        }

        private void TargetWindow_MouseUp(object sender, MouseEventArgs e)
        {
            // ターゲットウィンドウをもとに戻す
            targetWindow.Location = this.PointToScreen(panel1.Location);
            borderWindow.Visible = false;
            UpdateInfomation(activeProcess, false);
            this.Activate();


            var profile = setting.Profiles.FirstOrDefault(target => target.ProcessName.Equals($"{activeProcess.ProcessName}.exe"));

            if (profile is not null)
            {
                ComboBox_Profile.SelectedIndex = setting.Profiles.IndexOf(profile);
            }
            Timer_Refresh.Start();
        }

        private void TargetWindow_MouseDown(object sender, MouseEventArgs e)
        {
            // ウィンドウターゲット
            (x, y) = (e.X, e.Y);
            (borderWindow.Width, borderWindow.Height, borderWindow.Visible) = (0, 0, true);

            // ウィンドウリストの更新
            manager.UpdateWindowList();

            // 大麻停止
            Timer_Refresh.Stop();
        }

        private void TargetWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                (targetWindow.Left, targetWindow.Top) = (targetWindow.Left + e.X - x, targetWindow.Top + e.Y - y);

                // マウス下のウィンドウ情報を取得する。
                HittingProcess();
            }
        }

        private void HittingProcess()
        {
            if (manager.ProcessList != null)
            {
                foreach (var proc in manager.ProcessList)
                {
                    var rect = manager.GetWindowInfo(proc);

                    if (rect.Left < targetWindow.Left && targetWindow.Left < rect.Left + rect.Width && rect.Top < targetWindow.Top && rect.Top < targetWindow.Top + rect.Height)
                    {
                        (borderWindow.Left, borderWindow.Top, borderWindow.Width, borderWindow.Height) = (rect.Left, rect.Top, rect.Width, rect.Height);
                        borderWindow.Label_Infomation.Text = $"ProcessName : {proc.ProcessName}.exe\r\n  Left : { rect.Left}\r\n  Top : { rect.Top}\r\n  Width : { rect.Width}\r\n  Height : { rect.Height}";
                        activeProcess = proc;

                        break;
                    }
                }
            }
        }

        private void UpdateInfomation(Process process, bool isReset)
        {
            if (isReset)
            {
                Label_PID.Text = "PID : ";
                Label_Name.Text = "Name : ";
                Label_Path.Text = "";

                // size                
                Label_Left.Text = "Left: ";
                Label_Top.Text = "Top: ";
                Label_Width.Text = "Width : ";
                Label_Height.Text = "Height : ";
                Label_Maximize.Text = $"IsMaximize : ";
            }
            else
            {
                try
                {
                    if (process != null)
                    {
                        var info = manager.GetWindowInfo(process);

                        Label_PID.Text = $"PID : {process.Id}";
                        Label_Name.Text = $"Name : {process.ProcessName}.exe";
                        Label_Path.Text = $"{process.MainModule?.FileName}";

                        // size                
                        Label_Left.Text = $"Left : {info.Left,5}";
                        Label_Top.Text = $"Top : {info.Top,5}";
                        Label_Width.Text = $"Width : {info.Width,5}";
                        Label_Height.Text = $"Height : {info.Height,5}";
                        Label_Maximize.Text = $"IsMaximize : {info.IsMaximize}";

                        // Numeric
                        NumericUpDown_Top.Value = info.Top;
                        NumericUpDown_Left.Value = info.Left;
                        NumericUpDown_Height.Value = info.Height;
                        NumericUpDown_Width.Value = info.Width;
                    }
                }
                catch
                {
                    UpdateInfomation(process, true);
                    Label_Path.Text = "SizeFitnessを管理者権限で起動してください。";
                }
            }
        }

        private void MainForm_Move(object sender, EventArgs e) =>
            targetWindow.Location = this.PointToScreen(panel1.Location);

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (activeProcess is null)
            {
                if (ComboBox_Profile.SelectedItem is ProfileInfo info)
                {
                    info.Top = (int)NumericUpDown_Top.Value;
                    info.Left = (int)NumericUpDown_Left.Value;
                    info.Height = (int)NumericUpDown_Height.Value;
                    info.Width = (int)NumericUpDown_Width.Value;
                    info.Enable = true;
                }
            }
            else
            {
                var profile = new ProfileInfo()
                {
                    ProcessName = $"{activeProcess.ProcessName}.exe",
                    Path = activeProcess.MainModule?.FileName,
                    Top = (int)NumericUpDown_Top.Value,
                    Left = (int)NumericUpDown_Left.Value,
                    Height = (int)NumericUpDown_Height.Value,
                    Width = (int)NumericUpDown_Width.Value,
                    Enable = true
                };
                var target = setting.Profiles.FirstOrDefault(item => item.ProcessName == profile.ProcessName);

                if (target is not null)
                {
                    Utility.SetValues<ProfileInfo>(target, profile);
                }
                else
                {
                    setting.Profiles.Add(profile);
                }
            }

            // 更新
            Timer_Refresh_Tick(this, EventArgs.Empty);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (ComboBox_Profile.SelectedItem is ProfileInfo info)
                setting.Profiles.Remove(info);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) =>
            File.WriteAllText($"{Application.StartupPath}\\setting.json", JsonSerializer.Serialize(setting, new() { WriteIndented = true }));

        private void CheckBox_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (ComboBox_Profile.SelectedItem is ProfileInfo info)
            {
                if (info.Enable = CheckBox_Enable.Checked)
                {
                    // 更新
                    Timer_Refresh_Tick(this, EventArgs.Empty);
                }
            }
        }

        private void ComboBox_Profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Profile.SelectedItem is ProfileInfo info)
            {
                NumericUpDown_Top.Value = info.Top;
                NumericUpDown_Left.Value = info.Left;
                NumericUpDown_Height.Value = info.Height;
                NumericUpDown_Width.Value = info.Width;
                CheckBox_Enable.Checked = info.Enable;

                var process = manager.ProcessList?.FirstOrDefault(target => $"{target.ProcessName}.exe".Equals(info.ProcessName));

                if (process is not null)
                {
                    UpdateInfomation(process, false);
                }
            }
        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)
        {
            manager.UpdateWindowList();

            // 変更チェック

            foreach (var proc in manager.ProcessList)
            {
                var info = manager.GetWindowInfo(proc);

                var profile = setting.Profiles.FirstOrDefault(target => target.ProcessName.Equals($"{proc.ProcessName}.exe"));

                if (profile is not null && !info.IsMinimize)
                {
                    if (profile.Top == info.Top && profile.Left == info.Left && profile.Width == info.Width && profile.Height == info.Height)
                    {

                    }
                    else
                    {
                        manager.SetWindowPos(proc, profile);
                    }
                }
            }
        }
    }
}