Public Class frm_Course
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numCoursetxt.Clear()
        nameCoursetxt.Clear()
        unitsCoursetxt.Clear()
        rmnumCoursetxt.Clear()
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        Dim cour As Course
        cour = New Course
        cour.number = numCoursetxt.Text
        cour.name = nameCoursetxt.Text
        cour.units = unitsCoursetxt.Text
        cour.roomNum = rmnumCoursetxt.Text

        Dim output As System.IO.StreamWriter

        Try
            output = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Robby Loeffler\source\repos\105-Final\Course.txt", True)
            output.WriteLine(cour.number & "," & cour.name & "," & cour.units & "," & cour.roomNum)
            output.Close()

            MessageBox.Show("Course Info Written Successfully")
        Catch ex As Exception
            MessageBox.Show("Error Occurred When Writing to File")
        End Try
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim read() As String = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Course.txt")
        Dim query = From line In read
                    Let data = line.Split(",")
                    Let num = data(0)
                    Let name = data(1)
                    Let units = data(2)
                    Let rmNum = data(3)
                    Select num, name, units, rmNum

        DataGridView1.DataSource = query.ToList
        DataGridView1.Columns("num").HeaderText = "Course Number"
        DataGridView1.Columns("name").HeaderText = "Course Name"
        DataGridView1.Columns("units").HeaderText = "# of Units"
        DataGridView1.Columns("rmNum").HeaderText = "Room Number"
    End Sub
End Class

Class Course
    Public name As String
    Public number As String
    Public units As String
    Public roomNum As String
End Class