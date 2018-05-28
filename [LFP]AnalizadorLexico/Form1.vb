' /******************************************
' * Ejemplo desarrollado por Erick Navarro *
' * Blog: e-navarro.blogspot.com           *
' * Octubre - 2015                         *
' ******************************************/

Public Class Form1
    'Se carga un texto de ejemplo para ser analizado
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEntrada.Text = "4.124*(5+6.1781*(8/2^3)-7)-1"
    End Sub
    'Cuando se presiona el boton, se realiza el análisis léxico
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entrada As String = txtEntrada.Text
        'Proceso de análisis léxico
        Dim lex As AnalizadorLexico = New AnalizadorLexico()
        Dim lTokens As List(Of Token) = lex.escanear(entrada)
        'Luego del analisis léxico obtenemos como salida una lista de tokens
        'en este caso es lTokens, ahora procedemos a imprimirla para mostrar 
        'su contenido.
        mostrarLista(lTokens)

    End Sub
    'Método utilizado para mostrar el resultado del análisis léxico, es decir, la lista 
    'de tokens
    Private Sub mostrarLista(ByVal l As List(Of Token))
        txtSalida.Text = ""
        For Each t As Token In l
            txtSalida.AppendText(t.getTipoEnString() & "  <-->  " & t.getValor() & vbCrLf)
        Next
    End Sub
End Class
