Public Class frm_Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Course.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_Student.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_Instructor.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Enroll.Show()
        Me.Hide()
    End Sub
End Class