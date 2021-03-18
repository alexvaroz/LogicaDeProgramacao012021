Algoritmo "Exercicio02"

Var
   idadeHomem1, idadeHomem2, idadeMulher1, idadeMulher2:inteiro
   idadeHomemMaisVelho, idadeHomemMaisNovo: inteiro
   idadeMulherMaisVelha, idadeMulherMaisNova: inteiro
Inicio
   escreval("Informe as idades dos dois homens:")
   leia(idadeHomem1, idadeHomem2)
   escreval("Informe as idades das duas mulheres:")
   leia(idadeMulher1, idadeMulher2)
   se (idadeHomem1 > idadeHomem2) entao
      idadeHomemMaisVelho <- idadeHomem1
      idadeHomemMaisNovo <- idadeHomem2
   senao
      idadeHomemMaisVelho <- idadeHomem2
      idadeHomemMaisNovo <- idadeHomem1
   fimse
   se (idadeMulher1 > idadeMulher2) entao
      idadeMulherMaisVelha <- idadeMulher1
      idadeMulherMaisNova <- idadeMulher2
   senao
      idadeMulherMaisVelha <- idadeMulher2
      idadeMulherMaisNova <- idadeMulher1
   fimse
   escreval("A soma das idades do homem mais velho com a mulher mais nova é:")
   escreval(idadeHomemMaisVelho + idadeMulherMaisNova)
   escreval("O produto das idades do homem mais novo com a mulher mais velha é:")
   escreval(idadeHomemMaisNovo * idadeMulherMaisVelha)

Fimalgoritmo