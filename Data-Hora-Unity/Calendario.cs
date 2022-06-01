using System;

public class Calendario
{
    private static int dia;
    private static int mes;
    private static int ano;

    private void auxDia(int dia = 1, bool passar = true) {
        this.dia = dia;
        Mes += passar ? 1 : -1;
    }

    public static int Dia
    {
        get
        {
            return dia;
        }
        set
        {
            dia = value;

            switch (Mes)
            {
                case 1:
                    if (dia > 31)
                    {
                        auxDia();
                    }

                    if (dia < 1) {
                        auxDia(31, false);
                    }
                    break;

                case 2:
                    if (DateTime.IsLeapYear(Ano))
                    {
                        if (dia > 29)
                        {
                            auxDia();
                        }
                    } else
                    {
                        if (dia > 28)
                        {
                            auxDia();
                        }
                    }
                    
                    if (dia < 1)
                    {
                        auxDia(31, false);
                    }
                    break;

                case 3:
                    if (dia > 31)
                    {
                        auxDia();
                    }
                    
                    if (dia < 1)
                    {
                        if (DateTime.IsLeapYear(Ano))
                        {
                            auxDia(29, false);
                        }
                        else
                        {
                        auxDia(28, false);
                    }

                    break;

                /*
                default:
                    if (dia > 31)
                    {
                        dia = 1;
                        Mes++;
                    }
                    if (dia < 1) {
                        dia = 31;
                        Mes--;
                    }
                    break;

                case 2:
                    if (DateTime.IsLeapYear(Ano))
                    {
                        if (dia > 29)
                        {
                            dia = 1;
                            Mes++;
                        }
                    } else
                    {
                        if (dia > 28)
                        {
                            dia = 1;
                            Mes++;
                        }
                    }
                    break;

                case 4: case 6: case 9: case 11:
                    if (dia > 30)
                    {
                        dia = 1;
                        Mes++;
                    }
                    break;
                */
            }
        }
    }

    public static int Mes
    {
        get
        {
            if (mes <= 0) mes = 1;
            return mes;
        }
        set
        {
            mes = value;
            if (mes <= 0) mes = 1;

            if (mes > 12)
            {
                mes = 1;
                Ano++;
            }
        }
    }

    public static int Ano
    {
        get
        {
            return ano;
        }
        set
        {
            ano = value;
        }
    }

    public static string Data
    {
        get
        {
            return Dia + "-" + Mes + "-" + Ano;
        }
    }

    public static void SetData(DateTime data)
    {
        Dia = data.Day;
        Mes = data.Month;
        Ano = data.Year;
    }

    public static void SetData(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }
}
