Module md_criptografa
    Public Function criptografa(ByVal tamanhoTexto As Integer, ByVal textoDigitado As String, ByVal textoCripto() As String)
        For i = 0 To tamanhoTexto - 1 Step 1
            Select Case textoDigitado(i)
                Case "A"
                    textoCripto(i) = vet_binarios(0)
                Case "B"
                    textoCripto(i) = vet_binarios(1)
                Case "C"
                    textoCripto(i) = vet_binarios(2)
                Case "D"
                    textoCripto(i) = vet_binarios(3)
                Case "E"
                    textoCripto(i) = vet_binarios(4)
                Case "F"
                    textoCripto(i) = vet_binarios(5)
                Case "G"
                    textoCripto(i) = vet_binarios(6)
                Case "H"
                    textoCripto(i) = vet_binarios(7)
                Case "I"
                    textoCripto(i) = vet_binarios(8)
                Case "J"
                    textoCripto(i) = vet_binarios(9)
                Case "K"
                    textoCripto(i) = vet_binarios(10)
                Case "L"
                    textoCripto(i) = vet_binarios(11)
                Case "M"
                    textoCripto(i) = vet_binarios(12)
                Case "N"
                    textoCripto(i) = vet_binarios(13)
                Case "O"
                    textoCripto(i) = vet_binarios(14)
                Case "P"
                    textoCripto(i) = vet_binarios(15)
                Case "Q"
                    textoCripto(i) = vet_binarios(16)
                Case "R"
                    textoCripto(i) = vet_binarios(17)
                Case "S"
                    textoCripto(i) = vet_binarios(18)
                Case "T"
                    textoCripto(i) = vet_binarios(19)
                Case "U"
                    textoCripto(i) = vet_binarios(20)
                Case "V"
                    textoCripto(i) = vet_binarios(21)
                Case "W"
                    textoCripto(i) = vet_binarios(22)
                Case "X"
                    textoCripto(i) = vet_binarios(23)
                Case "Y"
                    textoCripto(i) = vet_binarios(24)
                Case "Z"
                    textoCripto(i) = vet_binarios(25)

                Case "a"
                    textoCripto(i) = vet_binarios(26)
                Case "b"
                    textoCripto(i) = vet_binarios(27)
                Case "c"
                    textoCripto(i) = vet_binarios(28)
                Case "d"
                    textoCripto(i) = vet_binarios(29)
                Case "e"
                    textoCripto(i) = vet_binarios(30)
                Case "f"
                    textoCripto(i) = vet_binarios(31)
                Case "g"
                    textoCripto(i) = vet_binarios(32)
                Case "h"
                    textoCripto(i) = vet_binarios(33)
                Case "i"
                    textoCripto(i) = vet_binarios(34)
                Case "j"
                    textoCripto(i) = vet_binarios(35)
                Case "k"
                    textoCripto(i) = vet_binarios(36)
                Case "l"
                    textoCripto(i) = vet_binarios(37)
                Case "m"
                    textoCripto(i) = vet_binarios(38)
                Case "n"
                    textoCripto(i) = vet_binarios(39)
                Case "o"
                    textoCripto(i) = vet_binarios(40)
                Case "p"
                    textoCripto(i) = vet_binarios(41)
                Case "q"
                    textoCripto(i) = vet_binarios(42)
                Case "r"
                    textoCripto(i) = vet_binarios(43)
                Case "s"
                    textoCripto(i) = vet_binarios(44)
                Case "t"
                    textoCripto(i) = vet_binarios(45)
                Case "u"
                    textoCripto(i) = vet_binarios(46)
                Case "v"
                    textoCripto(i) = vet_binarios(47)
                Case "w"
                    textoCripto(i) = vet_binarios(48)
                Case "x"
                    textoCripto(i) = vet_binarios(49)
                Case "y"
                    textoCripto(i) = vet_binarios(50)
                Case "z"
                    textoCripto(i) = vet_binarios(51)

                Case "0"
                    textoCripto(i) = vet_binarios(52)
                Case "1"
                    textoCripto(i) = vet_binarios(53)
                Case "2"
                    textoCripto(i) = vet_binarios(54)
                Case "3"
                    textoCripto(i) = vet_binarios(55)
                Case "4"
                    textoCripto(i) = vet_binarios(56)
                Case "5"
                    textoCripto(i) = vet_binarios(57)
                Case "6"
                    textoCripto(i) = vet_binarios(58)
                Case "7"
                    textoCripto(i) = vet_binarios(59)
                Case "8"
                    textoCripto(i) = vet_binarios(60)
                Case "9"
                    textoCripto(i) = vet_binarios(61)

                Case "!"
                    textoCripto(i) = vet_binarios(62)
                Case Chr(34) 'Comando para referenciar aspas duplas.
                    textoCripto(i) = vet_binarios(63)
                Case "#"
                    textoCripto(i) = vet_binarios(64)
                Case "$"
                    textoCripto(i) = vet_binarios(65)
                Case "%"
                    textoCripto(i) = vet_binarios(66)
                Case "&"
                    textoCripto(i) = vet_binarios(67)
                Case "'"
                    textoCripto(i) = vet_binarios(68)
                Case "("
                    textoCripto(i) = vet_binarios(69)
                Case ")"
                    textoCripto(i) = vet_binarios(70)
                Case "*"
                    textoCripto(i) = vet_binarios(71)
                Case "+"
                    textoCripto(i) = vet_binarios(72)
                Case ","
                    textoCripto(i) = vet_binarios(73)
                Case "-"
                    textoCripto(i) = vet_binarios(74)
                Case "."
                    textoCripto(i) = vet_binarios(75)
                Case "/"
                    textoCripto(i) = vet_binarios(76)
                Case ":"
                    textoCripto(i) = vet_binarios(77)
                Case ";"
                    textoCripto(i) = vet_binarios(78)
                Case "<"
                    textoCripto(i) = vet_binarios(79)
                Case "="
                    textoCripto(i) = vet_binarios(80)
                Case ">"
                    textoCripto(i) = vet_binarios(81)
                Case "?"
                    textoCripto(i) = vet_binarios(82)
                Case "@"
                    textoCripto(i) = vet_binarios(83)
                Case "["
                    textoCripto(i) = vet_binarios(84)
                Case "\"
                    textoCripto(i) = vet_binarios(85)
                Case "]"
                    textoCripto(i) = vet_binarios(86)
                Case "^"
                    textoCripto(i) = vet_binarios(87)
                Case "_"
                    textoCripto(i) = vet_binarios(88)
                Case "`"
                    textoCripto(i) = vet_binarios(89)
                Case "{"
                    textoCripto(i) = vet_binarios(90)
                Case "|"
                    textoCripto(i) = vet_binarios(91)
                Case "}"
                    textoCripto(i) = vet_binarios(92)
                Case "~"
                    textoCripto(i) = vet_binarios(93)
                Case Else

            End Select
        Next

        Return textoCripto
    End Function
End Module
