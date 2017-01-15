Imports System.IO

Public Class FileRename
    Private files() As FileInfo
    Private fileNameLength As Integer
    Private isDirectoryEmpty = True

    Private Sub Rename() Handles btnRename.Click
        Dim errors As Boolean = False

        Try
            If String.IsNullOrWhiteSpace(txtDirectory.Text) = True Then
                errors = True
                txtDirectory.BackColor = Color.Cyan
            Else
                txtDirectory.BackColor = Color.Empty
            End If

            For Each parentControl As Control In Controls
                For Each childControl In parentControl.Controls
                    If TypeOf childControl Is TextBox Then
                        If childControl.Name.Contains("txtInt") Then
                            If IsNumeric(childControl.Text) = False Then
                                errors = True
                                childControl.BackColor = Color.Cyan
                            Else
                                childControl.BackColor = Color.Empty
                            End If
                        End If
                    End If
                Next
            Next

            If errors = False Then
                If Directory.Exists(txtDirectory.Text) Then
                    Dim startIndex = Integer.Parse(txtIntStartIndex.Text)
                    Dim length = Integer.Parse(txtIntLength.Text)
                    Dim fileName = String.Empty

                    files = New DirectoryInfo(txtDirectory.Text).GetFiles()
                    For Each file As FileInfo In files
                        If startIndex + length > file.Name.Length - file.Extension.Length Then
                            Continue For
                        End If

                        fileName = txtPrefix.Text & file.Name.Substring(startIndex, length) & txtSuffix.Text & txtExtension.Text
                        file.MoveTo(txtDirectory.Text & Path.DirectorySeparatorChar & fileName)
                    Next file

                    MsgBox("Файловете бяха преименувани успешно!", MsgBoxStyle.OkOnly, "Преименуване на файлове")
                Else
                    Throw New DirectoryNotFoundException("Не съществува такава директория!")
                End If
            End If
        Catch ex As DirectoryNotFoundException
            txtDirectory.Text = ex.Message
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub SelectDirectory() Handles btnSelectDirectory.Click
        Dim folderBrowserDialog As New FolderBrowserDialog
        Dim fileInfo As FileInfo

        Try
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                txtDirectory.Text = folderBrowserDialog.SelectedPath
                files = New DirectoryInfo(txtDirectory.Text).GetFiles()

                If files.Length > 0 Then
                    isDirectoryEmpty = False
                    fileInfo = files(0)
                    fileNameLength = fileInfo.Name.Length - fileInfo.Extension.Length
                    txtIntStartIndex.Text = 0
                    txtIntLength.Text = fileNameLength
                    txtOldNamePreview.Text = fileInfo.Name
                    txtNewNamePreview.Text = txtPrefix.Text & Strings.Left(fileInfo.Name, fileNameLength) & txtSuffix.Text & fileInfo.Extension
                    txtExtension.Text = fileInfo.Extension

                    With TrackBar
                        .Minimum = 0
                        .Maximum = fileNameLength
                    End With
                Else
                    Throw New Exception("Няма намерени файлове!")
                End If
            End If
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub SetTrackBar() Handles TrackBar.Scroll
        Dim startIndex As Integer

        Try
            If isDirectoryEmpty = False Then
                startIndex = Integer.Parse(txtIntStartIndex.Text)
                With txtIntLength
                    .Text = TrackBar.Value
                End With

                With txtOldNamePreview
                    .Focus()
                    .Select(startIndex, TrackBar.Value)
                End With

                SetNewName()
            End If
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub ValidateStartIndex() Handles txtIntStartIndex.Validated
        Dim startIndex As Integer
        Dim length As Integer

        Try
            If isDirectoryEmpty = False Then
                startIndex = Integer.Parse(txtIntStartIndex.Text)

                If startIndex >= 0 And startIndex < fileNameLength Then
                    length = fileNameLength - startIndex
                    txtIntLength.Text = length

                    With TrackBar
                        .Minimum = 0
                        .Value = 0
                        .Maximum = length
                    End With
                Else
                    Throw New Exception(String.Format("Началният индекс {0} на низа е по-голям от неговата дължината {1}!", startIndex, fileNameLength))
                End If
            End If
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub ValidateFileName() Handles txtPrefix.TextChanged, txtSuffix.TextChanged, txtExtension.Validated
        Try
            SetNewName()
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub SetNewName()
        With txtNewNamePreview
            .Text = txtPrefix.Text & txtOldNamePreview.SelectedText & txtSuffix.Text & txtExtension.Text
        End With
    End Sub

    Private Sub GetMessage(ByVal message As String, ByVal type As Integer)
        Select Case type
            Case 1
                MsgBox(message, MsgBoxStyle.Exclamation, "Внимание")
            Case 2
                MsgBox(message, MsgBoxStyle.Critical, "Критична грешка")
            Case Else
                MsgBox(message, MsgBoxStyle.Information, "Информация")
        End Select
    End Sub

    Private Sub NavigateGooglePlus() Handles lblGooglePlus.LinkClicked
        Try
            Process.Start("https://plus.google.com/102163636733230695963")
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub

    Private Sub NavigateHomePage() Handles lblHomePage.LinkClicked
        Try
            Process.Start("http://sixeightone.eu")
        Catch ex As Exception
            GetMessage(ex.Message, 1)
        End Try
    End Sub
End Class