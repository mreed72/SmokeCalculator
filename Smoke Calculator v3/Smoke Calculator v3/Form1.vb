Public Class Form1
     Dim sLG As String = "C:\Smoke Calculator\slog.txt"
     Dim mLG As String = "C:\Smoke Calculator\mlog.txt"
     Dim eLG As String = "C:\Smoke Calculator\elog.txt"
     Dim x As New xFuels

     Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Try
               Dim xv, xc As String
               xv = My.Application.Info.Version.ToString
               xc = My.Application.Info.ProductName
               lbVersion.Text = xv
               Me.Text = xc & " v" & xv
          Catch ex As Exception
               x.errorlog("2XXMVZ4", ex.Message)
          End Try

          Try
               Dim d1, d2, d3 As Boolean
               d1 = My.Computer.FileSystem.FileExists(sLG)
               d2 = My.Computer.FileSystem.FileExists(mLG)
               d3 = My.Computer.FileSystem.FileExists(eLG)
               If d1 = False Then
                    My.Computer.FileSystem.WriteAllText(sLG, "", False)
               End If
               If d2 = False Then
                    My.Computer.FileSystem.WriteAllText(mLG, "", False)
               End If
               If d3 = False Then
                    My.Computer.FileSystem.WriteAllText(eLG, "", False)
               End If
          Catch ex As Exception

          End Try





     End Sub

     Private Sub btnSingle_Click(sender As System.Object, e As System.EventArgs) Handles btnSingle.Click
          frmSingle.Show()

     End Sub

     Private Sub btnMultiple_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiple.Click
          frmMultiple.Show()

     End Sub

     Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
          frmLogViewer.Show()

     End Sub

     Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
          frmAbout.Show()

     End Sub
End Class
