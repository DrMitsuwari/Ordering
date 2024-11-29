Public Class Main
    Private orderListForm As OrderList
    Private basePath As String = "C:\Users\elija\source\repos\Typical Fantasy Resturant\Typical Fantasy Resturant\Resources\"

    Public Sub New(orderList As OrderList)
        InitializeComponent()
        Me.orderListForm = orderList ' Assign the passed instance to the class variable
    End Sub

    Private Sub Main1_Click(sender As Object, e As EventArgs) Handles Main1.Click
        Dim imagePath As String = basePath & "Main 1.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 250
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Main2_Click(sender As Object, e As EventArgs) Handles Main2.Click
        Dim imagePath As String = basePath & "Main 2.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 225
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Main3_Click(sender As Object, e As EventArgs) Handles Main3.Click
        Dim imagePath As String = basePath & "Main 3.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 350
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Main4_Click(sender As Object, e As EventArgs) Handles Main4.Click
        Dim imagePath As String = basePath & "Main 4.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 250
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Main5_Click(sender As Object, e As EventArgs) Handles Main5.Click
        Dim imagePath As String = basePath & "Main 5.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 275
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub
    Private Sub Main6_Click(sender As Object, e As EventArgs) Handles Main6.Click
        Dim imagePath As String = basePath & "Main 6.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 200
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub
End Class
