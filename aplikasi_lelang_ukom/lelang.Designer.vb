<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lelang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lelang))
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel
        Me.shadow1 = New Guna.UI.WinForms.GunaPanel
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton
        Me.id_lelang = New Guna.UI.WinForms.GunaLabel
        Me.id_barang = New Guna.UI.WinForms.GunaLabel
        Me.id_histori = New Guna.UI.WinForms.GunaLabel
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(0, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(333, 38)
        Me.GunaLabel5.TabIndex = 6
        Me.GunaLabel5.Text = "Form Pelelangan"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GunaLabel5.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel9)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel10)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel1.Controls.Add(Me.shadow1)
        Me.GunaPanel1.Controls.Add(Me.GunaLineTextBox4)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 38)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(333, 206)
        Me.GunaPanel1.TabIndex = 7
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(126, 115)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(101, 17)
        Me.GunaLabel7.TabIndex = 16
        Me.GunaLabel7.Text = "Jumlah Pelelang"
        Me.GunaLabel7.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(126, 81)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(99, 17)
        Me.GunaLabel8.TabIndex = 15
        Me.GunaLabel8.Text = "Harga Tertinggi"
        Me.GunaLabel8.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(126, 48)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(75, 17)
        Me.GunaLabel9.TabIndex = 14
        Me.GunaLabel9.Text = "Harga Awal"
        Me.GunaLabel9.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(126, 15)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(88, 17)
        Me.GunaLabel10.TabIndex = 13
        Me.GunaLabel10.Text = "Nama Barang"
        Me.GunaLabel10.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(2, 115)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(101, 17)
        Me.GunaLabel6.TabIndex = 12
        Me.GunaLabel6.Text = "Jumlah Pelelang"
        Me.GunaLabel6.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'shadow1
        '
        Me.shadow1.BackColor = System.Drawing.Color.Black
        Me.shadow1.Location = New System.Drawing.Point(-6, 150)
        Me.shadow1.Name = "shadow1"
        Me.shadow1.Size = New System.Drawing.Size(343, 2)
        Me.shadow1.TabIndex = 11
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(152, 161)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(160, 26)
        Me.GunaLineTextBox4.TabIndex = 7
        Me.GunaLineTextBox4.Text = "Harga Yang Ditawarkan"
        Me.GunaLineTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 166)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(144, 17)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Harga Yang Ditawarkan"
        Me.GunaLabel4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(3, 81)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(99, 17)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Harga Tertinggi"
        Me.GunaLabel3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(3, 48)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(75, 17)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Harga Awal"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(3, 15)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(88, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Nama Barang"
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(84, 269)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(160, 31)
        Me.GunaButton1.TabIndex = 12
        Me.GunaButton1.Text = "Lelang"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'id_lelang
        '
        Me.id_lelang.AutoSize = True
        Me.id_lelang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_lelang.Location = New System.Drawing.Point(12, 9)
        Me.id_lelang.Name = "id_lelang"
        Me.id_lelang.Size = New System.Drawing.Size(59, 17)
        Me.id_lelang.TabIndex = 1
        Me.id_lelang.Text = "id_lelang"
        Me.id_lelang.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'id_barang
        '
        Me.id_barang.AutoSize = True
        Me.id_barang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_barang.Location = New System.Drawing.Point(81, 9)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(66, 17)
        Me.id_barang.TabIndex = 8
        Me.id_barang.Text = "id_barang"
        Me.id_barang.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'id_histori
        '
        Me.id_histori.AutoSize = True
        Me.id_histori.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_histori.Location = New System.Drawing.Point(250, 9)
        Me.id_histori.Name = "id_histori"
        Me.id_histori.Size = New System.Drawing.Size(60, 17)
        Me.id_histori.TabIndex = 13
        Me.id_histori.Text = "id_histori"
        Me.id_histori.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        '
        'lelang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 312)
        Me.Controls.Add(Me.id_histori)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.id_lelang)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Name = "lelang"
        Me.Text = "lelang"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents shadow1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents id_lelang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents id_barang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents id_histori As Guna.UI.WinForms.GunaLabel
End Class
