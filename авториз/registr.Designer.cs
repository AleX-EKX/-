
namespace avtoriz
{
    partial class registr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registr_btn = new avtoriz.brat_btn();
            this.label2 = new System.Windows.Forms.Label();
            this.usersureField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.registr_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usersureField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.PassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LogField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 450);
            this.panel1.TabIndex = 1;
            // 
            // registr_btn
            // 
            this.registr_btn.BackColor = System.Drawing.Color.Tomato;
            this.registr_btn.BackColorAdditional = System.Drawing.Color.Blue;
            this.registr_btn.BackColorGradientEnabled = true;
            this.registr_btn.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.registr_btn.BorderColor = System.Drawing.Color.Tomato;
            this.registr_btn.BorderColorEnabled = true;
            this.registr_btn.BorderColorOnHover = System.Drawing.Color.Cyan;
            this.registr_btn.BorderColorOnHoverEnabled = true;
            this.registr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registr_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registr_btn.ForeColor = System.Drawing.Color.White;
            this.registr_btn.Location = new System.Drawing.Point(164, 322);
            this.registr_btn.Name = "registr_btn";
            this.registr_btn.RippleColor = System.Drawing.Color.Lime;
            this.registr_btn.RoundingEnable = false;
            this.registr_btn.Size = new System.Drawing.Size(238, 43);
            this.registr_btn.TabIndex = 9;
            this.registr_btn.Text = "Зарегистрироваться";
            this.registr_btn.TextHover = "Войти";
            this.registr_btn.UseDownPressEffectOnClick = true;
            this.registr_btn.UseRippleEffect = false;
            this.registr_btn.UseZoomEffectOnHover = false;
            this.registr_btn.Click += new System.EventHandler(this.registr_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Авторизоваться";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usersureField
            // 
            this.usersureField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersureField.Location = new System.Drawing.Point(319, 141);
            this.usersureField.Multiline = true;
            this.usersureField.Name = "usersureField";
            this.usersureField.Size = new System.Drawing.Size(188, 41);
            this.usersureField.TabIndex = 7;
            this.usersureField.Enter += new System.EventHandler(this.usersureField_Enter);
            this.usersureField.Leave += new System.EventHandler(this.usersureField_Leave);
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameField.Location = new System.Drawing.Point(54, 141);
            this.usernameField.Multiline = true;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(188, 41);
            this.usernameField.TabIndex = 6;
            this.usernameField.Enter += new System.EventHandler(this.usernameField_Enter);
            this.usernameField.Leave += new System.EventHandler(this.usernameField_Leave);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(319, 218);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(188, 39);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::avtoriz.Properties.Resources.par;
            this.pictureBox2.Location = new System.Drawing.Point(271, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LogField
            // 
            this.LogField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogField.Location = new System.Drawing.Point(54, 218);
            this.LogField.Multiline = true;
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(188, 41);
            this.LogField.TabIndex = 2;
            this.LogField.Enter += new System.EventHandler(this.LogField_Enter);
            this.LogField.Leave += new System.EventHandler(this.LogField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::avtoriz.Properties.Resources.pol;
            this.pictureBox1.Location = new System.Drawing.Point(6, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.closelabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 100);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // closelabel
            // 
            this.closelabel.AutoSize = true;
            this.closelabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closelabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closelabel.Location = new System.Drawing.Point(524, 0);
            this.closelabel.Name = "closelabel";
            this.closelabel.Size = new System.Drawing.Size(30, 29);
            this.closelabel.TabIndex = 1;
            this.closelabel.Text = "X";
            this.closelabel.Click += new System.EventHandler(this.closelabel_Click);
            this.closelabel.MouseEnter += new System.EventHandler(this.closelabel_MouseEnter);
            this.closelabel.MouseLeave += new System.EventHandler(this.closelabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LogField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usersureField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label2;
        private brat_btn registr_btn;
    }
}