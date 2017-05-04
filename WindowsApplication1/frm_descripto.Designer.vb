<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_descripto
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
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_textdescrip = New System.Windows.Forms.RichTextBox()
        Me.btn_ativardescrip = New System.Windows.Forms.Button()
        Me.txb_textndescrip = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(167, 157)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(156, 25)
        Me.btn_limpar.TabIndex = 12
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Texto descriptografado:"
        '
        'txb_textdescrip
        '
        Me.txb_textdescrip.DetectUrls = False
        Me.txb_textdescrip.Enabled = False
        Me.txb_textdescrip.Location = New System.Drawing.Point(12, 219)
        Me.txb_textdescrip.Name = "txb_textdescrip"
        Me.txb_textdescrip.ReadOnly = True
        Me.txb_textdescrip.Size = New System.Drawing.Size(311, 110)
        Me.txb_textdescrip.TabIndex = 10
        Me.txb_textdescrip.Text = ""
        '
        'btn_ativardescrip
        '
        Me.btn_ativardescrip.Location = New System.Drawing.Point(12, 156)
        Me.btn_ativardescrip.Name = "btn_ativardescrip"
        Me.btn_ativardescrip.Size = New System.Drawing.Size(149, 26)
        Me.btn_ativardescrip.TabIndex = 9
        Me.btn_ativardescrip.Text = "Descriptografar!"
        Me.btn_ativardescrip.UseVisualStyleBackColor = True
        '
        'txb_textndescrip
        '
        Me.txb_textndescrip.Location = New System.Drawing.Point(12, 40)
        Me.txb_textndescrip.MaxLength = 128
        Me.txb_textndescrip.Name = "txb_textndescrip"
        Me.txb_textndescrip.Size = New System.Drawing.Size(311, 110)
        Me.txb_textndescrip.TabIndex = 8
        Me.txb_textndescrip.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Digite o texto para ser descriptografado:  (max. 120 caracteres)"
        '
        'frm_descripto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 341)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txb_textdescrip)
        Me.Controls.Add(Me.btn_ativardescrip)
        Me.Controls.Add(Me.txb_textndescrip)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frm_descripto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descriptografia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_limpar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_textdescrip As RichTextBox
    Friend WithEvents btn_ativardescrip As Button
    Friend WithEvents txb_textndescrip As RichTextBox
    Friend WithEvents Label1 As Label
End Class
