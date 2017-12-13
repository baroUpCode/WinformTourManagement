using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Tour : Form
    {
        public Tour()
        {
            InitializeComponent();
            LoadTour();
        }
        public void LoadTour()
        {
            string query = "select * from dbo.TOUR";
            DataProvicder data = new DataProvicder();
            dtgvTour.DataSource = data.ExecuteQuery(query);
        }
    }
}
