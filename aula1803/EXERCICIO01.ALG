Algoritmo "Exercicio01"

Var
   anoEleicao, anoNascimento: inteiro


Inicio
   escreval("Bom dia!!!")
   escreval("Digite o ano da eleição:")
   leia(anoEleicao)
   escreval("Digite o ano do seu nascimento:")
   leia(anoNascimento)
   se (anoEleicao - anoNascimento) >= 16 entao
      escreval("Você está apto para votar!!!")
   senao
      escreval("Você não estará apto a votar...")
   fimse

Fimalgoritmo