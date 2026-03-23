Imports TradingJournal.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim assetDialog = New TradeAssetPropertiesDialog() With
           {
           .Title = "Add Trade Asset",
           .OkButtonText = "Add"
           }
        If assetDialog.ShowDialog() = DialogResult.OK Then
            Using context = New TradeJournalDBContext()
                Dim tradeAssetService = New TradeAssetService(context)
                Dim asset = tradeAssetService.AddAsset(assetDialog.AssetName, assetDialog.AssetType)
                MessageBox.Show($"id:{asset.Id}, name:{asset.Name}, type:{asset.Type}")
                context.SaveChanges()
            End Using
        End If
    End Sub
End Class
