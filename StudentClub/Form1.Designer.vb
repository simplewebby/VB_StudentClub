<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstGeneralStudentList = New System.Windows.Forms.ListBox()
        Me.lstClubMembershipList = New System.Windows.Forms.ListBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnRemoveSelStudent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGeneralStudentList
        '
        Me.lstGeneralStudentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstGeneralStudentList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGeneralStudentList.ForeColor = System.Drawing.Color.Blue
        Me.lstGeneralStudentList.FormattingEnabled = True
        Me.lstGeneralStudentList.ItemHeight = 18
        Me.lstGeneralStudentList.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Johnson, Eric", "Koenig, Johann", "Matsunaga, Akiko", "Nakamura, Ken", "Ramirez, Maria", "Garyaeva, Tsagan"})
        Me.lstGeneralStudentList.Location = New System.Drawing.Point(37, 108)
        Me.lstGeneralStudentList.Name = "lstGeneralStudentList"
        Me.lstGeneralStudentList.Size = New System.Drawing.Size(232, 236)
        Me.lstGeneralStudentList.TabIndex = 0
        '
        'lstClubMembershipList
        '
        Me.lstClubMembershipList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstClubMembershipList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClubMembershipList.ForeColor = System.Drawing.Color.Blue
        Me.lstClubMembershipList.FormattingEnabled = True
        Me.lstClubMembershipList.ItemHeight = 18
        Me.lstClubMembershipList.Location = New System.Drawing.Point(291, 108)
        Me.lstClubMembershipList.Name = "lstClubMembershipList"
        Me.lstClubMembershipList.Size = New System.Drawing.Size(232, 200)
        Me.lstClubMembershipList.TabIndex = 1
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.Blue
        Me.btnAddStudent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddStudent.Location = New System.Drawing.Point(37, 364)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(232, 37)
        Me.btnAddStudent.TabIndex = 2
        Me.btnAddStudent.Text = "Add selected student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnRemoveSelStudent
        '
        Me.btnRemoveSelStudent.BackColor = System.Drawing.Color.Blue
        Me.btnRemoveSelStudent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelStudent.ForeColor = System.Drawing.Color.White
        Me.btnRemoveSelStudent.Location = New System.Drawing.Point(294, 364)
        Me.btnRemoveSelStudent.Name = "btnRemoveSelStudent"
        Me.btnRemoveSelStudent.Size = New System.Drawing.Size(229, 37)
        Me.btnRemoveSelStudent.TabIndex = 3
        Me.btnRemoveSelStudent.Text = "Remove selected student"
        Me.btnRemoveSelStudent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "General Student List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(291, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Club Membership List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.White
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.Blue
        Me.lblText.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblText.Location = New System.Drawing.Point(291, 315)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(232, 29)
        Me.lblText.TabIndex = 6
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label3.Location = New System.Drawing.Point(40, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(483, 59)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 447)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveSelStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lstClubMembershipList)
        Me.Controls.Add(Me.lstGeneralStudentList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Adding Students To a Club"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstGeneralStudentList As ListBox
    Friend WithEvents lstClubMembershipList As ListBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnRemoveSelStudent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblText As Label
    Friend WithEvents Label3 As Label
End Class
