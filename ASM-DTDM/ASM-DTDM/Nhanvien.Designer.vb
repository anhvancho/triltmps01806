<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlynhanvien
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTrove = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtSodienthoai = New System.Windows.Forms.TextBox()
        Me.lblSodienthoai = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtTennhanvien = New System.Windows.Forms.TextBox()
        Me.lblTennhanvien = New System.Windows.Forms.Label()
        Me.txtMasonhanvien = New System.Windows.Forms.TextBox()
        Me.lblMasonhanvien = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(372, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 174)
        Me.DataGridView1.TabIndex = 75
        '
        'btnTrove
        '
        Me.btnTrove.Location = New System.Drawing.Point(263, 163)
        Me.btnTrove.Name = "btnTrove"
        Me.btnTrove.Size = New System.Drawing.Size(73, 23)
        Me.btnTrove.TabIndex = 74
        Me.btnTrove.Text = "Trở về"
        Me.btnTrove.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(184, 163)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(73, 23)
        Me.btnXoa.TabIndex = 73
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(105, 163)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(73, 23)
        Me.btnSua.TabIndex = 72
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 163)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(73, 23)
        Me.btnThem.TabIndex = 71
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtSodienthoai
        '
        Me.txtSodienthoai.Location = New System.Drawing.Point(147, 118)
        Me.txtSodienthoai.Name = "txtSodienthoai"
        Me.txtSodienthoai.Size = New System.Drawing.Size(201, 20)
        Me.txtSodienthoai.TabIndex = 70
        Me.txtSodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSodienthoai
        '
        Me.lblSodienthoai.Location = New System.Drawing.Point(16, 116)
        Me.lblSodienthoai.Name = "lblSodienthoai"
        Me.lblSodienthoai.Size = New System.Drawing.Size(104, 23)
        Me.lblSodienthoai.TabIndex = 69
        Me.lblSodienthoai.Text = "Số điện thoại"
        Me.lblSodienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(147, 92)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(201, 20)
        Me.txtPassword.TabIndex = 68
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(16, 90)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(104, 23)
        Me.lblPassword.TabIndex = 67
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(147, 66)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(201, 20)
        Me.txtID.TabIndex = 66
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(16, 64)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(125, 23)
        Me.lblID.TabIndex = 65
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTennhanvien
        '
        Me.txtTennhanvien.Location = New System.Drawing.Point(147, 40)
        Me.txtTennhanvien.Name = "txtTennhanvien"
        Me.txtTennhanvien.Size = New System.Drawing.Size(201, 20)
        Me.txtTennhanvien.TabIndex = 64
        '
        'lblTennhanvien
        '
        Me.lblTennhanvien.Location = New System.Drawing.Point(16, 38)
        Me.lblTennhanvien.Name = "lblTennhanvien"
        Me.lblTennhanvien.Size = New System.Drawing.Size(104, 23)
        Me.lblTennhanvien.TabIndex = 63
        Me.lblTennhanvien.Text = "Tên nhân viên"
        Me.lblTennhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasonhanvien
        '
        Me.txtMasonhanvien.Location = New System.Drawing.Point(147, 14)
        Me.txtMasonhanvien.Name = "txtMasonhanvien"
        Me.txtMasonhanvien.Size = New System.Drawing.Size(201, 20)
        Me.txtMasonhanvien.TabIndex = 62
        '
        'lblMasonhanvien
        '
        Me.lblMasonhanvien.Location = New System.Drawing.Point(16, 12)
        Me.lblMasonhanvien.Name = "lblMasonhanvien"
        Me.lblMasonhanvien.Size = New System.Drawing.Size(125, 23)
        Me.lblMasonhanvien.TabIndex = 61
        Me.lblMasonhanvien.Text = "Mã số nhân viên"
        Me.lblMasonhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Quanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 207)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTrove)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSodienthoai)
        Me.Controls.Add(Me.lblSodienthoai)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtTennhanvien)
        Me.Controls.Add(Me.lblTennhanvien)
        Me.Controls.Add(Me.txtMasonhanvien)
        Me.Controls.Add(Me.lblMasonhanvien)
        Me.Name = "Quanlynhanvien"
        Me.Text = "Quản lý nhân viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTrove As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtSodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lblSodienthoai As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtTennhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblTennhanvien As System.Windows.Forms.Label
    Friend WithEvents txtMasonhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblMasonhanvien As System.Windows.Forms.Label
End Class
