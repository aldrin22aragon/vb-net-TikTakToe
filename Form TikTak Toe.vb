
Public Class Form_TikTak_Toe
   Dim LastFistmove As EnumPlayer = EnumPlayer.none
   Dim MoveCounts As Integer = 0
   Private Sub P1_Click(sender As Object, e As EventArgs) Handles P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P4.Click, P3.Click, P2.Click, P1.Click
      If Mode <> EnumMode.WinsFound Then
         Dim pnl As Panel = DirectCast(sender, Panel)
         Dim panelvalue As PanelValue = pnl.Tag
         If panelvalue = PanelValue.NONE Then
            Dim lastP As EnumPlayer = CurrentPlayer
            MoveCounts += 1
            Select Case CurrentPlayer
               Case EnumPlayer.none
                  SetMarkvalue(pnl.Name, PanelValue.NONE)
               Case EnumPlayer.P1
                  SetMarkvalue(pnl.Name, PanelValue.X)
                  CurrentPlayer = EnumPlayer.P2
               Case EnumPlayer.P2
                  SetMarkvalue(pnl.Name, PanelValue.O)
                  CurrentPlayer = EnumPlayer.P1
            End Select
            If CurrVsMode = VSMode._Vs_AI Then
               Dim P1Marks As List(Of Integer) = GetPanelWithXMarks()
               For Each i As Integer() In Wins

               Next
            End If
            If IsHaveWinner() Then
               Mode = EnumMode.WinsFound
               MyMsgs.Info("Player " & lastP.ToString & " WINS!!!!")
            End If
         End If
      End If
      If MoveCounts = 9 Then
         BtnRestart.Enabled = True
      End If
   End Sub

   Function GetPanelWithXMarks() As List(Of Integer)
      Dim res As New List(Of Integer)
      For i As Integer = 1 To 9
         Dim mark As PanelValue = GetMarkvalue("P" & i)
         If mark = PanelValue.X Then
            res.Add(i)
         End If
      Next
      Return res
   End Function

   Function IsHaveWinner() As Boolean
      Dim r As Boolean = False
      For Each i As Integer() In Wins
         Dim m1 As PanelValue = GetMarkvalue("P" & i(0))
         Dim m2 As PanelValue = GetMarkvalue("P" & i(1))
         Dim m3 As PanelValue = GetMarkvalue("P" & i(2))
         If m1 = m2 And m2 = m3 And m3 <> PanelValue.NONE Then
            r = True
            Exit For
         End If
      Next
      Return r
   End Function

   Enum VSMode As Integer
      _2Player = 1
      _Vs_AI = 2
   End Enum
   Dim _CurrVsMode As VSMode = VSMode._2Player
   Property CurrVsMode As VSMode
      Get
         Return _CurrVsMode
      End Get
      Set(value As VSMode)
         _CurrVsMode = value
      End Set
   End Property

   Enum PanelValue As Integer
      NONE = 0
      X = 1
      O = 2
   End Enum
   Enum EnumMode As Integer
      Browse = 0
      Started = 1
      WinsFound = 2
   End Enum
   Enum EnumPlayer As Integer
      none = 0
      P1 = 1
      P2 = 2
   End Enum
   Public _CurrentPlayer As EnumPlayer = EnumPlayer.none
   Property CurrentPlayer As EnumPlayer
      Get
         Return _CurrentPlayer
      End Get
      Set(value As EnumPlayer)
         _CurrentPlayer = value
         Select Case value
            Case EnumPlayer.none
               LblP1.BackColor = Color.White
               LblP2.BackColor = Color.White
               Label1.Text = ""
            Case EnumPlayer.P1
               LblP1.BackColor = Color.LightGreen
               LblP2.BackColor = Color.White
               Label1.Text = "Player 1 Turn"
            Case EnumPlayer.P2
               LblP1.BackColor = Color.White
               LblP2.BackColor = Color.LightGreen
               Label1.Text = "Player 2 Turn"
         End Select
      End Set
   End Property
   Dim tmpMode As EnumMode = EnumMode.Browse
   Property Mode As EnumMode
      Get
         Return tmpMode
      End Get
      Set(value As EnumMode)
         tmpMode = value
         Select Case value
            Case EnumMode.Browse
               CbChooseEnemy.Enabled = True
               BtnStart.Enabled = True
               BtnRestart.Enabled = False
               CurrentPlayer = EnumPlayer.none
               ResetMarks()
            Case EnumMode.Started
               CbChooseEnemy.Enabled = False
               BtnStart.Enabled = False
               BtnRestart.Enabled = False
               If LastFistmove = EnumPlayer.none Then
                  CurrentPlayer = EnumPlayer.P1
               Else
                  CurrentPlayer = EnumPlayer.P2
               End If
               LastFistmove = CurrentPlayer
               ResetMarks()
               MoveCounts = 0
            Case EnumMode.WinsFound
               CbChooseEnemy.Enabled = True
               BtnStart.Enabled = True
               BtnRestart.Enabled = True
               CurrentPlayer = EnumPlayer.none
         End Select
      End Set
   End Property

   Sub ResetMarks()
      For i As Integer = 1 To 9
         Dim panelName As String = "P" & i
         SetMarkvalue(panelName, PanelValue.NONE)
      Next
   End Sub
   Function GetMarkvalue(name As String) As PanelValue
      Dim panel As Panel = Me.Controls.Item(name)
      Dim v As PanelValue = panel.Tag
      Return v
   End Function
   Sub SetMarkvalue(name As String, value As PanelValue)
      Dim panel As Panel = Me.Controls.Item(name)
      Select Case value
         Case PanelValue.NONE
            panel.BackgroundImage = Nothing
         Case PanelValue.O
            panel.BackgroundImage = My.Resources.O
         Case PanelValue.X
            panel.BackgroundImage = My.Resources.X
      End Select
      panel.Tag = value
   End Sub

   Private Sub Form_TikTak_Toe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Mode = EnumMode.Browse
      CbChooseEnemy.SelectedIndex = 0
      callCam()
   End Sub

   Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
      Mode = EnumMode.Started
   End Sub

   Private Sub CbChooseEnemy_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbChooseEnemy.SelectedValueChanged
      If CbChooseEnemy.SelectedItem IsNot Nothing Then
         If CbChooseEnemy.SelectedItem.ToString = "2 PLAYER" Then
            LblP2.Text = "P2 = O"
            CurrVsMode = VSMode._2Player
         Else
            LblP2.Text = "P2_AI = O"
            CurrVsMode = VSMode._Vs_AI
            '2 PLAYER
            'VS ai
         End If
      End If
   End Sub

   Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
      Mode = EnumMode.Browse
   End Sub

   Class AI
      Private FirstMovePercentageToStartCenter As Integer = 60
   End Class
   ''

   Public Sub callCam()

   End Sub

End Class