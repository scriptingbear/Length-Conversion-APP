Public Class frmConversion



    Private Sub frmConversion_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        '=======================================================
        'Close the form when the Escape key is pressed.
        '=======================================================

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub frmConversion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        '=======================================================
        'Validate Imperial measurement textboxes for correct
        'number format. Then convert to inches and then convert
        'from inches to kilometers, meters and centimeters.
        'The Yards, Feet and Inches textboxes will automatically
        'detect overages and increment the value in the textbox
        'above accordingly, e.g. 2 ft, 3 in is OK but
        '2 ft, 14 in is not. In this case
        '2 ft -> 2 ft + Int(14/12), 14 Mod 12 in, or
        '3 ft, 2 in.
        '=======================================================
        Const PATTERN = "^([1-9]\d*|0)$"
        Dim arValidators As New List(Of TextBoxValidator) From
            {New TextBoxValidator(txtMiles, PATTERN),
            New TextBoxValidator(txtYards, PATTERN),
            New TextBoxValidator(txtFeet, PATTERN),
            New TextBoxValidator(txtInches, PATTERN)}

        '=======================================================
        'Perform calculations only on controls having valid
        'values.
        '=======================================================
        Const MILES_TO_INCHES = 63360
        Const YARDS_TO_INCHES = 36
        Const FEET_TO_INCHES = 12
        Const INCHES_PER_METER = 39.37

        Dim lngTotalInches As Long = 0
        Dim objTextbox As TextBox

        Dim ConversionConstants As New Dictionary(Of String, Double) From {
            {txtMiles.Name, MILES_TO_INCHES},
            {txtYards.Name, YARDS_TO_INCHES},
            {txtFeet.Name, FEET_TO_INCHES},
            {txtInches.Name, 1}}

        For Each objValidator As TextBoxValidator In arValidators
            If objValidator.IsValid() Then
                objTextbox = objValidator.TextBoxControl()
                lngTotalInches += CDbl(objTextbox.Text) * ConversionConstants(objTextbox.Name)
            End If
        Next objValidator

        If lngTotalInches = 0 Then
            msgAttention("None of the inputs is valid. Could not perform length conversion.")
            Exit Sub
        End If

        Dim dblTotalMeters As Double = CDbl(lngTotalInches) / INCHES_PER_METER
        lblKilometers.Text = Int(dblTotalMeters / 1000)
        lblMeters.Text = Int((dblTotalMeters - CDbl(lblKilometers.Text) * 1000))
        Dim temp As Double = ((dblTotalMeters - CDbl(lblKilometers.Text) * 1000) - CDbl(lblMeters.Text)) * 100

        lblCentimeters.Text = temp.ToString("N1")

    End Sub

    Private Sub AutoAdjust(sender As Object, e As EventArgs) Handles txtInches.TextChanged, txtFeet.TextChanged, txtYards.TextChanged
        '=======================================================
        'Detects measurements that are greater than the next
        'highest measrurement. E.g. in the Inches textbox, a 
        'value of 12 or more should be converted to the equivalent
        'number of feet and the value in the Feet textbox 
        'incremented by that amount.
        'First validate control to ensure it contains a positive
        'whole number > 0.
        '=======================================================
        Dim objThisTextbox As TextBox = CType(sender, TextBox)
        Dim objValidator As New TextBoxValidator(objThisTextbox, "^([1-9]\d*|0)$")

        If Not objValidator.IsValid() Then Exit Sub

        '=======================================================
        'Only have to adjust textbox above active textbox if 
        'the value entered in active textboc is >= the limit,
        'which represents how many of the active textbox's units
        'equal 1 of the units of the textbox above it.
        '=======================================================
        Dim intThisTextboxUnits As Integer = CInt(objThisTextbox.Text)
        Dim intLimit As Integer = objThisTextbox.Tag
        If intThisTextboxUnits < intLimit Then Exit Sub

        '=======================================================
        'Identify the textbox control immediately above the
        'active textbox. That will be the control whose
        'value will be increased.
        '=======================================================
        Dim objPreviousTexbox As TextBox = Nothing
        For Each obj As Control In Me.Controls
            If TypeOf obj Is TextBox Then
                If obj.TabIndex = objThisTextbox.TabIndex - 1 Then
                    objPreviousTexbox = obj
                    Exit For
                End If
            End If
        Next obj

        '=======================================================
        'Adjust the value in the textbox above by the number
        'of whole units of its type contained in the value
        'entered in the active textbox. Then replace the value
        'in the active textbox with the remainder.
        '=======================================================
        If Not objPreviousTexbox Is Nothing Then
            Dim intPreviousTextboxUnits As Integer
            If Not Integer.TryParse(objPreviousTexbox.Text, intPreviousTextboxUnits) Then
                intPreviousTextboxUnits = 0
            End If

            Dim intAddUnits = Int(intThisTextboxUnits / intLimit)
            intPreviousTextboxUnits += intAddUnits
            objPreviousTexbox.Text = intPreviousTextboxUnits
            objThisTextbox.Text = intThisTextboxUnits Mod intLimit
        End If

    End Sub


    Private Sub ClearInputs()
        '===================================================================
        'Clear the input textboxes and clear the output labels to the
        'right
        '===================================================================

        Dim arTextBoxes As New List(Of TextBox) From {txtMiles, txtYards, txtFeet, txtInches}

        For Each obj As TextBox In arTextBoxes
            obj.Clear()
        Next obj


        Dim arLabels As New List(Of Label) From {lblKilometers, lblMeters, lblCentimeters}

        For Each obj As Label In arLabels
            obj.Text = ""
        Next obj


    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        ClearInputs()
    End Sub
End Class
