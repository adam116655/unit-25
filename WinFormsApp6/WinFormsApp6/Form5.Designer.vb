<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(136, 69)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(136, 141)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 3
        Label2.Text = "level"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(302, 350)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 35)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(474, 59)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 30)
        Button2.TabIndex = 5
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(302, 168)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 7
        Label1.Text = "name"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 514)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
End Class
