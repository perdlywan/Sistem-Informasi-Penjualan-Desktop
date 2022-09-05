Imports MySql.Data.MySqlClient
Public Class formLogin
    Sub Kosong()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    

    
    Private Sub tblLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblLogin.Click
        Try
            VServer = "localhost"
            VUser = "root"
            VPass = ""
            VDatabase = "kelontong"

            StrCn = "Database='" & VDatabase & _
                    "';Data Source='" & VServer & _
                    "';User Id='" & VUser & _
                    "';Password='" & VPass & "'"

            cn = New MySqlConnection(StrCn)
            cn.Open()


            StrSQL = "SELECT * FROM admin Where username = '" & _
            txtUsername.Text & "' and password='" & txtPassword.Text & "'"
            Dim MyCommand As New MySqlCommand(StrSQL, cn)
            MyCommand.CommandType = CommandType.Text
            RdData = MyCommand.ExecuteReader

            If RdData.Read = False Then
                MsgBox("Maaf, Username Dan Password Salah",
               vbYes, "Login")
                Kosong()
                txtUsername.Focus()
            Else
                MsgBox("Koneksi Berhasil")
                formUtama.Show()
                vAdmin = txtUsername.Text
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Kesalahan!", MessageBoxButtons.OK,
           MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tblCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblCancel.Click
        Me.Dispose()
    End Sub

    Private Sub formLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class