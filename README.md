# E-Commerce Serverless Lambda Minimal API em .NET com AWS

## Descrição do Projeto

Este projeto é uma implementação de uma aplicação E-Commerce usando a arquitetura serverless da AWS. A aplicação é construída em .NET, utilizando AWS Lambda para a lógica de negócios, AWS API Gateway para expor APIs, AWS DynamoDB para armazenamento de dados, AWS SQS para a comunicação assíncrona e AWS S3 para o armazenamento de ativos.

### Tecnologias Utilizadas

- **AWS Lambda**: Funções serverless para a execução de código sem a necessidade de gerenciamento de servidores.
- **AWS API Gateway**: Serviço para criar, publicar, manter e monitorar APIs de maneira fácil.
- **AWS DynamoDB**: Banco de dados NoSQL totalmente gerenciado para armazenamento de dados.
- **AWS SQS**: Fila de mensagens para comunicação assíncrona entre componentes do sistema.
- **AWS S3**: Armazenamento de objetos escalável para ativos como imagens e documentos.

### Funcionalidades Principais

- **Gestão de Produtos**: Adição, remoção e atualização de produtos no catálogo.
- **Processamento Assíncrono**: Uso do AWS SQS para processamento assíncrono de pedidos e outras operações.
- **Armazenamento de Dados Durável**: Utilização do AWS DynamoDB para um armazenamento de dados altamente disponível e escalável.
- **API Serverless**: Exposição de endpoints seguros e escaláveis através do AWS API Gateway.
- **Armazenamento de Ativos**: Gerenciamento de imagens e outros ativos usando o AWS S3.

### Como Contribuir

1. Faça um fork do repositório.
2. Clone o fork localmente.
3. Implemente novas funcionalidades ou corrija problemas existentes.
4. Envie um pull request para revisão.

### Requisitos

- [AWS CLI](https://aws.amazon.com/cli/) configurado com as credenciais apropriadas.
- [Visual Studio](https://visualstudio.microsoft.com/) para desenvolvimento em .NET.

### Documentação

Para mais informações sobre como configurar, implantar e utilizar este projeto, consulte a [documentação](./docs).

### Nota

Este projeto está em constante desenvolvimento, ele esta sendo feito através de estudos em cima de cursos em .NET. Feedbacks, contribuições e melhorias são bem-vindos!

### Observação

Este projeto não esta separado em camadas, o principal objetivo é a implementação dos serviços AWS.

