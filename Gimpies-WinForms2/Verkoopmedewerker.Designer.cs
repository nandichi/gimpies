
using System;

namespace Gimpies_WinForms2
{
    partial class Verkoopmedewerker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verkoopmedewerker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Uitloggen = new System.Windows.Forms.Button();
            this.Voorraadschoenenbekijken = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verkoopmedewerker";
            // 
            // Uitloggen
            // 
            this.Uitloggen.Location = new System.Drawing.Point(292, 337);
            this.Uitloggen.Margin = new System.Windows.Forms.Padding(4);
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(188, 63);
            this.Uitloggen.TabIndex = 3;
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.UseVisualStyleBackColor = true;
            this.Uitloggen.Click += new System.EventHandler(this.Uitloggen_Click);
            // 
            // Voorraadschoenenbekijken
            // 
            this.Voorraadschoenenbekijken.Font = new System.Drawing.Font("Verdana", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voorraadschoenenbekijken.Location = new System.Drawing.Point(12, 140);
            this.Voorraadschoenenbekijken.Margin = new System.Windows.Forms.Padding(4);
            this.Voorraadschoenenbekijken.Name = "Voorraadschoenenbekijken";
            this.Voorraadschoenenbekijken.Size = new System.Drawing.Size(756, 173);
            this.Voorraadschoenenbekijken.TabIndex = 1;
            this.Voorraadschoenenbekijken.Text = "Voorraad schoenen bekijken en Schoenen verkopen";
            this.Voorraadschoenenbekijken.UseVisualStyleBackColor = true;
            this.Voorraadschoenenbekijken.Click += new System.EventHandler(this.Voorraadschoenenbekijken_Click);
            // 
            // Verkoopmedewerker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 427);
            this.Controls.Add(this.Uitloggen);
            this.Controls.Add(this.Voorraadschoenenbekijken);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Verkoopmedewerker";
            this.Text = "Verkoopmedewerker";
            this.Load += new System.EventHandler(this.Verkoopmedewerker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Uitloggen;
        private System.Windows.Forms.Button Voorraadschoenenbekijken;
    }
}