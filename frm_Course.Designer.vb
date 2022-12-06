<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Course
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.rmnumCoursetxt = New System.Windows.Forms.TextBox()
        Me.unitsCoursetxt = New System.Windows.Forms.TextBox()
        Me.nameCoursetxt = New System.Windows.Forms.TextBox()
        Me.numCoursetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back to Main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 34)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Clear Fields"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(58, 285)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(207, 34)
        Me.btnDisplay.TabIndex = 27
        Me.btnDisplay.Text = "Display Current Course Info"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(421, 362)
        Me.DataGridView1.TabIndex = 26
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(58, 245)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(207, 34)
        Me.btnOutput.TabIndex = 24
        Me.btnOutput.Text = "Output to File"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'rmnumCoursetxt
        '
        Me.rmnumCoursetxt.Location = New System.Drawing.Point(110, 165)
        Me.rmnumCoursetxt.Name = "rmnumCoursetxt"
        Me.rmnumCoursetxt.Size = New System.Drawing.Size(211, 23)
        Me.rmnumCoursetxt.TabIndex = 23
        '
        'unitsCoursetxt
        '
        Me.unitsCoursetxt.Location = New System.Drawing.Point(110, 130)
        Me.unitsCoursetxt.Name = "unitsCoursetxt"
        Me.unitsCoursetxt.Size = New System.Drawing.Size(211, 23)
        Me.unitsCoursetxt.TabIndex = 22
        '
        'nameCoursetxt
        '
        Me.nameCoursetxt.Location = New System.Drawing.Point(110, 94)
        Me.nameCoursetxt.Name = "nameCoursetxt"
        Me.nameCoursetxt.Size = New System.Drawing.Size(211, 23)
        Me.nameCoursetxt.TabIndex = 21
        '
        'numCoursetxt
        '
        Me.numCoursetxt.Location = New System.Drawing.Point(110, 60)
        Me.numCoursetxt.Name = "numCoursetxt"
        Me.numCoursetxt.Size = New System.Drawing.Size(211, 23)
        Me.numCoursetxt.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Units"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Course Number"
        '
        'frm_Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.rmnumCoursetxt)
        Me.Controls.Add(Me.unitsCoursetxt)
        Me.Controls.Add(Me.nameCoursetxt)
        Me.Controls.Add(Me.numCoursetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Course"
        Me.Text = "frm_Course"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnOutput As Button
    Friend WithEvents rmnumCoursetxt As TextBox
    Friend WithEvents unitsCoursetxt As TextBox
    Friend WithEvents nameCoursetxt As TextBox
    Friend WithEvents numCoursetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
