# Projeto Sistema de Celulares - Programação Orientada a Objetos (POO)

Este é um projeto desenvolvido como desafio da **Trilha .NET da Digital Innovation One (DIO)** para fixação dos conceitos de **Programação Orientada a Objetos (POO)** com C#.  

O objetivo foi criar um sistema que abstrai o comportamento de diferentes marcas de celulares (Nokia e iPhone), utilizando **herança, abstração e polimorfismo**, com base em um diagrama fornecido no desafio.

---

## Tecnologias Utilizadas

- 🟣 **C#**
- 🟣 **.NET 9
- 🟣 **Programação Orientada a Objetos (POO)**

---

## Sobre o Projeto

O projeto consiste em:  

✅ Uma **classe abstrata `Smartphone`**, que representa a estrutura base de um celular e define métodos e propriedades comuns.  
✅ Duas **classes derivadas** (`Nokia` e `Iphone`) que herdam de `Smartphone` e implementam o método `InstalarAplicativo` com comportamentos específicos para cada marca.  
✅ Um programa principal (`Program.cs`) que instancia as classes e demonstra o uso dos métodos.  

### Estrutura das Classes:
### 📦 Smartphone (classe abstrata)

**Propriedades:**
- `Numero`
- `Modelo`
- `IMEI`
- `Memoria`

**Métodos:**
- `Ligar()`
- `ReceberLigacao()`
- `InstalarAplicativo()` _(abstrato)_

---

### 📱 Nokia : Smartphone
- Sobrescreve o método `InstalarAplicativo()` com comportamento específico para aparelhos Nokia.

### 📱 Iphone : Smartphone
- Sobrescreve o método `InstalarAplicativo()` com comportamento específico para aparelhos iPhone.

---
## Objetivos de Aprendizado
✅ Aplicar conceitos de Herança, Abstração e Polimorfismo.

✅ Trabalhar com classes abstratas e métodos sobrescritos.

✅ Criar uma aplicação console com C# e .NET.
