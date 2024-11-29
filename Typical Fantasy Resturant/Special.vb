Public Class Special
    Private orderListForm As OrderList

    Private basePath As String = "C:\Users\elija\source\repos\Typical Fantasy Resturant\Typical Fantasy Resturant\Resources\"

    ' Constructor that takes an instance of OrderList
    Public Sub New(orderList As OrderList)
        InitializeComponent()
        Me.orderListForm = orderList ' Assign the passed instance to the class variable
    End Sub
    Private Sub Special1_Click(sender As Object, e As EventArgs) Handles Special1.Click
        Dim imagePath As String = basePath & "Special 1.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 250
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Special2_Click(sender As Object, e As EventArgs) Handles Special2.Click
        Dim imagePath As String = basePath & "Special 2.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 275
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Special3_Click(sender As Object, e As EventArgs) Handles Special3.Click
        Dim imagePath As String = basePath & "Special 3.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 300
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Special4_Click(sender As Object, e As EventArgs) Handles Special4.Click
        Dim imagePath As String = basePath & "Special 4.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 250
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Special5_Click(sender As Object, e As EventArgs) Handles Special5.Click
        Dim imagePath As String = basePath & "Special 5.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 150
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Special6_Click(sender As Object, e As EventArgs) Handles Special6.Click
        Dim imagePath As String = basePath & "Special 6.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 200
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

End Class
