Imports Scripting
Imports System.Runtime.InteropServices

Public Class Form1
    Inherits System.Windows.Forms.Form

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Dim FSO As FileSystemObject
    Dim CARPETA As Folder
    Dim ARCHIVO As File
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim nombreArchivo As String
        Dim cantidadArchiv As Long
        cantidadArchiv = 0
        nombreArchivo = PathFile.Text

        Call Cargar_Archivo(nombreArchivo, cantidadArchiv)

        MsgBox(cantidadArchiv)

    End Sub

    Public Sub Cargar_Archivo(ByVal nombreArchivo As String, ByRef cantidadArchiv As Long)

        FSO = New FileSystemObject

        CARPETA = FSO.GetFolder(nombreArchivo)

        For Each ARCHIVO In CARPETA.Files
            If InStr(ARCHIVO.Name, "xlsx") Then
                Call conectorBase(ARCHIVO.Path)
            End If
            cantidadArchiv = cantidadArchiv + 1
        Next ARCHIVO


    End Sub

    Public Sub conectorBase(nombreArchivo As String)
        Dim excelApp = New Microsoft.Office.Interop.Excel.Application
        Dim workB = excelApp.Workbooks.Open(nombreArchivo)

        workB.SaveAs(Replace(nombreArchivo, "xlsx", "txt"), FileFormat:=Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV)


        workB.Close()
        excelApp.ScreenUpdating = False
        excelApp.Quit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        Maximizar.Visible = False
        Restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Restaurar.Visible = False
        Maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultar.Tick
        If PanelDinamico.Width <= 53 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.PanelDinamico.Width = PanelDinamico.Width - 20
        End If
    End Sub

    Private Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If PanelDinamico.Width >= 133 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.PanelDinamico.Width = PanelDinamico.Width + 20
        End If
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click

        If PanelDinamico.Width = 133 Then
            tmOcultar.Enabled = True
        ElseIf PanelDinamico.Width = 53 Then
            tmMostrar.Enabled = True
        End If
        ' tmMostrar.Enabled = True
    End Sub
End Class
