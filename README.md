# Fiap.TC.Fase1

## Descrição

**Fiap.TC.Fase1** é uma solução desenvolvida como parte do desafio técnico para a pós-graduação em Software Architecture na FIAP. Esta API foi desenvolvida usando .NET 6 e se conecta a um banco de dados MongoDB. O projeto implementa a arquitetura hexagonal, garantindo uma separação limpa de responsabilidades e facilitando a manutenibilidade.

![Diagrama do Event Storming](/assets/EventStormingTCFASE1-FIAP.jpg)

## Características

- **Linguagem & Framework:** .NET 6.
- **Arquitetura:** Hexagonal.
- **Banco de Dados:** MongoDB.
- **Containerização:** Docker.
- **Imagem Docker:** Publicada no Docker Hub.
- **Documentação:** Event Storming no Miro.

## Pré-requisitos

- Docker instalado.

## Instruções de Execução

1. Clone este repositório:
   ```bash
   git clone https://github.com/brunodiego5/Fiap.TC.Fase1.git
   ```

2. Acesse a pasta do projeto e então a pasta `src`:
   ```bash
   cd Fiap.TC.Fase1/src
   ```

3. Utilizando Docker, inicie a aplicação:
   ```bash
   docker compose up
   ```

## Nota
Após a execução bem-sucedida, a API estará disponível na porta `80`.


## Endpoints da API

### 📌 Cliente

**1. POST /Customer**
   
Payload:
```json
{
  "nome": "Nome do Cliente",
  "email": "cliente@example.com",
  "cpf": {
    "numero": "123.456.789-01"
  }
}
```
Resposta:
- **200**: Success

**2. GET /Customer?cpf=<string>**

Resposta:
- **200**: Success

### 📌 Pedido

**1. POST /Order**

Payload:
```json
{
  "clienteId": "ID do Cliente",
  "items": [
    {
      "produtoId": "ID do Produto",
      "quantidade": 1
    }
  ]
}
```
Resposta:
- **200**: Success

**2. GET /Order**

Resposta:
- **200**: Success

### 📌 Produto

**1. POST /Product**

Payload:
```json
{
  "nome": "Nome do Produto",
  "categoria": 1,
  "preco": 15.00,
  "descricao": "Descrição do produto.",
  "imagem": "url_da_imagem"
}
```
Resposta:
- **200**: Success

**2. GET /Product?categoria=<integer>**

Resposta:
- **200**: Success

**3. PUT /Product?id=<UUID>**

Payload:
```json
{
  "nome": "Nome do Produto",
  "categoria": 1,
  "preco": 15.00,
  "descricao": "Descrição atualizada do produto.",
  "imagem": "url_da_imagem_atualizada"
}
```
Resposta:
- **200**: Success

**4. DELETE /Product?id=<UUID>**

Resposta:
- **200**: Success

## Links Externos

- [Imagem Docker no Docker Hub](https://hub.docker.com/r/brunodiego5/fiap.tc.fase1)
- [Diagrama do Event Storming no Miro](https://miro.com/app/board/uXjVNUiGV4E=/)