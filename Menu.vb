Imports System.IO
Imports Windows.Win32.System

Public Class Menu
    Inherits Form
    Dim clients As New Clients()

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Button_select.Image = Image.FromFile("C:\Users\HP\Documents\Epreuves et TD Licence3\TRANSMISSION\Cours S5\Projet VbNet\Gestion\IMAGES\icons8-upload-48.png")
        'Guna2PictureBox1.Image = Image.FromFile("C:\Users\HP\Documents\Epreuves et TD Licence3\TRANSMISSION\Cours S5\Projet VbNet\Gestion\IMAGES\tof.jpg")

        ' Définir AutoGenerateColumns sur True
        DataGridView_membre.AutoGenerateColumns = True

        LoadClientData()

        ' Charger les données dans le DataGridView
        DataGridView_membre.DataSource = clients.getAllClients()

        ' Afficher les en-têtes de colonne
        DataGridView_membre.ColumnHeadersVisible = True
        DataGridView_membre.RowTemplate.Height = 100 ' Ajuste cette valeur selon tes besoins


        ' Mise en page du DataGridView
        ' DataGridView_membre.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView_membre.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
        DataGridView_membre.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView_membre.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        DataGridView_membre.EnableHeadersVisualStyles = False

        AddHandler DataGridView_membre.CellClick, AddressOf DataGridView_membre_CellClick


        UpdateClientCount()
    End Sub

    Private Sub UpdateClientCount()
        Label_total1.Text = (DataGridView_membre.Rows.Count - 1).ToString() & " clients"
    End Sub

    Private Sub LoadClientData()
        DataGridView_membre.DataSource = Nothing
        DataGridView_membre.DataSource = clients.getAllClients()
        UpdateClientCount()
    End Sub


    Private Sub ba_Click(sender As Object, e As EventArgs) Handles ba.Click
        Try
            Dim Nom As String = tcl1.Text.Trim()
            Dim Prenoms As String = tcl2.Text.Trim()
            Dim Telephone As String = tcl3.Text.Trim()
            Dim Numero As Integer

            ' Vérifier si tcl3 contient une valeur numérique
            If Integer.TryParse(Telephone, Numero) Then
                If tcl4.Image IsNot Nothing Then ' Vérifier si une image a été ajoutée
                    Dim stream As New MemoryStream()
                    tcl4.Image.Save(stream, tcl4.Image.RawFormat)

                    ' Vérifier si l'image est vide avant de tenter la conversion en tableau de bytes
                    If stream.Length > 0 Then
                        Dim Photo As Byte() = stream.ToArray()

                        If Nom.Equals("") Then
                            MessageBox.Show("Entrez le nom du client", "Nom manquant", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ElseIf Prenoms.Equals("") Then
                            MessageBox.Show("Entrez le prénom", "Prénom manquant", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Else
                            If clients.addClient(Nom, Prenoms, Numero, Photo) Then
                                MessageBox.Show("Ajout réussi", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                tcl1.Text = ""
                                tcl2.Text = ""
                                tcl3.Text = ""
                                tcl4.Image = Nothing

                                DataGridView_membre.DataSource = clients.getAllClients()

                                LoadClientData()
                            Else
                                MessageBox.Show("Ajout invalide")
                            End If
                        End If
                    Else
                        MessageBox.Show("L'image ne peut pas être vide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Veuillez ajouter une image du client.", "Image manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Le numéro doit être une valeur numérique", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As FormatException
            MessageBox.Show($"Erreur de format : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DataGridView_membre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_membre.CellContentClick

    End Sub
    Private Sub DataGridView_membre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_membre.CellClick
        Try
            If DataGridView_membre.CurrentRow IsNot Nothing AndAlso DataGridView_membre.CurrentRow.Index <> -1 Then
                tcl1.Text = DataGridView_membre.CurrentRow.Cells(1).Value.ToString() ' Nom
                tcl2.Text = DataGridView_membre.CurrentRow.Cells(2).Value.ToString() ' Prénom
                tcl3.Text = DataGridView_membre.CurrentRow.Cells(3).Value.ToString() ' Téléphone
                For Each row As DataGridViewRow In DataGridView_membre.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                Next
                DataGridView_membre.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
                ' Charger l'image si elle existe
                If Not IsDBNull(DataGridView_membre.CurrentRow.Cells(4).Value) Then
                    Dim photoBytes As Byte() = CType(DataGridView_membre.CurrentRow.Cells(4).Value, Byte())
                    Dim stream As New MemoryStream(photoBytes)
                    tcl4.Image = Image.FromStream(stream)
                Else
                    tcl4.Image = Nothing
                End If
            Else
                ' Effacer les champs si aucune ligne n'est sélectionnée
                tcl1.Text = ""
                tcl2.Text = ""
                tcl3.Text = ""
                tcl4.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button_select_Click(sender As Object, e As EventArgs) Handles Button_select.Click
        Dim opf As New OpenFileDialog()
        opf.Filter = "Choose Image (*.jpg;*.png;*gif)|*.jpg;*.png;*gif"

        If opf.ShowDialog() = DialogResult.OK Then
            tcl4.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub bs_Click(sender As Object, e As EventArgs) Handles bs.Click
        Try
            ' Recherche du client par le nom et le téléphone
            Dim nom As String = tcl1.Text.Trim()
            Dim telephone As String = tcl3.Text.Trim()

            If nom <> "" AndAlso telephone <> "" Then
                Dim dataTable As DataTable = clients.getClientByNameAndPhone(nom, telephone)
                If dataTable.Rows.Count = 1 Then
                    Dim clientId As Integer = Convert.ToInt32(dataTable.Rows(0)("idcl"))

                    ' Message de confirmation 
                    If MessageBox.Show("Voulez-vous vraiment supprimer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If clients.deleteClient(clientId) Then
                            MessageBox.Show("Suppression réussie", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            tcl1.Text = ""
                            tcl2.Text = ""
                            tcl3.Text = ""
                            tcl4.Image = Nothing

                            DataGridView_membre.DataSource = clients.getAllClients()
                            LoadClientData()
                            UpdateClientCount()
                        Else
                            MessageBox.Show("Suppression invalide", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    MessageBox.Show("Client non trouvé ou plusieurs clients avec les mêmes informations.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Veuillez entrer le nom et le téléphone du client.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub tcl4_Click(sender As Object, e As EventArgs) Handles tcl4.Click

    End Sub

    Private Sub bm_Click(sender As Object, e As EventArgs) Handles bm.Click
        Try
            ' Vérifie que la ligne sélectionnée existe et récupère l'ID
            If DataGridView_membre.CurrentRow IsNot Nothing AndAlso DataGridView_membre.CurrentRow.Index <> -1 Then
                Dim idcl As Integer = Convert.ToInt32(DataGridView_membre.CurrentRow.Cells("idcl").Value)
                Dim Nom As String = tcl1.Text.Trim()
                Dim Prenoms As String = tcl2.Text.Trim()
                Dim Telephone As String = tcl3.Text.Trim()
                Dim Numero As Integer

                If Integer.TryParse(Telephone, Numero) Then
                    If tcl4.Image IsNot Nothing Then
                        Dim stream As New MemoryStream()
                        tcl4.Image.Save(stream, tcl4.Image.RawFormat)

                        If stream.Length > 0 Then
                            Dim Photo As Byte() = stream.ToArray()

                            If Nom.Equals("") Then
                                MessageBox.Show("Entrez le nom du client", "Nom manquant", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ElseIf Prenoms.Equals("") Then
                                MessageBox.Show("Entrez le prénom", "Prénom manquant", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Else
                                If clients.editClient(idcl, Nom, Prenoms, Numero, Photo) Then
                                    MessageBox.Show("Modification réussie", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    tcl1.Text = ""
                                    tcl2.Text = ""
                                    tcl3.Text = ""
                                    tcl4.Image = Nothing

                                    LoadClientData()
                                Else
                                    MessageBox.Show("Modification invalide")
                                End If
                            End If
                        Else
                            MessageBox.Show("L'image ne peut pas être vide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Veuillez ajouter une image du client.", "Image manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Le numéro doit être une valeur numérique", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Aucune ligne sélectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As FormatException
            MessageBox.Show($"Erreur de format : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub br_TextChanged(sender As Object, e As EventArgs) Handles br.TextChanged
        SearchClients(br.Text.Trim())
    End Sub

    Private Sub SearchClients(searchTerm As String)
        ' Récupère tous les clients
        Dim allClients As DataTable = clients.getAllClients()

        ' Crée un DataView pour filtrer les données
        Dim dv As DataView = allClients.DefaultView
        dv.RowFilter = $"nomcl LIKE '%{searchTerm}%' OR prenomcl LIKE '%{searchTerm}%' OR telcl LIKE '%{searchTerm}%'"

        ' Met à jour le DataGridView avec les données filtrées
        DataGridView_membre.DataSource = dv
    End Sub

    Private Sub bcl3_Click(sender As Object, e As EventArgs) Handles bcl3.Click
        Dim mn As New Login()
        mn.Show()
        Me.Close()
    End Sub

    Private Sub bcl1_Click(sender As Object, e As EventArgs) Handles bcl1.Click
        Dim p As New Produits()
        p.Show()
        Me.Close()
    End Sub

    Private Sub bcl2_Click(sender As Object, e As EventArgs) Handles bcl2.Click
        Dim v As New Ventes()
        v.Show()
        Me.Close()
    End Sub
End Class