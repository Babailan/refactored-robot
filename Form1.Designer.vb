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
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        OrderBtn = New Button()
        Button2 = New Button()
        Button3 = New Button()
        OrderPlace = New TextBox()
        Label1 = New Label()
        price = New Label()
        Label2 = New Label()
        Cash = New TextBox()
        Payment = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"HATDOG 32", "SPICY 55", "KANTON 66"})
        ListBox1.Location = New Point(28, 55)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 94)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(595, 55)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(129, 139)
        ListBox2.TabIndex = 0
        ' 
        ' OrderBtn
        ' 
        OrderBtn.Location = New Point(405, 167)
        OrderBtn.Name = "OrderBtn"
        OrderBtn.Size = New Size(93, 38)
        OrderBtn.TabIndex = 1
        OrderBtn.Text = "Order"
        OrderBtn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(405, 215)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 38)
        Button2.TabIndex = 2
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(405, 259)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 39)
        Button3.TabIndex = 3
        Button3.Text = "Cancel Order"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' OrderPlace
        ' 
        OrderPlace.BackColor = SystemColors.ButtonFace
        OrderPlace.Location = New Point(297, 82)
        OrderPlace.Name = "OrderPlace"
        OrderPlace.ReadOnly = True
        OrderPlace.Size = New Size(139, 23)
        OrderPlace.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(528, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 5
        Label1.Text = "TOTAL COST"
        ' 
        ' price
        ' 
        price.AutoSize = True
        price.Location = New Point(605, 238)
        price.Name = "price"
        price.Size = New Size(13, 15)
        price.TabIndex = 6
        price.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(297, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 7
        Label2.Text = "Place Order:"
        ' 
        ' Cash
        ' 
        Cash.Location = New Point(605, 259)
        Cash.Name = "Cash"
        Cash.Size = New Size(100, 23)
        Cash.TabIndex = 8
        ' 
        ' Payment
        ' 
        Payment.Location = New Point(605, 302)
        Payment.Name = "Payment"
        Payment.Size = New Size(100, 23)
        Payment.TabIndex = 9
        Payment.Text = "Payment"
        Payment.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(566, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 10
        Label3.Text = "Cash"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Payment)
        Controls.Add(Cash)
        Controls.Add(Label2)
        Controls.Add(price)
        Controls.Add(Label1)
        Controls.Add(OrderPlace)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(OrderBtn)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents OrderBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OrderPlace As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cash As TextBox
    Friend WithEvents Payment As Button
    Friend WithEvents Label3 As Label
End Class
