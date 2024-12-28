Imports System.Drawing.Printing

Public Class Form1
    Dim longpaper As Integer

    ' Change the paper size dynamically based on row count
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    ' Button click to show the print preview
    Private Sub BTPRINT_Click(sender As Object, e As EventArgs) Handles BTPRINT.Click
        PD.DefaultPageSettings.PaperSize = New PaperSize("MySize", 250, 600)
        PPD.WindowState = FormWindowState.Maximized
        PPD.PrintPreviewControl.Zoom = 2.5
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    ' PrintPage event to render content on the print document
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        ' Alignment settings
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String = "****************************************************************"

        ' Header information
        e.Graphics.DrawString("Etablissement Touré & Fils", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("ADIDOGOME BOULEVARD DU 30 Août", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Telephone: +228 91-92-00-01", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("FACTURE N°", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("DRW8555RE", f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Caisier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("AMA DAVID", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("20/01/2025", f8, Brushes.Black, 0, 95)

        ' Detail Header
        e.Graphics.DrawString("Nbre", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("produit", f8, Brushes.Black, 25, 110)
        e.Graphics.DrawString("Prix unitaire", f8, Brushes.Black, 180, 110, right)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, 110, right)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        ' Printing DataGridView rows
        Dim height As Integer
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 25, 115 + height)

            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 180, 115 + height, right)

            ' Total price calculation
            Dim totalprice As Long
            totalprice = Val(DataGridView1.Rows(row).Cells(1).Value * DataGridView1.Rows(row).Cells(2).Value)
            e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, 115 + height, right)
        Next

        ' Footer calculations
        Dim height2 As Integer = 145 + height
        sumprice()
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 10 + height2)

        ' Footer message
        e.Graphics.DrawString("~ Votre confort fait notre satisfaction ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ Quainquellerie Touré & Fils ~", f10, Brushes.Black, centermargin, 85 + height2, center)
    End Sub

    Dim t_price As Long
    Dim t_qty As Long

    ' Calculate total price and quantity
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice += Val(DataGridView1.Rows(rowitem).Cells(2).Value * DataGridView1.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty += DataGridView1.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub

    ' Refresh button to allow adding rows
    Private Sub BTREFRESH_Click(sender As Object, e As EventArgs) Handles BTREFRESH.Click
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Ajuste les lignes pour remplir verticalement
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Supprime les marges et ajustements inutiles
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AllowUserToResizeColumns = False

    End Sub


End Class
