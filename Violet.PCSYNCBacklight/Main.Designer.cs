namespace Violet.PCSYNCBacklight
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rd27inches = new System.Windows.Forms.RadioButton();
            this.grpScreenSize = new System.Windows.Forms.GroupBox();
            this.rd32inches = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_TurnOff = new System.Windows.Forms.Button();
            this.btn_TurnOn = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Yellow = new System.Windows.Forms.Button();
            this.btn_Magenta = new System.Windows.Forms.Button();
            this.btn_Cyan = new System.Windows.Forms.Button();
            this.btn_White = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btn_ColorPicker = new System.Windows.Forms.Button();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.ddlPort = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpScreenSize.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd27inches
            // 
            this.rd27inches.AutoSize = true;
            this.rd27inches.Enabled = false;
            this.rd27inches.Location = new System.Drawing.Point(18, 40);
            this.rd27inches.Name = "rd27inches";
            this.rd27inches.Size = new System.Drawing.Size(73, 17);
            this.rd27inches.TabIndex = 1;
            this.rd27inches.TabStop = true;
            this.rd27inches.Text = "27\' inches";
            this.rd27inches.UseVisualStyleBackColor = true;
            // 
            // grpScreenSize
            // 
            this.grpScreenSize.Controls.Add(this.rd32inches);
            this.grpScreenSize.Controls.Add(this.rd27inches);
            this.grpScreenSize.Location = new System.Drawing.Point(12, 24);
            this.grpScreenSize.Name = "grpScreenSize";
            this.grpScreenSize.Size = new System.Drawing.Size(193, 81);
            this.grpScreenSize.TabIndex = 3;
            this.grpScreenSize.TabStop = false;
            this.grpScreenSize.Text = "Screen Size";
            // 
            // rd32inches
            // 
            this.rd32inches.AutoSize = true;
            this.rd32inches.Enabled = false;
            this.rd32inches.Location = new System.Drawing.Point(104, 40);
            this.rd32inches.Name = "rd32inches";
            this.rd32inches.Size = new System.Drawing.Size(73, 17);
            this.rd32inches.TabIndex = 2;
            this.rd32inches.TabStop = true;
            this.rd32inches.Text = "32\' inches";
            this.rd32inches.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslInfo
            // 
            this.tslInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(39, 17);
            this.tslInfo.Text = "Ready";
            this.tslInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_TurnOff
            // 
            this.btn_TurnOff.BackColor = System.Drawing.Color.White;
            this.btn_TurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TurnOff.Location = new System.Drawing.Point(18, 102);
            this.btn_TurnOff.Name = "btn_TurnOff";
            this.btn_TurnOff.Size = new System.Drawing.Size(75, 45);
            this.btn_TurnOff.TabIndex = 0;
            this.btn_TurnOff.Text = "Turn Off";
            this.btn_TurnOff.UseVisualStyleBackColor = false;
            this.btn_TurnOff.Click += new System.EventHandler(this.btn_TurnOff_Click);
            // 
            // btn_TurnOn
            // 
            this.btn_TurnOn.BackColor = System.Drawing.Color.White;
            this.btn_TurnOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TurnOn.Location = new System.Drawing.Point(18, 37);
            this.btn_TurnOn.Name = "btn_TurnOn";
            this.btn_TurnOn.Size = new System.Drawing.Size(75, 45);
            this.btn_TurnOn.TabIndex = 6;
            this.btn_TurnOn.Text = "Turn On";
            this.btn_TurnOn.UseVisualStyleBackColor = false;
            this.btn_TurnOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Red.ForeColor = System.Drawing.Color.White;
            this.btn_Red.Location = new System.Drawing.Point(156, 35);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(75, 45);
            this.btn_Red.TabIndex = 7;
            this.btn_Red.Text = "Red";
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.Lime;
            this.btn_Green.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Green.Location = new System.Drawing.Point(256, 35);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(75, 45);
            this.btn_Green.TabIndex = 8;
            this.btn_Green.Text = "Green";
            this.btn_Green.UseVisualStyleBackColor = false;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Blue.ForeColor = System.Drawing.Color.White;
            this.btn_Blue.Location = new System.Drawing.Point(356, 35);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(75, 45);
            this.btn_Blue.TabIndex = 9;
            this.btn_Blue.Text = "Blue";
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Yellow
            // 
            this.btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Yellow.Location = new System.Drawing.Point(155, 102);
            this.btn_Yellow.Name = "btn_Yellow";
            this.btn_Yellow.Size = new System.Drawing.Size(75, 45);
            this.btn_Yellow.TabIndex = 10;
            this.btn_Yellow.Text = "Yellow";
            this.btn_Yellow.UseVisualStyleBackColor = false;
            this.btn_Yellow.Click += new System.EventHandler(this.btn_Yellow_Click);
            // 
            // btn_Magenta
            // 
            this.btn_Magenta.BackColor = System.Drawing.Color.Magenta;
            this.btn_Magenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Magenta.Location = new System.Drawing.Point(255, 102);
            this.btn_Magenta.Name = "btn_Magenta";
            this.btn_Magenta.Size = new System.Drawing.Size(75, 45);
            this.btn_Magenta.TabIndex = 11;
            this.btn_Magenta.Text = "Magenta";
            this.btn_Magenta.UseVisualStyleBackColor = false;
            this.btn_Magenta.Click += new System.EventHandler(this.btn_Magenta_Click);
            // 
            // btn_Cyan
            // 
            this.btn_Cyan.BackColor = System.Drawing.Color.Cyan;
            this.btn_Cyan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cyan.Location = new System.Drawing.Point(356, 102);
            this.btn_Cyan.Name = "btn_Cyan";
            this.btn_Cyan.Size = new System.Drawing.Size(75, 45);
            this.btn_Cyan.TabIndex = 12;
            this.btn_Cyan.Text = "Cyan";
            this.btn_Cyan.UseVisualStyleBackColor = false;
            this.btn_Cyan.Click += new System.EventHandler(this.btn_Cyan_Click);
            // 
            // btn_White
            // 
            this.btn_White.BackColor = System.Drawing.Color.White;
            this.btn_White.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_White.Location = new System.Drawing.Point(256, 166);
            this.btn_White.Name = "btn_White";
            this.btn_White.Size = new System.Drawing.Size(75, 45);
            this.btn_White.TabIndex = 13;
            this.btn_White.Text = "White";
            this.btn_White.UseVisualStyleBackColor = false;
            this.btn_White.Click += new System.EventHandler(this.btn_White_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btn_ColorPicker);
            this.pnlActions.Controls.Add(this.btn_White);
            this.pnlActions.Controls.Add(this.btn_Cyan);
            this.pnlActions.Controls.Add(this.btn_Magenta);
            this.pnlActions.Controls.Add(this.btn_Yellow);
            this.pnlActions.Controls.Add(this.btn_Blue);
            this.pnlActions.Controls.Add(this.btn_Green);
            this.pnlActions.Controls.Add(this.btn_Red);
            this.pnlActions.Controls.Add(this.btn_TurnOn);
            this.pnlActions.Controls.Add(this.btn_TurnOff);
            this.pnlActions.Location = new System.Drawing.Point(12, 130);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(462, 247);
            this.pnlActions.TabIndex = 4;
            // 
            // btn_ColorPicker
            // 
            this.btn_ColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("btn_ColorPicker.Image")));
            this.btn_ColorPicker.Location = new System.Drawing.Point(371, 166);
            this.btn_ColorPicker.Name = "btn_ColorPicker";
            this.btn_ColorPicker.Size = new System.Drawing.Size(47, 45);
            this.btn_ColorPicker.TabIndex = 14;
            this.btn_ColorPicker.UseVisualStyleBackColor = true;
            this.btn_ColorPicker.Click += new System.EventHandler(this.btn_ColorPicker_Click);
            // 
            // grpPort
            // 
            this.grpPort.Controls.Add(this.ddlPort);
            this.grpPort.Location = new System.Drawing.Point(279, 24);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(193, 81);
            this.grpPort.TabIndex = 4;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "Port";
            // 
            // ddlPort
            // 
            this.ddlPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPort.FormattingEnabled = true;
            this.ddlPort.Location = new System.Drawing.Point(20, 36);
            this.ddlPort.Name = "ddlPort";
            this.ddlPort.Size = new System.Drawing.Size(157, 21);
            this.ddlPort.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 427);
            this.Controls.Add(this.grpPort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.grpScreenSize);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpScreenSize.ResumeLayout(false);
            this.grpScreenSize.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.grpPort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd27inches;
        private System.Windows.Forms.RadioButton rd32inches;
        private System.Windows.Forms.GroupBox grpScreenSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslInfo;
        private System.Windows.Forms.Button btn_TurnOff;
        private System.Windows.Forms.Button btn_TurnOn;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Yellow;
        private System.Windows.Forms.Button btn_Magenta;
        private System.Windows.Forms.Button btn_Cyan;
        private System.Windows.Forms.Button btn_White;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.ComboBox ddlPort;
        private System.Windows.Forms.Button btn_ColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}