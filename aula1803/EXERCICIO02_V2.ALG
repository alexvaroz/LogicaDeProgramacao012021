Algoritmo "Exercicio02"

Var
   primeiraIdade, segundaIdade:inteiro
   idadeHomemMaisVelho, idadeHomemMaisNovo: inteiro
   idadeMulherMaisVelha, idadeMulherMaisNova: inteiro
Inicio
   escreval("Informe as idades dos dois homens:")
   leia(primeiraIdade, segundaIdade)
   se (primeiraIdade > segundaIdade) entao
      idadeHomemMaisVelho <- primeiraIdade
      idadeHomemMaisNovo <- segundaIdade
   senao
      idadeHomemMaisVelho <- segundaIdade
      idadeHomemMaisNovo <- primeiraIdade
   fimse
   escreval("Informe as idades das duas mulheres:")
   leia(primeiraIdade, segundaIdade)

   se (primeiraIdade > segundaIdade) entao
      idadeMulherMaisVelha <- primeiraIdade
      idadeMulherMaisNova <- segundaIdade
   senao
      idadeMulherMaisVelha <- segundaIdade
      idadeMulherMaisNova <- primeiraIdade
   fimse
   escreval("A soma das idades do homem mais velho com a mulher mais nova é:")
   escreval(idadeHomemMaisVelho + idadeMulherMaisNova)
   escreval("O produto das idades do homem mais novo com a mulher mais velha é:")
   escreval(idadeHomemMaisNovo * idadeMulherMaisVelha)

Fimalgoritmo