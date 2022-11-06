
namespace avtoriz
{
    partial class application
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
            this.usernameField = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.main_btn = new MaterialSkin.Controls.MaterialFlatButton();
            this.chislo = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.brat_btn1 = new avtoriz.brat_btn();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameField.Location = new System.Drawing.Point(135, 174);
            this.usernameField.Multiline = true;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(173, 27);
            this.usernameField.TabIndex = 7;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            this.usernameField.Enter += new System.EventHandler(this.usernameField_Enter);
            this.usernameField.Leave += new System.EventHandler(this.usernameField_Leave);
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tel.Location = new System.Drawing.Point(135, 207);
            this.tel.Multiline = true;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(173, 27);
            this.tel.TabIndex = 8;
            this.tel.Enter += new System.EventHandler(this.tel_Enter);
            this.tel.Leave += new System.EventHandler(this.tel_Leave);
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.Location = new System.Drawing.Point(135, 240);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(173, 27);
            this.mail.TabIndex = 9;
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // main_btn
            // 
            this.main_btn.AutoSize = true;
            this.main_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_btn.BackColor = System.Drawing.Color.Transparent;
            this.main_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_btn.Depth = 0;
            this.main_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.main_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.main_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.main_btn.Location = new System.Drawing.Point(249, 109);
            this.main_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.main_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.main_btn.Name = "main_btn";
            this.main_btn.Primary = false;
            this.main_btn.Size = new System.Drawing.Size(121, 36);
            this.main_btn.TabIndex = 11;
            this.main_btn.Text = "К расписанию";
            this.main_btn.UseVisualStyleBackColor = false;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // chislo
            // 
            this.chislo.AutoSize = true;
            this.chislo.BackColor = System.Drawing.Color.Transparent;
            this.chislo.Dock = System.Windows.Forms.DockStyle.Top;
            this.chislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo.ForeColor = System.Drawing.Color.Lime;
            this.chislo.Location = new System.Drawing.Point(0, 0);
            this.chislo.Name = "chislo";
            this.chislo.Size = new System.Drawing.Size(21, 24);
            this.chislo.TabIndex = 15;
            this.chislo.Text = "0";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(432, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 16;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label1_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.BackColor = System.Drawing.Color.Transparent;
            this.cena.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cena.ForeColor = System.Drawing.Color.Lime;
            this.cena.Location = new System.Drawing.Point(0, 34);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(20, 22);
            this.cena.TabIndex = 17;
            this.cena.Text = "0";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.materialFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.materialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.materialFlatButton1.Location = new System.Drawing.Point(87, 109);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(100, 36);
            this.materialFlatButton1.TabIndex = 18;
            this.materialFlatButton1.Text = "На главную";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // brat_btn1
            // 
            this.brat_btn1.BackColor = System.Drawing.Color.Tomato;
            this.brat_btn1.BackColorAdditional = System.Drawing.Color.Blue;
            this.brat_btn1.BackColorGradientEnabled = true;
            this.brat_btn1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.brat_btn1.BorderColor = System.Drawing.Color.Tomato;
            this.brat_btn1.BorderColorEnabled = true;
            this.brat_btn1.BorderColorOnHover = System.Drawing.Color.Cyan;
            this.brat_btn1.BorderColorOnHoverEnabled = true;
            this.brat_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brat_btn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.brat_btn1.ForeColor = System.Drawing.Color.White;
            this.brat_btn1.Location = new System.Drawing.Point(135, 290);
            this.brat_btn1.Name = "brat_btn1";
            this.brat_btn1.RippleColor = System.Drawing.Color.Lime;
            this.brat_btn1.RoundingEnable = false;
            this.brat_btn1.Size = new System.Drawing.Size(173, 30);
            this.brat_btn1.TabIndex = 2;
            this.brat_btn1.Text = "Отправить";
            this.brat_btn1.TextHover = "сао";
            this.brat_btn1.UseDownPressEffectOnClick = false;
            this.brat_btn1.UseRippleEffect = true;
            this.brat_btn1.UseZoomEffectOnHover = false;
            this.brat_btn1.Click += new System.EventHandler(this.brat_btn1_Click);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avtoriz.Properties.Resources._1587215672_8_p_foni_dlya_prilozhenii_15;
            this.ClientSize = new System.Drawing.Size(460, 430);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.chislo);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.brat_btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "application";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.application_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.application_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private brat_btn brat_btn1;
        private MaterialSkin.Controls.MaterialFlatButton main_btn;
        public System.Windows.Forms.Label chislo;
        private System.Windows.Forms.Label exit;
        public System.Windows.Forms.TextBox usernameField;
        public System.Windows.Forms.TextBox tel;
        public System.Windows.Forms.TextBox mail;
        public System.Windows.Forms.Label cena;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}