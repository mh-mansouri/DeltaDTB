
#Region "References"

Imports System.IO.Ports

#End Region

Friend Class Frm_DTB

#Region "Fields"

    Private delta_dtb As Delta.DeltaDTB
    Private str_ports() As String
    Private filename_opened As String = ""

#End Region

#Region "Properties"

#Region "Buttons"

    Private Sub cmd_bit_read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_bit_read.Click
        Try
            txt_bit_read.Text = delta_dtb.Read_bit(num_add_bit.Value)
            txt_bit_read_val.Text = delta_dtb.Extract_Value_bit(Trim(txt_bit_read.Text)).ToString("0")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            txt_bit_read.Text = ""
            txt_bit_write.Text = ""
            txt_reg_read.Text = ""
            txt_reg_write.Text = ""
            grpbox_bit.Enabled = False
            grpbox_Reg.Enabled = False
        End Try
    End Sub

    Private Sub cmd_bit_write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_bit_write.Click
        Try
            txt_bit_write.Text = delta_dtb.Write_bit(num_add_bit.Value, IIf(num_bit_write_data.Value = 1, True, False))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            txt_bit_read.Text = ""
            txt_bit_write.Text = ""
            txt_reg_read.Text = ""
            txt_reg_write.Text = ""
            grpbox_bit.Enabled = False
            grpbox_Reg.Enabled = False
        End Try
    End Sub

    Private Sub cmd_connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_connect.Click
        If delta_dtb.Test Then
            MsgBox("Responsed!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            grpbox_bit.Enabled = True
            grpbox_Reg.Enabled = True
        Else
            MsgBox("Not Responsed!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            txt_bit_read.Text = ""
            txt_bit_write.Text = ""
            txt_reg_read.Text = ""
            txt_reg_write.Text = ""
            grpbox_bit.Enabled = False
            grpbox_Reg.Enabled = False
        End If
    End Sub

    Private Sub cmd_reg_read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reg_read.Click
        Try
            txt_reg_read.Text = delta_dtb.Read_word(num_add_Reg.Value)
            txt_reg_read_val.Text = delta_dtb.Extract_Value_Word(Trim(txt_reg_read.Text)).ToString("0")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            txt_bit_read.Text = ""
            txt_bit_write.Text = ""
            txt_reg_read.Text = ""
            txt_reg_write.Text = ""
            grpbox_bit.Enabled = False
            grpbox_Reg.Enabled = False
        End Try
    End Sub

    Private Sub cmd_reg_write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reg_write.Click
        Try
            txt_reg_write.Text = delta_dtb.Write_word(num_add_Reg.Value, num_reg_write_data.Value)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "FKR_DeltaDTB")
            txt_bit_read.Text = ""
            txt_bit_write.Text = ""
            txt_reg_read.Text = ""
            txt_reg_write.Text = ""
            grpbox_bit.Enabled = False
            grpbox_Reg.Enabled = False
        End Try
    End Sub

#End Region

#Region "Form"

    Private Sub Frm_DTB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not delta_dtb Is Nothing Then
            If delta_dtb.ISOpen Then delta_dtb.Close()
            delta_dtb = Nothing
        End If
    End Sub

    Private Sub Frm_DTB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        delta_dtb = New Delta.DeltaDTB(New System.IO.Ports.SerialPort("COM1", 38400, IO.Ports.Parity.Even, 7, IO.Ports.StopBits.One))
        delta_dtb.Open()
    End Sub

#End Region

#Region "Menus"

    Private Sub mnu_About_Us_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_About_Us.Click
        Try
            Dim newF As Frm_AboutUs = New Frm_AboutUs
            newF.ShowDialog(Me)
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub mnu_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_return.Click
        Call Me.Close()
    End Sub

#End Region

#End Region

#Region "Functions and Subs"

#End Region

End Class
