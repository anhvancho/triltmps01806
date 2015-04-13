Public Class Main

    Private Sub mniDangxuat_Click(sender As Object, e As EventArgs) Handles mniDangxuat.Click
        Dim cuaso As New Dangnhap
        cuaso.Show()
        Me.Hide()
    End Sub

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        End
    End Sub

    Private Sub mniQuanlykhachhang_Click(sender As Object, e As EventArgs) Handles mniQuanlykhachhang.Click
        Dim QuanlyKH As New Quanlykhachhang
        Quanlykhachhang.Show()
        Me.Hide()
    End Sub

    Private Sub mniQuanlynhanvien_Click(sender As Object, e As EventArgs) Handles mniQuanlynhanvien.Click
        Dim QuanlyNV As New Quanlynhanvien
        Quanlynhanvien.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class