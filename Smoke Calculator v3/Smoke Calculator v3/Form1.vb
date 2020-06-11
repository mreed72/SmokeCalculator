Public Class Form1
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
          x.CheckLogFiles()

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
