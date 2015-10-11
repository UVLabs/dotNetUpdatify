<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_Checkupdates = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Checkupdates
        '
        Me.btn_Checkupdates.Location = New System.Drawing.Point(67, 87)
        Me.btn_Checkupdates.Name = "btn_Checkupdates"
        Me.btn_Checkupdates.Size = New System.Drawing.Size(137, 44)
        Me.btn_Checkupdates.TabIndex = 1
        Me.btn_Checkupdates.Text = "check for updates"
        Me.btn_Checkupdates.UseVisualStyleBackColor = True
        '
        'fm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_Checkupdates)
        Me.Name = "fm_main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Checkupdates As Button
End Class
