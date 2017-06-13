' بسم الله الرحمن الرحيم
Imports Microsoft.Win32
Imports System.IO
Imports DevComponents.DotNetBar
Public Class IMSS_ConfigureOptions
    Private _IMSS_RegistryEditorClass As New clsNGSRegistry
    Private _IMSS_RegistryGetValue As RegistryKey
    Private Const _IMSS_LOCALMACHINERIGSTRYPATH As String = "HKEY_LOCAL_MACHINE\"
    Private Sub IMSS_ConfigureOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Settings._IMSS_SetSettings = True Then
            _IMSS_GetValueAndSave()
            My.Settings._IMSS_SetSettings = True
        End If
    End Sub
    Private Sub _IMSS_Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub _IMSS_GetValueAndSave()
        If _IMSS_RegistryEditorClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SYSTEM\CurrentControlSet\Control") = True Then
            If Not _IMSS_LoadAndConvert() = 0 Then
                My.Settings._IMSS_SV = _IMSS_LoadAndConvert()
                My.Settings.Save()
            End If
        End If
    End Sub
    Private Function _IMSS_LoadAndConvert() As Integer
        Dim _IMSS_IntegerToStringConvert As String = String.Empty
        If Not Registry.GetValue(_IMSS_LOCALMACHINERIGSTRYPATH & "SYSTEM\CurrentControlSet\Control", "WaitToKillServiceTimeout", "ERROR") = Nothing Then
            _IMSS_IntegerToStringConvert = Registry.GetValue(_IMSS_LOCALMACHINERIGSTRYPATH & "SYSTEM\CurrentControlSet\Control", "WaitToKillServiceTimeout", "ERROR")
            If _IMSS_IntegerToStringConvert = "ERROR" Then
                Return 0
                Exit Function
            End If
        End If
        Return CType(_IMSS_IntegerToStringConvert, Integer)
    End Function
    Private Sub _IMSS_OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OK_Button.Click
        If _IMSS_SpeedUpToStageOne_RadioButton.Checked = True Then
            _IMSS_SetValue(5000)
        ElseIf _IMSS_SpeedUpToStageTwo_RadioButton.Checked = True Then
            _IMSS_SetValue(1000)
        Else
        End If
        Me.Close()
    End Sub
    Private Sub _IMSS_SetValue(ByVal _IMSS_STATUS As Integer)
        If _IMSS_RegistryEditorClass.DoesKeyExist(clsNGSRegistry.ERegistryPossibleRoots.HKEY_LOCALE_MACHINE, "SYSTEM\CurrentControlSet\Control") = True Then
            Registry.SetValue(_IMSS_LOCALMACHINERIGSTRYPATH & "SYSTEM\CurrentControlSet\Control", "WaitToKillServiceTimeout", _IMSS_STATUS)
        End If
    End Sub

    Private Sub _IMSS_RestoreDefault_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RestoreDefault_Button.Click
        On Error Resume Next
        _IMSS_SpeedUpToStageOne_RadioButton.Checked = False
        _IMSS_SpeedUpToStageTwo_RadioButton.Checked = False
        _IMSS_StopClearingPageFile_CheckBox.Checked = False
        _IMSS_SetValue(My.Settings._IMSS_SV)
        Me.Close()
    End Sub
End Class