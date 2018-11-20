namespace GestionCentre
{
    partial class AddGroupe
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
            this.id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.id.Location = new System.Drawing.Point(92, 180);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(175, 20);
            this.id.TabIndex = 83;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 118);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(296, 132);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(204, 20);
            this.search.TabIndex = 77;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Nom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(92, 226);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(175, 20);
            this.nom.TabIndex = 69;
            // 
            // clear
            // 
            this.clear.Image = global::GestionCentre.Properties.Resources.clear2;
            this.clear.Location = new System.Drawing.Point(440, 300);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clear.TabIndex = 90;
            this.clear.TabStop = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Image = global::GestionCentre.Properties.Resources.delete1;
            this.delete.Location = new System.Drawing.Point(318, 300);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 60);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 89;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Image = global::GestionCentre.Properties.Resources.edit1;
            this.edit.Location = new System.Drawing.Point(193, 300);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(60, 60);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edit.TabIndex = 88;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(201)))), ((int)(((byte)(147)))));
            this.add.Image = global::GestionCentre.Properties.Resources.addd;
            this.add.Location = new System.Drawing.Point(72, 300);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 60);
            this.add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add.TabIndex = 87;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GestionCentre.Properties.Resources.magnifier;
            this.pictureBox4.Location = new System.Drawing.Point(506, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestionCentre.Properties.Resources.grp;
            this.pictureBox7.Location = new System.Drawing.Point(22, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 88);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 85;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GestionCentre.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(509, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GestionCentre.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(540, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GestionCentre.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(201)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(569, 370);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.PictureBox add;
    }
}