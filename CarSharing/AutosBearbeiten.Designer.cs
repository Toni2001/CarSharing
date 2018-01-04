namespace CarSharing
{
    partial class AutosBearbeiten
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
            this.carSharingDBDataSet3 = new CarSharing.CarSharingDBDataSet3();
            this.autoTableAdapter = new CarSharing.CarSharingDBDataSet3TableAdapters.AutoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modellIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kennzeichenNummerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getriebartIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treibstoffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antriebIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carSharingDBDataSet5 = new CarSharing.CarSharingDBDataSet5();
            this.autoTableAdapter1 = new CarSharing.CarSharingDBDataSet5TableAdapters.AutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.carSharingDBDataSet3;
            // 
            // carSharingDBDataSet3
            // 
            this.carSharingDBDataSet3.DataSetName = "CarSharingDBDataSet3";
            this.carSharingDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIdDataGridViewTextBoxColumn,
            this.farbIdDataGridViewTextBoxColumn,
            this.markeIdDataGridViewTextBoxColumn,
            this.modellIdDataGridViewTextBoxColumn,
            this.kennzeichenNummerIdDataGridViewTextBoxColumn,
            this.typIdDataGridViewTextBoxColumn,
            this.getriebartIdDataGridViewTextBoxColumn,
            this.treibstoffIdDataGridViewTextBoxColumn,
            this.antriebIdDataGridViewTextBoxColumn,
            this.kilometerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 77);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // autoIdDataGridViewTextBoxColumn
            // 
            this.autoIdDataGridViewTextBoxColumn.DataPropertyName = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.HeaderText = "AutoId";
            this.autoIdDataGridViewTextBoxColumn.Name = "autoIdDataGridViewTextBoxColumn";
            this.autoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // farbIdDataGridViewTextBoxColumn
            // 
            this.farbIdDataGridViewTextBoxColumn.DataPropertyName = "FarbId";
            this.farbIdDataGridViewTextBoxColumn.HeaderText = "FarbId";
            this.farbIdDataGridViewTextBoxColumn.Name = "farbIdDataGridViewTextBoxColumn";
            // 
            // markeIdDataGridViewTextBoxColumn
            // 
            this.markeIdDataGridViewTextBoxColumn.DataPropertyName = "MarkeId";
            this.markeIdDataGridViewTextBoxColumn.HeaderText = "MarkeId";
            this.markeIdDataGridViewTextBoxColumn.Name = "markeIdDataGridViewTextBoxColumn";
            // 
            // modellIdDataGridViewTextBoxColumn
            // 
            this.modellIdDataGridViewTextBoxColumn.DataPropertyName = "ModellId";
            this.modellIdDataGridViewTextBoxColumn.HeaderText = "ModellId";
            this.modellIdDataGridViewTextBoxColumn.Name = "modellIdDataGridViewTextBoxColumn";
            // 
            // kennzeichenNummerIdDataGridViewTextBoxColumn
            // 
            this.kennzeichenNummerIdDataGridViewTextBoxColumn.DataPropertyName = "KennzeichenNummerId";
            this.kennzeichenNummerIdDataGridViewTextBoxColumn.HeaderText = "KennzeichenNummerId";
            this.kennzeichenNummerIdDataGridViewTextBoxColumn.Name = "kennzeichenNummerIdDataGridViewTextBoxColumn";
            // 
            // typIdDataGridViewTextBoxColumn
            // 
            this.typIdDataGridViewTextBoxColumn.DataPropertyName = "TypId";
            this.typIdDataGridViewTextBoxColumn.HeaderText = "TypId";
            this.typIdDataGridViewTextBoxColumn.Name = "typIdDataGridViewTextBoxColumn";
            // 
            // getriebartIdDataGridViewTextBoxColumn
            // 
            this.getriebartIdDataGridViewTextBoxColumn.DataPropertyName = "GetriebartId";
            this.getriebartIdDataGridViewTextBoxColumn.HeaderText = "GetriebartId";
            this.getriebartIdDataGridViewTextBoxColumn.Name = "getriebartIdDataGridViewTextBoxColumn";
            // 
            // treibstoffIdDataGridViewTextBoxColumn
            // 
            this.treibstoffIdDataGridViewTextBoxColumn.DataPropertyName = "TreibstoffId";
            this.treibstoffIdDataGridViewTextBoxColumn.HeaderText = "TreibstoffId";
            this.treibstoffIdDataGridViewTextBoxColumn.Name = "treibstoffIdDataGridViewTextBoxColumn";
            // 
            // antriebIdDataGridViewTextBoxColumn
            // 
            this.antriebIdDataGridViewTextBoxColumn.DataPropertyName = "AntriebId";
            this.antriebIdDataGridViewTextBoxColumn.HeaderText = "AntriebId";
            this.antriebIdDataGridViewTextBoxColumn.Name = "antriebIdDataGridViewTextBoxColumn";
            // 
            // kilometerDataGridViewTextBoxColumn
            // 
            this.kilometerDataGridViewTextBoxColumn.DataPropertyName = "Kilometer";
            this.kilometerDataGridViewTextBoxColumn.HeaderText = "Kilometer";
            this.kilometerDataGridViewTextBoxColumn.Name = "kilometerDataGridViewTextBoxColumn";
            // 
            // autoBindingSource1
            // 
            this.autoBindingSource1.DataMember = "Auto";
            this.autoBindingSource1.DataSource = this.carSharingDBDataSet5;
            // 
            // carSharingDBDataSet5
            // 
            this.carSharingDBDataSet5.DataSetName = "CarSharingDBDataSet5";
            this.carSharingDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoTableAdapter1
            // 
            this.autoTableAdapter1.ClearBeforeFill = true;
            // 
            // AutosBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1037, 77);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AutosBearbeiten";
            this.Load += new System.EventHandler(this.AutosBearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSharingDBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CarSharingDBDataSet3 carSharingDBDataSet3;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private CarSharingDBDataSet3TableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarSharingDBDataSet5 carSharingDBDataSet5;
        private System.Windows.Forms.BindingSource autoBindingSource1;
        private CarSharingDBDataSet5TableAdapters.AutoTableAdapter autoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modellIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kennzeichenNummerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getriebartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treibstoffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antriebIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometerDataGridViewTextBoxColumn;
    }
}