Imports System.Data.SqlClient
Public Class FrmLecturas
    Dim conn As New SqlConnection("Data Source=DESKTOP-A4LG2DL\SQLEXPRESS; Initial Catalog= UTE; User Id= LeoUte; Password=123456;")

    Private Sub FrmLecturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim aux As New DataTable
            conn.Open()
            'aux.Clear()
            Dim adaptador As New SqlDataAdapter("SELECT max(lectura) FROM Lecturas", conn)
            adaptador.Fill(aux)
            LblUltimo.Text = aux.Rows(0).Item(0)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        llenardatosgrid()
        TxtLectura.Focus()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtLectura.Text = "" Or DtpFecha.Text = "" Then
            MsgBox("Faltan datos", vbCritical, "Atención")
        Else
            If Convert.ToInt32(TxtLectura.Text) < Convert.ToInt32(LblUltimo.Text) Then
                MsgBox("La lectura no puede ser inferior a la anterior", vbInformation, "Atención")
                'TxtLectura.SelectAll()
                TxtLectura.Focus()
            Else
                Try
                    Dim id As Integer
                    conn.Open()
                    Using comando As New SqlCommand("INSERT INTO Lecturas (Fecha,Lectura) VALUES ('" & DtpFecha.Value & "'," & TxtLectura.Text.Trim & ")", conn)
                        id = comando.ExecuteScalar()
                    End Using
                    conn.Close()
                    llenardatosgrid()
                    LblUltimo.Text = TxtLectura.Text
                    TxtLectura.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End If
    End Sub

    Sub llenardatosgrid()
        Try
            Dim tabla As New DataTable
            conn.Open()
            Dim adaptador As New SqlDataAdapter("SELECT * FROM Lecturas ORDER BY fecha desc", conn)
            conn.Close()
            tabla.Clear()
            adaptador.Fill(tabla)
            tabla.Columns.Add("Diario")
            For f = tabla.Rows.Count - 2 To 0 Step -1
                tabla.Rows(f).Item("Diario") = Math.Round((Int(tabla.Rows(f).Item("Lectura") - tabla.Rows(f + 1).Item("Lectura"))) / (Int(DateAndTime.DateDiff("d", tabla.Rows(f + 1).Item("fecha"), tabla.Rows(f).Item("fecha")))), 1)
                'tabla.Rows(f).Item("Diario") = tabla.Rows(f).Item("Lectura")
            Next
            If tabla.Rows.Count > 0 Then
                DgvLecturas.DataSource = tabla
            Else
                DgvLecturas.DataSource = ""
            End If
            DgvLecturas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'DgvLecturas.Columns["Lectura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmLecturas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal.ActualizaDatos()
    End Sub
End Class