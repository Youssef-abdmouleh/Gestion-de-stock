namespace ex1
{
    partial class search
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
            this.Meth_Nom = new System.Windows.Forms.RadioButton();
            this.Meth_Tel = new System.Windows.Forms.RadioButton();
            this.Meth_Vil = new System.Windows.Forms.RadioButton();
            this.Meth_Pren = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Meth_Nom
            // 
            this.Meth_Nom.AutoSize = true;
            this.Meth_Nom.Location = new System.Drawing.Point(76, 123);
            this.Meth_Nom.Name = "Meth_Nom";
            this.Meth_Nom.Size = new System.Drawing.Size(47, 17);
            this.Meth_Nom.TabIndex = 0;
            this.Meth_Nom.TabStop = true;
            this.Meth_Nom.Text = "Nom";
            this.Meth_Nom.UseVisualStyleBackColor = true;
            this.Meth_Nom.CheckedChanged += new System.EventHandler(this.Meth_Nom_CheckedChanged);
            // 
            // Meth_Tel
            // 
            this.Meth_Tel.AutoSize = true;
            this.Meth_Tel.Location = new System.Drawing.Point(76, 251);
            this.Meth_Tel.Name = "Meth_Tel";
            this.Meth_Tel.Size = new System.Drawing.Size(76, 17);
            this.Meth_Tel.TabIndex = 1;
            this.Meth_Tel.TabStop = true;
            this.Meth_Tel.Text = "Telephone";
            this.Meth_Tel.UseVisualStyleBackColor = true;
            this.Meth_Tel.CheckedChanged += new System.EventHandler(this.Meth_Tel_CheckedChanged);
            // 
            // Meth_Vil
            // 
            this.Meth_Vil.AutoSize = true;
            this.Meth_Vil.Location = new System.Drawing.Point(76, 208);
            this.Meth_Vil.Name = "Meth_Vil";
            this.Meth_Vil.Size = new System.Drawing.Size(44, 17);
            this.Meth_Vil.TabIndex = 2;
            this.Meth_Vil.TabStop = true;
            this.Meth_Vil.Text = "Ville";
            this.Meth_Vil.UseVisualStyleBackColor = true;
            this.Meth_Vil.CheckedChanged += new System.EventHandler(this.Meth_Vil_CheckedChanged);
            // 
            // Meth_Pren
            // 
            this.Meth_Pren.AutoSize = true;
            this.Meth_Pren.Location = new System.Drawing.Point(76, 164);
            this.Meth_Pren.Name = "Meth_Pren";
            this.Meth_Pren.Size = new System.Drawing.Size(61, 17);
            this.Meth_Pren.TabIndex = 3;
            this.Meth_Pren.TabStop = true;
            this.Meth_Pren.Text = "Prenom";
            this.Meth_Pren.UseVisualStyleBackColor = true;
            this.Meth_Pren.CheckedChanged += new System.EventHandler(this.Meth_Pren_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method de recherche";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Meth_Pren);
            this.Controls.Add(this.Meth_Vil);
            this.Controls.Add(this.Meth_Tel);
            this.Controls.Add(this.Meth_Nom);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Meth_Nom;
        private System.Windows.Forms.RadioButton Meth_Tel;
        private System.Windows.Forms.RadioButton Meth_Vil;
        private System.Windows.Forms.RadioButton Meth_Pren;
        private System.Windows.Forms.Label label1;
    }
}