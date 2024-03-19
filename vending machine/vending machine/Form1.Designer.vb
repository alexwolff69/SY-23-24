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
        Me.dollars = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dollarcoin = New System.Windows.Forms.PictureBox()
        Me.Productcontrol1 = New vending_machine.productcontrol()
        Me.Productcontrol2 = New vending_machine.productcontrol()
        Me.IDtextbox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.productPictureBox = New System.Windows.Forms.PictureBox()
        Me.Productcontrol3 = New vending_machine.productcontrol()
        Me.Productcontrol4 = New vending_machine.productcontrol()
        Me.Productcontrol5 = New vending_machine.productcontrol()
        Me.Productcontrol6 = New vending_machine.productcontrol()
        CType(Me.dollarcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dollars
        '
        Me.dollars.Location = New System.Drawing.Point(38, 43)
        Me.dollars.Name = "dollars"
        Me.dollars.Size = New System.Drawing.Size(94, 29)
        Me.dollars.TabIndex = 0
        Me.dollars.Text = "dollars"
        Me.dollars.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "quarters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(38, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "nickles"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "coin return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dollarcoin
        '
        Me.dollarcoin.Location = New System.Drawing.Point(339, 331)
        Me.dollarcoin.Name = "dollarcoin"
        Me.dollarcoin.Size = New System.Drawing.Size(125, 62)
        Me.dollarcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarcoin.TabIndex = 6
        Me.dollarcoin.TabStop = False
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol1.Location = New System.Drawing.Point(931, 12)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productcount = 2
        Me.Productcontrol1.productID = "A1"
        Me.Productcontrol1.productpicture = Global.vending_machine.My.Resources.Resources.download
        Me.Productcontrol1.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol1.Size = New System.Drawing.Size(134, 92)
        Me.Productcontrol1.TabIndex = 7
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol2.Location = New System.Drawing.Point(809, 12)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productcount = 0
        Me.Productcontrol2.productID = "A2"
        Me.Productcontrol2.productpicture = Global.vending_machine.My.Resources.Resources.download31
        Me.Productcontrol2.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol2.Size = New System.Drawing.Size(116, 92)
        Me.Productcontrol2.TabIndex = 8
        '
        'IDtextbox
        '
        Me.IDtextbox.Location = New System.Drawing.Point(29, 353)
        Me.IDtextbox.Name = "IDtextbox"
        Me.IDtextbox.Size = New System.Drawing.Size(125, 27)
        Me.IDtextbox.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(38, 396)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "buy"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'productPictureBox
        '
        Me.productPictureBox.Location = New System.Drawing.Point(715, 331)
        Me.productPictureBox.Name = "productPictureBox"
        Me.productPictureBox.Size = New System.Drawing.Size(125, 62)
        Me.productPictureBox.TabIndex = 11
        Me.productPictureBox.TabStop = False
        '
        'Productcontrol3
        '
        Me.Productcontrol3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol3.Location = New System.Drawing.Point(678, 12)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.productcount = 0
        Me.Productcontrol3.productID = Nothing
        Me.Productcontrol3.productpicture = Global.vending_machine.My.Resources.Resources.download4
        Me.Productcontrol3.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol3.Size = New System.Drawing.Size(125, 92)
        Me.Productcontrol3.TabIndex = 12
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol4.Location = New System.Drawing.Point(563, 12)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productcount = 0
        Me.Productcontrol4.productID = Nothing
        Me.Productcontrol4.productpicture = Global.vending_machine.My.Resources.Resources.download5
        Me.Productcontrol4.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol4.Size = New System.Drawing.Size(109, 92)
        Me.Productcontrol4.TabIndex = 13
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol5.Location = New System.Drawing.Point(440, 7)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productcount = 0
        Me.Productcontrol5.productID = Nothing
        Me.Productcontrol5.productpicture = Global.vending_machine.My.Resources.Resources.download6
        Me.Productcontrol5.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol5.Size = New System.Drawing.Size(117, 97)
        Me.Productcontrol5.TabIndex = 14
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Productcontrol6.Location = New System.Drawing.Point(321, 7)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productcount = 0
        Me.Productcontrol6.productID = Nothing
        Me.Productcontrol6.productpicture = Global.vending_machine.My.Resources.Resources.download8
        Me.Productcontrol6.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol6.Size = New System.Drawing.Size(113, 97)
        Me.Productcontrol6.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 502)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.productPictureBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.IDtextbox)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.dollarcoin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dollars)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarcoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dollars As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dollarcoin As PictureBox
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents IDtextbox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents productPictureBox As PictureBox
    Friend WithEvents Productcontrol3 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
End Class
