Imports DevExpress.Web
Imports System
Imports System.Globalization
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class DateTemplate
	Implements ITemplate

	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		container.Controls.Add(New LiteralControl("<table  class='tab'"))
		container.Controls.Add(New LiteralControl("<tr>"))

		container.Controls.Add(New LiteralControl("<td class='cell' align='left'>"))
		Dim btPrev As New ASPxButton()
		btPrev.ID = "btPrev"
		container.Controls.Add(btPrev)
		btPrev.RenderMode = ButtonRenderMode.Link
		btPrev.CssClass = "buttonMonth"
		btPrev.Width = 10
		btPrev.ClientSideEvents.Click = "OnPrevClick"
		btPrev.AutoPostBack = False
		btPrev.Text = "<"
		container.Controls.Add(New LiteralControl("</td>"))

		container.Controls.Add(New LiteralControl("<td class='cell' style='text-align: center'>"))
		Dim label As New ASPxLabel()
		label.ID = "YearLabel"
		container.Controls.Add(label)
		label.Text = Date.Now.Year.ToString()
		label.ClientInstanceName = "lblYear"
		container.Controls.Add(New LiteralControl("</td>"))

		container.Controls.Add(New LiteralControl("<td class='cell' align='right'>"))
		Dim btNext As New ASPxButton()
		btNext.ID = "btNext"
		container.Controls.Add(btNext)
		btNext.AutoPostBack = False
		btNext.RenderMode = ButtonRenderMode.Link
		btNext.CssClass = "buttonMonth"
		btNext.Width = 10
		btNext.Text = ">"
		btNext.ClientSideEvents.Click = "OnNextClick"
		container.Controls.Add(New LiteralControl("</td>"))

		container.Controls.Add(New LiteralControl("</tr>"))
		container.Controls.Add(New LiteralControl("</table>"))

		container.Controls.Add(New LiteralControl("<table  class='tab'>"))
		Dim k As Integer = 1
		For i As Integer = 0 To 2
			container.Controls.Add(New LiteralControl("<tr>"))
			For j As Integer = 0 To 3
				container.Controls.Add(New LiteralControl("<td class='cell'>"))
				Dim button As New ASPxButton()
				button.ID = "btn#" & k
				container.Controls.Add(button)
				button.AutoPostBack = False
				button.RenderMode = ButtonRenderMode.Link
				button.Width = 50
				button.CssClass = "buttonMonth"
				button.FocusRectBorder.BorderWidth = 1
				button.ClientSideEvents.Click = "OnClick"
				button.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(k)
				container.Controls.Add(New LiteralControl("</td>"))
				k += 1
			Next j
			container.Controls.Add(New LiteralControl("</tr>"))
		Next i
		container.Controls.Add(New LiteralControl("</table>"))


		container.Controls.Add(New LiteralControl("<center  class='tab'>"))
		Dim btOk As New ASPxButton()
		btOk.ID = "BtOk"
		container.Controls.Add(btOk)
		btOk.AutoPostBack = False
		btOk.Text = "OK"
		btOk.Width = Unit.Percentage(100)
		btOk.ClientSideEvents.Click = "OnOkClick"
		container.Controls.Add(New LiteralControl("</center>"))
	End Sub
End Class