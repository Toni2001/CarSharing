namespace CarSharing
{
    partial class AutosLöschen
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
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSharingDBDataSet4 = new CarSharing.CarSharingDBDataSet4();
            this.autoTableAdapter = new CarSharing.CarSharingDBDataSet4TableAdapters.AutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.carSharingDBDataSet4;
            // 
            // carSharingDBDataSet4
            // 
            this.carSharingDBDataSet4.DataSetName = "CarSharingDBDataSet4";
            this.carSharingDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // AutosLöschen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1562, 548);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AutosLöschen";
            this.Text = "AutosLöschen";
            this.Load += new System.EventHandler(this.AutosLöschen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CarSharingDBDataSet4 carSharingDBDataSet4;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private CarSharingDBDataSet4TableAdapters.AutoTableAdapter autoTableAdapter;
    }
}