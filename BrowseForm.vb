Imports System.Collections.Frozen

Public Class BrowseForm

    Shared startingPoint = New Point(3, 3)
    Shared yOffset = 50

    Shared Filters As New Dictionary(Of String, String)
    Shared ApplyFilters = False

    Private Sub BrowseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResetFilters()

        Me.ControlBox = False
        Dim exampleDetails As New Dictionary(Of String, String)
        exampleDetails("bookName") = "TetoLands"
        exampleDetails("bookID") = "12345"
        exampleDetails("bookAuthor") = "F. Scott Fitzgerald"
        exampleDetails("bookSubject") = "Fantasy"
        exampleDetails("yearPublished") = "1925"

        GlobalVariables.Books(0) = exampleDetails

        Dim exampleDetails1 As New Dictionary(Of String, String)
        exampleDetails1("bookName") = "Test2"
        exampleDetails1("bookID") = "08625"
        exampleDetails1("bookAuthor") = "Fred"
        exampleDetails1("bookSubject") = "Science Fiction"
        exampleDetails1("yearPublished") = "1987"

        GlobalVariables.Books(1) = exampleDetails1



    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
        Dispose()
        Form1.Show()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        pnlEntryDisplay.Controls.Clear()

        Dim startPoint As New Point(3, 3)
        Dim index As Integer = 0
        For Each indexKey As Integer In GlobalVariables.Books.Keys
            Dim matching = False
            Dim book = GlobalVariables.Books(indexKey)
            Dim templateLabel = lblEntry
            Dim newLabel As New Label
            newLabel.Location = New Point(3, 3 + (20 * index))
            newLabel.Font = templateLabel.Font
            newLabel.AutoSize = True

            If Not ApplyFilters Then
                matching = True
            End If

            For Each attr As KeyValuePair(Of String, String) In book
                newLabel.Text = newLabel.Text & attr.Value & "  ,  "
                If Not matching Then
                    If Filters.ContainsKey(attr.Key) Then
                        If attr.Value = Filters(attr.Key) Then
                            matching = True
                        End If
                    End If
                End If

            Next

            If matching Then
                pnlEntryDisplay.Controls.Add(newLabel)
                newLabel.Name = "entry" & index
                index += 1
            End If

        Next
    End Sub

    Private Sub applyFilter(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        ApplyFilters = True
        Filters("bookAuthor") = txtBoxAuthor.Text
        Filters("bookName") = txtBoxTitle.Text
        If cmbBoxSubject.SelectedIndex > -1 Then
            Filters("bookSubject") = cmbBoxSubject.Items(cmbBoxSubject.SelectedIndex)
        End If
        Filters("yearPublishedFrom") = nudYearFrom.Value
        Filters("yearPublishedTo") = nudYearTo.Value
    End Sub

    Private Sub ResetFilters()
        ApplyFilters = False
        txtBoxAuthor.Clear()
        txtBoxTitle.Clear()
    End Sub

    Private Sub btnResetFilters_Click(sender As Object, e As EventArgs) Handles btnResetFilters.Click
        ResetFilters()
    End Sub
End Class