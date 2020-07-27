Imports MercadoPago
Imports MercadoPago.Resources
Imports MercadoPago.DataStructures.Preference
Imports MercadoPago.Common

Public Class ConfirmarCompra
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarBotonMercadoPago()
        End If
    End Sub


    Private Sub CargarBotonMercadoPago()

        'Vendedor
        'collector_id: 469485398
        'public key: APP_USR-7eb0138a-189f-4bec-87d1-c0504ead5626
        'AccessToken: APP_USR-6317427424180639-042414-47e969706991d3a442922b0702a0da44-469485398


        'Test user Comprador
        'Id:471923173
        'Email:test_user_63274575@testuser.com
        'password: qatest2417

        'MercadoPago.SDK.AccessToken = "APP_USR-6317427424180639-042414-47e969706991d3a442922b0702a0da44-469485398"
        'MercadoPago.SDK.IntegratorId = "dev_24c65fb163bf11ea96500242ac130004"
        If MercadoPago.SDK.AccessToken = String.Empty Then
            MercadoPago.SDK.AccessToken = ConfigurationManager.AppSettings("AccessToken").ToString()
        End If
        If MercadoPago.SDK.IntegratorId = String.Empty Then
            MercadoPago.SDK.IntegratorId = ConfigurationManager.AppSettings("IntegratorId").ToString()
        End If


        Dim oPreference As Preference = New Preference()

        Dim comprador As Payer = New Payer() With
                                 {.Date_created = System.DateTime.Now.Date,
                                 .Name = "Lalo",
                                 .Surname = "Landa",
                                 .Email = "test_user_63274575@testuser.com",
                                 .Address = New Address() With {.StreetName = "False", .StreetNumber = 123, .ZipCode = 1111},
                                 .Phone = New Phone() With {.AreaCode = 11, .Number = 22223333}
                                 }


        oPreference.Items.Add(New Item With
                                 {.Id = "1234",
                                  .Title = "Samsung Galaxy A10 32 GB Negro 2 GB RAM",
                                  .Description = "Dispositivo móvil de Tienda e-commerce",
                                  .Quantity = 1,
                                  .CurrencyId = Common.CurrencyId.ARS,
                                  .UnitPrice = CDec(10000),
                                  .PictureUrl = "http://tiendaecommerce.gearhostpreview.com/Images/samsung10b.jpg"
                                 }
                             )

        'oPreference.NotificationUrl = "https://b4d860fba207.ngrok.io/api/Webhook/Payment"
        oPreference.NotificationUrl = "http://tiendaecommerce.gearhostpreview.com/api/Webhook/Payment"
        'oPreference.NotificationUrl = HttpContext.Current.Request.Url.Scheme & "://" & HttpContext.Current.Request.Url.Authority & "/notificacion.aspx"
        oPreference.ExternalReference = "sebastianbaetti@gmail.com"
        oPreference.Payer = comprador


        Dim pago As Payment = New Payment()
        pago.ExternalReference = "sebastianbaetti@gmail.com"
        pago.Installments = 6
        pago.Description = "Dispositivo móvil de Tienda e-commerce"



        Dim paymentmethod As PaymentMethods = New PaymentMethods()
        Dim lexcludedPaymentMethod As List(Of DataStructures.Preference.PaymentMethod) = New List(Of DataStructures.Preference.PaymentMethod)
        lexcludedPaymentMethod.Add(New DataStructures.Preference.PaymentMethod With {.Id = "amex"})
        paymentmethod.ExcludedPaymentMethods = lexcludedPaymentMethod
        Dim excludepaymenttype As List(Of PaymentType) = New List(Of PaymentType)
        excludepaymenttype.Add(New PaymentType() With {.Id = "atm"})
        paymentmethod.ExcludedPaymentTypes = excludepaymenttype
        paymentmethod.Installments = 6
        oPreference.BackUrls = New BackUrls() With {.Success = "http://tiendaecommerce.gearhostpreview.com/PagoAprobado.aspx", .Failure = "http://tiendaecommerce.gearhostpreview.com/PagoRechazado.aspx", .Pending = "http://tiendaecommerce.gearhostpreview.com/PagoPendiente.aspx"}
        oPreference.AutoReturn = AutoReturnType.approved
        oPreference.PaymentMethods = paymentmethod

        oPreference.Save()

        Dim sb As StringBuilder = New StringBuilder("")

        sb.Append("<a href='" & oPreference.InitPoint & "' class='btn btn-info'>Pagar la compra</a>")

        Me.ltMercadoPago.Text = sb.ToString()

    End Sub

End Class