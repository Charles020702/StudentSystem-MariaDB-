Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String

    Private Sub PopListview()
        ListView1.Clear()
        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("last Name", 110)
            .Columns.Add("First Name", 110)
            .Columns.Add("Course", 110)
        End With

        openCon()
        sql = "Select * from tblstudentinfo"
        rs = New ADODB.Recordset
        rs.CursorLocation = 3
        rs.Open(sql, cn, 3, 3)

        If rs.RecordCount > 0 Then
            rs.MoveFirst()
            Do Until rs.EOF
                lv = New ListViewItem(rs.Fields("studno").Value.ToString)
                lv.Subitems.Add(rs.Fields("studlastname").Value)
                lv.Subitems.Add(rs.Fields("studfirstname").Value)
                lv.SubItems.Add(rs.Fields("studcourse").Value)
                ListView1.Items.Add(lv)
                rs.MoveNext()
            Loop
        End If
        rs.Close()
        cn.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListview()



    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For i = 0 To ListView1.SelectedItems.Count - 1


            selected = ListView1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tblstudentinfo where studno= '" & selected & "'"
            rs = New ADODB.Recordset
            rs.Open(sql, cn, 3, 3)
            Me.txtstudno.Text = rs.Fields("studno").Value
            Me.txtlastname.Text = rs.Fields("studlastname").Value
            Me.txtfirstname.Text = rs.Fields("studfirstname").Value
            Me.txtmi.Text = rs.Fields("studmi").Value
            Me.txtmi.Text = rs.Fields("studmi").Value
            Me.txtaddress.Text = rs.Fields("studaddress").Value
            Me.cmbgender.Text = rs.Fields("studgender").Value
            Me.txtcontact.Text = rs.Fields("studcontact").Value
            Me.cmbcourse.Text = rs.Fields("studcourse").Value
            rs.Close()
            cn.Close()
        Next
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        For x As Integer = 0 To ListView1.Items.Count - 1

            If txtstudno.Text = "" Or txtfirstname.Text = "" Or txtmi.Text = "" Or txtaddress.Text = "" Or cmbgender.Text = "" Or txtcontact.Text = "" Or cmbcourse.Text = "" Then
                MsgBox("Please Fill up all the inputs", vbCritical, vbOK)
                Return

            ElseIf txtstudno.Text = ListView1.Items(x).SubItems(0).Text Then
                MsgBox("The ID is taken!", vbCritical, vbOK)
                Return
            End If
        Next

        If MsgBox("Are you sure you want to save this record?", vbQuestion, vbYesNo) Then
            openCon()
            sql = "Insert into tblstudentinfo(studno, studlastname, studfirstname, studmi, studaddress, studgender, studcontact, studcourse)" _
            & "Values('" & (Me.txtstudno.Text) & "','" & Me.txtlastname.Text & "','" & Me.txtfirstname.Text & "', '" & Me.txtmi.Text & "', '" & Me.txtaddress.Text & "', '" & Me.cmbgender.Text & "','" & Me.txtcontact.Text & "', '" & Me.cmbcourse.Text & "')"
            rs = New ADODB.Recordset
            rs.Open(sql, cn, 3, 3)

            cn.Close()
            'rs = New ADODB.Recordset
            'rs.Open(sql, cn, 3, 3)
            'rs.AddNew()
            'rs.Fields("studno").Value = Me.txtstudno.Text
            'rs.Fields("studlastname").Value = Me.txtlastname.Text
            'rs.Fields("studfirstname").Value = Me.txtfirstname.Text
            'rs.Fields("studmi").Value = Me.txtmi.Text
            'rs.Fields("studaddress").Value = Me.txtaddress.Text
            'rs.Fields("studgender").Value = Me.cmbgender.Text
            'rs.Fields("studcontact").Value = Me.txtcontact.Text
            'rs.Fields("studcourse").Value = Me.cmbcourse.Text
            'rs.Update()
            'rs.Close()

        End If
        PopListview()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MsgBox("Are you sure you want to Delete this record?", vbQuestion, vbYesNo) Then
            openCon()
            sql = "DELETE from tblstudentinfo where studno= '" & selected & "'"
            rs = New ADODB.Recordset
            rs.Open(sql, cn, 3, 3)


        End If
        PopListview()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        If MsgBox("Are you sure you want to update this record?", vbQuestion, vbYesNo) = vbYes Then
            openCon()
            sql = "Update tblstudentinfo Set studno= '" & Me.txtstudno.Text & "',studlastname= '" & Me.txtlastname.Text & "', studfirstname= '" & Me.txtfirstname.Text & "' studmi='" & Me.txtmi.Text & "', studaddress='" & Me.txtaddress.Text & "', studgender='" & Me.cmbgender.Text & "', studcontact='" & Me.txtcontact.Text & "', studcourse= '" & Me.cmbcourse.Text & "' WHERE studno='" & selected & "'"
            rs = New ADODB.Recordset
            rs.Open(sql, cn, 3, 3)
            'rs.Fields("studno").Value = Me.txtstudno.Text
            'rs.Fields("studlastname").Value = Me.txtlastname.Text
            'rs.Fields("studfirstname").Value = Me.txtfirstname.Text
            'rs.Fields("studmi").Value = Me.txtmi.Text
            'rs.Fields("studaddress").Value = Me.txtaddress.Text
            'rs.Fields("studgender").Value = Me.cmbgender.Text
            'rs.Fields("studcontact").Value = Me.txtcontact.Text
            'rs.Fields("studcourse").Value = Me.cmbcourse.Text
            'rs.Update()
            'rs.Close()
            cn.Close()

        End If
        PopListview()
    End Sub

    Private Sub txtclear_Click(sender As Object, e As EventArgs) Handles txtclear.Click
        txtstudno.Clear()
        txtlastname.Clear()
        txtfirstname.Clear()
        txtmi.Clear()
        txtaddress.Clear()
        cmbgender.SelectedIndex = -1
        txtcontact.Clear()
        cmbcourse.SelectedIndex = -1
        PopListview()
    End Sub
End Class
