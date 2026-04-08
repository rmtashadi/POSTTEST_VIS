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
        MenuStrip1 = New MenuStrip()
        stripmenuFile = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBukaData = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        stripmenuData = New ToolStripMenuItem()
        InputToolStripMenuItem = New ToolStripMenuItem()
        stripmenuKartu = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        tpDataUtama = New TabPage()
        tpKontak = New TabPage()
        tpProfil = New TabPage()
        KeluarToolStripMenuItem = New ToolStripSeparator()
        Panel1 = New Panel()
        Label2 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txtNamaLengkap = New TextBox()
        txtIDAnggota = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cboKomunitas = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        mtxtNoTelp = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        Label6 = New Label()
        picFoto = New PictureBox()
        ofdFoto = New OpenFileDialog()
        gbPeran = New GroupBox()
        chBL = New CheckBox()
        chGym = New CheckBox()
        chEsports = New CheckBox()
        chCamping = New CheckBox()
        chIT = New CheckBox()
        chEduakasi = New CheckBox()
        chFoto = New CheckBox()
        chBahasa = New CheckBox()
        btnBrowse = New Button()
        btnSimpanCetak = New Button()
        rbStaff = New RadioButton()
        rbKetua = New RadioButton()
        rbAnggota = New RadioButton()
        gbMinat = New GroupBox()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tpDataUtama.SuspendLayout()
        tpKontak.SuspendLayout()
        tpProfil.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbPeran.SuspendLayout()
        gbMinat.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(24), CByte(53), CByte(99))
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {stripmenuFile, stripmenuData, stripmenuKartu})
        MenuStrip1.Location = New Point(0, 425)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 25)
        MenuStrip1.TabIndex = 0
        ' 
        ' stripmenuFile
        ' 
        stripmenuFile.DropDownItems.AddRange(New ToolStripItem() {menuSimpan, menuBukaData, KeluarToolStripMenuItem, menuKeluar})
        stripmenuFile.Name = "stripmenuFile"
        stripmenuFile.Size = New Size(39, 21)
        stripmenuFile.Text = "File"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.Name = "menuSimpan"
        menuSimpan.ShortcutKeyDisplayString = "Ctrl + S"
        menuSimpan.Size = New Size(202, 22)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBukaData
        ' 
        menuBukaData.Name = "menuBukaData"
        menuBukaData.Size = New Size(202, 22)
        menuBukaData.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(202, 22)
        menuKeluar.Text = "Keluar"
        ' 
        ' stripmenuData
        ' 
        stripmenuData.DropDownItems.AddRange(New ToolStripItem() {InputToolStripMenuItem})
        stripmenuData.Name = "stripmenuData"
        stripmenuData.Size = New Size(47, 21)
        stripmenuData.Text = "Data"
        ' 
        ' InputToolStripMenuItem
        ' 
        InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        InputToolStripMenuItem.Size = New Size(180, 22)
        InputToolStripMenuItem.Text = "Input"
        ' 
        ' stripmenuKartu
        ' 
        stripmenuKartu.DropDownItems.AddRange(New ToolStripItem() {LihatKartuToolStripMenuItem})
        stripmenuKartu.Name = "stripmenuKartu"
        stripmenuKartu.Size = New Size(51, 21)
        stripmenuKartu.Text = "Kartu"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(180, 22)
        LihatKartuToolStripMenuItem.Text = "Lihat "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(80, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 50)
        Label1.TabIndex = 1
        Label1.Text = "COMMUNITY ID CARD SYSTEM" & vbCrLf & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cute
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontak)
        TabControl1.Controls.Add(tpProfil)
        TabControl1.Dock = DockStyle.Bottom
        TabControl1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.ItemSize = New Size(120, 32)
        TabControl1.Location = New Point(0, 76)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(20, 10)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 349)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 3
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.BackColor = Color.Beige
        tpDataUtama.Controls.Add(cboKomunitas)
        tpDataUtama.Controls.Add(rbPerempuan)
        tpDataUtama.Controls.Add(rbLaki)
        tpDataUtama.Controls.Add(dtpTanggalLahir)
        tpDataUtama.Controls.Add(txtIDAnggota)
        tpDataUtama.Controls.Add(txtNamaLengkap)
        tpDataUtama.Controls.Add(Label12)
        tpDataUtama.Controls.Add(Label11)
        tpDataUtama.Controls.Add(Label10)
        tpDataUtama.Controls.Add(Label9)
        tpDataUtama.Controls.Add(Label8)
        tpDataUtama.Location = New Point(4, 36)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(792, 309)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "DATA UTAMA"
        ' 
        ' tpKontak
        ' 
        tpKontak.BackColor = Color.Beige
        tpKontak.Controls.Add(Label6)
        tpKontak.Controls.Add(txtEmail)
        tpKontak.Controls.Add(txtAlamat)
        tpKontak.Controls.Add(mtxtNoTelp)
        tpKontak.Controls.Add(Label3)
        tpKontak.Controls.Add(Label5)
        tpKontak.Controls.Add(Label4)
        tpKontak.Location = New Point(4, 36)
        tpKontak.Name = "tpKontak"
        tpKontak.Padding = New Padding(3)
        tpKontak.Size = New Size(792, 309)
        tpKontak.TabIndex = 1
        tpKontak.Text = "KONTAK & INFO"
        ' 
        ' tpProfil
        ' 
        tpProfil.BackColor = Color.Beige
        tpProfil.Controls.Add(gbMinat)
        tpProfil.Controls.Add(btnSimpanCetak)
        tpProfil.Controls.Add(btnBrowse)
        tpProfil.Controls.Add(gbPeran)
        tpProfil.Controls.Add(picFoto)
        tpProfil.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tpProfil.Location = New Point(4, 36)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(792, 309)
        tpProfil.TabIndex = 2
        tpProfil.Text = "PROFIL & HOBI"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(199, 6)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(53), CByte(99))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(82, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 13)
        Label2.TabIndex = 4
        Label2.Text = "Sistem Kartu Identitas Komunitas"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(148, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 17)
        Label8.TabIndex = 0
        Label8.Text = "ID ANGGOTA"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(148, 205)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 17)
        Label9.TabIndex = 1
        Label9.Text = "KOMUNITAS"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(148, 170)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 17)
        Label10.TabIndex = 2
        Label10.Text = "JENIS KELAMIN"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(148, 128)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 17)
        Label11.TabIndex = 3
        Label11.Text = "TANGGAL LAHIR"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(148, 51)
        Label12.Name = "Label12"
        Label12.Size = New Size(109, 17)
        Label12.TabIndex = 4
        Label12.Text = "NAMA LENGKAP"
        ' 
        ' txtNamaLengkap
        ' 
        txtNamaLengkap.BorderStyle = BorderStyle.FixedSingle
        txtNamaLengkap.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaLengkap.Location = New Point(341, 49)
        txtNamaLengkap.Name = "txtNamaLengkap"
        txtNamaLengkap.Size = New Size(167, 25)
        txtNamaLengkap.TabIndex = 1
        ' 
        ' txtIDAnggota
        ' 
        txtIDAnggota.BorderStyle = BorderStyle.FixedSingle
        txtIDAnggota.Location = New Point(341, 90)
        txtIDAnggota.Name = "txtIDAnggota"
        txtIDAnggota.Size = New Size(167, 23)
        txtIDAnggota.TabIndex = 2
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(341, 124)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(167, 23)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbLaki.Location = New Point(341, 154)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(77, 21)
        rbLaki.TabIndex = 4
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Checked = True
        rbPerempuan.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbPerempuan.Location = New Point(341, 177)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(96, 21)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cboKomunitas
        ' 
        cboKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cboKomunitas.FormattingEnabled = True
        cboKomunitas.Items.AddRange(New Object() {"PECINTA ALAM", "RELAWAN BENCANA ALAM", "KOMUNITAS MANCING MANIA", "PAGUYUBAN OTOMOTIF"})
        cboKomunitas.Location = New Point(341, 204)
        cboKomunitas.Name = "cboKomunitas"
        cboKomunitas.Size = New Size(167, 23)
        cboKomunitas.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(127, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 1
        Label4.Text = "EMAIL"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(78, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(127, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 17)
        Label3.TabIndex = 3
        Label3.Text = "ALAMAT"
        ' 
        ' mtxtNoTelp
        ' 
        mtxtNoTelp.BorderStyle = BorderStyle.FixedSingle
        mtxtNoTelp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mtxtNoTelp.Location = New Point(304, 195)
        mtxtNoTelp.Mask = "0000-0000-0000"
        mtxtNoTelp.Name = "mtxtNoTelp"
        mtxtNoTelp.Size = New Size(166, 25)
        mtxtNoTelp.TabIndex = 4
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(304, 136)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(166, 25)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(304, 75)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "@gmail.com"
        txtEmail.Size = New Size(166, 25)
        txtEmail.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(127, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 17)
        Label6.TabIndex = 7
        Label6.Text = "NO.TELEPON"
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(64, 25)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(100, 50)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ofdFoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofdFoto.Title = "Pilih Foto Profil"
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbStaff)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbPeran.Location = New Point(408, 22)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(200, 100)
        gbPeran.TabIndex = 1
        gbPeran.TabStop = False
        gbPeran.Text = "Peran/Jabatan"
        ' 
        ' chBL
        ' 
        chBL.AutoSize = True
        chBL.Cursor = Cursors.Hand
        chBL.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chBL.Location = New Point(192, 60)
        chBL.Name = "chBL"
        chBL.Size = New Size(67, 21)
        chBL.TabIndex = 2
        chBL.Text = "Billiard"
        chBL.UseVisualStyleBackColor = True
        ' 
        ' chGym
        ' 
        chGym.AutoSize = True
        chGym.Cursor = Cursors.Hand
        chGym.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chGym.Location = New Point(192, 30)
        chGym.Name = "chGym"
        chGym.Size = New Size(105, 21)
        chGym.TabIndex = 3
        chGym.Text = "Gym & Fitness"
        chGym.UseVisualStyleBackColor = True
        ' 
        ' chEsports
        ' 
        chEsports.AutoSize = True
        chEsports.Cursor = Cursors.Hand
        chEsports.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chEsports.Location = New Point(192, 120)
        chEsports.Name = "chEsports"
        chEsports.Size = New Size(78, 21)
        chEsports.TabIndex = 4
        chEsports.Text = "E-Sports"
        chEsports.UseVisualStyleBackColor = True
        ' 
        ' chCamping
        ' 
        chCamping.AutoSize = True
        chCamping.Cursor = Cursors.Hand
        chCamping.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chCamping.Location = New Point(16, 120)
        chCamping.Name = "chCamping"
        chCamping.Size = New Size(141, 21)
        chCamping.TabIndex = 5
        chCamping.Text = "Camping & Outdoor"
        chCamping.UseVisualStyleBackColor = True
        ' 
        ' chIT
        ' 
        chIT.AutoSize = True
        chIT.Cursor = Cursors.Hand
        chIT.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chIT.Location = New Point(192, 90)
        chIT.Name = "chIT"
        chIT.Size = New Size(84, 21)
        chIT.TabIndex = 6
        chIT.Text = "IT & Digital"
        chIT.UseVisualStyleBackColor = True
        ' 
        ' chEduakasi
        ' 
        chEduakasi.AutoSize = True
        chEduakasi.Cursor = Cursors.Hand
        chEduakasi.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chEduakasi.Location = New Point(16, 90)
        chEduakasi.Name = "chEduakasi"
        chEduakasi.Size = New Size(123, 21)
        chEduakasi.TabIndex = 7
        chEduakasi.Text = "Edukasi & Literasi"
        chEduakasi.UseVisualStyleBackColor = True
        ' 
        ' chFoto
        ' 
        chFoto.AutoSize = True
        chFoto.Cursor = Cursors.Hand
        chFoto.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chFoto.Location = New Point(16, 26)
        chFoto.Name = "chFoto"
        chFoto.Size = New Size(127, 21)
        chFoto.TabIndex = 8
        chFoto.Text = "Fotografi & Media"
        chFoto.UseVisualStyleBackColor = True
        ' 
        ' chBahasa
        ' 
        chBahasa.AutoSize = True
        chBahasa.Cursor = Cursors.Hand
        chBahasa.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chBahasa.Location = New Point(17, 60)
        chBahasa.Name = "chBahasa"
        chBahasa.Size = New Size(123, 21)
        chBahasa.TabIndex = 9
        chBahasa.Text = "Bahasa & Budaya"
        chBahasa.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.White
        btnBrowse.Cursor = Cursors.Hand
        btnBrowse.FlatAppearance.BorderColor = Color.DimGray
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(76, 97)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(80, 25)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "BROWSE"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.FromArgb(CByte(24), CByte(53), CByte(99))
        btnSimpanCetak.Cursor = Cursors.Hand
        btnSimpanCetak.FlatAppearance.BorderSize = 0
        btnSimpanCetak.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(433, 236)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(200, 45)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "SIMPAN DAN CETAK KARTU"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' rbStaff
        ' 
        rbStaff.AutoSize = True
        rbStaff.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbStaff.Location = New Point(23, 76)
        rbStaff.Name = "rbStaff"
        rbStaff.Size = New Size(53, 21)
        rbStaff.TabIndex = 12
        rbStaff.Text = "Staff"
        rbStaff.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbKetua.Location = New Point(25, 53)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(61, 21)
        rbKetua.TabIndex = 13
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Checked = True
        rbAnggota.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbAnggota.Location = New Point(23, 26)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(79, 21)
        rbAnggota.TabIndex = 14
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' gbMinat
        ' 
        gbMinat.Controls.Add(chFoto)
        gbMinat.Controls.Add(chBahasa)
        gbMinat.Controls.Add(chEduakasi)
        gbMinat.Controls.Add(chBL)
        gbMinat.Controls.Add(chGym)
        gbMinat.Controls.Add(chEsports)
        gbMinat.Controls.Add(chCamping)
        gbMinat.Controls.Add(chIT)
        gbMinat.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbMinat.Location = New Point(52, 146)
        gbMinat.Name = "gbMinat"
        gbMinat.Size = New Size(315, 157)
        gbMinat.TabIndex = 12
        gbMinat.TabStop = False
        gbMinat.Text = "Minat Komunitas"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt)."
        SaveFileDialog1.Title = "Ekspor"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        tpKontak.ResumeLayout(False)
        tpKontak.PerformLayout()
        tpProfil.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        gbMinat.ResumeLayout(False)
        gbMinat.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents stripmenuFile As ToolStripMenuItem
    Friend WithEvents stripmenuData As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBukaData As ToolStripMenuItem
    Friend WithEvents stripmenuKartu As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents tpKontak As TabPage
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents KeluarToolStripMenuItem As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtIDAnggota As TextBox
    Friend WithEvents txtNamaLengkap As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cboKomunitas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents mtxtNoTelp As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chBahasa As CheckBox
    Friend WithEvents chFoto As CheckBox
    Friend WithEvents chEduakasi As CheckBox
    Friend WithEvents chIT As CheckBox
    Friend WithEvents chCamping As CheckBox
    Friend WithEvents chEsports As CheckBox
    Friend WithEvents chGym As CheckBox
    Friend WithEvents chBL As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbStaff As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents gbMinat As GroupBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
