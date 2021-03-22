
namespace FRM_nagykonyv_210322
{
    partial class FRMLista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerzőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.dgwKonyv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonyv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerzőToolStripMenuItem,
            this.újKönyvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerzőToolStripMenuItem
            // 
            this.szerzőToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.szerzőToolStripMenuItem.Name = "szerzőToolStripMenuItem";
            this.szerzőToolStripMenuItem.Size = new System.Drawing.Size(100, 39);
            this.szerzőToolStripMenuItem.Text = "Szerző";
            // 
            // újKönyvToolStripMenuItem
            // 
            this.újKönyvToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.újKönyvToolStripMenuItem.Name = "újKönyvToolStripMenuItem";
            this.újKönyvToolStripMenuItem.Size = new System.Drawing.Size(124, 39);
            this.újKönyvToolStripMenuItem.Text = "Új könyv";
            this.újKönyvToolStripMenuItem.Click += new System.EventHandler(this.újKönyvToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés szerző vagy cím alapján:";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTB.Location = new System.Drawing.Point(17, 84);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(466, 30);
            this.searchTB.TabIndex = 2;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // dgwKonyv
            // 
            this.dgwKonyv.AllowUserToAddRows = false;
            this.dgwKonyv.AllowUserToDeleteRows = false;
            this.dgwKonyv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKonyv.ColumnHeadersHeight = 29;
            this.dgwKonyv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.helyezes,
            this.nev,
            this.cim});
            this.dgwKonyv.Location = new System.Drawing.Point(17, 140);
            this.dgwKonyv.MultiSelect = false;
            this.dgwKonyv.Name = "dgwKonyv";
            this.dgwKonyv.ReadOnly = true;
            this.dgwKonyv.RowHeadersWidth = 51;
            this.dgwKonyv.RowTemplate.Height = 24;
            this.dgwKonyv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKonyv.Size = new System.Drawing.Size(466, 226);
            this.dgwKonyv.TabIndex = 3;
            this.dgwKonyv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKonyv_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Könyv(ID)";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // helyezes
            // 
            this.helyezes.HeaderText = "Helyezés";
            this.helyezes.MinimumWidth = 6;
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // cim
            // 
            this.cim.HeaderText = "Cím";
            this.cim.MinimumWidth = 6;
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // FRMLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 389);
            this.Controls.Add(this.dgwKonyv);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FRMLista";
            this.Text = "Nagykönyv";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonyv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerzőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKönyvToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.DataGridView dgwKonyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
    }
}

