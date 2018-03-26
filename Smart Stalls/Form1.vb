Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListPorts.Items.Add(sp)
        Next
        ListPorts.SelectedIndex = ListPorts.FindStringExact(My.Settings.com_port)

        TabMain.SelectedTab = TabRegister
    End Sub

    ' CLICKs
    Private Sub CmdRegister_Click(sender As Object, e As EventArgs) Handles CmdRegister.Click
        Dim port As String = ListPorts.SelectedItem.ToString
        If port.Length < 1 Then
            MessageBox.Show("Select COM Port", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Con As IO.Ports.SerialPort
        Try
            Using Con
                Con = My.Computer.Ports.OpenSerialPort(ListPorts.SelectedItem)
                Con.WriteLine("OK-REGISTER")
                Con.ReadTimeout = 5000
                Dim dialog As New DialogWaiting
                dialog.con = Con
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If Con.IsOpen Then
                Con.Close()
            End If
        End Try

    End Sub


    'CHANGE AND SAVE
    Private Sub ListPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPorts.SelectedIndexChanged
        My.Settings.com_port = ListPorts.SelectedItem
        My.Settings.Save()
    End Sub
End Class
