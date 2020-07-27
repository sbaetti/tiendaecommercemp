Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class WebhookController
        Inherits ApiController

        ' GET: api/Webhook
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Webhook/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Webhook/payment
        <HttpPost()>
        Public Function Payment(<FromBody()> ByVal value As Object) As IHttpActionResult
            'Guardaria el value con el json

            Return StatusCode(HttpStatusCode.OK)
        End Function
    End Class
End Namespace