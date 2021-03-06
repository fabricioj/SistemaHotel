-- MySQL Script generated by MySQL Workbench
-- 12/03/16 01:40:34
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema SistemaHoteldb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `SistemaHoteldb` ;

-- -----------------------------------------------------
-- Schema SistemaHoteldb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `SistemaHoteldb` DEFAULT CHARACTER SET utf8 ;
USE `SistemaHoteldb` ;

-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`fornecedor` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `razao_social` VARCHAR(50) NULL,
  `cnpj` VARCHAR(25) NULL,
  `telefone` VARCHAR(15) NULL,
  `endereco` VARCHAR(50) NULL,
  `numero` VARCHAR(10) NULL,
  `bairro` VARCHAR(30) NULL,
  `cep` VARCHAR(16) NULL,
  `cidade` VARCHAR(50) NULL,
  `estado` VARCHAR(2) NULL,
  `email` VARCHAR(100) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`area_comum`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`area_comum` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `data_cadastro` DATE NULL,
  `observacao` VARCHAR(245) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`perfil` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  `supervisor` VARCHAR(1) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`morador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`morador` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `rg` VARCHAR(12) NULL,
  `cpf` VARCHAR(14) NULL,
  `celular` VARCHAR(9) NULL,
  `telefone` VARCHAR(15) NULL,
  `email` VARCHAR(35) NULL,
  `empresa` VARCHAR(45) NULL,
  `telefone_comercial` VARCHAR(15) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`usuario` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `cpf` VARCHAR(15) NULL,
  `telefone` VARCHAR(15) NULL,
  `celular` VARCHAR(15) NULL,
  `email` VARCHAR(50) NULL,
  `senha` VARCHAR(50) NULL,
  `perfil_id` INT NULL,
  `morador_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_usuario_perfil_idx` (`perfil_id` ASC),
  INDEX `fk_usuario_morador_idx` (`morador_id` ASC),
  CONSTRAINT `fk_usuario_perfil`
    FOREIGN KEY (`perfil_id`)
    REFERENCES `SistemaHoteldb`.`perfil` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`solicitacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`solicitacao` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `servico` VARCHAR(245) NULL,
  `local` VARCHAR(245) NULL,
  `observacao` VARCHAR(245) NULL,
  `data_inicio` DATE NULL,
  `data_fim` DATE NULL,
  `hora_inicio` TIME NULL,
  `hora_fim` TIME NULL,
  `data_emissao` DATE NULL,
  `data_visualizacao` DATE NULL,
  `observacao_visualizacao` VARCHAR(254) NULL,
  `resultado_visualizacao` VARCHAR(2) NULL,
  `area_comum_id` INT NULL,
  `tipo` VARCHAR(2) NULL,
  `usuario_solicitante_id` INT NULL,
  `usuario_visualizacao_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_solicitacao_area_comum_idx` (`area_comum_id` ASC),
  INDEX `fk_solicitacao_usuario1_idx` (`usuario_solicitante_id` ASC),
  INDEX `fk_solicitacao_usuario2_idx` (`usuario_visualizacao_id` ASC),
  CONSTRAINT `fk_solicitacao_area_comum`
    FOREIGN KEY (`area_comum_id`)
    REFERENCES `SistemaHoteldb`.`area_comum` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_solicitacao_solicitante_usuario`
    FOREIGN KEY (`usuario_solicitante_id`)
    REFERENCES `SistemaHoteldb`.`usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_solicitacao_visualizacao_usuario`
    FOREIGN KEY (`usuario_visualizacao_id`)
    REFERENCES `SistemaHoteldb`.`usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`procedimento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`procedimento` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(50) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`funcionario` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `rg` VARCHAR(15) NULL,
  `cpf` VARCHAR(15) NULL,
  `telefone` VARCHAR(15) NULL,
  `endereco` VARCHAR(50) NULL,
  `numero` VARCHAR(10) NULL,
  `bairro` VARCHAR(30) NULL,
  `cep` VARCHAR(15) NULL,
  `cidade` VARCHAR(50) NULL,
  `estado` VARCHAR(2) NULL,
  `email` VARCHAR(100) NULL,
  `estado_civil` VARCHAR(1) NULL,
  `nome_conjuge` VARCHAR(50) NULL,
  `nome_mae` VARCHAR(50) NULL,
  `nome_pai` VARCHAR(50) NULL,
  `nacionalidade` VARCHAR(20) NULL,
  `funcao` VARCHAR(100) NULL,
  `data_cadastro` DATE NULL,
  `data_contratacao` DATE NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`atividade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`atividade` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NULL,
  `data_cadastro` DATE NULL,
  `data_confirmacao` DATE NULL,
  `solicitacao_id` INT NULL,
  `procedimento_id` INT NULL,
  `funcionario_id` INT NULL,
  `usuario_confirmacao_id` INT NULL,
  `observacao_confirmacao` VARCHAR(254) NULL,
  `gerar_orcamento` VARCHAR(1) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_atividade_solicitcao_idx` (`solicitacao_id` ASC),
  INDEX `fk_atividade_procedimento_idx` (`procedimento_id` ASC),
  INDEX `fk_atividade_funcionario_idx` (`funcionario_id` ASC),
  INDEX `fk_atividade_usuario_confirmacao_idx` (`usuario_confirmacao_id` ASC),
  CONSTRAINT `fk_atividade_solicitacao`
    FOREIGN KEY (`solicitacao_id`)
    REFERENCES `SistemaHoteldb`.`solicitacao` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_atividade_procedimento`
    FOREIGN KEY (`procedimento_id`)
    REFERENCES `SistemaHoteldb`.`procedimento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_atividade_funcionario`
    FOREIGN KEY (`funcionario_id`)
    REFERENCES `SistemaHoteldb`.`funcionario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_atividade_usuario_confirmacao`
    FOREIGN KEY (`usuario_confirmacao_id`)
    REFERENCES `SistemaHoteldb`.`usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`orcamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`orcamento` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data_emissao` DATE NULL,
  `data_confirmacao` DATE NULL,
  `atividade_id` INT NULL,
  `fornecedor_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_cadastro_orcamento_atividade_idx` (`atividade_id` ASC),
  INDEX `fk_orcamento_fornecedor_idx` (`fornecedor_id` ASC),
  CONSTRAINT `fk_cadastro_orcamento_atividade`
    FOREIGN KEY (`atividade_id`)
    REFERENCES `SistemaHoteldb`.`atividade` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orcamento_fornecedor`
    FOREIGN KEY (`fornecedor_id`)
    REFERENCES `SistemaHoteldb`.`fornecedor` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`produto` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(245) NULL,
  `controla_estoque` VARCHAR(1) NULL,
  `quantidade` DOUBLE NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`orcamento_item`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`orcamento_item` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `quantidade` DOUBLE NULL,
  `orcamento_id` INT NULL,
  `produto_id` INT NULL,
  `quantidade_comprada` DOUBLE NULL,
  `valor` DOUBLE NULL,
  `observacao` VARCHAR(254) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_orcamento_item_orcamento_idx` (`orcamento_id` ASC),
  INDEX `fk_orcamento_item_produto_idx` (`produto_id` ASC),
  CONSTRAINT `fk_orcamento_item_orcamento`
    FOREIGN KEY (`orcamento_id`)
    REFERENCES `SistemaHoteldb`.`orcamento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_orcamento_item_produto`
    FOREIGN KEY (`produto_id`)
    REFERENCES `SistemaHoteldb`.`produto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`reserva_area_comum`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`reserva_area_comum` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `observacao` VARCHAR(254) NULL,
  `data_devolucao` DATE NULL,
  `hora_devolucao` TIME NULL,
  `solicitacao_id` INT NULL,
  `observacao_devolucao` VARCHAR(254) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_reserva_area_comum_cadastro_solicitcao1_idx` (`solicitacao_id` ASC),
  CONSTRAINT `fk_reserva_area_comum_solicitcao1`
    FOREIGN KEY (`solicitacao_id`)
    REFERENCES `SistemaHoteldb`.`solicitacao` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`ocorrencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`ocorrencia` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `observacao` VARCHAR(245) NULL,
  `data` DATE NULL,
  `morador_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ocorrencia_morador_idx` (`morador_id` ASC),
  CONSTRAINT `fk_ocorrencia_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`apartamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`apartamento` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `area` VARCHAR(245) NULL,
  `observacao` VARCHAR(245) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`moradia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`moradia` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data_ini_contrato` DATE NULL,
  `data_vigencia` DATE NULL,
  `data_final` DATE NULL,
  `caminho_documento` VARCHAR(245) NULL,
  `morador_id` INT NULL,
  `apartamento_id` INT NULL,
  `tipo_contrato` VARCHAR(2) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_moradia_morador_idx` (`morador_id` ASC),
  INDEX `fk_moradia_apartamento_idx` (`apartamento_id` ASC),
  CONSTRAINT `fk_moradia_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_moradia_apartamento`
    FOREIGN KEY (`apartamento_id`)
    REFERENCES `SistemaHoteldb`.`apartamento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`dependente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`dependente` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  `rg` VARCHAR(14) NULL,
  `cpf` VARCHAR(15) NULL,
  `morador_id` INT NULL,
  `celular` VARCHAR(15) NULL,
  `telefone_comercial` VARCHAR(15) NULL,
  `profissao` VARCHAR(100) NULL,
  `empresa` VARCHAR(100) NULL,
  `email` VARCHAR(100) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_dependente_morador_idx` (`morador_id` ASC),
  CONSTRAINT `fk_dependente_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`procedimento_passo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`procedimento_passo` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `descricao_passo` VARCHAR(245) NULL,
  `ordem_execucao` INT NULL,
  `procedimento_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_procedimento_passo_procedimento_idx` (`procedimento_id` ASC),
  CONSTRAINT `fk_procedimento_passo_procedimento`
    FOREIGN KEY (`procedimento_id`)
    REFERENCES `SistemaHoteldb`.`procedimento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`procedimento_passo_produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`procedimento_passo_produto` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `quantidade_utilizada` DOUBLE NULL,
  `procedimento_passo_id` INT NULL,
  `produto_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_procedimento_passo_produtos_procedimento_passo_idx` (`procedimento_passo_id` ASC),
  INDEX `fk_procedimento_passo_produto_produto_idx` (`produto_id` ASC),
  CONSTRAINT `fk_procedimento_passo_produto_procedimento_passo`
    FOREIGN KEY (`procedimento_passo_id`)
    REFERENCES `SistemaHoteldb`.`procedimento_passo` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_procedimento_passo_produto_produto`
    FOREIGN KEY (`produto_id`)
    REFERENCES `SistemaHoteldb`.`produto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`funcionalidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`funcionalidade` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome_funcionalidade` VARCHAR(45) NULL,
  `nome_tela` VARCHAR(45) NULL,
  `tipo` VARCHAR(1) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`permissao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`permissao` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `consultar` VARCHAR(1) NULL,
  `inserir` VARCHAR(1) NULL,
  `alterar` VARCHAR(1) NULL,
  `excluir` VARCHAR(1) NULL,
  `especial` VARCHAR(1) NULL,
  `funcionalidade_id` INT NULL,
  `perfil_id` INT NULL,
  `usuario_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_permissao_funcionalidade_idx` (`funcionalidade_id` ASC),
  INDEX `fk_permissao_perfil_idx` (`perfil_id` ASC),
  INDEX `fk_permissao_usuario_idx` (`usuario_id` ASC),
  CONSTRAINT `fk_permissao_funcionalidade`
    FOREIGN KEY (`funcionalidade_id`)
    REFERENCES `SistemaHoteldb`.`funcionalidade` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_permissao_perfil`
    FOREIGN KEY (`perfil_id`)
    REFERENCES `SistemaHoteldb`.`perfil` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_permissao_usuario`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `SistemaHoteldb`.`usuario` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`veiculo` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `marca` VARCHAR(45) NULL,
  `modelo` VARCHAR(50) NULL,
  `cor` VARCHAR(20) NULL,
  `placa` VARCHAR(9) NULL,
  `observacao` VARCHAR(254) NULL,
  `morador_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_veiculo_morador_idx` (`morador_id` ASC),
  CONSTRAINT `fk_veiculo_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`vaga`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`vaga` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `apartamento_id` INT NULL,
  `numero_vaga` INT NULL,
  `morador_ocupante_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_vaga_apartamento_idx` (`apartamento_id` ASC),
  INDEX `fk_vaga_morador_idx` (`morador_ocupante_id` ASC),
  CONSTRAINT `fk_vaga_apartamento`
    FOREIGN KEY (`apartamento_id`)
    REFERENCES `SistemaHoteldb`.`apartamento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vaga_morador`
    FOREIGN KEY (`morador_ocupante_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`visitante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`visitante` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `apartamento_id` INT NULL,
  `nome` VARCHAR(50) NULL,
  `rg` VARCHAR(15) NULL,
  `data_chegada` DATE NULL,
  `hora_chegada` TIME NULL,
  `data_saida` DATE NULL,
  `hora_saida` TIME NULL,
  `morador_id` INT NULL,
  `dependente_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_visitante_apartamento_idx` (`apartamento_id` ASC),
  INDEX `fk_visitante_morador_idx` (`morador_id` ASC),
  INDEX `fk_visitante_dependente_idx` (`dependente_id` ASC),
  CONSTRAINT `fk_visitante_apartamento`
    FOREIGN KEY (`apartamento_id`)
    REFERENCES `SistemaHoteldb`.`apartamento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_visitante_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_visitante_dependente`
    FOREIGN KEY (`dependente_id`)
    REFERENCES `SistemaHoteldb`.`dependente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`prestador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`prestador` (
  `id` INT NOT NULL,
  `nome` VARCHAR(50) NULL,
  `razao_social` VARCHAR(50) NULL,
  `cnpj` VARCHAR(25) NULL,
  `telefone` VARCHAR(15) NULL,
  `endereco` VARCHAR(50) NULL,
  `numero` VARCHAR(10) NULL,
  `bairro` VARCHAR(30) NULL,
  `cep` VARCHAR(20) NULL,
  `cidade` VARCHAR(50) NULL,
  `estado` VARCHAR(2) NULL,
  `email` VARCHAR(100) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`prestacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`prestacao` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data_prestacao` DATE NULL,
  `observacao` VARCHAR(245) NULL,
  `prestador_id` INT NULL,
  `apartamento_id` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_prestacao_prestador1_idx` (`prestador_id` ASC),
  INDEX `fk_prestacao_apartamento1_idx` (`apartamento_id` ASC),
  CONSTRAINT `fk_prestacao_prestador1`
    FOREIGN KEY (`prestador_id`)
    REFERENCES `SistemaHoteldb`.`prestador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_prestacao_apartamento1`
    FOREIGN KEY (`apartamento_id`)
    REFERENCES `SistemaHoteldb`.`apartamento` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `SistemaHoteldb`.`entrega_mercadorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `SistemaHoteldb`.`entrega_mercadorias` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `data_recebimento` DATE NULL,
  `produto_id` INT NULL,
  `morador_id` INT NULL,
  `data_entrega` DATE NULL,
  `hora_entrega` TIME NULL,
  `recibo_entrega` VARCHAR(254) NULL,
  `observacao_entrega` VARCHAR(254) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Entrega_mercadorias_produto_idx` (`produto_id` ASC),
  INDEX `fk_Entrega_mercadorias_morador_idx` (`morador_id` ASC),
  CONSTRAINT `fk_Entrega_mercadorias_produto`
    FOREIGN KEY (`produto_id`)
    REFERENCES `SistemaHoteldb`.`produto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Entrega_mercadorias_morador`
    FOREIGN KEY (`morador_id`)
    REFERENCES `SistemaHoteldb`.`morador` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

INSERT INTO `funcionalidade` (`id`, `nome_funcionalidade`, `nome_tela`, `tipo`) VALUES
(1, 'PRODUTOS', 'FrmProdutoLista', '1'),
(2, 'FORNECEDORES', 'FrmFornecedorLista', '1'),
(3, 'FUNCIONÁRIOS', 'FrmFuncionarioLista', '1'),
(4, 'PROCEDIMENTOS', 'FrmProcedimentoLista', '1'),
(5, 'ÁREAS COMUNS', 'FrmAreaComumLista', '1'),
(6, 'SOLICITAÇÕES', 'FrmSolicitacaoLista', '1'),
(7, 'VISUALIZAR SOLICITAÇÃO', 'FrmSolicitacaoVisualizar', '2'),
(8, 'RESERVAS DE ÁREAS COMUNS', 'FrmReservaAreaComum', '1'),
(9, 'DEVOLUÇÃO ÁREA COMUM', 'FrmReservaAreaComumDevolucao', '2'),
(10, 'ATIVIDADES', 'FrmAtividadeLista', '1'),
(11, 'ORÇAMENTOS', 'FrmOrcamentoLista', '1'),
(12, 'FUNCIONALIDADES', 'FrmFuncionalidadeLista', '1'),
(13, 'PERFIS', 'FrmPerfilLista', '1'),
(14, 'USUÁRIOS', 'FrmUsuarioLista', '1');

INSERT INTO `perfil` (`id`, `nome`, `supervisor`) VALUES
(1, 'SUPERVISORES', '0');

INSERT INTO `usuario` (`id`, `nome`, `cpf`, `telefone`, `celular`, `email`, `senha`, `perfil_id`, `morador_id`) VALUES
(1, 'SUPERVISOR SISTEMA HOTEL', '', '', '', 'supervisor@sistemahotel.com.br', '123456', 1, NULL);

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
