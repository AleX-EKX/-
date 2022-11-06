namespace avtoriz
{
    partial class Exits
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_yes = new System.Windows.Forms.Button();
            this.Bt_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(121, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы точно хотите выйти?";
            // 
            // Bt_yes
            // 
            this.Bt_yes.BackColor = System.Drawing.Color.Transparent;
            this.Bt_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_yes.ForeColor = System.Drawing.Color.Lime;
            this.Bt_yes.Location = new System.Drawing.Point(12, 203);
            this.Bt_yes.Name = "Bt_yes";
            this.Bt_yes.Size = new System.Drawing.Size(166, 45);
            this.Bt_yes.TabIndex = 5;
            this.Bt_yes.Text = "Да";
            this.Bt_yes.UseVisualStyleBackColor = false;
            this.Bt_yes.Click += new System.EventHandler(this.Bt_yes_Click);
            // 
            // Bt_no
            // 
            this.Bt_no.BackColor = System.Drawing.Color.Transparent;
            this.Bt_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_no.ForeColor = System.Drawing.Color.Lime;
            this.Bt_no.Location = new System.Drawing.Point(356, 203);
            this.Bt_no.Name = "Bt_no";
            this.Bt_no.Size = new System.Drawing.Size(166, 45);
            this.Bt_no.TabIndex = 6;
            this.Bt_no.Text = "Нет";
            this.Bt_no.UseVisualStyleBackColor = false;
            this.Bt_no.Click += new System.EventHandler(this.Bt_no_Click);
            // 
            // Exits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avtoriz.Properties.Resources._1587215672_8_p_foni_dlya_prilozhenii_151;
            this.ClientSize = new System.Drawing.Size(534, 260);
            this.Controls.Add(this.Bt_no);
            this.Controls.Add(this.Bt_yes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_yes;
        private System.Windows.Forms.Button Bt_no;
    }
}