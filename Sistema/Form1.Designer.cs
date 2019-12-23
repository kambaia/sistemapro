namespace Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menuLogOut = new System.Windows.Forms.Button();
            this.btn_menuTes = new System.Windows.Forms.Button();
            this.btn_menuAPedag = new System.Windows.Forms.Button();
            this.btn_menuPrincipal = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.painel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_menuLogOut);
            this.panel1.Controls.Add(this.btn_menuTes);
            this.panel1.Controls.Add(this.btn_menuAPedag);
            this.panel1.Controls.Add(this.btn_menuPrincipal);
            this.panel1.Controls.Add(this.pb_Logo);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 568);
            this.panel1.TabIndex = 0;
            // 
            // btn_menuLogOut
            // 
            this.btn_menuLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_menuLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuLogOut.Location = new System.Drawing.Point(0, 532);
            this.btn_menuLogOut.Name = "btn_menuLogOut";
            this.btn_menuLogOut.Size = new System.Drawing.Size(186, 36);
            this.btn_menuLogOut.TabIndex = 4;
            this.btn_menuLogOut.Text = "Sair";
            this.btn_menuLogOut.UseVisualStyleBackColor = true;
            // 
            // btn_menuTes
            // 
            this.btn_menuTes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuTes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuTes.Location = new System.Drawing.Point(0, 260);
            this.btn_menuTes.Name = "btn_menuTes";
            this.btn_menuTes.Size = new System.Drawing.Size(186, 36);
            this.btn_menuTes.TabIndex = 3;
            this.btn_menuTes.Text = "Tesouraria";
            this.btn_menuTes.UseVisualStyleBackColor = true;
            this.btn_menuTes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_menuAPedag
            // 
            this.btn_menuAPedag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuAPedag.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuAPedag.Location = new System.Drawing.Point(0, 218);
            this.btn_menuAPedag.Name = "btn_menuAPedag";
            this.btn_menuAPedag.Size = new System.Drawing.Size(186, 36);
            this.btn_menuAPedag.TabIndex = 2;
            this.btn_menuAPedag.Text = "Área Pedagógica";
            this.btn_menuAPedag.UseVisualStyleBackColor = true;
            this.btn_menuAPedag.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuPrincipal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuPrincipal.Location = new System.Drawing.Point(0, 176);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(186, 36);
            this.btn_menuPrincipal.TabIndex = 1;
            this.btn_menuPrincipal.Text = "Tela Inicial";
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(13, 67);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(161, 74);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // painel
            // 
            this.painel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel.Location = new System.Drawing.Point(192, 57);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(744, 494);
            this.painel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(140, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(960, 574);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(960, 574);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_menuLogOut;
        private System.Windows.Forms.Button btn_menuTes;
        private System.Windows.Forms.Button btn_menuAPedag;
        private System.Windows.Forms.Button btn_menuPrincipal;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Button button1;
    }
}

