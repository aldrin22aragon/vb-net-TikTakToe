Public Class Form1
   Friend WithEvents Hoster As AOATCPIP = Nothing

   Private Sub BtnStartHost_Click(sender As Object, e As EventArgs) Handles BtnStartHost.Click
      If Not Is_Hosting Then
         Dim pw As String = ""
         If IsProgrammer() Then
            pw = "drihnz"
         Else
            pw = InputBox("Please input Dev password", "Password", " ")
         End If
         If pw = "drihnz" Then
            Dim s As MySettings = FscMySettings.getSettings
            If s.FreePort = "" Then
               s.FreePort = AOATCPIP.FreeTcpPort
               FscMySettings.setSettings(s)
            End If
            Hoster = New AOATCPIP(s.FreePort)
            Is_Hosting = True
            Hoster.startListen()
         End If
      Else
         MyMsgs.Err("Host is already open.")
      End If
   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      CreateNeededFolders()
   End Sub

   Private Sub TimerHostChecking_Tick(sender As Object, e As EventArgs) Handles TimerHostChecking.Tick
      If Is_Hosting Then
         LblHost.Text = "Host is open."
      Else
         LblHost.Text = "Host no available."
      End If
   End Sub

   Private Sub BtnCreateLobby_Click(sender As Object, e As EventArgs) Handles BtnCreateLobby.Click
      If Is_Hosting Then
         Dim nputPlayerName As String = InputBox("Please enter player name", "Name", " ")
         Dim valid As String = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890"
         If nputPlayerName.Trim <> "" Then
            nputPlayerName = nputPlayerName.Trim.ToUpper
            Dim msg As String = ""
            For Each c As Char In nputPlayerName.ToCharArray
               If Not valid.Contains(c.ToString.ToUpper) Then
                  msg = "Invalid CHaracter found. Only Alpha numeric"
                  Exit For
               End If
            Next
            If msg = "" Then
               Dim game As New Game(Game.Task.CREATE_LOBBY, nputPlayerName)
               game.ShowDialog()
            Else
               MyMsgs.Err(msg)
            End If
         End If
      Else
         MyMsgs.Err("Please wait to the hoster to start.")
      End If
   End Sub


   'Private Sub Hoster_Recieved(sender As Object, e As AOATCPIP.SendReceInfo) Handles Hoster.Recieved
   '   Dim com As CommunicationInfo = CommunicationInfo.GetNew(e)
   '   Select Case com.Type
   '      Case CommunicationInfo.SendType.CREATE_LOBBY

   '   End Select
   'End Sub



End Class
