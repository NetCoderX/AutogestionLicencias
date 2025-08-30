namespace FormularioBlazor.Entities
{
    public class LicenciasPersonaACargo
    {
        public int idManager { get; set; }
        public DateTime Fecha { get; set; }
        public List<List<LicPersonaACargo>> LicenciasPersonaCargo { get; set; } = [];
        public List<LicPersonaACargoFeriados> LicenciasPersonaCargoFeriados { get; set; } = [];
    }
}
