<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produits
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
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        DataGridView_produits = New DataGridView()
        rpr = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnSupprimerProduit = New Button()
        btnModifierProduit = New Button()
        btnAjouterProduit = New Button()
        TextBox_qtepr = New TextBox()
        cl6 = New Label()
        TextBox_prixp = New TextBox()
        cl5 = New Label()
        TextBox_nompr = New TextBox()
        cl3 = New Label()
        cl2 = New Label()
        Panel2 = New Panel()
        bcl3 = New Button()
        bcl2 = New Button()
        bcl1 = New Button()
        Labelcl = New Label()
        cl4 = New Label()
        Panel1 = New Panel()
        ComboBox_categorie = New ComboBox()
        afp = New Label()
        CType(DataGridView_produits, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' DataGridView_produits
        ' 
        DataGridView_produits.BackgroundColor = SystemColors.Control
        DataGridView_produits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_produits.Location = New Point(371, 619)
        DataGridView_produits.Name = "DataGridView_produits"
        DataGridView_produits.RowHeadersWidth = 62
        DataGridView_produits.Size = New Size(936, 393)
        DataGridView_produits.TabIndex = 35
        ' 
        ' rpr
        ' 
        rpr.Location = New Point(1011, 545)
        rpr.Multiline = True
        rpr.Name = "rpr"
        rpr.Size = New Size(296, 46)
        rpr.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(818, 545)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 47)
        Label2.TabIndex = 33
        Label2.Text = "Recherche:" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(738, 478)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 47)
        Label1.TabIndex = 32
        Label1.Text = "LISTE   COMPLETE   DES    PRODUITS" & vbCrLf & vbCrLf
        ' 
        ' btnSupprimerProduit
        ' 
        btnSupprimerProduit.BackColor = Color.Salmon
        btnSupprimerProduit.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSupprimerProduit.Location = New Point(1387, 372)
        btnSupprimerProduit.Name = "btnSupprimerProduit"
        btnSupprimerProduit.Size = New Size(326, 76)
        btnSupprimerProduit.TabIndex = 31
        btnSupprimerProduit.Text = "SUPPRIMER"
        btnSupprimerProduit.UseVisualStyleBackColor = False
        ' 
        ' btnModifierProduit
        ' 
        btnModifierProduit.BackColor = Color.LemonChiffon
        btnModifierProduit.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModifierProduit.Location = New Point(934, 372)
        btnModifierProduit.Name = "btnModifierProduit"
        btnModifierProduit.Size = New Size(295, 76)
        btnModifierProduit.TabIndex = 30
        btnModifierProduit.Text = "MODIFIER"
        btnModifierProduit.UseVisualStyleBackColor = False
        ' 
        ' btnAjouterProduit
        ' 
        btnAjouterProduit.BackColor = Color.SpringGreen
        btnAjouterProduit.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjouterProduit.Location = New Point(498, 372)
        btnAjouterProduit.Name = "btnAjouterProduit"
        btnAjouterProduit.Size = New Size(270, 76)
        btnAjouterProduit.TabIndex = 29
        btnAjouterProduit.Text = "AJOUTER"
        btnAjouterProduit.UseVisualStyleBackColor = False
        ' 
        ' TextBox_qtepr
        ' 
        TextBox_qtepr.Location = New Point(1497, 185)
        TextBox_qtepr.Multiline = True
        TextBox_qtepr.Name = "TextBox_qtepr"
        TextBox_qtepr.Size = New Size(230, 46)
        TextBox_qtepr.TabIndex = 27
        ' 
        ' cl6
        ' 
        cl6.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl6.Location = New Point(1497, 103)
        cl6.Name = "cl6"
        cl6.Size = New Size(242, 55)
        cl6.TabIndex = 26
        cl6.Text = "Quantité:" & vbCrLf
        ' 
        ' TextBox_prixp
        ' 
        TextBox_prixp.Location = New Point(1112, 185)
        TextBox_prixp.Multiline = True
        TextBox_prixp.Name = "TextBox_prixp"
        TextBox_prixp.Size = New Size(251, 46)
        TextBox_prixp.TabIndex = 25
        ' 
        ' cl5
        ' 
        cl5.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl5.Location = New Point(1112, 103)
        cl5.Name = "cl5"
        cl5.Size = New Size(264, 55)
        cl5.TabIndex = 24
        cl5.Text = "PRIX:" & vbCrLf
        ' 
        ' TextBox_nompr
        ' 
        TextBox_nompr.Location = New Point(371, 185)
        TextBox_nompr.Multiline = True
        TextBox_nompr.Name = "TextBox_nompr"
        TextBox_nompr.Size = New Size(240, 46)
        TextBox_nompr.TabIndex = 21
        ' 
        ' cl3
        ' 
        cl3.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl3.Location = New Point(421, 103)
        cl3.Name = "cl3"
        cl3.Size = New Size(143, 55)
        cl3.TabIndex = 20
        cl3.Text = "Nom:" & vbCrLf
        ' 
        ' cl2
        ' 
        cl2.Font = New Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl2.Location = New Point(438, 17)
        cl2.Name = "cl2"
        cl2.Size = New Size(653, 47)
        cl2.TabIndex = 1
        cl2.Text = "OPERATIONS   LIES   AUX   PRODUITS" & vbCrLf & vbCrLf
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gainsboro
        Panel2.Controls.Add(cl2)
        Panel2.Location = New Point(322, -4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1601, 80)
        Panel2.TabIndex = 19
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
        bcl1.Text = "CLIENTS"
        bcl1.UseVisualStyleBackColor = True
        ' 
        ' Labelcl
        ' 
        Labelcl.Font = New Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelcl.ForeColor = SystemColors.ControlLightLight
        Labelcl.Location = New Point(-8, 21)
        Labelcl.Name = "Labelcl"
        Labelcl.Size = New Size(344, 78)
        Labelcl.TabIndex = 0
        Labelcl.Text = "PRODUITS"
        ' 
        ' cl4
        ' 
        cl4.Font = New Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cl4.Location = New Point(738, 103)
        cl4.Name = "cl4"
        cl4.Size = New Size(254, 55)
        cl4.TabIndex = 22
        cl4.Text = "Catégorie:"
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
        Panel1.Size = New Size(322, 1091)
        Panel1.TabIndex = 18
        ' 
        ' ComboBox_categorie
        ' 
        ComboBox_categorie.FormattingEnabled = True
        ComboBox_categorie.Items.AddRange(New Object() {"OUTILS", "MATERIAUX DE CONSTRUCTION", "PLOMBERIE", "ELECTRICITE", "PEINTURE", "JARDINAGE"})
        ComboBox_categorie.Location = New Point(738, 198)
        ComboBox_categorie.Name = "ComboBox_categorie"
        ComboBox_categorie.Size = New Size(254, 33)
        ComboBox_categorie.TabIndex = 36
        ' 
        ' afp
        ' 
        afp.Font = New Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        afp.Location = New Point(1313, 725)
        afp.Name = "afp"
        afp.Size = New Size(599, 141)
        afp.TabIndex = 37
        afp.Text = "Label3"
        ' 
        ' Produits
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(afp)
        Controls.Add(ComboBox_categorie)
        Controls.Add(DataGridView_produits)
        Controls.Add(rpr)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSupprimerProduit)
        Controls.Add(btnModifierProduit)
        Controls.Add(btnAjouterProduit)
        Controls.Add(TextBox_qtepr)
        Controls.Add(cl6)
        Controls.Add(TextBox_prixp)
        Controls.Add(cl5)
        Controls.Add(TextBox_nompr)
        Controls.Add(cl3)
        Controls.Add(Panel2)
        Controls.Add(cl4)
        Controls.Add(Panel1)
        Name = "Produits"
        Text = "Produits"
        CType(DataGridView_produits, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents DataGridView_produits As DataGridView
    Friend WithEvents rpr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSupprimerProduit As Button
    Friend WithEvents btnModifierProduit As Button
    Friend WithEvents btnAjouterProduit As Button
    Friend WithEvents TextBox_qtepr As TextBox
    Friend WithEvents cl6 As Label
    Friend WithEvents TextBox_prixp As TextBox
    Friend WithEvents cl5 As Label
    Friend WithEvents TextBox_nompr As TextBox
    Friend WithEvents cl3 As Label
    Friend WithEvents cl2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bcl3 As Button
    Friend WithEvents bcl2 As Button
    Friend WithEvents bcl1 As Button
    Friend WithEvents Labelcl As Label
    Friend WithEvents cl4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox_categorie As ComboBox
    Friend WithEvents afp As Label
End Class
