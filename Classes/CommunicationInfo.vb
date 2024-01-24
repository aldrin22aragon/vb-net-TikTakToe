Public Class CommunicationInfo
   Public Type As SendType = SendType.NONE
   Public Data As String = ""
   Enum SendType As Integer
      NONE = 0
      CREATE_LOBBY = 1
   End Enum
   Shared Function GetNew(r As AOATCPIP.SendReceInfo) As CommunicationInfo
      Dim res As New CommunicationInfo
      Return Newtonsoft.Json.JsonConvert.DeserializeObject(r.actionType, res.GetType)
   End Function
   Shared Function ConvertToSendReceInfo(r As CommunicationInfo) As AOATCPIP.SendReceInfo
      Dim a = Newtonsoft.Json.JsonConvert.SerializeObject(r)
      Return New AOATCPIP.SendReceInfo() With {.actionType = a}
   End Function
End Class
