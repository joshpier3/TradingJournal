Imports TradingJournal.Data

Public Class TradeAssetService
    Private _context As TradeJournalDBContext

    Public Sub New(context As TradeJournalDBContext)
        _context = context
    End Sub

    Public Function DoesAssetAlreadyExists(name As String, type As String) As Boolean
        Return _context.TradeAsset.Where(Function(a) a.Name = name AndAlso a.Type = type).Any()
    End Function

    Public Function AddAsset(name As String, type As String) As TradeAsset
        If DoesAssetAlreadyExists(name, type) Then
            Throw New Exception("This trade asset already exists.")
        End If

        Return _context.TradeAsset.Add(New TradeAsset With {.Name = name, .Type = type}).Entity
    End Function
End Class
