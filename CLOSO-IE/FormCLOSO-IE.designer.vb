<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInstructorStudentWorkSample
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInstructorStudentWorkSample))
        Me.ButtonViewImageFolder = New System.Windows.Forms.Button()
        Me.DataGridViewImageList = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonExtractImages = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButtonDeleteOldFiles = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAppendAtRow = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAppendAtEnd = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxAppendOverwrite = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RadioButtonActualSize = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFitToPage = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonA4 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLetter = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxPicture = New System.Windows.Forms.GroupBox()
        Me.LabelNoImageToDisplay = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAppendOverwrite.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBoxPicture.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonViewImageFolder
        '
        Me.ButtonViewImageFolder.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonViewImageFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonViewImageFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonViewImageFolder.Location = New System.Drawing.Point(87, 801)
        Me.ButtonViewImageFolder.Name = "ButtonViewImageFolder"
        Me.ButtonViewImageFolder.Size = New System.Drawing.Size(107, 25)
        Me.ButtonViewImageFolder.TabIndex = 2
        Me.ButtonViewImageFolder.Text = "View Image Folder"
        Me.ButtonViewImageFolder.UseVisualStyleBackColor = False
        '
        'DataGridViewImageList
        '
        Me.DataGridViewImageList.AllowUserToAddRows = False
        Me.DataGridViewImageList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageList.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewImageList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewImageList.Location = New System.Drawing.Point(312, 0)
        Me.DataGridViewImageList.Name = "DataGridViewImageList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageList.Size = New System.Drawing.Size(300, 880)
        Me.DataGridViewImageList.TabIndex = 5
        Me.DataGridViewImageList.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(24, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 784)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ButtonExtractImages
        '
        Me.ButtonExtractImages.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonExtractImages.Location = New System.Drawing.Point(87, 756)
        Me.ButtonExtractImages.Name = "ButtonExtractImages"
        Me.ButtonExtractImages.Size = New System.Drawing.Size(107, 25)
        Me.ButtonExtractImages.TabIndex = 1
        Me.ButtonExtractImages.Text = "Extract"
        Me.ToolTip1.SetToolTip(Me.ButtonExtractImages, "Images will be extracted from user-specified PDF file.")
        Me.ButtonExtractImages.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonExit.Location = New System.Drawing.Point(87, 846)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(107, 25)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ButtonExit, "Save and exit. To cancel, exit and then close without saving.")
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'RadioButtonDeleteOldFiles
        '
        Me.RadioButtonDeleteOldFiles.AutoSize = True
        Me.RadioButtonDeleteOldFiles.Location = New System.Drawing.Point(16, 61)
        Me.RadioButtonDeleteOldFiles.Name = "RadioButtonDeleteOldFiles"
        Me.RadioButtonDeleteOldFiles.Size = New System.Drawing.Size(150, 29)
        Me.RadioButtonDeleteOldFiles.TabIndex = 2
        Me.RadioButtonDeleteOldFiles.Text = "Replace all"
        Me.ToolTip1.SetToolTip(Me.RadioButtonDeleteOldFiles, "All image files in the above list will be deleted and new files will be added.")
        Me.RadioButtonDeleteOldFiles.UseVisualStyleBackColor = False
        '
        'RadioButtonAppendAtRow
        '
        Me.RadioButtonAppendAtRow.AutoSize = True
        Me.RadioButtonAppendAtRow.Location = New System.Drawing.Point(16, 90)
        Me.RadioButtonAppendAtRow.Name = "RadioButtonAppendAtRow"
        Me.RadioButtonAppendAtRow.Size = New System.Drawing.Size(309, 29)
        Me.RadioButtonAppendAtRow.TabIndex = 2
        Me.RadioButtonAppendAtRow.Text = "Overwrite from selected row"
        Me.ToolTip1.SetToolTip(Me.RadioButtonAppendAtRow, "Image files starting from the selected row in the above table will be overwritten" &
        " by image files extracted from a PDF.")
        Me.RadioButtonAppendAtRow.UseVisualStyleBackColor = True
        '
        'RadioButtonAppendAtEnd
        '
        Me.RadioButtonAppendAtEnd.AutoSize = True
        Me.RadioButtonAppendAtEnd.Checked = True
        Me.RadioButtonAppendAtEnd.Location = New System.Drawing.Point(16, 32)
        Me.RadioButtonAppendAtEnd.Name = "RadioButtonAppendAtEnd"
        Me.RadioButtonAppendAtEnd.Size = New System.Drawing.Size(117, 29)
        Me.RadioButtonAppendAtEnd.TabIndex = 2
        Me.RadioButtonAppendAtEnd.TabStop = True
        Me.RadioButtonAppendAtEnd.Text = "Append"
        Me.ToolTip1.SetToolTip(Me.RadioButtonAppendAtEnd, "Images will be appended  to the list of existing images in the above table. ")
        Me.RadioButtonAppendAtEnd.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(184, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Double-click to hide me.")
        Me.PictureBox2.Visible = False
        '
        'GroupBoxAppendOverwrite
        '
        Me.GroupBoxAppendOverwrite.Controls.Add(Me.RadioButtonDeleteOldFiles)
        Me.GroupBoxAppendOverwrite.Controls.Add(Me.RadioButtonAppendAtRow)
        Me.GroupBoxAppendOverwrite.Controls.Add(Me.RadioButtonAppendAtEnd)
        Me.GroupBoxAppendOverwrite.Location = New System.Drawing.Point(48, 556)
        Me.GroupBoxAppendOverwrite.Name = "GroupBoxAppendOverwrite"
        Me.GroupBoxAppendOverwrite.Size = New System.Drawing.Size(184, 112)
        Me.GroupBoxAppendOverwrite.TabIndex = 22
        Me.GroupBoxAppendOverwrite.TabStop = False
        Me.GroupBoxAppendOverwrite.Text = "Extract Options"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RadioButtonActualSize
        '
        Me.RadioButtonActualSize.AutoSize = True
        Me.RadioButtonActualSize.Location = New System.Drawing.Point(16, 72)
        Me.RadioButtonActualSize.Name = "RadioButtonActualSize"
        Me.RadioButtonActualSize.Size = New System.Drawing.Size(157, 29)
        Me.RadioButtonActualSize.TabIndex = 23
        Me.RadioButtonActualSize.Text = "Actual Size "
        Me.RadioButtonActualSize.UseVisualStyleBackColor = True
        '
        'RadioButtonFitToPage
        '
        Me.RadioButtonFitToPage.AutoSize = True
        Me.RadioButtonFitToPage.Checked = True
        Me.RadioButtonFitToPage.Location = New System.Drawing.Point(16, 32)
        Me.RadioButtonFitToPage.Name = "RadioButtonFitToPage"
        Me.RadioButtonFitToPage.Size = New System.Drawing.Size(147, 29)
        Me.RadioButtonFitToPage.TabIndex = 23
        Me.RadioButtonFitToPage.TabStop = True
        Me.RadioButtonFitToPage.Text = "Fit to Page"
        Me.RadioButtonFitToPage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonActualSize)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFitToPage)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 112)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Options"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 711)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open CLOSO File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonA4)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLetter)
        Me.GroupBox2.Location = New System.Drawing.Point(48, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 112)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paper Aspect Ratio"
        '
        'RadioButtonA4
        '
        Me.RadioButtonA4.AutoSize = True
        Me.RadioButtonA4.Location = New System.Drawing.Point(16, 72)
        Me.RadioButtonA4.Name = "RadioButtonA4"
        Me.RadioButtonA4.Size = New System.Drawing.Size(69, 29)
        Me.RadioButtonA4.TabIndex = 23
        Me.RadioButtonA4.Text = "A4"
        Me.RadioButtonA4.UseVisualStyleBackColor = True
        '
        'RadioButtonLetter
        '
        Me.RadioButtonLetter.AutoSize = True
        Me.RadioButtonLetter.Checked = True
        Me.RadioButtonLetter.Location = New System.Drawing.Point(16, 32)
        Me.RadioButtonLetter.Name = "RadioButtonLetter"
        Me.RadioButtonLetter.Size = New System.Drawing.Size(98, 29)
        Me.RadioButtonLetter.TabIndex = 23
        Me.RadioButtonLetter.TabStop = True
        Me.RadioButtonLetter.Text = "Letter"
        Me.RadioButtonLetter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 888)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1144, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "CLOSO File:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(8, 920)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1144, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Image Folder:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBoxPicture
        '
        Me.GroupBoxPicture.BackColor = System.Drawing.Color.White
        Me.GroupBoxPicture.Controls.Add(Me.LabelNoImageToDisplay)
        Me.GroupBoxPicture.Controls.Add(Me.PictureBox1)
        Me.GroupBoxPicture.Location = New System.Drawing.Point(688, 16)
        Me.GroupBoxPicture.Name = "GroupBoxPicture"
        Me.GroupBoxPicture.Size = New System.Drawing.Size(496, 864)
        Me.GroupBoxPicture.TabIndex = 28
        Me.GroupBoxPicture.TabStop = False
        Me.GroupBoxPicture.Text = "Selected Image Display"
        '
        'LabelNoImageToDisplay
        '
        Me.LabelNoImageToDisplay.Location = New System.Drawing.Point(48, 256)
        Me.LabelNoImageToDisplay.Name = "LabelNoImageToDisplay"
        Me.LabelNoImageToDisplay.Size = New System.Drawing.Size(400, 40)
        Me.LabelNoImageToDisplay.TabIndex = 7
        Me.LabelNoImageToDisplay.Text = "No image to display"
        Me.LabelNoImageToDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(112, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 48)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormInstructorStudentWorkSample
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1800, 1478)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxPicture)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonExtractImages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonViewImageFolder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewImageList)
        Me.Controls.Add(Me.GroupBoxAppendOverwrite)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInstructorStudentWorkSample"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridViewImageList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAppendOverwrite.ResumeLayout(False)
        Me.GroupBoxAppendOverwrite.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBoxPicture.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonViewImageFolder As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageList As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonExtractImages As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBoxAppendOverwrite As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDeleteOldFiles As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAppendAtRow As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAppendAtEnd As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RadioButtonActualSize As RadioButton
    Friend WithEvents RadioButtonFitToPage As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonA4 As RadioButton
    Friend WithEvents RadioButtonLetter As RadioButton
    Friend WithEvents GroupBoxPicture As GroupBox
    Friend WithEvents LabelNoImageToDisplay As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents pictureBoxLicenseInfo As PictureBox
    Friend WithEvents Button2 As Button
End Class
