-- MySQL dump 10.13  Distrib 5.7.19, for Win64 (x86_64)
--
-- Host: localhost    Database: pressingconjecture
-- ------------------------------------------------------
-- Server version	5.7.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clients` (
  `matricule` varchar(100) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `telephone` int(11) NOT NULL,
  `quartier` varchar(100) NOT NULL,
  `date_ajout` date NOT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES ('CL001','Kongnuy','Victorien',690210677,'Biyem-assi','2018-01-01'),('CL002','Kameni','Carlors',665894532,'Bastos','2018-02-03'),('CL003','Ngo','Samuel',660698654,'Biyem-assi','2018-01-12'),('CL004','Nana','Josianne',675213659,'Essos','2017-05-02'),('CL005','Bikoe','Eric',679855452,'Ekounou','2018-01-25'),('CL006','Kong','Victor',690415263,'Obili','2017-08-01'),('CL007','Nguefack','Rosine',697548965,'Emombo','2017-11-01'),('CL008','Nanfang','Bernard',665987421,'Essos','2018-03-01'),('CL009','Feugang','Madelaine',678451223,'Obili','2018-03-05'),('CL010','Voukeng','Brice',678965321,'Biyem-assi','2018-01-17'),('CL011','Zang','Boris',655987412,'Odza','2013-04-08'),('CL012','Somo','Simon',652632547,'Biyem-assi','2016-07-01'),('CL013','khjhfgg','ggfghfgf',454654,'kkkkkk','2013-02-06'),('CL014','hjcvbnvcx','sdfcgvbnvc',654545,'qsdfghj','2012-05-06'),('CL015','dfdgfhgjhkjkh','fghjkjghj',7889898,'lhlhjhjhlkjh','2011-08-06'),('CL016','hkjhkj','khkjhjh',454564,'iuiuiuiou','2013-08-03'),('CL017','oiujh','jujuj',4545,'lklkl','2015-03-05'),('CL019','tyty','tata',454,'king','2018-03-11'),('CL020','aqaqaqaq','titititi',77777,'tatata','2018-03-11');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compartiment`
--

DROP TABLE IF EXISTS `compartiment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `compartiment` (
  `code_c` varchar(100) NOT NULL,
  `libelle` varchar(100) NOT NULL,
  PRIMARY KEY (`code_c`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compartiment`
--

LOCK TABLES `compartiment` WRITE;
/*!40000 ALTER TABLE `compartiment` DISABLE KEYS */;
/*!40000 ALTER TABLE `compartiment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dedomagement`
--

DROP TABLE IF EXISTS `dedomagement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dedomagement` (
  `code_d` varchar(100) NOT NULL,
  `montant` int(11) NOT NULL,
  `beneficiare` varchar(100) NOT NULL,
  `date_du_dedomagement` date NOT NULL,
  PRIMARY KEY (`code_d`),
  KEY `fk_dedomagement` (`beneficiare`),
  CONSTRAINT `fk_dedomagement` FOREIGN KEY (`beneficiare`) REFERENCES `clients` (`matricule`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dedomagement`
--

LOCK TABLES `dedomagement` WRITE;
/*!40000 ALTER TABLE `dedomagement` DISABLE KEYS */;
INSERT INTO `dedomagement` VALUES ('D001',8500,'CL007','2017-11-15'),('D002',5000,'CL004','2017-09-05'),('D003',7000,'CL004','2017-09-15'),('D004',8500,'CL001','2018-02-21'),('D005',8500,'CL008','2017-04-11'),('D006',8500,'CL008','2017-03-17'),('D007',8500,'CL001','2017-03-27'),('D008',8500,'CL010','2017-02-14'),('D009',8500,'CL004','2017-06-15'),('D010',8500,'CL001','2017-12-01');
/*!40000 ALTER TABLE `dedomagement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facture`
--

DROP TABLE IF EXISTS `facture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facture` (
  `code_f` varchar(100) NOT NULL,
  `montant_a_payer` int(11) NOT NULL,
  `montant_payer` int(11) DEFAULT NULL,
  `date_de_creation` date DEFAULT NULL,
  PRIMARY KEY (`code_f`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facture`
--

LOCK TABLES `facture` WRITE;
/*!40000 ALTER TABLE `facture` DISABLE KEYS */;
INSERT INTO `facture` VALUES ('FT001',2400,2400,'2018-03-02'),('FT002',1800,1800,'2018-03-01'),('FT003',4000,4000,'2018-03-01'),('FT004',6600,5500,'2018-02-28'),('FT006',3000,3000,'2018-03-11'),('FT007',1800,1800,'2018-03-11'),('FT008',3764,3764,'2018-03-11');
/*!40000 ALTER TABLE `facture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fichelavage`
--

DROP TABLE IF EXISTS `fichelavage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fichelavage` (
  `code_l` varchar(100) NOT NULL,
  `laveur` varchar(100) NOT NULL,
  `type_lavage` varchar(100) NOT NULL,
  `delais` int(11) NOT NULL,
  `date_retrait` date NOT NULL,
  `date_lavage` date DEFAULT NULL,
  `nombre_vetement` int(11) DEFAULT NULL,
  PRIMARY KEY (`code_l`),
  KEY `fk_fichelavage` (`laveur`),
  CONSTRAINT `fk_fichelavage` FOREIGN KEY (`laveur`) REFERENCES `laveurs` (`matricule`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fichelavage`
--

LOCK TABLES `fichelavage` WRITE;
/*!40000 ALTER TABLE `fichelavage` DISABLE KEYS */;
/*!40000 ALTER TABLE `fichelavage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ficherepassage`
--

DROP TABLE IF EXISTS `ficherepassage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ficherepassage` (
  `code_r` varchar(100) NOT NULL,
  `repasseur` varchar(100) NOT NULL,
  `delais` int(11) NOT NULL,
  `date_retrait` date NOT NULL,
  `date_repassage` date DEFAULT NULL,
  PRIMARY KEY (`code_r`),
  KEY `fk_ficherepasseurs` (`repasseur`),
  CONSTRAINT `fk_ficherepasseurs` FOREIGN KEY (`repasseur`) REFERENCES `repasseurs` (`matricule`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ficherepassage`
--

LOCK TABLES `ficherepassage` WRITE;
/*!40000 ALTER TABLE `ficherepassage` DISABLE KEYS */;
/*!40000 ALTER TABLE `ficherepassage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incidentlavage`
--

DROP TABLE IF EXISTS `incidentlavage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `incidentlavage` (
  `code_il` varchar(100) NOT NULL,
  `description` varchar(500) NOT NULL,
  `vetement` varchar(100) NOT NULL,
  `date_incident` date DEFAULT NULL,
  PRIMARY KEY (`code_il`),
  KEY `fk_incidentlavage` (`vetement`),
  CONSTRAINT `fk_incidentlavage` FOREIGN KEY (`vetement`) REFERENCES `vetement` (`identifiant`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incidentlavage`
--

LOCK TABLES `incidentlavage` WRITE;
/*!40000 ALTER TABLE `incidentlavage` DISABLE KEYS */;
/*!40000 ALTER TABLE `incidentlavage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `incidentrepassage`
--

DROP TABLE IF EXISTS `incidentrepassage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `incidentrepassage` (
  `code_ir` varchar(100) NOT NULL,
  `description` varchar(500) NOT NULL,
  `vetement` varchar(100) NOT NULL,
  `date_incident` date DEFAULT NULL,
  PRIMARY KEY (`code_ir`),
  KEY `fk_incidentrepassage` (`vetement`),
  CONSTRAINT `fk_incidentrepassage` FOREIGN KEY (`vetement`) REFERENCES `vetement` (`identifiant`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `incidentrepassage`
--

LOCK TABLES `incidentrepassage` WRITE;
/*!40000 ALTER TABLE `incidentrepassage` DISABLE KEYS */;
/*!40000 ALTER TABLE `incidentrepassage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `laveurs`
--

DROP TABLE IF EXISTS `laveurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laveurs` (
  `matricule` varchar(100) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `telephone` int(11) DEFAULT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `laveurs`
--

LOCK TABLES `laveurs` WRITE;
/*!40000 ALTER TABLE `laveurs` DISABLE KEYS */;
/*!40000 ALTER TABLE `laveurs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lignefacture`
--

DROP TABLE IF EXISTS `lignefacture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lignefacture` (
  `code_f` varchar(100) NOT NULL,
  `mleclient` varchar(100) NOT NULL,
  `vetement` varchar(100) NOT NULL,
  PRIMARY KEY (`code_f`,`mleclient`,`vetement`),
  KEY `fk_lignefacture2` (`mleclient`),
  KEY `fk_lignefacture3` (`vetement`),
  CONSTRAINT `fk_lignefacture1` FOREIGN KEY (`code_f`) REFERENCES `facture` (`code_f`) ON DELETE CASCADE,
  CONSTRAINT `fk_lignefacture2` FOREIGN KEY (`mleclient`) REFERENCES `clients` (`matricule`) ON DELETE CASCADE,
  CONSTRAINT `fk_lignefacture3` FOREIGN KEY (`vetement`) REFERENCES `vetement` (`identifiant`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lignefacture`
--

LOCK TABLES `lignefacture` WRITE;
/*!40000 ALTER TABLE `lignefacture` DISABLE KEYS */;
INSERT INTO `lignefacture` VALUES ('FT006','CL001','VT033'),('FT002','CL004','VT004'),('FT002','CL004','VT005'),('FT001','CL005','VT001'),('FT001','CL005','VT003'),('FT003','CL008','VT006'),('FT003','CL008','VT007'),('FT003','CL008','VT008'),('FT004','CL010','VT009'),('FT004','CL010','VT010'),('FT008','CL012','VT035'),('FT008','CL012','VT036');
/*!40000 ALTER TABLE `lignefacture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `repasseurs`
--

DROP TABLE IF EXISTS `repasseurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `repasseurs` (
  `matricule` varchar(100) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `telephone` int(11) DEFAULT NULL,
  PRIMARY KEY (`matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `repasseurs`
--

LOCK TABLES `repasseurs` WRITE;
/*!40000 ALTER TABLE `repasseurs` DISABLE KEYS */;
/*!40000 ALTER TABLE `repasseurs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typevetement`
--

DROP TABLE IF EXISTS `typevetement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typevetement` (
  `code_t` varchar(100) NOT NULL,
  `libelle` varchar(100) NOT NULL,
  `pu_traitement` int(11) NOT NULL,
  `pu_lavage` int(11) DEFAULT NULL,
  PRIMARY KEY (`code_t`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typevetement`
--

LOCK TABLES `typevetement` WRITE;
/*!40000 ALTER TABLE `typevetement` DISABLE KEYS */;
INSERT INTO `typevetement` VALUES ('TVT01','Pantalon monsieur',500,800),('TVT02','Pantalon kaki',700,1000),('TVT03','Jeans',800,1100),('TVT04','Costume',1000,1500),('TVT05','Chemise',500,800),('TVT06','Tee-shirt',500,800),('TVT07','Polo',500,800),('TVT08','Maillot',300,500),('TVT09','Pull-over',600,900),('TVT10','Cuire',1500,2500),('TVT11','llllll',45,45),('TVT12','saaaa',600,600),('TVT13','hohoho',988,988),('TVT14','Jupe',500,500);
/*!40000 ALTER TABLE `typevetement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vetement`
--

DROP TABLE IF EXISTS `vetement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vetement` (
  `identifiant` varchar(100) NOT NULL,
  `type_v` varchar(100) NOT NULL,
  `quantite` int(11) NOT NULL,
  `proprietaire` varchar(100) NOT NULL,
  `date_depot` date NOT NULL,
  `date_disponibilite` date NOT NULL,
  `date_eff_retrait` date DEFAULT NULL,
  `compartiment` varchar(100) DEFAULT NULL,
  `fiche_l` varchar(100) DEFAULT NULL,
  `fiche_r` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`identifiant`),
  KEY `fk_vetement1` (`type_v`),
  KEY `fk_vetement2` (`proprietaire`),
  KEY `fk_vetement3` (`fiche_l`),
  KEY `fk_vetement4` (`fiche_r`),
  KEY `fk_vetement5` (`compartiment`),
  CONSTRAINT `fk_vetement1` FOREIGN KEY (`type_v`) REFERENCES `typevetement` (`code_t`) ON DELETE CASCADE,
  CONSTRAINT `fk_vetement2` FOREIGN KEY (`proprietaire`) REFERENCES `clients` (`matricule`) ON DELETE CASCADE,
  CONSTRAINT `fk_vetement3` FOREIGN KEY (`fiche_l`) REFERENCES `fichelavage` (`code_l`) ON DELETE CASCADE,
  CONSTRAINT `fk_vetement4` FOREIGN KEY (`fiche_r`) REFERENCES `ficherepassage` (`code_r`) ON DELETE CASCADE,
  CONSTRAINT `fk_vetement5` FOREIGN KEY (`compartiment`) REFERENCES `compartiment` (`code_c`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vetement`
--

LOCK TABLES `vetement` WRITE;
/*!40000 ALTER TABLE `vetement` DISABLE KEYS */;
INSERT INTO `vetement` VALUES ('VT001','TVT01',2,'CL005','2018-03-02','2018-03-08',NULL,NULL,NULL,NULL),('VT003','TVT05',1,'CL005','2018-03-02','2018-03-08',NULL,NULL,NULL,NULL),('VT004','TVT02',1,'CL004','2018-03-01','2018-03-07',NULL,NULL,NULL,NULL),('VT005','TVT07',1,'CL004','2018-03-01','2018-03-07',NULL,NULL,NULL,NULL),('VT006','TVT05',1,'CL008','2018-03-01','2018-03-07',NULL,NULL,NULL,NULL),('VT007','TVT01',1,'CL008','2018-03-01','2018-03-07',NULL,NULL,NULL,NULL),('VT008','TVT07',3,'CL008','2018-03-01','2018-03-07',NULL,NULL,NULL,NULL),('VT009','TVT07',2,'CL010','2018-02-28','2018-03-06',NULL,NULL,NULL,NULL),('VT010','TVT02',5,'CL010','2018-02-28','2018-03-06',NULL,NULL,NULL,NULL),('VT011','TVT05',3,'CL009','2018-03-03','2018-03-06',NULL,NULL,NULL,NULL),('VT012','TVT05',2,'CL001','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT013','TVT06',12,'CL002','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT014','TVT08',23,'CL002','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT015','TVT07',13,'CL002','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT016','TVT05',12,'CL008','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT017','TVT05',2,'CL003','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT018','TVT05',2,'CL003','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT019','TVT05',12,'CL005','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT022','TVT05',1,'CL001','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT025','TVT06',1,'CL001','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT030','TVT08',3,'CL008','2018-03-08','2018-03-08',NULL,NULL,NULL,NULL),('VT032','TVT05',1,'CL002','2018-03-11','2018-03-11',NULL,NULL,NULL,NULL),('VT033','TVT04',2,'CL001','2018-03-11','2018-03-11',NULL,NULL,NULL,NULL),('VT035','TVT05',1,'CL012','2018-03-11','2018-03-11',NULL,NULL,NULL,NULL),('VT036','TVT13',3,'CL012','2018-03-11','2018-03-11',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `vetement` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-11 23:21:06
