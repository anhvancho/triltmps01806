<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlykhachhang
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtSodienthoai = New System.Windows.Forms.TextBox()
        Me.lblSodienthoai = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTenkhachhang = New System.Windows.Forms.TextBox()
        Me.lblTenkhachhang = New System.Windows.Forms.Label()
        Me.txtMasokhachhang = New System.Windows.Forms.TextBox()
        Me.lblMasokhachhang = New System.Windows.Forms.Label()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnTrove = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 161)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(73, 23)
        Me.btnThem.TabIndex = 56
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtSodienthoai
        '
        Me.txtSodienthoai.Location = New System.Drawing.Point(147, 116)
        Me.txtSodienthoai.Name = "txtSodienthoai"
        Me.txtSodienthoai.Size = New System.Drawing.Size(201, 20)
        Me.txtSodienthoai.TabIndex = 55
        Me.txtSodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSodienthoai
        '
        Me.lblSodienthoai.Location = New System.Drawing.Point(16, 114)
        Me.lblSodienthoai.Name = "lblSodienthoai"
        Me.lblSodienthoai.Size = New System.Drawing.Size(104, 23)
        Me.lblSodienthoai.TabIndex = 54
        Me.lblSodienthoai.Text = "Số điện thoại"
        Me.lblSodienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(147, 90)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(201, 20)
        Me.txtDiachi.TabIndex = 53
        '
        'lblDiachi
        '
        Me.lblDiachi.Location = New System.Drawing.Point(16, 88)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(104, 23)
        Me.lblDiachi.TabIndex = 52
        Me.lblDiachi.Text = "Địa chỉ"
        Me.lblDiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(147, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 20)
        Me.txtEmail.TabIndex = 51
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(16, 62)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(125, 23)
        Me.lblEmail.TabIndex = 50
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTenkhachhang
        '
        Me.txtTenkhachhang.Location = New System.Drawing.Point(147, 38)
        Me.txtTenkhachhang.Name = "txtTenkhachhang"
        Me.txtTenkhachhang.Size = New System.Drawing.Size(201, 20)
        Me.txtTenkhachhang.TabIndex = 49
        '
        'lblTenkhachhang
        '
        Me.lblTenkhachhang.Location = New System.Drawing.Point(16, 36)
        Me.lblTenkhachhang.Name = "lblTenkhachhang"
        Me.lblTenkhachhang.Size = New System.Drawing.Size(104, 23)
        Me.lblTenkhachhang.TabIndex = 48
        Me.lblTenkhachhang.Text = "Tên Khách hàng"
        Me.lblTenkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasokhachhang
        '
        Me.txtMasokhachhang.Location = New System.Drawing.Point(147, 12)
        Me.txtMasokhachhang.Name = "txtMasokhachhang"
        Me.txtMasokhachhang.Size = New System.Drawing.Size(201, 20)
        Me.txtMasokhachhang.TabIndex = 47
        '
        'lblMasokhachhang
        '
        Me.lblMasokhachhang.Location = New System.Drawing.Point(16, 10)
        Me.lblMasokhachhang.Name = "lblMasokhachhang"
        Me.lblMasokhachhang.Size = New System.Drawing.Size(125, 23)
        Me.lblMasokhachhang.TabIndex = 46
        Me.lblMasokhachhang.Text = "Mã số khách hàng"
        Me.lblMasokhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(105, 161)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(73, 23)
        Me.btnSua.TabIndex = 57
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(184, 161)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(73, 23)
        Me.btnXoa.TabIndex = 58
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnTrove
        '
        Me.btnTrove.Location = New System.Drawing.Point(263, 161)
        Me.btnTrove.Name = "btnTrove"
        Me.btnTrove.Size = New System.Drawing.Size(73, 23)
        Me.btnTrove.TabIndex = 59
        Me.btnTrove.Text = "Trở về"
        Me.btnTrove.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(372, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 174)
        Me.DataGridView1.TabIndex = 60
        '
        'Quanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 206)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTrove)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSodienthoai)
        Me.Controls.Add(Me.lblSodienthoai)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtTenkhachhang)
        Me.Controls.Add(Me.lblTenkhachhang)
        Me.Controls.Add(Me.txtMasokhachhang)
        Me.Controls.Add(Me.lblMasokhachhang)
        Me.Name = "Quanlykhachhang"
        Me.Text = "Quản lý khách hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtSodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lblSodienthoai As System.Windows.Forms.Label
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents lblTenkhachhang As System.Windows.Forms.Label
    Friend WithEvents txtMasokhachhang As System.Windows.Forms.TextBox
    Friend WithEvents lblMasokhachhang As System.Windows.Forms.Label
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnTrove As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
