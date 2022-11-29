Imports System.Data.SqlClient
Public Class frmHome

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-7AUJDQG\SQLEXPRESS;Initial Catalog=tableRegi;Integrated Security=True")

    Private Sub btnPatientrecord_Click(sender As Object, e As EventArgs) Handles btnPatientrecord.Click

        gbxHome.Hide()
        TabControl1.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        TabControl1.Hide()
        gbxHome.Show()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtCellphone.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtProvince.Text = ""
        txtPostalcode.Text = ""
        rbSingle.Checked = False
        rbMarried.Checked = False
        dtpDateofBirth.ResetText()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        gbxHome.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



    End Sub
End Class