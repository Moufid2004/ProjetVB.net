Imports MySql.Data.MySqlClient

Public Class Prod
    Dim db As New MY_DB()

    Public Function addProduct(ByVal nompr As String, ByVal categorie As String, ByVal prixp As Decimal, ByVal qtepr As Integer) As Boolean
        Dim query As String = "INSERT INTO produits (nompr, categorie, prixp, qtepr) VALUES (@nm, @cat, @prix, @qte)"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nompr
        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categorie
        command.Parameters.Add("@prix", MySqlDbType.Decimal).Value = prixp
        command.Parameters.Add("@qte", MySqlDbType.Int32).Value = qtepr

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function getAllProducts() As DataTable
        Dim query As String = "SELECT * FROM produits"
        Return db.getData(query, Nothing)
    End Function

    Public Function updateProduct(ByVal idpr As Integer, ByVal nompr As String, ByVal categorie As String, ByVal prixp As Decimal, ByVal qtepr As Integer) As Boolean
        Dim query As String = "UPDATE produits SET nompr=@nm, categorie=@cat, prixp=@prix, qtepr=@qte WHERE idpr=@id"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = idpr
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nompr
        command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categorie
        command.Parameters.Add("@prix", MySqlDbType.Decimal).Value = prixp
        command.Parameters.Add("@qte", MySqlDbType.Int32).Value = qtepr

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function deleteProduct(ByVal idpr As Integer) As Boolean
        Dim query As String = "DELETE FROM produits WHERE idpr=@id"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = idpr

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function searchProduct(ByVal searchTerm As String) As DataTable
        Dim query As String = "SELECT * FROM produits WHERE nompr LIKE @search OR categorie LIKE @search OR prixp LIKE @search OR qtepr LIKE @search"
        Dim command As New MySqlCommand(query, db.getConnection)

        command.Parameters.Add("@search", MySqlDbType.VarChar).Value = "%" & searchTerm & "%"

        Return db.getData(query, command.Parameters.Cast(Of MySqlParameter).ToArray())
    End Function
End Class

