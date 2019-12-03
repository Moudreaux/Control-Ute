Imports System.Data.SqlClient
Public Class Principal
    Dim conn As New SqlConnection("Data Source=DESKTOP-A4LG2DL\SQLEXPRESS; Initial Catalog= UTE; User Id= LeoUte; Password=123456;")
    Private Sub AgregarLecturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLecturaToolStripMenuItem.Click
        FrmLecturas.ShowDialog()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        FrmFacturas.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consumoantes, consumoahora As Integer
        Try
            Dim aux As New DataTable
            conn.Open()
            Dim adaptador As New SqlDataAdapter("SELECT max(fechacorte), max(lectura) FROM Facturas", conn)
            adaptador.Fill(aux)
            If IsDBNull(aux.Rows(0).Item(0)) Then
                txtdesde.Text = 0
                consumoantes = 0
            Else
                txtdesde.Text = aux.Rows(0).Item(0)
                consumoantes = aux.Rows(0).Item(1)
            End If
            aux.Clear()
            adaptador = New SqlDataAdapter("SELECT max(fecha), max(Lectura) FROM Lecturas", conn)
            adaptador.Fill(aux)
            If IsDBNull(aux.Rows(0).Item(0)) Then
                txthasta.Text = 0
                consumoahora = 0
            Else
                txthasta.Text = aux.Rows(0).Item(0)
                consumoahora = aux.Rows(0).Item(1)
            End If
            TxtConsumidos.Text = consumoahora - consumoantes
            conn.Close()
            TxtDias.Text = Int(DateAndTime.DateDiff("d", txtdesde.Text, txthasta.Text))
            txtdiario.Text = Math.Round(TxtConsumidos.Text / TxtDias.Text, 2)
            Dim fechita As Date
            fechita = Date.ParseExact(txtdesde.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim dia As Integer = Microsoft.VisualBasic.DateAndTime.Day(txtdesde.Text)
            Dim mes As Integer = Month(fechita)
            Dim año As Integer = Year(fechita)
            If mes = 12 Then
                mes = 1
                año = año + 1
            Else
                mes = mes + 1
            End If
            dtpproxima.Value = Date.ParseExact(dia & "/" & mes & "/" & año, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            estimadatos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dtpproxima_ValueChanged(sender As Object, e As EventArgs) Handles dtpproxima.ValueChanged
        estimadatos()
    End Sub

    Sub estimadatos()
        TxtDiasEstimados.Text = Int(DateAndTime.DateDiff("d", txtdesde.Text, dtpproxima.Value))
        TxtConsumoEstimado.Text = Math.Ceiling(TxtDiasEstimados.Text * txtdiario.Text)
        txtprimeros.Text = 322.7
        If TxtConsumoEstimado.Text > 100 Then
            If TxtConsumoEstimado.Text > 140 Then
                txtmedio.Text = Math.Round(40 * 6.65, 1)
                txtresto.Text = Math.Round((TxtConsumoEstimado.Text - 140) * 12.15, 1)
            Else
                txtmedio.Text = Math.Round((TxtConsumoEstimado.Text - 100) * 6.65, 1)
                txtresto.Text = 0
            End If
        Else
            txtmedio.Text = 0
            txtresto.Text = 0
        End If
        txttotal.Text = txtprimeros.Text * 1 + txtmedio.Text * 1 + txtresto.Text * 1
        txtAPagar.Text = "$ " & Math.Round(txttotal.Text + ((txttotal.Text - txtprimeros.Text) * 0.22), 0)
        Try
            Dim tabla As New DataTable
            conn.Open()
            Dim adaptador As New SqlDataAdapter("SELECT * FROM Lecturas where fecha >'25/10/2019' order by fecha ", conn)
            'Date.ParseExact(txtdesde.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), conn)
            conn.Close()
            adaptador.Fill(tabla)
            tabla.Columns.Add("Diario")
            For f = 1 To tabla.Rows.Count - 1
                tabla.Rows(f).Item("Diario") = Math.Round((Int(tabla.Rows(f).Item("Lectura") - tabla.Rows(f - 1).Item("Lectura"))) / (Int(DateAndTime.DateDiff("d", tabla.Rows(f - 1).Item("fecha"), tabla.Rows(f).Item("fecha")))), 0)
            Next
            GrafPromedios.Series.Clear()
            GrafPromedios.Series.Add("Consumos")
            For Each row In tabla.Rows
                GrafPromedios.Series("Consumos").Points.AddXY(row.item("fecha"), row.item("diario"))
                If Not IsDBNull(row.item("diario")) Then
                    GrafPromedios.Series("Consumos").Points(GrafPromedios.Series("Consumos").Points.Count - 1).Label = row.item("diario")
                End If
            Next
            GrafPromedios.Legends.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
