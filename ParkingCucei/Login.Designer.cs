
namespace ParkingCucei
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFPass = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(200, 85);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(139, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(32, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Code";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(142, 133);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(53, 13);
            this.lblPasswd.TabIndex = 3;
            this.lblPasswd.Text = "Password";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(200, 133);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(215, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFPass
            // 
            this.lblFPass.AutoSize = true;
            this.lblFPass.Location = new System.Drawing.Point(197, 230);
            this.lblFPass.Name = "lblFPass";
            this.lblFPass.Size = new System.Drawing.Size(120, 13);
            this.lblFPass.TabIndex = 7;
            this.lblFPass.Text = "Restablecer contraseña";
            this.lblFPass.Click += new System.EventHandler(this.lblFPass_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(215, 258);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(68, 13);
            this.lblCreate.TabIndex = 8;
            this.lblCreate.TabStop = true;
            this.lblCreate.Text = "Crear cuenta";
            this.lblCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreate_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblFPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFPass;
        private System.Windows.Forms.LinkLabel lblCreate;
    }
}

