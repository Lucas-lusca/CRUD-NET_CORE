# Aula 12: Pipeline

Bom, esta aula mostrou oque é pipeline e apresentou um exemplo. Não pretendo reproduzi-lo em código : )

Basicamente no exemplo era mostrado um pipeline para a montagem de um veiculo, sendo que o primero teste criado era um pipeline continuo (apenas uma direção), já o outro possui duas direções (ida e volta). Este que possui duas direções é interessante para momentos em que... com um exemplo sinto ser mais fácil de explicar. 

## Exemplo:

Um carro precisa colocar as maçanetas depois que a pintura for realizada, e esta função será feita pelo mesmo módulo que coloca as portas, mas isso não é possível ser feito caso o pipeline possuir apenas uma direção e a sequencia for está:

![Exemplo de sequencia Pipeline](/Aula-12-Pipeline/img/ExemploSequenciaPipeline.png "Pipeline sequencia")

Utilizando o método de ida e volta, a porta ira ser colocada, a pintura sera feita e na volta, o modulo pintura apenas "passa direto" e no módulo da porta é colocado a maçaneta.

![Exemplo saída Pipeline](/Aula-12-Pipeline/img/SaidaPipelineExemplo.png "Pipeline saída")

Mais exemplos são mostrados durante a aula, mas caso tenha entendido esse, Ok, não jugo ser necessário ver os outros, mas caso queira, segue abaixo a fonte.

##### Fonte: 
https://youtu.be/8PAA6prE190?list=PL0YuSuacUEWuN8xnvk2b5yW_koKbkHh_m