' Order.vb

Public Class Order
    Public Property OrderId As Integer
    Public Property Products As New List(Of Product)

    Public Sub New(orderId As Integer)
        Me.OrderId = orderId
    End Sub

    Public Sub AddProduct(product As Product)
        Products.Add(product)
    End Sub

    Public Sub Display()
        Console.WriteLine($"Order ID: {OrderId}")
        For Each product In Products
            product.Display()
        Next
    End Sub
End Class
