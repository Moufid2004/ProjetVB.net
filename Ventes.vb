Imports System.Drawing.Printing
Public Class Ventes

    Private Sub Ventes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        LoadClients()
        LoadProducts()
        LoadVentesData()
    End Sub
    Private Sub LoadClients()
        ' Charger les noms des clients dans le ComboBox_client
        Dim clients As New Clients()
        Dim dtClients As DataTable = clients.getAllClients()
        ComboBox_client.DataSource = dtClients
        ComboBox_client.DisplayMember = "nomcl" ' Afficher les noms
        ComboBox_client.ValueMember = "nomcl"   ' Utiliser l'identifiant en interne
    End Sub

    Private Sub LoadProducts()
        ' Charger les noms des produits dans le ComboBox_idproduit
        Dim produits As New Prod()
        Dim dtProduits As DataTable = produits.getAllProducts()
        ComboBox_idproduit.DataSource = dtProduits
        ComboBox_idproduit.DisplayMember = "nompr" ' Afficher les noms
        ComboBox_idproduit.ValueMember = "nompr"   ' Utiliser l'identifiant en interne
    End Sub


    Private Sub LoadVentesData()
        Dim ventes As New Vent()
        DataGridView_ventes.DataSource = ventes.getAllVentes()

        ' Configurer les colonnes
        If DataGridView_ventes.Columns.Count > 0 Then
            DataGridView_ventes.Columns("idv").HeaderText = "ID Vente"
            DataGridView_ventes.Columns("dvente").HeaderText = "Date"
            DataGridView_ventes.Columns("client_nom").HeaderText = "Client"
            DataGridView_ventes.Columns("produit_nom").HeaderText = "Produit"
            DataGridView_ventes.Columns("qtite").HeaderText = "Quantité"
            DataGridView_ventes.Columns("prix").HeaderText = "Prix"
        End If

        UpdateVentesCount()
    End Sub

    Private Sub UpdateVentesCount()
        afv.Text = (DataGridView_ventes.Rows.Count - 1).ToString() & " ventes"
    End Sub
    Private Sub btnAjouterVente_Click(sender As Object, e As EventArgs) Handles btnAjouterVente.Click
        Try
            Dim dvente As DateTime = DateTimePicker_dvente.Value
            Dim clnom As String = ComboBox_client.SelectedValue.ToString()
            Dim prnom As String = ComboBox_idproduit.SelectedValue.ToString()
            Dim qtite As Integer = Integer.Parse(TextBox_quantite.Text)
            Dim prixUnitaire As Decimal = GetPrixUnitaire(prnom)
            Dim prixTotal As Decimal = qtite * prixUnitaire
            Label_prix.Text = prixTotal.ToString()

            If String.IsNullOrEmpty(clnom) OrElse String.IsNullOrEmpty(prnom) OrElse qtite <= 0 OrElse prixTotal <= 0 Then
                MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ventes As New Vent()
                If ventes.addVente(dvente, clnom, prnom, qtite, prixTotal) Then
                    MessageBox.Show("Vente ajoutée avec succès", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadVentesData()
                    ClearForm()
                Else
                    MessageBox.Show("L'ajout de la vente a échoué.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModifierVente_Click(sender As Object, e As EventArgs) Handles btnModifierVente.Click
        Try
            Dim idv As Integer = Integer.Parse(DataGridView_ventes.CurrentRow.Cells("idv").Value.ToString())
            Dim dvente As DateTime = DateTimePicker_dvente.Value
            Dim clnom As String = ComboBox_client.SelectedValue.ToString()
            Dim prnom As String = ComboBox_idproduit.SelectedValue.ToString()
            Dim qtite As Integer = Integer.Parse(TextBox_quantite.Text)
            Dim prixUnitaire As Decimal = GetPrixUnitaire(prnom)
            Dim prixTotal As Decimal = qtite * prixUnitaire
            Label_prix.Text = prixTotal.ToString()

            If String.IsNullOrEmpty(clnom) OrElse String.IsNullOrEmpty(prnom) OrElse qtite <= 0 OrElse prixTotal <= 0 Then
                MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ventes As New Vent()
                If ventes.updateVente(idv, dvente, clnom, prnom, qtite, prixTotal) Then
                    MessageBox.Show("Vente modifiée avec succès", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadVentesData()
                    ClearForm()
                Else
                    MessageBox.Show("La modification de la vente a échoué.", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnSupprimerVente_Click(sender As Object, e As EventArgs) Handles btnSupprimerVente.Click
        Try
            Dim idv As Integer = Integer.Parse(DataGridView_ventes.CurrentRow.Cells("idv").Value.ToString())

            If MessageBox.Show("Voulez-vous vraiment supprimer cette vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim ventes As New Vent()
                If ventes.deleteVente(idv) Then
                    MessageBox.Show("Vente supprimée avec succès", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadVentesData()
                    ClearForm()
                Else
                    MessageBox.Show("La suppression de la vente a échoué.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rv_TextChanged(sender As Object, e As EventArgs) Handles rv.TextChanged
        Dim searchTerm As String = rv.Text.Trim()
        Dim ventes As New Vent()
        DataGridView_ventes.DataSource = ventes.searchVente(searchTerm)
        UpdateVentesCount()
    End Sub

    Private Sub ClearForm()
        ComboBox_client.SelectedIndex = -1
        ComboBox_idproduit.SelectedIndex = -1
        TextBox_quantite.Text = ""
        Label_prix.Text = "0"
    End Sub

    Private Function GetPrixUnitaire(prnom As String) As Decimal
        ' Récupérer le prix unitaire du produit à partir de son nom
        Dim produits As New Prod()
        Dim dtProduits As DataTable = produits.getAllProducts()
        Dim prixUnitaire As Decimal = 0

        For Each row As DataRow In dtProduits.Rows
            If row("nompr") = prnom Then
                prixUnitaire = Decimal.Parse(row("prixp").ToString())
                Exit For
            End If
        Next

        Return prixUnitaire
    End Function



    Private Sub TextBox_quantite_TextChanged(sender As Object, e As EventArgs) Handles TextBox_quantite.TextChanged
        Try
            Dim qtite As Integer = Integer.Parse(TextBox_quantite.Text)
            Dim prnom As String = ComboBox_idproduit.SelectedValue.ToString() ' Utiliser le nom du produit
            Dim prixUnitaire As Decimal = GetPrixUnitaire(prnom)
            Dim prixTotal As Decimal = qtite * prixUnitaire
            Label_prix.Text = prixTotal.ToString()
        Catch ex As Exception
            Label_prix.Text = "0"
        End Try
    End Sub



    Private Sub DataGridView_ventes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ventes.CellClick
        Try
            If DataGridView_ventes.CurrentRow IsNot Nothing AndAlso DataGridView_ventes.CurrentRow.Index <> -1 Then
                DateTimePicker_dvente.Value = DateTime.Parse(DataGridView_ventes.CurrentRow.Cells("dvente").Value.ToString())
                ComboBox_client.Text = DataGridView_ventes.CurrentRow.Cells("client_nom").Value.ToString()
                ComboBox_idproduit.Text = DataGridView_ventes.CurrentRow.Cells("produit_nom").Value.ToString()
                TextBox_quantite.Text = DataGridView_ventes.CurrentRow.Cells("qtite").Value.ToString()
                Label_prix.Text = DataGridView_ventes.CurrentRow.Cells("prix").Value.ToString()

                ' Modifier la couleur de la ligne sélectionnée en jaune
                For Each row As DataGridViewRow In DataGridView_ventes.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                Next
                DataGridView_ventes.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
            Else
                ClearForm()
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bcl3_Click(sender As Object, e As EventArgs) Handles bcl3.Click
        Dim mn As New Login()
        mn.Show()
        Me.Close()
    End Sub

    Private Sub bcl2_Click(sender As Object, e As EventArgs) Handles bcl2.Click
        Dim p As New Produits()
        p.Show()
        Me.Close()
    End Sub

    Private Sub bcl1_Click(sender As Object, e As EventArgs) Handles bcl1.Click
        Dim cl As New Menu()
        cl.Show()
        Me.Close()
    End Sub

    Private Sub Reçu_Click(sender As Object, e As EventArgs) Handles Reçu.Click
        Dim ch As New Form1()
        ch.Show()
    End Sub
End Class