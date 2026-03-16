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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picFoto = New PictureBox()
        gbJenisKelamin = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtNoTelp = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnBrowse = New Button()
        dtpTanggal = New DateTimePicker()
        gbHobby = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox1 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        btnCetak = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Location = New Point(12, 27)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(225, 334)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Location = New Point(259, 214)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Size = New Size(247, 169)
        gbJenisKelamin.TabIndex = 1
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(16, 31)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(72, 19)
        rbLaki.TabIndex = 13
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(16, 69)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 14
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(359, 33)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(168, 23)
        txtNama.TabIndex = 2
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(359, 62)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(168, 23)
        txtUmur.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(359, 163)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(168, 23)
        txtAlamat.TabIndex = 4
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(359, 129)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(168, 23)
        txtNoTelp.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 7
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(259, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(259, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 9
        Label4.Text = "No. Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(259, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 10
        Label5.Text = "Alamat"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(65, 391)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(83, 32)
        btnBrowse.TabIndex = 11
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(359, 96)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(191, 23)
        dtpTanggal.TabIndex = 12
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(CheckBox10)
        gbHobby.Controls.Add(CheckBox9)
        gbHobby.Controls.Add(CheckBox8)
        gbHobby.Controls.Add(CheckBox7)
        gbHobby.Controls.Add(CheckBox6)
        gbHobby.Controls.Add(CheckBox2)
        gbHobby.Controls.Add(CheckBox5)
        gbHobby.Controls.Add(CheckBox1)
        gbHobby.Controls.Add(CheckBox4)
        gbHobby.Controls.Add(CheckBox3)
        gbHobby.Location = New Point(512, 214)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(261, 169)
        gbHobby.TabIndex = 15
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(144, 119)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(74, 19)
        CheckBox10.TabIndex = 23
        CheckBox10.Text = "Olahraga"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(144, 94)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(93, 19)
        CheckBox9.TabIndex = 22
        CheckBox9.Text = "Nonton Film"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(144, 69)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(57, 19)
        CheckBox8.TabIndex = 21
        CheckBox8.Text = "Game"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(144, 44)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(79, 19)
        CheckBox7.TabIndex = 20
        CheckBox7.Text = "Membaca"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(144, 22)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(74, 19)
        CheckBox6.TabIndex = 19
        CheckBox6.Text = "Fotografi"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(3, 44)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(77, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Memasak"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(3, 119)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(65, 19)
        CheckBox5.TabIndex = 18
        CheckBox5.Text = "Coding"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 19)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Menulis"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(3, 94)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(90, 19)
        CheckBox4.TabIndex = 17
        CheckBox4.Text = "Memancing"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(3, 69)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(74, 19)
        CheckBox3.TabIndex = 16
        CheckBox3.Text = "Traveling"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(259, 415)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(451, 23)
        btnCetak.TabIndex = 16
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetak)
        Controls.Add(gbHobby)
        Controls.Add(dtpTanggal)
        Controls.Add(btnBrowse)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNoTelp)
        Controls.Add(txtAlamat)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(gbJenisKelamin)
        Controls.Add(picFoto)
        Name = "Form1"
        Text = "Form1"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
