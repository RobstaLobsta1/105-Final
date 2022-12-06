<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Student
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameFtxt = New System.Windows.Forms.TextBox()
        Me.nameLtxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.numbertxt = New System.Windows.Forms.TextBox()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.counterTxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Student Number"
        '
        'nameFtxt
        '
        Me.nameFtxt.Location = New System.Drawing.Point(110, 60)
        Me.nameFtxt.Name = "nameFtxt"
        Me.nameFtxt.Size = New System.Drawing.Size(211, 23)
        Me.nameFtxt.TabIndex = 6
        '
        'nameLtxt
        '
        Me.nameLtxt.Location = New System.Drawing.Point(110, 94)
        Me.nameLtxt.Name = "nameLtxt"
        Me.nameLtxt.Size = New System.Drawing.Size(211, 23)
        Me.nameLtxt.TabIndex = 7
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(110, 130)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(211, 23)
        Me.emailtxt.TabIndex = 8
        '
        'numbertxt
        '
        Me.numbertxt.Location = New System.Drawing.Point(110, 165)
        Me.numbertxt.Name = "numbertxt"
        Me.numbertxt.Size = New System.Drawing.Size(211, 23)
        Me.numbertxt.TabIndex = 9
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(58, 245)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(207, 34)
        Me.btnOutput.TabIndex = 10
        Me.btnOutput.Text = "Output to File"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'counterTxt
        '
        Me.counterTxt.Enabled = False
        Me.counterTxt.Location = New System.Drawing.Point(12, 12)
        Me.counterTxt.Name = "counterTxt"
        Me.counterTxt.Size = New System.Drawing.Size(186, 23)
        Me.counterTxt.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(434, 362)
        Me.DataGridView1.TabIndex = 12
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(58, 285)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(207, 34)
        Me.btnDisplay.TabIndex = 13
        Me.btnDisplay.Text = "Display Current Student Roll"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 34)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear Fields"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.counterTxt)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.numbertxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.nameLtxt)
        Me.Controls.Add(Me.nameFtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Student"
        Me.Text = "frm_Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameFtxt As TextBox
    Friend WithEvents nameLtxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents numbertxt As TextBox
    Friend WithEvents btnOutput As Button
    Friend WithEvents counterTxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Button2 As Button
End Class
