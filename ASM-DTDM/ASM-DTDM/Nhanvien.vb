Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Quanlynhanvien
    'Tạo các biến
    Dim nv As New DataTable
    Dim conmectstr As String = "workstation id=anhvancho.mssql.somee.com;packet size=4096;user id=anhvancho_SQLLogin_1;pwd=tgnguhdn2e;data source=anhvancho.mssql.somee.com;persist security info=False;initial catalog=anhvancho"
    Public Sub adduser_Load()
        Dim KetNoi As New SqlConnection(conmectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(nv)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = nv
        KetNoi.Close()
    End Sub
    Private Sub btnTrove_Click(sender As Object, e As EventArgs) Handles btnTrove.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Quanlynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(conmectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(nv)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = nv
        KetNoi.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, ID, MatKhau, SoDT)"
        query &= "Values(@MaNV,@TenNV,@ID,@MK,@DT)"
        Using conn As New SqlConnection("workstation id=anhvancho.mssql.somee.com;packet size=4096;user id=anhvancho_SQLLogin_1;pwd=tgnguhdn2e;data source=anhvancho.mssql.somee.com;persist security info=False;initial catalog=anhvancho")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
                    .Parameters.AddWithValue("@TenNV", txtTennhanvien.Text)
                    .Parameters.AddWithValue("@ID", txtID.Text)
                    .Parameters.AddWithValue("@MK", txtPassword.Text)
                    .Parameters.AddWithValue("@DT", txtSodienthoai.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                nv.Clear()
                DataGridView1.DataSource = nv
                DataGridView1.DataSource = Nothing
                adduser_Load()
            End Using
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim KetNoi As New SqlConnection(conmectstr)
        KetNoi.Open()
        Dim stradd As String = "Update NhanVien set TenNhanVien = @TenNV, ID = @ID, MatKhau = @MK, SoDT = @DT where MaNhanVien = @MaNV"
        Dim Com As New SqlCommand(stradd, KetNoi)
        Try
            Com.Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
            Com.Parameters.AddWithValue("@TenNV", txtTennhanvien.Text)
            Com.Parameters.AddWithValue("@ID", txtID.Text)
            Com.Parameters.AddWithValue("@MK", txtPassword.Text)
            Com.Parameters.AddWithValue("@DT", txtSodienthoai.Text)
            Com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Thay đổi dữ liệu thành công")
        End Try
        nv.Clear()
        DataGridView1.DataSource = nv
        DataGridView1.DataSource = Nothing
        adduser_Load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMasonhanvien.Text = DataGridView1.Item(0, index).Value
        txtTennhanvien.Text = DataGridView1.Item(1, index).Value
        txtID.Text = DataGridView1.Item(2, index).Value
        txtPassword.Text = DataGridView1.Item(3, index).Value
        txtSodienthoai.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim KetNoi As New SqlConnection(conmectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from NhanVien Where MaNhanVien = @MaNV"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        nv.Clear()
        DataGridView1.DataSource = nv
        DataGridView1.DataSource = Nothing
        adduser_Load()
        txtMasonhanvien.Clear()
        txtTennhanvien.Clear()
        txtID.Clear()
        txtPassword.Clear()
        txtSodienthoai.Clear()
    End Sub
End Class