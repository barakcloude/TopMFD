namespace TopMFD
{
    partial class Form1
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
            button1 = new Button();
            STOP = new Button();
            SPEED = new Label();
            label1 = new Label();
            speed_value = new Label();
            ALT = new Label();
            alt_value = new Label();
            label2 = new Label();
            label3 = new Label();
            namevalue = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Chartreuse;
            button1.Location = new Point(199, 292);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 0;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // STOP
            // 
            STOP.BackColor = Color.Black;
            STOP.FlatAppearance.BorderColor = Color.Black;
            STOP.FlatAppearance.BorderSize = 0;
            STOP.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            STOP.ForeColor = Color.Chartreuse;
            STOP.Location = new Point(73, 292);
            STOP.Name = "STOP";
            STOP.Size = new Size(111, 41);
            STOP.TabIndex = 1;
            STOP.Text = "STOP";
            STOP.UseVisualStyleBackColor = false;
            STOP.Click += button2_Click;
            // 
            // SPEED
            // 
            SPEED.AutoSize = true;
            SPEED.Font = new Font("Arial", 10F, FontStyle.Bold);
            SPEED.ForeColor = Color.Chartreuse;
            SPEED.Location = new Point(12, 68);
            SPEED.Name = "SPEED";
            SPEED.Size = new Size(71, 19);
            SPEED.TabIndex = 2;
            SPEED.Text = "SPEED:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(351, 20);
            label1.TabIndex = 3;
            label1.Text = "---------------------------------------------------------";
            // 
            // speed_value
            // 
            speed_value.AutoSize = true;
            speed_value.Font = new Font("Arial", 10F, FontStyle.Bold);
            speed_value.ForeColor = Color.Chartreuse;
            speed_value.Location = new Point(78, 68);
            speed_value.Name = "speed_value";
            speed_value.Size = new Size(27, 19);
            speed_value.TabIndex = 4;
            speed_value.Text = "55";
            // 
            // ALT
            // 
            ALT.AutoSize = true;
            ALT.Font = new Font("Arial", 10F, FontStyle.Bold);
            ALT.ForeColor = Color.Chartreuse;
            ALT.Location = new Point(12, 92);
            ALT.Name = "ALT";
            ALT.Size = new Size(43, 19);
            ALT.TabIndex = 5;
            ALT.Text = "ALT:";
            // 
            // alt_value
            // 
            alt_value.AutoSize = true;
            alt_value.Font = new Font("Arial", 10F, FontStyle.Bold);
            alt_value.ForeColor = Color.Chartreuse;
            alt_value.Location = new Point(47, 92);
            alt_value.Name = "alt_value";
            alt_value.Size = new Size(36, 19);
            alt_value.TabIndex = 6;
            alt_value.Text = "200";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 7;
            label2.Text = "HEADING:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 8;
            label3.Text = "PILOT ID:";
            // 
            // namevalue
            // 
            namevalue.AutoSize = true;
            namevalue.Font = new Font("Arial", 10F, FontStyle.Bold);
            namevalue.ForeColor = Color.Chartreuse;
            namevalue.Location = new Point(102, 20);
            namevalue.Name = "namevalue";
            namevalue.Size = new Size(56, 19);
            namevalue.TabIndex = 9;
            namevalue.Text = "Guest";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Chartreuse;
            label5.Location = new Point(95, 118);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 10;
            label5.Text = "127";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Chartreuse;
            label4.Location = new Point(15, 147);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 11;
            label4.Text = "WEAPON:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Chartreuse;
            label6.Location = new Point(234, 20);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 12;
            label6.Text = "SLOT:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(383, 354);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(namevalue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(alt_value);
            Controls.Add(ALT);
            Controls.Add(speed_value);
            Controls.Add(label1);
            Controls.Add(SPEED);
            Controls.Add(STOP);
            Controls.Add(button1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "TopMFD";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button STOP;
        private Label SPEED;
        private Label label1;
        private Label speed_value;
        private Label ALT;
        private Label alt_value;
        private Label label2;
        private Label label3;
        private Label namevalue;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}
