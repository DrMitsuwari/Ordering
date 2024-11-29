Public Class Side
    Dim orderListForm As OrderList
    Dim basePath As String = "C:\Users\elija\source\repos\Typical Fantasy Resturant\Typical Fantasy Resturant\Resources\"

    Public Sub New(orderList As OrderList)
        InitializeComponent()
        Me.orderListForm = orderList ' Assign the passed instance to the class variable
    End Sub
    Private Sub Side1_Click(sender As Object, e As EventArgs) Handles Side1.Click
        Dim imagePath As String = basePath & "Side 1.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 150
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Side2_Click(sender As Object, e As EventArgs) Handles Side2.Click
        Dim imagePath As String = basePath & "Side 2.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 175
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub


    Private Sub Side3_Click(sender As Object, e As EventArgs) Handles Side3.Click
        Dim imagePath As String = basePath & "Side 3.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 125
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub


    Private Sub Side4_Click(sender As Object, e As EventArgs) Handles Side4.Click
        Dim imagePath As String = basePath & "Side 4.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 150
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub


    Private Sub Side5_Click(sender As Object, e As EventArgs) Handles Side5.Click
        Dim imagePath As String = basePath & "Side 5.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 100
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub


    Private Sub Side6_Click(sender As Object, e As EventArgs) Handles Side6.Click
        Dim imagePath As String = basePath & "Side 6.png"
        Dim image As Image = Image.FromFile(imagePath)
        Dim price As Integer = 200
        orderListForm.UpdateFirstAvailableOrderBox(image, price)
    End Sub

    Private Sub Side_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
