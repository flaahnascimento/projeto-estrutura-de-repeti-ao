namespace WindowsFormsApp1
{
    partial class defina_um_intervalo
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
            this.btnDwhile = new System.Windows.Forms.Button();
            this.txtlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDwhile
            // 
            this.btnDwhile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDwhile.Location = new System.Drawing.Point(87, 119);
            this.btnDwhile.Name = "btnDwhile";
            this.btnDwhile.Size = new System.Drawing.Size(86, 23);
            this.btnDwhile.TabIndex = 14;
            this.btnDwhile.Text = "DO_WHILE";
            this.btnDwhile.UseVisualStyleBackColor = false;
            this.btnDwhile.Click += new System.EventHandler(this.btnDwhile_Click);
            // 
            // txtlist
            // 
            this.txtlist.FormattingEnabled = true;
            this.txtlist.Location = new System.Drawing.Point(6, 157);
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(238, 212);
            this.txtlist.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "INICIO";
            // 
            // txtinicio
            // 
            this.txtinicio.Location = new System.Drawing.Point(82, 44);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(46, 20);
            this.txtinicio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "DEFINA O INTERVALO";
            // 
            // txtfim
            // 
            this.txtfim.Location = new System.Drawing.Point(194, 44);
            this.txtfim.Name = "txtfim";
            this.txtfim.Size = new System.Drawing.Size(46, 20);
            this.txtfim.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "FIM";
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfor.Location = new System.Drawing.Point(179, 119);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(64, 23);
            this.btnfor.TabIndex = 17;
            this.btnfor.Text = "FOR";
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhile.Location = new System.Drawing.Point(6, 119);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(75, 23);
            this.btnwhile.TabIndex = 18;
            this.btnwhile.Text = "WHILE";
            this.btnwhile.UseVisualStyleBackColor = false;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // defina_um_intervalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfim);
            this.Controls.Add(this.btnDwhile);
            this.Controls.Add(this.txtlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.label1);
            this.Name = "defina_um_intervalo";
            this.Text = "defina_um_intervalo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDwhile;
        private System.Windows.Forms.ListBox txtlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnwhile;
    }
}