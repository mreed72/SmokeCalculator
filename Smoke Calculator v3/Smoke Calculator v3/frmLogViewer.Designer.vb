<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
          Me.components = New System.ComponentModel.Container()
          Me.rtb = New System.Windows.Forms.RichTextBox()
          Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
          Me.Button1 = New System.Windows.Forms.Button()
          Me.Button2 = New System.Windows.Forms.Button()
          Me.Button3 = New System.Windows.Forms.Button()
          Me.Button5 = New System.Windows.Forms.Button()
          Me.Button6 = New System.Windows.Forms.Button()
          Me.Button4 = New System.Windows.Forms.Button()
          Me.bLogName = New System.Windows.Forms.Label()
          Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
          Me.TableLayoutPanel1.SuspendLayout()
          Me.SuspendLayout()
          '
          'rtb
          '
          Me.rtb.Dock = System.Windows.Forms.DockStyle.Bottom
          Me.rtb.Location = New System.Drawing.Point(0, 102)
          Me.rtb.Name = "rtb"
          Me.rtb.ReadOnly = True
          Me.rtb.Size = New System.Drawing.Size(547, 431)
          Me.rtb.TabIndex = 0
          Me.rtb.Text = ""
          '
          'TableLayoutPanel1
          '
          Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel1.ColumnCount = 3
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
          Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Button5, 0, 1)
          Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
          Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
          Me.TableLayoutPanel1.RowCount = 2
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel1.Size = New System.Drawing.Size(358, 65)
          Me.TableLayoutPanel1.TabIndex = 1
          '
          'Button1
          '
          Me.Button1.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p16_00188
          Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
          Me.Button1.Location = New System.Drawing.Point(5, 5)
          Me.Button1.Name = "Button1"
          Me.Button1.Size = New System.Drawing.Size(110, 23)
          Me.Button1.TabIndex = 0
          Me.Button1.Text = "Single Log"
          Me.ToolTip1.SetToolTip(Me.Button1, "Single Fuels Calculator Log Files")
          Me.Button1.UseVisualStyleBackColor = True
          '
          'Button2
          '
          Me.Button2.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p16_00255
          Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
          Me.Button2.Location = New System.Drawing.Point(123, 5)
          Me.Button2.Name = "Button2"
          Me.Button2.Size = New System.Drawing.Size(110, 23)
          Me.Button2.TabIndex = 1
          Me.Button2.Text = "Multiple Log"
          Me.ToolTip1.SetToolTip(Me.Button2, "Multiple Fuels Calculator Log Files")
          Me.Button2.UseVisualStyleBackColor = True
          '
          'Button3
          '
          Me.Button3.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p16_00426
          Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
          Me.Button3.Location = New System.Drawing.Point(241, 5)
          Me.Button3.Name = "Button3"
          Me.Button3.Size = New System.Drawing.Size(112, 23)
          Me.Button3.TabIndex = 2
          Me.Button3.Text = "Error Log"
          Me.ToolTip1.SetToolTip(Me.Button3, "Error Log")
          Me.Button3.UseVisualStyleBackColor = True
          '
          'Button5
          '
          Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.TableLayoutPanel1.SetColumnSpan(Me.Button5, 3)
          Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.Button5.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p3200015
          Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
          Me.Button5.Location = New System.Drawing.Point(5, 36)
          Me.Button5.Name = "Button5"
          Me.Button5.Size = New System.Drawing.Size(348, 23)
          Me.Button5.TabIndex = 3
          Me.Button5.Text = "CLEAR ALL LOGS"
          Me.ToolTip1.SetToolTip(Me.Button5, "CLEAR ALL LOG FILES")
          Me.Button5.UseVisualStyleBackColor = False
          '
          'Button6
          '
          Me.Button6.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.weIMAGE086
          Me.Button6.Location = New System.Drawing.Point(460, 12)
          Me.Button6.Name = "Button6"
          Me.Button6.Size = New System.Drawing.Size(75, 79)
          Me.Button6.TabIndex = 3
          Me.ToolTip1.SetToolTip(Me.Button6, "This will export the currently open log to an RTF")
          Me.Button6.UseVisualStyleBackColor = True
          '
          'Button4
          '
          Me.Button4.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p24_00079
          Me.Button4.Location = New System.Drawing.Point(376, 17)
          Me.Button4.Name = "Button4"
          Me.Button4.Size = New System.Drawing.Size(32, 23)
          Me.Button4.TabIndex = 2
          Me.ToolTip1.SetToolTip(Me.Button4, "Open the Log Folder")
          Me.Button4.UseVisualStyleBackColor = True
          '
          'bLogName
          '
          Me.bLogName.AutoSize = True
          Me.bLogName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.bLogName.ForeColor = System.Drawing.SystemColors.AppWorkspace
          Me.bLogName.Location = New System.Drawing.Point(12, 80)
          Me.bLogName.Name = "bLogName"
          Me.bLogName.Size = New System.Drawing.Size(28, 17)
          Me.bLogName.TabIndex = 4
          Me.bLogName.Text = "null"
          '
          'ToolTip1
          '
          Me.ToolTip1.IsBalloon = True
          Me.ToolTip1.ShowAlways = True
          Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
          '
          'frmLogViewer
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(547, 533)
          Me.Controls.Add(Me.bLogName)
          Me.Controls.Add(Me.Button6)
          Me.Controls.Add(Me.Button4)
          Me.Controls.Add(Me.TableLayoutPanel1)
          Me.Controls.Add(Me.rtb)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
          Me.Name = "frmLogViewer"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "Log Viewer"
          Me.TableLayoutPanel1.ResumeLayout(False)
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents rtb As System.Windows.Forms.RichTextBox
     Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Button1 As System.Windows.Forms.Button
     Friend WithEvents Button2 As System.Windows.Forms.Button
     Friend WithEvents Button3 As System.Windows.Forms.Button
     Friend WithEvents Button4 As System.Windows.Forms.Button
     Friend WithEvents Button5 As System.Windows.Forms.Button
     Friend WithEvents Button6 As System.Windows.Forms.Button
     Friend WithEvents bLogName As System.Windows.Forms.Label
     Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
