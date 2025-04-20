# Trabalho de Concessionaria

- Feito para a aula de Luciano Coelho
- Sistema basica(Nao esta muito complexo pelo fato que so fiz o assencial que ele pediu)
- Contem os 4 fundamentos de POO
- Contem CRUD completo

---
# Classes
### Classes Bases
- Veiculo
- Revenda
- Menu
- Program
### Classes Intermediarias
- DePassageiro
- DeCarga
- DeMisto
### Classes Filhas
- Automovel
- Bicicleta
- Motocicleta
- Caminhonete
- Caminhao
- Utilitario

---
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

---
## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./.../bin/Release/net8.0/` e execute o arquivo:
   
```
Calculdora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
