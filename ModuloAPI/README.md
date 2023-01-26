# MODULO API

## Como criar uma API do 0 no C#?
### Set o seguiente comando no terminal
![image](https://user-images.githubusercontent.com/99850729/214345873-63c71fec-15cf-405b-9a2f-fdfdb1ec9ea5.png)

## Como é criado o caminho?
### esses são os metodos que constitui o caminho.
![image](https://user-images.githubusercontent.com/99850729/214353976-09a38c33-19f4-43b2-a942-fbccc2a138a2.png)


## Entity Framework
### Como instar os pacotes no C#:
#### É apenas instalado uma vez, porque o tool é a nivel de maquina
![image](https://user-images.githubusercontent.com/99850729/214850313-69f0ffcc-801e-4102-a040-a7febdf47b82.png)

#### Instalando o packagem design do Entity.
![image](https://user-images.githubusercontent.com/99850729/214851000-0ea73f33-abf9-4be7-80ae-2f81ac76f763.png)

#### Instalando o packagem do banco de dados que será usado.
![image](https://user-images.githubusercontent.com/99850729/214851622-82923d81-41b7-44d0-a346-ad6551e1c80e.png)


### Caso ocorreu tudo com sucesso, os pacotes vão estar aqui.
![image](https://user-images.githubusercontent.com/99850729/214851929-3e17c5df-cde2-475a-825d-a13fb78e488c.png)


# Criando um CRUD
## Criando a classe para criar a entidade com a migração
![image](https://user-images.githubusercontent.com/99850729/214956429-403aa6b5-3831-4648-ba2c-d9f9b4be4bfa.png)

## Conectando o banco SQL Server com a API



## Desenvolvendo um contexto para receber a herança do DbContext que é uma classe do Entety Framework para realizar a migração e constituir o DbSet que vai gerar a entendade Contatos
![image](https://user-images.githubusercontent.com/99850729/214956654-245d57d2-1624-49ec-ac8b-fd63ba288c92.png)

## Local a onde vamos desenvolver a ConnectionString
![image](https://user-images.githubusercontent.com/99850729/214957120-fe295c6b-c72c-40e0-8e28-a2d3e6c5f8dc.png)

### No appsettings.Developmente.json, vamos fazer a CONNECTIONSTRING que resumidade é a conexão do SQL Server com o nosso programa em alguma porta no caso a do localshost
![image](https://user-images.githubusercontent.com/99850729/214957389-fd487e8c-4c14-4bfa-85e2-79aca62a7711.png)

### Utilizando a migration vamos criar a entidade contatos com o seguinte comando no terminal:
![image](https://user-images.githubusercontent.com/99850729/214962576-50d7d392-ae4d-43f6-8373-e5f67b85c8bf.png)



![image](https://user-images.githubusercontent.com/99850729/214962685-3be7216b-8ccd-438c-8c99-6744a898014f.png)



![image](https://user-images.githubusercontent.com/99850729/214962714-3c636dfc-4f9a-45b9-948a-452d10662b06.png)



![image](https://user-images.githubusercontent.com/99850729/214962757-9464b402-df2e-43b3-80b7-fb5af219fc1b.png)


### Agora vamos subir a nossa tabela para o banco de dados:
![image](https://user-images.githubusercontent.com/99850729/214963063-b1f4b8e1-46d2-4a42-bd7d-4ebab4dc6421.png)![image](https://user-images.githubusercontent.com/99850729/214963064-a4af2d02-917c-4158-8e6c-6bc749223aeb.png)


### Pronto foi realizada uma migração, agora temos um banco de dados criado sem termos digitado uma linha de codigo no SQL Server

