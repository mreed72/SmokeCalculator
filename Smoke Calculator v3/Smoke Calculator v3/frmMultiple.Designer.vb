<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiple
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
          Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiple))
          Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
          Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.Label3 = New System.Windows.Forms.Label()
          Me.txBlkSize = New System.Windows.Forms.TextBox()
          Me.txFtype = New System.Windows.Forms.ComboBox()
          Me.txFload = New System.Windows.Forms.ComboBox()
          Me.btnAdd = New System.Windows.Forms.Button()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.dgv = New System.Windows.Forms.DataGridView()
          Me.bkSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.ftype = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.fload = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.avFuels = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.ttons = New System.Windows.Forms.DataGridViewTextBoxColumn()
          Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
          Me.txAllowed = New System.Windows.Forms.Label()
          Me.Label6 = New System.Windows.Forms.Label()
          Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label8 = New System.Windows.Forms.Label()
          Me.txTotalTons = New System.Windows.Forms.Label()
          Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label4 = New System.Windows.Forms.Label()
          Me.txTotalSize = New System.Windows.Forms.Label()
          Me.txResults = New System.Windows.Forms.TextBox()
          Me.btnClear = New System.Windows.Forms.Button()
          Me.btnCalc = New System.Windows.Forms.Button()
          Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label5 = New System.Windows.Forms.Label()
          Me.txCatDay = New System.Windows.Forms.TextBox()
          Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
          Me.Label7 = New System.Windows.Forms.Label()
          Me.txDistance = New System.Windows.Forms.TextBox()
          Me.bbStatus = New System.Windows.Forms.TextBox()
          Me.TableLayoutPanel1.SuspendLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.TableLayoutPanel3.SuspendLayout()
          Me.TableLayoutPanel4.SuspendLayout()
          Me.TableLayoutPanel2.SuspendLayout()
          Me.TableLayoutPanel5.SuspendLayout()
          Me.TableLayoutPanel6.SuspendLayout()
          Me.SuspendLayout()
          '
          'Timer1
          '
          '
          'TableLayoutPanel1
          '
          Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel1.ColumnCount = 3
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
          Me.TableLayoutPanel1.Controls.Add(Me.txBlkSize, 0, 1)
          Me.TableLayoutPanel1.Controls.Add(Me.txFtype, 1, 1)
          Me.TableLayoutPanel1.Controls.Add(Me.txFload, 2, 1)
          Me.TableLayoutPanel1.Location = New System.Drawing.Point(222, 2)
          Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
          Me.TableLayoutPanel1.RowCount = 2
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
          Me.TableLayoutPanel1.Size = New System.Drawing.Size(473, 50)
          Me.TableLayoutPanel1.TabIndex = 0
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(5, 2)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(60, 13)
          Me.Label1.TabIndex = 0
          Me.Label1.Text = "Block Size:"
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(73, 2)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(87, 13)
          Me.Label2.TabIndex = 1
          Me.Label2.Text = "Block Fuel Type:"
          '
          'Label3
          '
          Me.Label3.AutoSize = True
          Me.Label3.Location = New System.Drawing.Point(351, 2)
          Me.Label3.Name = "Label3"
          Me.Label3.Size = New System.Drawing.Size(87, 13)
          Me.Label3.TabIndex = 2
          Me.Label3.Text = "Block Fuel Load:"
          '
          'txBlkSize
          '
          Me.txBlkSize.Location = New System.Drawing.Point(5, 20)
          Me.txBlkSize.Name = "txBlkSize"
          Me.txBlkSize.Size = New System.Drawing.Size(60, 20)
          Me.txBlkSize.TabIndex = 0
          '
          'txFtype
          '
          Me.txFtype.FormattingEnabled = True
          Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
          Me.txFtype.Location = New System.Drawing.Point(73, 20)
          Me.txFtype.Name = "txFtype"
          Me.txFtype.Size = New System.Drawing.Size(270, 21)
          Me.txFtype.TabIndex = 1
          '
          'txFload
          '
          Me.txFload.FormattingEnabled = True
          Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
          Me.txFload.Location = New System.Drawing.Point(351, 20)
          Me.txFload.Name = "txFload"
          Me.txFload.Size = New System.Drawing.Size(111, 21)
          Me.txFload.TabIndex = 2
          '
          'btnAdd
          '
          Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnAdd.Image = Global.Smoke_Calculator_v3.My.Resources.Resources._018489
          Me.btnAdd.Location = New System.Drawing.Point(701, 4)
          Me.btnAdd.Name = "btnAdd"
          Me.btnAdd.Size = New System.Drawing.Size(39, 44)
          Me.btnAdd.TabIndex = 1
          Me.btnAdd.UseVisualStyleBackColor = False
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.ShexLogoA2
          Me.PictureBox1.Location = New System.Drawing.Point(-88, -67)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(304, 260)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
          Me.PictureBox1.TabIndex = 1
          Me.PictureBox1.TabStop = False
          '
          'dgv
          '
          Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
          Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
          Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
          Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bkSize, Me.ftype, Me.fload, Me.avFuels, Me.ttons})
          Me.dgv.Location = New System.Drawing.Point(222, 104)
          Me.dgv.Name = "dgv"
          Me.dgv.ReadOnly = True
          Me.dgv.Size = New System.Drawing.Size(518, 150)
          Me.dgv.TabIndex = 6
          Me.dgv.TabStop = False
          '
          'bkSize
          '
          Me.bkSize.HeaderText = "Blk Size"
          Me.bkSize.Name = "bkSize"
          Me.bkSize.ReadOnly = True
          '
          'ftype
          '
          Me.ftype.HeaderText = "Fuel Type"
          Me.ftype.Name = "ftype"
          Me.ftype.ReadOnly = True
          '
          'fload
          '
          Me.fload.HeaderText = "Fuel Load"
          Me.fload.Name = "fload"
          Me.fload.ReadOnly = True
          '
          'avFuels
          '
          Me.avFuels.HeaderText = "Available Fuels"
          Me.avFuels.Name = "avFuels"
          Me.avFuels.ReadOnly = True
          '
          'ttons
          '
          Me.ttons.HeaderText = "Total Tons"
          Me.ttons.Name = "ttons"
          Me.ttons.ReadOnly = True
          '
          'TableLayoutPanel3
          '
          Me.TableLayoutPanel3.ColumnCount = 2
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel3.Controls.Add(Me.txAllowed, 1, 0)
          Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
          Me.TableLayoutPanel3.Location = New System.Drawing.Point(401, 260)
          Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
          Me.TableLayoutPanel3.RowCount = 1
          Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel3.Size = New System.Drawing.Size(126, 14)
          Me.TableLayoutPanel3.TabIndex = 6
          '
          'txAllowed
          '
          Me.txAllowed.AutoSize = True
          Me.txAllowed.Location = New System.Drawing.Point(84, 0)
          Me.txAllowed.Name = "txAllowed"
          Me.txAllowed.Size = New System.Drawing.Size(13, 13)
          Me.txAllowed.TabIndex = 0
          Me.txAllowed.Text = "0"
          '
          'Label6
          '
          Me.Label6.AutoSize = True
          Me.Label6.Location = New System.Drawing.Point(3, 0)
          Me.Label6.Name = "Label6"
          Me.Label6.Size = New System.Drawing.Size(75, 13)
          Me.Label6.TabIndex = 0
          Me.Label6.Text = "Allowed Fuels:"
          '
          'TableLayoutPanel4
          '
          Me.TableLayoutPanel4.ColumnCount = 2
          Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 0)
          Me.TableLayoutPanel4.Controls.Add(Me.txTotalTons, 1, 0)
          Me.TableLayoutPanel4.Location = New System.Drawing.Point(604, 260)
          Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
          Me.TableLayoutPanel4.RowCount = 1
          Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel4.Size = New System.Drawing.Size(133, 16)
          Me.TableLayoutPanel4.TabIndex = 7
          '
          'Label8
          '
          Me.Label8.AutoSize = True
          Me.Label8.Location = New System.Drawing.Point(3, 0)
          Me.Label8.Name = "Label8"
          Me.Label8.Size = New System.Drawing.Size(61, 13)
          Me.Label8.TabIndex = 0
          Me.Label8.Text = "Total Tons:"
          '
          'txTotalTons
          '
          Me.txTotalTons.AutoSize = True
          Me.txTotalTons.Location = New System.Drawing.Point(70, 0)
          Me.txTotalTons.Name = "txTotalTons"
          Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
          Me.txTotalTons.TabIndex = 0
          Me.txTotalTons.Text = "0"
          '
          'TableLayoutPanel2
          '
          Me.TableLayoutPanel2.ColumnCount = 2
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
          Me.TableLayoutPanel2.Controls.Add(Me.txTotalSize, 1, 0)
          Me.TableLayoutPanel2.Location = New System.Drawing.Point(222, 260)
          Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
          Me.TableLayoutPanel2.RowCount = 1
          Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel2.Size = New System.Drawing.Size(146, 14)
          Me.TableLayoutPanel2.TabIndex = 5
          '
          'Label4
          '
          Me.Label4.AutoSize = True
          Me.Label4.Location = New System.Drawing.Point(3, 0)
          Me.Label4.Name = "Label4"
          Me.Label4.Size = New System.Drawing.Size(82, 13)
          Me.Label4.TabIndex = 0
          Me.Label4.Text = "Total Burn Size:"
          '
          'txTotalSize
          '
          Me.txTotalSize.AutoSize = True
          Me.txTotalSize.Location = New System.Drawing.Point(91, 0)
          Me.txTotalSize.Name = "txTotalSize"
          Me.txTotalSize.Size = New System.Drawing.Size(13, 13)
          Me.txTotalSize.TabIndex = 0
          Me.txTotalSize.Text = "0"
          '
          'txResults
          '
          Me.txResults.Location = New System.Drawing.Point(222, 282)
          Me.txResults.Name = "txResults"
          Me.txResults.Size = New System.Drawing.Size(518, 20)
          Me.txResults.TabIndex = 7
          '
          'btnClear
          '
          Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
          Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnClear.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.weIMAGE072
          Me.btnClear.Location = New System.Drawing.Point(90, 266)
          Me.btnClear.Name = "btnClear"
          Me.btnClear.Size = New System.Drawing.Size(45, 36)
          Me.btnClear.TabIndex = 5
          Me.btnClear.UseVisualStyleBackColor = False
          '
          'btnCalc
          '
          Me.btnCalc.BackColor = System.Drawing.Color.White
          Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
          Me.btnCalc.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.Calculator_6_icon
          Me.btnCalc.Location = New System.Drawing.Point(141, 235)
          Me.btnCalc.Name = "btnCalc"
          Me.btnCalc.Size = New System.Drawing.Size(75, 67)
          Me.btnCalc.TabIndex = 4
          Me.btnCalc.UseVisualStyleBackColor = False
          '
          'TableLayoutPanel5
          '
          Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel5.ColumnCount = 2
          Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel5.Controls.Add(Me.Label5, 0, 0)
          Me.TableLayoutPanel5.Controls.Add(Me.txCatDay, 1, 0)
          Me.TableLayoutPanel5.Location = New System.Drawing.Point(333, 58)
          Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
          Me.TableLayoutPanel5.RowCount = 1
          Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel5.Size = New System.Drawing.Size(146, 29)
          Me.TableLayoutPanel5.TabIndex = 2
          '
          'Label5
          '
          Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label5.AutoSize = True
          Me.Label5.Location = New System.Drawing.Point(5, 8)
          Me.Label5.Name = "Label5"
          Me.Label5.Size = New System.Drawing.Size(74, 13)
          Me.Label5.TabIndex = 0
          Me.Label5.Text = "Category Day:"
          '
          'txCatDay
          '
          Me.txCatDay.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txCatDay.Location = New System.Drawing.Point(87, 5)
          Me.txCatDay.Name = "txCatDay"
          Me.txCatDay.Size = New System.Drawing.Size(42, 20)
          Me.txCatDay.TabIndex = 0
          '
          'TableLayoutPanel6
          '
          Me.TableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
          Me.TableLayoutPanel6.ColumnCount = 2
          Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
          Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 0)
          Me.TableLayoutPanel6.Controls.Add(Me.txDistance, 1, 0)
          Me.TableLayoutPanel6.Location = New System.Drawing.Point(485, 58)
          Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
          Me.TableLayoutPanel6.RowCount = 1
          Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
          Me.TableLayoutPanel6.Size = New System.Drawing.Size(166, 29)
          Me.TableLayoutPanel6.TabIndex = 3
          '
          'Label7
          '
          Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
          Me.Label7.AutoSize = True
          Me.Label7.Location = New System.Drawing.Point(5, 8)
          Me.Label7.Name = "Label7"
          Me.Label7.Size = New System.Drawing.Size(86, 13)
          Me.Label7.TabIndex = 0
          Me.Label7.Text = "Target Distance:"
          '
          'txDistance
          '
          Me.txDistance.Anchor = System.Windows.Forms.AnchorStyles.Left
          Me.txDistance.Location = New System.Drawing.Point(99, 5)
          Me.txDistance.Name = "txDistance"
          Me.txDistance.Size = New System.Drawing.Size(54, 20)
          Me.txDistance.TabIndex = 0
          '
          'bbStatus
          '
          Me.bbStatus.BackColor = System.Drawing.SystemColors.Control
          Me.bbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
          Me.bbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
          Me.bbStatus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
          Me.bbStatus.Location = New System.Drawing.Point(0, 320)
          Me.bbStatus.Name = "bbStatus"
          Me.bbStatus.Size = New System.Drawing.Size(749, 14)
          Me.bbStatus.TabIndex = 14
          Me.bbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
          '
          'frmMultiple
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(749, 334)
          Me.Controls.Add(Me.bbStatus)
          Me.Controls.Add(Me.TableLayoutPanel6)
          Me.Controls.Add(Me.TableLayoutPanel5)
          Me.Controls.Add(Me.btnClear)
          Me.Controls.Add(Me.btnCalc)
          Me.Controls.Add(Me.txResults)
          Me.Controls.Add(Me.TableLayoutPanel2)
          Me.Controls.Add(Me.TableLayoutPanel4)
          Me.Controls.Add(Me.TableLayoutPanel3)
          Me.Controls.Add(Me.dgv)
          Me.Controls.Add(Me.btnAdd)
          Me.Controls.Add(Me.TableLayoutPanel1)
          Me.Controls.Add(Me.PictureBox1)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
          Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
          Me.Name = "frmMultiple"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "frmMultiple"
          Me.TableLayoutPanel1.ResumeLayout(False)
          Me.TableLayoutPanel1.PerformLayout()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
          Me.TableLayoutPanel3.ResumeLayout(False)
          Me.TableLayoutPanel3.PerformLayout()
          Me.TableLayoutPanel4.ResumeLayout(False)
          Me.TableLayoutPanel4.PerformLayout()
          Me.TableLayoutPanel2.ResumeLayout(False)
          Me.TableLayoutPanel2.PerformLayout()
          Me.TableLayoutPanel5.ResumeLayout(False)
          Me.TableLayoutPanel5.PerformLayout()
          Me.TableLayoutPanel6.ResumeLayout(False)
          Me.TableLayoutPanel6.PerformLayout()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Timer1 As System.Windows.Forms.Timer
     Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents Label3 As System.Windows.Forms.Label
     Friend WithEvents txBlkSize As System.Windows.Forms.TextBox
     Friend WithEvents txFtype As System.Windows.Forms.ComboBox
     Friend WithEvents txFload As System.Windows.Forms.ComboBox
     Friend WithEvents btnAdd As System.Windows.Forms.Button
     Friend WithEvents dgv As System.Windows.Forms.DataGridView
     Friend WithEvents bkSize As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents ftype As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents fload As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents avFuels As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents ttons As System.Windows.Forms.DataGridViewTextBoxColumn
     Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents txAllowed As System.Windows.Forms.Label
     Friend WithEvents Label6 As System.Windows.Forms.Label
     Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label8 As System.Windows.Forms.Label
     Friend WithEvents txTotalTons As System.Windows.Forms.Label
     Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label4 As System.Windows.Forms.Label
     Friend WithEvents txTotalSize As System.Windows.Forms.Label
     Friend WithEvents txResults As System.Windows.Forms.TextBox
     Friend WithEvents btnClear As System.Windows.Forms.Button
     Friend WithEvents btnCalc As System.Windows.Forms.Button
     Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label5 As System.Windows.Forms.Label
     Friend WithEvents txCatDay As System.Windows.Forms.TextBox
     Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
     Friend WithEvents Label7 As System.Windows.Forms.Label
     Friend WithEvents txDistance As System.Windows.Forms.TextBox
     Friend WithEvents bbStatus As System.Windows.Forms.TextBox
End Class
