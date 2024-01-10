' Product.vb

Public Class Product
    Public Property ProductId As Integer
    Public Property Name As String
    Public Property Price As Double

    Public Sub New(productId As Integer, name As String, price As Double)
        Me.ProductId = productId
        Me.Name = name
        Me.Price = price
    End Sub

    Public Sub Display()
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: ${Price}")
    End Sub
End Class
