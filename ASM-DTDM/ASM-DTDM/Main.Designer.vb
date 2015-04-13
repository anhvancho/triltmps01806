<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.mnsmenuchinh = New System.Windows.Forms.MenuStrip()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDanhmuc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanlykhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanlynhanvien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsmenuchinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsmenuchinh
        '
        Me.mnsmenuchinh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniDanhmuc})
        Me.mnsmenuchinh.Location = New System.Drawing.Point(0, 0)
        Me.mnsmenuchinh.Name = "mnsmenuchinh"
        Me.mnsmenuchinh.Size = New System.Drawing.Size(498, 24)
        Me.mnsmenuchinh.TabIndex = 1
        Me.mnsmenuchinh.Text = "Menu chính"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDangxuat, Me.mniThoat})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(69, 20)
        Me.mniHethong.Text = "Hệ thống"
        '
        'mniDangxuat
        '
        Me.mniDangxuat.Image = Global.ASM_DTDM.My.Resources.Resources._128px_Human_gnome_logout_svg
        Me.mniDangxuat.Name = "mniDangxuat"
        Me.mniDangxuat.Size = New System.Drawing.Size(152, 22)
        Me.mniDangxuat.Text = "Đăng xuất"
        '
        'mniThoat
        '
        Me.mniThoat.Image = Global.ASM_DTDM.My.Resources.Resources.deconnection
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(152, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniDanhmuc
        '
        Me.mniDanhmuc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniQuanlykhachhang, Me.mniQuanlynhanvien})
        Me.mniDanhmuc.Name = "mniDanhmuc"
        Me.mniDanhmuc.Size = New System.Drawing.Size(74, 20)
        Me.mniDanhmuc.Text = "Danh mục"
        '
        'mniQuanlykhachhang
        '
        Me.mniQuanlykhachhang.Image = Global.ASM_DTDM.My.Resources.Resources.service_icon
        Me.mniQuanlykhachhang.Name = "mniQuanlykhachhang"
        Me.mniQuanlykhachhang.Size = New System.Drawing.Size(180, 22)
        Me.mniQuanlykhachhang.Text = "Quản lý khách hàng"
        '
        'mniQuanlynhanvien
        '
        Me.mniQuanlynhanvien.Image = Global.ASM_DTDM.My.Resources.Resources.User_Group_icon
        Me.mniQuanlynhanvien.Name = "mniQuanlynhanvien"
        Me.mniQuanlynhanvien.Size = New System.Drawing.Size(180, 22)
        Me.mniQuanlynhanvien.Text = "Quản lý  nhân viên"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ASM_DTDM.My.Resources.Resources._1213___Copy
        Me.ClientSize = New System.Drawing.Size(498, 457)
        Me.Controls.Add(Me.mnsmenuchinh)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.mnsmenuchinh.ResumeLayout(False)
        Me.mnsmenuchinh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsmenuchinh As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDanhmuc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanlykhachhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanlynhanvien As System.Windows.Forms.ToolStripMenuItem
End Class
