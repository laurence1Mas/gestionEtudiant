namespace GestionEtudiant.userControls
{
    partial class userTelephone
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
            this.dgtelephone = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbproprietaire = new System.Windows.Forms.ComboBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinitial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbsgbd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgproprietaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dginitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtelephone)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtelephone
            // 
            this.dgtelephone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtelephone.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtelephone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtelephone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtelephone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgproprietaire,
            this.dginitial,
            this.dgnumero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtelephone.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtelephone.Location = new System.Drawing.Point(32, 322);
            this.dgtelephone.Name = "dgtelephone";
            this.dgtelephone.Size = new System.Drawing.Size(937, 231);
            this.dgtelephone.TabIndex = 16;
            this.dgtelephone.DoubleClick += new System.EventHandler(this.dgtelephone_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(728, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 253);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Params";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsgbd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbproprietaire);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtinitial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(79, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification";
            // 
            // cmbproprietaire
            // 
            this.cmbproprietaire.FormattingEnabled = true;
            this.cmbproprietaire.Location = new System.Drawing.Point(66, 89);
            this.cmbproprietaire.Name = "cmbproprietaire";
            this.cmbproprietaire.Size = new System.Drawing.Size(227, 27);
            this.cmbproprietaire.TabIndex = 13;
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
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(349, 89);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(227, 27);
            this.txtnumero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero";
            // 
            // txtinitial
            // 
            this.txtinitial.Location = new System.Drawing.Point(66, 169);
            this.txtinitial.Multiline = true;
            this.txtinitial.Name = "txtinitial";
            this.txtinitial.Size = new System.Drawing.Size(227, 29);
            this.txtinitial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proprietaire";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Location = new System.Drawing.Point(794, 281);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(110, 38);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(191, 290);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(227, 29);
            this.txtsearch.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(124, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "search";
            // 
            // cmbsgbd
            // 
            this.cmbsgbd.FormattingEnabled = true;
            this.cmbsgbd.Items.AddRange(new object[] {
            "Sql_server",
            "Mysql",
            "PostgreSQL"});
            this.cmbsgbd.Location = new System.Drawing.Point(338, 169);
            this.cmbsgbd.Name = "cmbsgbd";
            this.cmbsgbd.Size = new System.Drawing.Size(238, 27);
            this.cmbsgbd.TabIndex = 18;
            this.cmbsgbd.SelectedIndexChanged += new System.EventHandler(this.cmbsgbd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "sgbd";
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "id";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgproprietaire
            // 
            this.dgproprietaire.DataPropertyName = "id_proprietaire";
            this.dgproprietaire.HeaderText = "proprietaire";
            this.dgproprietaire.Name = "dgproprietaire";
            // 
            // dginitial
            // 
            this.dginitial.DataPropertyName = "initial";
            this.dginitial.HeaderText = "Initial";
            this.dginitial.Name = "dginitial";
            // 
            // dgnumero
            // 
            this.dgnumero.DataPropertyName = "numero";
            this.dgnumero.HeaderText = "numero";
            this.dgnumero.Name = "dgnumero";
            // 
            // userTelephone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.dgtelephone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Name = "userTelephone";
            this.Size = new System.Drawing.Size(1000, 575);
            this.Load += new System.EventHandler(this.userTelephone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtelephone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgtelephone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinitial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbproprietaire;
        private System.Windows.Forms.ComboBox cmbsgbd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgproprietaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dginitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnumero;
    }
}
