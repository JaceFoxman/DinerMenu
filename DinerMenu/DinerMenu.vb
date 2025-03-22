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
              & "Ramen: A Japanese noodle dish that includes Chinese-style wheat noodles served in a broth and two slices of soft boiled egg.")
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
        WriteSaladSpecial()
        ReadSaladSpecial()
    End Sub

    Sub WriteSaladSpecial()
        FileOpen(2, "SaladSpecial.txt", OpenMode.Output)
        Write(2, "~Salad Of The Day~" & vbNewLine _
              & "Cesar Salad: A green salad of romaine lettuce and croutons dressed with lemon juice (or lime juice), olive oil, eggs, Worcestershire sauce, anchovies, garlic, Dijon mustard, Parmesan and black pepper.")
        FileClose(2)
    End Sub

    Sub ReadSaladSpecial()
        Dim saladOfTheDay As String
        FileOpen(2, "SaladSpecial.txt", OpenMode.Input)
        Try
            Do Until EOF(2)
                Input(2, saladOfTheDay)
                DisplaySpecialLabel.Text = saladOfTheDay
            Loop
            FileClose(2)
        Catch ex As Exception
            MsgBox("File Not Found")
        End Try
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        WriteFishSpecial()
        ReadFishSpecial()
    End Sub

    Sub WriteFishSpecial()
        FileOpen(3, "FishSpecial.txt", OpenMode.Output)
        Write(3, "~Fish Of The Day~" & vbNewLine _
              & "Sole meunière: a classic French fish dish consisting of sole, floured and fried, and served with hot melted butter, lemon juice and parsley.")
        FileClose(3)
    End Sub

    Sub ReadFishSpecial()
        Dim fishOfTheDay As String
        FileOpen(3, "FishSpecial.txt", OpenMode.Input)
        Try
            Do Until EOF(3)
                Input(3, fishOfTheDay)
                DisplaySpecialLabel.Text = fishOfTheDay
            Loop
            FileClose(3)
        Catch ex As Exception
            MsgBox("File Not Found")
        End Try
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
