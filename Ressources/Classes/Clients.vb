Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Clients

    Dim db As New MY_DB()

    ' Ajout d'un nouveau client
    Public Function addClient(ByVal nomcl As String, ByVal prenomcl As String, ByVal telcl As String, ByVal photocl As Byte()) As Boolean
        Dim query As String = "INSERT INTO `clients`(`nomcl`, `prenomcl`, `telcl`, `photocl`) VALUES (@nomcl, @prenomcl, @telcl, @photocl)"
        Dim params(3) As MySqlParameter

        params(0) = New MySqlParameter("@nomcl", MySqlDbType.VarChar)
        params(0).Value = nomcl

        params(1) = New MySqlParameter("@prenomcl", MySqlDbType.VarChar)
        params(1).Value = prenomcl

        params(2) = New MySqlParameter("@telcl", MySqlDbType.VarChar)
        params(2).Value = telcl

        params(3) = New MySqlParameter("@photocl", MySqlDbType.Blob)
        params(3).Value = photocl

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Modification d'un client
    Public Function editClient(ByVal idcl As Integer, ByVal nomcl As String, ByVal prenomcl As String, ByVal telcl As String, ByVal photocl As Byte()) As Boolean
        Dim query As String = "UPDATE `clients` SET `nomcl`=@nomcl, `prenomcl`=@prenomcl, `telcl`=@telcl, `photocl`=@photocl WHERE `idcl`=@idcl"
        Dim params(4) As MySqlParameter

        params(0) = New MySqlParameter("@idcl", MySqlDbType.Int32)
        params(0).Value = idcl

        params(1) = New MySqlParameter("@nomcl", MySqlDbType.VarChar)
        params(1).Value = nomcl

        params(2) = New MySqlParameter("@prenomcl", MySqlDbType.VarChar)
        params(2).Value = prenomcl

        params(3) = New MySqlParameter("@telcl", MySqlDbType.VarChar)
        params(3).Value = telcl

        params(4) = New MySqlParameter("@photocl", MySqlDbType.Blob)
        params(4).Value = photocl

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Suppression d'un client
    Public Function deleteClient(ByVal idcl As Integer) As Boolean
        Dim query As String = "DELETE FROM `clients` WHERE `idcl` = @idcl"
        Dim params(0) As MySqlParameter

        params(0) = New MySqlParameter("@idcl", MySqlDbType.Int32)
        params(0).Value = idcl

        If db.setData(query, params).Equals(1) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Récupérer un client par ID
    Public Function getClientById(ByVal idcl As Integer) As DataTable
        Try
            Dim query As String = "SELECT * FROM `clients` WHERE `idcl` = @idcl"
            Dim params(0) As MySqlParameter

            params(0) = New MySqlParameter("@idcl", MySqlDbType.Int32)
            params(0).Value = idcl

            Dim tableClient As DataTable = db.getData(query, params)
            Return tableClient
        Catch ex As Exception
            MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function getClientByNameAndPhone(ByVal nom As String, ByVal telephone As String) As DataTable
        Dim query As String = "SELECT * FROM clients WHERE nomcl = @nm AND telcl = @tel"
        Dim command As New MySqlCommand(query, db.getConnection)
        command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nom
        command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telephone
        Return db.getData(query, command.Parameters.Cast(Of MySqlParameter).ToArray())
    End Function

    ' Récupérer tous les clients
    Public Function getAllClients() As DataTable
        Dim query As String = "SELECT * FROM `clients`"
        Dim tableClients As DataTable = db.getData(query, Nothing)
        Return tableClients
    End Function
End Class
