
namespace ParkingCucei
{
    partial class show_cars
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
            this.label_cars_user = new System.Windows.Forms.Label();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add_new_car = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_cars_user
            // 
            this.label_cars_user.AutoSize = true;
            this.label_cars_user.Location = new System.Drawing.Point(280, 40);
            this.label_cars_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cars_user.Name = "label_cars_user";
            this.label_cars_user.Size = new System.Drawing.Size(58, 13);
            this.label_cars_user.TabIndex = 0;
            this.label_cars_user.Text = "Car\'s User ";
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPlate,
            this.columnBrand,
            this.columnModel,
            this.columnColor});
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(93, 74);
            this.listViewCars.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(421, 168);
            this.listViewCars.TabIndex = 2;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            // 
            // columnPlate
            // 
            this.columnPlate.Text = "Placa";
            this.columnPlate.Width = 80;
            // 
            // columnBrand
            // 
            this.columnBrand.Text = "Marca";
            this.columnBrand.Width = 110;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Modelo";
            this.columnModel.Width = 120;
            // 
            // columnColor
            // 
            this.columnColor.Text = "Color";
            this.columnColor.Width = 107;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(135, 275);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(56, 19);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add_new_car
            // 
            this.btn_add_new_car.Location = new System.Drawing.Point(413, 275);
            this.btn_add_new_car.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_new_car.Name = "btn_add_new_car";
            this.btn_add_new_car.Size = new System.Drawing.Size(83, 19);
            this.btn_add_new_car.TabIndex = 4;
            this.btn_add_new_car.Text = "Add New Car";
            this.btn_add_new_car.UseVisualStyleBackColor = true;
            this.btn_add_new_car.Click += new System.EventHandler(this.btn_add_new_car_Click);
            // 
            // show_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_add_new_car);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.label_cars_user);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "show_cars";
            this.Text = "Mostrar autos";
            this.Load += new System.EventHandler(this.show_cars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cars_user;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add_new_car;
        private System.Windows.Forms.ColumnHeader columnPlate;
        private System.Windows.Forms.ColumnHeader columnBrand;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnColor;
    }
}