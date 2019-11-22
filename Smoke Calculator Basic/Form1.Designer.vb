<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
          Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.txBurnSize = New System.Windows.Forms.TextBox()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.txCatDay = New System.Windows.Forms.TextBox()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.txDistance = New System.Windows.Forms.TextBox()
          Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label4 = New System.Windows.Forms.Label()
          Me.Label5 = New System.Windows.Forms.Label()
          Me.txFtype = New System.Windows.Forms.ComboBox()
          Me.txFload = New System.Windows.Forms.ComboBox()
          Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label6 = New System.Windows.Forms.Label()
          Me.txAvFuels = New System.Windows.Forms.Label()
          Me.Label8 = New System.Windows.Forms.Label()
          Me.txAllowed = New System.Windows.Forms.Label()
          Me.Label10 = New System.Windows.Forms.Label()
          Me.txTotalTons = New System.Windows.Forms.Label()
          Me.Label7 = New System.Windows.Forms.Label()
          Me.txResults = New System.Windows.Forms.TextBox()
          Me.txRecommend = New System.Windows.Forms.TextBox()
          Me.Label9 = New System.Windows.Forms.Label()
          Me.Panel1 = New System.Windows.Forms.Panel()
          Me.btnCalc = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.btnClear = New System.Windows.Forms.Button()
          Me.TableLayoutPanel1.SuspendLayout()
          Me.TableLayoutPanel2.SuspendLayout()
          Me.TableLayoutPanel3.SuspendLayout()
          Me.Panel1.SuspendLayout()
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
          Me.TableLayoutPanel1.Location = New System.Drawing.Point(118, 11)
          Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
          Me.TableLayoutPanel1.RowCount = 3
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 86)
          Me.TableLayoutPanel1.TabIndex = 0
          '
          'Label1
          '
          Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(36, 8)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(55, 13)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Burn Size:"
          '
          'txBurnSize
          '
          Me.txBurnSize.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txBurnSize.Location = New System.Drawing.Point(99, 5)
          Me.txBurnSize.Name = "txBurnSize"
          Me.txBurnSize.Size = New System.Drawing.Size(59, 20)
          Me.txBurnSize.TabIndex = 0
          '
          'Label2
          '
          Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(17, 36)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(74, 13)
          Me.Label2.TabIndex = 2
          Me.Label2.Text = "Category Day:"
          '
          'txCatDay
          '
          Me.txCatDay.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txCatDay.Location = New System.Drawing.Point(99, 33)
          Me.txCatDay.Name = "txCatDay"
          Me.txCatDay.Size = New System.Drawing.Size(30, 20)
          Me.txCatDay.TabIndex = 1
          '
          'Label3
          '
          Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label3.AutoSize = True
          Me.Label3.Location = New System.Drawing.Point(5, 64)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(86, 13)
          Me.Label3.TabIndex = 4
          Me.Label3.Text = "Target Distance:"
          '
          'txDistance
          '
          Me.txDistance.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txDistance.Location = New System.Drawing.Point(99, 61)
          Me.txDistance.Name = "txDistance"
          Me.txDistance.Size = New System.Drawing.Size(30, 20)
          Me.txDistance.TabIndex = 2
          '
          'TableLayoutPanel2
          '
          Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel2.ColumnCount = 2
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.68974!))
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31026!))
          Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
          Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 0)
          Me.TableLayoutPanel2.Controls.Add(Me.txFtype, 0, 1)
          Me.TableLayoutPanel2.Controls.Add(Me.txFload, 1, 1)
          Me.TableLayoutPanel2.Location = New System.Drawing.Point(118, 103)
          Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
          Me.TableLayoutPanel2.RowCount = 2
          Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel2.Size = New System.Drawing.Size(419, 49)
          Me.TableLayoutPanel2.TabIndex = 1
          '
          'Label4
          '
          Me.Label4.AutoSize = True
          Me.Label4.Location = New System.Drawing.Point(5, 2)
          Me.Label4.Name = "Label4"
          Me.Label4.Size = New System.Drawing.Size(57, 13)
          Me.Label4.TabIndex = 0
          Me.Label4.Text = "Fuel Type:"
          '
          'Label5
          '
          Me.Label5.AutoSize = True
          Me.Label5.Location = New System.Drawing.Point(294, 2)
          Me.Label5.Name = "Label5"
          Me.Label5.Size = New System.Drawing.Size(57, 13)
          Me.Label5.TabIndex = 1
          Me.Label5.Text = "Fuel Load:"
          '
          'txFtype
          '
          Me.txFtype.FormattingEnabled = True
          Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
          Me.txFtype.Location = New System.Drawing.Point(5, 20)
          Me.txFtype.Name = "txFtype"
          Me.txFtype.Size = New System.Drawing.Size(275, 21)
          Me.txFtype.TabIndex = 0
          '
          'txFload
          '
          Me.txFload.FormattingEnabled = True
          Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
          Me.txFload.Location = New System.Drawing.Point(294, 20)
          Me.txFload.Name = "txFload"
          Me.txFload.Size = New System.Drawing.Size(120, 21)
          Me.txFload.TabIndex = 1
          '
          'TableLayoutPanel3
          '
          Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel3.ColumnCount = 2
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.5!))
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5!))
          Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.txAvFuels, 1, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
          Me.TableLayoutPanel3.Controls.Add(Me.txAllowed, 1, 1)
          Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 2)
          Me.TableLayoutPanel3.Controls.Add(Me.txTotalTons, 1, 2)
          Me.TableLayoutPanel3.Location = New System.Drawing.Point(324, 11)
          Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
          Me.TableLayoutPanel3.RowCount = 3
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
          Me.TableLayoutPanel3.Size = New System.Drawing.Size(213, 86)
          Me.TableLayoutPanel3.TabIndex = 3
          '
          'Label6
          '
          Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label6.AutoSize = True
          Me.Label6.Location = New System.Drawing.Point(53, 10)
          Me.Label6.Name = "Label6"
          Me.Label6.Size = New System.Drawing.Size(81, 13)
          Me.Label6.TabIndex = 0
          Me.Label6.Text = "Available Fuels:"
          '
          'txAvFuels
          '
          Me.txAvFuels.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txAvFuels.AutoSize = True
          Me.txAvFuels.Location = New System.Drawing.Point(142, 10)
          Me.txAvFuels.Name = "txAvFuels"
          Me.txAvFuels.Size = New System.Drawing.Size(13, 13)
          Me.txAvFuels.TabIndex = 0
          Me.txAvFuels.Text = "0"
          '
          'Label8
          '
          Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label8.AutoSize = True
          Me.Label8.Location = New System.Drawing.Point(59, 41)
          Me.Label8.Name = "Label8"
          Me.Label8.Size = New System.Drawing.Size(75, 13)
          Me.Label8.TabIndex = 2
          Me.Label8.Text = "Allowed Fuels:"
          '
          'txAllowed
          '
          Me.txAllowed.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txAllowed.AutoSize = True
          Me.txAllowed.Location = New System.Drawing.Point(142, 41)
          Me.txAllowed.Name = "txAllowed"
          Me.txAllowed.Size = New System.Drawing.Size(13, 13)
          Me.txAllowed.TabIndex = 1
          Me.txAllowed.Text = "0"
          '
          'Label10
          '
          Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label10.AutoSize = True
          Me.Label10.Location = New System.Drawing.Point(73, 67)
          Me.Label10.Name = "Label10"
          Me.Label10.Size = New System.Drawing.Size(61, 13)
          Me.Label10.TabIndex = 4
          Me.Label10.Text = "Total Tons:"
          '
          'txTotalTons
          '
          Me.txTotalTons.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txTotalTons.AutoSize = True
          Me.txTotalTons.Location = New System.Drawing.Point(142, 67)
          Me.txTotalTons.Name = "txTotalTons"
          Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
          Me.txTotalTons.TabIndex = 2
          Me.txTotalTons.Text = "0"
          '
          'Label7
          '
          Me.Label7.AutoSize = True
          Me.Label7.Location = New System.Drawing.Point(115, 174)
          Me.Label7.Name = "Label7"
          Me.Label7.Size = New System.Drawing.Size(45, 13)
          Me.Label7.TabIndex = 4
          Me.Label7.Text = "Results:"
          '
          'txResults
          '
          Me.txResults.BackColor = System.Drawing.SystemColors.Control
          Me.txResults.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.txResults.Location = New System.Drawing.Point(118, 190)
          Me.txResults.Name = "txResults"
          Me.txResults.Size = New System.Drawing.Size(419, 13)
          Me.txResults.TabIndex = 4
          Me.txResults.TabStop = False
          '
          'txRecommend
          '
          Me.txRecommend.BackColor = System.Drawing.SystemColors.Control
          Me.txRecommend.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.txRecommend.Location = New System.Drawing.Point(118, 247)
          Me.txRecommend.Name = "txRecommend"
          Me.txRecommend.Size = New System.Drawing.Size(419, 13)
          Me.txRecommend.TabIndex = 5
          Me.txRecommend.TabStop = False
          '
          'Label9
          '
          Me.Label9.AutoSize = True
          Me.Label9.Location = New System.Drawing.Point(115, 231)
          Me.Label9.Name = "Label9"
          Me.Label9.Size = New System.Drawing.Size(95, 13)
          Me.Label9.TabIndex = 6
          Me.Label9.Text = "Recommendations"
          '
          'Panel1
          '
          Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
          Me.Panel1.BackgroundImage = Global.Smoke_Calculator_Basic.My.Resources.Resources.PNG_IMAGE_096
          Me.Panel1.Controls.Add(Me.btnCalc)
          Me.Panel1.Controls.Add(Me.PictureBox1)
          Me.Panel1.Controls.Add(Me.btnClear)
          Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
          Me.Panel1.Location = New System.Drawing.Point(0, 0)
          Me.Panel1.Name = "Panel1"
          Me.Panel1.Size = New System.Drawing.Size(112, 295)
          Me.Panel1.TabIndex = 2
          '
          'btnCalc
          '
          Me.btnCalc.BackColor = System.Drawing.Color.White
          Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnCalc.Location = New System.Drawing.Point(12, 229)
          Me.btnCalc.Name = "btnCalc"
          Me.btnCalc.Size = New System.Drawing.Size(89, 23)
          Me.btnCalc.TabIndex = 0
          Me.btnCalc.Text = "CALCULATE"
          Me.btnCalc.UseVisualStyleBackColor = False
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.Smoke_Calculator_Basic.My.Resources.Resources._099
          Me.PictureBox1.Location = New System.Drawing.Point(24, 11)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(65, 68)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
          Me.PictureBox1.TabIndex = 1
          Me.PictureBox1.TabStop = False
          '
          'btnClear
          '
          Me.btnClear.BackColor = System.Drawing.Color.White
          Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnClear.Location = New System.Drawing.Point(12, 258)
          Me.btnClear.Name = "btnClear"
          Me.btnClear.Size = New System.Drawing.Size(89, 23)
          Me.btnClear.TabIndex = 1
          Me.btnClear.Text = "CLEAR"
          Me.btnClear.UseVisualStyleBackColor = False
          '
          'Form1
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(549, 295)
          Me.Controls.Add(Me.txRecommend)
          Me.Controls.Add(Me.Label9)
          Me.Controls.Add(Me.txResults)
          Me.Controls.Add(Me.Label7)
          Me.Controls.Add(Me.TableLayoutPanel3)
          Me.Controls.Add(Me.TableLayoutPanel2)
          Me.Controls.Add(Me.TableLayoutPanel1)
          Me.Controls.Add(Me.Panel1)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Name = "Form1"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "Form1"
          Me.TableLayoutPanel1.ResumeLayout(False)
          Me.TableLayoutPanel1.PerformLayout()
          Me.TableLayoutPanel2.ResumeLayout(False)
          Me.TableLayoutPanel2.PerformLayout()
          Me.TableLayoutPanel3.ResumeLayout(False)
          Me.TableLayoutPanel3.PerformLayout()
          Me.Panel1.ResumeLayout(False)
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents btnCalc As System.Windows.Forms.Button
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents btnClear As System.Windows.Forms.Button
     Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents txBurnSize As System.Windows.Forms.TextBox
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents txCatDay As System.Windows.Forms.TextBox
     Friend WithEvents Label3 As System.Windows.Forms.Label
     Friend WithEvents txDistance As System.Windows.Forms.TextBox
     Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label4 As System.Windows.Forms.Label
     Friend WithEvents Label5 As System.Windows.Forms.Label
     Friend WithEvents txFtype As System.Windows.Forms.ComboBox
     Friend WithEvents txFload As System.Windows.Forms.ComboBox
     Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label6 As System.Windows.Forms.Label
     Friend WithEvents txAvFuels As System.Windows.Forms.Label
     Friend WithEvents Label8 As System.Windows.Forms.Label
     Friend WithEvents txAllowed As System.Windows.Forms.Label
     Friend WithEvents Label10 As System.Windows.Forms.Label
     Friend WithEvents txTotalTons As System.Windows.Forms.Label
     Friend WithEvents Label7 As System.Windows.Forms.Label
     Friend WithEvents txResults As System.Windows.Forms.TextBox
     Friend WithEvents txRecommend As System.Windows.Forms.TextBox
     Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
