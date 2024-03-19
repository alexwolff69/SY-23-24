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
        Me.components = New System.ComponentModel.Container()
        Me.pickplayer = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.Picair = New System.Windows.Forms.PictureBox()
        CType(Me.pickplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pickplayer
        '
        Me.pickplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pickplayer.Location = New System.Drawing.Point(46, 260)
        Me.pickplayer.Name = "pickplayer"
        Me.pickplayer.Size = New System.Drawing.Size(125, 62)
        Me.pickplayer.TabIndex = 0
        Me.pickplayer.TabStop = False
        '
        'tmrright
        '
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.Crimson
        Me.Picair.Location = New System.Drawing.Point(1, 396)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(787, 62)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Picair)
        Me.Controls.Add(Me.pickplayer)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        CType(Me.pickplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pickplayer As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents Picair As PictureBox
End Class
