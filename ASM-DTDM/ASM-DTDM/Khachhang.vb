Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Quanlykhachhang
    'Tạo các biến
    Dim kh As New DataTable
    Dim conmectstr As String = "workstation id=anhvancho.mssql.somee.com;packet size=4096;user id=anhvancho_SQLLogin_1;pwd=tgnguhdn2e;data source=anhvancho.mssql.somee.com;persist security info=False;initial catalog=anhvancho"
    Public Sub adduser_Load()
        Dim KetNoi As New SqlConnection(conmectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_hang", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(kh)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = kh
        KetNoi.Close()
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim KetNoi As New SqlConnection(conmectstr)
        KetNoi.Open()
        Dim stradd As String = "Update Khach_Hang set TenKhachHang = @TenKH, EmailKhachHang = @Email, SoDT = @DT, DiaChi = @DC where MaKhachHang = @MaKH"
        Dim Com As New SqlCommand(stradd, KetNoi)
        Try
            Com.Parameters.AddWithValue("@MaKH", txtMasokhachhang.Text)
            Com.Parameters.AddWithValue("@TenKH", txtTenkhachhang.Text)
            Com.Parameters.AddWithValue("@DC", txtDiachi.Text)
            Com.Parameters.AddWithValue("@DT", txtSodienthoai.Text)
            Com.Parameters.AddWithValue("@Email", txtEmail.Text)
            Com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Thay đổi dữ liệu thành công")
        End Try
        kh.Clear()
        DataGridView1.DataSource = kh
        DataGridView1.DataSource = Nothing
        adduser_Load()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Quanlykhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(conmectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_hang", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(kh)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = kh
        KetNoi.Close()
    End Sub

    Private Sub btnTrove_Click(sender As Object, e As EventArgs) Handles btnTrove.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO Khach_hang (MaKhachHang, TenKhachHang, SoDT, DiaChi, EmailKhachHang)"
        query &= "Values(@MaKH,@TenKH,@DT,@DC,@Email)"
        Using conn As New SqlConnection("workstation id=anhvancho.mssql.somee.com;packet size=4096;user id=anhvancho_SQLLogin_1;pwd=tgnguhdn2e;data source=anhvancho.mssql.somee.com;persist security info=False;initial catalog=anhvancho")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", txtMasokhachhang.Text)
                    .Parameters.AddWithValue("@TenKH", txtTenkhachhang.Text)
                    .Parameters.AddWithValue("@DT", txtSodienthoai.Text)
                    .Parameters.AddWithValue("@DC", txtDiachi.Text)
                    .Parameters.AddWithValue("@Email", txtEmail.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
                kh.Clear()
                DataGridView1.DataSource = kh
                DataGridView1.DataSource = Nothing
                adduser_Load()
            End Using
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim KetNoi As New SqlConnection(conmectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from Khach_Hang Where MaKhachHang = @MaKH"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMasokhachhang.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        kh.Clear()
        DataGridView1.DataSource = kh
        DataGridView1.DataSource = Nothing
        adduser_Load()
        txtMasokhachhang.Clear()
        txtTenkhachhang.Clear()
        txtEmail.Clear()
        txtDiachi.Clear()
        txtSodienthoai.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMasokhachhang.Text = DataGridView1.Item(0, index).Value
        txtTenkhachhang.Text = DataGridView1.Item(1, index).Value
        txtSodienthoai.Text = DataGridView1.Item(2, index).Value
        txtDiachi.Text = DataGridView1.Item(3, index).Value
        txtEmail.Text = DataGridView1.Item(4, index).Value
    End Sub
End Class