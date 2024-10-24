using System.Drawing;
using System.Windows.Forms;

namespace quizzy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kerdes_mezo = new System.Windows.Forms.TextBox();
            this.v1_gomb = new System.Windows.Forms.Button();
            this.v2_gomb = new System.Windows.Forms.Button();
            this.v3_gomb = new System.Windows.Forms.Button();
            this.v4_gomb = new System.Windows.Forms.Button();
            this.kerdes_szamolo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.masodpercek = new System.Windows.Forms.Timer(this.components);
            this.masodperc_mutato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kerdes_mezo
            // 
            this.kerdes_mezo.BackColor = System.Drawing.Color.White;
            this.kerdes_mezo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kerdes_mezo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.kerdes_mezo.Location = new System.Drawing.Point(15, 234);
            this.kerdes_mezo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.kerdes_mezo.Name = "kerdes_mezo";
            this.kerdes_mezo.ReadOnly = true;
            this.kerdes_mezo.Size = new System.Drawing.Size(594, 32);
            this.kerdes_mezo.TabIndex = 0;
            this.kerdes_mezo.TabStop = false;
            this.kerdes_mezo.TextChanged += new System.EventHandler(this.kerdes_mezo_TextChanged);
            // 
            // v1_gomb
            // 
            this.v1_gomb.BackColor = System.Drawing.Color.Transparent;
            this.v1_gomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v1_gomb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.v1_gomb.FlatAppearance.BorderSize = 2;
            this.v1_gomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.v1_gomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v1_gomb.ForeColor = System.Drawing.Color.White;
            this.v1_gomb.Location = new System.Drawing.Point(12, 294);
            this.v1_gomb.Name = "v1_gomb";
            this.v1_gomb.Size = new System.Drawing.Size(200, 50);
            this.v1_gomb.TabIndex = 1;
            this.v1_gomb.Text = "button1";
            this.v1_gomb.UseVisualStyleBackColor = false;
            this.v1_gomb.Click += new System.EventHandler(this.v1_gomb_Click);
            // 
            // v2_gomb
            // 
            this.v2_gomb.BackColor = System.Drawing.Color.Transparent;
            this.v2_gomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v2_gomb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.v2_gomb.FlatAppearance.BorderSize = 2;
            this.v2_gomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.v2_gomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v2_gomb.ForeColor = System.Drawing.Color.White;
            this.v2_gomb.Location = new System.Drawing.Point(412, 294);
            this.v2_gomb.Name = "v2_gomb";
            this.v2_gomb.Size = new System.Drawing.Size(200, 50);
            this.v2_gomb.TabIndex = 2;
            this.v2_gomb.Text = "button2";
            this.v2_gomb.UseVisualStyleBackColor = false;
            this.v2_gomb.Click += new System.EventHandler(this.v2_gomb_Click);
            // 
            // v3_gomb
            // 
            this.v3_gomb.BackColor = System.Drawing.Color.Transparent;
            this.v3_gomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v3_gomb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.v3_gomb.FlatAppearance.BorderSize = 2;
            this.v3_gomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.v3_gomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v3_gomb.ForeColor = System.Drawing.Color.White;
            this.v3_gomb.Location = new System.Drawing.Point(12, 379);
            this.v3_gomb.Name = "v3_gomb";
            this.v3_gomb.Size = new System.Drawing.Size(200, 50);
            this.v3_gomb.TabIndex = 3;
            this.v3_gomb.Text = "button3";
            this.v3_gomb.UseVisualStyleBackColor = false;
            this.v3_gomb.Click += new System.EventHandler(this.v3_gomb_Click);
            // 
            // v4_gomb
            // 
            this.v4_gomb.BackColor = System.Drawing.Color.Transparent;
            this.v4_gomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.v4_gomb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.v4_gomb.FlatAppearance.BorderSize = 2;
            this.v4_gomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.v4_gomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v4_gomb.ForeColor = System.Drawing.Color.White;
            this.v4_gomb.Location = new System.Drawing.Point(412, 379);
            this.v4_gomb.Name = "v4_gomb";
            this.v4_gomb.Size = new System.Drawing.Size(200, 50);
            this.v4_gomb.TabIndex = 4;
            this.v4_gomb.Text = "button4";
            this.v4_gomb.UseVisualStyleBackColor = false;
            this.v4_gomb.Click += new System.EventHandler(this.v4_gomb_Click);
            // 
            // kerdes_szamolo
            // 
            this.kerdes_szamolo.BackColor = System.Drawing.Color.White;
            this.kerdes_szamolo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kerdes_szamolo.Location = new System.Drawing.Point(290, 194);
            this.kerdes_szamolo.Name = "kerdes_szamolo";
            this.kerdes_szamolo.ReadOnly = true;
            this.kerdes_szamolo.Size = new System.Drawing.Size(60, 35);
            this.kerdes_szamolo.TabIndex = 5;
            this.kerdes_szamolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kerdes_szamolo.TextChanged += new System.EventHandler(this.kerdes_szamolo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // masodpercek
            // 
            this.masodpercek.Interval = 1000;
            this.masodpercek.Tick += new System.EventHandler(this.masodpercek_Tick);
            // 
            // masodperc_mutato
            // 
            this.masodperc_mutato.AutoSize = true;
            this.masodperc_mutato.BackColor = System.Drawing.Color.Transparent;
            this.masodperc_mutato.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masodperc_mutato.ForeColor = System.Drawing.Color.Green;
            this.masodperc_mutato.Location = new System.Drawing.Point(540, 9);
            this.masodperc_mutato.Name = "masodperc_mutato";
            this.masodperc_mutato.Size = new System.Drawing.Size(72, 55);
            this.masodperc_mutato.TabIndex = 7;
            this.masodperc_mutato.Text = "20";
            this.masodperc_mutato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.masodperc_mutato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kerdes_szamolo);
            this.Controls.Add(this.v4_gomb);
            this.Controls.Add(this.v3_gomb);
            this.Controls.Add(this.v2_gomb);
            this.Controls.Add(this.v1_gomb);
            this.Controls.Add(this.kerdes_mezo);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "BKvíz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kerdes_mezo;
        private System.Windows.Forms.Button v1_gomb;
        private System.Windows.Forms.Button v2_gomb;
        private System.Windows.Forms.Button v3_gomb;
        private System.Windows.Forms.Button v4_gomb;
        private System.Windows.Forms.TextBox kerdes_szamolo;
        private PictureBox pictureBox1;
        private Timer masodpercek;
        private Label masodperc_mutato;
    }
}

