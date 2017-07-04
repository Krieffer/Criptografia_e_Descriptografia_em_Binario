<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cripto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_textncrip = New System.Windows.Forms.RichTextBox()
        Me.btn_ativarcrip = New System.Windows.Forms.Button()
        Me.txb_textcrip = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o texto para ser criptografado:  (max. 120 caracteres)"
        '
        'txb_textncrip
        '
        Me.txb_textncrip.Location = New System.Drawing.Point(12, 38)
        Me.txb_textncrip.MaxLength = 128
        Me.txb_textncrip.Name = "txb_textncrip"
        Me.txb_textncrip.Size = New System.Drawing.Size(311, 110)
        Me.txb_textncrip.TabIndex = 2
        Me.txb_textncrip.Text = ""
        '
        'btn_ativarcrip
        '
        Me.btn_ativarcrip.Location = New System.Drawing.Point(12, 154)
        Me.btn_ativarcrip.Name = "btn_ativarcrip"
        Me.btn_ativarcrip.Size = New System.Drawing.Size(149, 26)
        Me.btn_ativarcrip.TabIndex = 3
        Me.btn_ativarcrip.Text = "Criptografar!"
        Me.btn_ativarcrip.UseVisualStyleBackColor = True
        '
        'txb_textcrip
        '
        Me.txb_textcrip.DetectUrls = False
        Me.txb_textcrip.Location = New System.Drawing.Point(12, 217)
        Me.txb_textcrip.Name = "txb_textcrip"
        Me.txb_textcrip.ReadOnly = True
        Me.txb_textcrip.Size = New System.Drawing.Size(311, 110)
        Me.txb_textcrip.TabIndex = 4
        Me.txb_textcrip.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Texto criptografado:"
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(167, 155)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(156, 25)
        Me.btn_limpar.TabIndex = 6
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'frm_cripto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(342, 338)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txb_textcrip)
        Me.Controls.Add(Me.btn_ativarcrip)
        Me.Controls.Add(Me.txb_textncrip)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_cripto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criptografia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txb_textncrip As RichTextBox
    Friend WithEvents btn_ativarcrip As Button
    Friend WithEvents txb_textcrip As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_limpar As Button
End Class
