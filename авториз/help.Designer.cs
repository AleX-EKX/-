
namespace avtoriz
{
    partial class help
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.brat_btn1 = new avtoriz.brat_btn();
            this.brat_btn2 = new avtoriz.brat_btn();
            this.brat_btn3 = new avtoriz.brat_btn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::avtoriz.Properties.Resources.регистр1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 384);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(741, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 19);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // brat_btn1
            // 
            this.brat_btn1.BackColor = System.Drawing.Color.Tomato;
            this.brat_btn1.BackColorAdditional = System.Drawing.Color.Gray;
            this.brat_btn1.BackColorGradientEnabled = false;
            this.brat_btn1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.brat_btn1.BorderColor = System.Drawing.Color.Tomato;
            this.brat_btn1.BorderColorEnabled = false;
            this.brat_btn1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.brat_btn1.BorderColorOnHoverEnabled = false;
            this.brat_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brat_btn1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.brat_btn1.ForeColor = System.Drawing.Color.White;
            this.brat_btn1.Location = new System.Drawing.Point(462, 408);
            this.brat_btn1.Name = "brat_btn1";
            this.brat_btn1.RippleColor = System.Drawing.Color.Black;
            this.brat_btn1.RoundingEnable = false;
            this.brat_btn1.Size = new System.Drawing.Size(80, 30);
            this.brat_btn1.TabIndex = 3;
            this.brat_btn1.Text = "Назад";
            this.brat_btn1.TextHover = null;
            this.brat_btn1.UseDownPressEffectOnClick = false;
            this.brat_btn1.UseRippleEffect = true;
            this.brat_btn1.UseZoomEffectOnHover = false;
            this.brat_btn1.Click += new System.EventHandler(this.brat_btn1_Click);
            // 
            // brat_btn2
            // 
            this.brat_btn2.BackColor = System.Drawing.Color.Tomato;
            this.brat_btn2.BackColorAdditional = System.Drawing.Color.Gray;
            this.brat_btn2.BackColorGradientEnabled = false;
            this.brat_btn2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.brat_btn2.BorderColor = System.Drawing.Color.Tomato;
            this.brat_btn2.BorderColorEnabled = false;
            this.brat_btn2.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.brat_btn2.BorderColorOnHoverEnabled = false;
            this.brat_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brat_btn2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.brat_btn2.ForeColor = System.Drawing.Color.White;
            this.brat_btn2.Location = new System.Drawing.Point(548, 408);
            this.brat_btn2.Name = "brat_btn2";
            this.brat_btn2.RippleColor = System.Drawing.Color.Black;
            this.brat_btn2.RoundingEnable = false;
            this.brat_btn2.Size = new System.Drawing.Size(80, 30);
            this.brat_btn2.TabIndex = 4;
            this.brat_btn2.Text = "Вперед";
            this.brat_btn2.TextHover = null;
            this.brat_btn2.UseDownPressEffectOnClick = false;
            this.brat_btn2.UseRippleEffect = true;
            this.brat_btn2.UseZoomEffectOnHover = false;
            this.brat_btn2.Click += new System.EventHandler(this.brat_btn2_Click);
            // 
            // brat_btn3
            // 
            this.brat_btn3.BackColor = System.Drawing.Color.Tomato;
            this.brat_btn3.BackColorAdditional = System.Drawing.Color.Gray;
            this.brat_btn3.BackColorGradientEnabled = false;
            this.brat_btn3.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.brat_btn3.BorderColor = System.Drawing.Color.Tomato;
            this.brat_btn3.BorderColorEnabled = false;
            this.brat_btn3.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.brat_btn3.BorderColorOnHoverEnabled = false;
            this.brat_btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brat_btn3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.brat_btn3.ForeColor = System.Drawing.Color.White;
            this.brat_btn3.Location = new System.Drawing.Point(655, 12);
            this.brat_btn3.Name = "brat_btn3";
            this.brat_btn3.RippleColor = System.Drawing.Color.Black;
            this.brat_btn3.RoundingEnable = false;
            this.brat_btn3.Size = new System.Drawing.Size(80, 30);
            this.brat_btn3.TabIndex = 5;
            this.brat_btn3.Text = "На главную";
            this.brat_btn3.TextHover = null;
            this.brat_btn3.UseDownPressEffectOnClick = false;
            this.brat_btn3.UseRippleEffect = true;
            this.brat_btn3.UseZoomEffectOnHover = false;
            this.brat_btn3.Click += new System.EventHandler(this.brat_btn3_Click);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avtoriz.Properties.Resources.programming_06;
            this.ClientSize = new System.Drawing.Size(761, 536);
            this.Controls.Add(this.brat_btn3);
            this.Controls.Add(this.brat_btn2);
            this.Controls.Add(this.brat_btn1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "help";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.help_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.help_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private brat_btn brat_btn1;
        private brat_btn brat_btn2;
        private brat_btn brat_btn3;
    }
}