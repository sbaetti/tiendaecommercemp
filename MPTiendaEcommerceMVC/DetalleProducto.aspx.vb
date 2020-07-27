Public Class DetalleProducto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("id") IsNot Nothing Then
                If Request.QueryString("id") = 1234 Then
                    Me.pnDetalleProducto.Visible = True
                    Me.pnErrorFormulario.Visible = False
                Else
                    Me.pnDetalleProducto.Visible = False
                    Me.pnErrorFormulario.Visible = True
                End If
            Else
                Me.pnDetalleProducto.Visible = False
                Me.pnErrorFormulario.Visible = True
            End If
        End If
    End Sub

End Class