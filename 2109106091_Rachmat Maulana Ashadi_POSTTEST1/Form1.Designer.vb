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
        lblips = New Label()
        lblipk = New Label()
        txtIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' lblips
        ' 
        lblips.AutoSize = True
        lblips.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblips.ForeColor = Color.Black
        lblips.Location = New Point(130, 106)
        lblips.Name = "lblips"
        lblips.Size = New Size(75, 15)
        lblips.TabIndex = 0
        lblips.Text = "IP Semester"
        ' 
        ' lblipk
        ' 
        lblipk.AutoSize = True
        lblipk.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblipk.Location = New Point(130, 207)
        lblipk.Name = "lblipk"
        lblipk.Size = New Size(76, 15)
        lblipk.TabIndex = 1
        lblipk.Text = "IP Kumulatif"
        ' 
        ' txtIPS
        ' 
        txtIPS.Location = New Point(242, 103)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(156, 23)
        txtIPS.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.ActiveBorder
        btnTambah.Location = New Point(242, 147)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ActiveBorder
        btnReset.Location = New Point(323, 147)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(242, 207)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(156, 23)
        txtIPK.TabIndex = 5
        txtIPK.Text = "0.00" & vbCrLf
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPredikat.Location = New Point(242, 256)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 15)
        lblPredikat.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Controls.Add(lblipk)
        Controls.Add(lblips)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblips As Label
    Friend WithEvents lblipk As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class
