
namespace SizeFitness
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_PID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Path = new System.Windows.Forms.Label();
            this.Timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.Label_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Top = new System.Windows.Forms.Label();
            this.Label_Left = new System.Windows.Forms.Label();
            this.Label_Width = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
            this.Label_Maximize = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumericUpDown_Left = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDown_Top = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Profile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.CheckBox_Enable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 0;
            // 
            // Label_PID
            // 
            this.Label_PID.AutoSize = true;
            this.Label_PID.Location = new System.Drawing.Point(56, 12);
            this.Label_PID.Name = "Label_PID";
            this.Label_PID.Size = new System.Drawing.Size(34, 15);
            this.Label_PID.TabIndex = 1;
            this.Label_PID.Text = "PID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path : ";
            // 
            // Label_Path
            // 
            this.Label_Path.AutoEllipsis = true;
            this.Label_Path.Location = new System.Drawing.Point(86, 29);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(330, 15);
            this.Label_Path.TabIndex = 4;
            this.Label_Path.Text = " ";
            // 
            // Timer_Refresh
            // 
            this.Timer_Refresh.Enabled = true;
            this.Timer_Refresh.Interval = 5000;
            this.Timer_Refresh.Tick += new System.EventHandler(this.Timer_Refresh_Tick);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(223, 12);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(47, 15);
            this.Label_Name.TabIndex = 5;
            this.Label_Name.Text = "Name : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 1);
            this.panel2.TabIndex = 7;
            // 
            // Label_Top
            // 
            this.Label_Top.AutoSize = true;
            this.Label_Top.Location = new System.Drawing.Point(51, 84);
            this.Label_Top.Name = "Label_Top";
            this.Label_Top.Size = new System.Drawing.Size(32, 15);
            this.Label_Top.TabIndex = 8;
            this.Label_Top.Text = "Top :";
            // 
            // Label_Left
            // 
            this.Label_Left.AutoSize = true;
            this.Label_Left.Location = new System.Drawing.Point(50, 64);
            this.Label_Left.Name = "Label_Left";
            this.Label_Left.Size = new System.Drawing.Size(33, 15);
            this.Label_Left.TabIndex = 9;
            this.Label_Left.Text = "Left :";
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(223, 64);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(45, 15);
            this.Label_Width.TabIndex = 10;
            this.Label_Width.Text = "Width :";
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(219, 84);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(49, 15);
            this.Label_Height.TabIndex = 11;
            this.Label_Height.Text = "Height :";
            // 
            // Label_Maximize
            // 
            this.Label_Maximize.AutoSize = true;
            this.Label_Maximize.Location = new System.Drawing.Point(12, 104);
            this.Label_Maximize.Name = "Label_Maximize";
            this.Label_Maximize.Size = new System.Drawing.Size(71, 15);
            this.Label_Maximize.TabIndex = 12;
            this.Label_Maximize.Text = "IsMaximize :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(12, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 1);
            this.panel3.TabIndex = 8;
            // 
            // NumericUpDown_Left
            // 
            this.NumericUpDown_Left.Location = new System.Drawing.Point(89, 139);
            this.NumericUpDown_Left.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown_Left.Name = "NumericUpDown_Left";
            this.NumericUpDown_Left.Size = new System.Drawing.Size(130, 23);
            this.NumericUpDown_Left.TabIndex = 13;
            this.NumericUpDown_Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Left :";
            // 
            // NumericUpDown_Top
            // 
            this.NumericUpDown_Top.Location = new System.Drawing.Point(89, 173);
            this.NumericUpDown_Top.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown_Top.Name = "NumericUpDown_Top";
            this.NumericUpDown_Top.Size = new System.Drawing.Size(130, 23);
            this.NumericUpDown_Top.TabIndex = 15;
            this.NumericUpDown_Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Top :";
            // 
            // NumericUpDown_Height
            // 
            this.NumericUpDown_Height.Location = new System.Drawing.Point(282, 173);
            this.NumericUpDown_Height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown_Height.Name = "NumericUpDown_Height";
            this.NumericUpDown_Height.Size = new System.Drawing.Size(130, 23);
            this.NumericUpDown_Height.TabIndex = 18;
            this.NumericUpDown_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown_Width
            // 
            this.NumericUpDown_Width.Location = new System.Drawing.Point(282, 139);
            this.NumericUpDown_Width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown_Width.Name = "NumericUpDown_Width";
            this.NumericUpDown_Width.Size = new System.Drawing.Size(130, 23);
            this.NumericUpDown_Width.TabIndex = 17;
            this.NumericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Height :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Width :";
            // 
            // ComboBox_Profile
            // 
            this.ComboBox_Profile.FormattingEnabled = true;
            this.ComboBox_Profile.Location = new System.Drawing.Point(89, 207);
            this.ComboBox_Profile.Name = "ComboBox_Profile";
            this.ComboBox_Profile.Size = new System.Drawing.Size(327, 23);
            this.ComboBox_Profile.TabIndex = 21;
            this.ComboBox_Profile.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Profile_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "プロファイル :";
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(262, 241);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 23;
            this.Button_Add.Text = "追加/変更(&A)";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(343, 241);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 24;
            this.Button_Delete.Text = "削除(&D)";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // CheckBox_Enable
            // 
            this.CheckBox_Enable.AutoSize = true;
            this.CheckBox_Enable.Checked = true;
            this.CheckBox_Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Enable.Location = new System.Drawing.Point(12, 245);
            this.CheckBox_Enable.Name = "CheckBox_Enable";
            this.CheckBox_Enable.Size = new System.Drawing.Size(62, 19);
            this.CheckBox_Enable.TabIndex = 25;
            this.CheckBox_Enable.Text = "有効化";
            this.CheckBox_Enable.UseVisualStyleBackColor = true;
            this.CheckBox_Enable.CheckedChanged += new System.EventHandler(this.CheckBox_Enable_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 276);
            this.Controls.Add(this.CheckBox_Enable);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBox_Profile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumericUpDown_Height);
            this.Controls.Add(this.NumericUpDown_Width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericUpDown_Top);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDown_Left);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Label_Maximize);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.Label_Width);
            this.Controls.Add(this.Label_Left);
            this.Controls.Add(this.Label_Top);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_PID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SizeFitness";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Move += new System.EventHandler(this.MainForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_PID;
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Timer Timer_Refresh;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label_Top;
        private System.Windows.Forms.Label Label_Left;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.Label Label_Maximize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Top;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Height;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_Profile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.CheckBox CheckBox_Enable;
    }
}

