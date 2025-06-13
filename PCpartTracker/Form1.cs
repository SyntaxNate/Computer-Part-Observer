using System;
using System.Windows.Forms;

namespace PCpartTracker
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            this.Text = "GPU Price Tracker";


            Label welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome to the GPU Price Tracker!";
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new System.Drawing.Point(20, 20);

            this.Controls.Add(welcomeLabel);
        }
    }
}