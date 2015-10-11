Imports System.IO
Public Class daemon
    Private Sub daemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Processes() As Process = Process.GetProcessesByName("updater")
            For Each Process As Process In Processes
                'kill process of updater
                Process.Kill()
            Next
            'update updater after process killed
            update_updater()
            MsgBox("Update Completed Sucessfully! Updater will now reopen", vbInformation, "Complete")
            'start updater
            Process.Start("updater.exe")
            'exit daemon
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub update_updater()

        Try
            'Declare application path
            Dim appPath As String = Application.StartupPath

            'Declare download directory path
            Dim downloadDir As String = Application.StartupPath & "\UpdaterUpdates"

            'Declare update files path
            Dim updateFiles As String = downloadDir & "\update.zip"

            'Create download directory
            Directory.CreateDirectory(downloadDir)

            'Download updates file in .zip file. Do not change this path, this daemon does not change!
            My.Computer.Network.DownloadFile("http://www.yourwebsite.com/updater.zip", updateFiles)

            'TODO: Add handling of 404!!

            'Get windows default zip creator/extrator 
            Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))

            'Declare the folder where the items will be extracted.
            Dim output As Object = shObj.NameSpace((appPath))

            'Declare the input zip file.
            Dim input As Object = shObj.NameSpace((updateFiles))

            'Extract the items from the zip file. Used option 16 to auto overwrite: https://msdn.microsoft.com/en-us/library/windows/desktop/bb787866%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396
            'If alot of files are to be extracted...copying dialogue will show...option is ignored by default (i think)
            output.CopyHere((input.Items), 16)

            'Clean up
            Directory.Delete(downloadDir, True)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

End Class
