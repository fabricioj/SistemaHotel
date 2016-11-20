namespace SistemaHotel.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SistemaHotelContext : DbContext
    {
        public SistemaHotelContext()
            : base("name=SistemaHotelDb")
        {
        }

        public virtual DbSet<Apartamento> apartamento { get; set; }
        public virtual DbSet<Area_comum> area_comum { get; set; }
        public virtual DbSet<Atividade> atividade { get; set; }
        public virtual DbSet<Dependente> dependentes { get; set; }
        public virtual DbSet<Entrega_mercadorias> entrega_mercadorias { get; set; }
        public virtual DbSet<Fornecedor> fornecedor { get; set; }
        public virtual DbSet<Funcionalidade> funcionalidade { get; set; }
        public virtual DbSet<Funcionario> funcionario { get; set; }
        public virtual DbSet<Moradia> moradia { get; set; }
        public virtual DbSet<Morador> morador { get; set; }
        public virtual DbSet<Ocorrencia> ocorrencia { get; set; }
        public virtual DbSet<Orcamento> orcamento { get; set; }
        public virtual DbSet<Orcamento_item> orcamento_item { get; set; }
        public virtual DbSet<Perfil> perfil { get; set; }
        public virtual DbSet<Permissao> permissao { get; set; }
        public virtual DbSet<Prestacao> prestacao { get; set; }
        public virtual DbSet<Prestador> prestador { get; set; }
        public virtual DbSet<Procedimento> procedimento { get; set; }
        public virtual DbSet<Procedimento_passo> procedimento_passo { get; set; }
        public virtual DbSet<Procedimento_passo_produto> procedimento_passo_produto { get; set; }
        public virtual DbSet<Produto> produto { get; set; }
        public virtual DbSet<Reserva_area_comum> reserva_area_comum { get; set; }
        public virtual DbSet<Solicitacao> solicitacao { get; set; }
        public virtual DbSet<Usuario> usuario { get; set; }
        public virtual DbSet<Vaga> vaga { get; set; }
        public virtual DbSet<Veiculo> veiculo { get; set; }
        public virtual DbSet<Visitante> visitante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartamento>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<Apartamento>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Apartamento>()
                .HasMany(e => e.moradia)
                .WithOptional(e => e.apartamento)
                .HasForeignKey(e => e.apartamento_id);

            modelBuilder.Entity<Apartamento>()
                .HasMany(e => e.prestacao)
                .WithOptional(e => e.apartamento)
                .HasForeignKey(e => e.apartamento_id);

            modelBuilder.Entity<Apartamento>()
                .HasMany(e => e.vaga)
                .WithOptional(e => e.apartamento)
                .HasForeignKey(e => e.apartamento_id);

            modelBuilder.Entity<Apartamento>()
                .HasMany(e => e.visitante)
                .WithOptional(e => e.apartamento)
                .HasForeignKey(e => e.apartamento_id);

            modelBuilder.Entity<Area_comum>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Area_comum>()
                .HasMany(e => e.solicitacao)
                .WithOptional(e => e.area_comum)
                .HasForeignKey(e => e.area_comum_id);

            modelBuilder.Entity<Atividade>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Atividade>()
                .HasMany(e => e.orcamento)
                .WithOptional(e => e.atividade)
                .HasForeignKey(e => e.atividade_id);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.telefone_comercial)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.profissao)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Dependente>()
                .HasMany(e => e.visitante)
                .WithOptional(e => e.dependentes)
                .HasForeignKey(e => e.dependentes_id);

            modelBuilder.Entity<Entrega_mercadorias>()
                .Property(e => e.recibo_entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Entrega_mercadorias>()
                .Property(e => e.observacao_entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.razao_social)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.orcamento)
                .WithOptional(e => e.fornecedor)
                .HasForeignKey(e => e.fornecedor_id);

            modelBuilder.Entity<Funcionalidade>()
                .Property(e => e.nome_funcionalidade)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionalidade>()
                .Property(e => e.nome_tela)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionalidade>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionalidade>()
                .HasMany(e => e.permissao)
                .WithOptional(e => e.funcionalidade)
                .HasForeignKey(e => e.funcionalidade_id);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.estado_civil)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.nome_conjuge)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.nome_mae)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.nome_pai)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.nacionalidade)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.funcao)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.atividade)
                .WithOptional(e => e.funcionario)
                .HasForeignKey(e => e.funcionario_id);

            modelBuilder.Entity<Moradia>()
                .Property(e => e.caminho_documento)
                .IsUnicode(false);

            modelBuilder.Entity<Moradia>()
                .Property(e => e.tipo_contrato)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.tel_fixo)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .Property(e => e.tel_comercial)
                .IsUnicode(false);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.dependentes)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.entrega_mercadorias)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.moradia)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.ocorrencia)
                .WithRequired(e => e.morador)
                .HasForeignKey(e => e.morador_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.usuario)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.vaga)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_ocupante_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.veiculo)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Morador>()
                .HasMany(e => e.visitante)
                .WithOptional(e => e.morador)
                .HasForeignKey(e => e.morador_id);

            modelBuilder.Entity<Ocorrencia>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Orcamento>()
                .HasMany(e => e.orcamento_item)
                .WithOptional(e => e.orcamento)
                .HasForeignKey(e => e.orcamento_id);

            modelBuilder.Entity<Orcamento_item>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.permissao)
                .WithOptional(e => e.perfil)
                .HasForeignKey(e => e.perfil_id);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.usuario)
                .WithOptional(e => e.perfil)
                .HasForeignKey(e => e.perfil_id);

            modelBuilder.Entity<Permissao>()
                .Property(e => e.consultar)
                .IsUnicode(false);

            modelBuilder.Entity<Permissao>()
                .Property(e => e.inserir)
                .IsUnicode(false);

            modelBuilder.Entity<Permissao>()
                .Property(e => e.alterar)
                .IsUnicode(false);

            modelBuilder.Entity<Permissao>()
                .Property(e => e.excluir)
                .IsUnicode(false);

            modelBuilder.Entity<Permissao>()
                .Property(e => e.especial)
                .IsUnicode(false);

            modelBuilder.Entity<Prestacao>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.razao_social)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<Prestador>()
                .HasMany(e => e.prestacao)
                .WithOptional(e => e.prestador)
                .HasForeignKey(e => e.prestador_id);

            modelBuilder.Entity<Procedimento>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimento>()
                .HasMany(e => e.atividade)
                .WithOptional(e => e.procedimento)
                .HasForeignKey(e => e.procedimento_id);

            modelBuilder.Entity<Procedimento>()
                .HasMany(e => e.procedimento_passo)
                .WithOptional(e => e.procedimento)
                .HasForeignKey(e => e.procedimento_id);

            modelBuilder.Entity<Procedimento_passo>()
                .Property(e => e.descricao_passo)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimento_passo>()
                .HasMany(e => e.procedimento_passo_produto)
                .WithOptional(e => e.procedimento_passo)
                .HasForeignKey(e => e.procedimento_passo_id);

            modelBuilder.Entity<Produto>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.controla_estoque)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.entrega_mercadorias)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.produto_id);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.orcamento_item)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.produto_id);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.procedimento_passo_produto)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.produto_id);

            modelBuilder.Entity<Reserva_area_comum>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.servico)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.local)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.observacao_visualizacao)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .Property(e => e.resultado_visualizacao)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitacao>()
                .HasMany(e => e.atividade)
                .WithOptional(e => e.solicitacao)
                .HasForeignKey(e => e.solicitacao_id);

            modelBuilder.Entity<Solicitacao>()
                .HasMany(e => e.reserva_area_comum)
                .WithOptional(e => e.solicitacao)
                .HasForeignKey(e => e.solicitacao_id);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.permissao)
                .WithOptional(e => e.usuario)
                .HasForeignKey(e => e.usuario_id);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.solicitacao_solicitante)
                .WithOptional(e => e.usuario_solicitante)
                .HasForeignKey(e => e.usuario_solicitante_id);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.solicitacao_visualizacao)
                .WithOptional(e => e.usuario_visualizacao)
                .HasForeignKey(e => e.usuario_visualizacao_id);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.cor)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.placa)
                .IsUnicode(false);

            modelBuilder.Entity<Veiculo>()
                .Property(e => e.observacao)
                .IsUnicode(false);

            modelBuilder.Entity<Visitante>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Visitante>()
                .Property(e => e.rg)
                .IsUnicode(false);
        }
    }
}
