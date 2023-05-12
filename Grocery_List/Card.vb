Imports System.Windows.Forms
Imports Grocery_List.DataClass

Public Class frmCard

    Private Sub btnCardConfirm_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCardConfirm.Click
        CCV = mtxtCCV.Text
        CardNo = mtxtCardNo.Text
        CardName = mtxtCardName.Text
        Expiration = mtxtExpire.Text
        If CCV <> "" And CardNo <> "" And CardName <> "" And Expiration <> "" Then
            Dim Mbox As String
            Mbox = MsgBox("Are you sure? Make sure the values are true and correctly", vbYesNo + vbQuestion, "Card Corfirmation")
            Select Case Mbox
                Case vbYes
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
            End Select

        Else
            MsgBox("Fill up first carefully information if want use card", vbOKOnly + vbCritical, "Lack of Information Error")
        End If



    End Sub

    Private Sub btNCardCancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNCardCancel.Click
        mtxtCCV.Text = Nothing
        mtxtCardNo.Text = Nothing
        mtxtCardName.Text = Nothing
        mtxtExpire.Text = Nothing
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mtxtCCV.Text = CCV
        mtxtCardNo.Text = CardNo
        mtxtCardName.Text = CardName
        mtxtExpire.Text = Expiration
    End Sub
End Class
