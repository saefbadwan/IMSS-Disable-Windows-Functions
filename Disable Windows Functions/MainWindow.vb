' بسم الله الرحمن الرحيم
Imports Microsoft.Win32
Imports System.IO
Imports DevComponents.DotNetBar

Public Class MainWindow
    Private _IMSS_RegistryEditorClass As New clsNGSRegistry
    Private _IMSS_RegistryGetValue As RegistryKey
    Private Const _IMSS_LOCALMACHINERIGSTRYPATH As String = "HKEY_LOCAL_MACHINE\"
    Private _IMSS_ThreadingControllar As Threading.Thread
    Private Sub MainWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        _IMSS_CheckHibernationfile_On_Off_Get_Size()
        _IMSS_WindowsSearchiIndex_On_Off_Get_Size()
    End Sub
#Region "IMSS Load Status"
    Private Sub _IMSS_CheckHibernationfile_On_Off_Get_Size()
        If _IMSS_RegistryEditorClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SYSTEM\CurrentControlSet\Control\Power") = True Then
            If Registry.GetValue(_IMSS_LOCALMACHINERIGSTRYPATH & "SYSTEM\CurrentControlSet\Control\Power", "HibernateEnabled", "ERROR") = 1 Then
                _IMSS_Hibernationfile_On_Off.Value = True : Else : _IMSS_Hibernationfile_On_Off.Value = False
            End If
        End If
        If IO.File.Exists("C:\hiberfil.sys") Then : _IMSS_Hibernationfile_OutPutLabel.Text _
        = (_IMSS_BytesToMegabytes(New FileInfo("C:\hiberfil.sys").Length)).ToString() & " MB" : Else : _IMSS_Hibernationfile_OutPutLabel.Text = "None" : End If
    End Sub
    Private Sub _IMSS_WindowsSearchiIndex_On_Off_Get_Size()
        If _IMSS_WindowsSearchIndexService.Status = ServiceProcess.ServiceControllerStatus.Running Then
            _IMSS_WindowsSearchiIndex_On_Off.Value = True
            If IO.File.Exists("C:\hiberfil.sys") Then : _IMSS_WindowsSearchIndex_Label.Text _
       = (_IMSS_BytesToMegabytes(New FileInfo("C:\ProgramData\Microsoft\Search\Data\Applications\Windows\Windows.edb").Length)).ToString() & " MB" : End If
        Else : _IMSS_WindowsSearchiIndex_On_Off.Value = False : _IMSS_WindowsSearchIndex_Label.Text = "None"
        End If
        ' Windows XP Path  C:\Documents and Settings\Application Data\All Users\Microsoft\Search\Data\Applications\Windows\Windows.edb
    End Sub
#End Region
    Private Sub _IMSS_Hibernationfile_On_Off_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Hibernationfile_On_Off.ValueChanged
        If _IMSS_CheckIfByUser = True Then
            _IMSS_Hibernationfile_On_Off.Enabled = False
            If _IMSS_Hibernationfile_On_Off.Value = True Then : Shell("powercfg -h on", AppWinStyle.Hide, True) _
                    : Else : Shell("powercfg -h off", AppWinStyle.Hide, True) : End If
            _IMSS_Hibernationfile_On_Off.Enabled = True : _IMSS_CheckHibernationfile_On_Off_Get_Size() : _IMSS_CheckIfByUser = True
        End If
    End Sub
    Private Function _IMSS_BytesToMegabytes(ByVal Bytes As Double) As Double
        Dim dblAns As Double : dblAns = (Bytes / 1024) / 1024
        _IMSS_BytesToMegabytes = Format(dblAns, "###,###,##0.00")
    End Function

    Private Sub _IMSS_WindowsSearchiIndex_On_Off_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WindowsSearchiIndex_On_Off.ValueChanged
        If _IMSS_CheckIfByUser = True Then
            Me.Cursor = Cursors.WaitCursor
            _IMSS_ThreadingControllar = New Threading.Thread(AddressOf _IMSS_WindowsSearchiIndex_On_Off_BackGroungWorker)
            _IMSS_ThreadingControllar.Priority = Threading.ThreadPriority.Highest
            _IMSS_ThreadingControllar.Start()
            _IMSS_CheckIfByUser = True
        End If
    End Sub
    Private Sub _IMSS_WindowsSearchiIndex_On_Off_BackGroungWorker()
        If Me.InvokeRequired = True Then
            Me.Invoke(New MethodInvoker(AddressOf _IMSS_WindowsSearchiIndex_On_Off_BackGroungWorker)) : Else
            If _IMSS_WindowsSearchiIndex_On_Off.Value = False Then : Shell("sc config wsearch start= disabled", AppWinStyle.Hide, True) : Shell("net stop wsearch", AppWinStyle.Hide, True) _
          : _IMSS_WindowsSearchIndex_Label.Text = "None" : Else : Shell("sc config wsearch start= auto", AppWinStyle.Hide, True) : Shell("net start wsearch", AppWinStyle.Hide, True)
                If IO.File.Exists("C:\hiberfil.sys") Then : _IMSS_WindowsSearchIndex_Label.Text _
           = (_IMSS_BytesToMegabytes(New FileInfo("C:\ProgramData\Microsoft\Search\Data\Applications\Windows\Windows.edb").Length)).ToString() & " MB" _
                : End If : End If : Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub _IMSS_SUWS_Configure_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_SUWS_Configure.LinkClicked
        Dim _IMSS_ConfigureOptions As New IMSS_ConfigureOptions
        _IMSS_ConfigureOptions.ShowDialog()
    End Sub

    Private Sub _IMSS_Done_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Done_Button.Click
        Application.Exit()
    End Sub
    Private _IMSS_CheckIfByUser As Boolean = False
    Private Sub _IMSS_Hibernationfile_On_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Hibernationfile_On_Off.Click
        _IMSS_CheckIfByUser = True
    End Sub

    Private Sub _IMSS_WindowsSearchiIndex_On_Off_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_WindowsSearchiIndex_On_Off.Click
        _IMSS_CheckIfByUser = True
    End Sub
End Class
