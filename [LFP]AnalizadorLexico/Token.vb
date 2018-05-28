' /******************************************
' * Ejemplo desarrollado por Erick Navarro *
' * Blog: e-navarro.blogspot.com           *
' * Octubre - 2015                         *
' ******************************************/

Public Class Token
    'Tipos de tokens reconocidos por el analizador
    Enum Tipo
        NUMERO_ENTERO
        NUMERO_REAL
        SIGNO_MAS
        SIGNO_MEN
        SIGNO_POR
        SIGNO_DIV
        SIGNO_POW
        PARENTESIS_IZQ
        PARENTESIS_DER
    End Enum

    'Atributo que almacena el tipo de token
    Private tipoToken As Tipo
    'Atributo que almacena el valor específico que fue reconocido, el lexema
    Private valor As String

    'Constructor de la clase
    Public Sub New(ByVal tipo As Tipo, ByVal auxLex As String)
        Me.tipoToken = tipo
        Me.valor = auxLex
    End Sub

    'Función que devuelve el valor almacenado, es decir, el lexema
    Public Function getValor() As String
        Return valor
    End Function

    'Función utilizada para devolver en cadena el tipo específico del token
    Public Function getTipoEnString() As String
        Select Case tipoToken
            Case Tipo.NUMERO_ENTERO
                Return "Número Entero "
            Case Tipo.NUMERO_REAL
                Return "Número Real   "
            Case Tipo.SIGNO_MAS
                Return "Signo Más     "
            Case Tipo.SIGNO_MEN
                Return "Signo Menos   "
            Case Tipo.SIGNO_POR
                Return "Signo Por     "
            Case Tipo.SIGNO_DIV
                Return "Signo División"
            Case Tipo.SIGNO_POW
                Return "Signo Potencia"
            Case Tipo.PARENTESIS_IZQ
                Return "Parentesis Izq"
            Case Tipo.PARENTESIS_DER
                Return "Parentesis Der"
            Case Else
                Return "Desconocido   "
        End Select
    End Function
End Class
