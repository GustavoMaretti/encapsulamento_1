# Gerenciamento de Conta Bancária

## Funcionalidades
- Criar e gerenciar uma conta bancária com as seguintes opções:
  - Registro do número da conta.
  - Definição do nome do titular.
  - Possibilidade de realizar um depósito inicial opcional.
- Realizar operações financeiras, como:
  - **Depósito**: Adicionar uma quantia ao saldo da conta.
  - **Saque**: Retirar uma quantia do saldo com cobrança de uma taxa fixa de R$ 5.00.
- Exibir os dados atualizados da conta, incluindo o saldo final.

## Uso
- O programa solicita ao usuário, via console:
  - Número da conta.
  - Nome do titular.
  - Decisão sobre a realização de depósito inicial (sim ou não).
  - Valores para depósitos e saques.
- O programa atualiza automaticamente o saldo e exibe as informações da conta no formato:
  - `Conta: Número, Titular: Nome, Saldo: R$XX.XX`.

## Tecnologias
- C#
- .NET 6.0
- Aplicação de console
