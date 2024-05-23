Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module Module1

    Public cn As OleDbConnection
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public cmd As OleDbCommand
    Public tb As DataTable
    Public cryRpt As New ReportDocument
    Public crtableLogoinfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public crTables As Tables
    Public crtable As Table
    Public Sub Module_Konfigurasi_laporan()
        With crConnectionInfo
            .ServerName = (Application.StartupPath.ToString & "\db_Penyimpanan.accdb")
            .DatabaseName = (Application.StartupPath.ToString &
           "\db_Penyimpanan.accdb")
            .UserID = ""
            .Password = ""
        End With
        crTables = cryRpt.Database.Tables
        For Each crtb In crTables
            crtableLogoninfo = crtable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            crtable.ApplyLogOnInfo(crtableLogoninfo)
        Next
    End Sub
    Public Sub koneksi()
        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
       Application.StartupPath.ToString & "\db_Penyimpanan.accdb")
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

End Module
