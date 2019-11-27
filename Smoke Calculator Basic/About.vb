Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About: {0}", ApplicationTitle)

        Label1.Text = "v" & My.Application.Info.Version.ToString
        Label2.Text = My.Application.Info.ProductName.ToString
        Label3.Text = "© 2019 SimonCoder Software Design"

          Dim slog As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\SmokeLog.txt"
          Dim cnts As String
          cnts = My.Computer.FileSystem.ReadAllText(slog)

          RichTextBox1.Text = cnts

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim x4 As String = "mailto:mreed1972@gmail.com"
            Diagnostics.Process.Start(x4)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Dim x4 As String = "https://github.com/mreed72/SmokeCalculator"
            Diagnostics.Process.Start(x4)
        Catch ex As Exception
        End Try
    End Sub

End Class