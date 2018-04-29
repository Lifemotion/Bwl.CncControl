Imports Bwl.Framework

Public Class App
    Private _machine As New MachineController
    Private _machineSettings As New AutoSettings(_storage.CreateChildStorage("Machine"), _machine)

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _logger.CollectLogs(_machine)
        DirectControl1.Machine = _machine
    End Sub
End Class
