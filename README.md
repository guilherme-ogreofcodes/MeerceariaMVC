# 🛒 MerceariaMVC

Uma aplicação web completa para gerenciamento de clientes e estoque de produtos para mercearias, desenvolvida no padrão de arquitetura **MVC (Model-View-Controller)** com **ASP.NET Core**.

---

## 🛠️ Tecnologias Utilizadas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%208.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core%20MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

---

## 📌 Sumário

- [📖 Sobre o Projeto](#-sobre-o-projeto)
- [👨‍🎓 Autoria e Orientação](#-autoria-e-orientação)
- [✨ Funcionalidades](#-funcionalidades)
- [📸 Capturas de Tela](#-capturas-de-tela)
- [🗄️ Configuração do Banco de Dados](#️-configuração-do-banco-de-dados)
- [▶️ Como Executar](#️-como-executar)
- [📁 Estrutura do Projeto](#-estrutura-do-projeto)

---

## 📖 Sobre o Projeto

O **MerceariaMVC** é uma solução robusta para cadastro, controle e gerenciamento de **Clientes** e **Produtos**. O sistema conta com uma interface responsiva, intuitiva e moderna, permitindo a realização do fluxo CRUD completo (Criar, Ler, Atualizar e Deletar), além de controlar estoque em tempo real e aplicar regras de negócio diretamente no servidor via Entity Framework Core.

---

## 👨‍🎓 Autoria e Orientação

- **Aluno / Desenvolvedor:** Guilherme Pereira Dantas de Oliveira Santos
- **Professor / Orientador:** Wallace Oliveira dos Santos

---

## ✨ Funcionalidades

### 👥 Módulo de Clientes
- Cadastro completo de clientes (Nome, E-mail, Idade e Status).
- Controle de status ativo/inativo para permissões no sistema.
- Validação de dados do cliente diretamente na Model/Controller.
- Listagem organizada, consulta de detalhes, edição e remoção.

### 📦 Módulo de Produtos
- Cadastro detalhado do catálogo com Nome, Preço e Quantidade.
- Controle automatizado de estoque com alerta visual de quantidade baixa.
- Operações de edição, atualização de saldo de estoque e exclusão de itens.

---

## 📸 Capturas de Tela

### 🏠 Painel Inicial (Dashboard)
![Página Inicial](./MerceariaMVC/Imagens/TelaInicial.png)

---

### 📍 Módulos do Sistema

| Gestão de Clientes | Gestão de Produtos |
| :---: | :---: |
| ![Módulo de Clientes](./MerceariaMVC/Imagens/TelaClientes.png) | ![Módulo de Produtos](./MerceariaMVC/Imagens/TelaProdutos.png) |

---

## 🗄️ Configuração do Banco de Dados

A aplicação utiliza o **SQL Server** com a abordagem **EF Core Code First**.

Configure sua string de conexão no arquivo `appsettings.json` dentro da pasta `MerceariaMVC`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=dbMerceariaMVC;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
