using System.Text.Json.Serialization;

namespace ConsumingAPIDotNetMVCBootstrap.Models
{
    public class ListaResultadoEquipeEsportiva
    {
        [JsonPropertyName("nuJogo")]
        public int NuJogo { get; set; }

        [JsonPropertyName("nuConcurso")]
        public int NuConcurso { get; set; }

        [JsonPropertyName("nuSequencial")]
        public int NuSequencial { get; set; }

        [JsonPropertyName("nomeEquipeUm")]
        public string NomeEquipeUm { get; set; }

        [JsonPropertyName("nomeEquipeDois")]
        public string NomeEquipeDois { get; set; }

        [JsonPropertyName("siglaUFUm")]
        public string SiglaUFUm { get; set; }

        [JsonPropertyName("siglaUFDois")]
        public string SiglaUFDois { get; set; }

        [JsonPropertyName("nomeCampeonato")]
        public string NomeCampeonato { get; set; }

        [JsonPropertyName("dtJogo")]
        public string DtJogo { get; set; }

        [JsonPropertyName("nuGolEquipeUm")]
        public int NuGolEquipeUm { get; set; }

        [JsonPropertyName("nuGolEquipeDois")]
        public int NuGolEquipeDois { get; set; }

        [JsonPropertyName("icSorteioResultado")]
        public int IcSorteioResultado { get; set; }

        [JsonPropertyName("siglaPaisUm")]
        public string SiglaPaisUm { get; set; }

        [JsonPropertyName("siglaPaisDois")]
        public string SiglaPaisDois { get; set; }

        [JsonPropertyName("resultado")]
        public object Resultado { get; set; }

        [JsonPropertyName("diaSemana")]
        public string DiaSemana { get; set; }
    }
}
