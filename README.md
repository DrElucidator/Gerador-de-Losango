```markdown
# Gerador de Losango em C#

Um programa simples em **C#** que desenha um losango no console utilizando o caractere **"X"**.  
O tamanho do losango é definido pelo usuário, que deve fornecer um número **ímpar**.

---

## Índice
- [Descrição](#-descrição)
- [Funcionalidades](#-funcionalidades)
- [Como Usar](#-como-usar)
- [Exemplo de Execução](#-exemplo-de-execução)
- [Requisitos](#-requisitos)
- [Execução](#-execução)

---

## Descrição
Este projeto solicita ao usuário um número ímpar e, a partir dele, gera um **losango proporcional** utilizando o caractere `"X"`.  
O programa valida a entrada e só aceita números ímpares, garantindo que o losango seja simétrico.

---

## Funcionalidades
- Solicita ao usuário um número ímpar.
- Valida a entrada (não permite números pares).
- Gera um losango proporcional ao número fornecido.
- Exibe o losango diretamente no console.

---

## Como Usar
1. Execute o programa.
2. Digite um número ímpar quando solicitado.
3. O programa desenhará um losango com base no número informado.

---

## Exemplo de Execução
Entrada:
```
Digite um número ímpar para gerar um losango do tamanho correspondente:
5
```

Saída:
```
        X
      X X X
    X X X X X
      X X X
        X
```

---

## Requisitos
- .NET SDK (versão 6.0 ou superior recomendada).
- Sistema operacional compatível (Windows, Linux ou macOS).

---

## Execução
1. Clone este repositório:
   ```bash
   git clone https://github.com/seuusuario/Gerador-de-Losango.git
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd gerador-de-losango
   ```
3. Compile e execute:
   ```bash
   dotnet run
   ```