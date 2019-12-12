Public Class frmMultiple
     Dim x As New xFuels
     Dim sTime As String
     Private CompTime As System.Int32
     Dim MultiFileName As String


     Private Sub frmMultiple_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Me.Text = "Multiple Fuels Calculator"
          Try
               CompTime = Environment.TickCount
               Timer1.Start()
          Catch ex As Exception
               x.ErrorLog("2X5N9QA", ex.Message)
          End Try
     End Sub




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




     Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
          If Chks(txBlkSize) = False Then
               txBlkSize.BackColor = Color.Yellow
               Exit Sub
          Else
               txBlkSize.BackColor = Color.White
          End If

          If Chks(txFtype) = False Then
               txFtype.BackColor = Color.Yellow
               Exit Sub
          Else
               txFtype.BackColor = Color.White
          End If

          If Chks(txFload) = False Then
               txFload.BackColor = Color.Yellow
               Exit Sub
          Else
               txFload.BackColor = Color.White
          End If


          Try
               Dim sAVF As Integer
               sAVF = x.GetAvailableFuels(txFtype.SelectedItem, txFload.SelectedItem)
               Dim sTT As Integer
               sTT = Val(txBlkSize.Text) * Val(sAVF)

               dgv.Rows.Add(txBlkSize.Text, txFtype.SelectedItem, txFload.SelectedItem, sAVF, sTT)
          Catch ex As Exception
               x.ErrorLog("2X3OUWL", ex.Message)
          End Try

          txBlkSize.Clear()
          txFtype.SelectedIndex = -1
          txFload.SelectedIndex = -1
          txBlkSize.Focus()






     End Sub

     Private Sub dgv_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded
          'total values from the datagrid

          Try
               Dim xM, xC As Decimal
               For Each row As DataGridViewRow In dgv.Rows
                    xM += row.Cells(0).Value 'Size
                    xC += row.Cells(4).Value 'Tons
               Next
               txTotalSize.Text = xM
               txTotalTons.Text = xC
          Catch ex As Exception
               x.ErrorLog("2XW3OSI", ex.Message)
          End Try


     End Sub

     Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
          Try
               txBlkSize.Clear()
               txFtype.SelectedIndex = -1
               txFload.SelectedIndex = -1
               dgv.Rows.Clear()
               txAllowed.Text = 0
               txTotalSize.Text = 0
               txTotalTons.Text = 0
               txResults.Clear()
               txCatDay.Clear()
               txDistance.Clear()

          Catch ex As Exception
               x.ErrorLog("2XL31O6", ex.Message)
          End Try

     End Sub

     Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
          'CALC
          If Chks(txCatDay) = False Then
               txCatDay.BackColor = Color.Yellow
               Exit Sub
          Else
               txCatDay.BackColor = Color.White
          End If

          If Chks(txDistance) = False Then
               txDistance.BackColor = Color.Yellow
               Exit Sub
          Else
               txDistance.BackColor = Color.White
          End If

          If txTotalSize.Text = 0 Then
               txTotalSize.BackColor = Color.Yellow
               Exit Sub
          Else
               txTotalSize.BackColor = DefaultBackColor
          End If

          If txTotalTons.Text = 0 Then
               txTotalTons.BackColor = Color.Yellow
               Exit Sub
          Else
               txTotalTons.BackColor = DefaultBackColor
          End If


          txAllowed.Text = x.smpCalc(txCatDay.Text, txDistance.Text)
          If Val(txTotalTons.Text) > Val(txAllowed.Text) Then
               'Exceeds
               txResults.Text = "This burn will exceed the guidelines."
               txResults.BackColor = Color.LightPink
          Else
               'Not Exceeds
               txResults.Text = "Burn is Good."
               txResults.BackColor = Color.White
          End If
          Expt()

          x.MultiLog("Fuels Log CSV File: " & MultiFileName & vbNewLine & "TME: " & sTime & vbNewLine & "Category Day: " & txCatDay.Text & vbNewLine & _
                     "Target Distance: " & txDistance.Text & vbNewLine & "Total Size: " & txTotalSize.Text & vbNewLine & "Total Tons: " & txTotalTons.Text & vbNewLine & "Results: " & txResults.Text)
     End Sub

     Function Chks(c As Control) As Boolean
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
     End Function

     Function Expt()
          Dim rdm As String = grs(5)
          Dim StrExport As String = ""
          For Each C As DataGridViewColumn In dgv.Columns
               StrExport &= """" & C.HeaderText & ""","
          Next
          StrExport = StrExport.Substring(0, StrExport.Length - 1)
          StrExport &= Environment.NewLine

          For Each R As DataGridViewRow In dgv.Rows
               For Each C As DataGridViewCell In R.Cells
                    If Not C.Value Is Nothing Then
                         StrExport &= """" & C.Value.ToString & ""","
                    Else
                         StrExport &= """" & "" & ""","
                    End If
               Next
               StrExport = StrExport.Substring(0, StrExport.Length - 1)
               StrExport &= Environment.NewLine
          Next

          Dim tw As IO.TextWriter = New IO.StreamWriter("C:\Smoke Calculator\MultiBurn_" & rdm & ".csv")
          tw.Write(StrExport)
          tw.Close()
          MultiFileName = "C:\Smoke Calculator\MultiBurn_" & rdm & ".csv"
          bbStatus.Text = MultiFileName

     End Function

     Function grs(ByRef length As Integer) As String
          Randomize()
          Dim ac As String
          ac = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
          Dim i As Integer
          For i = 1 To length
               grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
          Next
     End Function


End Class