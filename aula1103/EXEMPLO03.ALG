Algoritmo "Exemplo03"

Var
   bonus, salario: real
   anosEmpresa: inteiro

Inicio
   escreval("Bom dia!!! Digite a quantidade de anos na empresa:")
   leia(anosEmpresa)
   escreval("Digite seu salário atual:")
   leia(salario)
   se (anosEmpresa >= 5) entao
      bonus <- salario*0.2
   senao
      bonus <- salario*0.1
   fimse
   escreval("Você receberá um bônus de", bonus, " reais")

Fimalgoritmo