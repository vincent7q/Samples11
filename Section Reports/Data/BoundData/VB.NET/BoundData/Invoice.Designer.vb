﻿ _
Partial Class Invoice
    Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtProductname = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblNorthWind = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNWAddr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNWAddr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblInvoice = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblOrderNum = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.imgLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.lblThankYou = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblBillTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShipTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lneBillTo = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lneShipTo = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtBillToCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBillToAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBillToCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBillToRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBillToPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtBillToCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtShipToCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSalesPerson = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblSalesPerson = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblShipped = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtShipDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblShippedVia = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtShipper = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblQty = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSubTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblFreight = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblGrandTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtSubTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtFreight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.ghOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GFOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.ghOrderHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.ghTableHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        'txtProductID
        Me.txtProductID.CanGrow = False
        Me.txtProductID.DataField = "ProductID"
        resources.ApplyResources(Me.txtProductID, "txtProductID")
        Me.txtProductID.Name = "txtProductID"
        'txtProductname
        Me.txtProductname.CanGrow = False
        Me.txtProductname.DataField = "ProductName"
        resources.ApplyResources(Me.txtProductname, "txtProductname")
        Me.txtProductname.Name = "txtProductname"
        'txtQty
        Me.txtQty.CanGrow = False
        Me.txtQty.DataField = "Quantity"
        resources.ApplyResources(Me.txtQty, "txtQty")
        Me.txtQty.Name = "txtQty"
        'txtUnitPrice
        Me.txtUnitPrice.CanGrow = False
        Me.txtUnitPrice.DataField = "UnitPrice"
        resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
        Me.txtUnitPrice.Name = "txtUnitPrice"
        'txtDiscount
        Me.txtDiscount.CanGrow = False
        Me.txtDiscount.DataField = "Discount"
        resources.ApplyResources(Me.txtDiscount, "txtDiscount")
        Me.txtDiscount.Name = "txtDiscount"
        'txtExtended
        Me.txtExtended.CanGrow = False
        Me.txtExtended.DataField = "ExtendedPrice"
        resources.ApplyResources(Me.txtExtended, "txtExtended")
        Me.txtExtended.Name = "txtExtended"
        'lblNorthWind
        resources.ApplyResources(Me.lblNorthWind, "lblNorthWind")
        Me.lblNorthWind.Name = "lblNorthWind"
        'lblTraders
        resources.ApplyResources(Me.lblTraders, "lblTraders")
        Me.lblTraders.Name = "lblTraders"
        'lblNWAddr1
        resources.ApplyResources(Me.lblNWAddr1, "lblNWAddr1")
        Me.lblNWAddr1.Name = "lblNWAddr1"
        'lblNWAddr2
        resources.ApplyResources(Me.lblNWAddr2, "lblNWAddr2")
        Me.lblNWAddr2.Name = "lblNWAddr2"
        'lblInvoice
        resources.ApplyResources(Me.lblInvoice, "lblInvoice")
        Me.lblInvoice.Name = "lblInvoice"
        'lblOrderNum
        resources.ApplyResources(Me.lblOrderNum, "lblOrderNum")
        Me.lblOrderNum.Name = "lblOrderNum"
        'txtOrderID
        Me.txtOrderID.CanGrow = False
        Me.txtOrderID.DataField = "OrderID"
        resources.ApplyResources(Me.txtOrderID, "txtOrderID")
        Me.txtOrderID.Name = "txtOrderID"
        'lblOrderDate
        resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
        Me.lblOrderDate.Name = "lblOrderDate"
        'txtOrderDate
        Me.txtOrderDate.CanGrow = False
        Me.txtOrderDate.DataField = "OrderDate"
        resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
        Me.txtOrderDate.Name = "txtOrderDate"
        'imgLogo
        Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.imgLogo, "imgLogo")
        Me.imgLogo.ImageData = CType(resources.GetObject("imgLogo.ImageData"), System.IO.Stream)
        Me.imgLogo.LineColor = System.Drawing.Color.Black
        Me.imgLogo.LineWeight = 1.0!
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        'lblThankYou
        resources.ApplyResources(Me.lblThankYou, "lblThankYou")
        Me.lblThankYou.Name = "lblThankYou"
        'lblBillTo
        resources.ApplyResources(Me.lblBillTo, "lblBillTo")
        Me.lblBillTo.Name = "lblBillTo"
        'lblShipTo
        resources.ApplyResources(Me.lblShipTo, "lblShipTo")
        Me.lblShipTo.Name = "lblShipTo"
        'lneBillTo
        resources.ApplyResources(Me.lneBillTo, "lneBillTo")
        Me.lneBillTo.LineWeight = 2.0!
        Me.lneBillTo.Name = "lneBillTo"
        Me.lneBillTo.X1 = 0.0!
        Me.lneBillTo.X2 = 3.0!
        Me.lneBillTo.Y1 = 0.2!
        Me.lneBillTo.Y2 = 0.2!
        'lneShipTo
        resources.ApplyResources(Me.lneShipTo, "lneShipTo")
        Me.lneShipTo.LineWeight = 2.0!
        Me.lneShipTo.Name = "lneShipTo"
        Me.lneShipTo.X1 = 6.469!
        Me.lneShipTo.X2 = 3.469!
        Me.lneShipTo.Y1 = 0.2!
        Me.lneShipTo.Y2 = 0.2!
        'txtBillToCompany
        Me.txtBillToCompany.CanGrow = False
        Me.txtBillToCompany.DataField = "Customers.CompanyName"
        resources.ApplyResources(Me.txtBillToCompany, "txtBillToCompany")
        Me.txtBillToCompany.Name = "txtBillToCompany"
        'txtBillToAddress
        Me.txtBillToAddress.DataField = "Address"
        resources.ApplyResources(Me.txtBillToAddress, "txtBillToAddress")
        Me.txtBillToAddress.Name = "txtBillToAddress"
        'txtBillToCity
        Me.txtBillToCity.CanGrow = False
        Me.txtBillToCity.DataField = "City"
        resources.ApplyResources(Me.txtBillToCity, "txtBillToCity")
        Me.txtBillToCity.Name = "txtBillToCity"
        'txtBillToRegion
        Me.txtBillToRegion.CanGrow = False
        Me.txtBillToRegion.DataField = "Region"
        resources.ApplyResources(Me.txtBillToRegion, "txtBillToRegion")
        Me.txtBillToRegion.Name = "txtBillToRegion"
        'txtBillToPostalCode
        Me.txtBillToPostalCode.CanGrow = False
        Me.txtBillToPostalCode.DataField = "PostalCode"
        resources.ApplyResources(Me.txtBillToPostalCode, "txtBillToPostalCode")
        Me.txtBillToPostalCode.Name = "txtBillToPostalCode"
        'txtBillToCountry
        Me.txtBillToCountry.CanGrow = False
        Me.txtBillToCountry.DataField = "Country"
        resources.ApplyResources(Me.txtBillToCountry, "txtBillToCountry")
        Me.txtBillToCountry.Name = "txtBillToCountry"
        'txtShipToCompany
        Me.txtShipToCompany.CanGrow = False
        Me.txtShipToCompany.DataField = "ShipName"
        resources.ApplyResources(Me.txtShipToCompany, "txtShipToCompany")
        Me.txtShipToCompany.Name = "txtShipToCompany"
        'txtShipToAddress
        Me.txtShipToAddress.DataField = "ShipAddress"
        resources.ApplyResources(Me.txtShipToAddress, "txtShipToAddress")
        Me.txtShipToAddress.Name = "txtShipToAddress"
        'txtShipToCity
        Me.txtShipToCity.CanGrow = False
        Me.txtShipToCity.DataField = "ShipCity"
        resources.ApplyResources(Me.txtShipToCity, "txtShipToCity")
        Me.txtShipToCity.Name = "txtShipToCity"
        'txtShipToRegion
        Me.txtShipToRegion.CanGrow = False
        Me.txtShipToRegion.DataField = "ShipRegion"
        resources.ApplyResources(Me.txtShipToRegion, "txtShipToRegion")
        Me.txtShipToRegion.Name = "txtShipToRegion"
        'txtShipToPostalCode
        Me.txtShipToPostalCode.CanGrow = False
        Me.txtShipToPostalCode.DataField = "ShipPostalCode"
        resources.ApplyResources(Me.txtShipToPostalCode, "txtShipToPostalCode")
        Me.txtShipToPostalCode.Name = "txtShipToPostalCode"
        'txtShipToCountry
        Me.txtShipToCountry.CanGrow = False
        Me.txtShipToCountry.DataField = "ShipCountry"
        resources.ApplyResources(Me.txtShipToCountry, "txtShipToCountry")
        Me.txtShipToCountry.Name = "txtShipToCountry"
        'txtSalesPerson
        Me.txtSalesPerson.CanGrow = False
        Me.txtSalesPerson.DataField = "Salesperson"
        resources.ApplyResources(Me.txtSalesPerson, "txtSalesPerson")
        Me.txtSalesPerson.Name = "txtSalesPerson"
        'lblSalesPerson
        resources.ApplyResources(Me.lblSalesPerson, "lblSalesPerson")
        Me.lblSalesPerson.Name = "lblSalesPerson"
        'lblShipped
        resources.ApplyResources(Me.lblShipped, "lblShipped")
        Me.lblShipped.Name = "lblShipped"
        'txtShipDate
        Me.txtShipDate.CanGrow = False
        Me.txtShipDate.DataField = "ShippedDate"
        resources.ApplyResources(Me.txtShipDate, "txtShipDate")
        Me.txtShipDate.Name = "txtShipDate"
        'lblShippedVia
        resources.ApplyResources(Me.lblShippedVia, "lblShippedVia")
        Me.lblShippedVia.Name = "lblShippedVia"
        'txtShipper
        Me.txtShipper.CanGrow = False
        Me.txtShipper.DataField = "Shippers.CompanyName"
        resources.ApplyResources(Me.txtShipper, "txtShipper")
        Me.txtShipper.Name = "txtShipper"
        'lblProductID
        resources.ApplyResources(Me.lblProductID, "lblProductID")
        Me.lblProductID.Name = "lblProductID"
        'lblProductName
        resources.ApplyResources(Me.lblProductName, "lblProductName")
        Me.lblProductName.Name = "lblProductName"
        'lblQty
        resources.ApplyResources(Me.lblQty, "lblQty")
        Me.lblQty.Name = "lblQty"
        'lblUnitPrice
        resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
        Me.lblUnitPrice.Name = "lblUnitPrice"
        'lblDiscount
        resources.ApplyResources(Me.lblDiscount, "lblDiscount")
        Me.lblDiscount.Name = "lblDiscount"
        'lblTotal
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.Name = "lblTotal"
        'lblSubTotal
        resources.ApplyResources(Me.lblSubTotal, "lblSubTotal")
        Me.lblSubTotal.Name = "lblSubTotal"
        'lblFreight
        resources.ApplyResources(Me.lblFreight, "lblFreight")
        Me.lblFreight.Name = "lblFreight"
        'lblGrandTotal
        resources.ApplyResources(Me.lblGrandTotal, "lblGrandTotal")
        Me.lblGrandTotal.Name = "lblGrandTotal"
        'txtSubTotal
        Me.txtSubTotal.CanGrow = False
        Me.txtSubTotal.DataField = "ExtendedPrice"
        resources.ApplyResources(Me.txtSubTotal, "txtSubTotal")
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        'txtFreight
        Me.txtFreight.CanGrow = False
        Me.txtFreight.DataField = "Freight"
        resources.ApplyResources(Me.txtFreight, "txtFreight")
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        'txtTotal
        Me.txtTotal.CanGrow = False
        resources.ApplyResources(Me.txtTotal, "txtTotal")
        Me.txtTotal.Name = "txtTotal"
        'Label1
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        'Label2
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        'Label3
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        'Detail
        Me.Detail.CanGrow = False
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductID, Me.txtProductname, Me.txtQty, Me.txtUnitPrice, Me.txtDiscount, Me.txtExtended})
        Me.Detail.Height = 0.2!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        'PageHeader
        Me.PageHeader.CanGrow = False
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Visible = False
        'PageFooter
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblThankYou})
        Me.PageFooter.Height = 0.25!
        Me.PageFooter.Name = "PageFooter"
        'ghOrderID
        Me.ghOrderID.ColumnLayout = False
        Me.ghOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblBillTo, Me.lblShipTo, Me.lneBillTo, Me.lneShipTo, Me.txtBillToCompany, Me.txtBillToAddress, Me.txtBillToCity, Me.txtBillToRegion, Me.txtBillToPostalCode, Me.txtBillToCountry, Me.txtShipToCompany, Me.txtShipToAddress, Me.txtShipToCity, Me.txtShipToRegion, Me.txtShipToPostalCode, Me.txtShipToCountry, Me.txtSalesPerson, Me.lblSalesPerson, Me.lblShipped, Me.txtShipDate, Me.lblShippedVia, Me.txtShipper})
        Me.ghOrderID.DataField = "OrderID"
        Me.ghOrderID.Height = 1.325!
        Me.ghOrderID.KeepTogether = True
        Me.ghOrderID.Name = "ghOrderID"
        'GFOrderID
        Me.GFOrderID.CanGrow = False
        Me.GFOrderID.ColumnLayout = False
        Me.GFOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblSubTotal, Me.lblFreight, Me.lblGrandTotal, Me.txtSubTotal, Me.txtFreight, Me.txtTotal})
        Me.GFOrderID.Height = 0.6!
        Me.GFOrderID.KeepTogether = True
        Me.GFOrderID.Name = "GFOrderID"
        Me.GFOrderID.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
        'ghOrderHeader
        Me.ghOrderHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.imgLogo, Me.lblNorthWind, Me.lblTraders, Me.lblNWAddr1, Me.lblNWAddr2, Me.lblInvoice, Me.lblOrderNum, Me.txtOrderID, Me.lblOrderDate, Me.txtOrderDate})
        Me.ghOrderHeader.DataField = "OrderID"
        Me.ghOrderHeader.Height = 1.15!
        Me.ghOrderHeader.Name = "ghOrderHeader"
        'GroupFooter1
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = False
        'ghTableHeader
        Me.ghTableHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblProductID, Me.lblProductName, Me.lblQty, Me.lblUnitPrice, Me.lblDiscount, Me.lblTotal, Me.Label1, Me.Label2, Me.Label3})
        Me.ghTableHeader.DataField = "OrderID"
        Me.ghTableHeader.Height = 0.2!
        Me.ghTableHeader.Name = "ghTableHeader"
        'GroupFooter2
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.Visible = False
        'Invoice
        Me.MasterReport = False
        Me.MaxPages = CType(100, Long)
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.5!
        Me.Script = resources.GetString("$this.Script")
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.ghOrderHeader)
        Me.Sections.Add(Me.ghOrderID)
        Me.Sections.Add(Me.ghTableHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GFOrderID)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
    End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GFOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblNWAddr1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblNWAddr2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblInvoice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderNum As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private imgLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Private lblBillTo As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipTo As GrapeCity.ActiveReports.SectionReportModel.Label
Private lneBillTo As GrapeCity.ActiveReports.SectionReportModel.Line
Private lneShipTo As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtBillToCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtBillToAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtBillToCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtBillToRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtBillToPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtBillToCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipToCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtSalesPerson As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblSalesPerson As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQty As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblDiscount As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipped As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtShipDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblShippedVia As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtShipper As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductname As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtExtended As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblSubTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblFreight As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblGrandTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Public txtSubTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
Public txtFreight As GrapeCity.ActiveReports.SectionReportModel.TextBox
Public txtTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ghOrderHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents ghTableHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblThankYou As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
