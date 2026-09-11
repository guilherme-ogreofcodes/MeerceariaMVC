


<div align="center">

# 🛒 MerceariaMVC

### Sistema de Gestão para Mercearias

Aplicação web desenvolvida em **ASP.NET Core MVC** utilizando **C#**, **Entity Framework Core (Code First)** e **SQL Server**.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge&logo=csharp&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_Core-MVC-5C2D91?style=for-the-badge&logo=dotnet)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Bootstrap Icons](https://img.shields.io/badge/Bootstrap_Icons-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

</div>

---

# 📑 Índice

- [📖 Sobre o Projeto](#-sobre-o-projeto)
- [🚀 Funcionalidades](#-funcionalidades)
- [🛠 Tecnologias Utilizadas](#-tecnologias-utilizadas)
- [🗄 Banco de Dados](#-banco-de-dados)
- [📷 Telas do Sistema](#-telas-do-sistema)
- [▶️ Como Executar](#️-como-executar)
- [📁 Estrutura do Projeto](#-estrutura-do-projeto)
- [🎯 Objetivos de Aprendizagem](#-objetivos-de-aprendizagem)
- [👨‍💻 Créditos](#-créditos)

---

# 📖 Sobre o Projeto

O **MerceariaMVC** é um sistema web desenvolvido em ASP.NET Core MVC, utilizando C#, Entity Framework Core e SQL Server. O projeto permite realizar o cadastro, consulta, edição e exclusão de produtos e clientes, além de oferecer controle de estoque e interface responsiva para estabelecimentos comerciais. Seu objetivo é aplicar na prática conceitos de desenvolvimento web, arquitetura MVC, banco de dados e operações CRUD, proporcionando uma aplicação organizada e funcional.

---

# 🚀 Funcionalidades

✅ **Painel de Controle (Dashboard):** Visão geral do sistema e atalhos de navegação.

✅ **Gestão de Produtos:** Cadastrar, listar, editar, visualizar detalhes e controlar estoque com alerta visual de quantidade baixa.

✅ **Gestão de Clientes:** Cadastro completo (Nome, E-mail, Idade e Status) com controle de perfis ativos e inativos.

✅ **Interface Responsiva:** Design customizado em CSS moderno com ícones Bootstrap Icons.

✅ **Persistência de Dados:** Integração completa com banco SQL Server via Entity Framework Core.

---

# 🛠 Tecnologias Utilizadas

| Tecnologia | Descrição |
| --- | --- |
| C# | Linguagem de programação principal |
| ASP.NET Core | Framework web para arquitetura MVC |
| Entity Framework Core | Mapeamento objeto-relacional (ORM) |
| SQL Server | Banco de dados relacional |
| HTML5 / CSS3 | Estrutura e estilização da interface |
| Bootstrap Icons | Biblioteca de ícones interativos |

---

# 🗄 Banco de Dados

A aplicação utiliza o **SQL Server** para armazenamento e persistência das informações.

O banco de dados armazena os registros do catálogo de produtos, controle de estoque e o cadastro de clientes.

A conexão deve ser configurada no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=dbMerceariaMVC;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

```

---

# 📷 Telas do Sistema

### 🏠 Tela Inicial / Dashboard

![Tela Inicial](https://raw.githubusercontent.com/guilherme-ogreofcodes/MerceariaMVC/main/MerceariaMVC/Imagens/TelaInicial.png)


### 📦 Gestão de Produtos


![Tela de Produtos](https://raw.githubusercontent.com/guilherme-ogreofcodes/MerceariaMVC/main/MerceariaMVC/Imagens/TelaProdutos.png)


### 👥 Gestão de Clientes


![Tela de Clientes](https://raw.githubusercontent.com/guilherme-ogreofcodes/MerceariaMVC/main/MerceariaMVC/Imagens/TelaClientes.png)

# ▶️ Como Executar

## 1. Clone o projeto

```bash
git clone [https://github.com/guilherme-ogreofcodes/MerceariaMVC.git](https://github.com/guilherme-ogreofcodes/MerceariaMVC.git)

```

Entre na pasta do projeto:

```bash
cd MerceariaMVC

```

---

## 2. Abra o projeto

Abra a solução (`.sln`) utilizando o **Visual Studio 2022** ou outra IDE compatível com **ASP.NET Core**.

---

## 3. Configure a conexão com o banco

Abra o arquivo `appsettings.json` e configure a string de conexão de acordo com o seu ambiente e sua instalação do **SQL Server**.

---

## 4. Configure o banco de dados

Caso o projeto utilize **Entity Framework Core e Migrations**, execute no **Package Manager Console**:

```powershell
Update-Database

```

Ou, utilizando a CLI do .NET:

```bash
dotnet ef database update

```

---

## 5. Execute o projeto

No Visual Studio, pressione **F5** ou clique em **Iniciar** para executar a aplicação.

---

# 📁 Estrutura do Projeto

```text
MerceariaMVC
│
├── Controllers
├── Data
├── Imagens
│   ├── TelaClientes.png
│   ├── TelaInicial.png
│   └── TelaProdutos.png
├── Migrations
├── Models
├── Views
├── wwwroot
├── appsettings.json
├── Program.cs
└── README.md

```

---

# 🎯 Objetivos de Aprendizagem

Este projeto foi desenvolvido com o propósito de praticar e aplicar conhecimentos relacionados a:

* ASP.NET Core MVC
* Linguagem C#
* Desenvolvimento Web Responsivo
* Arquitetura MVC
* SQL Server
* Integração entre aplicação e banco de dados via Entity Framework Core
* Operações CRUD
* Cadastro, gerenciamento de estoque e fluxo de clientes
* Organização e estruturação de aplicações web

---

# 👨‍💻 Créditos

### Desenvolvedor

**Guilherme Pereira Dantas de Oliveira Santos**

---

### Professor

**Wallace Oliveira dos Santos**

---

### ⭐ Se este projeto foi útil para você, deixe uma estrela no repositório!

```

```
