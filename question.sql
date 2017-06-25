-- MySQL dump 10.13  Distrib 5.7.16, for Win64 (x86_64)
--
-- Host: localhost    Database: question
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admin` (
  `adminname` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`adminname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES ('admin','123');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `history` (
  `historyid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `questionid` int(11) NOT NULL,
  `useranswer` varchar(10) NOT NULL,
  `rightorwrong` int(11) NOT NULL,
  `tpid` int(11) NOT NULL,
  PRIMARY KEY (`historyid`),
  KEY `username` (`username`),
  KEY `questionid` (`questionid`),
  CONSTRAINT `history_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `history_ibfk_2` FOREIGN KEY (`questionid`) REFERENCES `question` (`questionid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `history`
--

LOCK TABLES `history` WRITE;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` VALUES (1,'test',20,'B',1,0),(2,'test',30,'B',0,0),(3,'test',22,'C',1,0),(4,'test',29,'B',1,0),(5,'test',15,'C',1,0),(6,'test',25,'B',0,0),(7,'test',30,'C',1,0),(8,'test',1,'B',1,0),(9,'test',18,'B',1,0),(10,'test',23,'A',1,0),(11,'dxj',29,'A',0,0),(12,'dxj',11,'C',1,0),(13,'dxj',23,'A',1,0),(14,'dxj',23,'A',1,0),(15,'dxj',5,'C',1,0),(16,'dxj',6,'D',1,0),(17,'dxj',12,'B',1,0),(18,'dxj',23,'A',1,0),(19,'dxj',5,'C',1,0),(20,'dxj',28,'B',1,0);
/*!40000 ALTER TABLE `history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `question` (
  `questionid` int(11) NOT NULL AUTO_INCREMENT,
  `q_name` varchar(1000) NOT NULL,
  `c_a` varchar(50) NOT NULL,
  `c_b` varchar(50) NOT NULL,
  `c_c` varchar(50) NOT NULL,
  `c_d` varchar(50) NOT NULL,
  `hardlevel` int(11) NOT NULL,
  `score` int(11) NOT NULL,
  `answer` varchar(2) NOT NULL,
  PRIMARY KEY (`questionid`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES (1,'10','1','2','5','4',1,10,'B'),(5,'1+2=','1','2','3','4',1,10,'C'),(6,'1+3=','1','2','3','4',1,10,'D'),(7,'1+4=','2','3','4','5',1,10,'D'),(8,'2+3','4','5','2','6',1,10,'B'),(9,'6+9+10=','34','12','25','99',2,10,'C'),(10,'859+490','1349','2345','1230','3049',3,10,'A'),(11,'C语言规定:在一个源程序中,main函数的位置 ','必须在最开始','必须在系统调用的库函数的后面 ','可以任意 ','必须在最后',2,10,'C'),(12,'一个C语言程序是由 ','一个主程序和若干子程序组成','若干个函数组成','若干过程组成 ','若干子程序组成',4,10,'B'),(13,'在C语言中(以16位PC机为例),5种基本数据类型的存储空间长度的排列顺序为 ','char<int<1ong int<=float<double ','char=int<1ong int<=float<double','char<int<1ong int=float=double','char=int=1ong int<=float<double',5,10,'A'),(14,'假设所有变量均为整型,则表达式(a=2,b=5,b++,a+b)的值是: ','7','8','6','2',3,10,'B'),(15,'若x,i,j和k都是int型变量,则执行下面表达式后x的值为  x=(i=4,j=16,k=32)','4','16','32','52',4,10,'C'),(16,'在C语言的函数中，下列正确的说法是()','必须有形参','形参必须是变量名','可以有也可以没有形参数','数组名不能作形参',2,10,'C'),(17,'若有说明:int a[3][4];则数组a中各元素()','可在程序的运行阶段得到初值0','可在程序的编译阶段得到初值0','不能得到确定的初值0','可在程序的编译或运行阶段得到初值0',3,10,'C'),(18,'设C语言中，int类型数据占2个字节，则short类型数据占()','1个字节',':2个字节','4个字节','8个字节',4,10,'B'),(19,'JAVA所定义的版本中不包括：','JAVA2 EE ','JAVA2 Card','JAVA2 ME',' JAVA2 HE ',5,10,'D'),(20,'为一个boolean类型变量赋值时，可以使用()方式','boolean = 1;','boolean a = (9 >= 10);','boolean a=\"真\"; ','boolean a = = false; ',3,10,'B'),(21,'\"红娘\"由来是出自下列哪部古典名剧: ','《琵琶记》','《西厢记》','《长生殿》','《桃花扇》',2,10,'B'),(22,'下面哪个是对“惊蛰”这个节气的正确描述？','春季开始 ','降雨量增多，对谷类生长有利。','温度逐渐升高，开始打雷，冬眠动物苏醒','气候温暖，草木茂盛，天气晴朗。',3,10,'C'),(23,'北京大学的第一位校长是？','严复','蔡元培','胡适','李大钊',2,10,'A'),(24,'不论是儿童、成年或老年缺钙都会影响健康，患各种疾病，钙的吸收与（）维生素有关：','维生素A','维生素B','维生素C','维生素D',1,10,'D'),(25,'凹透镜成像是以下哪种情形? ','虚物成虚像','虚物成实像','实物成虚像','实物成实',5,10,'C'),(26,'世界上最大的宫殿是: ','故宫 ','白宫','爱丽舍宫','克里姆林宫',2,10,'A'),(27,'\"破釜沉舟\"这个成语出于哪次战争?','赤壁之战','长平之战 ','巨鹿之战','官渡之战',4,10,'C'),(28,'莎士比亚四大悲剧中哪部又称\"王子复仇记\":','《奥赛罗》','《哈姆雷特》','《麦克白斯》','《李尔王》',3,10,'B'),(29,'第一个在春晚上打广告的企业是','联想集团','活力28集团 ','稻花香酒业','海尔集团',5,10,'B'),(30,'按照宇宙大爆炸理论，宇宙的年龄估计有','200亿年','50亿年','120亿年','150亿年',5,10,'C'),(31,'以下历史事件中，与关羽无关的是','单刀赴会','水淹七军','大意失荆州','七擒七纵',1,10,'D'),(32,'下列哪个是真正的鱼','海马','鲸鱼','章鱼','儒艮',5,10,'A');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `score`
--

DROP TABLE IF EXISTS `score`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `score` (
  `scoreid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `tpid` int(11) NOT NULL,
  `score` int(11) NOT NULL,
  PRIMARY KEY (`scoreid`),
  KEY `username` (`username`),
  CONSTRAINT `score_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `score`
--

LOCK TABLES `score` WRITE;
/*!40000 ALTER TABLE `score` DISABLE KEYS */;
INSERT INTO `score` VALUES (1,'test',0,80),(2,'dxj',0,90);
/*!40000 ALTER TABLE `score` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tpcount`
--

DROP TABLE IF EXISTS `tpcount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tpcount` (
  `countid` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  PRIMARY KEY (`countid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tpcount`
--

LOCK TABLES `tpcount` WRITE;
/*!40000 ALTER TABLE `tpcount` DISABLE KEYS */;
INSERT INTO `tpcount` VALUES (1,0);
/*!40000 ALTER TABLE `tpcount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `sex` int(11) NOT NULL,
  `class` varchar(50) NOT NULL,
  `question` varchar(50) NOT NULL,
  `answer` varchar(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('dxj','123',2,'1401','您目前的姓名是？','段晓君'),('test','123',1,'1401','您目前的姓名是？','wzw');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-06-24 13:52:20
