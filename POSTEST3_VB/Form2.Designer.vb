<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        picFotoHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTL = New Label()
        lblJK = New Label()
        lblNoTelp = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        CType(picFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFotoHasil
        ' 
        picFotoHasil.Location = New Point(27, 33)
        picFotoHasil.Name = "picFotoHasil"
        picFotoHasil.Size = New Size(223, 321)
        picFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picFotoHasil.TabIndex = 0
        picFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(284, 33)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(45, 15)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(282, 71)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(43, 15)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur :"
        ' 
        ' lblTL
        ' 
        lblTL.AutoSize = True
        lblTL.Location = New Point(282, 110)
        lblTL.Name = "lblTL"
        lblTL.Size = New Size(84, 15)
        lblTL.TabIndex = 3
        lblTL.Text = "Tanggal Lahir :"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(282, 156)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(84, 15)
        lblJK.TabIndex = 4
        lblJK.Text = "Jenis Kelamin :"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(282, 205)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(71, 15)
        lblNoTelp.TabIndex = 5
        lblNoTelp.Text = "No. Telpon :"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(280, 253)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(49, 15)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby :"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(280, 302)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(54, 15)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat : "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.hogwarts_crest_2560_x_1920_wallpaper_pzn3xazi2tuf34s6
        ClientSize = New Size(800, 450)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblNoTelp)
        Controls.Add(lblJK)
        Controls.Add(lblTL)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picFotoHasil)
        Name = "Form2"
        Text = "Form2"
        CType(picFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFotoHasil As PictureBox
    Public WithEvents lblNama As Label
    Public WithEvents lblUmur As Label
    Public WithEvents lblTL As Label
    Public WithEvents lblJK As Label
    Public WithEvents lblNoTelp As Label
    Public WithEvents lblHobby As Label
    Public WithEvents lblAlamat As Label
End Class
