using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dorms_and_Meals;

namespace Dorm_and_Meals
{
    public partial class Form1 : Form
    {
        string Dorm_Selection;
        Double Allen_Hall = 1500;
        Double Pike_Hall = 1600;
        Double Farthing_Hall = 1800;
        Double University_Hall = 2500;
        Double Dorm_Cost;
        Double Dorm_Price;
        Double Meal_Cost;
        Double Seven_Meals = 600;
        Double Fourteen_Meals = 1200;
        Double Unl_Meals = 1700;
        Double Toal_Price;
        public static double total;

        public Form1()
        {
            InitializeComponent();
        }

        public Double Calculate(double total)
        {
            total = Dorm_Price + Meal_Cost;
            return total;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if
              (lstDorms.SelectedIndex != -1)
            {
                Dorm_Selection = lstDorms.SelectedItem.ToString();
                switch (Dorm_Selection)
                {

                    case "Allen Hall $1,500":
                        Dorm_Price = Allen_Hall;
                        break;
                    case " Pike Hall $1,600":
                        Dorm_Price = Pike_Hall;
                        break;
                    case "Farthing Hall $1,800":
                        Dorm_Price = Farthing_Hall;
                        break;
                    case "University Suites $2,500":
                        Dorm_Price = University_Hall;
                        break;

                }

                if (radSeven.Checked)
                {
                    Meal_Cost = Seven_Meals;
                }

                if (rdbFourteen.Checked)
                {
                    Meal_Cost = Fourteen_Meals;
                }

                if (rdbUnlimited.Checked)
                {
                    Meal_Cost = Unl_Meals;
                }

            }

            //myMsg = whatever you want to display in the Total form
            //questions?
            //I'll github host it
            //well same thing as putting it up on my github page, just a new repo
            //The important thing to remember about the Total.cs form is that you need to have TWO constructors, one that will be the default
            //one that has the "string msg" argument in its list of args for that constructor

            //Total myTotal = new Total(myMsg);

            //So it is at the end of the buttonClk event handler
            //np
            //I'll put this on github now and shoot you a linkypoo
            //you too bud kbye

        }
    }
}
    



