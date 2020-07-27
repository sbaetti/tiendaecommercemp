Public Class PagoRechazado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("collection_id") IsNot Nothing Then
                If Request.QueryString("collection_id") <> String.Empty Then
                    Me.txtpaymentmethodid.Text = Request.QueryString("collection_id")
                End If
            End If
            If Request.QueryString("collection_status") IsNot Nothing Then
                If Request.QueryString("collection_status") <> String.Empty Then
                    Me.txtStatus.Text = Request.QueryString("collection_status")
                End If
            End If
            If Request.QueryString("external_reference") IsNot Nothing Then
                If Request.QueryString("external_reference") <> String.Empty Then
                    Me.txtreferencia.Text = Request.QueryString("external_reference")
                End If
            End If
        End If
    End Sub

End Class