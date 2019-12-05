namespace Toptancı.OtomasyonuAPP
{
    partial class frmMusteriBul
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
            this.lblNo = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(43, 90);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(69, 13);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "TC No Giriniz";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(142, 123);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.LightCoral;
            this.txtTcNo.Location = new System.Drawing.Point(142, 83);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtTcNo.TabIndex = 3;
            // 
            // frmMusteriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 190);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTcNo);
            this.Name = "frmMusteriBul";
            this.Text = "frmMusteriBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtTcNo;
    }
}