# MethodFactoryPaymentProcessor

O **MethodFactoryPaymentProcessor** é um sistema de processamento de pagamentos desenvolvido em .NET 6 que utiliza o padrão Factory para gerenciar a criação de diferentes processadores de pagamento de maneira eficiente e escalável.

## 🚀 Características

- **Padrão Factory**: Facilita a adição e manutenção de diferentes processadores de pagamento sem alterar o código central.
- **Injeção de Dependência**: Melhora a testabilidade e a manutenção do código ao desacoplar as classes de processamento de pagamento das suas dependências.
- **Encapsulamento através de Interfaces**: Assegura que mudanças em uma parte do sistema não afetam outras partes.
- **Testes Unitários**: Utiliza xUnit e Moq para testes unitários, garantindo que cada componente funcione corretamente de forma isolada.

## 📦 Dependências

- .NET 6 SDK
- xUnit
- Moq

## 🛠 Configuração

Para configurar o ambiente de desenvolvimento, siga estes passos:

1. Clone o repositório:
   
   git clone https://github.com/seu-usuario/MethodFactoryPaymentProcessor.git


2. Navegue até a pasta do projeto e restaure as dependências:

cd MethodFactoryPaymentProcessor
dotnet restore


## 🔨 Execução

dotnet run

## 🧪 Execução dos Testes

dotnet test


## 🤝 Contribuição
Contribuições são sempre bem-vindas! Se você tem sugestões para melhorar este projeto, 
sinta-se à vontade para fazer um fork do repositório e enviar um pull request, 
ou abrir um Issue com as tags "melhoria" ou "bug".

