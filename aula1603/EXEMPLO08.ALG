Algoritmo "Exemplo08"

Var
   numero: inteiro

Inicio
   escreval("Números de 1 a 10:")
   // Solução com "para"
   //   para numero de 1 ate 10 faca
   //      escreval(numero)
   //   fimpara

   // Solução com "enquanto"
   //   numero <- 1
   //   enquanto numero <= 10 faca
   //      escreval(numero)
   //      numero <- numero + 1
   //   fimenquanto

   // Solução com "repita"
   numero <- 0
   repita
      escreval(numero)
      numero <- numero + 2
   ate numero > 10

Fimalgoritmo