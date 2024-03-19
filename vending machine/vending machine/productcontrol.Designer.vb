<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productcontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(3, 68)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(24, 20)
        Me.idLabel.TabIndex = 1
        Me.idLabel.Text = "ID"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(54, 68)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(42, 20)
        Me.priceLabel.TabIndex = 2
        Me.priceLabel.Text = "price"
        '
        'productcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "productcontrol"
        Me.Size = New System.Drawing.Size(144, 93)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents idLabel As Label
    Friend WithEvents priceLabel As Label
End Class
