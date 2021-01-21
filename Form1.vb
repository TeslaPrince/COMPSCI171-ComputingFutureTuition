Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim year As Integer
        Dim tuition As Double
        Dim counter As Integer
        Dim fmt As String = "{0,-15}{1,-15}"
        year = CInt(txtYear.Text)
        tuition = CInt(txtTuition.Text)
        ListBox1.Items.Add(String.Format(fmt, "Year", "Tuition"))
        ListBox1.Items.Add(String.Format(fmt, "----", "----"))
        Do While counter <= 9
            counter = counter + 1
            year = year + 1
            tuition = (tuition * 0.05) + tuition
            ListBox1.Items.Add(String.Format(fmt, year, String.Format("{0:C}", tuition)))
        Loop
    End Sub
End Class
