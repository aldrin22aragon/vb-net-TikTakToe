Imports System.IO

Public Class MyFileIo
   Shared Function IsFileInUse(FilePath As String, Optional displayMsg As Boolean = False) As Boolean
      Try
         If IO.File.Exists(FilePath) Then
            Dim FS As IO.FileStream = IO.File.Open(FilePath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
            FS.Close()
            FS.Dispose()
            FS = Nothing
            Return False
         Else
            Return False
         End If
      Catch ioEX As IOException
         If displayMsg Then
            MsgBox("File " & vbNewLine & FilePath & vbNewLine & " is In Use!", MsgBoxStyle.Critical, "")
         End If
         Return True
      Catch ex As Exception
         If displayMsg Then
            MsgBox("Unknown error occured!", MsgBoxStyle.Critical, "")
         End If
         Return True
      End Try
   End Function
End Class
