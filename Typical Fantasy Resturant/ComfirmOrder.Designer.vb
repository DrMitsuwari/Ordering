<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComfirmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PayPrice = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Pay = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PayPrice
        '
        Me.PayPrice.BackColor = System.Drawing.Color.White
        Me.PayPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PayPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.PayPrice.Font = New System.Drawing.Font("Poor Richard", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayPrice.Location = New System.Drawing.Point(0, 0)
        Me.PayPrice.Name = "PayPrice"
        Me.PayPrice.ReadOnly = True
        Me.PayPrice.Size = New System.Drawing.Size(326, 80)
        Me.PayPrice.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Font = New System.Drawing.Font("Poor Richard", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 80)
        Me.TextBox1.TabIndex = 1
        '
        'Pay
        '
        Me.Pay.BackgroundImage = Global.Typical_Fantasy_Resturant.My.Resources.Resources.Wood
        Me.Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pay.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pay.Location = New System.Drawing.Point(54, 308)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(284, 51)
        Me.Pay.TabIndex = 2
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PayPrice)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(24, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 260)
        Me.Panel1.TabIndex = 3
        '
        'ComfirmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Typical_Fantasy_Resturant.My.Resources.Resources.MainBackground
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ComfirmOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PayPrice As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Pay As Button
    Friend WithEvents Panel1 As Panel
End Class
