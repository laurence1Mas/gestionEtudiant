namespace GestionEtudiant
{
    partial class frmprincipal
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
            this.container = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnetudiant = new System.Windows.Forms.Button();
            this.btnadresse = new System.Windows.Forms.Button();
            this.btntelephone = new System.Windows.Forms.Button();
            this.btndomicile = new System.Windows.Forms.Button();
            this.slide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 51);
            this.panel1.TabIndex = 0;
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(220, 57);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1000, 575);
            this.container.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT-MANAGE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.slide);
            this.panel3.Controls.Add(this.btndomicile);
            this.panel3.Controls.Add(this.btntelephone);
            this.panel3.Controls.Add(this.btnadresse);
            this.panel3.Controls.Add(this.btnetudiant);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 575);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionEtudiant.Properties.Resources.student_registration_60px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnetudiant
            // 
            this.btnetudiant.BackColor = System.Drawing.Color.AliceBlue;
            this.btnetudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnetudiant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnetudiant.ForeColor = System.Drawing.Color.Navy;
            this.btnetudiant.Location = new System.Drawing.Point(20, 192);
            this.btnetudiant.Name = "btnetudiant";
            this.btnetudiant.Size = new System.Drawing.Size(172, 43);
            this.btnetudiant.TabIndex = 1;
            this.btnetudiant.Text = "Etudiant";
            this.btnetudiant.UseVisualStyleBackColor = false;
            this.btnetudiant.Click += new System.EventHandler(this.btnetudiant_Click);
            // 
            // btnadresse
            // 
            this.btnadresse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnadresse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadresse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadresse.ForeColor = System.Drawing.Color.Navy;
            this.btnadresse.Location = new System.Drawing.Point(20, 266);
            this.btnadresse.Name = "btnadresse";
            this.btnadresse.Size = new System.Drawing.Size(172, 43);
            this.btnadresse.TabIndex = 2;
            this.btnadresse.Text = "Adresse";
            this.btnadresse.UseVisualStyleBackColor = false;
            this.btnadresse.Click += new System.EventHandler(this.btnadresse_Click);
            // 
            // btntelephone
            // 
            this.btntelephone.BackColor = System.Drawing.Color.AliceBlue;
            this.btntelephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntelephone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntelephone.ForeColor = System.Drawing.Color.Navy;
            this.btntelephone.Location = new System.Drawing.Point(20, 339);
            this.btntelephone.Name = "btntelephone";
            this.btntelephone.Size = new System.Drawing.Size(172, 43);
            this.btntelephone.TabIndex = 3;
            this.btntelephone.Text = "Telephone";
            this.btntelephone.UseVisualStyleBackColor = false;
            this.btntelephone.Click += new System.EventHandler(this.btntelephone_Click);
            // 
            // btndomicile
            // 
            this.btndomicile.BackColor = System.Drawing.Color.AliceBlue;
            this.btndomicile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndomicile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndomicile.ForeColor = System.Drawing.Color.Navy;
            this.btndomicile.Location = new System.Drawing.Point(20, 418);
            this.btndomicile.Name = "btndomicile";
            this.btndomicile.Size = new System.Drawing.Size(172, 43);
            this.btndomicile.TabIndex = 4;
            this.btndomicile.Text = "Domicile";
            this.btndomicile.UseVisualStyleBackColor = false;
            this.btndomicile.Click += new System.EventHandler(this.btndomicile_Click);
            // 
            // slide
            // 
            this.slide.BackColor = System.Drawing.Color.AliceBlue;
            this.slide.Location = new System.Drawing.Point(3, 192);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(11, 43);
            this.slide.TabIndex = 0;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1232, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btndomicile;
        private System.Windows.Forms.Button btntelephone;
        private System.Windows.Forms.Button btnadresse;
        private System.Windows.Forms.Button btnetudiant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel slide;
    }
}

