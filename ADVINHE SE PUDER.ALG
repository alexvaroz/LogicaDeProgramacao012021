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
      escreval("Qual o n�mero secreto??")
      leia(chute)
      se (chute = numero_secreto) entao
         escreval("Parab�ns!!! Voc� acertou!!!")
         interrompa
      senao
         numero_tentativas <- numero_tentativas - 1
         se (chute > numero_secreto) entao
            escreval("Voc� errou...Tente um n�mero menor...")
         senao
            escreval("Voc� errou...Tente um n�mero maior...")
         fimse
         escreval("Voc� tem ainda", numero_tentativas, " tentativas.")
      fimse
   fimenquanto
   se (numero_tentativas = 0) entao
      escreval("Game over... Voc� perdeu...")
   fimse
   escreval("Fim do jogo")

Fimalgoritmo