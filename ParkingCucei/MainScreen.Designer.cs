
namespace ParkingCucei
{
    partial class MainScreen
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
            this.lblCode = new System.Windows.Forms.Label();
            this.btnVolverLogin = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnMyCars = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnViewParking = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(39, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 13);
            this.lblCode.TabIndex = 0;
            // 
            // btnVolverLogin
            // 
            this.btnVolverLogin.Location = new System.Drawing.Point(374, 331);
            this.btnVolverLogin.Name = "btnVolverLogin";
            this.btnVolverLogin.Size = new System.Drawing.Size(92, 23);
            this.btnVolverLogin.TabIndex = 1;
            this.btnVolverLogin.Text = "Cerrar Sesion";
            this.btnVolverLogin.UseVisualStyleBackColor = true;
            this.btnVolverLogin.Click += new System.EventHandler(this.btnVolverLogin_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(42, 102);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(42, 180);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 13);
            this.lblLastName.TabIndex = 3;
            // 
            // btnMyCars
            // 
            this.btnMyCars.Location = new System.Drawing.Point(374, 45);
            this.btnMyCars.Name = "btnMyCars";
            this.btnMyCars.Size = new System.Drawing.Size(112, 45);
            this.btnMyCars.TabIndex = 4;
            this.btnMyCars.Text = "Mis carros";
            this.btnMyCars.UseVisualStyleBackColor = true;
            this.btnMyCars.Click += new System.EventHandler(this.btnMyCars_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(374, 124);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(112, 47);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Mi historial";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnViewParking
            // 
            this.btnViewParking.Location = new System.Drawing.Point(374, 200);
            this.btnViewParking.Name = "btnViewParking";
            this.btnViewParking.Size = new System.Drawing.Size(112, 47);
            this.btnViewParking.TabIndex = 6;
            this.btnViewParking.Text = "Ver estacionamientos";
            this.btnViewParking.UseVisualStyleBackColor = true;
            this.btnViewParking.Click += new System.EventHandler(this.btnViewParking_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(45, 284);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(522, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnViewParking);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnMyCars);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnVolverLogin);
            this.Controls.Add(this.lblCode);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnVolverLogin;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnMyCars;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnViewParking;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnExit;
    }
}