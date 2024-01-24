Public Class MyMsgs
   Shared Sub Err(msg As String)
      MessageBox.Show(msg, "!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
   End Sub
   Shared Sub Info(msg As String)
      MessageBox.Show(msg, "!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub
   Shared Sub Warning(msg As String)
      MessageBox.Show(msg, "...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
   End Sub
End Class
