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
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckedListBox1 = New CheckedListBox()
        CheckedListBox2 = New CheckedListBox()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(392, 45)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(106, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(106, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(361, 214)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(179, 112)
        CheckedListBox1.TabIndex = 3
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Location = New Point(182, 214)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.Size = New Size(147, 112)
        CheckedListBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(254, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 40)
        Button1.TabIndex = 5
        Button1.Text = "create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(403, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 40)
        Button2.TabIndex = 6
        Button2.Text = "main"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 7
        Label1.Text = "name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 8
        Label2.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(332, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 9
        Label3.Text = "level"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CheckedListBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
