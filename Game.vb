Public Class Game
   Enum Task
      CREATE_LOBBY
      ENTER_LOBBY
   End Enum
   Private ReadOnly PlayerName As String = ""
   Private WrLobby As IO.StreamWriter
   Sub New(playerName As String)
      InitializeComponent()
      Me.PlayerName = playerName
      CreateLobby_P1()
   End Sub
   Sub New(playerName As String, LobbyName As String)
      InitializeComponent()
      Me.PlayerName = playerName
      CreateLobby_P2(LobbyName)
   End Sub

   Function CreateLobby_P2(LobbyName As String) As String
      Dim res As String = ""
      Dim lobbyFile As String = IO.Path.Combine(LobbyFolder, String.Concat(LobbyName, "_P2_", PlayerName, ".txt"))
      Dim flWOext As String = IO.Path.GetFileNameWithoutExtension(lobbyFile)
      If Not MyFileIo.IsFileInUse(lobbyFile) Then
         WrLobby = New IO.StreamWriter(lobbyFile)
         WrLobby.WriteLine(PlayerName)
         res = lobbyFile
      Else
         MyMsgs.Err("Lobby is alreade")
      End If
      Return res
   End Function


   Public Function GetAllLobbysFilesThatIsRunning() As List(Of String)
      Dim r As New List(Of String)
      Dim files As String() = IO.Directory.GetFiles(LobbyFolder)
      For Each file As String In files
         Dim name As String = IO.Path.GetFileName(file).ToUpper
         If name.StartsWith("LOBBY_") AndAlso MyFileIo.IsFileInUse(file) Then
            r.Add(file)
         End If
      Next
      Return r
   End Function

   Function CreateLobby_P1() As String
      Dim res As String = ""
      For i As Integer = 1 To 100
         Dim lobbyFile As String = IO.Path.Combine(LobbyFolder, String.Concat("Lobby_", i, "_P1_", PlayerName, ".txt"))
         Dim flWOext As String = IO.Path.GetFileNameWithoutExtension(lobbyFile)
         If Not MyFileIo.IsFileInUse(lobbyFile) Then
            WrLobby = New IO.StreamWriter(lobbyFile)
            WrLobby.WriteLine(PlayerName)
            res = lobbyFile
            Exit For
         End If
      Next
      Return res
   End Function

   Private Sub Game_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      Try
         WrLobby.Close()
         GC.Collect()
         GC.WaitForPendingFinalizers()
      Catch ex As Exception

      End Try
   End Sub

   Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub
End Class