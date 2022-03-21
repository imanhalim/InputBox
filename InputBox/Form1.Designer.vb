<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TxtName = New System.Windows.Forms.Button()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.enter = New System.Windows.Forms.Label()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(380, 266)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(90, 23)
        Me.TxtName.TabIndex = 0
        Me.TxtName.Text = "CLICK HERE"
        Me.TxtName.UseVisualStyleBackColor = True
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(344, 216)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(180, 23)
        Me.TextName.TabIndex = 2
        '
        'enter
        '
        Me.enter.AutoSize = True
        Me.enter.Location = New System.Drawing.Point(212, 219)
        Me.enter.Name = "enter"
        Me.enter.Size = New System.Drawing.Size(96, 15)
        Me.enter.TabIndex = 3
        Me.enter.Text = "Enter Your Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Location = New System.Drawing.Point(225, 334)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(45, 15)
        Me.LblOutput.TabIndex = 5
        Me.LblOutput.Text = "Result :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 454)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.enter)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As Button
    Friend WithEvents TextName As TextBox
    Friend WithEvents enter As Label
    Friend WithEvents LblOutput As Label
End Class
