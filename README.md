# Pottencial-.NET-Developer

## Manipulação de Valores Monetários:

## Formatando o valor Decimal em monetário.
#### ![image](https://user-images.githubusercontent.com/99850729/206732301-6f5a2bdf-beb1-450b-bef1-2fcb5c94204b.png)

#### Saída esperada:
![image](https://user-images.githubusercontent.com/99850729/206746658-ef578f17-37db-44fc-8229-08186ba0fab4.png)


### Formata a maquina para uma determinda região, assim mudando a moeda.
![image](https://user-images.githubusercontent.com/99850729/206729885-f5cb6292-a5b7-4c6f-8f8a-d980b8746dca.png)

### Formatando direto na string e setando a região desejada.
![image](https://user-images.githubusercontent.com/99850729/206729517-eb3015c2-5fe0-40af-93bf-248f46f51109.png)

#### Saída esperada:
![image](https://user-images.githubusercontent.com/99850729/206746920-a86a24cc-2cfb-4893-89d2-ac152313f502.png)

## Formatção personalizada, é possivel personalizar a quatantidade de números que haverá na saída:
![image](https://user-images.githubusercontent.com/99850729/206778975-0d13db78-6e72-4624-8e80-3dd0f8e32fee.png)
#### O número depois do C é a quantidade de números que haverá depois da virgula.

#### Saída
![image](https://user-images.githubusercontent.com/99850729/206779359-3185f97b-d66b-41e7-8e6b-d206687d4a52.png)


## Formatando para Porcemtagem
![image](https://user-images.githubusercontent.com/99850729/206780535-62180a80-206b-45b2-87c5-882beaacba8f.png)
#### Use os ponto no começo e o P dentro do toString para formatar com porcentagem.

#### Saída 
![image](https://user-images.githubusercontent.com/99850729/206782302-a79a8567-6a7a-4366-a1c8-9ac62f5620b2.png)




## Personalizando a saída
![image](https://user-images.githubusercontent.com/99850729/206781826-e55b1892-c6d6-40b1-b41c-197e8a4d1856.png)
#### Os # é usados para separar os valores.

#### Saída 
![image](https://user-images.githubusercontent.com/99850729/206782503-37de6274-dceb-451a-a9f2-6a16cdc3425b.png)

## Formatando Hora
![image](https://user-images.githubusercontent.com/99850729/206786248-9919ffbc-0cf8-4f7c-bdc4-2b63a98361f9.png)



# Exceptions ou exceções 
## São situações excepcionais ou insperadas que ocorrem quando o programa é executado.

### Como ler arquivos txt no C#? 
### Para ler aquivos txt Primeiro:
### crie uma pasta, depois crie um arquivo txt
![image](https://user-images.githubusercontent.com/99850729/208253460-f0b18721-e6f0-4ac2-8fd9-d102834458c6.png)


### Logo apos, vai até a pagina program.cs do seu projte e set o seguinte codigo
![image](https://user-images.githubusercontent.com/99850729/208253423-61465535-e98c-4fb2-8d80-f580f2343eb0.png)

### Resultado: 
![image](https://user-images.githubusercontent.com/99850729/208253448-63b3b8d4-c5e5-4b4d-958b-038484de4660.png)


## Tratando exeção com Try Catch 
### O que é o try? 
O try só pela a tradução dele já podemos entender o que ele faz, "Try: tente."
O try em um codigo, ele tenta executar determindados blocos de códigos e caso de uma EXCEÇÃO, o catcha é responsavel pela solução, ele apanha o codigo com erro e trata. Dessa forma o block de código não vai para na exceção, vai prosseguir e finalizar. "Catch: apanhar", 

### Estrutura do try catch
![image](https://user-images.githubusercontent.com/99850729/209876083-b1082ca3-6741-4637-9a71-0b8ffe5ff4a7.png)


### Saida
#### Sem o Try Catch
![image](https://user-images.githubusercontent.com/99850729/209877362-9f4d1f0f-9028-4611-ab10-3d8a729ea08e.png)
#### Com o Try Catch
![image](https://user-images.githubusercontent.com/99850729/209876452-fc7ac9ef-714d-4fa7-b932-5b3f9f61aeb8.png)

## Exceção Genéricas
### O try pode conter varios catch e cada um pode cuidar de uma excecão

![image](https://user-images.githubusercontent.com/99850729/209882139-be5ceb5e-24db-4693-9fdd-fd861c493fdf.png)

### Saida: 

#### Erro 1
![image](https://user-images.githubusercontent.com/99850729/209882235-17b67925-9bf9-4ad8-b1e4-4f09b733d061.png)

#### Erro 2
![image](https://user-images.githubusercontent.com/99850729/209882195-d3fd8cf9-a309-479a-b220-336f3e783402.png)


## Finally
### O Finally vem logo após o try catch e podemos adicionar um novo block de código ali.
### E o Finally sempre vai ser executado mesmo que haja erro e execulte um catch ou não.

![image](https://user-images.githubusercontent.com/99850729/210616530-bfe3d048-7b31-48b3-a57a-c160a5675ceb.png)

Saida com o erro:
![image](https://user-images.githubusercontent.com/99850729/210616748-a0eaab05-3722-450f-9438-363657fe18c5.png)


Saida sem erro:
![image](https://user-images.githubusercontent.com/99850729/210616864-8f3066f0-89f3-481f-bcf0-838004a4c28b.png)

### Resumo, o finally é algo que sempre acontecerá, independe de errpos, ou não.


## Throw 
### O throw é usado para pegar erros e jogar pra cima, no caso, jogar para um try catch para ser tratado

### Saida com o try catch:
![image](https://user-images.githubusercontent.com/99850729/210621197-1280eb6e-f68e-4e71-8c56-2297d904d69d.png)


### Saida sem o try catch:
![image](https://user-images.githubusercontent.com/99850729/210621398-ce6b4914-d5dd-4ed0-8407-483416f07009.png)


# Coleções 
## Queue ou fila
### Funciona no sistema FIFO First In, First Out. Basicamente igual uma fila normal, o primeiro que chega é o primeiro que sair e o último que chegar é o último que saí.
![image](https://user-images.githubusercontent.com/99850729/210677332-d386cb24-4e79-46fa-86db-b0d52a20d58f.png)

### Saida: 
![image](https://user-images.githubusercontent.com/99850729/210677370-0396c330-12f9-4c9c-ae1a-bf4ffe13d250.png)

## Stack ou pila
### Funciona igual uma pilha de coisa. Funciona no sistema LIFO, Last In, First Out. Basicamente é o contrario de uma fila, o primeiro que chega é o último que saí, e o último que chega é o primeiro que saí.

![image](https://user-images.githubusercontent.com/99850729/210678462-ac5e34bc-5521-4d68-a287-c76f69bb8538.png)
#### A ordem da pilha é diferente da ordem para a lista ela é do top para a base, do último para o primeiro.

### Saída:
![image](https://user-images.githubusercontent.com/99850729/210678702-267529a3-6038-4c09-8b43-092909cc368d.png)
#### Para remover usamos o pop que remove do top para a base.


## Dictionary
### O Dictionary é diferente das coleções acima, porque ele utiliza o sisteme de chave e valor. A chave precisa ser unica, caso o contrario o correra uma exceção.

![image](https://user-images.githubusercontent.com/99850729/210680680-2d7b3677-9064-44c2-9102-131d87fb958e.png)


### Saida:
![image](https://user-images.githubusercontent.com/99850729/210680739-d2f75da8-41ea-4e6b-ab60-6b713e969ac7.png)

### Para remover um elemento do Dictionary é usado a chave e a Propriedade Remove
![image](https://user-images.githubusercontent.com/99850729/210681315-af973235-7700-4c9c-adf5-6145ae74b78d.png)

### Para alteramos dados também é algo facil, precisamos apenas da chave
![image](https://user-images.githubusercontent.com/99850729/210681951-b1ff2e76-d024-4f54-9f2a-5ec12722e53a.png)


## Tuplas
### é uma aglomerado de dados de estruraturas simples. Dentro de uma tuplas, podemos encontrar varios dados como strings, int e arrys etc...
![image](https://user-images.githubusercontent.com/99850729/210848279-d8fbfa22-f17c-45dc-b76d-e30497bba61f.png)

### Saida: 
![image](https://user-images.githubusercontent.com/99850729/210848376-9fbef685-658a-4f67-ae36-081fd6231a43.png)

### Criando um metodo com uma tupla

#### Metodo leitura de arquivos 
![image](https://user-images.githubusercontent.com/99850729/211024987-a5f62b59-2c83-4a4c-8d63-7def3af99ffc.png)

#### Program com o código pronto
![image](https://user-images.githubusercontent.com/99850729/211025091-81b48d13-92c2-4de3-b62c-129d5fe8707e.png)

#### Saída: 
![image](https://user-images.githubusercontent.com/99850729/211025377-9509d907-4c4b-49cc-93db-1d1f6b7dfd07.png)

## IF ternário
### Construindo um leitor de números par ou ímpar
![image](https://user-images.githubusercontent.com/99850729/211032107-82bd8896-3e2a-4f94-aeb1-2e5434794eca.png)
#### No if ternário sempre vamo ter dois valores e usamos ? e :. O ? é usado logo após a condição e ele é o famose "Se for verdade é" Já "Se for falso" podemos usar o : e o resultado. 

### Saida: 
![image](https://user-images.githubusercontent.com/99850729/211032328-b34a86d3-1299-4d26-978c-a5d4c834b33f.png)


## Nuget 
### Gerenciado de pacotes do C# 

![image](https://user-images.githubusercontent.com/99850729/211171823-d8f027b6-a6e4-4a34-8d0a-f54d5290353c.png)

### Instalando o NuGet 
#### Vai até o site e pege o comando 
![image](https://user-images.githubusercontent.com/99850729/211172279-1953e0dc-9b34-42a8-91cc-ec07bb5c645d.png)

### Agora escreva o codigo no terminal e execute o enter.
![image](https://user-images.githubusercontent.com/99850729/211172312-7ab85928-e47c-4251-bd82-b043c101c7fe.png)


### Para saber se o pacote foi instalado, vá até o arquivo .csproj e procure o nome do pacote instalado e a versão:
![image](https://user-images.githubusercontent.com/99850729/211172261-126bb397-e77c-402d-ad88-7c8662666663.png)


## Serialização 
### O que é serialização? 
#### Serialização é uma forma de transição de dados entre linguagens semelhantes ou liguagens diferentes, usando o formato Json.

### Como serializar um objeto?
#### é simples logo após criar ele em uma class
![image](https://user-images.githubusercontent.com/99850729/211425141-7ddf3437-882a-4e60-b47c-a8c806fc3b2e.png)
<br>

#### Passe as informações sobre ele e export o Newtonsoft e Utilizando a documentação passe os dados para o Newtonsoft que iria forma em tipo Json:
![image](https://user-images.githubusercontent.com/99850729/211425168-92f24aa8-68ee-405c-b3bc-fe77b1229ab0.png)

### Saída:
![image](https://user-images.githubusercontent.com/99850729/211425198-66277b04-12f2-4857-adf4-460b67b55061.png)

## Como escrever um objeto no formato Json? 
### Escreva o seguinte código com o caminho do arquivo

![image](https://user-images.githubusercontent.com/99850729/211426968-bd057505-91ec-4563-ab21-81abc9083580.png)

### Saída esqperada:
![image](https://user-images.githubusercontent.com/99850729/211427047-c83c1c3b-9d9a-4e4b-a66f-d93a1f76f3c0.png)


## Valores especiais no C#
### Tipos de valor nulo (nullable)


![image](https://user-images.githubusercontent.com/99850729/211872006-46d2ab26-42c8-4f0d-9b18-d7e8006f21a8.png)


### Para transformar uma propriedade nulla usamos o ? na frente da propriedade.
![image](https://user-images.githubusercontent.com/99850729/211884069-8d2992c1-3276-4c49-ab1c-e1b16244d5bd.png)
#### Como decimal de exemplo

### Tipos anonimos
#### é igual um tupla, só que apenas para a leitura
![image](https://user-images.githubusercontent.com/99850729/211884845-8a1caa22-125d-4c0c-994c-13d2ecc69cb7.png)
#### é apenas o get, somente leitura 

#### Exemplo:
![image](https://user-images.githubusercontent.com/99850729/211886195-3c631308-73d2-402d-af65-76bdb4a554a5.png)

### Variavel Dinamica
#### Baíscamente é uma variavel que indentifica o valor pela forma como ele entra e ja set ele como string, int, bool.

#### Exemplo
![image](https://user-images.githubusercontent.com/99850729/211917282-4aa4fe15-d5f6-422a-816e-348c13451c36.png)


### Lista generica 
![image](https://user-images.githubusercontent.com/99850729/211917942-ad35f192-be05-4e31-bb44-f1ff6ff77202.png)

## O comando new console cria uma estrutura so com o program.cs
![image](https://user-images.githubusercontent.com/99850729/212480132-82dc57da-8be2-4d44-b473-e3d44bcf2954.png)

## Orientação a Objeto ou POO:
### Abstração.
#### O que é abstração?
##### Abstração é uma forma de abstair as objetos da vida real, do plano terro para o mundo da programação, dependo do caso apenas colocaremos as informações mas imporante e que se encaixe em seu contexto.
![image](https://user-images.githubusercontent.com/99850729/212538654-031e4d7a-a6d2-4638-a6b1-def9b4883d6d.png)


### Encapsulamento.
#### O que é encapsulamento na POO:
##### O encapsulamento serve para proteger uma classe e definir limites para outras classe de suas como podem utilizar as suas propriedades.






### Herança.
#### O que é a Herença na POO: 
##### A Herença é a forma mais limpa que podemos usar para reaproveitar o nosso código e não ficamos repetindo códigos desnecessários.
![image](https://user-images.githubusercontent.com/99850729/212538212-da9d33f6-43e8-43ba-af3c-c73d3e153f6e.png)


#### Como fazer para uma classe herdar a outra? 
![image](https://user-images.githubusercontent.com/99850729/212536158-3dfe3d8c-bca6-4472-9717-2e82806d6f04.png)
##### é algo simples, apenas coloque : na frente do nome da classe e coloque o nome da classe que deseja herdar


### Polimorfismo 
#### O que é polimorfismo?
##### O polimorfismo vem do grego e quer dizer em tradução livre varias formas, Mas o polimorfismo na pratica, sobrescrever métodos das classes filhas para se comportamento de maneira diferente e ter a sua propria implementação.


Para podemos permetir a classe filha modificar a classe usando o polimorfismo, precisamos declara virutal na classe pai que sera alterada pela filha.<br>
![image](https://user-images.githubusercontent.com/99850729/212539654-2fa4fdad-0430-47ea-8652-020579903c21.png)


Na classe filha  precisamos declara override na classe filha que vai modificar e precisa ter o mesmo nome, mas pode modificar as informações.
![image](https://user-images.githubusercontent.com/99850729/212539726-7aa7947f-00b7-4ae3-83dd-379de48c487c.png)



![image](https://user-images.githubusercontent.com/99850729/212540415-ab6c1efa-9340-42e3-b894-78f940992544.png)


![image](https://user-images.githubusercontent.com/99850729/212540425-0ebfc441-24ae-4ad5-8fe6-814e304ebabe.png)


### Classe Abstrata
#### é uma classe onde apenas podemos sobrescrever métodos para as classe filhas fazerem um polimorfismo e a classe abstrata não pode ser instanciada.

![image](https://user-images.githubusercontent.com/99850729/212681259-dc2a78f3-9052-4705-9bc9-6ad9ad4b1726.png)


#### como utilizar a classe abstrata na pratica?
![image](https://user-images.githubusercontent.com/99850729/212681809-4e5a54de-a29c-44a2-9c04-5d02e4093b7a.png)
###### Primeiro você posiciona a palavra abstrata na frente do nome da classe

#### Crie um metodo abstrato.
![image](https://user-images.githubusercontent.com/99850729/212697072-f7e2dfe9-b877-4a28-9f31-f535d05d11c2.png)

#### Logo após crie a classe filha que vai herdar esse metodo abstrato.
![image](https://user-images.githubusercontent.com/99850729/212697273-f5a9c0bd-ac23-445e-84e7-cf1384b8be70.png)
##### a abstração é praticamente igual ao polimorfismo, a unica diferença que o metodo que é abstrato, ele é obrigatoriamente forçado a classe filha passar algum tipo de valor para ele.

##### SAÍDA
![image](https://user-images.githubusercontent.com/99850729/212698005-ae1805f8-d0fb-48c5-98b5-655575cc7536.png)

### Classe selada 
#### A classe selada é usada quando não queremos mais uma classe seja herdar por outra. Dessa forma as classe selada não pode ser classes pai de outras classes.

#### Como torna uma classe normal em classe selada. Apenas coloque a propriedade sealed na frente do nome da classe.
![image](https://user-images.githubusercontent.com/99850729/212721384-24f885be-1aa5-4700-97c8-96be51b60542.png)

### A classe diretor herdando a classe diretor.
![image](https://user-images.githubusercontent.com/99850729/212721422-11933162-3557-46ce-8143-aba7dc5f57b2.png)

#### Saída: Como o erro pela classe professor ser selada e a classe diretor não pode herdar ela.
![image](https://user-images.githubusercontent.com/99850729/212721471-3f376a48-69fa-4536-bdd0-0ac7bbaff243.png)


### Classe Object a mãe de todas as classe do .Net

## Interfaces 
