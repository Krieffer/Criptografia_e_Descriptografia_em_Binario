Public Class frm_cripto
    Public Sub encheVetores()
        encheVetBin()
        encheVetLetras()
    End Sub

    Private Sub encheVetLetras()
        Dim vet_letras(25) As Char
        Dim contVet As Integer
        Dim contCodLet As Integer = 65

        For contVet = 0 To 25 Step 1
            vet_letras(contVet) = ChrW(contCodLet)
            contCodLet += 1
        Next
    End Sub

    Private Sub encheVetBin()
        Dim vet_binarios(25) As Integer
        vet_binarios(0) = "01000001" 'A
        vet_binarios(1) = "01000010" 'B
        vet_binarios(2) = "01000011" 'C
        vet_binarios(3) = "01000100" 'D
        vet_binarios(4) = "01000101" 'E
        vet_binarios(5) = "01000110" 'F
        vet_binarios(6) = "01000111" 'G
        vet_binarios(7) = "01001000" 'H
        vet_binarios(8) = "01001001" 'I
        vet_binarios(9) = "01001010" 'J
        vet_binarios(10) = "01001011" 'K
        vet_binarios(11) = "01001100" 'L
        vet_binarios(12) = "01001101" 'M
        vet_binarios(13) = "01001110" 'N
        vet_binarios(14) = "01001111" 'O
        vet_binarios(15) = "01010000" 'P
        vet_binarios(16) = "01010001" 'Q
        vet_binarios(17) = "01010010" 'R
        vet_binarios(18) = "01010011" 'S
        vet_binarios(19) = "01010100" 'T
        vet_binarios(20) = "01010101" 'U
        vet_binarios(21) = "01010110" 'V
        vet_binarios(22) = "01010111" 'W
        vet_binarios(23) = "01011000" 'X
        vet_binarios(24) = "01011001" 'Y
        vet_binarios(25) = "01011010" 'Z
    End Sub

    Private Sub frm_cripto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    Private Sub frm_cripto_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub frm_cripto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encheVetores()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txb_textcrip.Clear()
        txb_textncrip.Clear()
    End Sub
End Class