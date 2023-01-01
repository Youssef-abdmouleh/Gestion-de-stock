namespace ex1
{
    partial class Fmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_btn_cl = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_pr = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_cde = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_quit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_cl,
            this.ts_btn_pr,
            this.ts_btn_cde,
            this.ts_btn_quit});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 86);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_cl
            // 
            this.ts_btn_cl.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_cl.Image")));
            this.ts_btn_cl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_cl.Name = "ts_btn_cl";
            this.ts_btn_cl.Size = new System.Drawing.Size(68, 83);
            this.ts_btn_cl.Text = "Clients";
            this.ts_btn_cl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_cl.Click += new System.EventHandler(this.ts_btn_cl_Click);
            // 
            // ts_btn_pr
            // 
            this.ts_btn_pr.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_pr.Image")));
            this.ts_btn_pr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_pr.Name = "ts_btn_pr";
            this.ts_btn_pr.Size = new System.Drawing.Size(68, 83);
            this.ts_btn_pr.Text = "Produits";
            this.ts_btn_pr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ts_btn_cde
            // 
            this.ts_btn_cde.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_cde.Image")));
            this.ts_btn_cde.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_cde.Name = "ts_btn_cde";
            this.ts_btn_cde.Size = new System.Drawing.Size(79, 83);
            this.ts_btn_cde.Text = "Commandes";
            this.ts_btn_cde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ts_btn_quit
            // 
            this.ts_btn_quit.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_quit.Image")));
            this.ts_btn_quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_quit.Name = "ts_btn_quit";
            this.ts_btn_quit.Size = new System.Drawing.Size(68, 83);
            this.ts_btn_quit.Text = "Quitter";
            this.ts_btn_quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 532);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Fmenu";
            this.Text = "Gestion des Commandes Clients";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Fmenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_btn_cl;
        private System.Windows.Forms.ToolStripButton ts_btn_pr;
        private System.Windows.Forms.ToolStripButton ts_btn_cde;
        private System.Windows.Forms.ToolStripButton ts_btn_quit;
    }
}

