<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DTB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DTB))
        Me.tstp_main = New System.Windows.Forms.ToolStrip
        Me.mnu_return = New System.Windows.Forms.ToolStripButton
        Me.sep_00 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_About_Us = New System.Windows.Forms.ToolStripButton
        Me.grpbox_Reg = New System.Windows.Forms.GroupBox
        Me.txt_reg_read_val = New System.Windows.Forms.TextBox
        Me.num_reg_write_data = New System.Windows.Forms.NumericUpDown
        Me.txt_reg_write = New System.Windows.Forms.TextBox
        Me.cmd_reg_write = New System.Windows.Forms.Button
        Me.txt_reg_read = New System.Windows.Forms.TextBox
        Me.cmd_reg_read = New System.Windows.Forms.Button
        Me.num_add_Reg = New System.Windows.Forms.NumericUpDown
        Me.lbl_reg_set = New System.Windows.Forms.Label
        Me.lbl_reg_Data = New System.Windows.Forms.Label
        Me.lbl_add_Reg = New System.Windows.Forms.Label
        Me.grpbox_bit = New System.Windows.Forms.GroupBox
        Me.txt_bit_read_val = New System.Windows.Forms.TextBox
        Me.num_bit_write_data = New System.Windows.Forms.NumericUpDown
        Me.txt_bit_write = New System.Windows.Forms.TextBox
        Me.cmd_bit_write = New System.Windows.Forms.Button
        Me.txt_bit_read = New System.Windows.Forms.TextBox
        Me.cmd_bit_read = New System.Windows.Forms.Button
        Me.num_add_bit = New System.Windows.Forms.NumericUpDown
        Me.lbl_bit_Set = New System.Windows.Forms.Label
        Me.lbl_bit_Data = New System.Windows.Forms.Label
        Me.lbl_add_bit = New System.Windows.Forms.Label
        Me.cmd_connect = New System.Windows.Forms.Button
        Me.tstp_main.SuspendLayout()
        Me.grpbox_Reg.SuspendLayout()
        CType(Me.num_reg_write_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_add_Reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_bit.SuspendLayout()
        CType(Me.num_bit_write_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_add_bit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstp_main
        '
        Me.tstp_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tstp_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_return, Me.sep_00, Me.mnu_About_Us})
        Me.tstp_main.Location = New System.Drawing.Point(0, 0)
        Me.tstp_main.Name = "tstp_main"
        Me.tstp_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tstp_main.Size = New System.Drawing.Size(312, 25)
        Me.tstp_main.TabIndex = 10
        Me.tstp_main.Text = "Test Toolbar"
        '
        'mnu_return
        '
        Me.mnu_return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnu_return.Image = CType(resources.GetObject("mnu_return.Image"), System.Drawing.Image)
        Me.mnu_return.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_return.Name = "mnu_return"
        Me.mnu_return.Size = New System.Drawing.Size(23, 22)
        Me.mnu_return.Text = "Back to Main"
        '
        'sep_00
        '
        Me.sep_00.Name = "sep_00"
        Me.sep_00.Size = New System.Drawing.Size(6, 25)
        '
        'mnu_About_Us
        '
        Me.mnu_About_Us.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnu_About_Us.Image = CType(resources.GetObject("mnu_About_Us.Image"), System.Drawing.Image)
        Me.mnu_About_Us.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnu_About_Us.Name = "mnu_About_Us"
        Me.mnu_About_Us.Size = New System.Drawing.Size(23, 22)
        Me.mnu_About_Us.Text = "He&lp"
        '
        'grpbox_Reg
        '
        Me.grpbox_Reg.Controls.Add(Me.txt_reg_read_val)
        Me.grpbox_Reg.Controls.Add(Me.num_reg_write_data)
        Me.grpbox_Reg.Controls.Add(Me.txt_reg_write)
        Me.grpbox_Reg.Controls.Add(Me.cmd_reg_write)
        Me.grpbox_Reg.Controls.Add(Me.txt_reg_read)
        Me.grpbox_Reg.Controls.Add(Me.cmd_reg_read)
        Me.grpbox_Reg.Controls.Add(Me.num_add_Reg)
        Me.grpbox_Reg.Controls.Add(Me.lbl_reg_set)
        Me.grpbox_Reg.Controls.Add(Me.lbl_reg_Data)
        Me.grpbox_Reg.Controls.Add(Me.lbl_add_Reg)
        Me.grpbox_Reg.Enabled = False
        Me.grpbox_Reg.Location = New System.Drawing.Point(12, 28)
        Me.grpbox_Reg.Name = "grpbox_Reg"
        Me.grpbox_Reg.Size = New System.Drawing.Size(289, 156)
        Me.grpbox_Reg.TabIndex = 11
        Me.grpbox_Reg.TabStop = False
        Me.grpbox_Reg.Text = "Register"
        '
        'txt_reg_read_val
        '
        Me.txt_reg_read_val.Location = New System.Drawing.Point(76, 44)
        Me.txt_reg_read_val.Name = "txt_reg_read_val"
        Me.txt_reg_read_val.ReadOnly = True
        Me.txt_reg_read_val.Size = New System.Drawing.Size(203, 20)
        Me.txt_reg_read_val.TabIndex = 6
        '
        'num_reg_write_data
        '
        Me.num_reg_write_data.Location = New System.Drawing.Point(76, 99)
        Me.num_reg_write_data.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.num_reg_write_data.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.num_reg_write_data.Name = "num_reg_write_data"
        Me.num_reg_write_data.Size = New System.Drawing.Size(203, 20)
        Me.num_reg_write_data.TabIndex = 5
        '
        'txt_reg_write
        '
        Me.txt_reg_write.Location = New System.Drawing.Point(76, 125)
        Me.txt_reg_write.Name = "txt_reg_write"
        Me.txt_reg_write.ReadOnly = True
        Me.txt_reg_write.Size = New System.Drawing.Size(203, 20)
        Me.txt_reg_write.TabIndex = 4
        '
        'cmd_reg_write
        '
        Me.cmd_reg_write.Location = New System.Drawing.Point(9, 123)
        Me.cmd_reg_write.Name = "cmd_reg_write"
        Me.cmd_reg_write.Size = New System.Drawing.Size(61, 23)
        Me.cmd_reg_write.TabIndex = 3
        Me.cmd_reg_write.Text = "Write"
        Me.cmd_reg_write.UseVisualStyleBackColor = True
        '
        'txt_reg_read
        '
        Me.txt_reg_read.Location = New System.Drawing.Point(76, 73)
        Me.txt_reg_read.Name = "txt_reg_read"
        Me.txt_reg_read.ReadOnly = True
        Me.txt_reg_read.Size = New System.Drawing.Size(203, 20)
        Me.txt_reg_read.TabIndex = 4
        '
        'cmd_reg_read
        '
        Me.cmd_reg_read.Location = New System.Drawing.Point(9, 71)
        Me.cmd_reg_read.Name = "cmd_reg_read"
        Me.cmd_reg_read.Size = New System.Drawing.Size(61, 23)
        Me.cmd_reg_read.TabIndex = 3
        Me.cmd_reg_read.Text = "Read"
        Me.cmd_reg_read.UseVisualStyleBackColor = True
        '
        'num_add_Reg
        '
        Me.num_add_Reg.Hexadecimal = True
        Me.num_add_Reg.Location = New System.Drawing.Point(76, 19)
        Me.num_add_Reg.Maximum = New Decimal(New Integer() {8383, 0, 0, 0})
        Me.num_add_Reg.Minimum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.num_add_Reg.Name = "num_add_Reg"
        Me.num_add_Reg.Size = New System.Drawing.Size(203, 20)
        Me.num_add_Reg.TabIndex = 0
        Me.num_add_Reg.Value = New Decimal(New Integer() {4096, 0, 0, 0})
        '
        'lbl_reg_set
        '
        Me.lbl_reg_set.AutoSize = True
        Me.lbl_reg_set.Location = New System.Drawing.Point(6, 101)
        Me.lbl_reg_set.Name = "lbl_reg_set"
        Me.lbl_reg_set.Size = New System.Drawing.Size(29, 13)
        Me.lbl_reg_set.TabIndex = 1
        Me.lbl_reg_set.Text = "Set :"
        '
        'lbl_reg_Data
        '
        Me.lbl_reg_Data.AutoSize = True
        Me.lbl_reg_Data.Location = New System.Drawing.Point(6, 47)
        Me.lbl_reg_Data.Name = "lbl_reg_Data"
        Me.lbl_reg_Data.Size = New System.Drawing.Size(40, 13)
        Me.lbl_reg_Data.TabIndex = 1
        Me.lbl_reg_Data.Text = "Value :"
        '
        'lbl_add_Reg
        '
        Me.lbl_add_Reg.AutoSize = True
        Me.lbl_add_Reg.Location = New System.Drawing.Point(6, 21)
        Me.lbl_add_Reg.Name = "lbl_add_Reg"
        Me.lbl_add_Reg.Size = New System.Drawing.Size(39, 13)
        Me.lbl_add_Reg.TabIndex = 1
        Me.lbl_add_Reg.Text = "Add# :"
        '
        'grpbox_bit
        '
        Me.grpbox_bit.Controls.Add(Me.txt_bit_read_val)
        Me.grpbox_bit.Controls.Add(Me.num_bit_write_data)
        Me.grpbox_bit.Controls.Add(Me.txt_bit_write)
        Me.grpbox_bit.Controls.Add(Me.cmd_bit_write)
        Me.grpbox_bit.Controls.Add(Me.txt_bit_read)
        Me.grpbox_bit.Controls.Add(Me.cmd_bit_read)
        Me.grpbox_bit.Controls.Add(Me.num_add_bit)
        Me.grpbox_bit.Controls.Add(Me.lbl_bit_Set)
        Me.grpbox_bit.Controls.Add(Me.lbl_bit_Data)
        Me.grpbox_bit.Controls.Add(Me.lbl_add_bit)
        Me.grpbox_bit.Enabled = False
        Me.grpbox_bit.Location = New System.Drawing.Point(12, 190)
        Me.grpbox_bit.Name = "grpbox_bit"
        Me.grpbox_bit.Size = New System.Drawing.Size(289, 156)
        Me.grpbox_bit.TabIndex = 11
        Me.grpbox_bit.TabStop = False
        Me.grpbox_bit.Text = "Bit"
        '
        'txt_bit_read_val
        '
        Me.txt_bit_read_val.Location = New System.Drawing.Point(76, 44)
        Me.txt_bit_read_val.Name = "txt_bit_read_val"
        Me.txt_bit_read_val.ReadOnly = True
        Me.txt_bit_read_val.Size = New System.Drawing.Size(203, 20)
        Me.txt_bit_read_val.TabIndex = 6
        '
        'num_bit_write_data
        '
        Me.num_bit_write_data.Location = New System.Drawing.Point(76, 99)
        Me.num_bit_write_data.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_bit_write_data.Name = "num_bit_write_data"
        Me.num_bit_write_data.Size = New System.Drawing.Size(203, 20)
        Me.num_bit_write_data.TabIndex = 5
        '
        'txt_bit_write
        '
        Me.txt_bit_write.Location = New System.Drawing.Point(76, 125)
        Me.txt_bit_write.Name = "txt_bit_write"
        Me.txt_bit_write.ReadOnly = True
        Me.txt_bit_write.Size = New System.Drawing.Size(203, 20)
        Me.txt_bit_write.TabIndex = 4
        '
        'cmd_bit_write
        '
        Me.cmd_bit_write.Location = New System.Drawing.Point(9, 123)
        Me.cmd_bit_write.Name = "cmd_bit_write"
        Me.cmd_bit_write.Size = New System.Drawing.Size(61, 23)
        Me.cmd_bit_write.TabIndex = 3
        Me.cmd_bit_write.Text = "Write"
        Me.cmd_bit_write.UseVisualStyleBackColor = True
        '
        'txt_bit_read
        '
        Me.txt_bit_read.Location = New System.Drawing.Point(76, 73)
        Me.txt_bit_read.Name = "txt_bit_read"
        Me.txt_bit_read.ReadOnly = True
        Me.txt_bit_read.Size = New System.Drawing.Size(203, 20)
        Me.txt_bit_read.TabIndex = 4
        '
        'cmd_bit_read
        '
        Me.cmd_bit_read.Location = New System.Drawing.Point(9, 71)
        Me.cmd_bit_read.Name = "cmd_bit_read"
        Me.cmd_bit_read.Size = New System.Drawing.Size(61, 23)
        Me.cmd_bit_read.TabIndex = 3
        Me.cmd_bit_read.Text = "Read"
        Me.cmd_bit_read.UseVisualStyleBackColor = True
        '
        'num_add_bit
        '
        Me.num_add_bit.Hexadecimal = True
        Me.num_add_bit.Location = New System.Drawing.Point(76, 19)
        Me.num_add_bit.Maximum = New Decimal(New Integer() {2072, 0, 0, 0})
        Me.num_add_bit.Minimum = New Decimal(New Integer() {2064, 0, 0, 0})
        Me.num_add_bit.Name = "num_add_bit"
        Me.num_add_bit.Size = New System.Drawing.Size(203, 20)
        Me.num_add_bit.TabIndex = 0
        Me.num_add_bit.Value = New Decimal(New Integer() {2064, 0, 0, 0})
        '
        'lbl_bit_Set
        '
        Me.lbl_bit_Set.AutoSize = True
        Me.lbl_bit_Set.Location = New System.Drawing.Point(6, 101)
        Me.lbl_bit_Set.Name = "lbl_bit_Set"
        Me.lbl_bit_Set.Size = New System.Drawing.Size(29, 13)
        Me.lbl_bit_Set.TabIndex = 1
        Me.lbl_bit_Set.Text = "Set :"
        '
        'lbl_bit_Data
        '
        Me.lbl_bit_Data.AutoSize = True
        Me.lbl_bit_Data.Location = New System.Drawing.Point(6, 47)
        Me.lbl_bit_Data.Name = "lbl_bit_Data"
        Me.lbl_bit_Data.Size = New System.Drawing.Size(40, 13)
        Me.lbl_bit_Data.TabIndex = 1
        Me.lbl_bit_Data.Text = "Value :"
        '
        'lbl_add_bit
        '
        Me.lbl_add_bit.AutoSize = True
        Me.lbl_add_bit.Location = New System.Drawing.Point(6, 21)
        Me.lbl_add_bit.Name = "lbl_add_bit"
        Me.lbl_add_bit.Size = New System.Drawing.Size(39, 13)
        Me.lbl_add_bit.TabIndex = 1
        Me.lbl_add_bit.Text = "Add# :"
        '
        'cmd_connect
        '
        Me.cmd_connect.Location = New System.Drawing.Point(12, 352)
        Me.cmd_connect.Name = "cmd_connect"
        Me.cmd_connect.Size = New System.Drawing.Size(289, 29)
        Me.cmd_connect.TabIndex = 12
        Me.cmd_connect.Text = "&Connect"
        Me.cmd_connect.UseVisualStyleBackColor = True
        '
        'Frm_DTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(312, 393)
        Me.Controls.Add(Me.cmd_connect)
        Me.Controls.Add(Me.grpbox_bit)
        Me.Controls.Add(Me.grpbox_Reg)
        Me.Controls.Add(Me.tstp_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_DTB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeltaDTB-OOP"
        Me.tstp_main.ResumeLayout(False)
        Me.tstp_main.PerformLayout()
        Me.grpbox_Reg.ResumeLayout(False)
        Me.grpbox_Reg.PerformLayout()
        CType(Me.num_reg_write_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_add_Reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_bit.ResumeLayout(False)
        Me.grpbox_bit.PerformLayout()
        CType(Me.num_bit_write_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_add_bit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstp_main As System.Windows.Forms.ToolStrip
    Friend WithEvents mnu_return As System.Windows.Forms.ToolStripButton
    Friend WithEvents sep_00 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_About_Us As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpbox_Reg As System.Windows.Forms.GroupBox
    Friend WithEvents num_add_Reg As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_add_Reg As System.Windows.Forms.Label
    Friend WithEvents lbl_reg_Data As System.Windows.Forms.Label
    Friend WithEvents cmd_reg_read As System.Windows.Forms.Button
    Friend WithEvents txt_reg_read As System.Windows.Forms.TextBox
    Friend WithEvents num_reg_write_data As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_reg_set As System.Windows.Forms.Label
    Friend WithEvents txt_reg_write As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reg_write As System.Windows.Forms.Button
    Friend WithEvents grpbox_bit As System.Windows.Forms.GroupBox
    Friend WithEvents num_bit_write_data As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_bit_write As System.Windows.Forms.TextBox
    Friend WithEvents cmd_bit_write As System.Windows.Forms.Button
    Friend WithEvents txt_bit_read As System.Windows.Forms.TextBox
    Friend WithEvents cmd_bit_read As System.Windows.Forms.Button
    Friend WithEvents num_add_bit As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_bit_Set As System.Windows.Forms.Label
    Friend WithEvents lbl_bit_Data As System.Windows.Forms.Label
    Friend WithEvents lbl_add_bit As System.Windows.Forms.Label
    Friend WithEvents txt_reg_read_val As System.Windows.Forms.TextBox
    Friend WithEvents txt_bit_read_val As System.Windows.Forms.TextBox
    Friend WithEvents cmd_connect As System.Windows.Forms.Button

End Class
