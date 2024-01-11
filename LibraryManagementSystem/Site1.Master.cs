using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]==null || Session["role"].Equals(""))
                {
                    LinkButton1.Visible=true;
                    LinkButton2.Visible = true; // user login
                    LinkButton3.Visible = true; // user sign up
                    LinkButton4.Visible = false; // logout
                    LinkButton5.Visible = false; // hello user

                    LinkButton17.Visible = true; // admin login
                    LinkButton18.Visible = false; // author management
                    LinkButton19.Visible = false; // publisher management
                    LinkButton20.Visible = false; // book inventory
                    LinkButton21.Visible = false; // book issue
                    LinkButton22.Visible = false; // member management
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = false; // user login
                    LinkButton3.Visible = false; // user sign up
                    LinkButton4.Visible = true; // logout
                    LinkButton5.Visible = true; // hello user
                    LinkButton5.Text = "Hello " + Session["username"].ToString();

                    LinkButton17.Visible = true; // admin login
                    LinkButton18.Visible = false; // author management
                    LinkButton19.Visible = false; // publisher management
                    LinkButton20.Visible = false; // book inventory
                    LinkButton21.Visible = false; // book issue
                    LinkButton22.Visible = false; // member management
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = false; // user login
                    LinkButton3.Visible = false; // user sign up
                    LinkButton4.Visible = true; // logout
                    LinkButton5.Visible = true; // hello user
                    LinkButton5.Text = "Hello Admin";

                    LinkButton17.Visible = false; // admin login
                    LinkButton18.Visible = true; // author management
                    LinkButton19.Visible = true; // publisher management
                    LinkButton20.Visible = true; // book inventory
                    LinkButton21.Visible = true; // book issue
                    LinkButton22.Visible = true; // member management
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            Response.Redirect("authormanagement.aspx");
        }

        protected void LinkButton19_Click(object sender, EventArgs e)
        {
            Response.Redirect("publishermanagement.aspx");
        }

        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookinventory.aspx");
        }

        protected void LinkButton21_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookissue.aspx");
        }

        protected void LinkButton22_Click(object sender, EventArgs e)
        {
            Response.Redirect("membermanagement.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }
        // logout button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton2.Visible = true; // user login
            LinkButton3.Visible = true; // user sign up
            LinkButton4.Visible = false; // logout
            LinkButton5.Visible = false; // hello user

            LinkButton17.Visible = true; // admin login
            LinkButton18.Visible = false; // author management
            LinkButton19.Visible = false; // publisher management
            LinkButton20.Visible = false; // book inventory
            LinkButton21.Visible = false; // book issue
            LinkButton22.Visible = false; // member management
            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}