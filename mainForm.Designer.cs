//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
namespace GeometricFigures3
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tSFigures = new System.Windows.Forms.ToolStrip();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Triangle = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.tsBClear = new System.Windows.Forms.ToolStripButton();
            this.mSMenu = new System.Windows.Forms.MenuStrip();
            this.tsMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.sFDSave = new System.Windows.Forms.SaveFileDialog();
            this.oFDOpen = new System.Windows.Forms.OpenFileDialog();
            this.pPol1 = new System.Windows.Forms.Panel();
            this.tSFigures.SuspendLayout();
            this.mSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSFigures
            // 
            this.tSFigures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tSFigures.Dock = System.Windows.Forms.DockStyle.Left;
            this.tSFigures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rectangle,
            this.Triangle,
            this.Circle,
            this.Line,
            this.tsBClear});
            this.tSFigures.Location = new System.Drawing.Point(0, 29);
            this.tSFigures.Name = "tSFigures";
            this.tSFigures.Size = new System.Drawing.Size(83, 368);
            this.tSFigures.TabIndex = 1;
            this.tSFigures.Text = "toolStrip1";
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Rectangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rectangle.Size = new System.Drawing.Size(80, 25);
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Rectangle.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Triangle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(80, 25);
            this.Triangle.Text = "Triangle";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Circle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(80, 25);
            this.Circle.Text = "Circle";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Line.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(80, 25);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // tsBClear
            // 
            this.tsBClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsBClear.Image = ((System.Drawing.Image)(resources.GetObject("tsBClear.Image")));
            this.tsBClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBClear.Name = "tsBClear";
            this.tsBClear.Size = new System.Drawing.Size(80, 20);
            this.tsBClear.Text = "Clear";
            this.tsBClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // mSMenu
            // 
            this.mSMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMFile});
            this.mSMenu.Location = new System.Drawing.Point(0, 0);
            this.mSMenu.Name = "mSMenu";
            this.mSMenu.Size = new System.Drawing.Size(800, 29);
            this.mSMenu.TabIndex = 3;
            this.mSMenu.Text = "menuStrip1";
            // 
            // tsMFile
            // 
            this.tsMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMSave,
            this.tsMLoad});
            this.tsMFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMFile.Name = "tsMFile";
            this.tsMFile.Size = new System.Drawing.Size(46, 25);
            this.tsMFile.Text = "File";
            // 
            // tsMSave
            // 
            this.tsMSave.Name = "tsMSave";
            this.tsMSave.Size = new System.Drawing.Size(180, 26);
            this.tsMSave.Text = "Save";
            this.tsMSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tsMLoad
            // 
            this.tsMLoad.Name = "tsMLoad";
            this.tsMLoad.Size = new System.Drawing.Size(180, 26);
            this.tsMLoad.Text = "Load";
            this.tsMLoad.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // oFDOpen
            // 
            this.oFDOpen.FileName = "openFileDialog1";
            // 
            // pPol1
            // 
            this.pPol1.BackColor = System.Drawing.Color.White;
            this.pPol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPol1.Location = new System.Drawing.Point(83, 29);
            this.pPol1.Name = "pPol1";
            this.pPol1.Size = new System.Drawing.Size(717, 368);
            this.pPol1.TabIndex = 4;
            this.pPol1.Paint += new System.Windows.Forms.PaintEventHandler(this.pPol1_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.pPol1);
            this.Controls.Add(this.tSFigures);
            this.Controls.Add(this.mSMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mSMenu;
            this.MinimumSize = new System.Drawing.Size(800, 369);
            this.Name = "mainForm";
            this.Text = "Figures editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tSFigures.ResumeLayout(false);
            this.tSFigures.PerformLayout();
            this.mSMenu.ResumeLayout(false);
            this.mSMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tSFigures;
        private System.Windows.Forms.ToolStripButton Rectangle;
        internal System.Windows.Forms.ToolStripButton Triangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton tsBClear;
        private System.Windows.Forms.MenuStrip mSMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMFile;
        private System.Windows.Forms.ToolStripMenuItem tsMSave;
        private System.Windows.Forms.ToolStripMenuItem tsMLoad;
        private System.Windows.Forms.SaveFileDialog sFDSave;
        private System.Windows.Forms.OpenFileDialog oFDOpen;
        internal System.Windows.Forms.Panel pPol1;
    }
}
