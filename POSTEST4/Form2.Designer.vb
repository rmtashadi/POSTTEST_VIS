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
        pbFotoHasil = New PictureBox()
        lblAktifitas = New Label()
        lblKontakHasil = New Label()
        lblKomunitasHasil = New Label()
        lblNamaHasil = New Label()
        lblIDHasil = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.BorderStyle = BorderStyle.FixedSingle
        pbFotoHasil.Location = New Point(48, 87)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(135, 160)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblAktifitas
        ' 
        lblAktifitas.AutoSize = True
        lblAktifitas.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAktifitas.ForeColor = Color.Silver
        lblAktifitas.Location = New Point(139, 298)
        lblAktifitas.Name = "lblAktifitas"
        lblAktifitas.Size = New Size(44, 17)
        lblAktifitas.TabIndex = 1
        lblAktifitas.Text = "Label1"
        ' 
        ' lblKontakHasil
        ' 
        lblKontakHasil.AutoSize = True
        lblKontakHasil.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontakHasil.ForeColor = Color.Silver
        lblKontakHasil.Location = New Point(196, 197)
        lblKontakHasil.Name = "lblKontakHasil"
        lblKontakHasil.Size = New Size(46, 17)
        lblKontakHasil.TabIndex = 2
        lblKontakHasil.Text = "Label2"
        ' 
        ' lblKomunitasHasil
        ' 
        lblKomunitasHasil.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKomunitasHasil.ForeColor = Color.Silver
        lblKomunitasHasil.Location = New Point(196, 157)
        lblKomunitasHasil.Name = "lblKomunitasHasil"
        lblKomunitasHasil.Size = New Size(610, 23)
        lblKomunitasHasil.TabIndex = 3
        lblKomunitasHasil.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.Font = New Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaHasil.ForeColor = Color.White
        lblNamaHasil.Location = New Point(195, 87)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(611, 23)
        lblNamaHasil.TabIndex = 4
        lblNamaHasil.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblIDHasil
        ' 
        lblIDHasil.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDHasil.ForeColor = Color.RoyalBlue
        lblIDHasil.ImageAlign = ContentAlignment.MiddleLeft
        lblIDHasil.Location = New Point(196, 110)
        lblIDHasil.Name = "lblIDHasil"
        lblIDHasil.Size = New Size(610, 23)
        lblIDHasil.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(35), CByte(100))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 75)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 25)
        Label1.TabIndex = 0
        Label1.Text = "KARTU IDENTITAS ANGGOTA"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(53), CByte(99))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(lblIDHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(lblKomunitasHasil)
        Controls.Add(lblKontakHasil)
        Controls.Add(lblAktifitas)
        Controls.Add(pbFotoHasil)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblAktifitas As Label
    Friend WithEvents lblKontakHasil As Label
    Friend WithEvents lblKomunitasHasil As Label
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblIDHasil As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
