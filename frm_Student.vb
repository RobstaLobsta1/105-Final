Imports System.IO
Public Class frm_Student
    Dim counter = File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Student.txt").Length
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        If counter < 20 Then
            Dim stu As Student
            stu = New Student
            stu.nameFirst = nameFtxt.Text
            stu.nameLast = nameLtxt.Text
            stu.email = emailtxt.Text
            stu.num = numbertxt.Text

            Dim output As System.IO.StreamWriter

            Try
                output = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Robby Loeffler\source\repos\105-Final\Student.txt", True)
                output.WriteLine(stu.nameFirst & "," & stu.nameLast & "," & stu.email & "," & stu.num)
                output.Close()
                counter += 1
                counterTxt.Text = ("Students created : " & counter & " out of 20")
                MessageBox.Show("Student Info Written Successfully")
            Catch ex As Exception
                MessageBox.Show("Error Occurred When Writing to File")
            End Try
        Else
            MessageBox.Show("Maximum Number of Students Reached")
        End If
    End Sub

    Private Sub frm_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counterTxt.Text = ("Students created : " & counter & " out of 20")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim read() As String = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Student.txt")
        Dim query = From line In read
                    Let data = line.Split(",")
                    Let fName = data(0)
                    Let lName = data(1)
                    Let email = data(2)
                    Let num = data(3)
                    Select fName, lName, email, num

        DataGridView1.DataSource = query.ToList
        DataGridView1.Columns("fName").HeaderText = "First Name"
        DataGridView1.Columns("lName").HeaderText = "Last Name"
        DataGridView1.Columns("email").HeaderText = "Email Address"
        DataGridView1.Columns("num").HeaderText = "Student Number"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        nameFtxt.Clear()
        nameLtxt.Clear()
        emailtxt.Clear()
        numbertxt.Clear()
    End Sub
End Class

Class Student
    Public nameFirst As String
    Public nameLast As String
    Public email As String
    Public num As String
End Class