Module Globals
   Public Wins As New List(Of Integer()) From {
      New Integer() {1, 2, 3},
      New Integer() {4, 5, 6},
      New Integer() {7, 8, 9},
      New Integer() {1, 4, 7},
      New Integer() {2, 5, 8},
      New Integer() {3, 6, 9},
      New Integer() {1, 5, 9},
      New Integer() {3, 5, 7}
   }
   Public PlayFolder As String = IO.Path.Combine(Application.StartupPath, "Play")
   Public LobbyFolder As String = IO.Path.Combine(PlayFolder, "Lobby")
   Public SettingsFile As String = IO.Path.Combine(PlayFolder, "Settings.txt")
   Public HostingWR As IO.StreamWriter = Nothing
   '
   Public HostingFile As String = IO.Path.Combine(PlayFolder, "Hosting.txt")
   Public Property Is_Hosting As Boolean
      Get
         Return MyFileIo.IsFileInUse(HostingFile)
      End Get
      Set(value As Boolean)
         If value = True Then
            HostingWR = New IO.StreamWriter(HostingFile)
         Else
            If HostingWR IsNot Nothing Then
               Try
                  HostingWR.Close()
                  GC.Collect()
                  GC.WaitForPendingFinalizers()
               Catch ex As Exception
               End Try
            End If
         End If
      End Set
   End Property

   '
   Public FscMySettings As New FileSettingsCreator2(Of MySettings)(SettingsFile, New MySettings)

   Public Sub CreateNeededFolders()
      If Not IO.Directory.Exists(PlayFolder) Then MkDir(PlayFolder)
      If Not IO.Directory.Exists(LobbyFolder) Then MkDir(LobbyFolder)
   End Sub

   Public Function IsProgrammer() As Boolean
      Return IO.Directory.Exists("C:\Users\soft10\source\repos\TikTakToe\bin\Debug")
   End Function
End Module
