Algoritmo "Exercicio04"

Var
   numero1, numero2, resultado: real
   sinalOperacao: caractere

Inicio
   escreval("Bom dia!!!")
   escreval("Digite o primeiro número da operação:")
   leia(numero1)
   escreval("Digite o segundo número da operação:")
   leia(numero2)
   escreval("Digite o sinal da operação desejada:")
   leia(sinalOperacao)
   escolha sinalOperacao
   caso "+"
      resultado <- numero1 + numero2
      escreval("A soma dos dois números é:" , resultado)
   caso "-"
      resultado <- numero1 - numero2
      escreval("A subtração entre os dois números é:" , resultado)
   caso "*"
      resultado <- numero1 * numero2
      escreval("A multiplicação entre os dois números é:" , resultado)
   caso "/"
      resultado <- numero1 / numero2
      escreval("A divisão entre os dois números é:" , resultado)
   outrocaso
      escreval("Operação não identificada... Tente novamente.")
   fimescolha

Fimalgoritmo