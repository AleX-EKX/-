
namespace avtoriz
{
    partial class technical_support
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
            this.otziv = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brat_btn1 = new avtoriz.brat_btn();
            this.exit = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // otziv
            // 
            this.otziv.Location = new System.Drawing.Point(156, 240);
            this.otziv.Multiline = true;
            this.otziv.Name = "otziv";
            this.otziv.Size = new System.Drawing.Size(281, 99);
            this.otziv.TabIndex = 0;
            this.otziv.Enter += new System.EventHandler(this.otziv_Enter);
            this.otziv.Leave += new System.EventHandler(this.otziv_Leave);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(156, 162);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(281, 31);
            this.email.TabIndex = 1;
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(191, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Техподдержка";
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
            this.brat_btn1.Location = new System.Drawing.Point(156, 364);
            this.brat_btn1.Name = "brat_btn1";
            this.brat_btn1.RippleColor = System.Drawing.Color.Lime;
            this.brat_btn1.RoundingEnable = false;
            this.brat_btn1.Size = new System.Drawing.Size(281, 30);
            this.brat_btn1.TabIndex = 3;
            this.brat_btn1.Text = "Отправить";
            this.brat_btn1.TextHover = "сао";
            this.brat_btn1.UseDownPressEffectOnClick = false;
            this.brat_btn1.UseRippleEffect = true;
            this.brat_btn1.UseZoomEffectOnHover = false;
            this.brat_btn1.Click += new System.EventHandler(this.brat_btn1_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(602, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 17;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
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
            this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFlatButton1.ForeColor = System.Drawing.Color.Lime;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 15);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(120, 36);
            this.materialFlatButton1.TabIndex = 18;
            this.materialFlatButton1.Text = "Главное меню";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // technical_support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avtoriz.Properties.Resources._1587215672_8_p_foni_dlya_prilozhenii_15;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.brat_btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.otziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "technical_support";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "technical_support";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.technical_support_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.technical_support_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox otziv;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private brat_btn brat_btn1;
        private System.Windows.Forms.Label exit;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}