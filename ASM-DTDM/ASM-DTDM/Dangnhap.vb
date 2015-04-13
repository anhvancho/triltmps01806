Imports System.Data.SqlClient
Public Class Dangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=anhvancho.mssql.somee.com;packet size=4096;user id=anhvancho_SQLLogin_1;pwd=tgnguhdn2e;data source=anhvancho.mssql.somee.com;persist security info=False;initial catalog=anhvancho"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where ID ='" & txttaikhoan.Text & "' and Matkhau='" & txtmatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công !")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dim dialog As DialogResult = MessageBox.Show("Bạn có muốn thoát !", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dialog = DialogResult.Yes) Then
            Me.Close()
            Application.Exit()
        Else
            txttaikhoan.Text = ""
            txtmatkhau.Text = ""
            txttaikhoan.Focus()
        End If
    End Sub

    Private Sub txttaikhoan_TextChanged(sender As Object, e As EventArgs) Handles txttaikhoan.TextChanged

    End Sub
End Class
