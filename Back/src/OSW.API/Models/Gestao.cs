namespace OSW.API.Models
{
    public class Gestao
    {
        public int EmbarqueId { get; set; }
        public string Porto { get; set; }
        public string DataEmbarque { get; set; }
        public string TipoEmbarque { get; set; }
        public int QtdTPA { get; set; }
        public string Navio { get; set; }
        public string ImagemURL { get; set; }
    }
}