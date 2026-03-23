Imports Microsoft.EntityFrameworkCore
Imports Microsoft.VisualBasic.ApplicationServices
Imports TradingJournal.Data

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication
        Protected Overrides Function OnStartup(eventArgs As StartupEventArgs) As Boolean
            Using context = New TradingJournal.Data.TradeJournalDBContext
                context.Database.Migrate()

                'Test Code
                'Dim assetId = context.Add(New TradeAsset With {.Name = "MNQ", .Type = "Futures"}).Entity.Id
                'context.Add(New TradeAsset With {.Name = "Nasdaq", .Type = "ETF"})
                'context.Add(New TradeAsset With {.Name = "Nasdaq", .Type = "Futures"})

                'context.SaveChanges()

                'Dim tradeId = context.Add(New Trade With {
                '                          .AssetId = context.TradeAsset.First().Id,
                '                          .Pnl = -100.23,
                '                          .Fees = 2.1,
                '                          .Quanity = 1,
                '                          .StartTime = DateTime.Now,
                '                          .EndTime = DateTime.Now.AddMinutes(-60)
                '                          }).Entity.Id

                'context.SaveChanges()

                'Dim entryId = context.Add(New TradeJournalEntry With {
                '                          .TradeId = context.Trade.First().Id,
                '                          .Title = "Bad day for MNQ.",
                '                          .Entry = "I took a trade and lost."}).Entity.Id


                'context.SaveChanges()
            End Using

            Return MyBase.OnStartup(eventArgs)
        End Function
    End Class
End Namespace
