Imports System.IO
Imports System.Threading.Tasks
Imports System.Web.Mvc
Imports Newtonsoft.Json.Linq

Namespace Controllers
    Public Class NotificacionController
        Inherits Controller

        ' GET: Notificacion
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Notificacion/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Notificacion/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Notificacion/Payment
        <HttpPost, ActionName("Payment"), AcceptVerbs("GET", "POST")>
        Function Payment() As ActionResult
            'Dim requestheader As NameValueCollection = HttpContext.Request.Headers
            'Dim requestbody As String
            'Using reader As StreamReader = New StreamReader(HttpContext.Request.Body)

            'End Using
            Return View()
            'GetDocumentContents(Request)
        End Function

    End Class
End Namespace