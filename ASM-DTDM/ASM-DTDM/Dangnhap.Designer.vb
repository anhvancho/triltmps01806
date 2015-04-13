<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dangnhap
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
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.txttaikhoan = New System.Windows.Forms.TextBox()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.lbldangnhaphethong = New System.Windows.Forms.Label()
        Me.ptbavatar = New System.Windows.Forms.PictureBox()
        CType(Me.ptbavatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(314, 207)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(97, 23)
        Me.btnthoat.TabIndex = 15
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(211, 207)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(97, 23)
        Me.btndangnhap.TabIndex = 14
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(211, 165)
        Me.txtmatkhau.MaxLength = 20
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(237, 20)
        Me.txtmatkhau.TabIndex = 13
        Me.txtmatkhau.Text = "admin"
        '
        'txttaikhoan
        '
        Me.txttaikhoan.Location = New System.Drawing.Point(211, 116)
        Me.txttaikhoan.MaxLength = 20
        Me.txttaikhoan.Name = "txttaikhoan"
        Me.txttaikhoan.Size = New System.Drawing.Size(237, 20)
        Me.txttaikhoan.TabIndex = 12
        Me.txttaikhoan.Text = "admin"
        '
        'lblmatkhau
        '
        Me.lblmatkhau.Location = New System.Drawing.Point(208, 139)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(100, 23)
        Me.lblmatkhau.TabIndex = 11
        Me.lblmatkhau.Text = "Mật khẩu"
        Me.lblmatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.Location = New System.Drawing.Point(208, 90)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(100, 23)
        Me.lbltaikhoan.TabIndex = 10
        Me.lbltaikhoan.Text = "Tài khoản:"
        Me.lbltaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldangnhaphethong
        '
        Me.lbldangnhaphethong.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldangnhaphethong.ForeColor = System.Drawing.Color.Red
        Me.lbldangnhaphethong.Location = New System.Drawing.Point(133, 9)
        Me.lbldangnhaphethong.Name = "lbldangnhaphethong"
        Me.lbldangnhaphethong.Size = New System.Drawing.Size(315, 54)
        Me.lbldangnhaphethong.TabIndex = 9
        Me.lbldangnhaphethong.Text = "Đăng nhập hệ thống"
        Me.lbldangnhaphethong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbavatar
        '
        Me.ptbavatar.Image = Global.ASM_DTDM.My.Resources.Resources.admin_128
        Me.ptbavatar.Location = New System.Drawing.Point(11, 90)
        Me.ptbavatar.Name = "ptbavatar"
        Me.ptbavatar.Size = New System.Drawing.Size(160, 160)
        Me.ptbavatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbavatar.TabIndex = 8
        Me.ptbavatar.TabStop = False
        '
        'Dangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 262)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txttaikhoan)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.lbltaikhoan)
        Me.Controls.Add(Me.lbldangnhaphethong)
        Me.Controls.Add(Me.ptbavatar)
        Me.Name = "Dangnhap"
        Me.Text = "Đăng Nhập"
        CType(Me.ptbavatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txttaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents lbldangnhaphethong As System.Windows.Forms.Label
    Friend WithEvents ptbavatar As System.Windows.Forms.PictureBox

End Class
