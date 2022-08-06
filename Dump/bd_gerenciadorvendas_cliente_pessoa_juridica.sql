CREATE DATABASE  IF NOT EXISTS `bd_gerenciadorvendas` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_gerenciadorvendas`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_gerenciadorvendas
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente_pessoa_juridica`
--

DROP TABLE IF EXISTS `cliente_pessoa_juridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente_pessoa_juridica` (
  `ID` int unsigned NOT NULL AUTO_INCREMENT,
  `NOME` text,
  `CNPJ` varchar(45) DEFAULT NULL,
  `VALOR_MONETARIO` decimal(10,0) DEFAULT NULL,
  `RAZAO_SOCIAL` text,
  `ATIVIDADES` text,
  `CODIGO_USUARIO` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente_pessoa_juridica`
--

LOCK TABLES `cliente_pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `cliente_pessoa_juridica` DISABLE KEYS */;
INSERT INTO `cliente_pessoa_juridica` VALUES (10,'Jorge Luiz Bd','11118145000108',1969,'A. BADER PINHEIRO','Comércio varejista de mercadorias em lojas de conveniência',32),(11,'Joao','17044689000159',90,'JOELSON DIAS MARTINS 95585770225','Fornecimento de alimentos preparados preponderantemente para consumo domiciliar',32),(12,'','04391803000175',0,'TABACARIA E BAR GULLO LTDA','Tabacaria',27),(13,'Raul','39451418000150',482,'RAUNI NASCIMENTO DOS SANTOS 05740423503','Promoção de vendas',27),(14,'Jesuino','39451418000150',785,'RAUNI NASCIMENTO DOS SANTOS 05740423503','Promoção de vendas',27),(15,'Bruno','32415563000137',754,'ROSINEI DA SILVA 27739251810','Transporte rodoviário de carga, exceto produtos perigosos e mudanças, intermunicipal, interestadual e internacional',27),(16,'Jose','03635909000104',564,'DIVINO CASSIMIRO COSTA','Comércio a varejo de peças e acessórios novos para veículos automotores',29),(17,'Eduardo','14484358000141',980,'RENATO AMORIM DA CONCEICAO 01635910161','Serviços de lavagem, lubrificação e polimento de veículos automotores',31);
/*!40000 ALTER TABLE `cliente_pessoa_juridica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-06 10:03:23
