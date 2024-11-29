Public Class OrderList
    Dim totalAmount As Integer = 0
    Dim OrderBoxes() As PictureBox
    Dim PriceBoxes() As TextBox
    Dim confirmOrder As ComfirmOrder

    ' Constructor that accepts a confirmOrder parameter
    Public Sub New(confirmOrderForm As ComfirmOrder)
        InitializeComponent()
        confirmOrder = confirmOrderForm

        ' Initialize the arrays of PictureBoxes and TextBoxes
        OrderBoxes = New PictureBox() {OrderBox1, OrderBox2, OrderBox3, OrderBox4, Orderbox5, OrderBox6, OrderBox7, OrderBox8, OrderBox9, OrderBox10, OrderBox11, OrderBox12}
        PriceBoxes = New TextBox() {Price1, Price2, Price3, Price4, Price5, Price6, Price7, Price8, Price9, Price10, Price11, Price12}
    End Sub

    ' Property to expose the current total amount
    Public ReadOnly Property CurrentTotalAmount As Integer
        Get
            Return totalAmount
        End Get
    End Property

    ' Method to update the first available order box with an image and price
    Public Sub UpdateFirstAvailableOrderBox(image As Image, price As Integer)
        For i As Integer = 0 To OrderBoxes.Length - 1
            If OrderBoxes(i).Image Is Nothing Then
                OrderBoxes(i).Image = image
                PriceBoxes(i).Text = price.ToString()
                UpdateTotalAmount(price)
                Return
            End If
        Next
        MessageBox.Show("All order boxes are already filled.", "Order Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Method to update the total amount and UI
    Public Sub UpdateTotalAmount(amount As Integer)
        totalAmount += amount
        TotalAmountPrice.Text = totalAmount.ToString()
        If confirmOrder IsNot Nothing Then
            confirmOrder.UpdatePayPrice(CurrentTotalAmount)  ' Update the PayPrice in ComfirmOrder
        End If
    End Sub

    ' Method to reduce the total amount
    Private Sub ReduceTotalAmount(amount As Integer)
        totalAmount -= amount
        TotalAmountPrice.Text = totalAmount.ToString()
        If confirmOrder IsNot Nothing Then
            confirmOrder.UpdatePayPrice(CurrentTotalAmount)  ' Update the PayPrice in ComfirmOrder
        End If
    End Sub

    ' Method to clear a specific order
    Private Sub ClearOrder(orderNumber As Integer)
        If orderNumber < 1 OrElse orderNumber > OrderBoxes.Length Then Return

        Dim priceToRemove As Integer = 0
        If Integer.TryParse(PriceBoxes(orderNumber - 1).Text, priceToRemove) Then
            ReduceTotalAmount(priceToRemove)
        End If

        OrderBoxes(orderNumber - 1).Image = Nothing
        PriceBoxes(orderNumber - 1).Text = String.Empty
    End Sub

    ' Clear order button click events
    Private Sub ClrOrder1_Click(sender As Object, e As EventArgs) Handles ClrOrder1.Click
        ClearOrder(1)
    End Sub

    Private Sub ClrOrder2_Click(sender As Object, e As EventArgs) Handles ClrOrder2.Click
        ClearOrder(2)
    End Sub

    Private Sub ClrOrder3_Click(sender As Object, e As EventArgs) Handles ClrOrder3.Click
        ClearOrder(3)
    End Sub

    Private Sub ClrOrder4_Click(sender As Object, e As EventArgs) Handles ClrOrder4.Click
        ClearOrder(4)
    End Sub

    Private Sub ClrOrder5_Click(sender As Object, e As EventArgs) Handles ClrOrder5.Click
        ClearOrder(5)
    End Sub

    Private Sub ClrOrder6_Click(sender As Object, e As EventArgs) Handles ClrOrder6.Click
        ClearOrder(6)
    End Sub

    Private Sub ClrOrder7_Click(sender As Object, e As EventArgs) Handles ClrOrder7.Click
        ClearOrder(7)
    End Sub

    Private Sub ClrOrder8_Click(sender As Object, e As EventArgs) Handles ClrOrder8.Click
        ClearOrder(8)
    End Sub

    Private Sub ClrOrder9_Click(sender As Object, e As EventArgs) Handles ClrOrder9.Click
        ClearOrder(9)
    End Sub

    Private Sub ClrOrder10_Click(sender As Object, e As EventArgs) Handles ClrOrder10.Click
        ClearOrder(10)
    End Sub

    Private Sub ClrOrder11_Click(sender As Object, e As EventArgs) Handles ClrOrder11.Click
        ClearOrder(11)
    End Sub

    Private Sub ClrOrder12_Click(sender As Object, e As EventArgs) Handles ClrOrder12.Click
        ClearOrder(12)
    End Sub
End Class
