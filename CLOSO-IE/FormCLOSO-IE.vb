
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Ghostscript.NET
Imports Ghostscript.NET.Rasterizer
'//
'// Application name: CLOSO-IE (CLOSO Image Extractor)
'// It has been written to help CLOSO software users to extract the images from a PDF file of students' work samples
'// CLOSO software (a a propreietery software of smart-accredit.com) is used by Academic programs to produce course folders and SSR data for  ABET accreditation
'// This extractor is a seperate software not linked to CLOSO in anayway and is distributed under AGPL license.
'// It uses the GhostScript wrapper written by: Josip Habjan(habjan@gmail.com) 
'// CLOSO-IE Copyright (c) 2016-2017 by smart-accredit.com. All rights reserved.
'//

'    CLOSO-IE is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU Affero General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU Affero General Public License For more details.

'    You should have received a copy Of the GNU Affero General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.
'    Author of this software can be contacted at sales@smart-accredit.com
'    The entire source code is available at https://github.com/smart-accredit/CLOSO-IE. 


'// Permission is hereby granted, free of charge, to any person obtaining
'// a copy of this software and associated documentation files (the
'// "Software"), to deal in the Software without restriction, including
'// without limitation the rights to use, copy, modify, merge, publish,
'// distribute, sublicense, And/Or sell copies of the Software, And to
'// permit persons to whom the Software is furnished to do so, subject to
'// the following conditions:
'//
'// The above copyright notice And this permission notice shall be
'// included in all copies or substantial portions of the Software.
'//
'// THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
'// EXPRESS Or IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES OF
'// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE And
'// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS Or COPYRIGHT HOLDERS BE
'// LIABLE FOR ANY CLAIM, DAMAGES Or OTHER LIABILITY, WHETHER IN AN ACTION
'// OF CONTRACT, TORT Or OTHERWISE, ARISING FROM, OUT OF Or IN CONNECTION
'// WITH THE SOFTWARE Or THE USE Or OTHER DEALINGS IN THE SOFTWARE.

Public Class FormInstructorStudentWorkSample
    Private CLOSOFN As String
    Private FullFileNameWithPath As String
    Private UserScreenWidth As Integer
    Private UserScreenHeight As Integer
    Private CLOSOImageFolderNameWithPath As String = " "
    Private NFileNamesofScannedImages As Integer
    Private filePDF As String = " "
    Private NStartPDF As Integer
    Private FileNamesOfScannedImagesWithSeperatorPages(9999)

    Private Sub FormInstructorStudentWorkSample_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim PreviousDataIsOK As Boolean = True

        UserScreenWidth = Screen.PrimaryScreen.WorkingArea.Width
        UserScreenHeight = Screen.PrimaryScreen.WorkingArea.Height
        SetControlPositions()
        Me.Text = "CLOSO-IE (CLOSO Image Extractor) to help CLOSO users - a free/open source software under GNU Affero General Public License. Full text of license available at: https://www.gnu.org/licenses/"
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub GetCLOSOFileName()

        OpenFileDialog1.Filter = "CLOSO Input File(*.CLOSO) |*.CLOSO"
        Dim dlgResult As DialogResult
        dlgResult = OpenFileDialog1.ShowDialog
        If dlgResult = DialogResult.Cancel Then Exit Sub
        CLOSOFN = OpenFileDialog1.FileName
        Dim t As String = System.IO.Path.GetExtension(CLOSOFN)
        If t <> ".CLOSO" Then
            MsgBox("Wrong type of file selected.")
            Exit Sub
        End If
    End Sub
    Private Sub SetControlPositions()
        Dim L As Integer = 0
        Dim KK As Integer = 0
        Dim ColIndex As Integer = 0
        Dim ScrollBarSpace As Integer = 30
        Dim P As Point
        Me.Width = UserScreenWidth
        Me.Height = UserScreenHeight
        Label1.Height = ButtonExtractImages.Height
        Label2.Height = ButtonExtractImages.Height


        P.Y = 5
        P.X = 5 + GroupBox2.Width + 10
        DataGridViewImageList.Location = P
        DataGridViewImageList.Height = UserScreenHeight - 3 * ScrollBarSpace - Label1.Height - Label2.Height
        DataGridViewImageList.ColumnCount = 1
        DataGridViewImageList.TopLeftHeaderCell.Value = "Image ID"
        DataGridViewImageList.Columns(0).Name = "Image File"

        DataGridViewImageList.RowHeadersWidth = 55
        DataGridViewImageList.Columns(0).Width = 200
        DataGridViewImageList.Width = DataGridViewImageList.RowHeadersWidth + DataGridViewImageList.Columns(0).Width + ScrollBarSpace
        Dim S1 As String
        Dim RH As Integer = 20
        Dim NN As Integer = (DataGridViewImageList.Height - DataGridViewImageList.ColumnHeadersHeight) / RH
        DataGridViewImageList.Height = NN * RH + DataGridViewImageList.ColumnHeadersHeight + 5
        DataGridViewImageList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewImageList.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewImageList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        For I = 1 To 99
            DataGridViewImageList.Rows.Add()
            DataGridViewImageList.Rows(I - 1).Height = RH
            DataGridViewImageList.Item(0, I - 1).Value = "Image not extracted"
            S1 = Str(I)
            S1 = S1.Trim
            DataGridViewImageList.Rows(I - 1).HeaderCell.Value = S1
        Next
        P.X = DataGridViewImageList.Location.X + DataGridViewImageList.Width + 10
        P.Y = DataGridViewImageList.Location.Y
        GroupBoxPicture.Location = P
        GroupBoxPicture.Height = DataGridViewImageList.Height
        GroupBoxPicture.Width = DataGridViewImageList.Height * 216 / 280
        If GroupBoxPicture.Width > Me.Width - PictureBox1.Location.X - ScrollBarSpace Then
            GroupBoxPicture.Width = Me.Width - PictureBox1.Location.X - ScrollBarSpace
        End If

        PictureBox1.Height = DataGridViewImageList.Height - 50
        If RadioButtonA4.Checked Then
            PictureBox1.Width = PictureBox1.Height * 210 / 297
        Else
            PictureBox1.Width = PictureBox1.Height * 216 / 280
        End If

        P.X = (GroupBoxPicture.Width - PictureBox1.Width) / 2
        P.Y = (GroupBoxPicture.Height - PictureBox1.Height) / 2
        PictureBox1.Location = P


        Label1.Left = 5
        Label2.Left = 5
        Label1.Width = DataGridViewImageList.Left + DataGridViewImageList.Width + 10 + GroupBoxPicture.Width - 5
        Label2.Width = Label1.Width
        Label1.Top = DataGridViewImageList.Top + DataGridViewImageList.Height + 5
        Label2.Top = DataGridViewImageList.Top + DataGridViewImageList.Height + Label1.Height + 5

        Dim SP As Integer = (DataGridViewImageList.Height - (ButtonExit.Height + ButtonViewImageFolder.Height + ButtonExtractImages.Height + Button1.Height _
            + GroupBoxAppendOverwrite.Height + GroupBox1.Height + GroupBox2.Height + Button2.Height)) / 10
        If SP > 30 Then SP = 30

        P.X = (5 + GroupBox2.Width) / 2 - ButtonExit.Width / 2
        P.Y = DataGridViewImageList.Bottom - ButtonExit.Height
        ButtonExit.Location = P

        P.Y = ButtonExit.Location.Y - SP - ButtonViewImageFolder.Height
        ButtonViewImageFolder.Location = P

        P.Y = ButtonViewImageFolder.Location.Y - SP - ButtonExtractImages.Height
        ButtonExtractImages.Location = P

        P.Y = ButtonExtractImages.Location.Y - SP - Button1.Height
        Button1.Location = P

        P.X = 5

        P.Y = Button1.Location.Y - SP - GroupBoxAppendOverwrite.Height
        GroupBoxAppendOverwrite.Location = P

        P.Y = GroupBoxAppendOverwrite.Location.Y - SP - GroupBox1.Height
        GroupBox1.Location = P

        P.Y = GroupBox1.Location.Y - SP - GroupBox2.Height
        GroupBox2.Location = P

        LabelNoImageToDisplay.Left = PictureBox1.Left
        LabelNoImageToDisplay.Width = PictureBox1.Width
        LabelNoImageToDisplay.Top = PictureBox1.Top + PictureBox1.Height / 2
        LabelNoImageToDisplay.Visible = True



        Label1.Text = "CLOSO File: Not specified"
        Label2.Text = "Image Folder: Not specified"

        Button2.Top = GroupBox2.Top - SP - Button2.Height
        Button2.Left = ButtonExit.Left + ButtonExit.Width / 2 - Button2.Width / 2

        DataGridViewImageList.Visible = True
        Me.Width = Label2.Width + 2 * ScrollBarSpace
        Me.Height = Label2.Top + Label2.Height + 2 * ScrollBarSpace

    End Sub
    Private Sub DisplayScannedImageDataTable1() 'called by ButtonExtractImages.click and form.load
        Dim L As Integer
        Dim NN As Integer
        '--------------------------
        If Not Directory.Exists(CLOSOImageFolderNameWithPath) Then Exit Sub
        NFileNamesofScannedImages = Directory.GetFiles(CLOSOImageFolderNameWithPath, "*.*").Count
        If NFileNamesofScannedImages <= 0 Then Exit Sub
        Dim s As String() = System.IO.Directory.GetFiles(CLOSOImageFolderNameWithPath)
        NN = DataGridViewImageList.RowCount
        For i = NN To 1 Step -1
            DataGridViewImageList.Rows.RemoveAt(DataGridViewImageList.RowCount - 1)
        Next
        For i = 1 To NFileNamesofScannedImages
            DataGridViewImageList.Rows.Add()
        Next
        Dim S1 As String
        L = 0
        For Each t In s
            L = L + 1
            FileNamesOfScannedImagesWithSeperatorPages(L) = System.IO.Path.GetFileName(t)
            DataGridViewImageList.Item(0, L - 1).Value = FileNamesOfScannedImagesWithSeperatorPages(L)
            S1 = Str(L)
            S1 = S1.Trim

            DataGridViewImageList.Rows(L - 1).HeaderCell.Value = S1
        Next t
        '----------------------
        PictureBox1.Visible = True
        DataGridViewImageList.Visible = True
        FullFileNameWithPath = CLOSOImageFolderNameWithPath & "\" & FileNamesOfScannedImagesWithSeperatorPages(1)
        Try
            LoadPictureBoxUsingFileStream(FullFileNameWithPath)
            DataGridViewImageList.CurrentCell = DataGridViewImageList(0, 0)
        Catch
            MsgBox("No image selected.")
        End Try

        DataGridViewImageList.Focus()
    End Sub
    Private Sub ButtonExtractImages_Click(sender As Object, e As EventArgs) Handles ButtonExtractImages.Click
        PictureBox2.Visible = False

        ExtractImageFilesFromPDF()
    End Sub
    Private Sub ExtractImageFilesFromPDF()
        If CLOSOFN = "" Then
            MsgBox("CLOSO file Not opened")
            Exit Sub
        End If
        If Not CLOSOFN.Contains(".CLOSO") Then
            MsgBox("CLOSO file Not opened")
            Exit Sub
        End If

        Dim NN As Integer = 0
        Dim Er1 As Boolean = False
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "File Of scanned images|*.PDF"

        ' Show the dialog.-----------------------------------------------------------
        Dim result As DialogResult = openFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            filePDF = openFileDialog1.FileName
            If Not Directory.Exists(CLOSOImageFolderNameWithPath) Then
                Directory.CreateDirectory(CLOSOImageFolderNameWithPath)
            Else
                If RadioButtonDeleteOldFiles.Checked Then
                    'Delete all files in the folder
                    DeleteFilesInFolder(CLOSOImageFolderNameWithPath)
                End If
            End If
        Else
            Exit Sub
        End If

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim Count As Integer = 0
        Dim I As Integer
        If RadioButtonDeleteOldFiles.Checked Then
            NStartPDF = 1 'File naming of extracted files will start with this ...Image00(nstartpdf).png
        End If
        If RadioButtonAppendAtRow.Checked Then
            If DataGridViewImageList.RowCount > 1 Then
                NStartPDF = Val(DataGridViewImageList.CurrentRow.Index) + 1
            End If
        End If
        If RadioButtonAppendAtEnd.Checked Then
            NStartPDF = NFileNamesofScannedImages + 1
        End If
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        '-------------------- Ghostscript extraction STARTS here ---------------------------------------
        If Not GhostscriptVersionInfo.IsGhostscriptInstalled Then

            Dim DirGhostScriptSetup32 As String = Path.Combine(Environment.CurrentDirectory, "gs920w32.exe")
            If Not File.Exists(DirGhostScriptSetup32) Then
                MsgBox("AGPL Ghostscript Is Not installed On your system And the installer  (gs920w32.exe) Not found In the following path:" _
                        & vbLf & Environment.CurrentDirectory & vbLf &
                        "You may install ghostscript by downloading it from:" & vbLf & "https://ghostscript.com/download/gsdnld.html.")
                Exit Sub
            Else
                msg = "AGPL Ghostscript is not installed on your system." & vbLf &
                       "AGPL Ghostscript installer  (gs920w32.exe) is available." & vbLf &
                       "Do you want to install AGPL Ghostscript on your system?"
                style = MsgBoxStyle.YesNo
                title = "Install Ghostscript"   ' Define title.
                ' Display message.
                response = MsgBox(msg, style, title)
                If response = MsgBoxResult.Yes Then   ' User chose Yes.
                    Dim processs As Process = Process.Start(DirGhostScriptSetup32)
                    processs.WaitForExit()
                Else
                    Exit Sub
                End If
            End If
        End If
        Try
            Count = StartExtracting(filePDF, CLOSOImageFolderNameWithPath, NStartPDF)
            MsgBox("Number of images extracted = " & Count)
        Catch
            MsgBox("Extraction from PDF failed. Probable cause: Ghostscript error.")
            System.Windows.Forms.Cursor.Current = Cursors.Default
            Exit Sub
        End Try
        '-------------------- Ghostscript extraction ENDS here ---------------------------------------

        If Not Directory.Exists(CLOSOImageFolderNameWithPath) Then
            MsgBox("Extraction from PDF failed. Unable to create the folder : " & CLOSOImageFolderNameWithPath)
            System.Windows.Forms.Cursor.Current = Cursors.Default
            Exit Sub
        End If
        NFileNamesofScannedImages = Directory.GetFiles(CLOSOImageFolderNameWithPath, "*.*").Count
        If NFileNamesofScannedImages < 1 Then
            MsgBox("The folder of images extracted from the PDF is empty. Folder name: " & CLOSOImageFolderNameWithPath)
            System.Windows.Forms.Cursor.Current = Cursors.Default
            Exit Sub
        End If

        Dim FNs As String() = System.IO.Directory.GetFiles(CLOSOImageFolderNameWithPath)
        I = 0
        For Each t In FNs
            I = I + 1
            FileNamesOfScannedImagesWithSeperatorPages(I) = System.IO.Path.GetFileName(t)
        Next t
        RadioButtonAppendAtEnd.Checked = True
        DisplayScannedImageDataTable1()
        System.Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub sh_image_Click(sender As Object, e As EventArgs) Handles ButtonViewImageFolder.Click
        PictureBox2.Visible = False

        If Directory.Exists(CLOSOImageFolderNameWithPath) Then
            NFileNamesofScannedImages = Directory.GetFiles(CLOSOImageFolderNameWithPath, "*.*").Count
            If NFileNamesofScannedImages > 0 Then
                Process.Start(CLOSOImageFolderNameWithPath)
                Exit Sub
            End If
        End If
        MsgBox("Please extract the images from the PDF file to view the folder of image files.")
    End Sub

    Private Sub LoadPictureBoxUsingFileStream(FullFileNameWithPath)
        Dim fs As System.IO.FileStream
        If File.Exists(FullFileNameWithPath) Then
            PictureBox1.Visible = True
            If RadioButtonActualSize.Checked Then
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            ElseIf RadioButtonFitToPage.Checked Then
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End If
            If RadioButtonA4.Checked Then
                PictureBox1.Width = PictureBox1.Height * 210 / 297
            Else
                PictureBox1.Width = PictureBox1.Height * 216 / 280
            End If

            Dim IR As Integer = DataGridViewImageList.CurrentRow.Index
            Dim t1 As String = DataGridViewImageList.Item(0, IR).Value
            fs = New System.IO.FileStream(FullFileNameWithPath, FileMode.Open, FileAccess.Read)
            Try
                PictureBox1.Image = System.Drawing.Image.FromStream(fs)
                LabelNoImageToDisplay.Visible = False

            Catch
                MsgBox("Unable to display the image file: " & FullFileNameWithPath)
                LabelNoImageToDisplay.Visible = True

            End Try
            fs.Close()
        Else
            'MsgBox("Image file not found.")
        End If



    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
    Public Sub DeleteFilesInFolder(F)
        'Dim fs As FileStream
        Try
            PictureBox1.Image.Dispose()
        Catch
            'ignore
        End Try
        For Each s In System.IO.Directory.GetFiles(F)
            Try
                Dim imageFileStream As New FileStream(s, FileMode.Open, FileAccess.Read)
                imageFileStream.Close()
                imageFileStream.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                'My.Computer.FileSystem.DeleteFile(s, FileIO.UICancelOption.DoNothing, FileIO.RecycleOption.SendToRecycleBin)
                System.IO.File.Delete(s)
            Catch
                Continue For
            End Try
        Next s

    End Sub

    Private Sub DataGridViewImageList_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewImageList.CellMouseUp
        If e.RowIndex < 0 Then Exit Sub
        FullFileNameWithPath = CLOSOImageFolderNameWithPath & "\" & FileNamesOfScannedImagesWithSeperatorPages(e.RowIndex + 1)
        Try
            LoadPictureBoxUsingFileStream(FullFileNameWithPath)
            'PictureOnDisplayID = e.RowIndex + 1
        Catch
            MsgBox("No image selected.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Visible = False
        GetCLOSOFileName()
        If CLOSOFN = "" Then Exit Sub
        CLOSOImageFolderNameWithPath = CLOSOFN.Substring(0, CLOSOFN.IndexOf(".CLOSO")) & "-Images"
        If Directory.Exists(CLOSOImageFolderNameWithPath) Then
            NFileNamesofScannedImages = Directory.GetFiles(CLOSOImageFolderNameWithPath, "*.*").Count
            DisplayScannedImageDataTable1()
        Else
            NFileNamesofScannedImages = 0
            For I = 1 To DataGridViewImageList.RowCount
                DataGridViewImageList.Item(0, I - 1).Value = "Image not extracted"
            Next
            LabelNoImageToDisplay.Visible = True
            PictureBox1.Image = Nothing
        End If
        Label1.Text = "CLOSO File Name: " & CLOSOFN
        Label2.Text = "CLOSO Image Folder Name: " & CLOSOImageFolderNameWithPath


    End Sub

    Private Sub RadioButtonLetter_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLetter.CheckedChanged
        Dim P As Point
        LoadPictureBoxUsingFileStream(FullFileNameWithPath)
        PictureBox1.Height = DataGridViewImageList.Height - 40
        If RadioButtonA4.Checked Then
            PictureBox1.Width = PictureBox1.Height * 210 / 297
        Else
            PictureBox1.Width = PictureBox1.Height * 216 / 280
        End If

        P.X = (GroupBoxPicture.Width - PictureBox1.Width) / 2
        P.Y = (GroupBoxPicture.Height - PictureBox1.Height) / 2
        PictureBox1.Location = P
        PictureBox2.Visible = False

    End Sub

    Private Sub RadioButtonFitToPage_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFitToPage.CheckedChanged
        LoadPictureBoxUsingFileStream(FullFileNameWithPath)
        PictureBox2.Visible = False

    End Sub

    Private Sub DataGridViewImageList_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridViewImageList.CurrentCellChanged
        If DataGridViewImageList.CurrentRow IsNot Nothing Then
            Dim IR As Integer = DataGridViewImageList.CurrentRow.Index
            If IR < 0 Or IR >= DataGridViewImageList.RowCount Then Exit Sub

            Dim FullFileNameWithPath As String = CLOSOImageFolderNameWithPath & "\" & FileNamesOfScannedImagesWithSeperatorPages(DataGridViewImageList.CurrentRow.Index + 1)
            Try
                LoadPictureBoxUsingFileStream(FullFileNameWithPath)
            Catch
                MsgBox("No image selected.")
            End Try
            DataGridViewImageList.Focus()
        End If

    End Sub

    Public Function StartExtracting(ByVal InputPath As String, ByVal OutputfolderPath As String, ByVal NStartPDF As Integer) As Integer
        Dim TotalCount As Integer = 0

        Dim desired_x_dpi As Integer = 96
        Dim desired_y_dpi As Integer = 96

        Dim inputPdfPath As String = InputPath
        Dim outputPath As String = OutputfolderPath

        Using rasterizer As New GhostscriptRasterizer()

            rasterizer.Open(inputPdfPath)
            TotalCount = rasterizer.PageCount
            Dim pageNumber As Integer

            Dim img As Image
            For pageNumber = 1 To rasterizer.PageCount 'Step pageNumber + 1
                Try
                    Dim pageFilePath As String = Path.Combine(outputPath, String.Format("Page{0:D4}.png", pageNumber + NStartPDF - 1))
                    img = rasterizer.GetPage(desired_x_dpi, desired_y_dpi, pageNumber)
                    img.Save(pageFilePath, ImageFormat.Png)
                Catch
                    MsgBox("Unable to extract using Ghostscript. Error occurred.")
                End Try

            Next
        End Using

        Return TotalCount
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            Exit Sub
        End If
        PictureBox2.Location = DataGridViewImageList.Location
        PictureBox2.Width = DataGridViewImageList.Width + GroupBoxPicture.Width + 10
        PictureBox2.Height = DataGridViewImageList.Height
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick
        PictureBox2.Visible = False
    End Sub
End Class


