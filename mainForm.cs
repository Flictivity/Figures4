//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System;
using System.Drawing;
using System.Windows.Forms;


namespace GeometricFigures3
{
    public partial class mainForm : Form
    {
        internal Figures figuresList = new Figures();
        public mainForm()
        {
            InitializeComponent();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            secondForm f2 = new secondForm(this, Rectangle);
            f2.Show();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            secondForm f2 = new secondForm(this, Triangle);
            f2.Show();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            secondForm f2 = new secondForm(this, Circle);
            f2.Show();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            secondForm f2 = new secondForm(this, Line);
            f2.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximumSize = new Size(new Point(Width, Height));
            this.MinimumSize = new Size(new Point(Width, Height));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            figuresList.Clear();
            pPol1.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sFDSave.DefaultExt = ".pic";
            sFDSave.Filter = "Figures img (.pic) |*.pic";
            try
            {
                if(sFDSave.ShowDialog() == DialogResult.OK)
                {
                    string path = sFDSave.FileName;
                    figuresList.Save(path);
                }
            }
            catch
            {
                MessageBox.Show("Not correct path or file name");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(oFDOpen.ShowDialog() == DialogResult.OK)
                {
                    string path = oFDOpen.FileName;
                    figuresList.Load(path);
                }
            }
            catch
            {
                MessageBox.Show("Not correct path");
            }
            try
            {
                figuresList.Draw(pPol1.CreateGraphics());
            }
            catch
            {
                MessageBox.Show("Can not draw figures");
            }
        }

        private void pPol1_Paint(object sender, PaintEventArgs e)
        {
            figuresList.Draw(e.Graphics);
        }
    }
}