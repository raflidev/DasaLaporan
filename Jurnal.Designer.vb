<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jurnal))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.ldebet = New System.Windows.Forms.Label
        Me.Tnamart = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lkode = New System.Windows.Forms.TextBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.labelkode = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dari Bulan"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(313, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sampai Bulan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(349, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kode Jurnal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ldebet)
        Me.GroupBox1.Controls.Add(Me.Tnamart)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 181)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(643, 118)
        Me.GroupBox4.TabIndex = 109
        Me.GroupBox4.TabStop = False
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button6.Location = New System.Drawing.Point(3, 75)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(637, 40)
        Me.Button6.TabIndex = 107
        Me.Button6.Text = "Cari Debet"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "MMMM yyyy"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(313, 35)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.ShowUpDown = True
        Me.DTP2.Size = New System.Drawing.Size(317, 20)
        Me.DTP2.TabIndex = 106
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "MMMM yyyy"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(0, 35)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.ShowUpDown = True
        Me.DTP1.Size = New System.Drawing.Size(307, 20)
        Me.DTP1.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(319, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "DEBET"
        '
        'ldebet
        '
        Me.ldebet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ldebet.Location = New System.Drawing.Point(435, 149)
        Me.ldebet.Name = "ldebet"
        Me.ldebet.Size = New System.Drawing.Size(202, 23)
        Me.ldebet.TabIndex = 107
        Me.ldebet.Text = "Label5"
        '
        'Tnamart
        '
        Me.Tnamart.Location = New System.Drawing.Point(131, 152)
        Me.Tnamart.Name = "Tnamart"
        Me.Tnamart.Size = New System.Drawing.Size(182, 20)
        Me.Tnamart.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 35)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Nama Ketua RT (Panggilan)"
        '
        'Lkode
        '
        Me.Lkode.Location = New System.Drawing.Point(349, 42)
        Me.Lkode.Name = "Lkode"
        Me.Lkode.ReadOnly = True
        Me.Lkode.Size = New System.Drawing.Size(70, 20)
        Me.Lkode.TabIndex = 102
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV.Location = New System.Drawing.Point(0, 256)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(649, 229)
        Me.DGV.TabIndex = 111
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Lkode)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 75)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fitur"
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(243, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 56)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Tutup"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(163, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 56)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Bersihkan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(83, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 56)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Hapus"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 56)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelkode})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 582)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(649, 22)
        Me.StatusStrip1.TabIndex = 112
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labelkode
        '
        Me.labelkode.Name = "labelkode"
        Me.labelkode.Size = New System.Drawing.Size(120, 17)
        Me.labelkode.Text = "ToolStripStatusLabel1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DTP2)
        Me.GroupBox5.Controls.Add(Me.DTP1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(637, 60)
        Me.GroupBox5.TabIndex = 108
        Me.GroupBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 485)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 85)
        Me.GroupBox3.TabIndex = 113
        Me.GroupBox3.TabStop = False
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(3, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(643, 66)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Tambah Keterangan"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Jurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 604)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Jurnal"
        Me.Text = "Jurnal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lkode As System.Windows.Forms.TextBox
    Friend WithEvents Tnamart As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ldebet As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents labelkode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
