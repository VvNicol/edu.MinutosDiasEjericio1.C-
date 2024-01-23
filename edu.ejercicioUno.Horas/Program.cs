namespace edu.ejercicioUno.Horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el número de minutos trabajados en un mes: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            string resultado = MinutosADiasHorasMinutos(minutos);
            Console.WriteLine(resultado);
        }

        private static string MinutosADiasHorasMinutos(int minutos)
        {
            if (minutos == 0)
            {
                return "No hay minutos.";
            }

            int dias = minutos / (8 * 60);
            int horas = (minutos % (8 * 60)) / 60;
            int minutosDelDia = minutos % 60;

            string[] partes = new string[3];
            if (dias > 0)
            {
                if (dias == 1)
                {
                    partes[0] = dias + " día";
                }
                else
                {
                    partes[0] = dias + " días";
                }
            }
            if (horas > 0)
            {
                if (horas == 1)
                {
                    partes[1] = horas + " hora";
                }
                else
                {
                    partes[1] = horas + " horas";
                }
            }
            if (minutosDelDia > 0)
            {
                if (minutosDelDia == 1)
                {
                    partes[2] = minutosDelDia + " minuto";
                }
                else
                {
                    partes[2] = minutosDelDia + " minutos";
                }
            }

            return string.Join(", ", partes);

        }
    }
}
