Imports System.Data.SQLite

Module Data
    Sub createNewDatabase()
        ' Ask the user where to save the new database
        Dim oSavePath As New SaveFileDialog
        With oSavePath
            .DefaultExt = "db"
            .Filter = "SQLite Database (*.db)|*.db"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "New Database Location"
        End With
        ' Show the Save Dialog
        If oSavePath.ShowDialog = Windows.Forms.DialogResult.OK Then
            createNewDatabaseFile(oSavePath.FileName)
        End If
    End Sub

    Sub createNewDatabaseFile(ByVal sPath As String)
        Dim sConnectString As String = "Data Source={0};Version=3;"
        Dim myConnection As SQLiteConnection
        Try
            sConnectString = String.Format(sConnectString, sPath)
            myConnection = New SQLiteConnection(sConnectString)
            myConnection.Open()
            ' Build tables

            ' Close connexion
            myConnection.Close()
            ' Confirm Creation
            MsgBox("Database created.", MsgBoxStyle.OkOnly, "Create New Database")
        Catch ex As Exception
            MsgBox("Cannot create Database.  " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub









End Module
