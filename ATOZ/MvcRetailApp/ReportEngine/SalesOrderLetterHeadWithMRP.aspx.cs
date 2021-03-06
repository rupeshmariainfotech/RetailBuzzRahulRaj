﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using CodeFirstServices.Interfaces;
using CodeFirstServices.Services;
using System.IO;

namespace MvcRetailApp.ReportEngine
{
    public partial class SalesOrderLetterHeadWithMRP : System.Web.UI.Page
    {
        public int Decode(string decodeMe)
        {
            byte[] decoded = Convert.FromBase64String(decodeMe);
            string decodedvalue = System.Text.Encoding.UTF8.GetString(decoded);
            return Convert.ToInt32(decodedvalue);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.Reset();
                string id = Request.QueryString["id"];
                int SalesOrderId = Decode(id);
                ReportDataSource rds1 = new ReportDataSource("DataSet2", GetDs1(SalesOrderId));
                ReportDataSource rds = new ReportDataSource("DataSet1", GetDs(SalesOrderId));
                ReportViewer1.LocalReport.DataSources.Add(rds1);
                ReportViewer1.LocalReport.DataSources.Add(rds);
                ReportViewer1.LocalReport.ReportPath = "ReportEngine/SalesOrderLetterHeadWithMRP.rdlc";
                ReportViewer1.LocalReport.Refresh();
                Warning[] warnings;
                string[] streamIds;
                string mimetype = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string title = "Retail Bill";
                byte[] bytes = ReportViewer1.LocalReport.Render("PDF", null, out mimetype, out encoding, out extension, out streamIds, out warnings);
                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.BinaryWrite(bytes);
                Response.End();
                string filename = "SalesOrder.pdf";
                string path = Server.MapPath("C");
                FileStream file = new FileStream(path + "/" + filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                file.Write(bytes, 0, bytes.Length);
                file.Dispose();

                Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", "SalesOrderLetterHeadWithMRP.aspx?file=" + filename));
            }
        }

        private DataTable GetDs(int SOId)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["RetailManagementConnectionString"].ConnectionString);
            string SalesOrderNo = Session["SalesOrderNo"].ToString();
            SqlDataAdapter adp1 = new SqlDataAdapter("select * from SalesOrderItems where OrderNo='" + SalesOrderNo + "'", con);
            DataSet ds1 = new DataSet();
            con.Open();
            adp1.Fill(ds1);
            return ds1.Tables[1];
        }

        private DataTable GetDs1(int SOId)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["RetailManagementConnectionString"].ConnectionString);
            SqlDataAdapter adp2 = new SqlDataAdapter("select * from SalesOrders where Id=" + SOId, con);
            DataSet ds2 = new DataSet();
            con.Open();
            adp2.Fill(ds2);

            //find sales order no using primary key
            string SalesOrderNo = ds2.Tables[1].Rows[0]["OrderNo"].ToString();
            Session["SalesOrderNo"] = SalesOrderNo;
            return ds2.Tables[1];
        }


    }
}