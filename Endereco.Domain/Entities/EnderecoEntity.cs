namespace Endereco.Domain.Entities
{
    public class EnderecoEntity : BaseEntity
    {
        public EnderecoEntity(string cep,
                              string logradouro,
                              string unidadeFederacao,
                              int numeroLogradouro,
                              string bairro)
        {
            Cep = cep;
            Logradouro = logradouro;
            UnidadeFederacao = unidadeFederacao;
            NumeroLogradouro = numeroLogradouro;
            Bairro = bairro;
        }

        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string UnidadeFederacao { get; private set; }
        public int NumeroLogradouro { get; private set; }
        public string Bairro { get; private set; }
        public bool IsValid => Validate();
        public bool IsFreteGratis => IsElegivelFreteGratis();

        private bool Validate()
        {
            return
                Cep.Length is 9;
        }
        private bool IsElegivelFreteGratis()
        {
            return
                UnidadeFederacao.Normalize() is "SP"
                ||
                UnidadeFederacao.Normalize() is "MG";
        }
    }
}