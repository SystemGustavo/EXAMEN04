namespace EXAMEN04.PRESENTACION
{
    partial class FrmRegion
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
            txtRegionName = new TextBox();
            dgvRegion = new DataGridView();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label3 = new Label();
            txtRegionID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            SuspendLayout();
            // 
            // txtRegionName
            // 
            txtRegionName.Location = new Point(221, 49);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(174, 27);
            txtRegionName.TabIndex = 0;
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Location = new Point(38, 140);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.RowHeadersWidth = 51;
            dgvRegion.RowTemplate.Height = 29;
            dgvRegion.Size = new Size(621, 298);
            dgvRegion.TabIndex = 2;
            dgvRegion.CellDoubleClick += dgvRegion_CellDoubleClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(448, 23);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(448, 58);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(448, 93);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 52);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 6;
            label1.Text = "Region Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "RegionID";
            // 
            // txtRegionID
            // 
            txtRegionID.Enabled = false;
            txtRegionID.Location = new Point(221, 12);
            txtRegionID.Name = "txtRegionID";
            txtRegionID.Size = new Size(174, 27);
            txtRegionID.TabIndex = 11;
            // 
            // FrmRegion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRegionID);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvRegion);
            Controls.Add(txtRegionName);
            Name = "FrmRegion";
            Text = "FrmRegion";
            Load += FrmRegion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegionName;
        private DataGridView dgvRegion;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label3;
        private TextBox txtRegionID;
    }
}