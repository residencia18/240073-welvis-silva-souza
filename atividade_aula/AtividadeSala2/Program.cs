// Exercício 2
// Crie uma classe Data que possui dois construtores. O primeiro recebe um dia, mês e ano e o 
// segundo, além destas informações, recebe também uma hora, minuto e segundo (a hora 
// fornecida deve estar entre 0 e 23). É importante que este segundo construtor invoque o primeiro 
// para evitar a duplicação de código.
// Os construtores devem armazenar os dados fornecidos como parâmetros em fields privados. 
// Estes fields devem ter seus valores expostos para fora da classe usando read-only properties.
// A classe Data deve ter também um método Imprimir(), utilizado para imprimir a data e hora 
// representados pelo objeto. Este método recebe como parâmetro o formato de hora que deve ser 
// utilizado para imprimir as horas (12 ou 24h). Se o objeto for construído sem informação de 
// horário, este parâmetro não afeta a impressão.
// Os formatos da hora são do tipo int, mas devem ser representados por duas constantes na classe 
// Data: FORMATO_12H e FORMATO_24H.


// Data d1 = new Data(10, 03, 2000, 10, 30, 10);
// d1.imprimir(Data.FORMATO_12H);
// d1.imprimir(Data.FORMATO_24H);

// Resultado:
// 10/3/2000 10:30:10 AM
// 10/3/2000 10:30:10


// Data d2 = new Data(15, 06, 2000, 23, 15, 20);
// d2.imprimir(Data.FORMATO_12H);
// d2.imprimir(Data.FORMATO_24H);

// Resultado:
// 15/6/2000 11:15:20 PM
// 15/6/2000 23:15:20


// Data d3 = new Data(5, 10, 2005);
// d3.imprimir(Data.FORMATO_12H);
// d3.imprimir(Data.FORMATO_24H);

// Resultado:
// 5/10/2005
// 5/10/2005


public class Data
{
    private int dia;
    private int mes;
    private int ano;
    private int hora;
    private int minuto;
    private int segundo;
    private bool temHorario;

    public static readonly int FORMATO_12H = 12;
    public static readonly int FORMATO_24H = 24;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
        this.temHorario = false;
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
        this.temHorario = true;
    }

    public void Imprimir(int formatoHora)
    {
        if (temHorario)
        {
            if (formatoHora == FORMATO_12H)
            {
                string periodo = hora < 12 ? "AM" : "PM";
                int horaFormatada = hora <= 12 ? hora : hora - 12;
                Console.WriteLine($"{dia}/{mes}/{ano} {horaFormatada}:{minuto}:{segundo} {periodo}");
            }
            else if (formatoHora == FORMATO_24H)
            {
                Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}");
            }
        }
        else
        {
            Console.WriteLine($"{dia}/{mes}/{ano}");
        }
    }
}


class Program
{
    static void Main()
    {
        Data d1 = new Data(10, 03, 2000, 10, 30, 10);
        d1.Imprimir(Data.FORMATO_12H);
        d1.Imprimir(Data.FORMATO_24H);

        Data d2 = new Data(15, 06, 2000, 23, 15, 20);
        d2.Imprimir(Data.FORMATO_12H);
        d2.Imprimir(Data.FORMATO_24H);

        Data d3 = new Data(5, 10, 2005);
        d3.Imprimir(Data.FORMATO_12H);
        d3.Imprimir(Data.FORMATO_24H);
    }
}
