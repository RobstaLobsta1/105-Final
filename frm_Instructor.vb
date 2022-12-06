Public Class frm_Instructor

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        instNameFirsttxt.Clear()
        instNameLasttxt.Clear()
        instEmailtxt.Clear()
        instNumtxt.Clear()
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim inst As Instructor
        inst = New Instructor
        inst.nameF = instNameFirsttxt.Text
        inst.nameL = instNameLasttxt.Text
        inst.email = instEmailtxt.Text
        inst.officeNum = instNumtxt.Text

        Dim output As System.IO.StreamWriter

        Try
            output = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Robby Loeffler\source\repos\105-Final\Instructor.txt", True)
            output.WriteLine(inst.nameF & "," & inst.nameL & "," & inst.email & "," & inst.officeNum)
            output.Close()

            MessageBox.Show("Instructor Info Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred When Writing to File")
        End Try
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim read() As String = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Instructor.txt")
        Dim query = From line In read
                    Let data = line.Split(",")
                    Let nameF = data(0)
                    Let nameL = data(1)
                    Let email = data(2)
                    Let officeNum = data(3)
                    Select nameF, nameL, email, officeNum

        DataGridView1.DataSource = query.ToList
        DataGridView1.Columns("nameF").HeaderText = "First Name"
        DataGridView1.Columns("nameL").HeaderText = "Last Name"
        DataGridView1.Columns("email").HeaderText = "Email"
        DataGridView1.Columns("officeNum").HeaderText = "Office Number"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Main.Show()
        Me.Hide()
    End Sub
End Class

Class Instructor
    Public nameF As String
    Public nameL As String
    Public email As String
    Public officeNum As String
End Class