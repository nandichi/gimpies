
namespace GImpies_Winforms
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
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.gebruikersnaam = new JMaterialTextbox.JMaterialTextbox();
            this.wachtwoord = new JMaterialTextbox.JMaterialTextbox();
            this.loginbutton = new FlatButton.JFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            //this.jDragControl1.GetForm = null;
            //this.jDragControl1.TargetControl = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 77);
            this.panel1.TabIndex = 0;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(147, 27);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(87, 25);
            this.text.TabIndex = 0;
            this.text.Text = "Log In";
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // gebruikersnaam
            // 
            this.gebruikersnaam.BackColor = System.Drawing.Color.Transparent;
            this.gebruikersnaam.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gebruikersnaam.ForeColors = System.Drawing.Color.Black;
            this.gebruikersnaam.HintText = null;
            this.gebruikersnaam.IsPassword = false;
            this.gebruikersnaam.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gebruikersnaam.LineThickness = 2;
            this.gebruikersnaam.Location = new System.Drawing.Point(71, 123);
            this.gebruikersnaam.MaxLength = 32767;
            this.gebruikersnaam.Name = "gebruikersnaam";
            this.gebruikersnaam.OnFocusedColor = System.Drawing.Color.Black;
            this.gebruikersnaam.OnFocusedTextColor = System.Drawing.Color.Black;
            this.gebruikersnaam.ReadOnly = false;
            this.gebruikersnaam.Size = new System.Drawing.Size(244, 23);
            this.gebruikersnaam.TabIndex = 1;
            this.gebruikersnaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gebruikersnaam.TextName = "gebruikersnaam";
            // 
            // wachtwoord
            // 
            this.wachtwoord.BackColor = System.Drawing.Color.Transparent;
            this.wachtwoord.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.wachtwoord.ForeColors = System.Drawing.Color.Black;
            this.wachtwoord.HintText = null;
            this.wachtwoord.IsPassword = false;
            this.wachtwoord.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wachtwoord.LineThickness = 2;
            this.wachtwoord.Location = new System.Drawing.Point(71, 164);
            this.wachtwoord.MaxLength = 32767;
            this.wachtwoord.Name = "wachtwoord";
            this.wachtwoord.OnFocusedColor = System.Drawing.Color.Black;
            this.wachtwoord.OnFocusedTextColor = System.Drawing.Color.Black;
            this.wachtwoord.ReadOnly = false;
            this.wachtwoord.Size = new System.Drawing.Size(244, 23);
            this.wachtwoord.TabIndex = 2;
            this.wachtwoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.wachtwoord.TextName = "wachtwoord";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Blue;
            this.loginbutton.BackgroundColor = System.Drawing.Color.Blue;
            this.loginbutton.ButtonText = "    Login";
            this.loginbutton.CausesValidation = false;
            this.loginbutton.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("loginbutton.ErrorImageLeft")));
            this.loginbutton.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("loginbutton.ErrorImageRight")));
            this.loginbutton.FocusBackground = System.Drawing.Color.Empty;
            this.loginbutton.FocusFontColor = System.Drawing.Color.Empty;
            this.loginbutton.ForeColors = System.Drawing.Color.White;
            this.loginbutton.HoverBackground = System.Drawing.Color.Empty;
            this.loginbutton.HoverFontColor = System.Drawing.Color.Empty;
            this.loginbutton.ImageLeft = ((System.Drawing.Image)(resources.GetObject("loginbutton.ImageLeft")));
            this.loginbutton.ImageRight = null;
            this.loginbutton.LeftPictureColor = System.Drawing.Color.Transparent;
            this.loginbutton.Location = new System.Drawing.Point(71, 239);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.loginbutton.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.loginbutton.RightPictureColor = System.Drawing.Color.Transparent;
            this.loginbutton.Size = new System.Drawing.Size(244, 38);
            this.loginbutton.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loginbutton.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.loginbutton.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 321);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.wachtwoord);
            this.Controls.Add(this.gebruikersnaam);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label text;
        private JMaterialTextbox.JMaterialTextbox gebruikersnaam;
        private JMaterialTextbox.JMaterialTextbox wachtwoord;
        private FlatButton.JFlatButton loginbutton;
    }
}

