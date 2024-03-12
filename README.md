# Programa de Análise de Faturamento Mensal por Estado

Este é um programa em C# que calcula o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora, com base nos dados fornecidos em um arquivo JSON.

## Requisitos

- .NET Core SDK 3.1 ou superior
- Um arquivo JSON contendo os dados de faturamento mensal por estado

## Utilização

1. Certifique-se de ter o .NET Core SDK instalado em seu sistema.
2. Clone este repositório ou faça o download dos arquivos.
3. Adicione o arquivo JSON contendo os dados de faturamento mensal por estado no diretório do projeto, com o nome `faturamento.json`.
4. Abra um terminal na pasta do projeto e execute o comando `dotnet run`.
5. O programa exibirá o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

## Formato do Arquivo JSON

O arquivo JSON deve ter a seguinte estrutura:

```json
{
  "SP": 67836.43,
  "RJ": 36678.66,
  "MG": 29229.88,
  "ES": 27165.48,
  "Outros": 19849.53
}
```
Neste exemplo, cada chave representa o estado e o valor associado representa o faturamento mensal desse estado.
