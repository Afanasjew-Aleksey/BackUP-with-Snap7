﻿namespace Project_1._3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextError = new System.Windows.Forms.TextBox();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Read = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtDump = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtSlot = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtRack = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TxtList = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.Text = "Выберете блок данных";
            // 
            // TextError
            // 
            this.TextError.BackColor = System.Drawing.Color.White;
            this.TextError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextError.ForeColor = System.Drawing.Color.Black;
            this.TextError.Location = new System.Drawing.Point(0, 428);
            this.TextError.Margin = new System.Windows.Forms.Padding(4);
            this.TextError.Name = "TextError";
            this.TextError.ReadOnly = true;
            this.TextError.Size = new System.Drawing.Size(965, 22);
            this.TextError.TabIndex = 77;
            // 
            // TxtDB
            // 
            this.TxtDB.Enabled = false;
            this.TxtDB.Location = new System.Drawing.Point(465, 163);
            this.TxtDB.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(59, 22);
            this.TxtDB.TabIndex = 76;
            this.TxtDB.Text = "1";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(600, 48);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(104, 17);
            this.Label11.TabIndex = 75;
            this.Label11.Text = "Rack=0, Slot=0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(600, 32);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 17);
            this.Label10.TabIndex = 74;
            this.Label10.Text = "See HW Config";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(600, 16);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(104, 17);
            this.Label9.TabIndex = 73;
            this.Label9.Text = "Rack=0, Slot=2";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(490, 32);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(95, 17);
            this.Label8.TabIndex = 72;
            this.Label8.Text = "S7400/WinAC";
            // 
            // Read
            // 
            this.Read.Enabled = false;
            this.Read.Location = new System.Drawing.Point(16, 112);
            this.Read.Margin = new System.Windows.Forms.Padding(4);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(129, 28);
            this.Read.TabIndex = 71;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(532, 163);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(84, 17);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "Size (Bytes)";
            // 
            // TxtSize
            // 
            this.TxtSize.Enabled = false;
            this.TxtSize.Location = new System.Drawing.Point(623, 159);
            this.TxtSize.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(59, 22);
            this.TxtSize.TabIndex = 65;
            this.TxtSize.Text = "32";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(430, 163);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(27, 17);
            this.Label6.TabIndex = 69;
            this.Label6.Text = "DB";
            // 
            // TxtDump
            // 
            this.TxtDump.BackColor = System.Drawing.Color.White;
            this.TxtDump.Enabled = false;
            this.TxtDump.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDump.ForeColor = System.Drawing.Color.Black;
            this.TxtDump.Location = new System.Drawing.Point(316, 193);
            this.TxtDump.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDump.Multiline = true;
            this.TxtDump.Name = "TxtDump";
            this.TxtDump.ReadOnly = true;
            this.TxtDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDump.Size = new System.Drawing.Size(616, 227);
            this.TxtDump.TabIndex = 68;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(490, 48);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 17);
            this.Label5.TabIndex = 67;
            this.Label5.Text = "S71200/1500";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "S7300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "label4";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(316, 40);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(133, 28);
            this.DisconnectBtn.TabIndex = 63;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(316, 8);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(133, 28);
            this.ConnectBtn.TabIndex = 60;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(234, 5);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 17);
            this.Label3.TabIndex = 62;
            this.Label3.Text = "Slot";
            // 
            // TxtSlot
            // 
            this.TxtSlot.Location = new System.Drawing.Point(234, 27);
            this.TxtSlot.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSlot.Name = "TxtSlot";
            this.TxtSlot.Size = new System.Drawing.Size(57, 22);
            this.TxtSlot.TabIndex = 59;
            this.TxtSlot.Text = "2";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(160, 5);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 17);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Rack";
            // 
            // TxtRack
            // 
            this.TxtRack.Location = new System.Drawing.Point(160, 27);
            this.TxtRack.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRack.Name = "TxtRack";
            this.TxtRack.Size = new System.Drawing.Size(57, 22);
            this.TxtRack.TabIndex = 57;
            this.TxtRack.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 5);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 17);
            this.Label1.TabIndex = 58;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(13, 27);
            this.TxtIP.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(132, 22);
            this.TxtIP.TabIndex = 56;
            this.TxtIP.Text = "192.168.0.12";
            // 
            // TxtList
            // 
            this.TxtList.BackColor = System.Drawing.Color.White;
            this.TxtList.Enabled = false;
            this.TxtList.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtList.ForeColor = System.Drawing.Color.Black;
            this.TxtList.Location = new System.Drawing.Point(16, 159);
            this.TxtList.Margin = new System.Windows.Forms.Padding(4);
            this.TxtList.Multiline = true;
            this.TxtList.Name = "TxtList";
            this.TxtList.ReadOnly = true;
            this.TxtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtList.Size = new System.Drawing.Size(236, 219);
            this.TxtList.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextError);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtDump);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtSlot);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtRack);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox TextError;
        internal System.Windows.Forms.TextBox TxtDB;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button Read;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TxtSize;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtDump;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtSlot;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtRack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        internal System.Windows.Forms.TextBox TxtList;
        private System.Windows.Forms.Button button1;
    }
}

