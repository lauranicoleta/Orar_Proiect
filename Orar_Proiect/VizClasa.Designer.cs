namespace Orar_Proiect
{
    partial class VizClasa
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
            this.lvClase = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editeazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.înapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvClase
            // 
            this.lvClase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lvClase.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClase.HideSelection = false;
            this.lvClase.Location = new System.Drawing.Point(12, 68);
            this.lvClase.Name = "lvClase";
            this.lvClase.Size = new System.Drawing.Size(962, 327);
            this.lvClase.TabIndex = 0;
            this.lvClase.UseCompatibleStateImageBehavior = false;
            this.lvClase.View = System.Windows.Forms.View.Details;
            this.lvClase.SelectedIndexChanged += new System.EventHandler(this.lvClase_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod Clasă";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "An";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 1;
            this.columnHeader4.Text = "Profil";
            this.columnHeader4.Width = 246;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cod Sala de Clasa";
            this.columnHeader3.Width = 175;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazăToolStripMenuItem,
            this.înapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editeazăToolStripMenuItem
            // 
            this.editeazăToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeazăToolStripMenuItem.Name = "editeazăToolStripMenuItem";
            this.editeazăToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.editeazăToolStripMenuItem.Text = "Editează";
            this.editeazăToolStripMenuItem.Click += new System.EventHandler(this.editeazăToolStripMenuItem_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cod Instituție";
            this.columnHeader5.Width = 159;
            // 
            // înapoiToolStripMenuItem
            // 
            this.înapoiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.înapoiToolStripMenuItem.Name = "înapoiToolStripMenuItem";
            this.înapoiToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.înapoiToolStripMenuItem.Text = "Înapoi";
            this.înapoiToolStripMenuItem.Click += new System.EventHandler(this.înapoiToolStripMenuItem_Click);
            // 
            // VizClasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.lvClase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VizClasa";
            this.Text = "VizClasa";
            this.Load += new System.EventHandler(this.VizClasa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvClase;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazăToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem înapoiToolStripMenuItem;
    }
}