Algoritmo "Advinhe se puder"

Var
   numero_secreto, chute, numero_tentativas: inteiro

Inicio
   numero_secreto <-Randi(50)
   numero_tentativas <- 3
   escreval("****************************")
   escreval("**                        **")
   escreval("** Seja bem vindo ao jogo **")
   escreval("**   ADIVINHE SE PUDER    **")
   escreval("**                        **")
   escreval("**                        **")
   escreval("****************************")
   escreval()
   enquanto numero_tentativas <> 0 faca
      escreval("Qual o número secreto??")
      leia(chute)
      se (chute = numero_secreto) entao
         escreval("Parabéns!!! Você acertou!!!")
         interrompa
      senao
         numero_tentativas <- numero_tentativas - 1
         se (chute > numero_secreto) entao
            escreval("Você errou...Tente um número menor...")
         senao
            escreval("Você errou...Tente um número maior...")
         fimse
         escreval("Você tem ainda", numero_tentativas, " tentativas.")
      fimse
   fimenquanto
   se (numero_tentativas = 0) entao
      escreval("Game over... Você perdeu...")
   fimse
   escreval("Fim do jogo")

Fimalgoritmo