# 🚗 API de Cadastro de Carros - Minimal API em C# - Projeto do Curso da DIO

Este projeto é uma API desenvolvida em **C#** utilizando **Minimal APIs** no .NET, com autenticação via **JWT** para gerenciamento de administradores e veículos.

## 📌 Funcionalidades

### 🔐 Administradores
- **Login** (`POST /administradores/login`) - Autentica um administrador e retorna um token JWT.
- **Listar administradores (paginação)** (`GET /administradores`) - Retorna administradores por página.
- **Buscar administrador por ID** (`GET /administradores/{id}`) - Retorna informações de um administrador específico.
- **Cadastrar administrador** (`POST /administradores`) - Cria um novo administrador (necessário estar autenticado).

### 🚙 Veículos
- **Listar veículos** (`GET /veiculos`) - Retorna todos os veículos cadastrados.
- **Buscar veículo por ID** (`GET /veiculos/{id}`) - Retorna informações de um veículo específico.
- **Cadastrar veículo** (`POST /veiculos`) - Adiciona um novo veículo.
- **Editar veículo** (`PUT /veiculos/{id}`) - Atualiza informações de um veículo existente.
- **Excluir veículo** (`DELETE /veiculos/{id}`) - Remove um veículo do sistema.

## 🔑 Autenticação
A API utiliza **JWT (JSON Web Token)** para autenticação.  
O token é gerado no endpoint `/administradores/login` e deve ser enviado no **header** `Authorization` no formato: Authorization: Bearer SEU_TOKEN_AQUI

## 🛠 Tecnologias Utilizadas
- **C# .NET**
- **Minimal APIs**
- **JWT Authentication**
- **Entity Framework Core**
- **MySQL** 
- **Swagger** para documentação

## ▶️ Como Executar o Projeto

1. **Clonar o repositório**
   ```bash
   git clone https://github.com/talyoliv/minimal-api
   cd minimal-api

2. **Configurar o banco de dados**
   ```bash
   Ajuste a connection string no arquivo appsettings.json.

3. **Instalar dependências**
   ```bash
   dotnet restore

4. **Executar o projeto**
   ```bash
   dotnet run

5. **Acessar o Swagger**
   ```bash   
   URL padrão: http://localhost:5038/swaggerc
