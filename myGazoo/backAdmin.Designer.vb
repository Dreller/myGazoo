Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class backAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.cmdDatabaseNew = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdDatabaseOpen = New System.Windows.Forms.Button()
        Me.cmdDatabaseClose = New System.Windows.Forms.Button()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabTables = New System.Windows.Forms.TabPage()
        Me.lblTabTablesName = New System.Windows.Forms.Label()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.lstTable = New System.Windows.Forms.ListBox()
        Me.StatusStrip1.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.tabTables.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(8, 36)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(112, 19)
        Me.lblDatabase.TabIndex = 0
        Me.lblDatabase.Text = "Base de données"
        '
        'cmdDatabaseNew
        '
        Me.cmdDatabaseNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDatabaseNew.Location = New System.Drawing.Point(8, 58)
        Me.cmdDatabaseNew.Name = "cmdDatabaseNew"
        Me.cmdDatabaseNew.Size = New System.Drawing.Size(142, 29)
        Me.cmdDatabaseNew.TabIndex = 1
        Me.cmdDatabaseNew.Text = "Nouveau..."
        Me.cmdDatabaseNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabaseNew.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 24)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(209, 19)
        Me.lblStatus.Text = "(Aucune base de données active)"
        '
        'cmdDatabaseOpen
        '
        Me.cmdDatabaseOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDatabaseOpen.Location = New System.Drawing.Point(8, 93)
        Me.cmdDatabaseOpen.Name = "cmdDatabaseOpen"
        Me.cmdDatabaseOpen.Size = New System.Drawing.Size(142, 29)
        Me.cmdDatabaseOpen.TabIndex = 5
        Me.cmdDatabaseOpen.Text = "Ouvrir..."
        Me.cmdDatabaseOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabaseOpen.UseVisualStyleBackColor = True
        '
        'cmdDatabaseClose
        '
        Me.cmdDatabaseClose.Enabled = False
        Me.cmdDatabaseClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDatabaseClose.Location = New System.Drawing.Point(8, 128)
        Me.cmdDatabaseClose.Name = "cmdDatabaseClose"
        Me.cmdDatabaseClose.Size = New System.Drawing.Size(142, 29)
        Me.cmdDatabaseClose.TabIndex = 6
        Me.cmdDatabaseClose.Text = "Fermer"
        Me.cmdDatabaseClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabaseClose.UseVisualStyleBackColor = True
        '
        'tab
        '
        Me.tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab.Controls.Add(Me.tabSettings)
        Me.tab.Controls.Add(Me.tabTables)
        Me.tab.Location = New System.Drawing.Point(156, 58)
        Me.tab.Multiline = True
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(644, 365)
        Me.tab.TabIndex = 7
        '
        'tabSettings
        '
        Me.tabSettings.Location = New System.Drawing.Point(4, 28)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(636, 333)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Paramètres"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabTables
        '
        Me.tabTables.Controls.Add(Me.lstTable)
        Me.tabTables.Controls.Add(Me.lblTabTablesName)
        Me.tabTables.Controls.Add(Me.cmbTable)
        Me.tabTables.Location = New System.Drawing.Point(4, 28)
        Me.tabTables.Name = "tabTables"
        Me.tabTables.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTables.Size = New System.Drawing.Size(636, 333)
        Me.tabTables.TabIndex = 1
        Me.tabTables.Text = "Tables"
        Me.tabTables.UseVisualStyleBackColor = True
        '
        'lblTabTablesName
        '
        Me.lblTabTablesName.AutoSize = True
        Me.lblTabTablesName.Location = New System.Drawing.Point(10, 13)
        Me.lblTabTablesName.Name = "lblTabTablesName"
        Me.lblTabTablesName.Size = New System.Drawing.Size(109, 19)
        Me.lblTabTablesName.TabIndex = 1
        Me.lblTabTablesName.Text = "Nom de la table:"
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Items.AddRange(New Object() {"Priorité", "Statut", "Catégorie", "Liste"})
        Me.cmbTable.Location = New System.Drawing.Point(125, 9)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(488, 27)
        Me.cmbTable.TabIndex = 0
        '
        'lstTable
        '
        Me.lstTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTable.FormattingEnabled = True
        Me.lstTable.ItemHeight = 19
        Me.lstTable.Location = New System.Drawing.Point(10, 69)
        Me.lstTable.MultiColumn = True
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(603, 249)
        Me.lstTable.TabIndex = 2
        '
        'backAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab)
        Me.Controls.Add(Me.cmdDatabaseClose)
        Me.Controls.Add(Me.cmdDatabaseOpen)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdDatabaseNew)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "backAdmin"
        Me.Text = "backAdmin"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tab.ResumeLayout(False)
        Me.tabTables.ResumeLayout(False)
        Me.tabTables.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub backAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Close connection if connection is Up
        CloseDatabase()
    End Sub

    Friend WithEvents lblDatabase As Label
    Friend WithEvents cmdDatabaseNew As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents cmdDatabaseOpen As Button
    Friend WithEvents cmdDatabaseClose As Button
    Friend WithEvents tab As TabControl
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tabTables As TabPage
    Friend WithEvents lblTabTablesName As Label
    Friend WithEvents cmbTable As ComboBox
    Friend WithEvents lstTable As ListBox
End Class
