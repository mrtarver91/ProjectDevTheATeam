Public Class Insert

    Public Shared Function Insert_Personal() As DataSet
            Dim _DBConnector As New DBConnector()
            Dim ds As New DataSet
            Dim query As String


            Try
                query = "INSERT INTO STUDENT (STUDENT_ID, LAST_NAME, MIDDLE_NAME, FIRST_NAME, PREFERRED_NAME, SSN, BIRTHDAY, ORIGIN, ETHINC, GENDER, CITZENSHIP) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtLastName.Text & "','" & Professional_MIS.frmApplicationForm.txtMiddleName.Text & "','" & Professional_MIS.frmApplicationForm.txtFirstName.Text & "','" & Professional_MIS.frmApplicationForm.txtPreferred.Text & "','" & Professional_MIS.frmApplicationForm.txtSSN.Text & "','" & Professional_MIS.frmApplicationForm.txtBirthday1.Text & "','" & Professional_MIS.frmApplicationForm.cbxOrigin.Text & "','" & Professional_MIS.frmApplicationForm.cbxEthnic.Text & "','" & Professional_MIS.frmApplicationForm.cbxGender.Text & "','" & Professional_MIS.frmApplicationForm.cbxCitizenship.Text & "')"
                ds = _DBConnector.GetDataSet(query)
            Catch err As Exception
                MessageBox.Show(err.Message)
            Finally
                'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
            End Try
            Return ds
        End Function

    'Public Shared Function Update_Personal() As DataSet
    '    Dim _DBConnector As New DBConnector()
    '    Dim ds As New DataSet
    '    Dim query As String

    '    Try
    '        query = "UPDATE STUDENT SET LAST_NAME = '" & Professional_MIS.frmApplicationForm.txtLastName.Text & "', MIDDLE_NAME = '" & Professional_MIS.frmApplicationForm.txtMiddleName.Text & "', FIRST_NAME = '" & Professional_MIS.frmApplicationForm.txtFirstName.Text & "', PREFERRED_NAME = '" & Professional_MIS.frmApplicationForm.txtPreferred.Text & "', SSN = '" & Professional_MIS.frmApplicationForm.txtSSN.Text & "', BIRTHDAY = '" & Professional_MIS.frmApplicationForm.txtBirthday1.Text & "', ORIGIN = '" & Professional_MIS.frmApplicationForm.cbxOrigin.Text & "', ETHINC = '" & Professional_MIS.frmApplicationForm.cbxEthnic.Text & "', GENDER = '" & Professional_MIS.frmApplicationForm.cbxGender.Text & "', CITZENSHIP = '" & Professional_MIS.frmApplicationForm.cbxCitizenship.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '        ds = _DBConnector.GetDataSet(query)
    '    Catch err As Exception
    '        MessageBox.Show(err.Message)
    '    Finally
    '        'MsgBox("Student Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '    End Try
    '    Return ds
    'End Function

    'Public Shared Function Insert_Address() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "INSERT INTO STUDENT_ADDRESS (STUDENT_ID, PERM_ADDRESS, PERM_CITY, PERM_STATE, PERM_ZIP_CODE, PREVIOUS_ADDRESS, PREVIOUS_CITY, PREVIOUS_STATE, PERVIOUS_ZIP_CODE, MAILING_ADDRESS, MAILING_CITY, MAILING_STATE, MAILING_ZIP_CODE, RESIDENT, YEARS_PERM, YEARS_PREVIOUS) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtPAddress.Text & "','" & Professional_MIS.frmApplicationForm.txtPCity.Text & "','" & Professional_MIS.frmApplicationForm.cbxPState.Text & "','" & Professional_MIS.frmApplicationForm.txtPZipCode.Text & "','" & Professional_MIS.frmApplicationForm.txtFAddress.Text & "','" & Professional_MIS.frmApplicationForm.txtFCity.Text & "','" & Professional_MIS.frmApplicationForm.cbxFState.Text & "','" & Professional_MIS.frmApplicationForm.txtFZipCode.Text & "','" & Professional_MIS.frmApplicationForm.txtLAddress.Text & "','" & Professional_MIS.frmApplicationForm.txtLCity.Text & "','" & Professional_MIS.frmApplicationForm.cbxLState.Text & "','" & Professional_MIS.frmApplicationForm.txtLZipCode.Text & "','" & Professional_MIS.frmApplicationForm.chkResident.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.txtPYears.Text & "','" & Professional_MIS.frmApplicationForm.txtFYears.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function

    'Public Shared Function Update_Address() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_ADDRESS SET PERM_ADDRESS = '" & Professional_MIS.frmApplicationForm.txtPAddress.Text & "', PERM_CITY = '" & Professional_MIS.frmApplicationForm.txtPCity.Text & "', PERM_STATE = '" & Professional_MIS.frmApplicationForm.cbxPState.Text & "', PERM_ZIP_CODE = '" & Professional_MIS.frmApplicationForm.txtPZipCode.Text & "', PREVIOUS_ADDRESS = '" & Professional_MIS.frmApplicationForm.txtFAddress.Text & "', PREVIOUS_CITY = '" & Professional_MIS.frmApplicationForm.txtFCity.Text & "', PREVIOUS_STATE = '" & Professional_MIS.frmApplicationForm.cbxFState.Text & "', PERVIOUS_ZIP_CODE = '" & Professional_MIS.frmApplicationForm.txtFZipCode.Text & "', MAILING_ADDRESS = '" & Professional_MIS.frmApplicationForm.txtLAddress.Text & "', MAILING_CITY = '" & Professional_MIS.frmApplicationForm.txtLCity.Text & "', MAILING_STATE = '" & Professional_MIS.frmApplicationForm.cbxLState.Text & "', MAILING_ZIP_CODE = '" & Professional_MIS.frmApplicationForm.txtLZipCode.Text & "', RESIDENT = '" & Professional_MIS.frmApplicationForm.chkResident.Checked.ToString & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Address tudent Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function

    '    Public Shared Function Insert_Phone() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "INSERT INTO STUDENT_PHONE (STUDENT_ID, CURRENT_PHONE, WORK_PHONE, PERM_PHONE, CONTACT) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtCurrentPhone.Text & "','" & Professional_MIS.frmApplicationForm.txtWorkPhone.Text & "','" & Professional_MIS.frmApplicationForm.txtPPhone.Text & "','" & Professional_MIS.frmApplicationForm.cbxPrimaryContactNumber.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function

    '    Public Shared Function Update_Phone() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_PHONE SET CURRENT_PHONE = '" & Professional_MIS.frmApplicationForm.txtCurrentPhone.Text & "', WORK_PHONE = '" & Professional_MIS.frmApplicationForm.txtWorkPhone.Text & "', PERM_PHONE = '" & Professional_MIS.frmApplicationForm.txtPPhone.Text & "', CONTACT = '" & Professional_MIS.frmApplicationForm.cbxPrimaryContactNumber.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Phone Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function


    '    Public Shared Function Insert_Email() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "INSERT INTO STUDENT_EMAIL (STUDENT_ID, EMAIL_ADDRESS) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtEmail.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function

    '    Public Shared Function Update_Email() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_EMAIL SET EMAIL_ADDRESS = '" & Professional_MIS.frmApplicationForm.txtEmail.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Email Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function


    '    Public Shared Function Insert_Student_Test_Score() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Professional_MIS.frmApplicationForm.txtGMATDate.Text = "1980-01-01"
    '        Professional_MIS.frmApplicationForm.txtTOEFLDate.Text = "1980-01-01"
    '        Professional_MIS.frmApplicationForm.txtTSEDate.Text = "1980-01-01"

    '        Try
    '            query = "INSERT INTO STUDENT_TEST_SCORE (STUDENT_ID, GMATDATE, GMATVERBAL, GMATQUANT, GMATTOTAL, TOEFLDATE, TOEFLTOTAL, TSEDATE, TSETOTAL) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtGMATDate.Text & "','" & Professional_MIS.frmApplicationForm.txtGMATVerbal.Text & "','" & Professional_MIS.frmApplicationForm.txtGMATQuant.Text & "','" & Professional_MIS.frmApplicationForm.txtGMATTotal.Text & "','" & Professional_MIS.frmApplicationForm.txtTOEFLDate.Text & "','" & Professional_MIS.frmApplicationForm.txtTOEFLTotal.Text & "','" & Professional_MIS.frmApplicationForm.txtTSEDate.Text & "','" & Professional_MIS.frmApplicationForm.txtTSETotal.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function


    '    Public Shared Function Update_Student_Test_Score() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_TEST_SCORE SET GMATDATE = '" & Professional_MIS.frmApplicationForm.txtGMATDate.Text & "', GMATVERBAL = '" & Professional_MIS.frmApplicationForm.txtGMATVerbal.Text & "', GMATQUANT = '" & Professional_MIS.frmApplicationForm.txtGMATQuant.Text & "', GMATTOTAL = '" & Professional_MIS.frmApplicationForm.txtGMATTotal.Text & "', TOEFLDATE = '" & Professional_MIS.frmApplicationForm.txtTOEFLDate.Text & "', TOEFLTOTAL = '" & Professional_MIS.frmApplicationForm.txtTOEFLTotal.Text & "', TSEDATE = '" & Professional_MIS.frmApplicationForm.txtTSEDate.Text & "', TSETOTAL = '" & Professional_MIS.frmApplicationForm.txtTSETotal.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Test Score Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function


    '    Public Shared Function Insert_Student_Academic_Transcript() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "INSERT INTO STUDENT_ADADEMIC_TRANSCRIPT (STUDENT_ID, UNDERGRAD_GPA, GPA_SENIOR, COLLEGE_NAME_1, DATE_TO_1, DATE_FROM_1, COLLEGE_GPA_1, HOURS_EARNED_1, DEGREE_NAME_1, MAJOR_1, DEGREE_DATE_1, CURRENT_HOURS_1, COLLEGE_NAME_2, DATE_TO_2, DATE_FROM_2, COLLEGE_GPA_2, HOURS_EARNED_2, DEGREE_NAME_2, MAJOR_2, DEGREE_DATE_2, CURRENT_HOURS_2) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ",'" & Professional_MIS.frmApplicationForm.txtUnderGPA.Text & "','" & Professional_MIS.frmApplicationForm.txtGPASenior.Text & "','" & Professional_MIS.frmApplicationForm.txtCName1.Text & "','" & Professional_MIS.frmApplicationForm.txtCTo1.Text & "','" & Professional_MIS.frmApplicationForm.txtCFrom1.Text & "','" & Professional_MIS.frmApplicationForm.txtCGPA1.Text & "','" & Professional_MIS.frmApplicationForm.txtHoursEarned1.Text & "','" & Professional_MIS.frmApplicationForm.txtDegree1.Text & "','" & Professional_MIS.frmApplicationForm.txtMajor1.Text & "','" & Professional_MIS.frmApplicationForm.txtDegreeDate1.Text & "','" & Professional_MIS.frmApplicationForm.txtCurrentHours1.Text & "','" & Professional_MIS.frmApplicationForm.txtCName2.Text & "','" & Professional_MIS.frmApplicationForm.txtCTo2.Text & "','" & Professional_MIS.frmApplicationForm.txtCFrom2.Text & "','" & Professional_MIS.frmApplicationForm.txtCGPA2.Text & "','" & Professional_MIS.frmApplicationForm.txtHoursEarned2.Text & "','" & Professional_MIS.frmApplicationForm.txtDegree2.Text & "','" & Professional_MIS.frmApplicationForm.txtMajor2.Text & "','" & Professional_MIS.frmApplicationForm.txtDegreeDate2.Text & "','" & Professional_MIS.frmApplicationForm.txtCurrentHours2.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function


    '    Public Shared Function Update_Student_Academic_Transcript() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_ADADEMIC_TRANSCRIPT SET UNDERGRAD_GPA = '" & Professional_MIS.frmApplicationForm.txtUnderGPA.Text & "', GPA_SENIOR = '" & Professional_MIS.frmApplicationForm.txtGPASenior.Text & "', COLLEGE_NAME_1 = '" & Professional_MIS.frmApplicationForm.txtCName1.Text & "', DATE_TO_1 = '" & Professional_MIS.frmApplicationForm.txtCTo1.Text & "', DATE_FROM_1 = '" & Professional_MIS.frmApplicationForm.txtCFrom1.Text & "', COLLEGE_GPA_1 = '" & Professional_MIS.frmApplicationForm.txtCGPA1.Text & "', HOURS_EARNED_1 = '" & Professional_MIS.frmApplicationForm.txtHoursEarned1.Text & "', DEGREE_NAME_1 = '" & Professional_MIS.frmApplicationForm.txtDegree1.Text & "', MAJOR_1 = '" & Professional_MIS.frmApplicationForm.txtMajor1.Text & "', DEGREE_DATE_1 = '" & Professional_MIS.frmApplicationForm.txtDegreeDate1.Text & "', CURRENT_HOURS_1 = '" & Professional_MIS.frmApplicationForm.txtCurrentHours1.Text & "', COLLEGE_NAME_2 = '" & Professional_MIS.frmApplicationForm.txtCName2.Text & "', DATE_TO_2 = '" & Professional_MIS.frmApplicationForm.txtCTo2.Text & "', DATE_FROM_2 = '" & Professional_MIS.frmApplicationForm.txtCFrom2.Text & "', COLLEGE_GPA_2 = '" & Professional_MIS.frmApplicationForm.txtCGPA2.Text & "', HOURS_EARNED_2 = '" & Professional_MIS.frmApplicationForm.txtHoursEarned2.Text & "', DEGREE_NAME_2 = '" & Professional_MIS.frmApplicationForm.txtDegree2.Text & "', MAJOR_2 = '" & Professional_MIS.frmApplicationForm.txtMajor2.Text & "', DEGREE_DATE_2 = '" & Professional_MIS.frmApplicationForm.txtDegreeDate2.Text & "', CURRENT_HOURS_2 = '" & Professional_MIS.frmApplicationForm.txtCurrentHours2.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information update completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function

    '    Public Shared Function Insert_Student_Admission_State() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "INSERT INTO STUDENT_ADMISSION_STATE (STUDENT_ID, REQUEST_YEAR, YEAR_TERM, APPLIED_BEFORE, DATE_BEFORE, ENROLLED, ENROLLED_DATE, STUDENT_STANDING, ASSISTANTSHIP_REQUESTED, APPLICATION_FEE, STUDENT_RESUME, ESSAY, APPLICATION, LOR, TRANSCRIPT, EDUCATION, FINANCIAL, TOEFL, TSE, GMAT_SCORE, GRE_SCORE, STATUS, DATE_APPLIED, ASSISTANTSHIP_STATUS, FEE_PAID, STUDENT_ENROLLED, DATE_ENROLLED, OFFER_DECLINED, DATE_DECLINED, ACCEPTED_OFFER, DATE_ACCEPTED, NOTES) VALUES (" & Professional_MIS.frmApplicationForm.txtStudentID.Text & ", '" & Professional_MIS.frmApplicationForm.txtRequestYear.Text & "','" & Professional_MIS.frmApplicationForm.cbxSession.Text & "','" & Professional_MIS.frmApplicationForm.chkBefore.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.txtBefore_when.Text & "','" & Professional_MIS.frmApplicationForm.chkEnrolled.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.txtEnrolled_When.Text & "','" & Professional_MIS.frmApplicationForm.cbxStanding.Text & "','" & Professional_MIS.frmApplicationForm.chkRequested.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkAppFeePaid.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkResume.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkEssay.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkAppForm.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkLOR.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkTranscript.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkEducation.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkFinancial.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkTOEFL.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkTSE.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkGMATScore.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.chkGREScore.Checked.ToString & "','" & Professional_MIS.frmApplicationForm.txtStatus.Text & "','" & Professional_MIS.frmApplicationForm.txtDateApplied.Text & "','" & Professional_MIS.frmApplicationForm.txtAStatus.Text & "','" & Professional_MIS.frmApplicationForm.txtFeePaid.Text & "','" & Professional_MIS.frmApplicationForm.txtSEnrolled.Text & "','" & Professional_MIS.frmApplicationForm.txtDEnrolled.Text & "','" & Professional_MIS.frmApplicationForm.txtDeclined.Text & "','" & Professional_MIS.frmApplicationForm.txtDDate.Text & "','" & Professional_MIS.frmApplicationForm.txtAcceptedOffer.Text & "','" & Professional_MIS.frmApplicationForm.txtDateAccepted.Text & "','" & Professional_MIS.frmApplicationForm.txtNotes.Text & "')"
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            MsgBox("Added student information sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Update_Student_Admission_State() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "UPDATE STUDENT_ADMISSION_STATE SET REQUEST_YEAR = '" & Professional_MIS.frmApplicationForm.txtRequestYear.Text & "', YEAR_TERM = '" & Professional_MIS.frmApplicationForm.cbxSession.Text & "', APPLIED_BEFORE = '" & Professional_MIS.frmApplicationForm.chkBefore.Checked.ToString & "', DATE_BEFORE = '" & Professional_MIS.frmApplicationForm.txtBefore_when.Text & "', ENROLLED = '" & Professional_MIS.frmApplicationForm.chkEnrolled.Checked.ToString & "', ENROLLED_DATE = '" & Professional_MIS.frmApplicationForm.txtEnrolled_When.Text & "', STUDENT_STANDING = '" & Professional_MIS.frmApplicationForm.cbxStanding.Text & "', ASSISTANTSHIP_REQUESTED = '" & Professional_MIS.frmApplicationForm.chkRequested.Checked.ToString & "', APPLICATION_FEE = '" & Professional_MIS.frmApplicationForm.chkAppFeePaid.Checked.ToString & "', STUDENT_RESUME = '" & Professional_MIS.frmApplicationForm.chkResume.Checked.ToString & "', ESSAY = '" & Professional_MIS.frmApplicationForm.chkEssay.Checked.ToString & "', APPLICATION = '" & Professional_MIS.frmApplicationForm.chkAppForm.Checked.ToString & "', LOR = '" & Professional_MIS.frmApplicationForm.chkLOR.Checked.ToString & "', TRANSCRIPT = '" & Professional_MIS.frmApplicationForm.chkTranscript.Checked.ToString & "', EDUCATION = '" & Professional_MIS.frmApplicationForm.chkEducation.Checked.ToString & "', FINANCIAL = '" & Professional_MIS.frmApplicationForm.chkFinancial.Checked.ToString & "', TOEFL = '" & Professional_MIS.frmApplicationForm.chkTOEFL.Checked.ToString & "', TSE = '" & Professional_MIS.frmApplicationForm.chkTSE.Checked.ToString & "', GMAT_SCORE = '" & Professional_MIS.frmApplicationForm.chkGMATScore.Checked.ToString & "', GRE_SCORE = '" & Professional_MIS.frmApplicationForm.chkGREScore.Checked & "', STATUS = '" & Professional_MIS.frmApplicationForm.txtStatus.Text & "', DATE_APPLIED = '" & Professional_MIS.frmApplicationForm.txtDateApplied.Text & "', ASSISTANTSHIP_STATUS = '" & Professional_MIS.frmApplicationForm.txtAStatus.Text & "', FEE_PAID = '" & Professional_MIS.frmApplicationForm.txtFeePaid.Text & "', STUDENT_ENROLLED = '" & Professional_MIS.frmApplicationForm.txtSEnrolled.Text & "', DATE_ENROLLED = '" & Professional_MIS.frmApplicationForm.txtDEnrolled.Text & "', OFFER_DECLINED = '" & Professional_MIS.frmApplicationForm.txtDeclined.Text & "', DATE_DECLINED = '" & Professional_MIS.frmApplicationForm.txtDDate.Text & "', ACCEPTED_OFFER = '" & Professional_MIS.frmApplicationForm.txtAcceptedOffer.Text & "', DATE_ACCEPTED = '" & Professional_MIS.frmApplicationForm.txtDateAccepted.Text & "', NOTES = '" & Professional_MIS.frmApplicationForm.txtNotes.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            MsgBox("Student information updated completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Personal() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            MsgBox("Student information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Address() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_ADDRESS WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Phone() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_PHONE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Email() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_EMAIL WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Student_Test_Score() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_TEST_SCORE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Student_Academic_Transcript() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_ADADEMIC_TRANSCRIPT WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
    '    Public Shared Function Delete_Student_Admission_State() As DataSet
    '        Dim _DBConnector As New DBConnector()
    '        Dim ds As New DataSet
    '        Dim query As String

    '        Try
    '            query = "DELETE FROM STUDENT_ADMISSION_STATE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
    '            ds = _DBConnector.GetDataSet(query)
    '        Catch err As Exception
    '            MessageBox.Show(err.Message)
    '        Finally
    '            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
    '        End Try
    '        Return ds
    '    End Function
End Class
