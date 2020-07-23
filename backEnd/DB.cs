using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace backEnd
{
    public class DB
    {
        public static IEnumerable<Evento> LerEventoDoArquivo()
        {
            var conteudoArquivo = System.IO.File.ReadAllText("data.json");

            var lista = JsonSerializer.Deserialize<IEnumerable<Evento>>(conteudoArquivo);

            return lista;
        }
        public static void SalvarArquivoNovo(IEnumerable<Evento> novaLista)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(novaLista);
            System.IO.File.WriteAllText("data.json", json);
        }




    }
}
