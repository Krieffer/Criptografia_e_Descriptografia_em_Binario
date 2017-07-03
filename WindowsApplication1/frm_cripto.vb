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
        Dim tamanhoTexto, i, textoCripto(tamanhoTexto) As Integer
        Dim textoDigitado As String

        textoDigitado = txb_textncrip.Text.ToString
        tamanhoTexto = txb_textncrip.TextLength

        ReDim textoCripto(tamanhoTexto)

        For i = 0 To tamanhoTexto - 1 Step 1
            Select Case textoDigitado(i)
                Case "A"
                    textoCripto(i) = vet_binarios(0)
                Case "B"
                    textoCripto(i) = vet_binarios(1)
                Case "C"
                    textoCripto(i) = vet_binarios(3)
                Case "D"
                    textoCripto(i) = vet_binarios(4)
                Case Else

            End Select
        Next



        For i = 0 To tamanhoTexto - 1 Step 1
            lbl_textcrip. = textoCripto(i)
        Next
    End Sub
End Class