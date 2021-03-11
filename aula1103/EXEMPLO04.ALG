Algoritmo "Exemplo04"

Var
   dividendo, divisor: inteiro
   resultado: real

Inicio
   escreval("Digite o dividendo:")
   leia(dividendo)
   escreval("Digite o divisor:")
   leia(divisor)
   se (divisor<>0) entao
      resultado <- dividendo/divisor
      escreval("O resultado é:", resultado)
   senao
      escreval("A divisão por zero não é possível!")
   fimse
Fimalgoritmo