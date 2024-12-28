Imports MySql.Data.MySqlClient

Public Class Login
    Private menuForm As Menu

    ' Constructeur par défaut
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructeur avec une référence au menu principal (si nécessaire)
    Public Sub New(mainMenu As Menu)
        InitializeComponent()
        menuForm = mainMenu
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Initialisation des champs texte
        TextBox1.Text = "Username"
        TextBox1.ForeColor = Color.Gray

        TextBox2.Text = "Password"
        TextBox2.ForeColor = Color.Gray
        TextBox2.PasswordChar = ControlChars.NullChar ' Rendre visible initialement
    End Sub

    ' Gestion des focus pour TextBox1 (nom d'utilisateur)
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    ' Gestion des focus pour TextBox2 (mot de passe)
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "•"c ' Masquer le texte
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "Password"
            TextBox2.ForeColor = Color.Gray
            TextBox2.PasswordChar = ControlChars.NullChar ' Afficher le texte
        End If
    End Sub

    ' Affichage/masquage du mot de passe
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.PasswordChar = If(CheckBox1.Checked, ControlChars.NullChar, "•"c)
    End Sub

    ' Gestion du bouton de connexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Vérification des champs vides
        If String.IsNullOrEmpty(username) OrElse username = "Username" Then
            MessageBox.Show("Veuillez entrer votre nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(password) OrElse password = "Password" Then
            MessageBox.Show("Veuillez entrer votre mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Vérification des identifiants
        Dim mydb As New MY_DB()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass", mydb.getConnection)

        Try
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            ' Vérification si l'utilisateur existe
            If table.Rows.Count > 0 Then
                MessageBox.Show("Connexion réussie. Bienvenue !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Ouvrir la fenêtre Menu
                Dim menuPage As New Menu()
                menuPage.Show()

                ' Fermer la fenêtre de connexion
                Me.Hide() ' Utilisez Close() si vous n'avez plus besoin de la fenêtre Login
            Else
                MessageBox.Show("Identifiants incorrects. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            mydb.getConnection.Close()
        End Try
    End Sub
End Class
