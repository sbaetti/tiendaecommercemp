Imports System.IO
Imports System.Net.Mail
Imports System.Threading.Tasks
Imports Microsoft.AspNet.WebHooks
Imports Newtonsoft.Json.Linq

Public Class testhandler
    Inherits WebHookHandler

    'Public Overrides Function ExecuteAsync(ByVal receiver As String, ByVal context As WebHookHandlerContext) As Task

    '    Return Task.FromResult(True)
    'End Function


    Public Overrides Function ExecuteAsync(ByVal generator As String, ByVal context As WebHookHandlerContext) As Task
        Dim data As JObject = context.GetDataOrDefault(Of JObject)()

        Dim Mail As New MailMessage
        Dim SMTP As New SmtpClient("smtp.gmail.com")

        Mail.Subject = "webhook"
        Mail.From = New MailAddress("buntudeco@gmail.com")
        SMTP.Credentials = New System.Net.NetworkCredential("buntudeco@gmail.com", "Point2050") '<-- Password Here

        Mail.To.Add("sebastianbaetti@gmail.com")

        Mail.Body = data.ToString()

        SMTP.EnableSsl = True
        SMTP.Port = "587"
        SMTP.Send(Mail)


        Return Task.FromResult(True)
    End Function
End Class
