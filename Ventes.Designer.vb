<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventes
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
        ComboBox_client = New ComboBox()
        DataGridView_ventes = New DataGridView()
        rv = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnSupprimerVente = New Button()
        btnModifierVente = New Button()
        btnAjouterVente = New Button()
        cl6 = New Label()
        TextBox_quantite = New TextBox()
        bcl3 = New Button()
        bcl2 = New Button()
        bcl1 = New Button()
        Labelcl = New Label()
        cl5 = New Label()
        cl2 = New Label()
        cl3 = New Label()
        Panel2 = New Panel()
        cl4 = New Label()
        Panel1 = New Panel()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        ComboBox_idproduit = New ComboBox()
        Label3 = New Label()
        Reçu = New Button()
        DateTimePicker_dvente = New DateTimePicker()
        Label_prix = New Label()
        afv = New Label()
        CType(DataGridView_ventes, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox_client
        ' 
        ComboBox_client.FormattingEnabled = True
        ComboBox_client.Location = New Point(629, 198)
        ComboBox_client.Name = "ComboBox_client"
        ComboBox_client.Size = New Size(194, 33)
        ComboBox_client.TabIndex = 53
        ' 
        ' DataGridView_ventes
        ' 
        DataGridView_ventes.BackgroundColor = SystemColors.Control
        DataGridView_ventes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_ventes.Location = New Point(384, 645)
        DataGridView_ventes.Name = "DataGridView_ventes"
        DataGridView_ventes.RowHeadersWidth = 62
        DataGridView_ventes.Size = New Size(923, 393)
        DataGridView_ventes.TabIndex = 52
        ' 
        ' rv
        ' 
        rv.Location = New Point(1011, 545)
        rv.Multiline = True
        rv.Name = "rv"
        rv.Size = New Size(296, 46)
        rv.TabIndex = 51
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial Narrow", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(818, 545)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 47)
        Label2.TabIndex = 50
        Label2.Text = "Recherche:" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial Narrow", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(738, 478)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 47)
        Label1.TabIndex = 49
        Label1.Text = "LISTE   COMPLETE   DES    VENTES" & vbCrLf & vbCrLf
        ' 
        ' btnSupprimerVente
        ' 
        btnSupprimerVente.BackColor = Color.Salmon
        btnSupprimerVente.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSupprimerVente.Location = New Point(1387, 372)
        btnSupprimerVente.Name = "btnSupprimerVente"
        btnSupprimerVente.Size = New Size(326, 76)
        btnSupprimerVente.TabIndex = 48
        btnSupprimerVente.Text = "SUPPRIMER"
        btnSupprimerVente.UseVisualStyleBackColor = False
        ' 
        ' btnModifierVente
        ' 
        btnModifierVente.BackColor = Color.LemonChiffon
        btnModifierVente.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModifierVente.Location = New Point(934, 372)
        btnModifierVente.Name = "btnModifierVente"
        btnModifierVente.Size = New Size(295, 76)
        btnModifierVente.TabIndex = 47
        btnModifierVente.Text = "MODIFIER"
        btnModifierVente.UseVisualStyleBackColor = False
        ' 
        ' btnAjouterVente
        ' 
        btnAjouterVente.BackColor = Color.SpringGreen
        btnAjouterVente.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjouterVente.Location = New Point(498, 372)
        btnAjouterVente.Name = "btnAjouterVente"
        btnAjouterVente.Size = New Size(270, 76)
        btnAjouterVente.TabIndex = 46
        btnAjouterVente.Text = "AJOUTER"
        btnAjouterVente.UseVisualStyleBackColor = False
        ' 
        ' cl6
        ' 
        cl6.Font = New Font("Arial Rounded MT Bold", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl6.Location = New Point(629, 103)
        cl6.Name = "cl6"
        cl6.Size = New Size(203, 55)
        cl6.TabIndex = 44
        cl6.Text = "Client:" & vbCrLf
        ' 
        ' TextBox_quantite
        ' 
        TextBox_quantite.Location = New Point(1178, 185)
        TextBox_quantite.Multiline = True
        TextBox_quantite.Name = "TextBox_quantite"
        TextBox_quantite.Size = New Size(216, 46)
        TextBox_quantite.TabIndex = 43
        ' 
        ' bcl3
        ' 
        bcl3.BackColor = SystemColors.Info
        bcl3.Font = New Font("Arial Black", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl3.Location = New Point(54, 964)
        bcl3.Name = "bcl3"
        bcl3.Size = New Size(210, 73)
        bcl3.TabIndex = 3
        bcl3.Text = "QUITTER"
        bcl3.UseVisualStyleBackColor = False
        ' 
        ' bcl2
        ' 
        bcl2.Font = New Font("Arial", 22.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl2.Location = New Point(12, 623)
        bcl2.Name = "bcl2"
        bcl2.Size = New Size(295, 67)
        bcl2.TabIndex = 2
        bcl2.Text = "PRODUITS" & vbCrLf
        bcl2.UseVisualStyleBackColor = True
        ' 
        ' bcl1
        ' 
        bcl1.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bcl1.Location = New Point(12, 449)
        bcl1.Name = "bcl1"
        bcl1.Size = New Size(295, 71)
        bcl1.TabIndex = 1
        bcl1.Text = "CLIENTS"
        bcl1.UseVisualStyleBackColor = True
        ' 
        ' Labelcl
        ' 
        Labelcl.Font = New Font("Arial Narrow", 36.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelcl.ForeColor = SystemColors.ControlLightLight
        Labelcl.Location = New Point(29, 21)
        Labelcl.Name = "Labelcl"
        Labelcl.Size = New Size(276, 78)
        Labelcl.TabIndex = 0
        Labelcl.Text = "VENTES"
        ' 
        ' cl5
        ' 
        cl5.Font = New Font("Arial Rounded MT Bold", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl5.Location = New Point(1483, 103)
        cl5.Name = "cl5"
        cl5.Size = New Size(264, 55)
        cl5.TabIndex = 42
        cl5.Text = "TOTAL"
        ' 
        ' cl2
        ' 
        cl2.Font = New Font("Arial Narrow", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl2.Location = New Point(438, 17)
        cl2.Name = "cl2"
        cl2.Size = New Size(653, 47)
        cl2.TabIndex = 1
        cl2.Text = "OPERATIONS   LIES   AUX   VENTES" & vbCrLf & vbCrLf
        ' 
        ' cl3
        ' 
        cl3.Font = New Font("Arial Rounded MT Bold", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl3.Location = New Point(329, 103)
        cl3.Name = "cl3"
        cl3.Size = New Size(201, 55)
        cl3.TabIndex = 39
        cl3.Text = "Date:" & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(cl2)
        Panel2.Location = New Point(322, -4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1601, 80)
        Panel2.TabIndex = 38
        ' 
        ' cl4
        ' 
        cl4.Font = New Font("Arial Rounded MT Bold", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl4.Location = New Point(1175, 103)
        cl4.Name = "cl4"
        cl4.Size = New Size(254, 55)
        cl4.TabIndex = 41
        cl4.Text = "Quantité:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(bcl3)
        Panel1.Controls.Add(bcl2)
        Panel1.Controls.Add(bcl1)
        Panel1.Controls.Add(Labelcl)
        Panel1.Location = New Point(1, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(322, 1087)
        Panel1.TabIndex = 37
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' ComboBox_idproduit
        ' 
        ComboBox_idproduit.FormattingEnabled = True
        ComboBox_idproduit.Location = New Point(887, 198)
        ComboBox_idproduit.Name = "ComboBox_idproduit"
        ComboBox_idproduit.Size = New Size(221, 33)
        ComboBox_idproduit.TabIndex = 57
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial Rounded MT Bold", 22.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(887, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 55)
        Label3.TabIndex = 56
        Label3.Text = "Produit:" & vbCrLf
        ' 
        ' Reçu
        ' 
        Reçu.BackColor = Color.Aqua
        Reçu.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Reçu.Location = New Point(1338, 940)
        Reçu.Name = "Reçu"
        Reçu.Size = New Size(375, 93)
        Reçu.TabIndex = 58
        Reçu.Text = "Reçu"
        Reçu.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker_dvente
        ' 
        DateTimePicker_dvente.Location = New Point(329, 200)
        DateTimePicker_dvente.Name = "DateTimePicker_dvente"
        DateTimePicker_dvente.Size = New Size(234, 31)
        DateTimePicker_dvente.TabIndex = 59
        ' 
        ' Label_prix
        ' 
        Label_prix.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_prix.Location = New Point(1483, 185)
        Label_prix.Name = "Label_prix"
        Label_prix.Size = New Size(230, 46)
        Label_prix.TabIndex = 60
        ' 
        ' afv
        ' 
        afv.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        afv.Location = New Point(1324, 682)
        afv.Name = "afv"
        afv.Size = New Size(444, 127)
        afv.TabIndex = 61
        afv.Text = "Label5"
        ' 
        ' Ventes
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(afv)
        Controls.Add(Label_prix)
        Controls.Add(DateTimePicker_dvente)
        Controls.Add(Reçu)
        Controls.Add(ComboBox_idproduit)
        Controls.Add(Label3)
        Controls.Add(ComboBox_client)
        Controls.Add(DataGridView_ventes)
        Controls.Add(rv)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSupprimerVente)
        Controls.Add(btnModifierVente)
        Controls.Add(btnAjouterVente)
        Controls.Add(cl6)
        Controls.Add(TextBox_quantite)
        Controls.Add(cl5)
        Controls.Add(cl3)
        Controls.Add(Panel2)
        Controls.Add(cl4)
        Controls.Add(Panel1)
        Name = "Ventes"
        Text = "Ventes"
        CType(DataGridView_ventes, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox_client As ComboBox
    Friend WithEvents DataGridView_ventes As DataGridView
    Friend WithEvents rv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSupprimerVente As Button
    Friend WithEvents btnModifierVente As Button
    Friend WithEvents btnAjouterVente As Button
    Friend WithEvents cl6 As Label
    Friend WithEvents TextBox_quantite As TextBox
    Friend WithEvents bcl3 As Button
    Friend WithEvents bcl2 As Button
    Friend WithEvents bcl1 As Button
    Friend WithEvents Labelcl As Label
    Friend WithEvents cl5 As Label
    Friend WithEvents cl2 As Label
    Friend WithEvents cl3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cl4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents ComboBox_idproduit As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Reçu As Button
    Friend WithEvents DateTimePicker_dvente As DateTimePicker
    Friend WithEvents Label_prix As Label
    Friend WithEvents afv As Label
End Class
