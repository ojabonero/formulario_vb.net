Imports System.Drawing.Text

Public Class Form1

    Dim fontSize As Integer = 12

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Font = New Font("Comic Sans MS", fontSize, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Font = New Font("Tahoma", fontSize, TextBox1.Font.Style)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Font = New Font("Verdana", fontSize, TextBox1.Font.Style)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleccion As Integer

        seleccion = ComboBox1.SelectedItem
        Select Case (seleccion)
            Case (8)
                fontSize = 8
            Case (9)
                fontSize = 9
            Case (10)
                fontSize = 10
            Case (11)
                fontSize = 11
            Case (12)
                fontSize = 12
            Case (14)
                fontSize = 14
            Case (16)
                fontSize = 16
            Case (18)
                fontSize = 18
            Case (20)
                fontSize = 20
            Case (22)
                fontSize = 22
            Case (24)
                fontSize = 24
            Case (26)
                fontSize = 26
            Case (28)
                fontSize = 28
            Case (36)
                fontSize = 36
            Case (48)
                fontSize = 48

        End Select

        TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style Or FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style Or FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style Or FontStyle.Underline)
        Else
            TextBox1.Font = New Font(TextBox1.Text, fontSize, TextBox1.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
