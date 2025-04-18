# BookstoreManagement - API

## Descrição

Este projeto é uma API para a gestão de uma livraria online. O objetivo é permitir a criação, visualização, edição e exclusão de livros, aplicando conceitos de desenvolvimento de APIs RESTful.

## Funcionalidades

A API oferece os seguintes recursos:

- **Criar um livro**: Adicionar um novo livro ao sistema.
- **Visualizar todos os livros**: Listar todos os livros cadastrados.
- **Editar um livro**: Atualizar as informações de um livro existente.
- **Excluir um livro**: Remover um livro do sistema.

## Estrutura de Dados

Cada livro possui os seguintes campos:

- `id` (único): Identificador único do livro.
- `título`: Nome do livro.
- `autor`: Nome do autor do livro.
- `gênero`: Categoria do livro (ex.: ficção, romance, mistério).
- `preço`: Valor do livro.
- `quantidadeEmEstoque`: Quantidade disponível no estoque.

## Endpoints

- **POST** `/livros`: Criar um novo livro.
- **GET** `/livros`: Listar todos os livros.
- **PUT** `/livros/{id}`: Atualizar as informações de um livro.
- **DELETE** `/livros/{id}`: Excluir um livro.

## Tecnologias Utilizadas

- **.NET 8**
- **C#**
- **ASP.NET Core** (para desenvolvimento da API)


Feito com 💜 por Douglas Resende
   