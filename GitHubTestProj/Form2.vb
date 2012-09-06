Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GroupBox1.Height = 20 Then
            GroupBox1.Height = 200
        Else
            GroupBox1.Height = 20
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GroupBox2.Height = 20 Then
            GroupBox2.Height = 200
        Else
            GroupBox2.Height = 20
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If GroupBox3.Height <= 20 Then
            GroupBox3.Height = 200
        Else
            GroupBox3.Height = 20
        End If
    End Sub
End Class