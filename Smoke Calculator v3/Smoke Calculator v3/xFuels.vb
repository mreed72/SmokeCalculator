'©2019 Scott Reed

Public Class xFuels

     ''' <summary>
     ''' Smoke Calculation function
     ''' </summary>
     ''' <param name="xCatDay">INTEGER Category Day No Decimals must be 1 to 50</param>
     ''' <param name="xDistance">DOUBLE Target Distance in Miles Decimals okay</param>
     ''' <returns>INTEGER this number must be compared with the total tons to determine smoke mgmt results.</returns>
     ''' <remarks>Fixed Issues with error at exactly 20 miles distance.</remarks>
     Public Function smpCalc(ByRef xCatDay As Integer, ByRef xDistance As Double)
          Select Case xCatDay
               Case 1
                    Return 0
               Case 2
                    Select Case xDistance
                         Case 0 To 0.19
                              Return 0
                         Case 0.2 To 4.9
                              Return 488
                         Case 5 To 9.9
                              Return 1000
                         Case 10 To 19.9
                              Return 1840
                         Case Is > 19.9
                              Return 2880
                         Case Else
                              Return 0
                    End Select
               Case 3
                    Select Case xDistance
                         Case 0 To 0.19
                              Return 0
                         Case 0.2 To 4.9
                              Return 560
                         Case 5 To 9.9
                              Return 1200
                         Case 10 To 19.9
                              Return 2240
                         Case Is > 19.9
                              Return 3280
                         Case Else
                              Return 0
                    End Select
               Case 4
                    Select Case xDistance
                         Case 0 To 0.19
                              Return 0
                         Case 0.2 To 4.9
                              Return 720
                         Case 5 To 9.9
                              Return 1840
                         Case 10 To 19.9
                              Return 4200
                         Case Is > 19.9
                              Return 6400
                         Case Else
                              Return 0
                    End Select
               Case 5
                    Select Case xDistance
                         Case 0 To 0.19
                              Return 0
                         Case 0.2 To 4.9
                              Return 1280
                         Case 5 To 9.9
                              Return 3200
                         Case 10 To 19.9
                              Return 7200
                         Case Is > 19.9
                              Return 11600
                         Case Else
                              Return 0
                    End Select
               Case Else
                    Return 0
          End Select
     End Function

     ''' <summary>
     ''' Determine available fuels
     ''' </summary>
     ''' <param name="cTypx">STRING this is the fuel type selected by the user</param>
     ''' <param name="cLoad">STRING this is the fuel loading selected by the user</param>
     ''' <returns>DOUBLE this value is multiplied by the burn size to determine the total tons for the burn </returns>
     ''' <remarks></remarks>
     Public Function GetAvailableFuels(ByVal cTypx As String, ByVal cLoad As String)
          Select Case cTypx
               Case "Shortleaf Pine with Oak"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 3.0
                         Case Is = "Moderate"
                              Return 4.0
                         Case Is = "Heavy"
                              Return 4.4
                         Case Else
                              Return 0
                    End Select
               Case "Shortleaf Pine Regeneration"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 2.6
                         Case Is = "Moderate"
                              Return 3.8
                         Case Is = "Heavy"
                              Return 5.1
                         Case Else
                              Return 0
                    End Select
               Case "Loblolly Pine with Oak"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 6.4
                         Case Is = "Moderate"
                              Return 6.8
                         Case Is = "Heavy"
                              Return 7.9
                         Case Else
                              Return 0
                    End Select
               Case "Loblolly Pine Regeneration"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 4.4
                         Case Is = "Moderate"
                              Return 7.6
                         Case Is = "Heavy"
                              Return 8.5
                         Case Else
                              Return 0
                    End Select
               Case "Hardwood Leaf Litter"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 0.8
                         Case Is = "Moderate"
                              Return 1.5
                         Case Is = "Heavy"
                              Return 2.5
                         Case Else
                              Return 0
                    End Select
               Case "Grass or Brush"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 2.0
                         Case Is = "Moderate"
                              Return 3.0
                         Case Is = "Heavy"
                              Return 5.0
                         Case Else
                              Return 0
                    End Select
               Case "Dispersed Slash"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 4.0
                         Case Is = "Moderate"
                              Return 6.0
                         Case Is = "Heavy"
                              Return 8.0
                         Case Else
                              Return 0
                    End Select
               Case "Piled Debris"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 5.0
                         Case Is = "Moderate"
                              Return 7.5
                         Case Is = "Heavy"
                              Return 10.0
                         Case Else
                              Return 0
                    End Select
               Case "Shortleaf Loblolly with Grass"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 1.5
                         Case Is = "Moderate"
                              Return 3.8
                         Case Is = "Heavy"
                              Return 5.9
                         Case Else
                              Return 0
                    End Select
               Case "Corn"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 3.1
                         Case Is = "Moderate"
                              Return 4.7
                         Case Is = "Heavy"
                              Return 6.2
                         Case Else
                              Return 0
                    End Select
               Case "Cotton"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 0.8
                         Case Is = "Moderate"
                              Return 1.1
                         Case Is = "Heavy"
                              Return 1.5
                         Case Else
                              Return 0
                    End Select
               Case "Rice"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 2.5
                         Case Is = "Moderate"
                              Return 3.7
                         Case Is = "Heavy"
                              Return 4.9
                         Case Else
                              Return 0
                    End Select
               Case "Soybean"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 2.9
                         Case Is = "Moderate"
                              Return 4.3
                         Case Is = "Heavy"
                              Return 5.7
                         Case Else
                              Return 0
                    End Select
               Case "Wheat"
                    Select Case cLoad
                         Case Is = "Low"
                              Return 0.9
                         Case Is = "Moderate"
                              Return 1.4
                         Case Is = "Heavy"
                              Return 1.9
                         Case Else
                              Return 0
                    End Select
               Case Else
                    Return 0
          End Select
     End Function

     Public Function CheckLogFiles()
          Dim xLG As String = "C:\Smoke Calculator\"
          Dim sLG As String = "C:\Smoke Calculator\slog.txt"
          Dim mLG As String = "C:\Smoke Calculator\mlog.txt"
          Dim eLG As String = "C:\Smoke Calculator\elog.txt"
          Dim d1, d2, d3, dx As Boolean
          dx = My.Computer.FileSystem.DirectoryExists(xlg)
          d1 = My.Computer.FileSystem.FileExists(sLG)
          d2 = My.Computer.FileSystem.FileExists(mLG)
          d3 = My.Computer.FileSystem.FileExists(eLG)
          If dx = False Then
               My.Computer.FileSystem.CreateDirectory(xLG)
          End If
          If d1 = False Then
               My.Computer.FileSystem.WriteAllText(sLG, "", False)
          End If
          If d2 = False Then
               My.Computer.FileSystem.WriteAllText(mLG, "", False)
          End If
          If d3 = False Then
               My.Computer.FileSystem.WriteAllText(eLG, "", False)
          End If
     End Function

    Public Function SessionLog(msg As String)
          CheckLogFiles()

          Dim myfile As String = "C:\Smoke Calculator\slog.txt"
          Dim itxt As New TextBox
          If IO.File.Exists(myfile) Then
               itxt.Text = IO.File.ReadAllText(myfile)
          End If
          Dim vt As String = vbCrLf & Date.Now & " - SINGLE FUELS - " & vbNewLine & msg & vbNewLine & "---------------------------" & itxt.Text
          My.Computer.FileSystem.WriteAllText(myfile, vt, False)
          itxt.Clear()
     End Function

     Public Function MultiLog(msg As String)
          CheckLogFiles()

          Dim myfile As String = "C:\Smoke Calculator\mlog.txt"
          Dim itxt As New TextBox
          If IO.File.Exists(myfile) Then
               itxt.Text = IO.File.ReadAllText(myfile)
          End If
          Dim vt As String = vbCrLf & Date.Now & " - MULTI FUELS - " & vbNewLine & msg & vbNewLine & "---------------------------" & itxt.Text
          My.Computer.FileSystem.WriteAllText(myfile, vt, False)
          itxt.Clear()
     End Function

     Public Function ErrorLog(code As String, msg As String)
          CheckLogFiles()

          Dim myfile As String = "C:\Smoke Calculator\elog.txt"
          Dim itxt As New TextBox
          If IO.File.Exists(myfile) Then
               itxt.Text = IO.File.ReadAllText(myfile)
          End If
          Dim vt As String = vbCrLf & Date.Now & " ---ERROR--- " & code & vbNewLine & msg & vbNewLine & "---------------------------" & itxt.Text
          My.Computer.FileSystem.WriteAllText(myfile, vt, False)
          itxt.Clear()
     End Function


End Class
