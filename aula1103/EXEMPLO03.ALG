Algoritmo "Exemplo03"

Var
   bonus, salario: real
   anosEmpresa: inteiro

Inicio
   escreval("Bom dia!!! Digite a quantidade de anos na empresa:")
   leia(anosEmpresa)
   escreval("Digite seu sal�rio atual:")
   leia(salario)
   se (anosEmpresa >= 5) entao
      bonus <- salario*0.2
   senao
      bonus <- salario*0.1
   fimse
   escreval("Voc� receber� um b�nus de", bonus, " reais")

Fimalgoritmo