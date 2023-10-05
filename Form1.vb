Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber, secondNumber As Integer

        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)
        sum(firstNumber, secondNumber)
    End Sub
    Sub sum(a As Integer, b As Integer)
        Dim total As Integer

        total = a + b

        TextBox3.Text = total
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.BlanchedAlmond
    End Sub
End Class
