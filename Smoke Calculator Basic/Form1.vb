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

    Private Function CheckFields() As Boolean
        If txBurnSize.Text = String.Empty Then
            txBurnSize.BackColor = Color.Yellow
            Return False
        Else
               txBurnSize.BackColor = Color.White
            Return True
        End If

        If txCatDay.Text = String.Empty Then
            txCatDay.BackColor = Color.Yellow
            Return False
        Else
               txCatDay.BackColor = Color.White
            Return True
        End If

        If txDistance.Text = String.Empty Then
            txDistance.BackColor = Color.Yellow
            Return False
        Else
               txDistance.BackColor = Color.White
            Return True
        End If

        If txFtype.SelectedIndex = -1 Then
            txFtype.BackColor = Color.Yellow
            Return False
        Else
               txFtype.BackColor = Color.White
            Return True
        End If

        If txFload.SelectedIndex = -1 Then
            txFload.BackColor = Color.Yellow
            Return False
        Else
               txFload.BackColor = Color.White
            Return True
        End If

    End Function

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        'CALCULATE

        'TODO: need to fix code to check fields before calculating
        If CheckFields() = False Then
            Exit Sub
        Else
            Try
                txAvFuels.Text = x.GetTonsAvailable(txFtype.SelectedItem, txFload.SelectedItem)
                txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
                txAllowed.Text = x.smpCalc(txCatDay.Text, txDistance.Text)

                If Val(txTotalTons.Text) >= Val(txAllowed.Text) Then
                    Dim snew As Integer = txAllowed.Text \ txAvFuels.Text - 5
                    txRecommend.Text = "New Burn Size: " & snew & " acres."
                         txResults.Text = "Burn Will Exceed the Guidelines."
                         txResults.BackColor = Color.LightPink
                Else
                    txRecommend.Clear()
                         txResults.Text = "Burn is Good."
                         txResults.BackColor = Color.White
                End If
            Catch ex As Exception
               End Try
        End If

          Dim bs, cd As Integer
          Dim td As Double
          Dim ft, fl As String
          Dim res, rec As String

          bs = txBurnSize.Text
          cd = txCatDay.Text
          td = txDistance.Text
          ft = txFtype.SelectedItem
          fl = txFload.SelectedItem
          res = txResults.Text
          rec = txRecommend.Text

          x.LogIt("Burn Size: " & bs & vbNewLine & "Category Day: " & cd & vbNewLine & "Target Distance: " & td & vbNewLine & "Fuel Type: " & ft _
                 & vbNewLine & "Fuel Load: " & fl & vbNewLine & "Results: " & res & vbNewLine & "Recommended: " & rec)





    End Sub

    Private Sub txCatDay_Leave(sender As Object, e As EventArgs) Handles txCatDay.Leave
        Try
            If txCatDay.Text < 1 Or txCatDay.Text > 5 Then
                txCatDay.BackColor = Color.Yellow
            Else
                    txCatDay.BackColor = Color.White
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        About.Show()

    End Sub

     Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
          Dim fx As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\SmokeLog.txt"
          My.Computer.FileSystem.DeleteFile(fx, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

     End Sub
End Class