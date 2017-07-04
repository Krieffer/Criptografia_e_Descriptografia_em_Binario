<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_crip = New System.Windows.Forms.Button()
        Me.btn_descrip = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_sobre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CriptoSolutions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Escolha a opção desejada:"
        '
        'btn_crip
        '
        Me.btn_crip.Location = New System.Drawing.Point(89, 104)
        Me.btn_crip.Name = "btn_crip"
        Me.btn_crip.Size = New System.Drawing.Size(159, 25)
        Me.btn_crip.TabIndex = 2
        Me.btn_crip.Text = "Criptografar"
        Me.btn_crip.UseVisualStyleBackColor = True
        '
        'btn_descrip
        '
        Me.btn_descrip.Location = New System.Drawing.Point(89, 146)
        Me.btn_descrip.Name = "btn_descrip"
        Me.btn_descrip.Size = New System.Drawing.Size(159, 25)
        Me.btn_descrip.TabIndex = 3
        Me.btn_descrip.Text = "Descriptografar"
        Me.btn_descrip.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(89, 186)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(159, 24)
        Me.btn_sair.TabIndex = 4
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_sobre
        '
        Me.btn_sobre.Location = New System.Drawing.Point(283, 175)
        Me.btn_sobre.Name = "btn_sobre"
        Me.btn_sobre.Size = New System.Drawing.Size(48, 35)
        Me.btn_sobre.TabIndex = 5
        Me.btn_sobre.Text = "Sobre Nós"
        Me.btn_sobre.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 217)
        Me.Controls.Add(Me.btn_sobre)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_descrip)
        Me.Controls.Add(Me.btn_crip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criptografia e Descriptografia em Binário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_crip As Button
    Friend WithEvents btn_descrip As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_sobre As Button
End Class
