<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Instructor
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.instNumtxt = New System.Windows.Forms.TextBox()
        Me.instEmailtxt = New System.Windows.Forms.TextBox()
        Me.instNameLasttxt = New System.Windows.Forms.TextBox()
        Me.instNameFirsttxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 34)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Clear Fields"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(60, 283)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(207, 34)
        Me.btnDisplay.TabIndex = 40
        Me.btnDisplay.Text = "Display Current Instructor Roll"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(329, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(421, 362)
        Me.DataGridView1.TabIndex = 39
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(60, 243)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(207, 34)
        Me.btnOutput.TabIndex = 38
        Me.btnOutput.Text = "Output to File"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'instNumtxt
        '
        Me.instNumtxt.Location = New System.Drawing.Point(112, 163)
        Me.instNumtxt.Name = "instNumtxt"
        Me.instNumtxt.Size = New System.Drawing.Size(211, 23)
        Me.instNumtxt.TabIndex = 37
        '
        'instEmailtxt
        '
        Me.instEmailtxt.Location = New System.Drawing.Point(112, 128)
        Me.instEmailtxt.Name = "instEmailtxt"
        Me.instEmailtxt.Size = New System.Drawing.Size(211, 23)
        Me.instEmailtxt.TabIndex = 36
        '
        'instNameLasttxt
        '
        Me.instNameLasttxt.Location = New System.Drawing.Point(112, 92)
        Me.instNameLasttxt.Name = "instNameLasttxt"
        Me.instNameLasttxt.Size = New System.Drawing.Size(211, 23)
        Me.instNameLasttxt.TabIndex = 35
        '
        'instNameFirsttxt
        '
        Me.instNameFirsttxt.Location = New System.Drawing.Point(112, 58)
        Me.instNameFirsttxt.Name = "instNameFirsttxt"
        Me.instNameFirsttxt.Size = New System.Drawing.Size(211, 23)
        Me.instNameFirsttxt.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Office Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "First Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 43)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Back to Main"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Instructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.instNumtxt)
        Me.Controls.Add(Me.instEmailtxt)
        Me.Controls.Add(Me.instNameLasttxt)
        Me.Controls.Add(Me.instNameFirsttxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Instructor"
        Me.Text = "frm_Instructor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnOutput As Button
    Friend WithEvents instNumtxt As TextBox
    Friend WithEvents instEmailtxt As TextBox
    Friend WithEvents instNameLasttxt As TextBox
    Friend WithEvents instNameFirsttxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
