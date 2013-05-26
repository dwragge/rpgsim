namespace rpgsim
{
    public partial class OptionsDialog
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
            this.Random_Button = new System.Windows.Forms.Button();
            this.RunSim_Button = new System.Windows.Forms.Button();
            this.hpUnit1_Text = new System.Windows.Forms.TextBox();
            this.HpUnit1_Label = new System.Windows.Forms.Label();
            this.strUnit1_Label = new System.Windows.Forms.Label();
            this.strUnit1_Text = new System.Windows.Forms.TextBox();
            this.speedUnit1_Label = new System.Windows.Forms.Label();
            this.speedUnit1_Text = new System.Windows.Forms.TextBox();
            this.rangeUnit1_Label = new System.Windows.Forms.Label();
            this.rangeUnit1_Text = new System.Windows.Forms.TextBox();
            this.Unit1_Label = new System.Windows.Forms.Label();
            this.hpUnit2_Text = new System.Windows.Forms.TextBox();
            this.hpUnit2_Label = new System.Windows.Forms.Label();
            this.strUnit2_Label = new System.Windows.Forms.Label();
            this.strUnit2_Text = new System.Windows.Forms.TextBox();
            this.speedUnit2_Label = new System.Windows.Forms.Label();
            this.speedUnit2_Text = new System.Windows.Forms.TextBox();
            this.range_Unit2_Label = new System.Windows.Forms.Label();
            this.rangeUnit2_Text = new System.Windows.Forms.TextBox();
            this.Unit2_Label = new System.Windows.Forms.Label();
            this.Unit1_Team = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Unit2_Team = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x_Unit1_Text = new System.Windows.Forms.TextBox();
            this.x_Unit2_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.y_Unit1_Text = new System.Windows.Forms.TextBox();
            this.y_Unit2_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Random_Button
            // 
            this.Random_Button.Location = new System.Drawing.Point(68, 241);
            this.Random_Button.Name = "Random_Button";
            this.Random_Button.Size = new System.Drawing.Size(100, 25);
            this.Random_Button.TabIndex = 0;
            this.Random_Button.Text = "Random Values";
            this.Random_Button.UseVisualStyleBackColor = true;
            this.Random_Button.Click += new System.EventHandler(this.Random_Button_Click);
            // 
            // RunSim_Button
            // 
            this.RunSim_Button.Location = new System.Drawing.Point(174, 241);
            this.RunSim_Button.Name = "RunSim_Button";
            this.RunSim_Button.Size = new System.Drawing.Size(100, 25);
            this.RunSim_Button.TabIndex = 1;
            this.RunSim_Button.Text = "Run Simulation";
            this.RunSim_Button.UseVisualStyleBackColor = true;
            this.RunSim_Button.Click += new System.EventHandler(this.RunSim_Button_Click);
            // 
            // hpUnit1_Text
            // 
            this.hpUnit1_Text.Location = new System.Drawing.Point(68, 50);
            this.hpUnit1_Text.Name = "hpUnit1_Text";
            this.hpUnit1_Text.Size = new System.Drawing.Size(54, 20);
            this.hpUnit1_Text.TabIndex = 3;
            this.hpUnit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.hpUnit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HP_Text_KeyPress);
            // 
            // HpUnit1_Label
            // 
            this.HpUnit1_Label.AutoSize = true;
            this.HpUnit1_Label.Location = new System.Drawing.Point(11, 53);
            this.HpUnit1_Label.Name = "HpUnit1_Label";
            this.HpUnit1_Label.Size = new System.Drawing.Size(41, 13);
            this.HpUnit1_Label.TabIndex = 4;
            this.HpUnit1_Label.Text = "Health:";
            // 
            // strUnit1_Label
            // 
            this.strUnit1_Label.AutoSize = true;
            this.strUnit1_Label.Location = new System.Drawing.Point(11, 79);
            this.strUnit1_Label.Name = "strUnit1_Label";
            this.strUnit1_Label.Size = new System.Drawing.Size(50, 13);
            this.strUnit1_Label.TabIndex = 5;
            this.strUnit1_Label.Text = "Strength:";
            // 
            // strUnit1_Text
            // 
            this.strUnit1_Text.Location = new System.Drawing.Point(68, 76);
            this.strUnit1_Text.Name = "strUnit1_Text";
            this.strUnit1_Text.Size = new System.Drawing.Size(54, 20);
            this.strUnit1_Text.TabIndex = 6;
            this.strUnit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.strUnit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Str_Text_KeyPress);
            // 
            // speedUnit1_Label
            // 
            this.speedUnit1_Label.AutoSize = true;
            this.speedUnit1_Label.Location = new System.Drawing.Point(11, 106);
            this.speedUnit1_Label.Name = "speedUnit1_Label";
            this.speedUnit1_Label.Size = new System.Drawing.Size(41, 13);
            this.speedUnit1_Label.TabIndex = 7;
            this.speedUnit1_Label.Text = "Speed:";
            // 
            // speedUnit1_Text
            // 
            this.speedUnit1_Text.Location = new System.Drawing.Point(68, 103);
            this.speedUnit1_Text.Name = "speedUnit1_Text";
            this.speedUnit1_Text.Size = new System.Drawing.Size(54, 20);
            this.speedUnit1_Text.TabIndex = 8;
            this.speedUnit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.speedUnit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Speed_Text_KeyPress);
            // 
            // rangeUnit1_Label
            // 
            this.rangeUnit1_Label.AutoSize = true;
            this.rangeUnit1_Label.Location = new System.Drawing.Point(11, 133);
            this.rangeUnit1_Label.Name = "rangeUnit1_Label";
            this.rangeUnit1_Label.Size = new System.Drawing.Size(42, 13);
            this.rangeUnit1_Label.TabIndex = 9;
            this.rangeUnit1_Label.Text = "Range:";
            // 
            // rangeUnit1_Text
            // 
            this.rangeUnit1_Text.Location = new System.Drawing.Point(68, 130);
            this.rangeUnit1_Text.Name = "rangeUnit1_Text";
            this.rangeUnit1_Text.Size = new System.Drawing.Size(54, 20);
            this.rangeUnit1_Text.TabIndex = 10;
            this.rangeUnit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.rangeUnit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Range_Text_KeyPress);
            // 
            // Unit1_Label
            // 
            this.Unit1_Label.AutoSize = true;
            this.Unit1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit1_Label.Location = new System.Drawing.Point(46, 9);
            this.Unit1_Label.Name = "Unit1_Label";
            this.Unit1_Label.Size = new System.Drawing.Size(62, 25);
            this.Unit1_Label.TabIndex = 12;
            this.Unit1_Label.Text = "Unit 1";
            // 
            // hpUnit2_Text
            // 
            this.hpUnit2_Text.Location = new System.Drawing.Point(253, 50);
            this.hpUnit2_Text.Name = "hpUnit2_Text";
            this.hpUnit2_Text.Size = new System.Drawing.Size(54, 20);
            this.hpUnit2_Text.TabIndex = 3;
            this.hpUnit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.hpUnit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HP_Text_KeyPress);
            // 
            // hpUnit2_Label
            // 
            this.hpUnit2_Label.AutoSize = true;
            this.hpUnit2_Label.Location = new System.Drawing.Point(196, 53);
            this.hpUnit2_Label.Name = "hpUnit2_Label";
            this.hpUnit2_Label.Size = new System.Drawing.Size(41, 13);
            this.hpUnit2_Label.TabIndex = 4;
            this.hpUnit2_Label.Text = "Health:";
            // 
            // strUnit2_Label
            // 
            this.strUnit2_Label.AutoSize = true;
            this.strUnit2_Label.Location = new System.Drawing.Point(196, 79);
            this.strUnit2_Label.Name = "strUnit2_Label";
            this.strUnit2_Label.Size = new System.Drawing.Size(50, 13);
            this.strUnit2_Label.TabIndex = 5;
            this.strUnit2_Label.Text = "Strength:";
            // 
            // strUnit2_Text
            // 
            this.strUnit2_Text.Location = new System.Drawing.Point(253, 76);
            this.strUnit2_Text.Name = "strUnit2_Text";
            this.strUnit2_Text.Size = new System.Drawing.Size(54, 20);
            this.strUnit2_Text.TabIndex = 6;
            this.strUnit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.strUnit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Str_Text_KeyPress);
            // 
            // speedUnit2_Label
            // 
            this.speedUnit2_Label.AutoSize = true;
            this.speedUnit2_Label.Location = new System.Drawing.Point(196, 106);
            this.speedUnit2_Label.Name = "speedUnit2_Label";
            this.speedUnit2_Label.Size = new System.Drawing.Size(41, 13);
            this.speedUnit2_Label.TabIndex = 7;
            this.speedUnit2_Label.Text = "Speed:";
            // 
            // speedUnit2_Text
            // 
            this.speedUnit2_Text.Location = new System.Drawing.Point(253, 103);
            this.speedUnit2_Text.Name = "speedUnit2_Text";
            this.speedUnit2_Text.Size = new System.Drawing.Size(54, 20);
            this.speedUnit2_Text.TabIndex = 8;
            this.speedUnit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.speedUnit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Speed_Text_KeyPress);
            // 
            // range_Unit2_Label
            // 
            this.range_Unit2_Label.AutoSize = true;
            this.range_Unit2_Label.Location = new System.Drawing.Point(196, 133);
            this.range_Unit2_Label.Name = "range_Unit2_Label";
            this.range_Unit2_Label.Size = new System.Drawing.Size(42, 13);
            this.range_Unit2_Label.TabIndex = 9;
            this.range_Unit2_Label.Text = "Range:";
            // 
            // rangeUnit2_Text
            // 
            this.rangeUnit2_Text.Location = new System.Drawing.Point(253, 130);
            this.rangeUnit2_Text.Name = "rangeUnit2_Text";
            this.rangeUnit2_Text.Size = new System.Drawing.Size(54, 20);
            this.rangeUnit2_Text.TabIndex = 10;
            this.rangeUnit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.rangeUnit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Range_Text_KeyPress);
            // 
            // Unit2_Label
            // 
            this.Unit2_Label.AutoSize = true;
            this.Unit2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit2_Label.Location = new System.Drawing.Point(231, 9);
            this.Unit2_Label.Name = "Unit2_Label";
            this.Unit2_Label.Size = new System.Drawing.Size(62, 25);
            this.Unit2_Label.TabIndex = 12;
            this.Unit2_Label.Text = "Unit 2";
            // 
            // Unit1_Team
            // 
            this.Unit1_Team.FormattingEnabled = true;
            this.Unit1_Team.Location = new System.Drawing.Point(68, 156);
            this.Unit1_Team.Name = "Unit1_Team";
            this.Unit1_Team.Size = new System.Drawing.Size(54, 21);
            this.Unit1_Team.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Team:";
            // 
            // Unit2_Team
            // 
            this.Unit2_Team.FormattingEnabled = true;
            this.Unit2_Team.Location = new System.Drawing.Point(253, 156);
            this.Unit2_Team.Name = "Unit2_Team";
            this.Unit2_Team.Size = new System.Drawing.Size(54, 21);
            this.Unit2_Team.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Team:";
            // 
            // x_Unit1_Text
            // 
            this.x_Unit1_Text.Location = new System.Drawing.Point(68, 184);
            this.x_Unit1_Text.Name = "x_Unit1_Text";
            this.x_Unit1_Text.Size = new System.Drawing.Size(54, 20);
            this.x_Unit1_Text.TabIndex = 15;
            this.x_Unit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.x_Unit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_Text_KeyPress);
            // 
            // x_Unit2_Text
            // 
            this.x_Unit2_Text.Location = new System.Drawing.Point(253, 184);
            this.x_Unit2_Text.Name = "x_Unit2_Text";
            this.x_Unit2_Text.Size = new System.Drawing.Size(54, 20);
            this.x_Unit2_Text.TabIndex = 15;
            this.x_Unit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.x_Unit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X_Text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "X:";
            // 
            // y_Unit1_Text
            // 
            this.y_Unit1_Text.Location = new System.Drawing.Point(68, 210);
            this.y_Unit1_Text.Name = "y_Unit1_Text";
            this.y_Unit1_Text.Size = new System.Drawing.Size(54, 20);
            this.y_Unit1_Text.TabIndex = 15;
            this.y_Unit1_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.y_Unit1_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y_Text_Keypress);
            // 
            // y_Unit2_Text
            // 
            this.y_Unit2_Text.Location = new System.Drawing.Point(253, 210);
            this.y_Unit2_Text.Name = "y_Unit2_Text";
            this.y_Unit2_Text.Size = new System.Drawing.Size(54, 20);
            this.y_Unit2_Text.TabIndex = 15;
            this.y_Unit2_Text.TextChanged += new System.EventHandler(this.Text_Changed);
            this.y_Unit2_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y_Text_Keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y:";
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y_Unit2_Text);
            this.Controls.Add(this.x_Unit2_Text);
            this.Controls.Add(this.y_Unit1_Text);
            this.Controls.Add(this.x_Unit1_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unit2_Team);
            this.Controls.Add(this.Unit1_Team);
            this.Controls.Add(this.Unit2_Label);
            this.Controls.Add(this.Unit1_Label);
            this.Controls.Add(this.rangeUnit2_Text);
            this.Controls.Add(this.range_Unit2_Label);
            this.Controls.Add(this.rangeUnit1_Text);
            this.Controls.Add(this.speedUnit2_Text);
            this.Controls.Add(this.rangeUnit1_Label);
            this.Controls.Add(this.speedUnit2_Label);
            this.Controls.Add(this.speedUnit1_Text);
            this.Controls.Add(this.strUnit2_Text);
            this.Controls.Add(this.speedUnit1_Label);
            this.Controls.Add(this.strUnit2_Label);
            this.Controls.Add(this.strUnit1_Text);
            this.Controls.Add(this.hpUnit2_Label);
            this.Controls.Add(this.strUnit1_Label);
            this.Controls.Add(this.hpUnit2_Text);
            this.Controls.Add(this.HpUnit1_Label);
            this.Controls.Add(this.hpUnit1_Text);
            this.Controls.Add(this.RunSim_Button);
            this.Controls.Add(this.Random_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsDialog";
            this.Text = "Simulation Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Random_Button;
        private System.Windows.Forms.Button RunSim_Button;
        public System.Windows.Forms.TextBox hpUnit1_Text;
        private System.Windows.Forms.Label HpUnit1_Label;
        private System.Windows.Forms.Label strUnit1_Label;
        public System.Windows.Forms.TextBox strUnit1_Text;
        private System.Windows.Forms.Label speedUnit1_Label;
        public System.Windows.Forms.TextBox speedUnit1_Text;
        private System.Windows.Forms.Label rangeUnit1_Label;
        public System.Windows.Forms.TextBox rangeUnit1_Text;
        private System.Windows.Forms.Label Unit1_Label;
        public System.Windows.Forms.TextBox hpUnit2_Text;
        private System.Windows.Forms.Label hpUnit2_Label;
        private System.Windows.Forms.Label strUnit2_Label;
        public System.Windows.Forms.TextBox strUnit2_Text;
        private System.Windows.Forms.Label speedUnit2_Label;
        public System.Windows.Forms.TextBox speedUnit2_Text;
        private System.Windows.Forms.Label range_Unit2_Label;
        public System.Windows.Forms.TextBox rangeUnit2_Text;
        private System.Windows.Forms.Label Unit2_Label;
        public System.Windows.Forms.ComboBox Unit1_Team;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Unit2_Team;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox x_Unit1_Text;
        public System.Windows.Forms.TextBox x_Unit2_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox y_Unit1_Text;
        public System.Windows.Forms.TextBox y_Unit2_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}