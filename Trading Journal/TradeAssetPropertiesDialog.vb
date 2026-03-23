Imports TradingJournal.Data

Public Class TradeAssetPropertiesDialog
    Public Property AssetName As String
        Get
            Return TextBoxName.Text
        End Get
        Set(value As String)
            TextBoxName.Text = value
        End Set
    End Property

    Public Property AssetType As String
        Get
            Return TextBoxType.Text
        End Get
        Set(value As String)
            TextBoxType.Text = value
        End Set
    End Property

    Public Property OkButtonText As String
        Get
            Return ButtonOk.Text
        End Get
        Set(value As String)
            ButtonOk.Text = value
        End Set
    End Property

    Public Property CancelButtonText As String
        Get
            Return ButtonCancel.Text
        End Get
        Set(value As String)
            ButtonCancel.Text = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return Me.Text
        End Get
        Set(value As String)
            Me.Text = value
        End Set
    End Property

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged
        ValidateForm()
    End Sub

    Private Sub TextBoxType_TextChanged(sender As Object, e As EventArgs) Handles TextBoxType.TextChanged
        ValidateForm()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Using context = New TradeJournalDBContext()
            Dim tradeAssetService = New TradeAssetService(context)
            If tradeAssetService.DoesAssetAlreadyExists(AssetName, AssetType) Then
                MessageBox.Show("This asset already exists.")
                Return
            End If
        End Using

        DialogResult = DialogResult.OK
    End Sub

    Private Sub ValidateForm()
        ButtonOk.Enabled = Not String.IsNullOrWhiteSpace(AssetName) AndAlso Not String.IsNullOrWhiteSpace(AssetType)
    End Sub

    Private Sub TradeAssetPropertiesDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonOk.Enabled = False
        ValidateForm()
    End Sub
End Class