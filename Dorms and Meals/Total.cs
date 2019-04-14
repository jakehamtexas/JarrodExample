using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_and_Meals
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }

        public Total(string msg)
        {
            //both include InitializeComponent()
            //When you have multiple constructors you can initalize an object more than one way, and if there are special instructions
            //for the constructed type, you can add them in for that specified constructor
            InitializeComponent();

            //like here
            lblOutput.Text = msg;

            //You may need to use Application.Run() on the form object
            //I think there is also a ShowWindow method or something simliar, google will help
        }
    }
}
