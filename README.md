# Data e Hora para Unity

Um sistema simples de controle e manipulação de data e hora para Unity.

## Como usar

Copie e cole os scripts *Calendario.cs* e *Relogio.cs* ou importe o arquivo *DataHora.package* para o projeto Unity.

### Calendario.cs

>Utilize os métodos SetData() para definir o valor das propriedades Dia, Mes e Ano antes de utilizá-las. Evite atribuir valor diretamente a elas, prefira incrementá-las ou decrementá-las.
>
>![Calendario.SetData(DateTime)](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/00calendario-awake.jpg)
>
>Para usar uma data com o valor de Ano menor ou igual a zero é necessário usar o método *SetData(int, int, int)*.
>
>![Calendario.SetData(int, int, int)](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/01calendario-awake.jpg)

### Relogio.cs

>Pode ser usado sem o Calendario apagando as linhas 72 e 82 e os 2 métodos *SetDataHora*.
>
>![Relogio sem Calendario](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/02relogio-calendario.jpg)
>
>O método *Rodar()* deve ser colocado em um *FixedUpdate()*
>
![Relogio.FixedUpdate()](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/03relogio-update.jpg)

### DataHora.package

>Abra a cena *DataHora*.
>
>![Project->Assets->Scenes->DataHora.unity](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/04demo-scenes.jpg)
>
>Selecione o prefab *DataHoraDemo*
>
>![Hierarchy->DataHoraDemo](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/05demo-hierarchy.jpg)
>
>No Inspector você pode escolher data, hora e escala iniciais. Quando escala = 0, o relógio fica parado; escala = 1, velocidade do relógio igual a real.
>
>![Inspector->Demo(Script)](https://github.com/GabrielMendesMelo/DataHora-Unity/blob/main/img/06demo-inspector.jpg)
