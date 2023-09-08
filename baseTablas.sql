-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idclientes` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `cc` varchar(45) NOT NULL,
  PRIMARY KEY (`idclientes`),
  UNIQUE KEY `cc_UNIQUE` (`cc`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (13,'Carla','1234667989'),(14,'Andrea','1234689989'),(15,'Marcela','1334337989'),(16,'Peter','1334887989'),(17,'Catalina','13533989'),(18,'Karina','1355333989');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `idEmpleado` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `CC` varchar(45) NOT NULL,
  PRIMARY KEY (`idEmpleado`),
  UNIQUE KEY `CC_UNIQUE` (`CC`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'Jairo','1234667989'),(2,'Andres','1234687989'),(3,'Maria','1334667989'),(4,'Mario','13349967989'),(5,'Pedro','1355667989');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiposeguro`
--

DROP TABLE IF EXISTS `tiposeguro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiposeguro` (
  `idTipoSeguro` int NOT NULL AUTO_INCREMENT,
  `TipoSegurocol` varchar(45) NOT NULL,
  `precio` int NOT NULL,
  PRIMARY KEY (`idTipoSeguro`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiposeguro`
--

LOCK TABLES `tiposeguro` WRITE;
/*!40000 ALTER TABLE `tiposeguro` DISABLE KEYS */;
INSERT INTO `tiposeguro` VALUES (1,'Seguro de vida',9000000),(2,'Seguro educativo',800000),(3,'Seguro obligatorio de accidentes de transito',60000);
/*!40000 ALTER TABLE `tiposeguro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `idventas` int NOT NULL AUTO_INCREMENT,
  `clientes_idclientes` int NOT NULL,
  `TipoSeguro_idTipoSeguro` int DEFAULT NULL,
  `Empleado_idEmpleado` int NOT NULL,
  `fechaInicioSeguro` datetime DEFAULT NULL,
  `fechaFinalSeguro` datetime DEFAULT NULL,
  `venta` tinyint NOT NULL,
  PRIMARY KEY (`idventas`),
  KEY `fk_ventas_clientes_idx` (`clientes_idclientes`),
  KEY `fk_ventas_TipoSeguro1_idx` (`TipoSeguro_idTipoSeguro`),
  KEY `fk_ventas_Empleado1_idx` (`Empleado_idEmpleado`),
  CONSTRAINT `fk_ventas_clientes` FOREIGN KEY (`clientes_idclientes`) REFERENCES `clientes` (`idclientes`),
  CONSTRAINT `fk_ventas_Empleado1` FOREIGN KEY (`Empleado_idEmpleado`) REFERENCES `empleado` (`idEmpleado`),
  CONSTRAINT `fk_ventas_TipoSeguro1` FOREIGN KEY (`TipoSeguro_idTipoSeguro`) REFERENCES `tiposeguro` (`idTipoSeguro`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (7,14,2,3,'2023-12-23 00:00:00','2024-12-24 00:00:00',1),(11,14,3,5,'2020-10-23 00:00:00','2020-10-24 00:00:00',1),(12,15,2,5,'2024-09-23 00:00:00','2024-09-24 00:00:00',1),(13,17,1,2,'2024-09-23 00:00:00','2024-09-24 00:00:00',1),(14,14,NULL,3,NULL,NULL,0),(15,15,NULL,2,NULL,NULL,0),(16,17,NULL,1,NULL,NULL,0);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-07 20:19:15
