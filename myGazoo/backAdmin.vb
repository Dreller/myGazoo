Imports System
Public Class backAdmin
    Private Sub cmdDatabaseNew_Click(sender As Object, e As EventArgs) Handles cmdDatabaseNew.Click
        ' Create a new Database
        CreateNewDatabase()
        UpdateScreen()
    End Sub

    Private Sub cmdDatabaseOpen_Click(sender As Object, e As EventArgs) Handles cmdDatabaseOpen.Click
        ' Open existing Database
        OpenDatabase()
        UpdateScreen()
    End Sub

    Private Sub UpdateScreen()
        If My.Application.currentDatabasePath = "" Then
            Me.cmdDatabaseNew.Enabled = True
            Me.cmdDatabaseOpen.Enabled = True
            Me.cmdDatabaseClose.Enabled = False
            Me.tab.Enabled = False
            Me.lblStatus.Text = "(Aucune connexion active)"
        Else
            Me.cmdDatabaseNew.Enabled = False
            Me.cmdDatabaseOpen.Enabled = False
            Me.cmdDatabaseClose.Enabled = True
            Me.tab.Enabled = True
            Me.lblStatus.Text = "Connecté sur: " & My.Application.currentDatabasePath
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabTables.Click

    End Sub

    Private Sub cmbTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTable.SelectedIndexChanged
        LoadTableItems(Me.cmbTable.SelectedValue.ToString)
    End Sub

    Private Sub LoadTableItems(sTable As String)

    End Sub

End Class