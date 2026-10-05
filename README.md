# Ecommerce Checkout - xUnit

Projeto desenvolvido em **C# com .NET 10** para simular algumas funcionalidades de uma loja online, incluindo geração de código de rastreio, cálculo de pontos de fidelidade e verificação de frete grátis.

O projeto também possui **testes unitários utilizando xUnit**.

## Estrutura do Projeto

A solução é composta por dois projetos:

- **EcommerceCheckout.App** - contém o código de produção.
- **EcommerceCheckout.Tests** - contém os testes unitários utilizando xUnit.

Estrutura:

```text
EcommerceCheckout/
│
├── EcommerceCheckout.sln
│
├── EcommerceCheckout.App/
│   ├── EcommerceCheckout.App.csproj
│   ├── Program.cs
│   └── PedidoService.cs
│
├── EcommerceCheckout.Tests/
│   ├── EcommerceCheckout.Tests.csproj
│   └── PedidoServiceTests.cs
│
├── README.md
├── .gitignore
└── LICENSE
