using System.ComponentModel.DataAnnotations;
namespace NFSC.Models
    
{
   public class RegistroMestre
    {
        /// Legenda onde vê-se X lê-se letras,onde vê-se N lê-se Números
        /// <summary>
        /// Campo 01 CPFCGC Tamanho 14  Posição I=1,F=14 Formato N 
        /// </summary>
        [StringLength(14)]
        public string CPFouCNPJ { get; set; }
        /// <summary>
        /// Campo 02 IE Tamanho 14 Posição I=15,F28 Formato X 
        /// </summary>
        public string IE { get; set; }
        /// <summary>
        /// Campo 03 IE Tamanho 35 Posição I=29,F63 Formato X
        /// </summary>
        public string RazaoSocial { get; set; }
        /// <summary>
        /// Campo 04 IE Tamanho 2 Posição I=64,F65 Formato X 
        /// </summary>
        public string UF { get; set; }
        /// <summary>
        /// Campo 05 ClasseConsummo Tamanho 1 Posição I=66,F66 Formato N 
        /// </summary>
        public string ClasseConsummo { get; set; }
        /// <summary>
        /// Campo 06 FaseOuTipoUltilizacao Tamanho 1 Posição I=67,F67 Formato N 
        /// </summary>
        public string FaseOuTipoUltilizacao { get; set; }
        /// <summary>
        /// Campo 07 GrupoDeTensao Tamanho 2 Posição I=68,F69 Formato N 
        /// </summary>
        public string GrupoDeTensao { get; set; }
        /// <summary>
        /// Campo 08 CodigoIdentificacaoConsumidor Tamanho 12 Posição I=70,F=81 Formato X
        /// </summary>
        public string CodigoIdentificacaoConsumidor { get; set; }
        /// <summary>
        /// Campo 09 DataEmissao Tamanho 8 Posição I=82,F=89 Formato N 
        /// </summary>
        public string DataEmissao { get; set; }
        /// <summary>
        /// Campo 10 Modelo Tamanho 2 Posição I=90,F=91 Formato N 
        /// </summary>
        public string Modelo { get; set; }
        /// <summary>
        /// Campo 11 Serie Tamanho 3 Posição I=92,F=94 Formato X 
        /// </summary>
        public string Serie { get; set; }
        /// <summary>
        /// Campo 12 Numero Tamanho 9 Posição I=95,F=103 Formato N 
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Campo 13 AutenticacaoDigital Tamanho 32 Posição I=104,F=135 Formato X 
        /// </summary>
        public string AutenticacaoDigital { get; set; }
        /// <summary>
        /// Campo 14 ValorTotal Tamanho 12 Posição I=136,F=147 Formato N  com 2 Casas Decimais 
        /// </summary>
        public string ValorTotal  { get; set; }
        /// <summary>
        /// Campo 15 BCICMS Tamanho 12 Posição I=148,F=159 Formato N  com 2 Casas Decimais 
        /// </summary>
        public string BCICMS { get; set; }
        /// <summary>
        /// Campo 16 ICMS Tamanho 12 Posição I=160,F=171 Formato N  com 2 Casas Decimais 
        /// </summary>
        public string ICMS { get; set; }
        /// <summary>
        /// Campo 17 IsentoNaoTributado Tamanho 12 Posição I=172,F=183 Formato N  com 2 Casas Decimais 
        /// </summary>
        public string IsentoNaoTributado  { get; set; }
        /// <summary>
        /// Campo 18 Outros Tamanho 12 Posição I=184,F=195 Formato N  com 2 Casas Decimais 
        /// </summary>
        public string Outros { get; set; }
        /// <summary>
        /// Campo 19 SituacaoDocumento Tamanho 1 Posição I=196,F=196 Formato X 
        /// </summary>
        public string SituacaoDocumento { get; set; }
        /// <summary>
        /// Campo 20 AnoMesRefApuracao Tamanho 4 Posição I=197,F=200 Formato N 
        /// </summary>
        public string AnoMesRefApuracao { get; set; }
        /// <summary>
        /// Campo 21 ReferenciaAoItemNF Tamanho 9 Posição I=201,F=209 Formato N 
        /// </summary>
        public string ReferenciaAoItemNF { get; set; }
        /// <summary>
        /// Campo 22 NumeroTerminalTeleOuUnidadeConsumidora Tamanho 12 Posição I=210,F=221 Formato X 
        /// </summary>
        public string NumeroTerminalTeleOuUnidadeConsumidora { get; set; }
        /// <summary>
        /// Campo 23 IndicacaoDoTipodeInformacaoCampo1 Tamanho 1 Posição I=222,F=222 Formato N 
        /// </summary>
        public string IndicacaoDoTipodeInformacaoCampo1 { get; set; }
        /// <summary>
        /// Campo 24 TipoCliente Tamanho 2 Posição I=223,F=224 Formato N 
        /// </summary>
        public string TipoCliente { get; set; }
        /// <summary>
        /// Campo 25 SubClasseConsumo Tamanho 2 Posição I=225,F=226 Formato N 
        /// </summary>
        public string SubClasseConsumo { get; set; }
        /// <summary>
        /// Campo 26 NumeroTerminalTelefonicoPrincipal Tamanho 12 Posição I=227,F=238 Formato X 
        /// </summary>
        public string NumeroTerminalTelefonicoPrincipal { get; set; }
        /// <summary>
        /// Campo 27 CNPJEmitente Tamanho 14 Posição I=239,F=252 Formato N 
        /// </summary>
        public string CNPJEmitente { get; set; }
        /// <summary>
        /// Campo 28 CodigoFaturaComercial Tamanho 20 Posição I=253,F=272 Formato X 
        /// </summary>
        public string  CodigoFaturaComercial { get; set; }
        /// <summary>
        /// Campo 29 ValorTotalFatura Tamanho 12 Posição I=273,F=284 Formato N 
        /// </summary>
        public string ValorTotalFatura { get; set; }
        /// <summary>
        /// Campo 30 DataLeituraAnterior Tamanho 8 Posição I=285,F=292 Formato N 
        /// </summary>
        public string DataLeituraAnterior { get; set; }
        /// <summary>
        /// Campo 31 DataLeituraAtual Tamanho 8 Posição I=293,F=300 Formato N 
        /// </summary>
        public string DataLeituraAtual { get; set; }
        /// <summary>
        /// Campo 32 Brancos Tamanho 50 Posição I=301,F=350 Formato X
        /// </summary>
        public string Brancos  { get; set; }
        
        /// <summary>
        /// Campo 33 Brancos1 Tamanho 8 Posição I=351,F=358 Formato N
        /// </summary>
        public string Brancos1 { get; set; }
        /// <summary>
        /// Campo 34 InformacaoesAdiciaionais Tamanho 30 Posição I=359,F=388 Formato X
        /// </summary>
        public string InformacaoesAdiciaionais { get; set; }
        /// <summary>
        /// Campo 35 Brancos2 Tamanho 5 Posição I=389,F=393 Formato X
        /// </summary>
        public string Brancos2  { get; set; }
        /// <summary>
        /// Campo 36 CodigoAutenticacaoDigitalReg Tamanho 32 Posição I=394,F=425 Formato X
        /// </summary>
        public string CodigoAutenticacaoDigitalReg { get; set; }
    }
}
