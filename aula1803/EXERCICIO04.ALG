Algoritmo "Exercicio04"

Var
   numero1, numero2, resultado: real
   sinalOperacao: caractere

Inicio
   escreval("Bom dia!!!")
   escreval("Digite o primeiro n�mero da opera��o:")
   leia(numero1)
   escreval("Digite o segundo n�mero da opera��o:")
   leia(numero2)
   escreval("Digite o sinal da opera��o desejada:")
   leia(sinalOperacao)
   escolha sinalOperacao
   caso "+"
      resultado <- numero1 + numero2
      escreval("A soma dos dois n�meros �:" , resultado)
   caso "-"
      resultado <- numero1 - numero2
      escreval("A subtra��o entre os dois n�meros �:" , resultado)
   caso "*"
      resultado <- numero1 * numero2
      escreval("A multiplica��o entre os dois n�meros �:" , resultado)
   caso "/"
      resultado <- numero1 / numero2
      escreval("A divis�o entre os dois n�meros �:" , resultado)
   outrocaso
      escreval("Opera��o n�o identificada... Tente novamente.")
   fimescolha

Fimalgoritmo