Public Class DialogWaiting
    Public con As IO.Ports.SerialPort
    Private Sub DialogWaiting_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim th As New Threading.Thread(AddressOf doWait)
        th.Start()
    End Sub

    Private Sub doWait()
        Try
            Do
                Dim Incoming As String = con.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    Me.Invoke(Sub()
                                  MetroLabel1.Text = Incoming.Replace("\n", "").Replace(vbCr, "").Replace(vbLf, "")
                              End Sub)
                End If
            Loop
        Catch ex As Exception
        End Try
        Me.Invoke(Sub() Me.Close())
    End Sub
End Class