# Seleção de Bolsistas - Prova Prática

## 1. Objetivo

Desenvolver um pequeno sistema para gerenciar alunos utilizando .NET Core no backend, HTML/CSS no frontend e SQL Server como banco de dados com o Entity Framework Core como ORM.

## 2. Especificações:

### 2.1 Backend:

Desenvolva uma aplicação web em .NET Core.

- Utilize Entity Framework Core como ORM para SQL Server.
- Implemente os métodos do controlador AlunoController para:
  - Criar um novo aluno.
  - Atualizar um aluno pelo Id.

### 2.2 Frontend:

Crie uma interface usando HTML e CSS. Você pode optar por usar Angular ou Razor para a criação das páginas.

- **2.2.1 Formulário de Alunos**
  - Será usado tanto para cadastro quanto para edição. Se um ID for passado para ele, preencha os campos com as informações do aluno correspondente.
  - Deve conter um formulário com os campos: Nome, Data de Nascimento, Curso.
  - Um botão de "Salvar" que envia os dados para a API e salva no banco de dados, tanto para criação quanto para edição.

### 2.3 Banco de Dados e Modelo

Utilize SQL Server como banco de dados.

## 3. Instruções

- Utilize o projeto disponibilizado no link [selecao-bolsista](https://github.com/alosaulo/selecao-bolsista.git)
- Utilize o comando em .net cli `dotnet ef database update`, ou em Package Manager Console `Update-Database`, para atualizar o banco de dados.
- Desenvolva o controlador AlunoController com as rotas especificadas.
- Crie o frontend com o "Formulário de Alunos" e a página de listagem.
- Certifique-se de que todas as operações do CRUD estejam funcionando corretamente.
- Enviar o projeto comprimido, ou link de download, para o email: saulocaliman@ceet.secti.es.gov.br

## 4. Critérios de Avaliação:

- Funcionalidade: Todas as operações do CRUD devem estar funcionais.
- Design: A interface, mesmo simples, deve ser limpa e intuitiva. Modificar a interface padrão é um diferencial.
- Organização do Código: O código deve ser bem estruturado e seguir boas práticas.
- Interação com o Banco: O uso correto do Entity Framework Core com SQL Server será avaliado.
- Feedback para o Usuário: O sistema deve fornecer feedbacks claros após cada operação.

## 5. Observações:

- A escolha de bibliotecas adicionais é livre. Justifique suas escolhas se perguntado.
- A avaliação é focada em habilidades técnicas, solução de problemas e organização.
- Boa sorte!
