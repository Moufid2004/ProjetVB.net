Imports MySql.Data.MySqlClient

Public Class Vent
    Dim db As New MY_DB()

    ' Ajouter une vente en utilisant les noms des clients et des produits
    Public Function addVente(ByVal dvente As DateTime, ByVal clnom As String, ByVal prnom As String, ByVal qtite As Integer, ByVal prix As Decimal) As Boolean
        Dim query As String = "INSERT INTO ventes (dvente, clnom, prnom, qtite, prix) VALUES (@date, @client, @produit, @quantite, @prix)"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dvente
        command.Parameters.Add("@client", MySqlDbType.VarChar).Value = clnom
        command.Parameters.Add("@produit", MySqlDbType.VarChar).Value = prnom
        command.Parameters.Add("@quantite", MySqlDbType.Int32).Value = qtite
        command.Parameters.Add("@prix", MySqlDbType.Decimal).Value = prix

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    ' Obtenir toutes les ventes avec les noms des clients et produits
    Public Function getAllVentes() As DataTable
        Dim query As String = "SELECT v.idv, v.dvente, v.clnom AS client_nom, v.prnom AS produit_nom, v.qtite, v.prix FROM ventes v"
        Return db.getData(query, Nothing)
    End Function

    ' Mettre à jour une vente en utilisant les noms
    Public Function updateVente(ByVal idv As Integer, ByVal dvente As DateTime, ByVal clnom As String, ByVal prnom As String, ByVal qtite As Integer, ByVal prix As Decimal) As Boolean
        Dim query As String = "UPDATE ventes SET dvente=@date, clnom=@client, prnom=@produit, qtite=@quantite, prix=@prix WHERE idv=@id"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = idv
        command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dvente
        command.Parameters.Add("@client", MySqlDbType.VarChar).Value = clnom
        command.Parameters.Add("@produit", MySqlDbType.VarChar).Value = prnom
        command.Parameters.Add("@quantite", MySqlDbType.Int32).Value = qtite
        command.Parameters.Add("@prix", MySqlDbType.Decimal).Value = prix

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    ' Supprimer une vente
    Public Function deleteVente(ByVal idv As Integer) As Boolean
        Dim query As String = "DELETE FROM ventes WHERE idv=@id"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = idv

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    ' Rechercher une vente en fonction des noms ou de la date
    Public Function searchVente(ByVal searchTerm As String) As DataTable
        Dim query As String = "SELECT v.idv, v.dvente, v.clnom AS client_nom, v.prnom AS produit_nom, v.qtite, v.prix FROM ventes v WHERE v.clnom LIKE @search OR v.prnom LIKE @search OR v.dvente LIKE @search"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@search", MySqlDbType.VarChar).Value = "%" & searchTerm & "%"

        Return db.getData(query, command.Parameters.Cast(Of MySqlParameter).ToArray())
    End Function
End Class
