
namespace ParkingCucei
{
    partial class EditUser
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.txtNewPasswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarModificacion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(136, 64);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(135, 20);
            this.txtFName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primer nombre:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(136, 131);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(135, 20);
            this.txtLName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundo Nombre:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(136, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(136, 245);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(135, 20);
            this.txtPasswd.TabIndex = 14;
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(61, 248);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(64, 13);
            this.lblPasswd.TabIndex = 13;
            this.lblPasswd.Text = "Contraseña:";
            // 
            // txtNewPasswd
            // 
            this.txtNewPasswd.Location = new System.Drawing.Point(136, 293);
            this.txtNewPasswd.Name = "txtNewPasswd";
            this.txtNewPasswd.PasswordChar = '*';
            this.txtNewPasswd.Size = new System.Drawing.Size(135, 20);
            this.txtNewPasswd.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nueva contraseña:";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(378, 50);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(98, 46);
            this.btnEliminarUsuario.TabIndex = 17;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnGuardarModificacion
            // 
            this.btnGuardarModificacion.Location = new System.Drawing.Point(378, 156);
            this.btnGuardarModificacion.Name = "btnGuardarModificacion";
            this.btnGuardarModificacion.Size = new System.Drawing.Size(98, 56);
            this.btnGuardarModificacion.TabIndex = 18;
            this.btnGuardarModificacion.Text = "Modificar";
            this.btnGuardarModificacion.UseVisualStyleBackColor = true;
            this.btnGuardarModificacion.Click += new System.EventHandler(this.btnGuardarModificacion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(378, 280);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 44);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarModificacion);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.txtNewPasswd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.TextBox txtNewPasswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnGuardarModificacion;
        private System.Windows.Forms.Button btnVolver;
    }
}