Algoritmo "Advinhe se puder"

Var
   numero_secreto, chute: inteiro

Inicio
   numero_secreto <-25
   escreval("****************************")
   escreval("**                        **")
   escreval("** Seja bem vindo ao jogo **")
   escreval("**   ADIVINHE SE PUDER    **")
   escreval("**                        **")
   escreval("**                        **")
   escreval("****************************")
   escreval()
   escreval("Qual o número secreto??")
   leia(chute)
   se (chute = numero_secreto) entao
      escreval("Parabéns!!! Você acertou!!!")
   senao
      se (chute > numero_secreto) entao
         escreval("Você errou...Tente um número menor...")
      senao
         escreval("Você errou...Tente um número maior...")
      fimse
   fimse

Fimalgoritmo