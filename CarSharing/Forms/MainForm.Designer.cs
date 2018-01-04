namespace CarSharing.Forms
{
    partial class MainForm
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
            this.btnAutosAusleihen = new System.Windows.Forms.Button();
            this.btnAutosKaufen = new System.Windows.Forms.Button();
            this.btnAutosLöschen = new System.Windows.Forms.Button();
            this.btnAutosBearbeiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutosAusleihen
            // 
            this.btnAutosAusleihen.BackColor = System.Drawing.Color.Black;
            this.btnAutosAusleihen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutosAusleihen.Location = new System.Drawing.Point(180, 62);
            this.btnAutosAusleihen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutosAusleihen.Name = "btnAutosAusleihen";
            this.btnAutosAusleihen.Size = new System.Drawing.Size(152, 25);
            this.btnAutosAusleihen.TabIndex = 0;
            this.btnAutosAusleihen.Text = "Autos ausleihen";
            this.btnAutosAusleihen.UseVisualStyleBackColor = false;
            this.btnAutosAusleihen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutosKaufen
            // 
            this.btnAutosKaufen.BackColor = System.Drawing.Color.Black;
            this.btnAutosKaufen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutosKaufen.Location = new System.Drawing.Point(180, 91);
            this.btnAutosKaufen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutosKaufen.Name = "btnAutosKaufen";
            this.btnAutosKaufen.Size = new System.Drawing.Size(152, 25);
            this.btnAutosKaufen.TabIndex = 1;
            this.btnAutosKaufen.Text = "Autos kaufen";
            this.btnAutosKaufen.UseVisualStyleBackColor = false;
            this.btnAutosKaufen.Click += new System.EventHandler(this.btnAutosKaufen_Click);
            // 
            // btnAutosLöschen
            // 
            this.btnAutosLöschen.BackColor = System.Drawing.Color.Black;
            this.btnAutosLöschen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutosLöschen.Location = new System.Drawing.Point(180, 120);
            this.btnAutosLöschen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutosLöschen.Name = "btnAutosLöschen";
            this.btnAutosLöschen.Size = new System.Drawing.Size(152, 25);
            this.btnAutosLöschen.TabIndex = 2;
            this.btnAutosLöschen.Text = "Autos löschen";
            this.btnAutosLöschen.UseVisualStyleBackColor = false;
            this.btnAutosLöschen.Click += new System.EventHandler(this.btnAutosLöschen_Click);
            // 
            // btnAutosBearbeiten
            // 
            this.btnAutosBearbeiten.BackColor = System.Drawing.Color.Black;
            this.btnAutosBearbeiten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutosBearbeiten.Location = new System.Drawing.Point(180, 149);
            this.btnAutosBearbeiten.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutosBearbeiten.Name = "btnAutosBearbeiten";
            this.btnAutosBearbeiten.Size = new System.Drawing.Size(152, 25);
            this.btnAutosBearbeiten.TabIndex = 3;
            this.btnAutosBearbeiten.Text = "Autos bearbeiten";
            this.btnAutosBearbeiten.UseVisualStyleBackColor = false;
            this.btnAutosBearbeiten.Click += new System.EventHandler(this.btnAutosBearbeiten_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(530, 265);
            this.Controls.Add(this.btnAutosBearbeiten);
            this.Controls.Add(this.btnAutosLöschen);
            this.Controls.Add(this.btnAutosKaufen);
            this.Controls.Add(this.btnAutosAusleihen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutosAusleihen;
        private System.Windows.Forms.Button btnAutosKaufen;
        private System.Windows.Forms.Button btnAutosLöschen;
        private System.Windows.Forms.Button btnAutosBearbeiten;
    }
}