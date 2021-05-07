
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
            this.listView = new System.Windows.Forms.ListView();
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
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(93, 74);
            this.listView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(421, 168);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(135, 275);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btn_add_new_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label_cars_user);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "show_cars";
            this.Text = "Mostrar autos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cars_user;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add_new_car;
    }
}