﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckedListBox1 = New CheckedListBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(173, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(173, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(231, 201)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(211, 94)
        CheckedListBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 3
        Label1.Text = "name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 15)
        Label2.TabIndex = 4
        Label2.Text = "ID"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(397, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 38)
        Button1.TabIndex = 5
        Button1.Text = "main menu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(221, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 38)
        Button2.TabIndex = 6
        Button2.Text = "Create"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckedListBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
