Module md_criptografia
    Public Function criptografia(ByVal tamanhoTexto As Integer, ByVal textoDigitado As String, ByVal textoCripto() As String)

        ReDim textoCripto(tamanhoTexto)

        textoCripto = criptografa(tamanhoTexto, textoDigitado, textoCripto)

        Return textoCripto
    End Function
End Module
