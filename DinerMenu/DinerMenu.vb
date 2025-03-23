'Jason Permann
'Spring 2025
'RCET2265
'Diner Menu
'https://github.com/JaceFoxman/DinerMenu.git

Option Explicit On
Option Strict On
Public Class DinerMenu

    Private Sub DinerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' When pressed run WriteSoupSpecial and ReadSoupSpecial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        WriteSoupSpecial()
        ReadSoupSpecial()
    End Sub

    ''' <summary>
    ''' Create or open file "SoupSpecial" and add text
    ''' </summary>
    Sub WriteSoupSpecial()
        FileOpen(1, "SoupSpecial.txt", OpenMode.Output)
        Write(1, "                                    ~Soup Of The Day~" & vbNewLine _
              & "Ramen: A Japanese noodle dish that includes Chinese-style wheat noodles served in a broth and two slices of soft boiled egg.")
        FileClose(1)
    End Sub

    ''' <summary>
    ''' Opens file "SoupSpecial" and writes to label
    ''' </summary>
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

    ''' <summary>
    ''' When pressed run WriteChefSpecial and ReadChefSpecial
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Saladbutton_Click(sender As Object, e As EventArgs) Handles Saladbutton.Click
        WriteChefSpecial()
        ReadChefSpecial()
    End Sub

    ''' <summary>
    ''' Create or open file "Chef's Special" and add text
    ''' </summary>
    Sub WriteChefSpecial()
        FileOpen(2, "Chef's Special.txt", OpenMode.Output)
        Write(2, "                                      ~Chef's Special~" & vbNewLine _
              & "Cesar Salad: A green salad of romaine lettuce and croutons dressed with lemon juice (or lime juice), olive oil, eggs, Worcestershire sauce, anchovies, garlic, Dijon mustard, Parmesan and black pepper.")
        FileClose(2)
    End Sub

    ''' <summary>
    ''' Opens file "Chef's Special" and writes to label
    ''' </summary>
    Sub ReadChefSpecial()
        Dim chefSpecial As String
        FileOpen(2, "Chef's Special.txt", OpenMode.Input)
        Try
            Do Until EOF(2)
                Input(2, chefSpecial)
                DisplaySpecialLabel.Text = chefSpecial
            Loop
            FileClose(2)
        Catch ex As Exception
            MsgBox("File Not Found")
        End Try
    End Sub

    ''' <summary>
    ''' When pressed run WriteDailyFish and ReadDailyFish
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        WriteDailyFish()
        ReadDailyFish()
    End Sub

    ''' <summary>
    ''' Create or open file "Daily Fish" and add text
    ''' </summary>
    Sub WriteDailyFish()
        FileOpen(3, "Daily Fish.txt", OpenMode.Output)
        Write(3, "                                          ~Daily Fish~" & vbNewLine _
              & "Sole meunière: a classic French fish dish consisting of sole, floured and fried, and served with hot melted butter, lemon juice and parsley.")
        FileClose(3)
    End Sub

    ''' <summary>
    ''' Opens file "Daily Fish" and writes to label
    ''' </summary>
    Sub ReadDailyFish()
        Dim dailyFish As String
        FileOpen(3, "Daily Fish.txt", OpenMode.Input)
        Try
            Do Until EOF(3)
                Input(3, dailyFish)
                DisplaySpecialLabel.Text = dailyFish
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
