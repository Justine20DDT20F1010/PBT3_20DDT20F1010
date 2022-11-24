'Name : Justine Nanggai
'No matrik : 20DDT20F1010
'Class : DDT5A
'PBT : 3
Public Class Form1
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'declare array for arrayheight, arrayweight and array bmi
        Dim I As Integer
        Dim ArrayHeight(10) As Integer
        Dim ArrayWeight(10) As Integer
        Dim health(10) As String
        Dim ArrayBMU(10) As Double
        If I < ArrayHeight.Length Then
            If txtheight.Text.Trim.Length > 0 Then
                ArrayHeight(I) = txtheight.Text
                ArrayWeight(I) = txtheight.Text

                'BMI = Weight/height^2(m)
                '<18.4 underweight
                '18.5-24.9 normal
                '25-39.9 overweight
                '>40 obese
                'formula for calculate the bmi
                ArrayBMU(I) = ArrayWeight(I) / (ArrayHeight(I) * ArrayHeight(I))

                'if the bmi more than 40 or equal to the listbox will display underweight
                If ArrayBMU(I) >= 40 Then
                    health(I) = "obese"
                    'if the bmi more than 25 or equal to the  listbox will display overweight
                ElseIf ArrayBMU(I) >= 25 Then
                    health(I) = "overweight"
                    'if the bmi more than 18.5 or equal to the listbox
                ElseIf ArrayBMU(I) >= 18.5 Then
                    health(I) = "normal"
                Else
                    'if the bmi less than 25
                    health(I) = "underweight"
                End If
                'display in listbox
                lbdisplay.Items.Add(ArrayHeight(I) & "  " & ArrayWeight(I) & "  " & ArrayBMU(I) & "  " & health(I))
                I = I + 1
            Else
                'if the user do not enter the data
                MsgBox("Please Enter Data")
            End If
        Else
            'if the array is full
            MsgBox("The array is Full")
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'open dialog 
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'save dialog 
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'print form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        'clear the textbox
        txtheight.Clear()
        txtweight.Clear()
    End Sub
End Class
