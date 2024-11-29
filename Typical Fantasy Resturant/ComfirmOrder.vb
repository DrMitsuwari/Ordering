Public Class ComfirmOrder
    ' Method to update the total amount in PayPrice TextBox
    Public Sub UpdatePayPrice(amount As Integer)
        PayPrice.Text = amount.ToString()
    End Sub

    ' Event handler for the Pay button click
    Private Sub Pay_Click(sender As Object, e As EventArgs) Handles Pay.Click
        Dim userPayment As Integer
        Dim totalAmount As Integer

        ' Ensure the total amount is parsed from PayPrice TextBox
        If Integer.TryParse(PayPrice.Text, totalAmount) AndAlso Integer.TryParse(TextBox1.Text, userPayment) Then
            If userPayment >= totalAmount Then
                Dim change As Integer = userPayment - totalAmount
                MessageBox.Show($"Order confirmed! Total: {totalAmount}, Paid: {userPayment}, Change: {change}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Additional logic for completing the order can be added here, such as resetting the form or clearing the order list
            Else
                MessageBox.Show("Insufficient funds! Please enter a sufficient amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
