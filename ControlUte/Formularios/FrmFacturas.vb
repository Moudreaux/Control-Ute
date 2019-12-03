Imports System.Data.SqlClient
Public Class FrmFacturas
    Dim conn As New SqlConnection("Data Source=DESKTOP-A4LG2DL\SQLEXPRESS; Initial Catalog= UTE; User Id= LeoUte; Password=123456;")

    Sub llenardatosgrid()
        Try
            Dim tabla As New DataTable
            conn.Open()
            Dim adaptador As New SqlDataAdapter("SELECT * FROM facturas ORDER BY fechaCorte desc", conn)
            conn.Close()
            tabla.Clear()
            adaptador.Fill(tabla)
            tabla.Columns.Add("Consumo")
            tabla.Columns.Add("Diario")
            For f = tabla.Rows.Count - 2 To 0 Step -1
                tabla.Rows(f).Item("Consumo") = Int(tabla.Rows(f).Item("Lectura") - tabla.Rows(f + 1).Item("Lectura"))
                'tabla.Rows(f).Item("Diario") = 5
                tabla.Rows(f).Item("Diario") = Math.Round(tabla.Rows(f).Item("Consumo") / Int(DateAndTime.DateDiff("d", tabla.Rows(f + 1).Item("fechaCorte"), tabla.Rows(f).Item("fechaCorte"))), 2)
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
                    Using comando As New SqlCommand("INSERT INTO Facturas (FechaCorte,Lectura) VALUES ('" & DtpFecha.Value & "'," & Int(TxtLectura.Text.Trim) & ")", conn)
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

    Private Sub FrmFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim aux As New DataTable
            conn.Open()
            'aux.Clear()
            Dim adaptador As New SqlDataAdapter("SELECT max(Lectura) FROM Facturas", conn)
            adaptador.Fill(aux)
            If IsDBNull(aux.Rows(0).Item(0)) Then
                LblUltimo.Text = 0
            Else
                LblUltimo.Text = Str(aux.Rows(0).Item(0))
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        llenardatosgrid()
        TxtLectura.Focus()
    End Sub

End Class