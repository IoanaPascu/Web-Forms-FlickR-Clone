﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/LogIn.aspx");
    }
    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/LogIn.aspx");
    }
    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SignUp.aspx");
    }
    protected void btnProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/About.aspx");
    }
    protected void btnNotifications_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Notifications.aspx");
    }
    protected void btnSettings_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Settings.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string input = txtSearch.Text;

        Response.Redirect("~/Default.aspx?search=" + input);
    }
}
