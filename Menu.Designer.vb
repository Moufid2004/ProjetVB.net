<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        bcl3 = New Button()
        bcl2 = New Button()
        bcl1 = New Button()
        Labelcl = New Label()
        Panel2 = New Panel()
        cl2 = New Label()
        cl3 = New Label()
        tcl1 = New TextBox()
        tcl2 = New TextBox()
        cl4 = New Label()
        tcl3 = New TextBox()
        cl5 = New Label()
        cl6 = New Label()
        Button_select = New Button()
        ba = New Button()
        bm = New Button()
        bs = New Button()
        Label1 = New Label()
        Label2 = New Label()
        br = New TextBox()
        DataGridView_membre = New DataGridView()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label_total1 = New Label()
        MYDBBindingSource = New BindingSource(components)
        tcl4 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView_membre, ComponentModel.ISupportInitialize).BeginInit()
        CType(MYDBBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(tcl4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(bcl3)
        Panel1.Controls.Add(bcl2)
        Panel1.Controls.Add(bcl1)
        Panel1.Controls.Add(Labelcl)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(322, 1105)
        Panel1.TabIndex = 0
        ' 
        ' bcl3
        ' 
        bcl3.BackColor = SystemColors.Info
        bcl3.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl3.Location = New Point(54, 964)
        bcl3.Name = "bcl3"
        bcl3.Size = New Size(210, 73)
        bcl3.TabIndex = 3
        bcl3.Text = "QUITTER"
        bcl3.UseVisualStyleBackColor = False
        ' 
        ' bcl2
        ' 
        bcl2.Font = New Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl2.Location = New Point(12, 623)
        bcl2.Name = "bcl2"
        bcl2.Size = New Size(295, 67)
        bcl2.TabIndex = 2
        bcl2.Text = "VENTES" & vbCrLf
        bcl2.UseVisualStyleBackColor = True
        ' 
        ' bcl1
        ' 
        bcl1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl1.Location = New Point(12, 449)
        bcl1.Name = "bcl1"
        bcl1.Size = New Size(295, 71)
        bcl1.TabIndex = 1
        bcl1.Text = "PRODUITS"
        bcl1.UseVisualStyleBackColor = True
        ' 
        ' Labelcl
        ' 
        Labelcl.Font = New Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelcl.ForeColor = SystemColors.ControlLightLight
        Labelcl.Location = New Point(39, 21)
        Labelcl.Name = "Labelcl"
        Labelcl.Size = New Size(238, 78)
        Labelcl.TabIndex = 0
        Labelcl.Text = "Clients"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(cl2)
        Panel2.Location = New Point(321, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1601, 80)
        Panel2.TabIndex = 1
        ' 
        ' cl2
        ' 
        cl2.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl2.Location = New Point(438, 17)
        cl2.Name = "cl2"
        cl2.Size = New Size(625, 47)
        cl2.TabIndex = 1
        cl2.Text = "OPERATIONS   LIES   AUX   CLIENTS" & vbCrLf & vbCrLf
        ' 
        ' cl3
        ' 
        cl3.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl3.Location = New Point(420, 108)
        cl3.Name = "cl3"
        cl3.Size = New Size(143, 55)
        cl3.TabIndex = 2
        cl3.Text = "Nom:" & vbCrLf
        ' 
        ' tcl1
        ' 
        tcl1.Location = New Point(370, 190)
        tcl1.Multiline = True
        tcl1.Name = "tcl1"
        tcl1.Size = New Size(240, 46)
        tcl1.TabIndex = 3
        ' 
        ' tcl2
        ' 
        tcl2.Location = New Point(737, 190)
        tcl2.Multiline = True
        tcl2.Name = "tcl2"
        tcl2.Size = New Size(240, 46)
        tcl2.TabIndex = 5
        ' 
        ' cl4
        ' 
        cl4.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl4.Location = New Point(756, 108)
        cl4.Name = "cl4"
        cl4.Size = New Size(203, 55)
        cl4.TabIndex = 4
        cl4.Text = "Prénom:" & vbCrLf
        ' 
        ' tcl3
        ' 
        tcl3.Location = New Point(1111, 190)
        tcl3.Multiline = True
        tcl3.Name = "tcl3"
        tcl3.Size = New Size(251, 46)
        tcl3.TabIndex = 7
        ' 
        ' cl5
        ' 
        cl5.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl5.Location = New Point(1111, 108)
        cl5.Name = "cl5"
        cl5.Size = New Size(264, 55)
        cl5.TabIndex = 6
        cl5.Text = "Telephone:" & vbCrLf
        ' 
        ' cl6
        ' 
        cl6.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl6.Location = New Point(1496, 108)
        cl6.Name = "cl6"
        cl6.Size = New Size(181, 55)
        cl6.TabIndex = 8
        cl6.Text = "Photo:" & vbCrLf
        ' 
        ' Button_select
        ' 
        Button_select.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_select.Location = New Point(1465, 464)
        Button_select.Name = "Button_select"
        Button_select.Size = New Size(238, 66)
        Button_select.TabIndex = 10
        Button_select.Text = "Choisir"
        Button_select.UseVisualStyleBackColor = True
        ' 
        ' ba
        ' 
        ba.BackColor = Color.SpringGreen
        ba.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ba.Location = New Point(407, 377)
        ba.Name = "ba"
        ba.Size = New Size(270, 76)
        ba.TabIndex = 11
        ba.Text = "AJOUTER"
        ba.UseVisualStyleBackColor = False
        ' 
        ' bm
        ' 
        bm.BackColor = Color.LemonChiffon
        bm.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bm.Location = New Point(737, 377)
        bm.Name = "bm"
        bm.Size = New Size(295, 76)
        bm.TabIndex = 12
        bm.Text = "MODIFIER"
        bm.UseVisualStyleBackColor = False
        ' 
        ' bs
        ' 
        bs.BackColor = Color.Salmon
        bs.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bs.Location = New Point(1086, 377)
        bs.Name = "bs"
        bs.Size = New Size(326, 76)
        bs.TabIndex = 13
        bs.Text = "SUPPRIMER"
        bs.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(737, 483)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 47)
        Label1.TabIndex = 14
        Label1.Text = "LISTE   COMPLETE   DES    CLIENTS" & vbCrLf & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(817, 550)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 47)
        Label2.TabIndex = 15
        Label2.Text = "Recherche:" & vbCrLf
        ' 
        ' br
        ' 
        br.Location = New Point(1010, 550)
        br.Multiline = True
        br.Name = "br"
        br.Size = New Size(296, 46)
        br.TabIndex = 16
        ' 
        ' DataGridView_membre
        ' 
        DataGridView_membre.BackgroundColor = SystemColors.Control
        DataGridView_membre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_membre.Location = New Point(518, 602)
        DataGridView_membre.Name = "DataGridView_membre"
        DataGridView_membre.RowHeadersWidth = 62
        DataGridView_membre.Size = New Size(788, 436)
        DataGridView_membre.TabIndex = 17
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label_total1
        ' 
        Label_total1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label_total1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_total1.Location = New Point(1356, 737)
        Label_total1.Name = "Label_total1"
        Label_total1.Size = New Size(534, 149)
        Label_total1.TabIndex = 18
        Label_total1.Text = "Label3"
        ' 
        ' MYDBBindingSource
        ' 
        MYDBBindingSource.DataSource = GetType(MY_DB)
        ' 
        ' tcl4
        ' 
        tcl4.BackColor = Color.Gainsboro
        tcl4.Location = New Point(1448, 190)
        tcl4.Name = "tcl4"
        tcl4.Size = New Size(267, 263)
        tcl4.TabIndex = 19
        tcl4.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(tcl4)
        Controls.Add(Label_total1)
        Controls.Add(DataGridView_membre)
        Controls.Add(br)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(bs)
        Controls.Add(bm)
        Controls.Add(ba)
        Controls.Add(Button_select)
        Controls.Add(cl6)
        Controls.Add(tcl3)
        Controls.Add(cl5)
        Controls.Add(tcl2)
        Controls.Add(cl4)
        Controls.Add(tcl1)
        Controls.Add(cl3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Menu"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(DataGridView_membre, ComponentModel.ISupportInitialize).EndInit()
        CType(MYDBBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(tcl4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Labelcl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cl2 As Label
    Friend WithEvents bcl3 As Button
    Friend WithEvents bcl2 As Button
    Friend WithEvents bcl1 As Button
    Friend WithEvents cl3 As Label
    Friend WithEvents tcl1 As TextBox
    Friend WithEvents tcl2 As TextBox
    Friend WithEvents cl4 As Label
    Friend WithEvents tcl3 As TextBox
    Friend WithEvents cl5 As Label
    Friend WithEvents cl6 As Label
    Friend WithEvents Button_select As Button
    Friend WithEvents ba As Button
    Friend WithEvents bm As Button
    Friend WithEvents bs As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents br As TextBox
    Friend WithEvents DataGridView_membre As DataGridView
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label_total1 As Label
    Friend WithEvents MYDBBindingSource As BindingSource
    Friend WithEvents tcl4 As PictureBox
End Class
