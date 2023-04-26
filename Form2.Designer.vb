<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        UserName = New TextBox()
        Password = New TextBox()
        Login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' UserName
        ' 
        UserName.Location = New Point(202, 145)
        UserName.Name = "UserName"
        UserName.Size = New Size(100, 23)
        UserName.TabIndex = 0
        ' 
        ' Password
        ' 
        Password.Location = New Point(202, 209)
        Password.Name = "Password"
        Password.Size = New Size(100, 23)
        Password.TabIndex = 1
        ' 
        ' Login
        ' 
        Login.Location = New Point(202, 252)
        Login.Name = "Login"
        Login.Size = New Size(100, 40)
        Login.TabIndex = 2
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Login)
        Controls.Add(Password)
        Controls.Add(UserName)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserName As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
