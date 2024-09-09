[url_docs_microsoft_console]: https://learn.microsoft.com/en-us/windows/console/console-reference
[url_thirtytwo]: https://github.com/thirtytwointerops
[url_author]: https://github.com/eduardobaginskicosta
[url_microsoft]: https://www.microsoft.com/en-us/startups

<!-- == == == -->

[social_instagram]: https://instagram.com/eduardobcosta7/
[social_linkedin]: https://linkedin.com/in/eduardobaginskicosta/
[social_twitter]: https://twitter.com/eduardobcosta7/

<!-- == == == -->

<h1 align="center">Kernel32 • Documentação</h1>

**[Retornar à Página Inicial](../README.md)
&emsp;|&emsp;[PT-BR](./pt-br/README.md)
&ensp;•&ensp;[EN-US](./en-us/README.md)**

> [!NOTE]
>
> **Todas as informações foram retiradas diretamente da documentação oficial da Microsoft e adaptadas para o ambiente .NET Framework (C#). Todos os direitos reservados à Microsoft.**

Especifica um caractere Unicode ou ANSI e seus atributos. Essa estrutura é usada por funções de console para ler e gravar em um buffer de tela de console.

**Estrutura Original • Documentação da Microsoft**

```cpp
typedef struct _CHAR_INFO {
  union {
    WCHAR UnicodeChar;
    CHAR  AsciiChar;
  } Char;
  WORD  Attributes;
} CHAR_INFO, *PCHAR_INFO;
```

<p align="center">
  Código fonte da estrutura: 
  <b><a href="https://learn.microsoft.com/en-us/windows/console/char-info-str">CHAR_INFO</a></b>
</p>

**Estrutura Adaptada • ThirtyTwo Interops • Kernel32**

```csharp
public struct CharacterInformation
{
  public char UnicodeChar;
  public char AsciiChar;
  public CharacterAttributes Attributes;
}
```

<p align="center">
  Código fonte da estrutura: 
  <b><a href="https://github.com/thirtytwointerops/kernel32/blob/main/Source/Structures/CharacterInformation.cs">CharacterInformation.cs</a></b>
</p>

**`UnicodeChar`**  
Caractere Unicode de uma célula de caractere de
buffer de tela.

**`AsciiChar`**  
Caractere ANSI de uma célula de caractere de buffer
de tela.

**`Attributes`**  
Os atributos do caractere. Este membro pode ser zero
ou qualquer combinação dos valores da enumeração
[CharacterAttributes](https://github.com/thirtytwointerops/kernel32/blob/main/Source/Enumerations/CharacterAttributes.cs).

| Nome                    | Valor    | Descrição                                              |
| ----------------------- | -------- | ------------------------------------------------------ |
| ForegroundBlue          | `0x0001` | A cor do texto contém azul.                            |
| ForegroundGreen         | `0x0002` | A cor do texto contém verde.                           |
| ForegroundRed           | `0x0004` | A cor do texto contém vermelho.                        |
| ForegroundIntensity     | `0x0008` | A cor do texto é intensificada.                        |
| BackgroundBlue          | `0x0010` | A cor de fundo contém azul.                            |
| BackgroundGreen         | `0x0020` | A cor de fundo contém verde.                           |
| BackgroundRed           | `0x0040` | A cor de fundo contém vermelho.                        |
| BackgroundIntensity     | `0x0080` | A cor do fundo é intensificada.                        |
| CommonLVBLeadingByte    | `0x0100` | Byte inicial.                                          |
| CommonLVBTrailingByte   | `0x0200` | Byte à direita.                                        |
| CommonGridHorizontal    | `0x0400` | Horizontal superior.                                   |
| CommonGridLeftVertical  | `0x0800` | Vertical esquerdo.                                     |
| CommonGridRightVertical | `0x1000` | Vertical direito.                                      |
| CommonLVBReverseVideo   | `0x4000` | Atributo de primeiro plano e plano de fundo invertido. |
| CommonLVBUnderscore     | `0x8000` | Enfatizar.                                             |

<!-- == == == -->

---

**Agora parte da [Microsoft for Startups Founders Hub][url_microsoft]**  
**Mantido por [@eduardobaginskicosta][url_author]&emsp;|&emsp;[X][social_twitter]&ensp;•&ensp;[LinkedIn][social_linkedin]&ensp;•&ensp;[Instagram][social_instagram]**
