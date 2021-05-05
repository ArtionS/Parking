
namespace ParkingCucei
{
    partial class FPasswd
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
            this.lblCodeRecover = new System.Windows.Forms.Label();
            this.txtFPass = new System.Windows.Forms.TextBox();
            this.btnFPass = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodeRecover
            // 
            this.lblCodeRecover.AutoSize = true;
            this.lblCodeRecover.Location = new System.Drawing.Point(89, 122);
            this.lblCodeRecover.Name = "lblCodeRecover";
            this.lblCodeRecover.Size = new System.Drawing.Size(40, 13);
            this.lblCodeRecover.TabIndex = 0;
            this.lblCodeRecover.Text = "Codigo";
            // 
            // txtFPass
            // 
            this.txtFPass.Location = new System.Drawing.Point(140, 122);
            this.txtFPass.Name = "txtFPass";
            this.txtFPass.Size = new System.Drawing.Size(100, 20);
            this.txtFPass.TabIndex = 1;
            // 
            // btnFPass
            // 
            this.btnFPass.Location = new System.Drawing.Point(110, 160);
            this.btnFPass.Name = "btnFPass";
            this.btnFPass.Size = new System.Drawing.Size(147, 23);
            this.btnFPass.TabIndex = 2;
            this.btnFPass.Text = "Recuperar contraseña";
            this.btnFPass.UseVisualStyleBackColor = true;
            this.btnFPass.Click += new System.EventHandler(this.btnFPass_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(259, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 46);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver a login";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FPasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFPass);
            this.Controls.Add(this.txtFPass);
            this.Controls.Add(this.lblCodeRecover);
            this.Name = "FPasswd";
            this.Text = "Recuperar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeRecover;
        private System.Windows.Forms.TextBox txtFPass;
        private System.Windows.Forms.Button btnFPass;
        private System.Windows.Forms.Button btnVolver;
    }
}