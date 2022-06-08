//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
namespace GeometricFigures3
{
    partial class secondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secondForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.mtbX = new System.Windows.Forms.MaskedTextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.mtbY = new System.Windows.Forms.MaskedTextBox();
            this.cDColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.Location = new System.Drawing.Point(226, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // mtbX
            // 
            this.mtbX.Location = new System.Drawing.Point(185, 135);
            this.mtbX.Mask = "00000";
            this.mtbX.MaximumSize = new System.Drawing.Size(100, 100);
            this.mtbX.Name = "mtbX";
            this.mtbX.Size = new System.Drawing.Size(40, 23);
            this.mtbX.TabIndex = 2;
            this.mtbX.ValidatingType = typeof(int);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(162, 140);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(20, 15);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "X0";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(305, 140);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(20, 15);
            this.lbY.TabIndex = 4;
            this.lbY.Text = "Y0";
            // 
            // mtbY
            // 
            this.mtbY.Location = new System.Drawing.Point(322, 135);
            this.mtbY.Mask = "00000";
            this.mtbY.Name = "mtbY";
            this.mtbY.Size = new System.Drawing.Size(40, 23);
            this.mtbY.TabIndex = 2;
            this.mtbY.ValidatingType = typeof(int);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(185, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(36, 23);
            this.btnColor.TabIndex = 6;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(338, 67);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(40, 23);
            this.tbWidth.TabIndex = 7;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(273, 73);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(59, 15);
            this.lbWidth.TabIndex = 8;
            this.lbWidth.Text = "PenWidth";
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.mtbY);
            this.Controls.Add(this.mtbX);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "secondForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.secondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        internal System.Windows.Forms.MaskedTextBox mtbX;
        internal System.Windows.Forms.MaskedTextBox mtbY;
        private System.Windows.Forms.ColorDialog cDColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lbWidth;
    }
}