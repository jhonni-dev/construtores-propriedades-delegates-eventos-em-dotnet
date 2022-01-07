# Construtores, Propriedades, Delegates e Eventos em .NET
> *Aula sobre Construtores, Propriedades, Delegates e Eventos em .NET do Bootcamp Avanade #2 da DIO*

## Aula 1 - Construtores
### Introdução
+ Um construtor é um **método especial**, que contém o mesmo nome do seu tipo classee **tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instaciação de um objeto.**
+ Um construtor não possui um retorno.
+ Atalho VS Code para criar um  construtor: ctor
+ Um **construtor padrão** é sempre definido quando não declaramos nenhum para sua classe.
  + Uma classe pode ter mais de um construtor.
  + Quando se usa um construtor com no mínimo um parâmetro, não é possível utilizar o contrutor padrão.
+ **Construtor privado (private):** é um construtor que não permite instanciar um objeto

## Aula 2
### Getters e Setters
+ O **Get** e **Set** servem para que você possa atribuir um valor em uma variável de maneira controlada e com validações.
+ **Propriedades:** é uma maneira de unificar o get e o set, podendo ter validações ou não.

## Aula 3
### Modificadores
+ **Readonly:** bloqueia um campo contra alterações que não sejam diretamente em sua inicialização ou pelo prório construtor.
+ **Constantes:** representa um valor que somente oide ser atribuído no momento de sua inicialização e não pode ser modificado posteriormente. Usa a palavra reservada **const**.
  + Não é possível inicializar uma constante sem valor.

## Aula 4
### Delegates
+ Um delegate é uma maneira de passar um método como referência, podendo ser usado como um callbackk, aceitando qualquer método que contenha a mesma assinatura.
+ Obedece a ordem FIFO.
+ Usa-se a palavra reservada 'Invoke' para passar os parâmetros para o delegate
+ **Multicast delegate:** é uma extensão do delegate que consiste em chamar vários métodos em sequência numa única chamada do delegate.
  + para isso usa-se o '+=' na chamada de cada método adicional.

## Aula 5
### Eventos
+ Evento é um mecanismo de comunicaçao entre objetos, onde existe um **publisher** que realiza o evento, e o **subscriber** que se inscreve em um evento.
+ Um evento usa internamente um delegate, logo, para definir um evento, precisamos primeiramente definir um delegate.
+ Usa a palavra reservada **event**
