﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void okButton_Click(object sender, EventArgs e)
    {
        resultLabel.Text = "";

        if (pencilRadioButton.Checked)
        {
            resultImage.ImageUrl = "pencil.png";
            resultLabel.Text = "You selected pencil!";
        }
        else if (penRadioButton.Checked)
        {
            resultImage.ImageUrl = "pen.png";
            resultLabel.Text = "You selected pen!";
        }
        else if (phoneRadioButton.Checked)
        {
            resultImage.ImageUrl = "phone.png";
            resultLabel.Text = "You selected phone!";
        }
        else if (tabletRadioButton.Checked)
        {
            resultImage.ImageUrl = "tablet.png";
            resultLabel.Text = "You selected tablet!";
        }
        else
        {
            resultLabel.Text = "Please select an option";
        }
    }
}