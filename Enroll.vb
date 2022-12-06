Public Class Enroll
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim master As masterEnroll
        master = New masterEnroll

        master.name = ComboBox1.SelectedItem
        master.course = ComboBox2.SelectedItem
        master.inst = ComboBox3.SelectedItem

        Dim output As System.IO.StreamWriter

        Try
            output = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Robby Loeffler\source\repos\105-Final\masterEnroll.txt", True)
            output.WriteLine(master.name & "," & master.course & "," & master.inst)
            output.Close()

            MessageBox.Show("You have been successfully enrolled")
        Catch ex As Exception
            MessageBox.Show("Error Occurred When Writing to File")
        End Try
    End Sub

    Private Sub Enroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim readS() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Student.txt")
        Dim queryS = From line In readS
                     Let data = line.Split(",")
                     Let fName = data(0)
                     Let lName = data(1)
                     Let email = data(2)
                     Let num = data(3)
                     Let info = num & "," & fName + " " & lName
                     Select info
        ComboBox1.DataSource = queryS.ToList

        Dim readC() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Course.txt")
        Dim queryC = From line In readC
                     Let data = line.Split(",")
                     Let num = data(0)
                     Let name = data(1)
                     Let units = data(2)
                     Let rmNum = data(3)
                     Let courseInfo = name + " " & num
                     Select courseInfo
        ComboBox2.DataSource = queryC.ToList

        Dim readI() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Instructor.txt")
        Dim queryI = From line In readI
                     Let data = line.Split(",")
                     Let fName = data(0)
                     Let lName = data(1)
                     Let email = data(2)
                     Let num = data(3)
                     Let info = num & "," & fName + " " & lName
                     Select info
        ComboBox3.DataSource = queryI.ToList

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim read() As String = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\masterEnroll.txt")
        Dim query = From line In read
                    Let data = line.Split(",")
                    Let idNum = data(0)
                    Let name = data(1)
                    Let course = data(2)
                    Let rmNum = data(3)
                    Let profName = data(4)
                    Select idNum, name, course, rmNum, profName

        DataGridView1.DataSource = query.ToList
        DataGridView1.Columns("idNum").HeaderText = "ID Number"
        DataGridView1.Columns("name").HeaderText = "Name"
        DataGridView1.Columns("course").HeaderText = "Course"
        DataGridView1.Columns("profName").HeaderText = "Instructor Name"
        DataGridView1.Columns("rmNum").HeaderText = "Room Number"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim readS() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Student.txt")
        Dim queryS = From line In readS
                     Let data = line.Split(",")
                     Let fName = data(0)
                     Let lName = data(1)
                     Let email = data(2)
                     Let num = data(3)
                     Let info = num & "," & fName + " " & lName
                     Select info
        ComboBox1.DataSource = queryS.ToList

        Dim readC() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Course.txt")
        Dim queryC = From line In readC
                     Let data = line.Split(",")
                     Let num = data(0)
                     Let name = data(1)
                     Let units = data(2)
                     Let rmNum = data(3)
                     Let courseInfo = name + " " & num
                     Select courseInfo
        ComboBox2.DataSource = queryC.ToList

        Dim readI() = IO.File.ReadAllLines("C:\Users\Robby Loeffler\source\repos\105-Final\Instructor.txt")
        Dim queryI = From line In readI
                     Let data = line.Split(",")
                     Let fName = data(0)
                     Let lName = data(1)
                     Let email = data(2)
                     Let num = data(3)
                     Let info = num & "," & fName + " " & lName
                     Select info
        ComboBox3.DataSource = queryI.ToList
    End Sub
End Class

Class masterEnroll
    Public name As String
    Public course As String
    Public inst As String
End Class