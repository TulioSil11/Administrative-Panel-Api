using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace new_bs_integra.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BsecDepartamento> BsecDepartamentos { get; set; }
        public virtual DbSet<BsecFuncionario> BsecFuncionarios { get; set; }
        public virtual DbSet<BsecPrecoRegular> BsecPrecoRegulars { get; set; }
        public virtual DbSet<BsecProduto> BsecProdutos { get; set; }
        public virtual DbSet<BsecSecao> BsecSecaos { get; set; }
        public virtual DbSet<BsecUsuarioPerfil> BsecUsuarioPerfils { get; set; }
        public virtual DbSet<BsecVendedor> BsecVendedors { get; set; }
        public virtual DbSet<BsecFormaparcela> BsecFormaparcela { get; set; }
        public virtual DbSet<BsecEstoque> BsecEstoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Your Connect string",
                    o => o.UseOracleSQLCompatibility("11"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("BSCASARIOS");


            modelBuilder.Entity<BsecDepartamento>(entity =>
            {
                entity.HasKey(e => new { e.IdDepto, e.SeqCliente });

                entity.ToTable("BSEC_DEPARTAMENTO");

                entity.HasIndex(e => e.IdDepto, "BSEC_DEPARTAMENTO_IDXBS001");

                entity.Property(e => e.IdDepto)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_DEPTO");

                entity.Property(e => e.SeqCliente)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Enviaecommerce)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ENVIAECOMMERCE");

                entity.Property(e => e.IdDeptoMagento)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_DEPTO_MAGENTO");

                entity.Property(e => e.NomeDepto)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_DEPTO");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.SeqCatalogoServico)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("SEQ_CATALOGO_SERVICO");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STRING_BANCO");
            });

            modelBuilder.Entity<BsecFuncionario>(entity =>
            {
                entity.HasKey(e => new { e.IdFuncionario, e.SeqCliente });

                entity.ToTable("BSEC_FUNCIONARIO");

                entity.Property(e => e.IdFuncionario)
                    .HasPrecision(15)
                    .HasColumnName("ID_FUNCIONARIO");

                entity.Property(e => e.SeqCliente)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DescontoMaxRodape)
                    .HasColumnType("NUMBER(18,2)")
                    .HasColumnName("DESCONTO_MAX_RODAPE");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Enviafv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENVIAFV");

                entity.Property(e => e.IdFilial)
                    .HasPrecision(5)
                    .HasColumnName("ID_FILIAL");

                entity.Property(e => e.IdPerfil)
                    .HasPrecision(3)
                    .HasColumnName("ID_PERFIL");

                entity.Property(e => e.IdSetor)
                    .HasPrecision(10)
                    .HasColumnName("ID_SETOR");

                entity.Property(e => e.IdVendedor)
                    .HasPrecision(10)
                    .HasColumnName("ID_VENDEDOR");

                entity.Property(e => e.NomeFuncionario)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOME_FUNCIONARIO");

                entity.Property(e => e.NomeSetor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME_SETOR");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.Senhabd)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SENHABD");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.SituacaoErp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO_ERP");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");

                entity.Property(e => e.Tipocargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TIPOCARGO");

                entity.Property(e => e.Usuariobd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIOBD");
            });

            modelBuilder.Entity<BsecPrecoRegular>(entity =>
            {
                entity.HasKey(e => new { e.IdProduto, e.IdRegiao, e.SeqCliente });

                entity.ToTable("BSEC_PRECO_REGULAR");

                entity.HasIndex(e => e.SincUpdate, "BSEC_PRECO_REGULAR_IDX001");

                entity.HasIndex(e => new { e.SeqCliente, e.IdProduto }, "BSEC_PRECO_REGULAR_IDX002");

                entity.HasIndex(e => e.IdProduto, "BSEC_PRECO_REGULAR_IDXBS_001");

                entity.Property(e => e.IdProduto)
                    .HasPrecision(6)
                    .HasColumnName("ID_PRODUTO");

                entity.Property(e => e.IdRegiao)
                    .HasPrecision(4)
                    .HasColumnName("ID_REGIAO");

                entity.Property(e => e.SeqCliente)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Perdescmax)
                    .HasColumnType("NUMBER(10,2)")
                    .HasColumnName("PERDESCMAX");

                entity.Property(e => e.Perdescmaxtab)
                    .HasColumnType("NUMBER(10,2)")
                    .HasColumnName("PERDESCMAXTAB");

                entity.Property(e => e.Preco)
                    .HasColumnType("NUMBER(22,4)")
                    .HasColumnName("PRECO");

                entity.Property(e => e.PrecoGerencia)
                    .HasColumnType("NUMBER(22,4)")
                    .HasColumnName("PRECO_GERENCIA");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");

                entity.Property(e => e.TpEnvio)
                    .HasPrecision(1)
                    .HasColumnName("TP_ENVIO");
            });

            modelBuilder.Entity<BsecProduto>(entity =>
            {
                entity.HasKey(e => new { e.IdProduto, e.SeqCliente });

                entity.ToTable("BSEC_PRODUTO");

                entity.HasIndex(e => e.RowidTb, "BSEC_PRODUTO_IDX001");

                entity.HasIndex(e => new { e.RowidTb, e.SeqCliente }, "BSEC_PRODUTO_IDX002");

                entity.HasIndex(e => e.IdSecao, "BSEC_PRODUTO_IDX007");

                entity.HasIndex(e => e.IdProduto, "BSEC_PRODUTO_IDX100");

                entity.HasIndex(e => new { e.Enviaecommerce, e.SincUpdate, e.Dtexclusao, e.IdProduto }, "BSEC_PRODUTO_IDX101");

                entity.Property(e => e.IdProduto)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PRODUTO");

                entity.Property(e => e.SeqCliente)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.Altura)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ALTURA");

                entity.Property(e => e.CodFab)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COD_FAB");

                entity.Property(e => e.Comprimento)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("COMPRIMENTO");

                entity.Property(e => e.Dadostecnicos)
                    .HasColumnType("CLOB")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DADOSTECNICOS");

                entity.Property(e => e.Descricao1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                entity.Property(e => e.Dirfotoprod)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DIRFOTOPROD");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtImagemDir)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_IMAGEM_DIR");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtProdHomeFim)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_PROD_HOME_FIM");

                entity.Property(e => e.DtProdHomeIni)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_PROD_HOME_INI");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Dtexclusao)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DTEXCLUSAO");

                entity.Property(e => e.Dtvalidadedestaque)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DTVALIDADEDESTAQUE");

                entity.Property(e => e.Embalagem)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EMBALAGEM");

                entity.Property(e => e.Enviacorreios)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENVIACORREIOS");

                entity.Property(e => e.Enviaecommerce)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ENVIAECOMMERCE");

                entity.Property(e => e.Estgerindisponivelsite)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ESTGERINDISPONIVELSITE");

                entity.Property(e => e.IdCategoria)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CATEGORIA");

                entity.Property(e => e.IdDepartamento)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.IdFornecedor)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_FORNECEDOR");

                entity.Property(e => e.IdLinha)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_LINHA");

                entity.Property(e => e.IdMarca)
                    .HasPrecision(8)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_MARCA");

                entity.Property(e => e.IdProdprincipal)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PRODPRINCIPAL");

                entity.Property(e => e.IdProdutoMagento)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_PRODUTO_MAGENTO");

                entity.Property(e => e.IdSecao)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SECAO");

                entity.Property(e => e.IdSubcategoria)
                    .HasPrecision(6)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SUBCATEGORIA");

                entity.Property(e => e.Informacoestecnicas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("INFORMACOESTECNICAS");

                entity.Property(e => e.Largura)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("LARGURA");

                entity.Property(e => e.Litragem)
                    .HasColumnType("NUMBER(18,6)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("LITRAGEM");

                entity.Property(e => e.Multiplo)
                    .HasColumnType("NUMBER(18,2)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("MULTIPLO");

                entity.Property(e => e.Ncm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NCM");

                entity.Property(e => e.NomeCategoria)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_CATEGORIA");

                entity.Property(e => e.NomeLinha)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_LINHA");

                entity.Property(e => e.NomeMarca)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_MARCA");

                entity.Property(e => e.NomeProduto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_PRODUTO");

                entity.Property(e => e.NomeSubcategoria)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOME_SUBCATEGORIA");

                entity.Property(e => e.Nomeecommerce)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NOMEECOMMERCE");

                entity.Property(e => e.Obs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OBS");

                entity.Property(e => e.Obs2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OBS2");

                entity.Property(e => e.PesoBruto)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("PESO_BRUTO");

                entity.Property(e => e.PesoLiquido)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("PESO_LIQUIDO");

                entity.Property(e => e.Pesoembalagem)
                    .HasColumnType("NUMBER(14,7)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("PESOEMBALAGEM");

                entity.Property(e => e.QtImagens)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("QT_IMAGENS");

                entity.Property(e => e.QtImagensMagento)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("QT_IMAGENS_MAGENTO");

                entity.Property(e => e.QtminAtacado)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("QTMIN_ATACADO");

                entity.Property(e => e.Qtprod)
                    .HasColumnType("NUMBER(22,4)")
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("QTPROD");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.SeqFormaparcela)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .ValueGeneratedNever()
                    .HasColumnName("SEQ_FORMAPARCELA");

                entity.Property(e => e.SincConfig)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_CONFIG")
                    .HasDefaultValueSql("0\n");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STRING_BANCO");

                entity.Property(e => e.Subtituloecommerce)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SUBTITULOECOMMERCE");

                entity.Property(e => e.TipoMpAcab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TIPO_MP_ACAB");

                entity.Property(e => e.Tipoestoque)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TIPOESTOQUE");

                entity.Property(e => e.Tituloecommerce)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TITULOECOMMERCE");

                entity.Property(e => e.TpEnvio)
                    .HasPrecision(1)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TP_ENVIO");

                entity.Property(e => e.Unidademaster)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UNIDADEMASTER");
            });

            modelBuilder.Entity<BsecSecao>(entity =>
            {
                entity.HasKey(e => new { e.IdSecao, e.SeqCliente });

                entity.ToTable("BSEC_SECAO");

                entity.Property(e => e.IdSecao)
                    .HasPrecision(6)
                    .HasColumnName("ID_SECAO");

                entity.Property(e => e.SeqCliente)
                    .HasPrecision(10)
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Enviaecommerce)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ENVIAECOMMERCE");

                entity.Property(e => e.IdDepartamento)
                    .HasPrecision(6)
                    .HasColumnName("ID_DEPARTAMENTO");

                entity.Property(e => e.NomeSecao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("NOME_SECAO");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");
            });

            modelBuilder.Entity<BsecUsuarioPerfil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BSEC_USUARIO_PERFIL");

                entity.HasIndex(e => e.IdPerfil, "PRIMARYKEY")
                    .IsUnique();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdPerfil)
                    .HasPrecision(3)
                    .HasColumnName("ID_PERFIL");
            });

            modelBuilder.Entity<BsecVendedor>(entity =>
            {
                entity.HasKey(e => new { e.IdVendedor, e.SeqCliente });

                entity.ToTable("BSEC_VENDEDOR");

                entity.Property(e => e.IdVendedor)
                    .HasPrecision(4)
                    .HasColumnName("ID_VENDEDOR");

                entity.Property(e => e.SeqCliente)
                    .HasPrecision(10)
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.Bloqueio)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BLOQUEIO");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.Dttermino)
                    .HasColumnType("DATE")
                    .HasColumnName("DTTERMINO");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IdClienteMagento)
                    .HasPrecision(10)
                    .HasColumnName("ID_CLIENTE_MAGENTO");

                entity.Property(e => e.IdFilial)
                    .HasPrecision(10)
                    .HasColumnName("ID_FILIAL");

                entity.Property(e => e.IdSupervisor)
                    .HasPrecision(4)
                    .HasColumnName("ID_SUPERVISOR");

                entity.Property(e => e.Matricula)
                    .HasPrecision(8)
                    .HasColumnName("MATRICULA");

                entity.Property(e => e.NomeSupervisor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOME_SUPERVISOR");

                entity.Property(e => e.NomeVendedor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOME_VENDEDOR");

                entity.Property(e => e.Proxnumped)
                    .HasColumnType("NUMBER(22,2)")
                    .HasColumnName("PROXNUMPED");

                entity.Property(e => e.Proxnumpedforca)
                    .HasPrecision(10)
                    .HasColumnName("PROXNUMPEDFORCA");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.Senhabd)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SENHABD");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                entity.Property(e => e.Telefone1)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE1");

                entity.Property(e => e.Tipovend)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TIPOVEND");

                entity.Property(e => e.Tpatacarejo)
                    .HasPrecision(1)
                    .HasColumnName("TPATACAREJO");

                entity.Property(e => e.Usuariobd)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("USUARIOBD");
            });

            modelBuilder.Entity<BsecFormaparcela>(entity =>
            {
                entity.HasKey(e => new { e.SeqFormaparcela, e.SeqCliente })
                    .HasName("PK_FORMAPARCELA");

                entity.ToTable("BSEC_FORMAPARCELA");

                entity.HasIndex(e => e.SeqFormaparcela, "BSEC_FORMAPARCELA_IDXBS001");

                entity.HasIndex(e => new { e.StringBanco, e.SeqFormaparcela, e.SeqCliente }, "UK_FORMAPARCELA")
                    .IsUnique();

                entity.Property(e => e.SeqFormaparcela)
                    .HasPrecision(10)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SEQ_FORMAPARCELA");

                entity.Property(e => e.SeqCliente)
                    .HasPrecision(10)
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.NomeFormaparcela)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOME_FORMAPARCELA");

                entity.Property(e => e.Numparcela)
                    .HasPrecision(10)
                    .HasColumnName("NUMPARCELA");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");
            });

            modelBuilder.Entity<BsecEstoque>(entity =>
            {
                entity.HasKey(e => new { e.IdProduto, e.IdFilial, e.SeqCliente });

                entity.ToTable("BSEC_ESTOQUE");

                entity.HasIndex(e => e.IdProduto, "BSEC_ESTOQUE_IDX100");

                entity.Property(e => e.IdProduto)
                    .HasPrecision(10)
                    .HasColumnName("ID_PRODUTO");

                entity.Property(e => e.IdFilial)
                    .HasPrecision(10)
                    .HasColumnName("ID_FILIAL");

                entity.Property(e => e.SeqCliente)
                    .HasPrecision(10)
                    .HasColumnName("SEQ_CLIENTE");

                entity.Property(e => e.DtDelete)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_DELETE");

                entity.Property(e => e.DtDeleteBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_DELETE_BS");

                entity.Property(e => e.DtInsert)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT");

                entity.Property(e => e.DtInsertBs)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_INSERT_BS")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.DtUltimaEntrada)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_ULTIMA_ENTRADA");

                entity.Property(e => e.DtUpdate)
                    .HasColumnType("DATE")
                    .HasColumnName("DT_UPDATE");

                entity.Property(e => e.DtUpdateBs)
                    .HasColumnType("DATE")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DT_UPDATE_BS");

                entity.Property(e => e.QtDisponivel)
                    .HasColumnType("NUMBER(22,4)")
                    .HasColumnName("QT_DISPONIVEL");

                entity.Property(e => e.RowidTb)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ROWID_TB");

                entity.Property(e => e.SincDelete)
                    .HasPrecision(1)
                    .HasColumnName("SINC_DELETE");

                entity.Property(e => e.SincInsert)
                    .HasPrecision(1)
                    .HasColumnName("SINC_INSERT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SincUpdate)
                    .HasPrecision(1)
                    .HasColumnName("SINC_UPDATE");

                entity.Property(e => e.Status)
                    .HasPrecision(1)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StringBanco)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STRING_BANCO");

                entity.Property(e => e.TipoProduto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PRODUTO");
            });

            modelBuilder.HasSequence("BSEC_SEQ_UNO_LOGIN");

            modelBuilder.HasSequence("SEQ_BSEC_AVALIACAO_CLIENTE");

            modelBuilder.HasSequence("SEQ_BSEC_AVALIACAO_TRIBUTOS");

            modelBuilder.HasSequence("SEQ_BSEC_ENDER_ENTREGA");

            modelBuilder.HasSequence("SEQ_BSEC_FORMAENTREGA");

            modelBuilder.HasSequence("SEQ_BSEC_FORMAPAGTO");

            modelBuilder.HasSequence("SEQ_BSEC_FORMAPARCELA");

            modelBuilder.HasSequence("SEQ_BSEC_LEAD_CLIENTE");

            modelBuilder.HasSequence("SEQ_BSEC_MEDIA_ATRIBUTOS");

            modelBuilder.HasSequence("SEQ_BSEC_PEDIDO");

            modelBuilder.HasSequence("SEQ_BSEC_QUEMVIUPRODUTOS");

            modelBuilder.HasSequence("SEQ_BSEC_USUARIO");

            modelBuilder.HasSequence("SEQ_PARAMETRO_RODAPE");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
