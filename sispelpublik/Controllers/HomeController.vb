Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Halaman() As ActionResult
        Return View()
    End Function

    Function Form() As ActionResult
        Return View()
    End Function
End Class
