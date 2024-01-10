' InventoryManager.vb

Public Class InventoryManager
    Private ReadOnly Products As New List(Of Product)
    Private ReadOnly Orders As New List(Of Order)

    Public Sub AddProduct(product As Product)
        Products.Add(product)
    End Sub

    Public Sub CreateOrder(order As Order)
        Orders.Add(order)
    End Sub

    Public Sub DisplayProducts()
        Console.WriteLine("Available Products:")
        For Each product In Products
            product.Display()
        Next
    End Sub

    Public Sub DisplayOrders()
        Console.WriteLine("Order History:")
        For Each order In Orders
            order.Display()
        Next
    End Sub
End Class
