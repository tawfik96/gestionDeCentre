namespace GestionCentre
{
    partial class Formation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Professeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nom ";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(147, 207);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(175, 20);
            this.nom.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 171);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(385, 109);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(305, 20);
            this.search.TabIndex = 43;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "ID";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.id.Location = new System.Drawing.Point(147, 165);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(175, 20);
            this.id.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionCentre.Properties.Resources.magnifier;
            this.pictureBox4.Location = new System.Drawing.Point(696, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            // 
            // clear
            // 
            this.clear.Image = global::GestionCentre.Properties.Resources.clear2;
            this.clear.Location = new System.Drawing.Point(600, 356);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clear.TabIndex = 56;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // delete
            // 
            this.delete.Image = global::GestionCentre.Properties.Resources.delete1;
            this.delete.Location = new System.Drawing.Point(434, 356);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 60);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 55;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Image = global::GestionCentre.Properties.Resources.edit1;
            this.edit.Location = new System.Drawing.Point(272, 356);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(60, 60);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edit.TabIndex = 54;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(201)))), ((int)(((byte)(147)))));
            this.add.Image = global::GestionCentre.Properties.Resources.addd;
            this.add.Location = new System.Drawing.Point(127, 356);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 60);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add.TabIndex = 53;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GestionCentre.Properties.Resources.formation;
            this.pictureBox6.Location = new System.Drawing.Point(38, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GestionCentre.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(728, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GestionCentre.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(759, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GestionCentre.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(350, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(201)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formation";
            this.Load += new System.EventHandler(this.Formation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}