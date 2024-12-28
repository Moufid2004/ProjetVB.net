<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PD = New Printing.PrintDocument()
        PPD = New PrintPreviewDialog()
        DataGridView1 = New DataGridView()
        BTPRINT = New Button()
        BTREFRESH = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PD
        ' 
        ' 
        ' PPD
        ' 
        PPD.AutoScrollMargin = New Size(0, 0)
        PPD.AutoScrollMinSize = New Size(0, 0)
        PPD.ClientSize = New Size(400, 300)
        PPD.Enabled = True
        PPD.Icon = CType(resources.GetObject("PPD.Icon"), Icon)
        PPD.Name = "PPD"
        PPD.Visible = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1164, 511)
        DataGridView1.TabIndex = 0
        ' 
        ' BTPRINT
        ' 
        BTPRINT.Location = New Point(858, 595)
        BTPRINT.Name = "BTPRINT"
        BTPRINT.Size = New Size(248, 64)
        BTPRINT.TabIndex = 1
        BTPRINT.Text = "IMPRIMER"
        BTPRINT.UseVisualStyleBackColor = True
        ' 
        ' BTREFRESH
        ' 
        BTREFRESH.Location = New Point(12, 595)
        BTREFRESH.Name = "BTREFRESH"
        BTREFRESH.Size = New Size(208, 64)
        BTREFRESH.TabIndex = 2
        BTREFRESH.Text = "ANNULER"
        BTREFRESH.UseVisualStyleBackColor = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Produit"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Quantité"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PRIX UNITAIRE"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(20.0F, 48.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1164, 725)
        Controls.Add(BTREFRESH)
        Controls.Add(BTPRINT)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PD As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTPRINT As Button
    Friend WithEvents BTREFRESH As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
