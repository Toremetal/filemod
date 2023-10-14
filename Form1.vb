Imports Microsoft.VisualBasic.FileIO

Public Class Form1

    Function Add(ByVal a As Int32)
        Return a + 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If FileIO.FileSystem.FileExists(InFile.Text.ToString()) Then
            ' Dim timeNow = Date.Now
            Dim cnt = CountWith.Text
            Dim line As String
            Dim filewtr As IO.StreamWriter = FileIO.FileSystem.OpenTextFileWriter(SpecialDirectories.Desktop & "\(new)" & OpenFileDialog1.SafeFileName, False)
            Dim fileRdr As IO.StreamReader = FileIO.FileSystem.OpenTextFileReader(InFile.Text.ToString())
            While Not fileRdr.EndOfStream
                line = fileRdr.ReadLine()
                If Not ReplaceText.Text = "" Then
                    line = line.Replace(ReplaceText.Text, TextWith.Text)
                End If
                line = Before.Text & line & After.Text
                If CheckBox1.Checked Then
                    If Not ReplaceCount.Text = "" Then
                        line = line.Replace(ReplaceCount.Text, cnt.ToString())
                        cnt = Add(cnt)
                    End If
                Else
                    If Not ReplaceCount.Text = "" And Not ReplaceCount.Text = "" Then
                        line = line.Replace(ReplaceCount.Text, CountWith.Text)
                    End If
                End If
                filewtr.WriteLine(line)
            End While
            fileRdr.Close()
            filewtr.Close()
            CountWith.Text = cnt
        End If
        If MsgBox("File processing complete! Open File?", MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
            Process.Start(SpecialDirectories.Desktop & "\(new)" & OpenFileDialog1.SafeFileName)
        End If
        Button1.Enabled = True
    End Sub

    Private Sub InFile_Clicked(sender As Object, e As EventArgs) Handles InFile.Click
        If Not OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
            InFile.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class
