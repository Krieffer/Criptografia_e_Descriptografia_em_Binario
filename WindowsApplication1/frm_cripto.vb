Public Class frm_cripto
    Private Sub frm_cripto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    Private Sub frm_cripto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encheVetores()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txb_textcrip.Clear()
        txb_textncrip.Clear()
    End Sub

    Private Sub btn_ativarcrip_Click(sender As Object, e As EventArgs) Handles btn_ativarcrip.Click
        Dim tamanhoTexto, i As Integer
        Dim textoDigitado, textoCripto(tamanhoTexto) As String

        textoDigitado = txb_textncrip.Text.ToString
        tamanhoTexto = txb_textncrip.TextLength

        textoCripto = criptografia(tamanhoTexto, textoDigitado, textoCripto)

        For i = 0 To tamanhoTexto - 1 Step 1
            txb_textcrip.Text &= textoCripto(i)
        Next
    End Sub
End Class