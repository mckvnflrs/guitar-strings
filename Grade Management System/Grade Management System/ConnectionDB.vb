Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcCommand
Imports System.Data.Odbc.OdbcConnection
Imports System.Windows.Forms

Public Class ConnectionDB

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)

    Public Function commandQuery(ByVal command As OdbcCommand) As Boolean

        command.Connection = connect

        Try

            connect.Open()
            command.ExecuteNonQuery()
            Return True

        Catch ex As Exception

            MessageBox.Show("ERROR: " + ex.Message, "Internal Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False

        Finally

            connect.Close()
            connect.Dispose()

        End Try
    End Function
End Class
