Aqui está o README atualizado com as instruções para configurar e rodar os testes usando .NET:

---

# Descrição dos Testes

Este repositório contém três testes diferentes que abordam a contagem de funcionários por departamento, a elegibilidade de bônus baseado em avaliações de desempenho, e o cálculo da folha de pagamento de uma empresa. Abaixo estão as descrições de cada um dos testes, juntamente com as instruções para rodá-los utilizando .NET.

## Teste 1: Contagem de Funcionários por Departamento

### Descrição
Você precisa desenvolver um sistema que conte o número de funcionários em cada departamento. Dada uma lista que representa o departamento de cada funcionário, seu objetivo é calcular a quantidade de funcionários em cada departamento e apresentar esse número.

### Entrada
A entrada é uma string onde cada valor, separado por vírgulas, representa o nome do departamento ao qual um funcionário pertence.

### Saída
Deverá retornar os nomes dos departamentos em ordem alfabética seguidos pela contagem de funcionários em cada departamento, um por linha.

### Exemplos

| Entrada                       | Saída                              |
| ----------------------------- | ---------------------------------- |
| `TI,RH,TI,Financeiro`          | Financeiro: 1<br>RH: 1<br>TI: 2   |
| `Financeiro,RH,RH,TI`          | Financeiro: 1<br>RH: 2<br>TI: 1   |
| `TI,TI,TI,RH,Financeiro,RH`    | Financeiro: 1<br>RH: 2<br>TI: 3   |

## Teste 2: Avaliação de Desempenho

### Descrição
Uma empresa realiza uma avaliação anual de desempenho de seus funcionários, utilizando três critérios principais: produtividade, qualidade do trabalho e pontualidade. Cada critério recebe uma nota que varia de 0 a 10. O objetivo do sistema é calcular a média das notas e determinar se o funcionário é elegível para receber um bônus anual.

Para ser elegível ao bônus, o funcionário precisa obter uma média igual ou superior a 7,0.

### Entrada
Você receberá uma string contendo três valores inteiros separados por vírgula (,). Esses valores representam as notas atribuídas a cada critério, na seguinte ordem:
- Produtividade
- Qualidade do Trabalho
- Pontualidade

### Saída
O programa deve imprimir duas linhas:
1. A primeira linha deve mostrar a média das três notas, formatada com duas casas decimais.
2. A segunda linha deve informar se o funcionário é elegível para o bônus, exibindo `Sim` ou `Nao`.

### Exemplos

| Entrada   | Saída                                   |
| --------- | --------------------------------------- |
| `8,7,9`   | Media: 8.00<br>Elegível para bônus: Sim |
| `6,5,7`   | Media: 6.00<br>Elegível para bônus: Nao |
| `10,9,8`  | Media: 9.00<br>Elegível para bônus: Sim |

## Teste 3: Cálculo da Folha de Pagamento

### Descrição
Você foi contratado para desenvolver uma aplicação que automatize o cálculo da folha de pagamento de uma empresa. A aplicação deve considerar o salário base do funcionário, as horas extras trabalhadas e descontos, como imposto de renda e contribuição previdenciária. O objetivo é calcular o salário líquido de cada funcionário ao final do mês.

Para o cálculo considere a fórmula:

**Salário Líquido = Salário Base + (Horas Extras Trabalhadas * Valor por Hora Extra) - Desconto de Imposto de Renda - Desconto de Contribuição Previdenciária**

### Entrada
A entrada é uma string representando uma lista com cinco valores numéricos separados por vírgula (,), na seguinte ordem:
1. Salário base (um valor decimal que representa o salário fixo do funcionário).
2. Horas extras trabalhadas (um valor inteiro que indica o número de horas extras realizadas pelo funcionário).
3. Valor por hora extra (um valor decimal que representa quanto o funcionário ganha por hora extra trabalhada).
4. Desconto de imposto de renda (um valor decimal que representa o valor do imposto a ser descontado do salário).
5. Desconto de contribuição previdenciária (um valor decimal que representa a contribuição previdenciária a ser descontada).

### Saída
A saída deverá retornar o salário líquido do funcionário com duas casas decimais.

### Exemplos

| Entrada                            | Saída   |
| ---------------------------------- | ------- |
| `2500, 0, 50, 250, 150`            | 2100.00 |
| `4000, 8, 40, 400, 300`            | 3620.00 |
| `4500, 5, 60, 450, 350`            | 4000.00 |

---

## Configuração para Rodar os Testes com .NET

### Pré-requisitos
- .NET SDK instalado (recomendado .NET 6 ou superior).

### Passo a Passo para Rodar os Testes

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. **Crie um novo projeto de console** (se ainda não existir):
   ```bash
   dotnet new console -n ContagemFuncionarios
   cd ContagemFuncionarios
   ```

3. **Adicione o código dos testes**:
   - Adicione os arquivos de código com as implementações dos testes descritos acima no diretório `ContagemFuncionarios`.

4. **Execute os testes**:
   - Para rodar o projeto de console:
     ```bash
     dotnet run
     ```

5. **Testes Automáticos**:
   - Caso você queira incluir testes automáticos, crie um projeto de testes:
     ```bash
     dotnet new xunit -n ContagemFuncionarios.Tests
     cd ContagemFuncionarios.Tests
     dotnet add reference ../ContagemFuncionarios/ContagemFuncionarios.csproj
     ```
   - Adicione testes unitários para cada uma das funcionalidades descritas.
   - Execute os testes:
     ```bash
     dotnet test
     ```

### Dicas
- Certifique-se de que os métodos estão corretamente implementados para lidar com diferentes cenários de entrada.
- Use testes unitários para verificar se todos os casos de uso estão cobertos.

---

Este README fornece um guia completo para entender, configurar e executar os testes relacionados à contagem de funcionários, avaliação de desempenho e cálculo da folha de pagamento utilizando .NET.
