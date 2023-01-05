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
