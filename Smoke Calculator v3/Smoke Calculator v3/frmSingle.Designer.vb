<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSingle
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSingle))
          Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.txBurnSize = New System.Windows.Forms.TextBox()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.txCatDay = New System.Windows.Forms.TextBox()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.txDistance = New System.Windows.Forms.TextBox()
          Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label4 = New System.Windows.Forms.Label()
          Me.txFtype = New System.Windows.Forms.ComboBox()
          Me.Label5 = New System.Windows.Forms.Label()
          Me.txFload = New System.Windows.Forms.ComboBox()
          Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label6 = New System.Windows.Forms.Label()
          Me.Label7 = New System.Windows.Forms.Label()
          Me.Label8 = New System.Windows.Forms.Label()
          Me.txAvFuels = New System.Windows.Forms.Label()
          Me.txAllowed = New System.Windows.Forms.Label()
          Me.txTotalTons = New System.Windows.Forms.Label()
          Me.txResults = New System.Windows.Forms.TextBox()
          Me.txRec = New System.Windows.Forms.TextBox()
          Me.btnClear = New System.Windows.Forms.Button()
          Me.btnCalc = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
          Me.Label9 = New System.Windows.Forms.Label()
          Me.TableLayoutPanel1.SuspendLayout()
          Me.TableLayoutPanel2.SuspendLayout()
          Me.TableLayoutPanel3.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'TableLayoutPanel1
          '
          Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel1.ColumnCount = 2
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.txBurnSize, 1, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
          Me.TableLayoutPanel1.Controls.Add(Me.txCatDay, 1, 1)
          Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
          Me.TableLayoutPanel1.Controls.Add(Me.txDistance, 1, 2)
          Me.TableLayoutPanel1.Location = New System.Drawing.Point(222, 12)
          Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
          Me.TableLayoutPanel1.RowCount = 4
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
          Me.TableLayoutPanel1.Size = New System.Drawing.Size(199, 93)
          Me.TableLayoutPanel1.TabIndex = 0
          '
          'Label1
          '
          Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label1.AutoSize = True
          Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label1.Location = New System.Drawing.Point(51, 7)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(67, 17)
          Me.Label1.TabIndex = 3
          Me.Label1.Text = "BURN SIZE:"
          '
          'txBurnSize
          '
          Me.txBurnSize.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txBurnSize.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txBurnSize.Location = New System.Drawing.Point(126, 5)
          Me.txBurnSize.Name = "txBurnSize"
          Me.txBurnSize.Size = New System.Drawing.Size(62, 22)
          Me.txBurnSize.TabIndex = 0
          '
          'Label2
          '
          Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label2.AutoSize = True
          Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label2.Location = New System.Drawing.Point(16, 37)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(102, 17)
          Me.Label2.TabIndex = 4
          Me.Label2.Text = "CATEGORY DAY:"
          '
          'txCatDay
          '
          Me.txCatDay.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txCatDay.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txCatDay.Location = New System.Drawing.Point(126, 35)
          Me.txCatDay.Name = "txCatDay"
          Me.txCatDay.Size = New System.Drawing.Size(38, 22)
          Me.txCatDay.TabIndex = 1
          '
          'Label3
          '
          Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label3.AutoSize = True
          Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label3.Location = New System.Drawing.Point(5, 67)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(113, 17)
          Me.Label3.TabIndex = 5
          Me.Label3.Text = "TARGET DISTANCE:"
          '
          'txDistance
          '
          Me.txDistance.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txDistance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.txDistance.Location = New System.Drawing.Point(126, 65)
          Me.txDistance.Name = "txDistance"
          Me.txDistance.Size = New System.Drawing.Size(46, 22)
          Me.txDistance.TabIndex = 2
          '
          'TableLayoutPanel2
          '
          Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel2.ColumnCount = 2
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
          Me.TableLayoutPanel2.Controls.Add(Me.txFtype, 1, 0)
          Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
          Me.TableLayoutPanel2.Controls.Add(Me.txFload, 1, 1)
          Me.TableLayoutPanel2.Location = New System.Drawing.Point(221, 111)
          Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
          Me.TableLayoutPanel2.RowCount = 2
          Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel2.Size = New System.Drawing.Size(383, 66)
          Me.TableLayoutPanel2.TabIndex = 1
          '
          'Label4
          '
          Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label4.AutoSize = True
          Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label4.Location = New System.Drawing.Point(14, 7)
          Me.Label4.Name = "Label4"
          Me.Label4.Size = New System.Drawing.Size(65, 17)
          Me.Label4.TabIndex = 2
          Me.Label4.Text = "FUEL TYPE:"
          '
          'txFtype
          '
          Me.txFtype.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txFtype.FormattingEnabled = True
          Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
          Me.txFtype.Location = New System.Drawing.Point(87, 5)
          Me.txFtype.Name = "txFtype"
          Me.txFtype.Size = New System.Drawing.Size(239, 21)
          Me.txFtype.TabIndex = 0
          '
          'Label5
          '
          Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label5.AutoSize = True
          Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label5.Location = New System.Drawing.Point(5, 39)
          Me.Label5.Name = "Label5"
          Me.Label5.Size = New System.Drawing.Size(74, 17)
          Me.Label5.TabIndex = 3
          Me.Label5.Text = "FUEL LOAD:"
          '
          'txFload
          '
          Me.txFload.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txFload.FormattingEnabled = True
          Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
          Me.txFload.Location = New System.Drawing.Point(87, 37)
          Me.txFload.Name = "txFload"
          Me.txFload.Size = New System.Drawing.Size(121, 21)
          Me.txFload.TabIndex = 1
          '
          'TableLayoutPanel3
          '
          Me.TableLayoutPanel3.ColumnCount = 3
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
          Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.Label8, 2, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.txAvFuels, 0, 1)
          Me.TableLayoutPanel3.Controls.Add(Me.txAllowed, 1, 1)
          Me.TableLayoutPanel3.Controls.Add(Me.txTotalTons, 2, 1)
          Me.TableLayoutPanel3.Location = New System.Drawing.Point(222, 183)
          Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
          Me.TableLayoutPanel3.RowCount = 2
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel3.Size = New System.Drawing.Size(382, 30)
          Me.TableLayoutPanel3.TabIndex = 4
          '
          'Label6
          '
          Me.Label6.AutoSize = True
          Me.Label6.Location = New System.Drawing.Point(3, 0)
          Me.Label6.Name = "Label6"
          Me.Label6.Size = New System.Drawing.Size(101, 13)
          Me.Label6.TabIndex = 0
          Me.Label6.Text = "AVAILABLE FUELS"
          '
          'Label7
          '
          Me.Label7.AutoSize = True
          Me.Label7.Location = New System.Drawing.Point(130, 0)
          Me.Label7.Name = "Label7"
          Me.Label7.Size = New System.Drawing.Size(93, 13)
          Me.Label7.TabIndex = 1
          Me.Label7.Text = "ALLOWED TONS"
          '
          'Label8
          '
          Me.Label8.AutoSize = True
          Me.Label8.Location = New System.Drawing.Point(257, 0)
          Me.Label8.Name = "Label8"
          Me.Label8.Size = New System.Drawing.Size(75, 13)
          Me.Label8.TabIndex = 2
          Me.Label8.Text = "TOTAL TONS"
          '
          'txAvFuels
          '
          Me.txAvFuels.AutoSize = True
          Me.txAvFuels.Location = New System.Drawing.Point(3, 13)
          Me.txAvFuels.Name = "txAvFuels"
          Me.txAvFuels.Size = New System.Drawing.Size(13, 13)
          Me.txAvFuels.TabIndex = 3
          Me.txAvFuels.Text = "0"
          '
          'txAllowed
          '
          Me.txAllowed.AutoSize = True
          Me.txAllowed.Location = New System.Drawing.Point(130, 13)
          Me.txAllowed.Name = "txAllowed"
          Me.txAllowed.Size = New System.Drawing.Size(13, 13)
          Me.txAllowed.TabIndex = 4
          Me.txAllowed.Text = "0"
          '
          'txTotalTons
          '
          Me.txTotalTons.AutoSize = True
          Me.txTotalTons.Location = New System.Drawing.Point(257, 13)
          Me.txTotalTons.Name = "txTotalTons"
          Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
          Me.txTotalTons.TabIndex = 5
          Me.txTotalTons.Text = "0"
          '
          'txResults
          '
          Me.txResults.Location = New System.Drawing.Point(222, 219)
          Me.txResults.Name = "txResults"
          Me.txResults.Size = New System.Drawing.Size(382, 20)
          Me.txResults.TabIndex = 5
          '
          'txRec
          '
          Me.txRec.BackColor = System.Drawing.SystemColors.Control
          Me.txRec.Location = New System.Drawing.Point(222, 245)
          Me.txRec.Name = "txRec"
          Me.txRec.Size = New System.Drawing.Size(382, 20)
          Me.txRec.TabIndex = 6
          Me.txRec.Text = "Recommendations:"
          '
          'btnClear
          '
          Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnClear.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.weIMAGE072
          Me.btnClear.Location = New System.Drawing.Point(559, 27)
          Me.btnClear.Name = "btnClear"
          Me.btnClear.Size = New System.Drawing.Size(45, 36)
          Me.btnClear.TabIndex = 3
          Me.btnClear.UseVisualStyleBackColor = False
          '
          'btnCalc
          '
          Me.btnCalc.BackColor = System.Drawing.Color.White
          Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnCalc.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.Calculator_6_icon
          Me.btnCalc.Location = New System.Drawing.Point(472, 12)
          Me.btnCalc.Name = "btnCalc"
          Me.btnCalc.Size = New System.Drawing.Size(75, 67)
          Me.btnCalc.TabIndex = 2
          Me.btnCalc.UseVisualStyleBackColor = False
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.ShexLogoA2
          Me.PictureBox1.Location = New System.Drawing.Point(-88, -67)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(304, 260)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
          Me.PictureBox1.TabIndex = 0
          Me.PictureBox1.TabStop = False
          '
          'Timer1
          '
          '
          'Label9
          '
          Me.Label9.AutoSize = True
          Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.Label9.ForeColor = System.Drawing.SystemColors.AppWorkspace
          Me.Label9.Location = New System.Drawing.Point(0, 261)
          Me.Label9.Name = "Label9"
          Me.Label9.Size = New System.Drawing.Size(14, 16)
          Me.Label9.TabIndex = 7
          Me.Label9.Text = "0"
          '
          'frmSingle
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(616, 275)
          Me.Controls.Add(Me.Label9)
          Me.Controls.Add(Me.btnClear)
          Me.Controls.Add(Me.btnCalc)
          Me.Controls.Add(Me.txRec)
          Me.Controls.Add(Me.txResults)
          Me.Controls.Add(Me.TableLayoutPanel3)
          Me.Controls.Add(Me.TableLayoutPanel2)
          Me.Controls.Add(Me.TableLayoutPanel1)
          Me.Controls.Add(Me.PictureBox1)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Name = "frmSingle"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "frmSingle"
          Me.TableLayoutPanel1.ResumeLayout(False)
          Me.TableLayoutPanel1.PerformLayout()
          Me.TableLayoutPanel2.ResumeLayout(False)
          Me.TableLayoutPanel2.PerformLayout()
          Me.TableLayoutPanel3.ResumeLayout(False)
          Me.TableLayoutPanel3.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents txBurnSize As System.Windows.Forms.TextBox
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents txCatDay As System.Windows.Forms.TextBox
     Friend WithEvents Label3 As System.Windows.Forms.Label
     Friend WithEvents txDistance As System.Windows.Forms.TextBox
     Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label4 As System.Windows.Forms.Label
     Friend WithEvents txFtype As System.Windows.Forms.ComboBox
     Friend WithEvents Label5 As System.Windows.Forms.Label
     Friend WithEvents txFload As System.Windows.Forms.ComboBox
     Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label6 As System.Windows.Forms.Label
     Friend WithEvents Label7 As System.Windows.Forms.Label
     Friend WithEvents Label8 As System.Windows.Forms.Label
     Friend WithEvents txAvFuels As System.Windows.Forms.Label
     Friend WithEvents txAllowed As System.Windows.Forms.Label
     Friend WithEvents txTotalTons As System.Windows.Forms.Label
     Friend WithEvents txResults As System.Windows.Forms.TextBox
     Friend WithEvents txRec As System.Windows.Forms.TextBox
     Friend WithEvents btnCalc As System.Windows.Forms.Button
     Friend WithEvents btnClear As System.Windows.Forms.Button
     Friend WithEvents Timer1 As System.Windows.Forms.Timer
     Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
