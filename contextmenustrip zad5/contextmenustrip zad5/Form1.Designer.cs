namespace contextmenustrip_zad5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtboxLijevo = new System.Windows.Forms.TextBox();
            this.txtboxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoCtrldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxLijevo
            // 
            this.txtboxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.txtboxLijevo.Location = new System.Drawing.Point(127, 63);
            this.txtboxLijevo.Name = "txtboxLijevo";
            this.txtboxLijevo.Size = new System.Drawing.Size(100, 20);
            this.txtboxLijevo.TabIndex = 0;
            // 
            // txtboxDesno
            // 
            this.txtboxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.txtboxDesno.Location = new System.Drawing.Point(362, 63);
            this.txtboxDesno.Name = "txtboxDesno";
            this.txtboxDesno.Size = new System.Drawing.Size(100, 20);
            this.txtboxDesno.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoCtrldToolStripMenuItem,
            this.desnoNaLijevoCtrlLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 70);
            // 
            // lijevoNaDesnoCtrldToolStripMenuItem
            // 
            this.lijevoNaDesnoCtrldToolStripMenuItem.Name = "lijevoNaDesnoCtrldToolStripMenuItem";
            this.lijevoNaDesnoCtrldToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.lijevoNaDesnoCtrldToolStripMenuItem.Text = "Lijevo na desno      Ctrl+D";
            this.lijevoNaDesnoCtrldToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoCtrldToolStripMenuItem_Click);
            // 
            // desnoNaLijevoCtrlLToolStripMenuItem
            // 
            this.desnoNaLijevoCtrlLToolStripMenuItem.Name = "desnoNaLijevoCtrlLToolStripMenuItem";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.desnoNaLijevoCtrlLToolStripMenuItem.Text = "Desno na lijevo       Ctrl+L";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoCtrlLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 257);
            this.Controls.Add(this.txtboxDesno);
            this.Controls.Add(this.txtboxLijevo);
            this.Name = "Form1";
            this.Text = "Upotreba ContextMenuStrip kontrole";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxLijevo;
        private System.Windows.Forms.TextBox txtboxDesno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoCtrldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoCtrlLToolStripMenuItem;
    }
}

