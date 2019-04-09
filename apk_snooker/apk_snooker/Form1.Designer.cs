namespace apk_snooker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gracz1 = new System.Windows.Forms.TextBox();
            this.gracz2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wynpart2 = new System.Windows.Forms.Label();
            this.wynpart1 = new System.Windows.Forms.Label();
            this.wyncal = new System.Windows.Forms.GroupBox();
            this.wyncal2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wyncal1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wskaznik1 = new System.Windows.Forms.PictureBox();
            this.czerwona = new System.Windows.Forms.Button();
            this.zolta = new System.Windows.Forms.Button();
            this.brazowa = new System.Windows.Forms.Button();
            this.niebieska = new System.Windows.Forms.Button();
            this.rozowa = new System.Windows.Forms.Button();
            this.zielona = new System.Windows.Forms.Button();
            this.czarna = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.wyncal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wskaznik1)).BeginInit();
            this.SuspendLayout();
            // 
            // gracz1
            // 
            this.gracz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gracz1.Location = new System.Drawing.Point(12, 35);
            this.gracz1.Name = "gracz1";
            this.gracz1.Size = new System.Drawing.Size(165, 26);
            this.gracz1.TabIndex = 0;
            // 
            // gracz2
            // 
            this.gracz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gracz2.Location = new System.Drawing.Point(409, 35);
            this.gracz2.Name = "gracz2";
            this.gracz2.Size = new System.Drawing.Size(165, 26);
            this.gracz2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gracz 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(419, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gracz 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.wynpart2);
            this.groupBox1.Controls.Add(this.wynpart1);
            this.groupBox1.Controls.Add(this.wyncal);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.wskaznik1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gracz2);
            this.groupBox1.Controls.Add(this.gracz1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // wynpart2
            // 
            this.wynpart2.AutoSize = true;
            this.wynpart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynpart2.Location = new System.Drawing.Point(332, 35);
            this.wynpart2.Name = "wynpart2";
            this.wynpart2.Size = new System.Drawing.Size(18, 20);
            this.wynpart2.TabIndex = 8;
            this.wynpart2.Text = "0";
            // 
            // wynpart1
            // 
            this.wynpart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynpart1.Location = new System.Drawing.Point(209, 35);
            this.wynpart1.Name = "wynpart1";
            this.wynpart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wynpart1.Size = new System.Drawing.Size(42, 20);
            this.wynpart1.TabIndex = 7;
            this.wynpart1.Text = "0";
            // 
            // wyncal
            // 
            this.wyncal.BackColor = System.Drawing.SystemColors.Control;
            this.wyncal.Controls.Add(this.wyncal2);
            this.wyncal.Controls.Add(this.label3);
            this.wyncal.Controls.Add(this.wyncal1);
            this.wyncal.Location = new System.Drawing.Point(257, 32);
            this.wyncal.Name = "wyncal";
            this.wyncal.Size = new System.Drawing.Size(69, 29);
            this.wyncal.TabIndex = 6;
            this.wyncal.TabStop = false;
            // 
            // wyncal2
            // 
            this.wyncal2.AutoSize = true;
            this.wyncal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyncal2.Location = new System.Drawing.Point(46, 4);
            this.wyncal2.Name = "wyncal2";
            this.wyncal2.Size = new System.Drawing.Size(18, 20);
            this.wyncal2.TabIndex = 2;
            this.wyncal2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // wyncal1
            // 
            this.wyncal1.AutoSize = true;
            this.wyncal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyncal1.Location = new System.Drawing.Point(3, 4);
            this.wyncal1.Name = "wyncal1";
            this.wyncal1.Size = new System.Drawing.Size(18, 20);
            this.wyncal1.TabIndex = 0;
            this.wyncal1.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // wskaznik1
            // 
            this.wskaznik1.Image = ((System.Drawing.Image)(resources.GetObject("wskaznik1.Image")));
            this.wskaznik1.Location = new System.Drawing.Point(183, 32);
            this.wskaznik1.Name = "wskaznik1";
            this.wskaznik1.Size = new System.Drawing.Size(29, 29);
            this.wskaznik1.TabIndex = 4;
            this.wskaznik1.TabStop = false;
            // 
            // czerwona
            // 
            this.czerwona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("czerwona.BackgroundImage")));
            this.czerwona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.czerwona.Location = new System.Drawing.Point(71, 128);
            this.czerwona.Name = "czerwona";
            this.czerwona.Size = new System.Drawing.Size(120, 120);
            this.czerwona.TabIndex = 5;
            this.czerwona.UseVisualStyleBackColor = true;
            // 
            // zolta
            // 
            this.zolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zolta.BackgroundImage")));
            this.zolta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zolta.Location = new System.Drawing.Point(218, 128);
            this.zolta.Name = "zolta";
            this.zolta.Size = new System.Drawing.Size(120, 120);
            this.zolta.TabIndex = 6;
            this.zolta.UseVisualStyleBackColor = true;
            // 
            // brazowa
            // 
            this.brazowa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brazowa.BackgroundImage")));
            this.brazowa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brazowa.Location = new System.Drawing.Point(71, 275);
            this.brazowa.Name = "brazowa";
            this.brazowa.Size = new System.Drawing.Size(120, 120);
            this.brazowa.TabIndex = 7;
            this.brazowa.UseVisualStyleBackColor = true;
            // 
            // niebieska
            // 
            this.niebieska.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("niebieska.BackgroundImage")));
            this.niebieska.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.niebieska.Location = new System.Drawing.Point(218, 275);
            this.niebieska.Name = "niebieska";
            this.niebieska.Size = new System.Drawing.Size(120, 120);
            this.niebieska.TabIndex = 8;
            this.niebieska.UseVisualStyleBackColor = true;
            // 
            // rozowa
            // 
            this.rozowa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rozowa.BackgroundImage")));
            this.rozowa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rozowa.Location = new System.Drawing.Point(363, 275);
            this.rozowa.Name = "rozowa";
            this.rozowa.Size = new System.Drawing.Size(120, 120);
            this.rozowa.TabIndex = 9;
            this.rozowa.UseVisualStyleBackColor = true;
            // 
            // zielona
            // 
            this.zielona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zielona.BackgroundImage")));
            this.zielona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zielona.Location = new System.Drawing.Point(363, 128);
            this.zielona.Name = "zielona";
            this.zielona.Size = new System.Drawing.Size(120, 120);
            this.zielona.TabIndex = 10;
            this.zielona.UseVisualStyleBackColor = true;
            // 
            // czarna
            // 
            this.czarna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("czarna.BackgroundImage")));
            this.czarna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.czarna.Location = new System.Drawing.Point(71, 416);
            this.czarna.Name = "czarna";
            this.czarna.Size = new System.Drawing.Size(120, 120);
            this.czarna.TabIndex = 11;
            this.czarna.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(257, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wynik:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 568);
            this.Controls.Add(this.czarna);
            this.Controls.Add(this.zielona);
            this.Controls.Add(this.rozowa);
            this.Controls.Add(this.niebieska);
            this.Controls.Add(this.brazowa);
            this.Controls.Add(this.zolta);
            this.Controls.Add(this.czerwona);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Snookcount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.wyncal.ResumeLayout(false);
            this.wyncal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wskaznik1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox gracz1;
        private System.Windows.Forms.TextBox gracz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox wskaznik1;
        private System.Windows.Forms.Button czerwona;
        private System.Windows.Forms.Button zolta;
        private System.Windows.Forms.Button brazowa;
        private System.Windows.Forms.Label wynpart2;
        private System.Windows.Forms.Label wynpart1;
        private System.Windows.Forms.GroupBox wyncal;
        private System.Windows.Forms.Label wyncal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wyncal1;
        private System.Windows.Forms.Button niebieska;
        private System.Windows.Forms.Button rozowa;
        private System.Windows.Forms.Button zielona;
        private System.Windows.Forms.Button czarna;
        private System.Windows.Forms.Label label4;
    }
}

