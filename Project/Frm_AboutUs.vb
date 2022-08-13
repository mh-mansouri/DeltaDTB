
Friend NotInheritable Class Frm_AboutUs

    Private Sub AboutUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("FKR-About Us")
        Me.LabelProductName.Text = "DeltaDTB Software"
        Me.LabelVersion.Text = String.Format("Version 2.0.1.0")
        Me.LabelCompanyName.Text = "Farzankar Ind. Co."
        Me.TextBoxDescription.Text = "DeltaDTB Software" & vbNewLine & "Created by Farzankar Ind. Co., Automation and Software Department" & vbNewLine & "http://www.Farzankar.Ir"
    End Sub

End Class
