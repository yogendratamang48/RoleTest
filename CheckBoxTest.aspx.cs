using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoleTest
{
    public partial class CheckBoxTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grvWorkatHouseFirstGridViewRow();
            }
        }
        #region For ३८. तपाईको परिवारमा निम्न कार्यहरु प्राय कसले गर्दछ ? (दुवै भए दुवैमा ठिक लगाउने)(grvWorkatHouse)
        private void grvWorkatHouseFirstGridViewRow()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Col1", typeof(string)));
            dt.Columns.Add(new DataColumn("Col2", typeof(string)));
            dt.Columns.Add(new DataColumn("Col3", typeof(string)));
            dr = dt.NewRow();
            dr["RowNumber"] = 1;
            dr["Col1"] = string.Empty;
            dr["Col2"] = string.Empty;
            dr["Col3"] = string.Empty;
            dt.Rows.Add(dr);
            ViewState["CurrentTablegrvWorkatHouse"] = dt;
            grvWorkatHouse.DataSource = dt;
            grvWorkatHouse.DataBind();
        }
        private void grvWorkatHouseAddNewRow()
        {
            int rowIndex = 0;
            if (ViewState["CurrentTablegrvWorkatHouse"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTablegrvWorkatHouse"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {
                        DropDownList ddlgrvWorkatHouseWork = (DropDownList)grvWorkatHouse.Rows[rowIndex].Cells[1].FindControl("ddlgrvWorkatHouseWork");
                        CheckBox ckbgrvWorkatHouseMale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[2].FindControl("ckbgrvWorkatHouseMale");
                        CheckBox ckbgrvWorkatHouseFemale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[3].FindControl("ckbgrvWorkatHouseFemale");
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["RowNumber"] = i + 1;
                        dtCurrentTable.Rows[i - 1]["Col1"] = ddlgrvWorkatHouseWork.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Col2"] = ckbgrvWorkatHouseMale.Checked;
                        dtCurrentTable.Rows[i - 1]["Col3"] = ckbgrvWorkatHouseFemale.Checked;
                        rowIndex++;
                    }
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    ViewState["CurrentTablegrvWorkatHouse"] = dtCurrentTable;
                    grvWorkatHouse.DataSource = dtCurrentTable;
                    grvWorkatHouse.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }
            grvWorkatHouseSetPreviousData();
        }
        private void grvWorkatHouseSetPreviousData()
        {
            int rowIndex = 0;
            if (ViewState["CurrentTablegrvWorkatHouse"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTablegrvWorkatHouse"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DropDownList ddlgrvWorkatHouseWork = (DropDownList)grvWorkatHouse.Rows[rowIndex].Cells[1].FindControl("ddlgrvWorkatHouseWork");
                        CheckBox ckbgrvWorkatHouseMale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[2].FindControl("ckbgrvWorkatHouseMale");
                        
                        CheckBox ckbgrvWorkatHouseFemale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[3].FindControl("ckbgrvWorkatHouseFemale");
                        if (i<dt.Rows.Count - 1)
                        {


                            ckbgrvWorkatHouseMale.Checked = Convert.ToBoolean(dt.Rows[i][2].ToString());
                            ckbgrvWorkatHouseFemale.Checked = Convert.ToBoolean(dt.Rows[i][3].ToString());
                        }

                        grvWorkatHouse.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                        ddlgrvWorkatHouseWork.SelectedValue = dt.Rows[i]["Col1"].ToString();

                        rowIndex++;
                    }
                }
            }
        }
        protected void grvWorkatHouseAdd_Click(object sender, EventArgs e)
        {
            grvWorkatHouseAddNewRow();
        }
        protected void grvWorkatHouse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            grvWorkatHouseSetRowData();
            if (ViewState["CurrentTablegrvWorkatHouse"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTablegrvWorkatHouse"];
                DataRow drCurrentRow = null;
                int rowIndex = Convert.ToInt32(e.RowIndex);
                if (dt.Rows.Count > 1)
                {
                    dt.Rows.Remove(dt.Rows[rowIndex]);
                    drCurrentRow = dt.NewRow();
                    ViewState["CurrentTablegrvWorkatHouse"] = dt;
                    grvWorkatHouse.DataSource = dt;
                    grvWorkatHouse.DataBind();

                    for (int i = 0; i < grvWorkatHouse.Rows.Count - 1; i++)
                    {
                        grvWorkatHouse.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                    }
                    grvWorkatHouseSetPreviousData();
                }
            }
        }
        private void grvWorkatHouseSetRowData()
        {
            int rowIndex = 0;

            if (ViewState["CurrentTablegrvWorkatHouse"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTablegrvWorkatHouse"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {
                        DropDownList ddlgrvWorkatHouseWork = (DropDownList)grvWorkatHouse.Rows[rowIndex].Cells[1].FindControl("ddlgrvWorkatHouseWork");
                        CheckBox ckbgrvWorkatHouseMale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[2].FindControl("ckbgrvWorkatHouseMale");
                        CheckBox ckbgrvWorkatHouseFemale = (CheckBox)grvWorkatHouse.Rows[rowIndex].Cells[3].FindControl("ckbgrvWorkatHouseFemale");
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["RowNumber"] = i + 1;
                        dtCurrentTable.Rows[i - 1]["Col1"] = ddlgrvWorkatHouseWork.SelectedValue;
                        dtCurrentTable.Rows[i - 1]["Col2"] = ckbgrvWorkatHouseMale.Checked;
                        dtCurrentTable.Rows[i - 1]["Col3"] = ckbgrvWorkatHouseFemale.Checked;
                        rowIndex++;
                    }
                    ViewState["CurrentTablegrvWorkatHouse"] = dtCurrentTable;
                }
            }
            else
            {
                Response.Write("ViewState is null");
            }
        }
        #endregion
    }
}