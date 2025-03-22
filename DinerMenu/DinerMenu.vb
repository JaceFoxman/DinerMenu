Public Class DinerMenu
    'Jason Permann
    'Spring 2025
    'RCET2265
    'Diner Menu
    'https://github.com/JaceFoxman/DinerMenu.git
    Private Sub DinerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        WriteSoupSpecial()
        ReadSoupSpecial()
    End Sub

    Sub WriteSoupSpecial()
        FileOpen(1, "SoupSpecial.txt", OpenMode.Output)
        Write(1, "~Soup Of The Day~" & vbNewLine _
              & "Traditional Japenese Ramen with two soft boiled eggs")
        FileClose(1)
    End Sub

    Sub ReadSoupSpecial()
        Dim soupOfTheDay As String
        FileOpen(1, "SoupSpecial.txt", OpenMode.Input)
        Try
            Do Until EOF(1)
                Input(1, soupOfTheDay)
                DisplaySpecialLabel.Text = soupOfTheDay
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("File Not Found")
        End Try
    End Sub

    Private Sub Saladbutton_Click(sender As Object, e As EventArgs) Handles Saladbutton.Click

    End Sub

    Sub SaladSpecial()
        FileOpen(2, "SaladSpecial.txt", OpenMode.Output)
        Write(2, "~Salad Of The Day~" & vbNewLine _
              & "Traditional Japenese Ramen with two soft boiled eggs")
        FileClose(2)
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

    End Sub

    Sub FishSpecial()

    End Sub

    ''' <summary>
    ''' closes program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
