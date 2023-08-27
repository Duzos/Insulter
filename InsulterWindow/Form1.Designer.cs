namespace InsulterWindow
{
    partial class Insulter
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
            this.btnInsult = new System.Windows.Forms.Button();
            this.lblInsult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsult
            // 
            this.btnInsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsult.Location = new System.Drawing.Point(7, 28);
            this.btnInsult.Name = "btnInsult";
            this.btnInsult.Size = new System.Drawing.Size(120, 49);
            this.btnInsult.TabIndex = 0;
            this.btnInsult.Text = "insult me";
            this.btnInsult.UseVisualStyleBackColor = true;
            this.btnInsult.Click += new System.EventHandler(this.btnInsult_Click);
            // 
            // lblInsult
            // 
            this.lblInsult.AutoSize = true;
            this.lblInsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsult.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInsult.Location = new System.Drawing.Point(2, 0);
            this.lblInsult.Name = "lblInsult";
            this.lblInsult.Size = new System.Drawing.Size(146, 25);
            this.lblInsult.TabIndex = 1;
            this.lblInsult.Text = "Click the button";
            // 
            // Insulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 83);
            this.Controls.Add(this.lblInsult);
            this.Controls.Add(this.btnInsult);
            this.Name = "Insulter";
            this.Text = "Insulter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsult;
        private System.Windows.Forms.Label lblInsult;
    }
}

