# .net-core-test-container-swarm
Teste de aplicação .net core em containers e utilizando o swarm para criar várias instâncias incluindo integração com AWS IOT

### Configuração

Para configurar o projeto correntamente visite primeito o link abaixo para mais instruções sobre como configurar o awsiot:

- [AWS Samples IOT .Net](https://github.com/aws-samples/iot-dotnet-publisher-consumer)

### Projetos
- consumer-aws-iot: Aplicação de console que irá consumir itens da fila MQTT disponibilizada na AWS IOT
- simular-aws-iot: Aplicação de console quer irá publicar itens na fila do MQTT para que outras aplicações possam consumir
- unitTest: Teste unitário da aplicação web, incluindo as classes de teste de monitoramento de pressão
- exercicio-3: Exercicio 3 do curso de pós graduação

### Execucação

Este projeto foi desenvolvido utilizando .NET CORE, portanto para executar basta executar os comandos abaixos nos respectivos dieretório:

Primeiramente restauramos as dependências do projeto:
```
dotnet restore
```
Realizamos o build do projeto para verificar se o projeto está gerando o executável corretamente:
```
dotnet build
```
Iniciamos a execução do projeto:
```
dotnet run
```