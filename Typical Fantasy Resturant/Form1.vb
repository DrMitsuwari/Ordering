Public Class Menu1
    Dim orderListForm As OrderList
    Dim confirmOrderForm As ComfirmOrder

    Public Sub New()
        InitializeComponent()
        confirmOrderForm = New ComfirmOrder() ' Initialize confirmOrderForm first
        orderListForm = New OrderList(confirmOrderForm) ' Then initialize orderListForm with it
    End Sub

    ' Method to load child forms into the Order panel
    Sub childform(ByVal child As Form)
        Order.Controls.Clear()
        child.TopLevel = False
        Order.Controls.Add(child)
        child.Show()
        child.Dock = DockStyle.Fill
    End Sub

    ' Event handler for Main Dish button
    Private Sub MainDish_Click(sender As Object, e As EventArgs) Handles MainDish.Click
        Dim mainForm As New Main(orderListForm)
        childform(mainForm)
    End Sub

    ' Event handler for Special Dish button
    Private Sub SpecialDish_Click(sender As Object, e As EventArgs) Handles SpecialDish.Click
        Dim specialForm As New Special(orderListForm)
        childform(specialForm)
    End Sub

    ' Event handler for Side Dish button
    Private Sub SideDish_Click(sender As Object, e As EventArgs) Handles SideDish.Click
        Dim sideForm As New Side(orderListForm)
        childform(sideForm)
    End Sub

    ' Event handler for Dessert button
    Private Sub Dessert_Click(sender As Object, e As EventArgs) Handles Dessert.Click
        Dim dessertForm As New Dessert(orderListForm)
        childform(dessertForm)
    End Sub

    ' Event handler to view current orders
    Private Sub ViewOrder_Click(sender As Object, e As EventArgs) Handles ViewOrder.Click
        childform(orderListForm)
    End Sub

    ' Event handler to confirm order
    Private Sub ConfirmOrder_Click(sender As Object, e As EventArgs) Handles ConfirmOrder.Click
        ' Ensure to update the pay price before showing confirm order
        confirmOrderForm.UpdatePayPrice(orderListForm.CurrentTotalAmount)
        childform(confirmOrderForm)
    End Sub
End Class
