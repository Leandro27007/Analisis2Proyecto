﻿
namespace Analisis2Proyecto
{
    partial class frmInicioUIBienvenida
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_bienvenida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageKey = "(ninguno)";
            this.label1.Location = new System.Drawing.Point(290, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Toque la pantalla  para ver el menu de servicios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Analisis2Proyecto.Properties.Resources.thomas_lefebvre__0eMNseqmYk_unsplash;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 10);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_bienvenida
            // 
            this.btn_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.btn_bienvenida.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bienvenida.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_bienvenida.Image = global::Analisis2Proyecto.Properties.Resources.click_tap_single_hand_gesture_icon_218645;
            this.btn_bienvenida.Location = new System.Drawing.Point(-3, 93);
            this.btn_bienvenida.Name = "btn_bienvenida";
            this.btn_bienvenida.Size = new System.Drawing.Size(802, 366);
            this.btn_bienvenida.TabIndex = 0;
            this.btn_bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_bienvenida.UseVisualStyleBackColor = false;
            this.btn_bienvenida.Click += new System.EventHandler(this.btn_bienvenida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Analisis2Proyecto.Properties.Resources.vecteezy_soft_blue_gradients_color_background_modern_screen_vector_13129501;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Analisis2Proyecto.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicioUIBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_bienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInicioUIBienvenida";
            this.Text = "UI Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_bienvenida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}