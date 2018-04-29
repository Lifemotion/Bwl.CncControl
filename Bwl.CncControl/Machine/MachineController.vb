Public Class MachineController
    Private _port As New IO.Ports.SerialPort

    Public Property SerialPortNameSetting As String = "COM0"
    Public Property SerialPortSpeedSetting As String = "115200"

    Public Event Logger(type As String, msg As String)

    Private Sub Open()
        If _port.IsOpen = False OrElse
           _port.PortName <> SerialPortNameSetting OrElse
           _port.BaudRate <> SerialPortSpeedSetting Then
            _port.Close()
            Try
                _port.PortName = SerialPortNameSetting
                _port.BaudRate = SerialPortSpeedSetting
                _port.Open()
            Catch ex As Exception
                RaiseEvent Logger("ERR", "Failed to open port: " + ex.Message)
                Throw New Exception("Machine is not connected!")
            End Try
        End If
    End Sub

    Public Sub MoveRelative(xMm As Double, yMm As Double, zMm As Double)
        Open()
        Dim cmd = "G91G0"
        If xMm <> 0 Then cmd += "X" + xMm.ToString("0.00").Replace(",", ".")
        If yMm <> 0 Then cmd += "Y" + yMm.ToString("0.00").Replace(",", ".")
        If zMm <> 0 Then cmd += "Z" + zMm.ToString("0.00").Replace(",", ".")
        _port.WriteLine(cmd)
    End Sub
End Class
