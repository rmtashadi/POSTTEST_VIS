<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        gbNamaBarang = New GroupBox()
        txtKeterangan = New TextBox()
        Label7 = New Label()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnReset = New Button()
        btnDetail = New Button()
        txtKategori = New TextBox()
        txtTahunBeli = New TextBox()
        txtNamaBarang = New TextBox()
        txtID = New TextBox()
        txtKondisi = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgvBarang = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colKategori = New DataGridViewTextBoxColumn()
        colKondisi = New DataGridViewTextBoxColumn()
        colTahun = New DataGridViewTextBoxColumn()
        colKeterangan = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Label1 = New Label()
        gbNamaBarang.SuspendLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbNamaBarang
        ' 
        gbNamaBarang.Controls.Add(txtKeterangan)
        gbNamaBarang.Controls.Add(Label7)
        gbNamaBarang.Controls.Add(btnSimpan)
        gbNamaBarang.Controls.Add(btnUbah)
        gbNamaBarang.Controls.Add(btnHapus)
        gbNamaBarang.Controls.Add(btnReset)
        gbNamaBarang.Controls.Add(btnDetail)
        gbNamaBarang.Controls.Add(txtKategori)
        gbNamaBarang.Controls.Add(txtTahunBeli)
        gbNamaBarang.Controls.Add(txtNamaBarang)
        gbNamaBarang.Controls.Add(txtID)
        gbNamaBarang.Controls.Add(txtKondisi)
        gbNamaBarang.Controls.Add(Label6)
        gbNamaBarang.Controls.Add(Label5)
        gbNamaBarang.Controls.Add(Label4)
        gbNamaBarang.Controls.Add(Label3)
        gbNamaBarang.Controls.Add(Label2)
        gbNamaBarang.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbNamaBarang.ForeColor = Color.FromArgb(CByte(46), CByte(103), CByte(177))
        gbNamaBarang.Location = New Point(28, 49)
        gbNamaBarang.Name = "gbNamaBarang"
        gbNamaBarang.Size = New Size(599, 247)
        gbNamaBarang.TabIndex = 0
        gbNamaBarang.TabStop = False
        gbNamaBarang.Text = "Data Barang"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.BorderStyle = BorderStyle.FixedSingle
        txtKeterangan.Location = New Point(302, 161)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.PlaceholderText = "catatan tambahan (Opsional)"
        txtKeterangan.Size = New Size(257, 25)
        txtKeterangan.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(302, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 17)
        Label7.TabIndex = 15
        Label7.Text = "Keterangan"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(46), CByte(103), CByte(177))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.YellowGreen
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(26, 208)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(79, 37)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatAppearance.MouseOverBackColor = Color.YellowGreen
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(111, 208)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 37)
        btnUbah.TabIndex = 13
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(192, 208)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 37)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        btnReset.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(286, 208)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 37)
        btnReset.TabIndex = 11
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnDetail
        ' 
        btnDetail.BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        btnDetail.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDetail.Location = New Point(485, 208)
        btnDetail.Name = "btnDetail"
        btnDetail.Size = New Size(75, 37)
        btnDetail.TabIndex = 10
        btnDetail.Text = "Detail"
        btnDetail.UseVisualStyleBackColor = False
        ' 
        ' txtKategori
        ' 
        txtKategori.BorderStyle = BorderStyle.FixedSingle
        txtKategori.Location = New Point(26, 161)
        txtKategori.Name = "txtKategori"
        txtKategori.PlaceholderText = """Contoh:Elektronik/Hobi/Pakaian"""
        txtKategori.Size = New Size(241, 25)
        txtKategori.TabIndex = 5
        ' 
        ' txtTahunBeli
        ' 
        txtTahunBeli.BorderStyle = BorderStyle.FixedSingle
        txtTahunBeli.Location = New Point(302, 102)
        txtTahunBeli.Name = "txtTahunBeli"
        txtTahunBeli.Size = New Size(257, 25)
        txtTahunBeli.TabIndex = 4
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.BorderStyle = BorderStyle.FixedSingle
        txtNamaBarang.Location = New Point(26, 41)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(237, 25)
        txtNamaBarang.TabIndex = 1
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(302, 41)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "Otomatis oleh sistem"
        txtID.Size = New Size(257, 25)
        txtID.TabIndex = 2
        ' 
        ' txtKondisi
        ' 
        txtKondisi.BorderStyle = BorderStyle.FixedSingle
        txtKondisi.Location = New Point(26, 102)
        txtKondisi.Name = "txtKondisi"
        txtKondisi.PlaceholderText = """Contoh:Baru/Bekas/Rusak"""
        txtKondisi.Size = New Size(237, 25)
        txtKondisi.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(302, 21)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 17)
        Label6.TabIndex = 4
        Label6.Text = "ID Barang"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(302, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 17)
        Label5.TabIndex = 3
        Label5.Text = "Tahun Beli"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 17)
        Label4.TabIndex = 2
        Label4.Text = "Kategori"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 17)
        Label3.TabIndex = 1
        Label3.Text = "Kondisi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 17)
        Label2.TabIndex = 0
        Label2.Text = "Nama Barang"
        ' 
        ' dgvBarang
        ' 
        dgvBarang.AllowUserToAddRows = False
        dgvBarang.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(225), CByte(240), CByte(255))
        dgvBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBarang.BackgroundColor = SystemColors.Control
        dgvBarang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(46), CByte(103), CByte(177))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBarang.Columns.AddRange(New DataGridViewColumn() {colID, colNama, colKategori, colKondisi, colTahun, colKeterangan})
        dgvBarang.EnableHeadersVisualStyles = False
        dgvBarang.Location = New Point(28, 302)
        dgvBarang.Name = "dgvBarang"
        dgvBarang.ReadOnly = True
        dgvBarang.RowHeadersVisible = False
        dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBarang.Size = New Size(599, 149)
        dgvBarang.TabIndex = 15
        ' 
        ' colID
        ' 
        colID.DataPropertyName = "id"
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colNama
        ' 
        colNama.DataPropertyName = "nama_barang"
        colNama.HeaderText = "Nama Barang"
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colKategori
        ' 
        colKategori.DataPropertyName = "kategori"
        colKategori.HeaderText = "Kategori"
        colKategori.Name = "colKategori"
        colKategori.ReadOnly = True
        ' 
        ' colKondisi
        ' 
        colKondisi.DataPropertyName = "kondisi"
        colKondisi.HeaderText = "Kondisi"
        colKondisi.Name = "colKondisi"
        colKondisi.ReadOnly = True
        ' 
        ' colTahun
        ' 
        colTahun.DataPropertyName = "tahun_beli"
        colTahun.HeaderText = "Tahun Beli"
        colTahun.Name = "colTahun"
        colTahun.ReadOnly = True
        ' 
        ' colKeterangan
        ' 
        colKeterangan.HeaderText = "Keterangan"
        colKeterangan.Name = "colKeterangan"
        colKeterangan.ReadOnly = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.HotTrack
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 43)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 21)
        Label1.TabIndex = 1
        Label1.Text = "Sistem Manajemen Koleksi Barang Pribadi" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvBarang)
        Controls.Add(Panel1)
        Controls.Add(gbNamaBarang)
        Name = "Form1"
        Text = "Form1"
        gbNamaBarang.ResumeLayout(False)
        gbNamaBarang.PerformLayout()
        CType(dgvBarang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbNamaBarang As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtKondisi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDetail As Button
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtTahunBeli As TextBox
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colKategori As DataGridViewTextBoxColumn
    Friend WithEvents colKondisi As DataGridViewTextBoxColumn
    Friend WithEvents colTahun As DataGridViewTextBoxColumn
    Friend WithEvents colKeterangan As DataGridViewTextBoxColumn

End Class
