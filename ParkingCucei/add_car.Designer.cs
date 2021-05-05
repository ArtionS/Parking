
namespace ParkingCucei
{
    partial class add_car
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
            this.lavel_new_car = new System.Windows.Forms.Label();
            this.lavel_plate = new System.Windows.Forms.Label();
            this.lavel_model = new System.Windows.Forms.Label();
            this.lavel_color = new System.Windows.Forms.Label();
            this.lavel_brand = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txb_plate = new System.Windows.Forms.TextBox();
            this.txb_model = new System.Windows.Forms.TextBox();
            this.txb_brand = new System.Windows.Forms.TextBox();
            this.txb_color = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lavel_new_car
            // 
            this.lavel_new_car.AutoSize = true;
            this.lavel_new_car.Location = new System.Drawing.Point(351, 53);
            this.lavel_new_car.Name = "lavel_new_car";
            this.lavel_new_car.Size = new System.Drawing.Size(61, 17);
            this.lavel_new_car.TabIndex = 0;
            this.lavel_new_car.Text = "New Car";
            // 
            // lavel_plate
            // 
            this.lavel_plate.AutoSize = true;
            this.lavel_plate.Location = new System.Drawing.Point(220, 149);
            this.lavel_plate.Name = "lavel_plate";
            this.lavel_plate.Size = new System.Drawing.Size(40, 17);
            this.lavel_plate.TabIndex = 1;
            this.lavel_plate.Text = "Plate";
            // 
            // lavel_model
            // 
            this.lavel_model.AutoSize = true;
            this.lavel_model.Location = new System.Drawing.Point(476, 149);
            this.lavel_model.Name = "lavel_model";
            this.lavel_model.Size = new System.Drawing.Size(46, 17);
            this.lavel_model.TabIndex = 2;
            this.lavel_model.Text = "Model";
            // 
            // lavel_color
            // 
            this.lavel_color.AutoSize = true;
            this.lavel_color.Location = new System.Drawing.Point(476, 246);
            this.lavel_color.Name = "lavel_color";
            this.lavel_color.Size = new System.Drawing.Size(41, 17);
            this.lavel_color.TabIndex = 3;
            this.lavel_color.Text = "Color";
            // 
            // lavel_brand
            // 
            this.lavel_brand.AutoSize = true;
            this.lavel_brand.Location = new System.Drawing.Point(220, 246);
            this.lavel_brand.Name = "lavel_brand";
            this.lavel_brand.Size = new System.Drawing.Size(46, 17);
            this.lavel_brand.TabIndex = 4;
            this.lavel_brand.Text = "Brand";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(204, 367);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Car";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txb_plate
            // 
            this.txb_plate.Location = new System.Drawing.Point(192, 112);
            this.txb_plate.Name = "txb_plate";
            this.txb_plate.Size = new System.Drawing.Size(100, 22);
            this.txb_plate.TabIndex = 8;
            // 
            // txb_model
            // 
            this.txb_model.Location = new System.Drawing.Point(445, 112);
            this.txb_model.Name = "txb_model";
            this.txb_model.Size = new System.Drawing.Size(100, 22);
            this.txb_model.TabIndex = 9;
            // 
            // txb_brand
            // 
            this.txb_brand.Location = new System.Drawing.Point(192, 209);
            this.txb_brand.Name = "txb_brand";
            this.txb_brand.Size = new System.Drawing.Size(100, 22);
            this.txb_brand.TabIndex = 10;
            // 
            // txb_color
            // 
            this.txb_color.Location = new System.Drawing.Point(445, 209);
            this.txb_color.Name = "txb_color";
            this.txb_color.Size = new System.Drawing.Size(100, 22);
            this.txb_color.TabIndex = 11;
            // 
            // add_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_color);
            this.Controls.Add(this.txb_brand);
            this.Controls.Add(this.txb_model);
            this.Controls.Add(this.txb_plate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lavel_brand);
            this.Controls.Add(this.lavel_color);
            this.Controls.Add(this.lavel_model);
            this.Controls.Add(this.lavel_plate);
            this.Controls.Add(this.lavel_new_car);
            this.Name = "add_car";
            this.Text = "add_car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lavel_new_car;
        private System.Windows.Forms.Label lavel_plate;
        private System.Windows.Forms.Label lavel_model;
        private System.Windows.Forms.Label lavel_color;
        private System.Windows.Forms.Label lavel_brand;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txb_plate;
        private System.Windows.Forms.TextBox txb_model;
        private System.Windows.Forms.TextBox txb_brand;
        private System.Windows.Forms.TextBox txb_color;
    }
}