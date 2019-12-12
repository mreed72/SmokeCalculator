Public Class frmSingle
     Dim x As New xFuels
     Dim sTime As String
     Dim sNEW As Integer
     Private CompTime As System.Int32
     Dim steps As Integer = 0

     Private Sub frmSingle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          'LOAD
          Me.Text = "Single Fuels Calculator"
          Try
               CompTime = Environment.TickCount
               Timer1.Start()
          Catch ex As Exception
               x.ErrorLog("2X5N9QA", ex.Message)
          End Try
          btnCalc.Enabled = False

     End Sub

     Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
          'CLEAR
          Try
               txBurnSize.Clear()
               txCatDay.Clear()
               txDistance.Clear()
               txFtype.SelectedIndex = -1
               txFload.SelectedIndex = -1
               txAvFuels.Text = 0
               txAllowed.Text = 0
               txTotalTons.Text = 0
               txRec.Clear()
               txResults.Clear()
               txRec.BackColor = Color.White
               txResults.BackColor = Color.White
               sNEW = 0
               steps = 0
               btnCalc.Enabled = False

          Catch ex As Exception
               x.ErrorLog("2XXLK6G", ex.Message)
          End Try

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
          'CALC
          If CheckFields(txBurnSize) = False Then
               txBurnSize.BackColor = Color.Yellow
               Exit Sub
          Else
               txBurnSize.BackColor = Color.White
          End If

          If CheckFields(txCatDay) = False Then
               txCatDay.BackColor = Color.Yellow
               Exit Sub
          Else
               txCatDay.BackColor = Color.White
          End If

          If CheckFields(txDistance) = False Then
               txDistance.BackColor = Color.Yellow
               Exit Sub
          Else
               txDistance.BackColor = Color.White
          End If

          If CheckFields(txFtype) = False Then
               txFtype.BackColor = Color.Yellow
               Exit Sub
          Else
               txFtype.BackColor = Color.White
          End If

          If CheckFields(txFload) = False Then
               txFload.BackColor = Color.Yellow
               Exit Sub
          Else
               txFload.BackColor = Color.White
          End If

          Try
               txAvFuels.Text = x.GetAvailableFuels(txFtype.SelectedItem, txFload.SelectedItem)
               txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
               txAllowed.Text = x.smpCalc(txCatDay.Text, txDistance.Text)
          Catch ex As Exception
               x.ErrorLog("2XKD5RO", ex.Message)
          End Try

          Try
               If Val(txTotalTons.Text) > Val(txAllowed.Text) Then
                    txResults.Text = "This burn will exceed the guidelines."
                    txResults.BackColor = Color.LightPink
                    sNEW = txAllowed.Text \ txAvFuels.Text - 5
                    txRec.Text = "Recommendation:  Reduce burn size to a maximum of " & sNEW & " acres."
               Else
                    txResults.Text = "Burn is Good"
                    txResults.BackColor = Color.LightGreen
                    txRec.Clear()
               End If
          Catch ex As Exception
               x.ErrorLog("2XI6LZ1", ex.Message)
          End Try

          Try
               x.SessionLog("Elapsed Time: " & sTime & vbNewLine & "SIZE: " & txBurnSize.Text & vbNewLine & "CATDAY: " & txCatDay.Text & vbNewLine & "DISTANCE: " & txDistance.Text _
                            & vbNewLine & "FUEL TYPE:  " & txFtype.SelectedItem & " LD: " & txFload.SelectedItem & vbNewLine & "AFUELS: " & txAvFuels.Text & vbNewLine & _
                            "ALLOWED: " & txAllowed.Text & vbNewLine & "TOTALTONS: " & txTotalTons.Text & vbNewLine & "RESULTS: " & txResults.Text & vbNewLine & "REC: " & txRec.Text)
          Catch ex As Exception
               x.ErrorLog("2XVXTA2", ex.Message)
          End Try



     End Sub

     Private Function CheckFields(c As Control) As Boolean
          Try
               If TypeOf c Is TextBox Then
                    If c.Text = String.Empty Then
                         Return False
                    Else
                         Return True
                    End If
               End If

               If TypeOf c Is ComboBox Then
                    If c.Text = String.Empty Then
                         Return False
                    Else
                         Return True
                    End If
               End If
          Catch ex As Exception
               x.ErrorLog("2XIU0JM", ex.Message)
          End Try

     End Function


#Region "Time Lapse"

     Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
          Try
               Dim CurTickValue As System.Int32 = Environment.TickCount
               Dim Difference As System.Int32 = CurTickValue - CompTime

               Dim Hours As System.Int32
               Dim Minutes As System.Int32
               Dim Seconds As System.Int32

               Hours = (Difference / (3600 * 999)) Mod 24
               Minutes = (Difference / (60 * 999)) Mod 60
               Seconds = (Difference / 999) Mod 60

               sTime = String.Format("{0} hours, {1} minutes {2} seconds", CStr(Hours), CStr(Minutes), CStr(Seconds))
          Catch ex As Exception
               x.ErrorLog("2X69B4V", ex.Message)
          End Try
     End Sub
#End Region



     Private Sub txBurnSize_Leave(sender As System.Object, e As System.EventArgs) Handles txBurnSize.Leave
          Try
               If txBurnSize.Text > String.Empty Then
                    steps += 1
               End If
          Catch ex As Exception

          End Try
          Label9.Text = steps
     End Sub

     Private Sub txCatDay_Leave(sender As System.Object, e As System.EventArgs) Handles txCatDay.Leave
          Try
               If txCatDay.Text > String.Empty Then
                    steps += 1
               End If
          Catch ex As Exception

          End Try
          Label9.Text = steps
     End Sub

     Private Sub txDistance_Leave(sender As System.Object, e As System.EventArgs) Handles txDistance.Leave
          Try
               If txDistance.Text > String.Empty Then
                    steps += 1
               End If
          Catch ex As Exception

          End Try
          Label9.Text = steps
     End Sub

     Private Sub txFtype_Leave(sender As System.Object, e As System.EventArgs) Handles txFtype.Leave
          Try
               If txFtype.SelectedIndex > -1 Then
                    steps += 1
               End If
          Catch ex As Exception

          End Try
          Label9.Text = steps
     End Sub

     Private Sub txFload_Leave(sender As System.Object, e As System.EventArgs) Handles txFload.Leave
          Try
               If txFload.SelectedIndex > -1 Then
                    steps += 1
               End If
          Catch ex As Exception

          End Try
          Label9.Text = steps
     End Sub

     Private Sub Label9_TextChanged(sender As System.Object, e As System.EventArgs) Handles Label9.TextChanged
          If steps = 5 Then
               btnCalc.Enabled = True
               steps = 0
          End If
     End Sub
End Class