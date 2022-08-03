public class Order
{
    public string? Id { get; set; }
    public string? Date { get; set; } // Porque não é um DateTime? Verificar no README.md

    public DateTime Date1
    {
        get
        {
            if (Date == null)
            {
                return DateTime.MinValue;
            }
            // Essa conversão está sugeita a gerar exceção, pois não lida com datas inválidas.
            return DateTime.Parse(Date);
        }
    }

    public DateTime Date2
    {
        get
        {
            // Essa conversão entende que o formato da data é MM/dd/yyyy, portanto, não atende nossa necessidade.
            DateTime.TryParse(Date, out DateTime date);
            return date;
        }
    }

    public DateTime Date3
    {
        get
        {
            // Essa conversão ocorre com sucesso, porém, dependendo da configuração de cultura do SO, troca dia e mês ao gravar no banco de dados.
            DateTime.TryParse(Date, new CultureInfo("pt-BR"), DateTimeStyles.None, out DateTime date);
            return date;
        }
    }

    public DateTime Date4
    {
        get
        {
            // Essa conversão ocorre com sucesso, e também grava corretamente no banco de dados.
            // DateTimeStyles.AdjustToUniversal informa que queremos que o DateTime seja convertido para UniversalTime.
            DateTime.TryParseExact(Date, "dd/MM/yyyy", new CultureInfo("en-US"), DateTimeStyles.AdjustToUniversal, out DateTime date);
            return date;
        }
    }

    public DateTime Date5
    {
        get
        {
            // Essa conversão ocorre com sucesso, e também grava corretamente no banco de dados.
            // CultureInfo.InvariantCulture informa que não queremos depender do idioma do sistema operacional.
            DateTime.TryParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out DateTime date);
            return date;
        }
    }
}
