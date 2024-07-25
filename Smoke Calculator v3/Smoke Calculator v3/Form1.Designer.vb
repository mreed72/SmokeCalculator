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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMultiple = New System.Windows.Forms.Button()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbVersion)
        Me.Panel1.Location = New System.Drawing.Point(12, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 58)
        Me.Panel1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.Smoke_Calculator_v3.My.Resources.Resources._1493228
        Me.Button2.Location = New System.Drawing.Point(249, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "© 2024 Scott Reed"
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(3, 9)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(42, 13)
        Me.lbVersion.TabIndex = 0
        Me.lbVersion.Text = "Version"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.p24_00079
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(298, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOG VIEWER"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnMultiple
        '
        Me.btnMultiple.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiple.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.weIMAGE088
        Me.btnMultiple.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMultiple.Location = New System.Drawing.Point(298, 53)
        Me.btnMultiple.Name = "btnMultiple"
        Me.btnMultiple.Size = New System.Drawing.Size(135, 34)
        Me.btnMultiple.TabIndex = 3
        Me.btnMultiple.Text = "MULTIPLE FUELS"
        Me.btnMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMultiple.UseVisualStyleBackColor = False
        '
        'btnSingle
        '
        Me.btnSingle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSingle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSingle.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.weIMAGE095
        Me.btnSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSingle.Location = New System.Drawing.Point(298, 12)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(135, 34)
        Me.btnSingle.TabIndex = 2
        Me.btnSingle.Text = "SINGLE FUELS"
        Me.btnSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSingle.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Smoke_Calculator_v3.My.Resources.Resources.ShexLogoA2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMultiple)
        Me.Controls.Add(Me.btnSingle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Panel1 As System.Windows.Forms.Panel
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents lbVersion As System.Windows.Forms.Label
     Friend WithEvents btnSingle As System.Windows.Forms.Button
     Friend WithEvents btnMultiple As System.Windows.Forms.Button
     Friend WithEvents Button1 As System.Windows.Forms.Button
     Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
