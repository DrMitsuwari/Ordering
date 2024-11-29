Public Class Dessert
    Private orderListForm As OrderList
    Private basePath As String = "C:\Users\elija\source\repos\Typical Fantasy Resturant\Typical Fantasy Resturant\Resources\"

    ' Constructor that accepts an instance of OrderList
    Public Sub New(orderList As OrderList)
        InitializeComponent()
        Me.orderListForm = orderList ' Assign the passed instance to the class variable
    End Sub

    ' Click event handlers remain unchanged
    Private Sub Dessert1_Click(sender As Object, e As EventArgs) Handles Dessert1.Click
        Dim imagePath As String = basePath & "Dessert 1.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 150
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Dessert2_Click(sender As Object, e As EventArgs) Handles Dessert2.Click
        Dim imagePath As String = basePath & "Dessert 2.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 125
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Dessert3_Click(sender As Object, e As EventArgs) Handles Dessert3.Click
        Dim imagePath As String = basePath & "Dessert 3.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 125
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Dessert4_Click(sender As Object, e As EventArgs) Handles Dessert4.Click
        Dim imagePath As String = basePath & "Dessert 4.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 75
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Dessert5_Click(sender As Object, e As EventArgs) Handles Dessert5.Click
        Dim imagePath As String = basePath & "Dessert 5.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 100
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Dessert6_Click(sender As Object, e As EventArgs) Handles Dessert6.Click
        Dim imagePath As String = basePath & "Dessert 6.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 200
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub
End Class
