﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Default
{
    public partial class trial : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litSearch.Text = Request.QueryString["searchFields"];
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
        
        }
    }
}