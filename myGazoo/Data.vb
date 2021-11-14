Imports System.Data.SQLite

Module Data
    Dim myConnection As SQLiteConnection

    Sub CloseDatabase()
        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
            My.Application.currentDatabasePath = ""
        End If
    End Sub
    Sub OpenDatabase()
        Dim oFilePath As New OpenFileDialog
        With oFilePath
            .DefaultExt = "db"
            .Filter = "SQLite Database (*.db)|*.db"
            .FilterIndex = 1
            .Title = "Select Existing Database"
        End With
        ' Retrieve the database path
        If oFilePath.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadDatabase(oFilePath.FileName)
        End If
    End Sub
    Sub LoadDatabase(sFilePath As String)
        My.Application.currentDatabasePath = ""
        My.Application.currentDatabasePath = sFilePath
        ' Establish connection
        Try
            myConnection = New SQLiteConnection("Data Source=" & sFilePath & ";Version=3;")
            myConnection.Open()
        Catch ex As Exception
            MsgBox("Cannot connect to " & sFilePath & ": " & ex.Message, MsgBoxStyle.Critical, "Error")
            myConnection.Close()
            My.Application.currentDatabasePath = ""
        End Try
    End Sub
    Sub CreateNewDatabase()
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
            CreateNewDatabaseFile(oSavePath.FileName)
        End If
    End Sub

    Sub CreateNewDatabaseFile(ByVal sPath As String)
        Dim sConnectString As String = "Data Source={0};Version=3;"
        Try
            sConnectString = String.Format(sConnectString, sPath)
            myConnection = New SQLiteConnection(sConnectString)
            myConnection.Open()
            ' Build tables
            BuildDatabaseFromScratch()
            ' Confirm Creation
            MsgBox("Database created.", MsgBoxStyle.OkOnly, "Create New Database")
            My.Application.currentDatabasePath = sPath
        Catch ex As Exception
            MsgBox("Cannot create Database.  " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub BuildDatabaseFromScratch()
        Dim sTemp As String
        ' TABLE: tPriority
        sTemp = "prioCode!text|prioDescription!text|prioRank!integer|prioColor!text"
        AddTable("tPriority", sTemp, "prioCode")
        ' TABLE: tCategory
        sTemp = "categCode!text|categDescription!text"
        AddTable("tCategory", sTemp, "categCode")
        ' TABLE: tList
        sTemp = "listCode!text|listDescription!text"
        AddTable("tList", sTemp, "listCode")
        ' TABLE: tStatus
        sTemp = "staCode!text|staDescription!text|staSort!integer|staNextStatus!text|staStage!text"
        AddTable("tStatus", sTemp, "staCode")
        ' TABLE: tSystem
        sTemp = "sysCode!text|sysValue!text"
        AddTable("tSystem", sTemp)
        ' TABLE: tTask
        sTemp = "taskNumber!text|taskListCode!text|taskCategoryCode!text|taskStatusCode!text|taskPriorityCode!text|"
        sTemp &= "taskName!text|taskDescription!text|taskCreateTime!datetime|taskEditTime!datetime|taskCloseTime!datetime"
        AddTable("tTask", sTemp, "taskNumber")
    End Sub
    Sub AddTable(sTableName As String, Optional ByVal aColumns As String = "", Optional ByVal sIndex As String = "")
        ' Build columns if passed.
        ' Columns to create must be in a regular string variable, under this format:  name!type|name!type|name!type, etc.
        Dim sOtherCols As String = ""
        If aColumns <> "" Then
            Dim colArray() As String
            Dim fldArray() As String
            Dim colCount As Integer
            Dim sName As String
            Dim sType As String
            colArray = aColumns.Split("|")
            For colCount = 0 To colArray.Length - 1
                fldArray = colArray(colCount).Split("!")
                sName = fldArray(0)
                sType = fldArray(1)
                sOtherCols &= " " & sName & " " & UCase(sType) & ", "
            Next
            sOtherCols = ", " & sOtherCols
            sOtherCols = Left(sOtherCols, Len(sOtherCols) - 2)
        End If
        ' Build the final columns list
        Dim sColumns As String = "iid INTEGER NOT NULL UNIQUE " & sOtherCols & ", PRIMARY KEY(iid AUTOINCREMENT)"
        ' Send the query to the database
        Dim sQuery As String
        sQuery = "CREATE TABLE " & sTableName & " (" & sColumns & ");"
        Dim sCommand As SQLiteCommand = myConnection.CreateCommand()
        sCommand.CommandText = sQuery
        sCommand.ExecuteNonQuery()
        ' Add index if required
        If sIndex <> "" Then
            AddIndex(sTableName, sIndex)
        End If
    End Sub
    Sub AddIndex(sTableName As String, sFieldName As String)
        Dim sName As String
        sName = "idx_" & UCase(Left(sFieldName, 1)) & Right(sFieldName, Len(sFieldName) - 1)
        Dim sTemp As String
        sTemp = "CREATE UNIQUE INDEX " & sName & " ON " & sTableName & " (" & sFieldName & " ASC)"
        Dim sCommand As SQLiteCommand = myConnection.CreateCommand()
        sCommand.CommandText = sTemp
        sCommand.ExecuteNonQuery()
    End Sub

    Public Sub FillList(cListBox As System.Windows.Forms.ListBox, sTable As String)
        Dim myReader As SQLiteDataReader
        Dim myCommand As SQLiteCommand = myConnection.CreateCommand()

        Dim sCommand As String
        Dim sColumns As String
        Dim sColNames As String

        Select Case sTable
            Case "Priorité"
                sColumns = "prioCode|prioDescription|prioRank"
                sColNames = "Code|Description|Rang"
            Case "Statut"
                sColumns = "staCode|staDescription"
                sColNames = "Code|Description"
            Case "Liste"
                sColumns = "listCode|listDescription"
                sColNames = "Code|Description"
            Case "Catégorie"
                sColumns = "categCode|categDescription"
                sColNames = "Code|Description"
        End Select
        cListBox.MultiColumn = True



    End Sub





End Module
