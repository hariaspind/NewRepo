using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Individual> individuals = new List<Individual>();
            Individual ind = new Individual();
            ind.FirstName = txtFirstName.Text;

            individuals.Add(ind);


            GvFamilyData.DataSource= individuals; 
        }
    }
    public class Individual {
        public string  FirstName {get;set;}
        public string LastName { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
    }
}
