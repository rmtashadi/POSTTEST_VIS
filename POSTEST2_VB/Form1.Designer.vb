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
        gbTambah = New GroupBox()
        cboGenre = New ComboBox()
        btnTambah = New Button()
        txtJudulTambah = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        gbHapus = New GroupBox()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label3 = New Label()
        lstBuku = New ListBox()
        gbTambah.SuspendLayout()
        gbHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbTambah
        ' 
        gbTambah.Controls.Add(cboGenre)
        gbTambah.Controls.Add(btnTambah)
        gbTambah.Controls.Add(txtJudulTambah)
        gbTambah.Controls.Add(Label2)
        gbTambah.Controls.Add(Label1)
        gbTambah.ForeColor = Color.White
        gbTambah.Location = New Point(24, 28)
        gbTambah.Name = "gbTambah"
        gbTambah.Size = New Size(322, 188)
        gbTambah.TabIndex = 0
        gbTambah.TabStop = False
        gbTambah.Text = "Tambah Buku"
        ' 
        ' cboGenre
        ' 
        cboGenre.FormattingEnabled = True
        cboGenre.Items.AddRange(New Object() {"NOVEL", "KOMIK", "PENDIDIKAN", "TEKNOLOGI"})
        cboGenre.Location = New Point(175, 76)
        cboGenre.Name = "cboGenre"
        cboGenre.Size = New Size(100, 23)
        cboGenre.TabIndex = 5
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(175, 134)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 30)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtJudulTambah.Location = New Point(175, 29)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(100, 20)
        txtJudulTambah.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' gbHapus
        ' 
        gbHapus.Controls.Add(btnHapus)
        gbHapus.Controls.Add(txtJudulHapus)
        gbHapus.Controls.Add(Label3)
        gbHapus.ForeColor = Color.White
        gbHapus.Location = New Point(438, 28)
        gbHapus.Name = "gbHapus"
        gbHapus.Size = New Size(324, 188)
        gbHapus.TabIndex = 1
        gbHapus.TabStop = False
        gbHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(202), CByte(81), CByte(0))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(213, 134)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 30)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(204, 51)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(100, 23)
        txtJudulHapus.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(45, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 2
        Label3.Text = "Judul Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(219, 234)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(332, 199)
        lstBuku.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(38))
        ClientSize = New Size(778, 445)
        Controls.Add(lstBuku)
        Controls.Add(gbHapus)
        Controls.Add(gbTambah)
        Name = "Form1"
        Text = "Form1"
        gbTambah.ResumeLayout(False)
        gbTambah.PerformLayout()
        gbHapus.ResumeLayout(False)
        gbHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbTambah As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbHapus As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents cboGenre As ComboBox

End Class
