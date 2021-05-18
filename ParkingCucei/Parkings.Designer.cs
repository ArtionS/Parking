
namespace ParkingCucei
{
    partial class Parkings
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewParkings = new System.Windows.Forms.ListView();
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDirección = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTamaño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackParking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estacionamientos";
            // 
            // listViewParkings
            // 
            this.listViewParkings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colDirección,
            this.colTamaño});
            this.listViewParkings.GridLines = true;
            this.listViewParkings.HideSelection = false;
            this.listViewParkings.Location = new System.Drawing.Point(90, 82);
            this.listViewParkings.Name = "listViewParkings";
            this.listViewParkings.Size = new System.Drawing.Size(444, 186);
            this.listViewParkings.TabIndex = 1;
            this.listViewParkings.UseCompatibleStateImageBehavior = false;
            this.listViewParkings.View = System.Windows.Forms.View.Details;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 100;
            // 
            // colDirección
            // 
            this.colDirección.Text = "Dirección";
            this.colDirección.Width = 280;
            // 
            // colTamaño
            // 
            this.colTamaño.Text = "Tamaño";
            // 
            // btnBackParking
            // 
            this.btnBackParking.Location = new System.Drawing.Point(265, 302);
            this.btnBackParking.Name = "btnBackParking";
            this.btnBackParking.Size = new System.Drawing.Size(75, 23);
            this.btnBackParking.TabIndex = 2;
            this.btnBackParking.Text = "Volver";
            this.btnBackParking.UseVisualStyleBackColor = true;
            this.btnBackParking.Click += new System.EventHandler(this.btnBackParking_Click);
            // 
            // Parkings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBackParking);
            this.Controls.Add(this.listViewParkings);
            this.Controls.Add(this.label1);
            this.Name = "Parkings";
            this.Text = "Estacionamientos";
            this.Load += new System.EventHandler(this.Parkings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewParkings;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colDirección;
        private System.Windows.Forms.ColumnHeader colTamaño;
        private System.Windows.Forms.Button btnBackParking;
    }
}