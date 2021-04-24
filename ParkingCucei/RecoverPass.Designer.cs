
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFPass = new System.Windows.Forms.TextBox();
            this.btnFPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
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
            this.btnFPass.Location = new System.Drawing.Point(123, 159);
            this.btnFPass.Name = "btnFPass";
            this.btnFPass.Size = new System.Drawing.Size(147, 23);
            this.btnFPass.TabIndex = 2;
            this.btnFPass.Text = "Recuperar contraseña";
            this.btnFPass.UseVisualStyleBackColor = true;
            this.btnFPass.Click += new System.EventHandler(this.btnFPass_Click);
            // 
            // FPasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFPass);
            this.Controls.Add(this.txtFPass);
            this.Controls.Add(this.label1);
            this.Name = "FPasswd";
            this.Text = "Recuperar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFPass;
        private System.Windows.Forms.Button btnFPass;
    }
}