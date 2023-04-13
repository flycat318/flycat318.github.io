Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Gold")
        ComboBox1.Items.Add("Biru")
        ComboBox1.Items.Add("Hitam")

        Dim Arr(3, 1) As String
        Arr(0, 0) = "Warna"
        Arr(0, 1) = "Merk"
        Arr(1, 0) = "Harga"
        Arr(1, 1) = "Jumlah"
        Arr(2, 0) = "Total Harga"
        Arr(2, 1) = "Diskon"
        Arr(3, 0) = "Total Bayar"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For Baris = 0 To 3
            For Kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, Kolom), 100)
            Next Kolom
        Next Baris
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Gold" Then
            ComboBox2.Items.Clear()
            ComboBox1.Text = " "
            ComboBox2.Items.Add("RCB-G")
            ComboBox2.Items.Add("Vrossi-G")
            ComboBox2.Items.Add("BRT Chemco-G")

        ElseIf ComboBox1.Text = "Biru" Then
            ComboBox2.Items.Clear()
            ComboBox1.Text = " "
            ComboBox2.Items.Add("RCB-B")
            ComboBox2.Items.Add("Vrossi-B")
            ComboBox2.Items.Add("BRT Chemco-B")

        ElseIf ComboBox1.Text = "Hitam" Then
            ComboBox2.Items.Clear()
            ComboBox1.Text = " "
            ComboBox2.Items.Add("RCB-H")
            ComboBox2.Items.Add("Vrossi-H")
            ComboBox2.Items.Add("BRT Chemco-H")

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "RCB-G" Then
            TextBox1.Text = 2200000
        ElseIf ComboBox2.Text = "Vrossi-G" Then
            TextBox1.Text = 1300000
        ElseIf ComboBox2.Text = "BRT Chemco-G" Then
            TextBox1.Text = 1500000
        ElseIf ComboBox2.Text = "RCB-B" Then
            TextBox1.Text = 2200000
        ElseIf ComboBox2.Text = "Vrossi-B" Then
            TextBox1.Text = 1300000
        ElseIf ComboBox2.Text = "BRT Chemco-B" Then
            TextBox1.Text = 1500000
        ElseIf ComboBox2.Text = "RCB-H" Then
            TextBox1.Text = 2200000
        ElseIf ComboBox2.Text = "Vrossi-H" Then
            TextBox1.Text = 1300000
        ElseIf ComboBox2.Text = "BRT Chemco-H" Then
            TextBox1.Text = 1500000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        If TextBox3.Text > 100000 Then
            TextBox4.Text = 15000
        Else
            TextBox4.Text = 0
        End If
        TextBox5.Text = Val(TextBox3.Text) - Val(TextBox4.Text)

        Dim Arr(6) As String
        Arr(0) = ComboBox1.Text
        Arr(1) = ComboBox2.Text
        Arr(2) = TextBox1.Text
        Arr(3) = TextBox2.Text
        Arr(4) = TextBox3.Text
        Arr(5) = TextBox4.Text
        Arr(6) = TextBox5.Text

        Dim Listitem As ListViewItem
        Listitem = ListView1.Items.Add(Arr(0))
        Listitem.SubItems.Add(Arr(1))
        Listitem.SubItems.Add(Arr(2))
        Listitem.SubItems.Add(Arr(3))
        Listitem.SubItems.Add(Arr(4))
        Listitem.SubItems.Add(Arr(5))
        Listitem.SubItems.Add(Arr(6))
        TextBox1.Text = " "
        TextBox2.Text = " "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        ComboBox1.Text = " "
        ComboBox2.Text = " "
    End Sub
End Class
