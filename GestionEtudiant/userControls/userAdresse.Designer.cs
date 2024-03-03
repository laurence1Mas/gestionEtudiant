namespace GestionEtudiant.userControls
{
    partial class userAdresse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtville = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcommune = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquartier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgadresse = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquartier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcommune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbsgbd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgadresse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(547, 15);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(65, 27);
            this.txtcode.TabIndex = 12;
            this.txtcode.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Location = new System.Drawing.Point(794, 281);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(126, 38);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(191, 290);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(227, 29);
            this.txtsearch.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(124, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "search";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(33, 189);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 44);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DarkRed;
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(33, 103);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(129, 44);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Navy;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(33, 32);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(129, 44);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpays
            // 
            this.txtpays.Location = new System.Drawing.Point(309, 175);
            this.txtpays.Multiline = true;
            this.txtpays.Name = "txtpays";
            this.txtpays.Size = new System.Drawing.Size(227, 40);
            this.txtpays.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pays";
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(309, 83);
            this.txtville.Multiline = true;
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(227, 40);
            this.txtville.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ville";
            // 
            // txtcommune
            // 
            this.txtcommune.Location = new System.Drawing.Point(26, 175);
            this.txtcommune.Multiline = true;
            this.txtcommune.Name = "txtcommune";
            this.txtcommune.Size = new System.Drawing.Size(227, 40);
            this.txtcommune.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commune";
            // 
            // txtquartier
            // 
            this.txtquartier.Location = new System.Drawing.Point(26, 83);
            this.txtquartier.Multiline = true;
            this.txtquartier.Name = "txtquartier";
            this.txtquartier.Size = new System.Drawing.Size(227, 40);
            this.txtquartier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quartier";
            // 
            // dgadresse
            // 
            this.dgadresse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgadresse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgadresse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgadresse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadresse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgquartier,
            this.dgcommune,
            this.dgville,
            this.dgpays});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgadresse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgadresse.Location = new System.Drawing.Point(32, 322);
            this.dgadresse.Name = "dgadresse";
            this.dgadresse.Size = new System.Drawing.Size(937, 231);
            this.dgadresse.TabIndex = 10;
            this.dgadresse.DoubleClick += new System.EventHandler(this.dgadresse_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "id";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgquartier
            // 
            this.dgquartier.DataPropertyName = "quartier";
            this.dgquartier.HeaderText = "quartier";
            this.dgquartier.Name = "dgquartier";
            // 
            // dgcommune
            // 
            this.dgcommune.DataPropertyName = "commune";
            this.dgcommune.HeaderText = "commune";
            this.dgcommune.Name = "dgcommune";
            // 
            // dgville
            // 
            this.dgville.DataPropertyName = "ville";
            this.dgville.HeaderText = "ville";
            this.dgville.Name = "dgville";
            // 
            // dgpays
            // 
            this.dgpays.DataPropertyName = "pays";
            this.dgpays.HeaderText = "pays";
            this.dgpays.Name = "dgpays";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(758, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 253);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Params";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsgbd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtpays);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtville);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcommune);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtquartier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 253);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            // 
            // cmbsgbd
            // 
            this.cmbsgbd.FormattingEnabled = true;
            this.cmbsgbd.Items.AddRange(new object[] {
            "Sql_server",
            "Mysql",
            "PostgreSQL"});
            this.cmbsgbd.Location = new System.Drawing.Point(560, 83);
            this.cmbsgbd.Name = "cmbsgbd";
            this.cmbsgbd.Size = new System.Drawing.Size(154, 27);
            this.cmbsgbd.TabIndex = 14;
            this.cmbsgbd.SelectedIndexChanged += new System.EventHandler(this.cmbsgbd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "sgbd";
            // 
            // userAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgadresse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "userAdresse";
            this.Size = new System.Drawing.Size(1000, 575);
            this.Load += new System.EventHandler(this.userAdresse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadresse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtpays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcommune;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquartier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgadresse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquartier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcommune;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgville;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpays;
        private System.Windows.Forms.ComboBox cmbsgbd;
        private System.Windows.Forms.Label label4;
    }
}
