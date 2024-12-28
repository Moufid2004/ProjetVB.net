Imports System.IO

Public Class Produits
    Inherits Form

    Private Sub Produits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Ajouter les catégories au combobox
        ComboBox_categorie.SelectedIndex = 0 ' Sélectionner la première catégorie par défaut

        LoadProductData()
    End Sub

    Private Sub LoadProductData()
        Dim produits As New Prod()
        DataGridView_produits.DataSource = produits.getAllProducts()

        ' Configurer les colonnes
        If DataGridView_produits.Columns.Count > 0 Then
            DataGridView_produits.Columns("idpr").HeaderText = "ID"
            DataGridView_produits.Columns("nompr").HeaderText = "Nom du produit"
            DataGridView_produits.Columns("categorie").HeaderText = "Catégorie"
            DataGridView_produits.Columns("prixp").HeaderText = "Prix"
            DataGridView_produits.Columns("qtepr").HeaderText = "Quantité"
        End If
        UpdateProductCount()
    End Sub



    Private Sub UpdateProductCount()
        afp.Text = (DataGridView_produits.Rows.Count - 1).ToString() & " produits"
    End Sub

    Private Sub btnAjouterProduit_Click(sender As Object, e As EventArgs) Handles btnAjouterProduit.Click
        Try
            Dim nompr As String = TextBox_nompr.Text.Trim()
            Dim categorie As String = ComboBox_categorie.SelectedItem.ToString()
            Dim prixp As Decimal = Decimal.Parse(TextBox_prixp.Text)
            Dim qtepr As Integer = Integer.Parse(TextBox_qtepr.Text)

            If nompr.Equals("") OrElse prixp <= 0 OrElse qtepr <= 0 Then
                MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim produits As New Prod()
                If produits.addProduct(nompr, categorie, prixp, qtepr) Then
                    MessageBox.Show("Produit ajouté avec succès", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadProductData()
                    ClearForm()
                Else
                    MessageBox.Show("L'ajout du produit a échoué.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModifierProduit_Click(sender As Object, e As EventArgs) Handles btnModifierProduit.Click
        Try
            Dim idpr As Integer = Integer.Parse(DataGridView_produits.CurrentRow.Cells("idpr").Value.ToString())
            Dim nompr As String = TextBox_nompr.Text.Trim()
            Dim categorie As String = ComboBox_categorie.SelectedItem.ToString()
            Dim prixp As Decimal = Decimal.Parse(TextBox_prixp.Text)
            Dim qtepr As Integer = Integer.Parse(TextBox_qtepr.Text)

            If nompr.Equals("") OrElse prixp <= 0 OrElse qtepr <= 0 Then
                MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim produits As New Prod()
                If produits.updateProduct(idpr, nompr, categorie, prixp, qtepr) Then
                    MessageBox.Show("Produit modifié avec succès", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadProductData()
                    ClearForm()
                Else
                    MessageBox.Show("La modification du produit a échoué.", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSupprimerProduit_Click(sender As Object, e As EventArgs) Handles btnSupprimerProduit.Click
        Try
            Dim idpr As Integer = Integer.Parse(DataGridView_produits.CurrentRow.Cells("idpr").Value.ToString())

            If MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim produits As New Prod()
                If produits.deleteProduct(idpr) Then
                    MessageBox.Show("Produit supprimé avec succès", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadProductData()
                    ClearForm()
                Else
                    MessageBox.Show("La suppression du produit a échoué.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rpr_TextChanged(sender As Object, e As EventArgs) Handles rpr.TextChanged
        Dim searchTerm As String = rpr.Text.Trim()
        Dim produits As New Prod()
        DataGridView_produits.DataSource = produits.searchProduct(searchTerm)
        UpdateProductCount()
    End Sub

    Private Sub ClearForm()
        TextBox_nompr.Text = ""
        ComboBox_categorie.SelectedIndex = 0
        TextBox_prixp.Text = ""
        TextBox_qtepr.Text = ""
    End Sub

    Private Sub DataGridView_produits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_produits.CellClick
        Try
            If DataGridView_produits.CurrentRow IsNot Nothing AndAlso DataGridView_produits.CurrentRow.Index <> -1 Then
                TextBox_nompr.Text = DataGridView_produits.CurrentRow.Cells("nompr").Value.ToString()
                ComboBox_categorie.SelectedItem = DataGridView_produits.CurrentRow.Cells("categorie").Value.ToString()
                TextBox_prixp.Text = DataGridView_produits.CurrentRow.Cells("prixp").Value.ToString()
                TextBox_qtepr.Text = DataGridView_produits.CurrentRow.Cells("qtepr").Value.ToString()

                ' Modifier la couleur de la ligne sélectionnée en jaune
                For Each row As DataGridViewRow In DataGridView_produits.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                Next
                DataGridView_produits.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
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

    Private Sub bcl1_Click(sender As Object, e As EventArgs) Handles bcl1.Click
        Dim c As New Menu()
        c.Show()
        Me.Close()
    End Sub

    Private Sub bcl2_Click(sender As Object, e As EventArgs) Handles bcl2.Click
        Dim vt As New Ventes()
        vt.Show()
        Me.Close()
    End Sub
End Class
