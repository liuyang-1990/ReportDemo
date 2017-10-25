using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using ReportDemo.Dao;

namespace ReportDemo.ReportPage
{
    public partial class UserReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadReport();
            }
        }

        private void LoadReport()
        {
            var db = SugarDao.GetInstance();
            var dt = db.Queryable<User>().ToDataTable();
            userReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            userReport.LocalReport.Refresh();
        }
    }
}