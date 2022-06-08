//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures3
{
    public partial class secondForm : Form
    {
        private string figureType;
        mainForm parentForm;

        private MaskedTextBox mtbW;
        private MaskedTextBox mtbH;

        private MaskedTextBox mtbTriangleX1;
        private MaskedTextBox mtbTriangleY1;
        private MaskedTextBox mtbTriangleX2;
        private MaskedTextBox mtbTriangleY2;

        private MaskedTextBox mtbCircleRadius;

        private MaskedTextBox mtbLineX1;
        private MaskedTextBox mtbLineY1;

        public secondForm()
        {
            InitializeComponent();
        }
        public secondForm(mainForm parent, ToolStripButton figType)
        {
            InitializeComponent();
            parentForm = parent;
            figureType = figType.Name;

            var lbNameForm = new Label();
            lbNameForm.Location = new Point(1, 1);
            lbNameForm.Size = new Size(310, 100);
            lbNameForm.Font = new Font(new FontFamily("Comic Sans MS"), 15, FontStyle.Bold);
            this.Controls.Add(lbNameForm);

            switch (figureType)
            {
                case "Rectangle":
                    lbNameForm.Text = "Rectangle params";

                    //------Rectangle Width------
                    mtbW = new MaskedTextBox();
                    mtbW.Size = new Size(40, 30);
                    mtbW.Location = new Point(185, 185);
                    mtbW.Mask = "00000";

                    var lbW = new Label();
                    lbW.Size = new Size(50, 15);
                    lbW.Location = new Point(147, 190);
                    lbW.Text = "Width";

                    //------Rectangle Height------
                    mtbH = new MaskedTextBox();
                    mtbH.Size = new Size(40, 30);
                    mtbH.Location = new Point(322, 185);
                    mtbH.Mask = "00000";

                    var lbH = new Label();
                    lbH.Size = new Size(50, 15);
                    lbH.Location = new Point(282, 190);
                    lbH.Text = "Height";

                    //------Add------
                    this.Controls.Add(mtbW);
                    this.Controls.Add(lbW);
                    this.Controls.Add(mtbH);
                    this.Controls.Add(lbH);
                    break;
                case "Triangle":
                    lbNameForm.Text = "Triangle params";

                    //------Triangle Second Point------
                    mtbTriangleX1 = new MaskedTextBox();
                    mtbTriangleX1.Size = new Size(40, 23);
                    mtbTriangleX1.Location = new Point(185, 178);
                    mtbTriangleX1.Mask = "00000";

                    var lbTrinagleX1 = new Label();
                    lbTrinagleX1.Size = new Size(26, 15);
                    lbTrinagleX1.Location = new Point(162, 180);
                    lbTrinagleX1.Text = "X1";

                    mtbTriangleY1 = new MaskedTextBox();
                    mtbTriangleY1.Size = new Size(40, 23);
                    mtbTriangleY1.Location = new Point(322, 178);
                    mtbTriangleY1.Mask = "00000";

                    var lbTrinagleY1 = new Label();
                    lbTrinagleY1.Size = new Size(30, 15);
                    lbTrinagleY1.Location = new Point(299, 180);
                    lbTrinagleY1.Text = "Y1";

                    //------Triangle Third Point------

                    mtbTriangleX2 = new MaskedTextBox();
                    mtbTriangleX2.Size = new Size(40, 23);
                    mtbTriangleX2.Location = new Point(185, 220);
                    mtbTriangleX2.Mask = "00000";

                    var lbTrinagleX2 = new Label();
                    lbTrinagleX2.Size = new Size(26, 15);
                    lbTrinagleX2.Location = new Point(162, 222);
                    lbTrinagleX2.Text = "X2";

                    mtbTriangleY2 = new MaskedTextBox();
                    mtbTriangleY2.Size = new Size(40, 23);
                    mtbTriangleY2.Location = new Point(322, 220);
                    mtbTriangleY2.Mask = "00000";

                    var lbTrinagleY2 = new Label();
                    lbTrinagleY2.Size = new Size(30, 15);
                    lbTrinagleY2.Location = new Point(299, 222);
                    lbTrinagleY2.Text = "Y2";

                    //------Add------
                    this.Controls.Add(mtbTriangleX1);
                    this.Controls.Add(lbTrinagleX1);
                    this.Controls.Add(mtbTriangleY1);
                    this.Controls.Add(lbTrinagleY1);
                    this.Controls.Add(mtbTriangleX2);
                    this.Controls.Add(lbTrinagleX2);
                    this.Controls.Add(mtbTriangleY2);
                    this.Controls.Add(lbTrinagleY2);
                    break;

                case "Circle":
                    lbNameForm.Text = "Circle params";

                    //------Circle Radius------
                    mtbCircleRadius = new MaskedTextBox();
                    mtbCircleRadius.Size = new Size(40, 23);
                    mtbCircleRadius.Location = new Point(250, 185);
                    mtbCircleRadius.Mask = "00000";

                    var lbCircleRadius = new Label();
                    lbCircleRadius.Size = new Size(50, 15);
                    lbCircleRadius.Location = new Point(210, 190);
                    lbCircleRadius.Text = "Radius";

                    //------Add------
                    this.Controls.Add(mtbCircleRadius);
                    this.Controls.Add(lbCircleRadius);
                    break;
                case "Line":
                    lbNameForm.Text = "Line params";

                    //------Line Second Point------
                    mtbLineX1 = new MaskedTextBox();
                    mtbLineX1.Size = new Size(40, 23);
                    mtbLineX1.Location = new Point(185, 178);
                    mtbLineX1.Mask = "00000";

                    var lbLineX1 = new Label();
                    lbLineX1.Size = new Size(50, 15);
                    lbLineX1.Location = new Point(162, 180);
                    lbLineX1.Text = "X1";

                    mtbLineY1 = new MaskedTextBox();
                    mtbLineY1.Size = new Size(40, 23);
                    mtbLineY1.Location = new Point(322, 178);
                    mtbLineY1.Mask = "00000";

                    var lbLineY1 = new Label();
                    lbLineY1.Size = new Size(50, 15);
                    lbLineY1.Location = new Point(299, 180);
                    lbLineY1.Text = "Y1";

                    //------Add------
                    this.Controls.Add(mtbLineX1);
                    this.Controls.Add(mtbLineY1);
                    this.Controls.Add(lbLineX1);
                    this.Controls.Add(lbLineY1);
                    break;
            }
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{figureType} draw window");    
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FilledFigure figure;
            try
            {
                switch (figureType)
                {
                    case "Rectangle":
                        var startPoint = new MyPoint(int.Parse(mtbX.Text), int.Parse(mtbY.Text));
                        int width = int.Parse(mtbW.Text);
                        int height = int.Parse(mtbH.Text);

                        figure = new Rectangle(startPoint, width, height);
                        break;
                    case "Triangle":
                        startPoint = new MyPoint(int.Parse(mtbX.Text), int.Parse(mtbY.Text));
                        var secondPoint = new MyPoint(int.Parse(mtbTriangleX1.Text), int.Parse(mtbTriangleY1.Text));
                        var thirdPoint = new MyPoint(int.Parse(mtbTriangleX2.Text), int.Parse(mtbTriangleY2.Text));

                        figure = new Triangle(startPoint, secondPoint, thirdPoint);
                        break;
                    case "Circle":
                        startPoint = new MyPoint(int.Parse(mtbX.Text), int.Parse(mtbY.Text));
                        int radius = int.Parse(mtbCircleRadius.Text);
                        figure = new Circle(startPoint, radius);
                        break;
                    case "Line":
                        int x0 = int.Parse(mtbX.Text);
                        int y0 = int.Parse(mtbY.Text);
                        int x1 = int.Parse(mtbLineX1.Text);
                        int y1 = int.Parse(mtbLineY1.Text);

                        figure = new Line(x0, y0, x1, y1);
                        break;
                    default:
                        throw new Exception("Non button");
                }

                try
                {
                    figure.Stroke.Width = int.Parse(tbWidth.Text);
                    figure.Stroke.Color = cDColor.Color;
                    parentForm.figuresList.Add(figure);
                    parentForm.pPol1.Invalidate();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Cant draw figure with input params");
                }
            }
            catch
            {
                MessageBox.Show("Input data is not correct format");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cDColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cDColor.Color;
            }
        }
    }
}
