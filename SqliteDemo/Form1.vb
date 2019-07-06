Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class Form1
    Dim DB_Path As String
    Dim TableName As String = "hello"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Path = "Data Source = hello.db"
        Dim SQLiteCon As New SQLiteConnection(DB_Path)
        Try
            SQLiteCon.Open()
            MsgBox("connceted")
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)

        End Try

    End Sub
End Class
