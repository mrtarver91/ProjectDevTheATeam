Imports System.Windows.Forms.ErrorProvider



Public Class Application




    'Programmer: Joel Golden
    'Date: 2/18/08
    'Description: Application DB UI for the Walton Business College Masters Programs.

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
            If Me.txtLastName.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtLastName, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtLastName, "")
            End If
            If Me.txtFirstName.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtFirstName, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtFirstName, "")
            End If
            If Not (txtStudentID.Text Like "#########") Then
                Me.ErrorProvider1.SetError(txtStudentID, "Student ID must be 9 numbers.")
            Else
                Me.ErrorProvider1.SetError(txtStudentID, "")
            End If
            If Not (txtSSN.Text Like "###-##-####") Then
                Me.ErrorProvider1.SetError(txtSSN, "SSN must be in ###-###-#### format.")
            Else
                Me.ErrorProvider1.SetError(txtSSN, "")
            End If
            If Me.txtBirthday1.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtBirthday1, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtBirthday1, "")
            End If
            If Me.cbxOrigin.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxOrigin, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxOrigin, "")
            End If
            If Me.txtSSN.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtSSN, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtSSN, "")
            End If
            If Me.cbxEthnic.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxEthnic, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxEthnic, "")
            End If
            If Me.cbxGender.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxGender, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxGender, "")
            End If
            If Me.cbxCitizenship.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxCitizenship, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxCitizenship, "")
            End If
            If Me.txtPAddress.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtPAddress, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtPAddress, "")
            End If
            If Me.txtPCity.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtPCity, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtPCity, "")
            End If
            If Me.cbxPState.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxPState, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxPState, "")
            End If
            If Not (txtPZipCode.Text Like "#####-####") Then
                Me.ErrorProvider1.SetError(txtPZipCode, "Zip Code must be in #####-#### format.")
            Else
                Me.ErrorProvider1.SetError(txtPZipCode, "")
            End If
            If Me.txtLAddress.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtLAddress, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtLAddress, "")
            End If
            If Me.txtLCity.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtLCity, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtLCity, "")
            End If
            If Me.cbxLState.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxLState, "Field required.")
            Else
                Me.ErrorProvider1.SetError(cbxLState, "")
            End If
            If Not (txtLZipCode.Text Like "#####-####") Then
                Me.ErrorProvider1.SetError(txtLZipCode, "Zip Code must be in #####-#### format.")
            Else
                Me.ErrorProvider1.SetError(txtLZipCode, "")
            End If
            'If Me.txtCurrentPhone.Text.Length = 0 Then
            'Me.ErrorProvider1.SetError(txtCurrentPhone, "Field required.")
            'Else
            'Me.ErrorProvider1.SetError(txtCurrentPhone, "")
            'End If
            If Me.txtPPhone.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtPPhone, "Please enter a permanent phone number.")
            Else
                Me.ErrorProvider1.SetError(txtPPhone, "")
            End If
            If Me.cbxPrimaryContactNumber.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(cbxPrimaryContactNumber, "Please select a primary contact number.")
            Else
                Me.ErrorProvider1.SetError(cbxPrimaryContactNumber, "")
            End If
            If Me.txtRequestYear.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtRequestYear, "Field required.")
            Else
                Me.ErrorProvider1.SetError(txtRequestYear, "")
            End If
            If Me.txtGMATDate.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtGMATDate, "Please enter students GMAT date.")
            Else
                Me.ErrorProvider1.SetError(txtGMATDate, "")
            End If
            If Me.txtGMATVerbal.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtGMATVerbal, "Please enter students Verbal GMAT Score.")
            Else
                Me.ErrorProvider1.SetError(txtGMATVerbal, "")
            End If
            If Me.txtGMATTotal.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtGMATTotal, "Please enter students Total GMAT Score.")
            Else
                Me.ErrorProvider1.SetError(txtGMATTotal, "")
            End If
            If Me.txtUnderGPA.Text.Length = 0 Then
                Me.ErrorProvider1.SetError(txtUnderGPA, "Please enter students Undergrad GPA.")
            Else
                Me.ErrorProvider1.SetError(txtUnderGPA, "")
            End If

            Insert.Insert_Personal()
            Insert.Insert_Address()
            Insert.Insert_Email()
            Insert.Insert_Phone()
            Insert.Insert_Student_Academic_Transcript()
            Insert.Insert_Student_Test_Score()
            Insert.Insert_Student_Admission_State()
        End Sub

    Private Function ErrorProvider1() As Object
        Throw New NotImplementedException()
    End Function

    ''Private Sub btnSearchRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRecord.Click

    ''    Dim variable As String

    ''    ControlClassForm.ValidateSearchFields()
    ''    '        ControlClassSQL.GetSearchResults()

    ''    Dim searchResults As DataSet

    ''    If Me.txtLastName.Text.Length <> 0 And
    ''                        Me.txtLastName.Text.Length <> 0 And
    ''                        Me.Text.Length <> 0 And
    ''                        Me.Text.Length <> 0 And
    ''                        Me.Text.Length <> 0 Then

    ''        searchResults = ControlClassSQL.GetSearchResults()

    ''        frmSearchResults.dgSearchResults.DataBindings.Clear()
    ''        frmSearchResults.dgSearchResults.DataSource = searchResults.Tables(0).DefaultView()
    ''        frmSearchResults.Show()

    ''        'Use row autosizing to show all the text
    ''        frmSearchResults.dgSearchResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

    ''        ' Initialize DataGridView Columns
    ''        frmSearchResults.dgSearchResults.RowHeadersVisible = False
    ''        For Each col As DataGridViewColumn In frmSearchResults.dgSearchResults.Columns
    ''            If col.GetType Is GetType(DataGridViewTextBoxColumn) Then
    ''                For Each row As DataGridViewRow In frmSearchResults.dgSearchResults.Rows
    ''                    If row.IsNewRow Then Continue For
    ''                    row.Height = row.Cells("LAST_NAME").ContentBounds.Height + 6
    ''                Next
    ''            End If
    ''        Next

    ''    End If

    ''End Sub

    'Private Sub btnEditRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRecord.Click

    '    Call EditText Function
    '        ControlClassForm.UnlockFields()

    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSearchFields.Click

    '    Clear all text boxes used for search function
    '        ControlClassForm.ClearSearchFields()
    '    ControlClassForm.UnlockFields()

    'End Sub


    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click

        'Call function to save changes to record to DB.

        Insert.Update_Personal()
        Insert.Update_Address()
        Insert.Update_Email()
        Insert.Update_Phone()
        Insert.Update_Student_Academic_Transcript()
        Insert.Update_Student_Test_Score()
        Insert.Update_Student_Admission_State()

    End Sub

    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRecord.Click
            Insert.Delete_Student_Admission_State()
            Insert.Delete_Student_Academic_Transcript()
            Insert.Delete_Student_Test_Score()
            Insert.Delete_Phone()
            Insert.Delete_Email()
            Insert.Delete_Address()
            Insert.Delete_Personal()
        'ControlClassForm.ClearSearchFields()
    End Sub

    'Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
    '    'Call EditText function
    '    ControlClassForm.UnlockFields()
    'End Sub

    Private Sub frmApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class






'dgGrades.DataBindings.Clear() 
'        dgGrades.Columns.Clear() 
'        dgGrades.AutoGenerateColumns = False 
'        dgGrades.DataSource = studentGrades.Tables(0) 

'Dim colClass As New DataGridViewColumn
'        dgGrades.Columns.Add("Class", "Class") 
'        dgGrades.Columns("Class").DataPropertyName = "Class"
