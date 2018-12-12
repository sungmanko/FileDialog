Public Class Form1

    ''' <summary>
    ''' 파일을 선택합니다.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Title = "파일선택 타이틀입니다."

        ' 초기 디렉토리를 설정합니다.
        OpenFileDialog1.InitialDirectory = "C:\"

        ' 초기 선택파일명을 선택합니다.
        OpenFileDialog1.FileName = "초기파일명"

        ' 파일의 필터를 설정합니다.
        OpenFileDialog1.Filter = "텍스트파일|*.txt;*.log|전체파일|*.*"

        ' 필터의 초기설정입니다. 
        OpenFileDialog1.FilterIndex = 1

        ' 다이얼로그를 닫을때 마지막 설정을 유효로 하겠다는 설정입니다.
        OpenFileDialog1.RestoreDirectory = True

        ' 복수파일을 선택가능하게 합니다.
        OpenFileDialog1.Multiselect = False

        ' HELP 버튼을 표시합니다.
        OpenFileDialog1.ShowHelp = True

        ' 읽기전용으로 표시합니다.
        OpenFileDialog1.ShowReadOnly = True

        ' 체크박스를 표시합니다.
        OpenFileDialog1.ReadOnlyChecked = True

        ' 존재하지않는 파일을 선택했을때 경고를 표시합니다.
        'OpenFileDialog1.CheckFileExists = True

        ' 존재하지않는 경로를 지정했을때 경고를 표시합니다.
        'OpenFileDialog1.CheckPathExists = True

        ' 확장자가 존재하지 않는경우에는 확장자를 자동으로 붙여줍니다.
        'OpenFileDialog1.AddExtension = True

        ' 유효한 Win32 파일명만을 입력받게합니다.
        'OpenFileDialog1.ValidateNames = True

        ' 다이얼로그를 표시하고 OK 선택시에만 선택한 파일을 표시합니다.
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName

            ' 파일이 복수선택 되었을때는 아래의 로직이 돌아가며 뿌려줍니다.
            'For Each nFileName As String In OpenFileDialog1.FileNames
            '    MessageBox.Show(nFileName)
            'Next nFileName
        End If

        ' 처리가 끝났으므로 파기합니다.
        OpenFileDialog1.Dispose()
    End Sub

    ''' <summary>
    ''' 파일을 지정된곳으로 복사합니다.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFileCopy_Click(sender As Object, e As EventArgs) Handles btnFileCopy.Click

        ' 파일명을 취득합니다.
        Dim fileName As String = System.IO.Path.GetFileName(TextBox1.Text)

        ' 파일을 복사합니다.
        System.IO.File.Copy(TextBox1.Text, TextBox2.Text & fileName, True)

        ' 파일을 이동합니다.
        'System.IO.File.Move("C:\test\1.txt", "C:\test\3.txt")
    End Sub

End Class
