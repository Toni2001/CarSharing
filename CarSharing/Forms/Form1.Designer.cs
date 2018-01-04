namespace CarSharing
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLoginLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLoginLink, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtRePassword, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTitel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitel, 2);
            this.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(107, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(202, 34);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Register:";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.Location = new System.Drawing.Point(211, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(98, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.Location = new System.Drawing.Point(211, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(98, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblLoginLink
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblLoginLink, 2);
            this.lblLoginLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoginLink.LinkColor = System.Drawing.Color.Black;
            this.lblLoginLink.Location = new System.Drawing.Point(107, 272);
            this.lblLoginLink.Name = "lblLoginLink";
            this.lblLoginLink.Size = new System.Drawing.Size(202, 34);
            this.lblLoginLink.TabIndex = 9;
            this.lblLoginLink.TabStop = true;
            this.lblLoginLink.Text = "Ich habe bereits einen Account!";
            this.lblLoginLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLoginLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(211, 207);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRePassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRePassword.Location = new System.Drawing.Point(211, 143);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(98, 20);
            this.txtRePassword.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(417, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lblLoginLink;
    }
}

