using UnityEngine;
using System;
using System.Text;

public static class Relogio
{
    private static float totalSegundos;

    public static int Hora { get; private set; }
    public static int Minuto { get; private set; }
    public static int Segundo { get; private set; }

    private static float velMult = 1;

    public static float intervaloSegundo;

    private static string TempoFormatado(int t)
    {
        return t < 10 ? "0" + t : t.ToString();
    }

    public static string Horario (bool hora = true, bool min = true, bool seg = true)
    {
        string h;
        string m;
        string s;
        StringBuilder sb = new StringBuilder();

        if (hora)
        {
            h = TempoFormatado(Hora);
            sb.Append(h);
        }
        if (min)
        {
            if (hora)
            {
                sb.Append(":");
            }
            m = TempoFormatado(Minuto);
            sb.Append(m);
        }
        if (seg)
        {
            if (min)
            {
                sb.Append(":");
            }
            s = TempoFormatado(Segundo);
            sb.Append(s);
        }

        string horario = sb.ToString();

        return string.IsNullOrEmpty(horario) ? "00:00:00" : horario;
    }
    
    public static void Rodar()
    {
        totalSegundos += Time.deltaTime * velMult;
        intervaloSegundo = Time.deltaTime * velMult;
        
        Segundo = (int) totalSegundos;
        Minuto = Segundo / 60;
        Hora = Minuto / 60;

        if (Segundo >= 60) Segundo -= Minuto * 60;
        if (Minuto >= 60) Minuto -= Hora * 60;
        if (Hora >= 24)
        {
            totalSegundos = 0;
            Calendario.Dia++;
        }
    }

    public static void VariarVelocidade(float n, Operacao operacao = Operacao.SUBSTITUIR)
    {
        switch (operacao)
        {
            case Operacao.SOMA:
                velMult += n;
                break;

            case Operacao.SUBTRACAO:
                velMult -= n;
                break;

            case Operacao.MULTIPLICACAO:
                velMult *= n;
                break;

            case Operacao.DIVISAO:
                velMult /= n;
                break;

            default:
                velMult = n;
                break;
        }

        if (velMult <= 0) velMult = 0;
    }

    public static void SetHora(DateTime data)
    {
        int h = data.Hour;
        int m = data.Minute;
        int s = data.Second;

        totalSegundos = s + m * 60 + h * 60 * 60;
    }
    
    public static void SetHora(int hora, int min, int seg)
    {
        int h = hora;
        int m = min;
        int s= seg;

        totalSegundos = s + m * 60 + h * 60 * 60;
    }
    
    public enum Operacao
    {
        SOMA,
        SUBTRACAO,
        MULTIPLICACAO,
        DIVISAO,
        SUBSTITUIR
    }
}
