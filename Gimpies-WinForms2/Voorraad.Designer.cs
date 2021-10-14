
namespace Gimpies_WinForms2
{
    partial class Voorraad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voorraad));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtMaat = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtKleur = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Toevoegen = new System.Windows.Forms.Button();
            this.Aanpassen = new System.Windows.Forms.Button();
            this.Verwijderen = new System.Windows.Forms.Button();
            this.Terug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Aantal = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.verkopen = new System.Windows.Forms.Button();
            this.verkopenaantallabel = new System.Windows.Forms.Label();
            this.verkopenaantal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(36, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 129);
            this.panel1.TabIndex = 2;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_user.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(12, 42);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(255, 51);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Gebruiker";
            this.lbl_user.Click += new System.EventHandler(this.Gebruiker_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(576, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 52);
            this.label7.TabIndex = 0;
            this.label7.Text = "Voorraad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(36, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(36, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kleur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(36, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prijs";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(166, 206);
            this.txtMerk.Margin = new System.Windows.Forms.Padding(4);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(208, 31);
            this.txtMerk.TabIndex = 8;
            this.txtMerk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaat
            // 
            this.txtMaat.Location = new System.Drawing.Point(166, 325);
            this.txtMaat.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaat.Name = "txtMaat";
            this.txtMaat.Size = new System.Drawing.Size(208, 31);
            this.txtMaat.TabIndex = 9;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(166, 271);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(208, 31);
            this.txtType.TabIndex = 10;
            // 
            // txtKleur
            // 
            this.txtKleur.Location = new System.Drawing.Point(166, 379);
            this.txtKleur.Margin = new System.Windows.Forms.Padding(4);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(208, 31);
            this.txtKleur.TabIndex = 11;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(166, 429);
            this.txtPrijs.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(208, 31);
            this.txtPrijs.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(940, 635);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Toevoegen
            // 
            this.Toevoegen.BackColor = System.Drawing.Color.Lime;
            this.Toevoegen.Location = new System.Drawing.Point(470, 148);
            this.Toevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(188, 42);
            this.Toevoegen.TabIndex = 15;
            this.Toevoegen.Text = "Toevoegen";
            this.Toevoegen.UseVisualStyleBackColor = false;
            this.Toevoegen.Click += new System.EventHandler(this.Toevoegen_Click);
            // 
            // Aanpassen
            // 
            this.Aanpassen.BackColor = System.Drawing.Color.Yellow;
            this.Aanpassen.Location = new System.Drawing.Point(692, 148);
            this.Aanpassen.Margin = new System.Windows.Forms.Padding(4);
            this.Aanpassen.Name = "Aanpassen";
            this.Aanpassen.Size = new System.Drawing.Size(188, 42);
            this.Aanpassen.TabIndex = 16;
            this.Aanpassen.Text = "Aanpassen";
            this.Aanpassen.UseVisualStyleBackColor = false;
            this.Aanpassen.Click += new System.EventHandler(this.Aanpassen_Click);
            // 
            // Verwijderen
            // 
            this.Verwijderen.BackColor = System.Drawing.Color.Red;
            this.Verwijderen.Location = new System.Drawing.Point(912, 148);
            this.Verwijderen.Margin = new System.Windows.Forms.Padding(4);
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.Size = new System.Drawing.Size(188, 42);
            this.Verwijderen.TabIndex = 17;
            this.Verwijderen.Text = "Verwijderen";
            this.Verwijderen.UseVisualStyleBackColor = false;
            this.Verwijderen.Click += new System.EventHandler(this.Verwijderen_Click);
            // 
            // Terug
            // 
            this.Terug.Location = new System.Drawing.Point(44, 742);
            this.Terug.Margin = new System.Windows.Forms.Padding(4);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(166, 38);
            this.Terug.TabIndex = 18;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(44, 788);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 19;
            this.button1.Text = "uitloggen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aantal
            // 
            this.Aantal.AutoSize = true;
            this.Aantal.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal.ForeColor = System.Drawing.Color.Blue;
            this.Aantal.Location = new System.Drawing.Point(36, 475);
            this.Aantal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aantal.Name = "Aantal";
            this.Aantal.Size = new System.Drawing.Size(121, 45);
            this.Aantal.TabIndex = 20;
            this.Aantal.Text = "Aantal";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(166, 481);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(4);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(208, 31);
            this.txtAantal.TabIndex = 21;
            // 
            // verkopen
            // 
            this.verkopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.verkopen.Location = new System.Drawing.Point(1129, 148);
            this.verkopen.Margin = new System.Windows.Forms.Padding(4);
            this.verkopen.Name = "verkopen";
            this.verkopen.Size = new System.Drawing.Size(188, 42);
            this.verkopen.TabIndex = 22;
            this.verkopen.Text = "Verkopen";
            this.verkopen.UseVisualStyleBackColor = false;
            this.verkopen.Click += new System.EventHandler(this.verkopen_Click);
            // 
            // verkopenaantallabel
            // 
            this.verkopenaantallabel.AutoSize = true;
            this.verkopenaantallabel.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verkopenaantallabel.ForeColor = System.Drawing.Color.Blue;
            this.verkopenaantallabel.Location = new System.Drawing.Point(13, 553);
            this.verkopenaantallabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verkopenaantallabel.Name = "verkopenaantallabel";
            this.verkopenaantallabel.Size = new System.Drawing.Size(429, 45);
            this.verkopenaantallabel.TabIndex = 23;
            this.verkopenaantallabel.Text = "Hoeveel wilt U verkopen?";
            this.verkopenaantallabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // verkopenaantal
            // 
            this.verkopenaantal.Location = new System.Drawing.Point(21, 634);
            this.verkopenaantal.Margin = new System.Windows.Forms.Padding(4);
            this.verkopenaantal.Name = "verkopenaantal";
            this.verkopenaantal.Size = new System.Drawing.Size(208, 31);
            this.verkopenaantal.TabIndex = 24;
            // 
            // Voorraad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 915);
            this.Controls.Add(this.verkopenaantal);
            this.Controls.Add(this.verkopenaantallabel);
            this.Controls.Add(this.verkopen);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.Aantal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.Verwijderen);
            this.Controls.Add(this.Aanpassen);
            this.Controls.Add(this.Toevoegen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtMaat);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Voorraad";
            this.Text = "Voorraad";
            this.Load += new System.EventHandler(this.Voorraad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtMaat;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtKleur;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Toevoegen;
        private System.Windows.Forms.Button Aanpassen;
        private System.Windows.Forms.Button Verwijderen;
        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Aantal;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button verkopen;
        private System.Windows.Forms.Label verkopenaantallabel;
        private System.Windows.Forms.TextBox verkopenaantal;
    }
}