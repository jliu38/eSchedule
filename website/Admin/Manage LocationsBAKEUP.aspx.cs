﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GeneralAdmin_Manage_Locations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void HandleCRUDErrors(object sender, ObjectDataSourceStatusEventArgs e)
    {
        LocationsWebUserControl.HandleDataBoundException(e);
    }
}