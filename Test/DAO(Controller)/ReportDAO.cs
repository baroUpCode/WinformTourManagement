using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO_Controller_
{
    class ReportDAO
    {
        private static ReportDAO instance;

        internal static ReportDAO Instance {
            get { if (instance == null) instance = new ReportDAO();
                return ReportDAO.instance; }
            set => ReportDAO.instance = value;
        }
    }
}
