namespace NFSC.Models
{
  public  class Item
    {
        /// Legenda onde vê-se X lê-se letras,onde vê-se N lê-se Números
        /// <summary>
        ///  Campo 1, CPFCNPJ, Tamanho =14,Pos.I = 1,Pos.F=14,Formato= N
        /// </summary>
        public string CPFCNPJ { get; set; }

        /// <summary>
        ///  Campo 2, UF, Tamanho =2,Pos.I = 15,Pos.F=16,Formato= X
        /// </summary>       
        public string UF { get; set; }
        /// <summary>
        ///  Campo 3, ClasseConsumo, Tamanho =1,Pos.I = 17,Pos.F=17,Formato= N
        /// </summary>      
        public string ClasseConsumo { get; set; }
        /// <summary>
        ///  Campo 4, TipoUltilizacao, Tamanho =1,Pos.I = 18,Pos.F=18,Formato= N
        /// </summary>
        
        public string TipoUltilizacao { get; set; }
        /// <summary>
        ///  Campo 5, GrupoTensao, Tamanho =2,Pos.I = 19,Pos.F=20,Formato= N
        /// </summary>
        public string GrupoTensao  { get; set; }
        /// <summary>
        ///  Campo 6, DataEmissao, Tamanho =8,Pos.I = 21,Pos.F=28,Formato= N
        /// </summary>
        
        public string  DataEmissao { get; set; }
        /// <summary>
        ///  Campo 7, Modelo, Tamanho =2,Pos.I = 29,Pos.F=30,Formato= N
        /// </summary>
        
        public string Modelo { get; set; }
        /// <summary>
        ///  Campo 8, Serie, Tamanho =3,Pos.I = 31,Pos.F=33,Formato= X
        /// </summary>

        public string Serie { get; set; }
        /// <summary>
        ///  Campo 9, Numero, Tamanho =9,Pos.I = 34,Pos.F=42,Formato= N
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        ///  Campo 10, CFOP, Tamanho =4,Pos.I = 43,Pos.F=46,Formato= N
        /// </summary>

        public string CFOP { get; set; }
        /// <summary>
        ///  Campo 11, NroOrdemItem, Tamanho =3,Pos.I = 47,Pos.F=49,Formato= N
        /// </summary>        
        public string NroOrdemItem { get; set; }
        /// <summary>
        ///  Campo 12, CodigoItem, Tamanho =10,Pos.I = 50,Pos.F=59,Formato= X
        /// </summary>        
        public string CodigoItem { get; set; }
        /// <summary>
        ///  Campo 13, DescricaoItems, Tamanho =40,Pos.I = 60,Pos.F=99,Formato= N
        /// </summary>
        public string DescricaoItems { get; set; }
        /// <summary>
        ///  Campo 14, CodigoClassificacaoItem, Tamanho =4,Pos.I = 100,Pos.F=103,Formato= N
        /// </summary>
        public string CodigoClassificacaoItem { get; set; }
        /// <summary>
        ///  Campo 15, Unidade, Tamanho =6,Pos.I = 104,Pos.F=109,Formato= X
        /// </summary>
        public string Unidade { get; set; }
        /// <summary>
        ///  Campo 16, QuantidadeContratada, Tamanho =12,Pos.I = 110,Pos.F=121,Formato= N,Com 3 CasasDecimais
        /// </summary>
        public string  QuantidadeContratada { get; set; }
        /// <summary>
        ///  Campo 17, QuantidadeMedida, Tamanho =12,Pos.I = 122,Pos.F=133,Formato= N,Com 3 CasasDecimais
        /// </summary>
        public string QuantidadeMedida  { get; set; }
        /// <summary>
        ///  Campo 18, Total, Tamanho =11,Pos.I = 134,Pos.F=144,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string Total { get; set; }
        /// <summary>
        ///  Campo 19, DescontosRedutores, Tamanho =11,Pos.I = 145,Pos.F=155,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string DescontosRedutores { get; set; }
        /// <summary>
        ///  Campo 20, AcrescimosDespesasAcessorias, Tamanho =11,Pos.I = 156,Pos.F=166,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string AcrescimosDespesasAcessorias { get; set; }
        /// <summary>
        ///  Campo 21, BaseICMS= Valor da base, Tamanho =11,Pos.I = 167,Pos.F=177,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string BaseICMS { get; set; }
        /// <summary>
        ///  Campo 22, ICMS= Valor do Icms, Tamanho =11,Pos.I = 178,Pos.F=188,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string ICMS { get; set; }
        /// <summary>
        ///  Campo 23, IsentoNaoTributado, Tamanho =11,Pos.I = 189,Pos.F=199,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string IsentoNaoTributado { get; set; }
        /// <summary>
        ///  Campo 24, OutrosValores, Tamanho =11,Pos.I = 200,Pos.F=210,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string OutrosValores { get; set; }
        /// <summary>
        ///  Campo 25, AliquotaICMS, Tamanho =4,Pos.I = 211,Pos.F=214,Formato= N,Com 2 Casas Decimais
        /// </summary>
        public string AliquotaICMS { get; set; }
        /// <summary>
        ///  Campo 26,Situacao, Tamanho =1,Pos.I = 215,Pos.F=215,Formato= X
        /// </summary>
        public string  Situacao { get; set; }
        /// <summary>
        ///  Campo 27,AnoMesRefenciaApuracao, Tamanho =4,Pos.I = 216,Pos.F=219,Formato= X
        /// </summary>
        public string AnoMesRefenciaApuracao { get; set; }
        /// <summary>
        ///  Campo 28,NumeroContrato, Tamanho =15,Pos.I = 220,Pos.F=234,Formato= X
        /// </summary>
        public string NumeroContrato { get; set; }
        /// <summary>
        ///  Campo 29,QuantidadeFaturada, Tamanho =12,Pos.I = 235,Pos.F=246,Formato= N,Com 3 casas decimais
        /// </summary>
        public string QuantidadeFaturada { get; set; }
        /// <summary>
        ///  Campo 30,PrecoMedioEfetivo, Tamanho =11,Pos.I = 247,Pos.F=257,Formato= N,Com 6 casas decimais
        /// </summary>
        public string PrecoMedioEfetivo { get; set; }
        /// <summary>
        ///  Campo 31,AliquotaPISPASEP, Tamanho =6,Pos.I = 258,Pos.F=263,Formato= N,Com 4 casas decimais
        /// </summary>
        public string AliquotaPISPASEP { get; set; }
        /// <summary>
        ///  Campo 32,PISPASEP, Tamanho =11,Pos.I = 264,Pos.F=274,Formato= N,Com 2 casas decimais
        /// </summary>
        public string PISPASEP { get; set; }
        /// <summary>
        ///  Campo 33,ALIQUOTACOFINS, Tamanho =6,Pos.I = 275,Pos.F=280,Formato= N,Com 4 casas decimais
        /// </summary>
        public string ALIQUOTACOFINS { get; set; }
        /// <summary>
        ///  Campo 34,COFINS, Tamanho =11,Pos.I = 281,Pos.F=291,Formato= N,Com 2 casas decimais
        /// </summary>
        ///  
        public string COFINS { get; set; }
        /// <summary>
        ///  Campo 35,IndicadorDescntoJudicial, Tamanho =1,Pos.I = 292,Pos.F=292,Formato= X
        /// </summary>
        ///  
        public string IndicadorDescontoJudicial { get; set; }
        /// <summary>
        ///  Campo 36,TipoInsecaoReducaoBaseCalculo, Tamanho =2,Pos.I = 293,Pos.F=294,Formato= N
        /// </summary>
        /// 
        public string TipoInsecaoReducaoBaseCalculo { get; set; }
        /// <summary>
        ///  Campo 37,Brancos, Tamanho =5,Pos.I = 295,Pos.F=299,Formato= X
        /// </summary>
        /// 
        public string Brancos { get; set; }
        /// <summary>
        ///  Campo 38,CodigoAutenticacaoDigitalRegistro, Tamanho =32,Pos.I = 300,Pos.F=331,Formato= X
        /// </summary>
        /// 
        public string CodigoAutenticacaoDigitalRegistro { get; set; }

    }
}
