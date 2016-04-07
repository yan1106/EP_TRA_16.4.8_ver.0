using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Query_npiEATra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

  


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index;
        int i = 0;
        index = Convert.ToInt32(e.CommandArgument);
        GridViewRow selecteRow = GridView1.Rows[index];
        TableCell productName_Device = selecteRow.Cells[1];
        TableCell productName_Production_Site = selecteRow.Cells[2];
        TableCell productName_PKG = selecteRow.Cells[3];
        TableCell productName_Wafer = selecteRow.Cells[4];
        TableCell productName_fab = selecteRow.Cells[5];
        TableCell productWaferPSV = selecteRow.Cells[6];
        TableCell productRVSI = selecteRow.Cells[7];
        TableCell productCustomer = selecteRow.Cells[8];



        if (e.CommandName == "search")
        {


        

     

        }
    }


    

    protected void Search_Device_Eptra_table(object sender, EventArgs e)
    {
        string str_eptraver_main = "select * from npieptraver_main where Ver_New_Customer = '" + Customer_TB.Text + "'and Ver_New_Device= '" + ND_TB.Text + "' and Ver_Status = 'Y' ";

        clsMySQL db = new clsMySQL(); //Connection MySQL
        clsMySQL.DBReply dr = db.QueryDS(str_eptraver_main);
        GridView1.DataSource = dr.dsDataSet.Tables[0].DefaultView;
        GridView1.DataBind();
        db.Close();

    }

    protected void Customer_TB_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ND_TB_TextChanged1(object sender, EventArgs e)
    {

    }
}