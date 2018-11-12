# .net-core-test-container-swarm
Teste de aplicação .net core em containers. Utilizando o docker, swarm, k8s, para criar várias instâncias incluindo integração com AWS IOT.

### Configuração

Para configurar a integração com o AWS IOT visite primeito o link abaixo para mais instruções sobre como configurar:

- [AWS Samples IOT .Net](https://github.com/aws-samples/iot-dotnet-publisher-consumer)

### Projetos
- consumer-aws-iot: Aplicação de console que irá consumir itens da fila MQTT disponibilizada na AWS IOT
- simular-aws-iot: Aplicação de console quer irá publicar itens na fila do MQTT para que outras aplicações possam consumir
- unitTest: Teste unitário da aplicação web, incluindo as classes de teste de monitoramento de pressão
- exercicio-3: Exercicio 3 do curso de pós graduação

### Execucação

Este projeto foi desenvolvido utilizando .NET CORE, portanto para executar basta executar os comandos abaixos nos respectivos dieretório.

Para visualizar a integração é necessário executar o projeto `simulador-aws-iot` e `consumer-aws-iot`, ambos estão uitlizando a mesma fila no MQTT para consumir e enviar dados, no mesmo tópico.

Primeiramente restauramos as dependências do projeto:

>Navegue nos diretórios `simulador-aws-iot` e `consumer-aws-iot` e execute os comandos abaixos:

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