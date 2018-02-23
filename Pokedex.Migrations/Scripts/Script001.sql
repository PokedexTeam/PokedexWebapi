-- MySQL dump 10.13  Distrib 5.7.21, for Win64 (x86_64)
--
-- Host: localhost    Database: pokedex
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `Pokemons`
--
DROP TABLE IF EXISTS `Pokemons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Pokemons` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `BaseAttack` int(11) NOT NULL,
  `BaseDefense` int(11) NOT NULL,
  `BaseHP` int(11) NOT NULL,
  `BaseSpAtk` int(11) NOT NULL,
  `BaseSpDef` int(11) NOT NULL,
  `BaseSpeed` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pokemonskills`
--

DROP TABLE IF EXISTS `PokemonSkills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `PokemonSkills` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=620 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pokemonskills`
--

LOCK TABLES `PokemonSkills` WRITE;
/*!40000 ALTER TABLE `PokemonSkills` DISABLE KEYS */;
INSERT INTO `PokemonSkills` VALUES (1,'Pound'),(2,'Karate Chop'),(3,'Double Slap'),(4,'Comet Punch'),(5,'Mega Punch'),(6,'Pay Day'),(7,'Fire Punch'),(8,'Ice Punch'),(9,'Thunder Punch'),(10,'Scratch'),(11,'Vice Grip'),(12,'Guillotine'),(13,'Razor Wind'),(14,'Swords Dance'),(15,'Cut'),(16,'Gust'),(17,'Wing Attack'),(18,'Whirlwind'),(19,'Fly'),(20,'Bind'),(21,'Slam'),(22,'Vine Whip'),(23,'Stomp'),(24,'Double Kick'),(25,'Mega Kick'),(26,'Jump Kick'),(27,'Rolling Kick'),(28,'Sand Attack'),(29,'Headbutt'),(30,'Horn Attack'),(31,'Fury Attack'),(32,'Horn Drill'),(33,'Tackle'),(34,'Body Slam'),(35,'Wrap'),(36,'Take Down'),(37,'Thrash'),(38,'Double-Edge'),(39,'Tail Whip'),(40,'Poison Sting'),(41,'Twineedle'),(42,'Pin Missile'),(43,'Leer'),(44,'Bite'),(45,'Growl'),(46,'Roar'),(47,'Sing'),(48,'Supersonic'),(49,'Sonic Boom'),(50,'Disable'),(51,'Acid'),(52,'Ember'),(53,'Flamethrower'),(54,'Mist'),(55,'Water Gun'),(56,'Hydro Pump'),(57,'Surf'),(58,'Ice Beam'),(59,'Blizzard'),(60,'Psybeam'),(61,'Bubble Beam'),(62,'Aurora Beam'),(63,'Hyper Beam'),(64,'Peck'),(65,'Drill Peck'),(66,'Submission'),(67,'Low Kick'),(68,'Counter'),(69,'Seismic Toss'),(70,'Strength'),(71,'Absorb'),(72,'Mega Drain'),(73,'Leech Seed'),(74,'Growth'),(75,'Razor Leaf'),(76,'Solar Beam'),(77,'Poison Powder'),(78,'Stun Spore'),(79,'Sleep Powder'),(80,'Petal Dance'),(81,'String Shot'),(82,'Dragon Rage'),(83,'Fire Spin'),(84,'Thunder Shock'),(85,'Thunderbolt'),(86,'Thunder Wave'),(87,'Thunder'),(88,'Rock Throw'),(89,'Earthquake'),(90,'Fissure'),(91,'Dig'),(92,'Toxic'),(93,'Confusion'),(94,'Psychic'),(95,'Hypnosis'),(96,'Meditate'),(97,'Agility'),(98,'Quick Attack'),(99,'Rage'),(100,'Teleport'),(101,'Night Shade'),(102,'Mimic'),(103,'Screech'),(104,'Double Team'),(105,'Recover'),(106,'Harden'),(107,'Minimize'),(108,'Smokescreen'),(109,'Confuse Ray'),(110,'Withdraw'),(111,'Defense Curl'),(112,'Barrier'),(113,'Light Screen'),(114,'Haze'),(115,'Reflect'),(116,'Focus Energy'),(117,'Bide'),(118,'Metronome'),(119,'Mirror Move'),(120,'Self-Destruct'),(121,'Egg Bomb'),(122,'Lick'),(123,'Smog'),(124,'Sludge'),(125,'Bone Club'),(126,'Fire Blast'),(127,'Waterfall'),(128,'Clamp'),(129,'Swift'),(130,'Skull Bash'),(131,'Spike Cannon'),(132,'Constrict'),(133,'Amnesia'),(134,'Kinesis'),(135,'Soft-Boiled'),(136,'High Jump Kick'),(137,'Glare'),(138,'Dream Eater'),(139,'Poison Gas'),(140,'Barrage'),(141,'Leech Life'),(142,'Lovely Kiss'),(143,'Sky Attack'),(144,'Transform'),(145,'Bubble'),(146,'Dizzy Punch'),(147,'Spore'),(148,'Flash'),(149,'Psywave'),(150,'Splash'),(151,'Acid Armor'),(152,'Crabhammer'),(153,'Explosion'),(154,'Fury Swipes'),(155,'Bonemerang'),(156,'Rest'),(157,'Rock Slide'),(158,'Hyper Fang'),(159,'Sharpen'),(160,'Conversion'),(161,'Tri Attack'),(162,'Super Fang'),(163,'Slash'),(164,'Substitute'),(165,'Struggle'),(166,'Sketch'),(167,'Triple Kick'),(168,'Thief'),(169,'Spider Web'),(170,'Mind Reader'),(171,'Nightmare'),(172,'Flame Wheel'),(173,'Snore'),(174,'Curse'),(175,'Flail'),(176,'Conversion 2'),(177,'Aeroblast'),(178,'Cotton Spore'),(179,'Reversal'),(180,'Spite'),(181,'Powder Snow'),(182,'Protect'),(183,'Mach Punch'),(184,'Scary Face'),(185,'Feint Attack'),(186,'Sweet Kiss'),(187,'Belly Drum'),(188,'Sludge Bomb'),(189,'Mud-Slap'),(190,'Octazooka'),(191,'Spikes'),(192,'Zap Cannon'),(193,'Foresight'),(194,'Destiny Bond'),(195,'Perish Song'),(196,'Icy Wind'),(197,'Detect'),(198,'Bone Rush'),(199,'Lock-On'),(200,'Outrage'),(201,'Sandstorm'),(202,'Giga Drain'),(203,'Endure'),(204,'Charm'),(205,'Rollout'),(206,'False Swipe'),(207,'Swagger'),(208,'Milk Drink'),(209,'Spark'),(210,'Fury Cutter'),(211,'Steel Wing'),(212,'Mean Look'),(213,'Attract'),(214,'Sleep Talk'),(215,'Heal Bell'),(216,'Return'),(217,'Present'),(218,'Frustration'),(219,'Safeguard'),(220,'Pain Split'),(221,'Sacred Fire'),(222,'Magnitude'),(223,'Dynamic Punch'),(224,'Megahorn'),(225,'Dragon Breath'),(226,'Baton Pass'),(227,'Encore'),(228,'Pursuit'),(229,'Rapid Spin'),(230,'Sweet Scent'),(231,'Iron Tail'),(232,'Metal Claw'),(233,'Vital Throw'),(234,'Morning Sun'),(235,'Synthesis'),(236,'Moonlight'),(237,'Hidden Power'),(238,'Cross Chop'),(239,'Twister'),(240,'Rain Dance'),(241,'Sunny Day'),(242,'Crunch'),(243,'Mirror Coat'),(244,'Psych Up'),(245,'Extreme Speed'),(246,'Ancient Power'),(247,'Shadow Ball'),(248,'Future Sight'),(249,'Rock Smash'),(250,'Whirlpool'),(251,'Beat Up'),(252,'Fake Out'),(253,'Uproar'),(254,'Stockpile'),(255,'Spit Up'),(256,'Swallow'),(257,'Heat Wave'),(258,'Hail'),(259,'Torment'),(260,'Flatter'),(261,'Will-O-Wisp'),(262,'Memento'),(263,'Facade'),(264,'Focus Punch'),(265,'Smelling Salts'),(266,'Follow Me'),(267,'Nature Power'),(268,'Charge'),(269,'Taunt'),(270,'Helping Hand'),(271,'Trick'),(272,'Role Play'),(273,'Wish'),(274,'Assist'),(275,'Ingrain'),(276,'Superpower'),(277,'Magic Coat'),(278,'Recycle'),(279,'Revenge'),(280,'Brick Break'),(281,'Yawn'),(282,'Knock Off'),(283,'Endeavor'),(284,'Eruption'),(285,'Skill Swap'),(286,'Imprison'),(287,'Refresh'),(288,'Grudge'),(289,'Snatch'),(290,'Secret Power'),(291,'Dive'),(292,'Arm Thrust'),(293,'Camouflage'),(294,'Tail Glow'),(295,'Luster Purge'),(296,'Mist Ball'),(297,'Feather Dance'),(298,'Teeter Dance'),(299,'Blaze Kick'),(300,'Mud Sport'),(301,'Ice Ball'),(302,'Needle Arm'),(303,'Slack Off'),(304,'Hyper Voice'),(305,'Poison Fang'),(306,'Crush Claw'),(307,'Blast Burn'),(308,'Hydro Cannon'),(309,'Meteor Mash'),(310,'Astonish'),(311,'Weather Ball'),(312,'Aromatherapy'),(313,'Fake Tears'),(314,'Air Cutter'),(315,'Overheat'),(316,'Odor Sleuth'),(317,'Rock Tomb'),(318,'Silver Wind'),(319,'Metal Sound'),(320,'Grass Whistle'),(321,'Tickle'),(322,'Cosmic Power'),(323,'Water Spout'),(324,'Signal Beam'),(325,'Shadow Punch'),(326,'Extrasensory'),(327,'Sky Uppercut'),(328,'Sand Tomb'),(329,'Sheer Cold'),(330,'Muddy Water'),(331,'Bullet Seed'),(332,'Aerial Ace'),(333,'Icicle Spear'),(334,'Iron Defense'),(335,'Block'),(336,'Howl'),(337,'Dragon Claw'),(338,'Frenzy Plant'),(339,'Bulk Up'),(340,'Bounce'),(341,'Mud Shot'),(342,'Poison Tail'),(343,'Covet'),(344,'Volt Tackle'),(345,'Magical Leaf'),(346,'Water Sport'),(347,'Calm Mind'),(348,'Leaf Blade'),(349,'Dragon Dance'),(350,'Rock Blast'),(351,'Shock Wave'),(352,'Water Pulse'),(353,'Doom Desire'),(354,'Psycho Boost'),(355,'Roost'),(356,'Gravity'),(357,'Miracle Eye'),(358,'Wake-Up Slap'),(359,'Hammer Arm'),(360,'Gyro Ball'),(361,'Healing Wish'),(362,'Brine'),(363,'Natural Gift'),(364,'Feint'),(365,'Pluck'),(366,'Tailwind'),(367,'Acupressure'),(368,'Metal Burst'),(369,'U-turn'),(370,'Close Combat'),(371,'Payback'),(372,'Assurance'),(373,'Embargo'),(374,'Fling'),(375,'Psycho Shift'),(376,'Trump Card'),(377,'Heal Block'),(378,'Wring Out'),(379,'Power Trick'),(380,'Gastro Acid'),(381,'Lucky Chant'),(382,'Me First'),(383,'Copycat'),(384,'Power Swap'),(385,'Guard Swap'),(386,'Punishment'),(387,'Last Resort'),(388,'Worry Seed'),(389,'Sucker Punch'),(390,'Toxic Spikes'),(391,'Heart Swap'),(392,'Aqua Ring'),(393,'Magnet Rise'),(394,'Flare Blitz'),(395,'Force Palm'),(396,'Aura Sphere'),(397,'Rock Polish'),(398,'Poison Jab'),(399,'Dark Pulse'),(400,'Night Slash'),(401,'Aqua Tail'),(402,'Seed Bomb'),(403,'Air Slash'),(404,'X-Scissor'),(405,'Bug Buzz'),(406,'Dragon Pulse'),(407,'Dragon Rush'),(408,'Power Gem'),(409,'Drain Punch'),(410,'Vacuum Wave'),(411,'Focus Blast'),(412,'Energy Ball'),(413,'Brave Bird'),(414,'Earth Power'),(415,'Switcheroo'),(416,'Giga Impact'),(417,'Nasty Plot'),(418,'Bullet Punch'),(419,'Avalanche'),(420,'Ice Shard'),(421,'Shadow Claw'),(422,'Thunder Fang'),(423,'Ice Fang'),(424,'Fire Fang'),(425,'Shadow Sneak'),(426,'Mud Bomb'),(427,'Psycho Cut'),(428,'Zen Headbutt'),(429,'Mirror Shot'),(430,'Flash Cannon'),(431,'Rock Climb'),(432,'Defog'),(433,'Trick Room'),(434,'Draco Meteor'),(435,'Discharge'),(436,'Lava Plume'),(437,'Leaf Storm'),(438,'Power Whip'),(439,'Rock Wrecker'),(440,'Cross Poison'),(441,'Gunk Shot'),(442,'Iron Head'),(443,'Magnet Bomb'),(444,'Stone Edge'),(445,'Captivate'),(446,'Stealth Rock'),(447,'Grass Knot'),(448,'Chatter'),(449,'Judgment'),(450,'Bug Bite'),(451,'Charge Beam'),(452,'Wood Hammer'),(453,'Aqua Jet'),(454,'Attack Order'),(455,'Defend Order'),(456,'Heal Order'),(457,'Head Smash'),(458,'Double Hit'),(459,'Roar of Time'),(460,'Spacial Rend'),(461,'Lunar Dance'),(462,'Crush Grip'),(463,'Magma Storm'),(464,'Dark Void'),(465,'Seed Flare'),(466,'Ominous Wind'),(467,'Shadow Force'),(468,'Hone Claws'),(469,'Wide Guard'),(470,'Guard Split'),(471,'Power Split'),(472,'Wonder Room'),(473,'Psyshock'),(474,'Venoshock'),(475,'Autotomize'),(476,'Rage Powder'),(477,'Telekinesis'),(478,'Magic Room'),(479,'Smack Down'),(480,'Storm Throw'),(481,'Flame Burst'),(482,'Sludge Wave'),(483,'Quiver Dance'),(484,'Heavy Slam'),(485,'Synchronoise'),(486,'Electro Ball'),(487,'Soak'),(488,'Flame Charge'),(489,'Coil'),(490,'Low Sweep'),(491,'Acid Spray'),(492,'Foul Play'),(493,'Simple Beam'),(494,'Entrainment'),(495,'After You'),(496,'Round'),(497,'Echoed Voice'),(498,'Chip Away'),(499,'Clear Smog'),(500,'Stored Power'),(501,'Quick Guard'),(502,'Ally Switch'),(503,'Scald'),(504,'Shell Smash'),(505,'Heal Pulse'),(506,'Hex'),(507,'Sky Drop'),(508,'Shift Gear'),(509,'Circle Throw'),(510,'Incinerate'),(511,'Quash'),(512,'Acrobatics'),(513,'Reflect Type'),(514,'Retaliate'),(515,'Final Gambit'),(516,'Bestow'),(517,'Inferno'),(518,'Water Pledge'),(519,'Fire Pledge'),(520,'Grass Pledge'),(521,'Volt Switch'),(522,'Struggle Bug'),(523,'Bulldoze'),(524,'Frost Breath'),(525,'Dragon Tail'),(526,'Work Up'),(527,'Electroweb'),(528,'Wild Charge'),(529,'Drill Run'),(530,'Dual Chop'),(531,'Heart Stamp'),(532,'Horn Leech'),(533,'Sacred Sword'),(534,'Razor Shell'),(535,'Heat Crash'),(536,'Leaf Tornado'),(537,'Steamroller'),(538,'Cotton Guard'),(539,'Night Daze'),(540,'Psystrike'),(541,'Tail Slap'),(542,'Hurricane'),(543,'Head Charge'),(544,'Gear Grind'),(545,'Searing Shot'),(546,'Techno Blast'),(547,'Relic Song'),(548,'Secret Sword'),(549,'Glaciate'),(550,'Bolt Strike'),(551,'Blue Flare'),(552,'Fiery Dance'),(553,'Freeze Shock'),(554,'Ice Burn'),(555,'Snarl'),(556,'Icicle Crash'),(557,'V-create'),(558,'Fusion Flare'),(559,'Fusion Bolt'),(560,'Flying Press'),(561,'Mat Block'),(562,'Belch'),(563,'Rototiller'),(564,'Sticky Web'),(565,'Fell Stinger'),(566,'Phantom Force'),(567,'Trick-or-Treat'),(568,'Noble Roar'),(569,'Ion Deluge'),(570,'Parabolic Charge'),(571,'Forest\'s Curse'),(572,'Petal Blizzard'),(573,'Freeze-Dry'),(574,'Disarming Voice'),(575,'Parting Shot'),(576,'Topsy-Turvy'),(577,'Draining Kiss'),(578,'Crafty Shield'),(579,'Flower Shield'),(580,'Grassy Terrain'),(581,'Misty Terrain'),(582,'Electrify'),(583,'Play Rough'),(584,'Fairy Wind'),(585,'Moonblast'),(586,'Boomburst'),(587,'Fairy Lock'),(588,'King\'s Shield'),(589,'Play Nice'),(590,'Confide'),(594,'Water Shuriken'),(595,'Mystical Fire'),(596,'Spiky Shield'),(597,'Aromatic Mist'),(598,'Eerie Impulse'),(599,'Venom Drench'),(600,'Powder'),(601,'Geomancy'),(602,'Magnetic Flux'),(603,'Happy Hour'),(604,'Electric Terrain'),(605,'Dazzling Gleam'),(606,'Celebration'),(608,'Baby-Doll Eyes'),(609,'Nuzzle'),(611,'Infestation'),(612,'Power-Up Punch'),(613,'Oblivion Wing'),(616,'Land\'s Wrath'),(617,'Diamond Storm'),(618,'Hyperspace Hole'),(619,'Steam Eruption');
/*!40000 ALTER TABLE `PokemonSkills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PokemonToPokemonSkills`
--

DROP TABLE IF EXISTS `PokemonToPokemonSkills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `PokemonToPokemonSkills` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PokemonId` int(11) NOT NULL,
  `PokemonSkillId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `PokemonSkillId` (`PokemonSkillId`),
  KEY `PokemonId` (`PokemonId`),
  CONSTRAINT `PokemonToPokemonSkills_ibfk_1` FOREIGN KEY (`PokemonSkillId`) REFERENCES `PokemonSkills` (`Id`),
  CONSTRAINT `PokemonToPokemonSkills_ibfk_2` FOREIGN KEY (`PokemonId`) REFERENCES `Pokemons` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PokemonToPokemonSkills`
--

LOCK TABLES `PokemonToPokemonSkills` WRITE;
/*!40000 ALTER TABLE `PokemonToPokemonSkills` DISABLE KEYS */;
INSERT INTO `PokemonToPokemonSkills` VALUES (1,1,33);
/*!40000 ALTER TABLE `PokemonToPokemonSkills` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PokemonToPokemonTypes`
--

DROP TABLE IF EXISTS `PokemonToPokemonTypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `PokemonToPokemonTypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PokemonId` int(11) NOT NULL,
  `PokemonTypeId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `PokemonTypeId` (`PokemonTypeId`),
  KEY `PokemonId` (`PokemonId`),
  CONSTRAINT `PokemonToPokemonTypes_ibfk_1` FOREIGN KEY (`PokemonTypeId`) REFERENCES `PokemonTypes` (`Id`),
  CONSTRAINT `PokemonToPokemonTypes_ibfk_2` FOREIGN KEY (`PokemonId`) REFERENCES `Pokemons` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PokemonToPokemonTypes`
--

LOCK TABLES `PokemonToPokemonTypes` WRITE;
/*!40000 ALTER TABLE `PokemonToPokemonTypes` DISABLE KEYS */;
INSERT INTO `PokemonToPokemonTypes` VALUES (1,1,12),(2,1,4);
/*!40000 ALTER TABLE `PokemonToPokemonTypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PokemonTypes`
--

DROP TABLE IF EXISTS `PokemonTypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `PokemonTypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PokemonTypes`
--

LOCK TABLES `PokemonTypes` WRITE;
/*!40000 ALTER TABLE `PokemonTypes` DISABLE KEYS */;
INSERT INTO `PokemonTypes` VALUES (1,'Normal'),(2,'Fighting'),(3,'Flying'),(4,'Poison'),(5,'Ground'),(6,'Rock'),(7,'Bug'),(8,'Ghost'),(9,'Steel'),(10,'Fire'),(11,'Water'),(12,'Grass'),(13,'Electric'),(14,'Psychic'),(15,'Ice'),(16,'Dragon'),(17,'Dark'),(18,'Fairy');
/*!40000 ALTER TABLE `PokemonTypes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-04 15:19:04
