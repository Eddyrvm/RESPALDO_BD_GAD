Imports System.IO

Public Class FrmRespaldoBase
    Private Sub BtnConectar_Click(sender As Object, e As EventArgs) Handles BtnConectar.Click
        Dim conString As String = "server=192.168.71.251;uid=ADMIN;pwd=BOLIVAR2021; database=master"
        'Dim conString As String = "server=DESKTOP-JTH9EA2\SQLEXPRESS;uid=yupak;pwd=yupak; database=master"
        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = conString
        conexion.Open()
        Dim cmd As New SqlClient.SqlCommand("SELECT name from sys.databases", conexion)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                CbBasesDeDatos.Items.Add(fila(0).ToString)
            Next
            CbBasesDeDatos.SelectedIndex = 0
        End If
    End Sub

    Private Sub BtnRuta_Click(sender As Object, e As EventArgs) Handles BtnRuta.Click
        SaveFileDialog1.Filter = "SQL Backup files|*.bak"
        SaveFileDialog1.FileName = CbBasesDeDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRuta.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnGenerarRespaldo_Click(sender As Object, e As EventArgs) Handles BtnGenerarRespaldo.Click
        Try
            If Not Directory.Exists("E:\Backup") Then
                Directory.CreateDirectory("E:\Backup")
            End If
            Process.Start("cmd", "/k" & "sqlcmd -S 192.168.71.251 -E -Q ""BACKUP DATABASE [
                          " & CbBasesDeDatos.Text &
                          "] TO DISK='" & txtRuta.Text & "'""")
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub BtnRutaRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRutaRestaurar.Click
        OpenFileDialog1.Filter = "SQL Backup Files|*.bak"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtRutaRestaurar.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("cmd", "/k" & "Sqlcmd -S 192.168.71.251 -E -Q ""RESTORE DATABASE [
                      " & TxtBaseRestaurar.Text &
                      "] FROM DISK = '" & TxtRutaRestaurar.Text & "'""")
    End Sub
End Class
