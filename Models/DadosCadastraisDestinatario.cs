namespace NFSC.Models
{
  public class DadosCadastraisDestinatario
    {
        /// Legenda onde vê-se X lê-se letras,onde vê-se N lê-se Números
        /// <summary>
        /// Campo 01 CPFCNPJ Tamanho 14  Posição I=1,F=14 Formato N 
        /// </summary>
        public string CPFCNPJ { get; set; }
        /// <summary>
        /// Campo 02 IE Tamanho 14  Posição I=15,F=28 Formato X 
        /// </summary>
        public string IE { get; set; }
        /// <summary>
        /// Campo 03 RazaoSocial Tamanho 35  Posição I=29,F=63 Formato X 
        /// </summary>
        public string RazaoSocial { get; set; }
        /// <summary>
        /// Campo 04 Logradouro Tamanho 45  Posição I=64,F=108 Formato X 
        /// </summary>
        public string Logradouro { get; set; }
        /// <summary>
        /// Campo 05 Numero Tamanho 5  Posição I=109,F=113 Formato N 
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Campo 06 Complemento Tamanho 15  Posição I=114,F=128 Formato X
        /// </summary>
        public string Complemento { get; set; }
        /// <summary>
        /// Campo 07 CEP, Tamanho 8  Posição I=129,F=136 Formato N 
        /// </summary>
        public string CEP { get; set; }
        /// <summary>
        /// Campo 08 Bairro, Tamanho 15  Posição I=137,F=151 Formato X 
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Campo 09 Municipio, Tamanho 30  Posição I=152,F=181 Formato X 
        /// </summary>
        public string Municipio { get; set; }
        /// <summary>
        /// Campo 10 UF, Tamanho 2  Posição I=182,F=183 Formato X 
        /// </summary>
        public string UF { get; set; }
        /// <summary>
        /// Campo 11 TelefoneContato, Tamanho 12  Posição I=184,F=195 Formato X 
        /// </summary>
        public string TelefoneContato { get; set; }
        /// <summary>
        /// Campo 12 CodigoIdentificacao, Tamanho 12  Posição I=196,F=207 Formato X 
        /// </summary>
        public string CodigoIdentificacao { get; set; }
        /// <summary>
        /// Campo 13 CodigoUnidadeConsumidora, Tamanho 12  Posição I=208,F=219 Formato X 
        /// </summary>
        public string CodigoUnidadeConsumidora { get; set; }
        /// <summary>
        /// Campo 14 UFHabilitacaoTerminalTelefonico, Tamanho 2  Posição I=220,F=221 Formato X 
        /// </summary>
        public string UFHabilitacaoTerminalTelefonico { get; set; }
        /// <summary>
        /// Campo 15 DataEmissao, Tamanho 8  Posição I=222,F=229 Formato N 
        /// </summary>
        public string DataEmissao { get; set; }
        /// <summary>
        /// Campo 16 Modelo, Tamanho 2  Posição I=230,F=231 Formato N 
        /// </summary>
        public string Modelo    { get; set; }
        /// <summary>
        /// Campo 17 Serie, Tamanho 3  Posição I=232,F=234 Formato X 
        /// </summary>
        public string Serie { get; set; }
        /// <summary>
        /// Campo 18 Numero1, Tamanho 9  Posição I=235,F=243 Formato N
        /// </summary>
        public string Numero1 { get; set; }
        /// <summary>
        /// Campo 19 CodigoMunicipio, Tamanho 7  Posição I=244,F=250 Formato N
        /// </summary>
        public string CodigoMunicipio { get; set; }
        /// <summary>
        /// Campo 20 Brancos, Tamanho 5  Posição I=251,F=255 Formato X
        /// </summary>
        public string Brancos { get; set; }
        /// <summary>
        /// Campo 21 CodigoAutenticacoDigital, Tamanho 32  Posição I=256,F=287 Formato X
        /// </summary>
        public string CodigoAutenticacoDigital { get; set; }
    }
}
