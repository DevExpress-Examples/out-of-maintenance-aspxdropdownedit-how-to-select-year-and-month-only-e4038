using DevExpress.Web;
using DevExpress.Web.ASPxEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class DateTemplate : ITemplate
{
    public void InstantiateIn(Control container)
    {
        container.Controls.Add(new LiteralControl("<table  class='tab'"));
        container.Controls.Add(new LiteralControl("<tr>"));

        container.Controls.Add(new LiteralControl("<td class='cell' align='left'>"));
        ASPxButton btPrev = new ASPxButton();
        btPrev.ID = "btPrev";
        container.Controls.Add(btPrev);
        btPrev.EnableDefaultAppearance = false;
        btPrev.CssClass = "buttonMonth";
        btPrev.Width = 10;
        btPrev.ClientSideEvents.Click = "OnPrevClick";
        btPrev.AutoPostBack = false;
        btPrev.Text = "<";
        container.Controls.Add(new LiteralControl("</td>"));

        container.Controls.Add(new LiteralControl("<td class='cell' style='text-align: center'>"));
        ASPxLabel label = new ASPxLabel();
        label.ID = "YearLabel";
        container.Controls.Add(label);
        label.Text = DateTime.Now.Year.ToString();
        label.ClientInstanceName = "lblYear";
        container.Controls.Add(new LiteralControl("</td>"));

        container.Controls.Add(new LiteralControl("<td class='cell' align='right'>"));
        ASPxButton btNext = new ASPxButton();
        btNext.ID = "btNext";
        container.Controls.Add(btNext);
        btNext.AutoPostBack = false;
        btNext.EnableDefaultAppearance = false;
        btNext.CssClass = "buttonMonth";
        btNext.Width = 10;
        btNext.Text = ">";
        btNext.ClientSideEvents.Click = "OnNextClick";
        container.Controls.Add(new LiteralControl("</td>"));

        container.Controls.Add(new LiteralControl("</tr>"));
        container.Controls.Add(new LiteralControl("</table>"));

        container.Controls.Add(new LiteralControl("<table  class='tab'>"));
        int k = 1;
        for (int i = 0; i < 3; i++)
        {
            container.Controls.Add(new LiteralControl("<tr>"));
            for (int j = 0; j < 4; j++)
            {
                container.Controls.Add(new LiteralControl("<td class='cell'>"));
                ASPxButton button = new ASPxButton();
                button.ID = "btn#" + k;
                container.Controls.Add(button);
                button.AutoPostBack = false;
                button.EnableDefaultAppearance = false;
                button.Width = 50;
                button.CssClass = "buttonMonth";
                button.FocusRectBorder.BorderWidth = 1;
                button.ClientSideEvents.Click = "OnClick";
                button.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(k);
                container.Controls.Add(new LiteralControl("</td>"));
                k++;
            }
            container.Controls.Add(new LiteralControl("</tr>"));
        }
        container.Controls.Add(new LiteralControl("</table>"));


        container.Controls.Add(new LiteralControl("<center  class='tab'>"));
        ASPxButton btOk = new ASPxButton();
        btOk.ID = "BtOk";
        container.Controls.Add(btOk);
        btOk.AutoPostBack = false;
        btOk.Text = "OK";
        btOk.Width = Unit.Percentage(100);
        btOk.ClientSideEvents.Click = "OnOkClick";
        container.Controls.Add(new LiteralControl("</center>"));
    }
}