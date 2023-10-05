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
        Button1 = New Button()
        Label1 = New Label()
        PrintDialog1 = New PrintDialog()
        PrintDialog2 = New PrintDialog()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(186, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Sum"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(186, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter first number"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDialog2
        ' 
        PrintDialog2.UseEXDialog = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(391, 103)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(186, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter second number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(141, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(391, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(391, 228)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("SimSun-ExtB", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        TextBox4.Location = New Point(273, 24)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(192, 39)
        TextBox4.TabIndex = 3
        TextBox4.Text = "Procedures"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
