
namespace ParkingCucei
{
    partial class Tickets
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colIdTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdTicket,
            this.colDateIn,
            this.colDateOut});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(109, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 171);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colIdTicket
            // 
            this.colIdTicket.Text = "Ticket";
            // 
            // colDateIn
            // 
            this.colDateIn.Text = "Fecha llegada";
            this.colDateIn.Width = 170;
            // 
            // colDateOut
            // 
            this.colDateOut.Text = "Fecha Salida";
            this.colDateOut.Width = 170;
            // 
            // btnBackTickets
            // 
            this.btnBackTickets.Location = new System.Drawing.Point(109, 283);
            this.btnBackTickets.Name = "btnBackTickets";
            this.btnBackTickets.Size = new System.Drawing.Size(75, 23);
            this.btnBackTickets.TabIndex = 2;
            this.btnBackTickets.Text = "Volver";
            this.btnBackTickets.UseVisualStyleBackColor = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBackTickets);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colIdTicket;
        private System.Windows.Forms.ColumnHeader colDateIn;
        private System.Windows.Forms.ColumnHeader colDateOut;
        private System.Windows.Forms.Button btnBackTickets;
    }
}