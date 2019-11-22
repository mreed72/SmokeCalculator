'© 2019 Scott Reed

Public Class Form1
     Dim x As New xFuels

     Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Dim xv As String = My.Application.Info.Version.ToString
          Me.Text = "Smoke Calculator v" & xv

     End Sub

     Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
          'CLEAR
          Try
               txBurnSize.Clear()
               txCatDay.Clear()
               txDistance.Clear()
               txRecommend.Clear()
               txResults.Clear()
               txAvFuels.Text = "0"
               txAllowed.Text = "0"
               txTotalTons.Text = "0"
               txFtype.SelectedIndex = -1
               txFload.SelectedIndex = -1
          Catch ex As Exception
          End Try

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
          'CALCULATE

          'TODO: need to write code to check fields before calculating

          Try
               txAvFuels.Text = x.GetTonsAvailable(txFtype.SelectedItem, txFload.SelectedItem)
               txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
               txAllowed.Text = x.smpCalc(txCatDay.Text, txDistance.Text)

               If Val(txTotalTons.Text) >= Val(txAllowed.Text) Then
                    Dim snew As Integer = txAllowed.Text \ txAvFuels.Text - 5
                    txRecommend.Text = "New Burn Size: " & snew & " acres."
                    txResults.Text = "Burn Will Exceed the Guidelines."
               Else
                    txRecommend.Clear()
                    txResults.Text = "Burn is Good."
               End If
          Catch ex As Exception
          End Try
     End Sub
End Class
