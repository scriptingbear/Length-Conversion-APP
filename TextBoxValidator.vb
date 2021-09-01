'=======================================================
'A class that handles validation of the textbox
'control passed to it, according to the specified regex.
'=======================================================

Imports System.Text.RegularExpressions
Imports System.Collections
Public Class TextBoxValidator

    Private _objTextboxControl As TextBox
    Private _strValidationPattern As String
    Private _strErrorMessage As String

    Public Sub New(ByRef TextBoxControl As TextBox, ByVal ValidationPattern As String, Optional ErrorMessage As String = vbNullString)
        Me.TextBoxControl = TextBoxControl
        Me.ValidationPattern = ValidationPattern
        Me.ErrorMessage = ErrorMessage
    End Sub
    Public Property TextBoxControl() As TextBox
        Get
            Return _objTextboxControl
        End Get

        Set(value As TextBox)
            _objTextboxControl = value
        End Set
    End Property
    Public Property ValidationPattern() As String

        Get
            Return _strValidationPattern
        End Get

        Set(value As String)
            _strValidationPattern = value
        End Set
    End Property

    Public Property ErrorMessage() As String
        Get
            Return _strErrorMessage
        End Get
        Set(value As String)
            _strErrorMessage = value
        End Set
    End Property

    Public Function IsValid() As Boolean
        Dim objMatch As Match = Regex.Match(_objTextboxControl.Text, _strValidationPattern)
        '=======================================================
        'NEW CODE: 09/01/2021: Displaying an error message is now
        'optional.
        '=======================================================
        If Not objMatch.Success Then
            If _strErrorMessage <> vbNullString Then
                msgAttention(_strErrorMessage)
            End If
            Return False
        Else
            Return True
        End If
    End Function

End Class
