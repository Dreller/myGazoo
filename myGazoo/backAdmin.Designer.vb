<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.cmdDatabaseNew = New System.Windows.Forms.Button()
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
        Me.cmdDatabaseNew.Location = New System.Drawing.Point(8, 58)
        Me.cmdDatabaseNew.Name = "cmdDatabaseNew"
        Me.cmdDatabaseNew.Size = New System.Drawing.Size(142, 23)
        Me.cmdDatabaseNew.TabIndex = 1
        Me.cmdDatabaseNew.Text = "Nouveau..."
        Me.cmdDatabaseNew.UseVisualStyleBackColor = True
        '
        'backAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdDatabaseNew)
        Me.Controls.Add(Me.lblDatabase)
        Me.Name = "backAdmin"
        Me.Text = "backAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDatabase As Label
    Friend WithEvents cmdDatabaseNew As Button
End Class
