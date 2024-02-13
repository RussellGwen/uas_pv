Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Memanggil prosedur untuk membaca file saat form dimuat
        ReadFile()
    End Sub

    Private Sub ReadFile()
        ' Membaca file "data.txt" yang berisi beberapa baris teks
        Dim filePath As String = "data.txt"

        ' Memeriksa apakah file ada
        If File.Exists(filePath) Then
            ' Membuka file dan membaca baris per baris
            Using reader As New StreamReader(filePath)
                Dim line As String
                While Not reader.EndOfStream
                    line = reader.ReadLine()

                    ' Menampilkan setiap baris teks pada ListBox
                    Result.Items.Add(line)
                End While
            End Using
        Else
            MessageBox.Show("File tidak ditemukan!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Memanggil prosedur untuk melakukan perulangan pada ListBox
        LoopThroughListBox()
    End Sub

    Private Sub LoopThroughListBox()
        ' Melakukan perulangan pada setiap item di ListBox
        For Each item As String In Result.Items
            ' Menampilkan setiap item dalam pesan dialog
            MessageBox.Show(item)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Memanggil prosedur untuk melakukan percabangan
        Branching()
    End Sub

    Private Sub Branching()
        ' Memeriksa apakah ListBox memiliki item
        If Result.Items.Count > 0 Then
            MessageBox.Show("data.txt Found!")
        Else
            MessageBox.Show("data.txt Not Found!")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Result.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
