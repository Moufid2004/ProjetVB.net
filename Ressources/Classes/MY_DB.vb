Imports MySql.Data.MySqlClient

Public Class MY_DB
    Private ReadOnly connection As New MySqlConnection("Server=localhost;Port=3306;User=root;Password=;Database=pvb")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Fonction pour obtenir des données sous forme de DataTable
    Public Function getData(ByVal query As String, ByVal params As MySqlParameter()) As DataTable
        Dim command As New MySqlCommand(query, connection)

        ' Vérifier si des paramètres ont été fournis
        If params IsNot Nothing Then
            command.Parameters.AddRange(params)
        End If

        Try
            openConnection()

            ' Utiliser un DataAdapter pour remplir une DataTable
            Dim dataAdapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            Return dataTable
        Catch ex As Exception
            ' Gérer l'exception (afficher un message d'erreur, journaliser, etc.)
            MessageBox.Show($"Une erreur s'est produite lors de la récupération des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            closeConnection()
        End Try
    End Function


    ' Utilisez cette fonction pour les opérations INSERT, UPDATE, DELETE
    Public Function setData(ByVal query As String, ByVal params As MySqlParameter()) As Integer
        Dim command As New MySqlCommand(query, connection)

        ' Vérifier si des paramètres ont été fournis
        If params IsNot Nothing Then
            command.Parameters.AddRange(params)
        End If

        openConnection()

        Dim commandState As Integer = command.ExecuteNonQuery()

        closeConnection()

        Return commandState
    End Function
End Class
