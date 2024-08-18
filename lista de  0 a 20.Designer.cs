namespace WindowsFormsApp1
{
    partial class lista_de__0_a_20
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
            this.btNLISTE = new System.Windows.Forms.Button();
            this.txtlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNLISTE
            // 
            this.btNLISTE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNLISTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNLISTE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNLISTE.Location = new System.Drawing.Point(60, 226);
            this.btNLISTE.Name = "btNLISTE";
            this.btNLISTE.Size = new System.Drawing.Size(86, 39);
            this.btNLISTE.TabIndex = 23;
            this.btNLISTE.Text = "LISTE";
            this.btNLISTE.UseVisualStyleBackColor = false;
            this.btNLISTE.Click += new System.EventHandler(this.btNLISTE_Click);
            // 
            // txtlist
            // 
            this.txtlist.FormattingEnabled = true;
            this.txtlist.Location = new System.Drawing.Point(12, 60);
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(258, 160);
            this.txtlist.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "LISTA DE 0 A 20";
            // 
            // lista_de__0_a_20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download1;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.btNLISTE);
            this.Controls.Add(this.txtlist);
            this.Controls.Add(this.label1);
            this.Name = "lista_de__0_a_20";
            this.Text = "lista_de__0_a_20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNLISTE;
        private System.Windows.Forms.ListBox txtlist;
        private System.Windows.Forms.Label label1;
    }
}