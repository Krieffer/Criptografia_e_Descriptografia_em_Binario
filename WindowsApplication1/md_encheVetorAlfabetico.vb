Module md_enchevetorAlfabetico
    Public Sub encheVetLetras()
        Dim contVet As Integer
        Dim contCodLet As Integer = 65

        For contVet = 0 To 25 Step 1
            vet_letras(contVet) = ChrW(contCodLet)
            contCodLet += 1
        Next
    End Sub
End Module
