Public Class frmLogViewer
     Dim sLG As String = "C:\Smoke Calculator\slog.txt"
     Dim mLG As String = "C:\Smoke Calculator\mlog.txt"
     Dim eLG As String = "C:\Smoke Calculator\elog.txt"
     Dim x As New xFuels

     Private Sub frmLogViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

     End Sub

     Function RdText(c As String)
          Try
               Dim filex As String
               filex = c
               Dim cnts As String
               cnts = My.Computer.FileSystem.ReadAllText(filex)
               rtb.Text = cnts
          Catch ex As Exception
               x.errorlog("2XDN7NK", ex.Message)
          End Try
     End Function

     Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
          Try
               RdText(sLG)
          Catch ex As Exception
               x.ErrorLog("2XEOC51", ex.Message)
          End Try
     End Sub

     Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
          Try
               RdText(mLG)
          Catch ex As Exception
               x.ErrorLog("2X70RSU", ex.Message)
          End Try
     End Sub

     Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
          Try
               RdText(eLG)
          Catch ex As Exception
               x.ErrorLog("2XR4I00", ex.Message)
          End Try
     End Sub

     Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
          Try
               Dim x As String = "C:\Smoke Calculator\"
               Diagnostics.Process.Start(x)
          Catch ex As Exception
               x.ErrorLog("2XF5OGN", ex.Message)
          End Try

     End Sub

     Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
          Try
               My.Computer.FileSystem.DeleteFile(sLG)
               My.Computer.FileSystem.DeleteFile(mLG)
               My.Computer.FileSystem.DeleteFile(eLG)

               My.Computer.FileSystem.WriteAllText(sLG, "", False)
               My.Computer.FileSystem.WriteAllText(mLG, "", False)
               My.Computer.FileSystem.WriteAllText(eLG, "", False)

               MsgBox("All Log Files Cleared!")

          Catch ex As Exception
               x.ErrorLog("2XZ1QYF", ex.Message)
          End Try
     End Sub

     Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click

          Try
               Dim ftname As String = "C:\Smoke Calculator\Log_" & grs(5) & ".rtf"
               Dim sw As New System.IO.StreamWriter(ftname, True)
               sw.Write(rtb.Rtf)
               sw.Flush()
               sw.Close()
               bLogName.Text = ftname
          Catch ex As Exception
               MessageBox.Show(ex.Message)
          End Try

     End Sub


     Function grs(ByRef length As Integer) As String
          Randomize()
          Dim ac As String
          ac = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
          Dim i As Integer
          For i = 1 To length
               grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
          Next
     End Function




End Class