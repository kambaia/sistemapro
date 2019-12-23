namespace Sistema
{
    partial class AreaPedagogica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaPedagogica));
            this.btn_AP_Profs = new MetroFramework.Controls.MetroTile();
            this.btn_AP_Discip = new MetroFramework.Controls.MetroTile();
            this.btn_AP_AnoLet = new MetroFramework.Controls.MetroTile();
            this.btn_AP_Notas = new MetroFramework.Controls.MetroTile();
            this.btn_AP_Classes = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_AP_Profs
            // 
            this.btn_AP_Profs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AP_Profs.Location = new System.Drawing.Point(440, 95);
            this.btn_AP_Profs.Name = "btn_AP_Profs";
            this.btn_AP_Profs.Size = new System.Drawing.Size(238, 129);
            this.btn_AP_Profs.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_AP_Profs.TabIndex = 11;
            this.btn_AP_Profs.Text = "Professores";
            this.btn_AP_Profs.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_AP_Profs.TileImage")));
            this.btn_AP_Profs.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AP_Profs.UseTileImage = true;
            this.btn_AP_Profs.Click += new System.EventHandler(this.btn_AP_Profs_Click);
            // 
            // btn_AP_Discip
            // 
            this.btn_AP_Discip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AP_Discip.Location = new System.Drawing.Point(51, 230);
            this.btn_AP_Discip.Name = "btn_AP_Discip";
            this.btn_AP_Discip.Size = new System.Drawing.Size(238, 129);
            this.btn_AP_Discip.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_AP_Discip.TabIndex = 10;
            this.btn_AP_Discip.Text = "Disciplinas";
            this.btn_AP_Discip.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_AP_Discip.TileImage")));
            this.btn_AP_Discip.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AP_Discip.UseTileImage = true;
            this.btn_AP_Discip.Click += new System.EventHandler(this.btn_AP_Discip_Click);
            // 
            // btn_AP_AnoLet
            // 
            this.btn_AP_AnoLet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AP_AnoLet.Location = new System.Drawing.Point(539, 230);
            this.btn_AP_AnoLet.Name = "btn_AP_AnoLet";
            this.btn_AP_AnoLet.Size = new System.Drawing.Size(139, 129);
            this.btn_AP_AnoLet.TabIndex = 9;
            this.btn_AP_AnoLet.Text = "Ano Letivo";
            this.btn_AP_AnoLet.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_AP_AnoLet.TileImage")));
            this.btn_AP_AnoLet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AP_AnoLet.UseTileImage = true;
            // 
            // btn_AP_Notas
            // 
            this.btn_AP_Notas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AP_Notas.Location = new System.Drawing.Point(295, 230);
            this.btn_AP_Notas.Name = "btn_AP_Notas";
            this.btn_AP_Notas.Size = new System.Drawing.Size(238, 129);
            this.btn_AP_Notas.Style = MetroFramework.MetroColorStyle.Brown;
            this.btn_AP_Notas.TabIndex = 8;
            this.btn_AP_Notas.Text = "Notas";
            this.btn_AP_Notas.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_AP_Notas.TileImage")));
            this.btn_AP_Notas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AP_Notas.UseTileImage = true;
            this.btn_AP_Notas.Click += new System.EventHandler(this.btn_AP_Notas_Click);
            // 
            // btn_AP_Classes
            // 
            this.btn_AP_Classes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AP_Classes.Location = new System.Drawing.Point(295, 95);
            this.btn_AP_Classes.Name = "btn_AP_Classes";
            this.btn_AP_Classes.Size = new System.Drawing.Size(139, 129);
            this.btn_AP_Classes.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_AP_Classes.TabIndex = 7;
            this.btn_AP_Classes.Text = "Classes";
            this.btn_AP_Classes.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_AP_Classes.TileImage")));
            this.btn_AP_Classes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AP_Classes.UseTileImage = true;
            this.btn_AP_Classes.Click += new System.EventHandler(this.btn_AP_Classes_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.Location = new System.Drawing.Point(51, 95);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(238, 129);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Funcionários";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // AreaPedagogica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.btn_AP_Profs);
            this.Controls.Add(this.btn_AP_Discip);
            this.Controls.Add(this.btn_AP_AnoLet);
            this.Controls.Add(this.btn_AP_Notas);
            this.Controls.Add(this.btn_AP_Classes);
            this.Controls.Add(this.metroTile1);
            this.Name = "AreaPedagogica";
            this.Text = "AreaPedagogica";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_AP_Profs;
        private MetroFramework.Controls.MetroTile btn_AP_Discip;
        private MetroFramework.Controls.MetroTile btn_AP_AnoLet;
        private MetroFramework.Controls.MetroTile btn_AP_Notas;
        private MetroFramework.Controls.MetroTile btn_AP_Classes;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}