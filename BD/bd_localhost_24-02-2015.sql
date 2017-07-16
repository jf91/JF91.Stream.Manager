-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.9 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for sm
CREATE DATABASE IF NOT EXISTS `sm` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sm`;


-- Dumping structure for table sm.projects
CREATE TABLE IF NOT EXISTS `projects` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.projects: ~3 rows (approximately)
DELETE FROM `projects`;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` (`ID`, `name`) VALUES
	(4, 'freesoccer'),
	(5, 'MegaTVHD'),
	(6, 'goalshour');
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;


-- Dumping structure for table sm.streamers
CREATE TABLE IF NOT EXISTS `streamers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `page_url` varchar(100) NOT NULL DEFAULT '0',
  `player_url` varchar(100) NOT NULL DEFAULT '0',
  `token` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers: ~1 rows (approximately)
DELETE FROM `streamers`;
/*!40000 ALTER TABLE `streamers` DISABLE KEYS */;
INSERT INTO `streamers` (`ID`, `name`, `page_url`, `player_url`, `token`) VALUES
	(2, 'HDCast', 'Pafina', 'Player', 'Token');
/*!40000 ALTER TABLE `streamers` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_channels
CREATE TABLE IF NOT EXISTS `streamers_channels` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `rmtp_url` varchar(100) NOT NULL DEFAULT '0',
  `streamer_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `stream_id` (`streamer_id`),
  CONSTRAINT `stream_id` FOREIGN KEY (`streamer_id`) REFERENCES `streamers` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_channels: ~3 rows (approximately)
DELETE FROM `streamers_channels`;
/*!40000 ALTER TABLE `streamers_channels` DISABLE KEYS */;
INSERT INTO `streamers_channels` (`ID`, `name`, `rmtp_url`, `streamer_id`) VALUES
	(5, 'channel 1', 'rmtp', 2),
	(6, 'channel 2', 'rmtpd2', 2),
	(7, 'channel 3', 'rmtpdn3', 2);
/*!40000 ALTER TABLE `streamers_channels` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_channels_freesoccer
CREATE TABLE IF NOT EXISTS `streamers_channels_freesoccer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `rmtp_url` varchar(100) NOT NULL DEFAULT '0',
  `caster_rmtp` varchar(500) DEFAULT NULL,
  `streamer_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `streamer_id` (`streamer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_channels_freesoccer: ~25 rows (approximately)
DELETE FROM `streamers_channels_freesoccer`;
/*!40000 ALTER TABLE `streamers_channels_freesoccer` DISABLE KEYS */;
INSERT INTO `streamers_channels_freesoccer` (`ID`, `name`, `rmtp_url`, `caster_rmtp`, `streamer_id`) VALUES
	(3, 'Channel 1', 'rtmpe://46.246.124.29:1935/l/llive1', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(4, 'Channel 2', 'rtmpe://46.246.29.150:1935/l/llive2', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(5, 'Channel 3', 'rtmpe://46.246.124.29:1935/l/llive3', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(6, 'Channel 4', 'rtmpe://46.246.124.27:1935/l/llive4', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(7, 'Channel 5', 'rtmpe://46.246.124.26:1935/l/llive5', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(8, 'Channel 6', 'rtmpe://46.246.124.87:1935/l/llive6', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(9, 'Channel 7', 'rtmpe://46.246.124.30:1935/l/llive7', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(10, 'Channel 8', 'rtmpe://46.246.124.87:1935/l/llive8', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(11, 'Channel 9', 'rtmpe://46.246.124.22:1935/l/llive9', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(12, 'Channel 10', 'rtmpe://46.246.29.160:1935/l/llive10', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(13, 'Channel 11', 'rtmpe://46.246.124.31:1935/l/llive11', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(14, 'Channel 12', 'rtmpe://46.246.124.86:1935/l/llive12', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(15, 'Channel 13', 'rtmpe://46.246.29.162:1935/l/llive13', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(16, 'Channel 14', 'rtmpe://46.246.29.160:1935/l/llive14', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(17, 'Channel 15', 'rtmpe://46.246.124.25:1935/l/llive15', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(18, 'Sky Sports 1', 'rtmpe://46.246.124.3:1935/l/sskys1', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(19, 'Sky Sports 2', 'rtmpe://46.246.124.22:1935/l/sskys2', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(20, 'Sky Sports 3', 'rtmpe://46.246.124.3:1935/l/sskys3', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(21, 'Sky Sports 4', 'rtmpe://46.246.124.86:1935/l/sskys4', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(22, 'Sky Sports 5', 'rtmpe://46.246.29.162:1935/l/sskys5', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(23, 'Sky Sports F1', 'rtmpe://46.246.124.93:1935/l/sskysf1', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(24, 'Sky Sports News', 'rtmpe://46.246.124.29:1935/l/sskysn', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(25, 'Eurosport', 'rtmpe://46.246.124.3:1935/l/sesp', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(26, 'Eurosport 2', 'rtmpe://46.246.124.29:1935/l/sesp2', 'rtmp://online.pxstream.tv/loadbalance/', 1),
	(27, 'BeIN Sports HD', 'rtmpe://46.246.124.93:1935/l/sbein11', 'rtmp://online.pxstream.tv/loadbalance/', 1);
/*!40000 ALTER TABLE `streamers_channels_freesoccer` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_channels_goalshour
CREATE TABLE IF NOT EXISTS `streamers_channels_goalshour` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `rmtp_url` varchar(100) NOT NULL DEFAULT '0',
  `caster_rmtp` varchar(500) NOT NULL DEFAULT '0',
  `streamer_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_channels_goalshour: ~15 rows (approximately)
DELETE FROM `streamers_channels_goalshour`;
/*!40000 ALTER TABLE `streamers_channels_goalshour` DISABLE KEYS */;
INSERT INTO `streamers_channels_goalshour` (`ID`, `name`, `rmtp_url`, `caster_rmtp`, `streamer_id`) VALUES
	(1, 'Channel1', 'rtmpe://46.246.124.89:1935/l/llive1', 'rtmp://31.220.0.206/live', 1),
	(2, 'Channel2', 'rtmpe://46.246.124.87:1935/l/llive2', 'rtmp://31.220.0.206/live', 1),
	(3, 'Channel3', 'rtmpe://46.246.124.87:1935/l/llive3', 'rtmp://31.220.0.206/live', 1),
	(4, 'Channel4', 'rtmpe://46.246.124.87:1935/l/llive4', 'rtmp://31.220.0.206/live', 1),
	(5, 'Channel5', 'rtmpe://46.246.124.89:1935/l/llive5', 'rtmp://31.220.0.206/live', 1),
	(6, 'Channel6', 'rtmpe://46.246.124.87:1935/l/llive6', 'rtmp://31.220.0.206/live', 1),
	(7, 'Channel7', 'rtmpe://46.246.124.87:1935/l/llive7', 'rtmp://31.220.0.206/live', 1),
	(8, 'Channel8', 'rtmpe://46.246.124.87:1935/l/llive8', 'rtmp://31.220.0.206/live', 1),
	(9, 'Channel9', 'rtmpe://46.246.124.87:1935/l/llive9', 'rtmp://31.220.0.206/live', 1),
	(10, 'Channel10', 'rtmpe://46.246.124.87:1935/l/llive10', 'rtmp://31.220.0.206/live', 1),
	(11, 'Channel11', 'rtmpe://46.246.124.87:1935/l/llive11', 'rtmp://31.220.0.206/live', 1),
	(12, 'Channel12', 'rtmpe://46.246.124.87:1935/l/llive12', 'rtmp://31.220.0.206/live', 1),
	(13, 'Channel13', 'rtmpe://46.246.124.87:1935/l/llive13', 'rtmp://31.220.0.206/live', 1),
	(14, 'Channel14', 'rtmpe://46.246.124.87:1935/l/llive14', 'rtmp://31.220.0.206/live', 1),
	(15, 'Channel15', 'rtmpe://46.246.124.87:1935/l/llive15', 'rtmp://31.220.0.206/live', 1);
/*!40000 ALTER TABLE `streamers_channels_goalshour` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_channels_megatvhd
CREATE TABLE IF NOT EXISTS `streamers_channels_megatvhd` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `rmtp_url` varchar(100) NOT NULL DEFAULT '0',
  `caster_rmtp` varchar(500) NOT NULL DEFAULT '0',
  `streamer_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_channels_megatvhd: ~24 rows (approximately)
DELETE FROM `streamers_channels_megatvhd`;
/*!40000 ALTER TABLE `streamers_channels_megatvhd` DISABLE KEYS */;
INSERT INTO `streamers_channels_megatvhd` (`ID`, `name`, `rmtp_url`, `caster_rmtp`, `streamer_id`) VALUES
	(1, 'Channel1', 'rtmpe://46.246.124.89:1935/l/llive1', 'rtmp://chucky.megatvhd.tv/live', 1),
	(2, 'Channel2', 'rtmpe://46.246.124.87:1935/l/llive2', 'rtmp://chucky.megatvhd.tv/live', 1),
	(3, 'Channel3', 'rtmpe://46.246.124.89:1935/l/llive3', 'rtmp://chucky.megatvhd.tv/live', 1),
	(4, 'Channel4', 'rtmpe://46.246.124.89:1935/l/llive4', 'rtmp://chucky.megatvhd.tv/live', 1),
	(5, 'Channel5', 'rtmpe://46.246.124.89:1935/l/llive5', 'rtmp://chucky.megatvhd.tv/live', 1),
	(6, 'Channel6', 'rtmpe://46.246.124.87:1935/l/llive6', 'rtmp://chucky.megatvhd.tv/live', 1),
	(7, 'Channel7', 'rtmpe://46.246.124.87:1935/l/llive7', 'rtmp://chucky.megatvhd.tv/live', 1),
	(8, 'Channel8', 'rtmpe://46.246.124.87:1935/l/llive8', 'rtmp://chucky.megatvhd.tv/live', 1),
	(9, 'Channel9', 'rtmpe://46.246.124.87:1935/l/llive9', 'rtmp://chucky.megatvhd.tv/live', 1),
	(10, 'Channel10', 'rtmpe://46.246.124.87:1935/l/llive10', 'rtmp://chucky.megatvhd.tv/live', 1),
	(11, 'Channel11', 'rtmpe://46.246.124.87:1935/l/llive11', 'rtmp://chucky.megatvhd.tv/live', 1),
	(12, 'Channel12', 'rtmpe://46.246.124.89:1935/l/llive12', 'rtmp://chucky.megatvhd.tv/live', 1),
	(13, 'Channel13', 'rtmpe://46.246.124.87:1935/l/llive13', 'rtmp://chucky.megatvhd.tv/live', 1),
	(14, 'Channel14', 'rtmpe://46.246.124.87:1935/l/llive14', 'rtmp://chucky.megatvhd.tv/live', 1),
	(15, 'Channel15', 'rtmpe://46.246.124.87:1935/l/llive15', 'rtmp://chucky.megatvhd.tv/live', 1),
	(16, 'Channel1', 'rtmp://207.244.76.206/iguide/3gr5gxx65akwo94 ', 'rtmp://31.220.0.206/live', 2),
	(17, 'EuroSport1', 'rtmp://s1.stream-server.org:1935/live/eurosport.stream', 'rtmp://chucky.megatvhd.tv/live', 3),
	(18, 'ORF Eins', 'rtmp://s4.stream-server.org:1935/live/orfeins.stream', 'rtmp://31.220.0.206/live', 3),
	(19, 'ORF', 'rtmp://s4.stream-server.org:1935/live/orf1.stream', 'rtmp://chucky.megatvhd.tv/live', 1),
	(20, 'Sky Sports1', 'rtmp://rtmp.popeoftheplayers.pw:1935/redirect47', 'rtmp://chucky.megatvhd.tv/live', 4),
	(21, 'Canal+Liga', 'rtmp://89.248.171.90:443/liverepeater/4', 'rtmp://chucky.megatvhd.tv/live', 4),
	(22, 'Sky Sports 24h(ITALY)', 'rtmp://89.248.171.90:443/liverepeater/3', 'rtmp://chucky.megatvhd.tv/live', 4),
	(23, '', '', '', 1),
	(24, '', '', '', 1);
/*!40000 ALTER TABLE `streamers_channels_megatvhd` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_freesoccer
CREATE TABLE IF NOT EXISTS `streamers_freesoccer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `page_url` varchar(100) NOT NULL DEFAULT '0',
  `player_url` varchar(100) NOT NULL,
  `token` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_freesoccer: ~1 rows (approximately)
DELETE FROM `streamers_freesoccer`;
/*!40000 ALTER TABLE `streamers_freesoccer` DISABLE KEYS */;
INSERT INTO `streamers_freesoccer` (`ID`, `name`, `page_url`, `player_url`, `token`) VALUES
	(1, 'HDCast (StreamKing)', 'http://www.hdcast.org/embedlive4.php', 'http://hdcast.org/eplayer.swf', 'Fo5_n0w?U.rA6l3-70w47ch');
/*!40000 ALTER TABLE `streamers_freesoccer` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_goalshour
CREATE TABLE IF NOT EXISTS `streamers_goalshour` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `page_url` varchar(100) NOT NULL DEFAULT '0',
  `player_url` varchar(100) NOT NULL DEFAULT '0',
  `token` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_goalshour: ~1 rows (approximately)
DELETE FROM `streamers_goalshour`;
/*!40000 ALTER TABLE `streamers_goalshour` DISABLE KEYS */;
INSERT INTO `streamers_goalshour` (`ID`, `name`, `page_url`, `player_url`, `token`) VALUES
	(1, 'HDCAST - Streamking', 'http://www.hdcast.org/embedlive4.php', 'http://hdcast.org/eplayer.swf', 'Fo5_n0w?U.rA6l3-70w47ch');
/*!40000 ALTER TABLE `streamers_goalshour` ENABLE KEYS */;


-- Dumping structure for table sm.streamers_megatvhd
CREATE TABLE IF NOT EXISTS `streamers_megatvhd` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `page_url` varchar(100) NOT NULL DEFAULT '0',
  `player_url` varchar(100) NOT NULL DEFAULT '0',
  `token` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.streamers_megatvhd: ~3 rows (approximately)
DELETE FROM `streamers_megatvhd`;
/*!40000 ALTER TABLE `streamers_megatvhd` DISABLE KEYS */;
INSERT INTO `streamers_megatvhd` (`ID`, `name`, `page_url`, `player_url`, `token`) VALUES
	(1, 'HDCAST - Streamking', 'http://www.hdcast.org/embedlive4.php', 'http://hdcast.org/eplayer.swf', 'Fo5_n0w?U.rA6l3-70w47ch'),
	(3, 'Live Stream .tv', 'http://www.live-stream.tv', 'http://static.live-stream.tv/player/player.swf', 'a'),
	(4, 'CricHD.tv', 'http://popeoftheplayers.pw/player31.php', 'http://popeoftheplayers.pw/stylish.swf', '#atd%#$ZH');
/*!40000 ALTER TABLE `streamers_megatvhd` ENABLE KEYS */;


-- Dumping structure for table sm.website_channels
CREATE TABLE IF NOT EXISTS `website_channels` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `flash_id` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.website_channels: ~2 rows (approximately)
DELETE FROM `website_channels`;
/*!40000 ALTER TABLE `website_channels` DISABLE KEYS */;
INSERT INTO `website_channels` (`ID`, `name`, `flash_id`) VALUES
	(6, 'Channel 1', 'pocrl1'),
	(7, 'Channel 2', 'pocrl2');
/*!40000 ALTER TABLE `website_channels` ENABLE KEYS */;


-- Dumping structure for table sm.website_channels_freesoccer
CREATE TABLE IF NOT EXISTS `website_channels_freesoccer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `flash_id` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.website_channels_freesoccer: ~10 rows (approximately)
DELETE FROM `website_channels_freesoccer`;
/*!40000 ALTER TABLE `website_channels_freesoccer` DISABLE KEYS */;
INSERT INTO `website_channels_freesoccer` (`ID`, `name`, `flash_id`) VALUES
	(1, 'Channel 1', '81824185996849642121'),
	(2, 'Channel 2', '46312298391277833568'),
	(3, 'Channel 3', '72485691191834975514'),
	(4, 'Channel 4', '96442813796179844998'),
	(5, 'Channel 5', '82852126489189177588'),
	(6, 'Channel 6', '23454211812867549865'),
	(7, 'Channel 7', '73119573587452264643'),
	(8, 'Channel 8', '24276963449695817856'),
	(9, 'Channel 9', '12967789768545516336'),
	(10, 'Channel 10', '38289469244775915831');
/*!40000 ALTER TABLE `website_channels_freesoccer` ENABLE KEYS */;


-- Dumping structure for table sm.website_channels_goalshour
CREATE TABLE IF NOT EXISTS `website_channels_goalshour` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `flash_id` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.website_channels_goalshour: ~15 rows (approximately)
DELETE FROM `website_channels_goalshour`;
/*!40000 ALTER TABLE `website_channels_goalshour` DISABLE KEYS */;
INSERT INTO `website_channels_goalshour` (`ID`, `name`, `flash_id`) VALUES
	(1, 'Channel18', '/yolo_ch1'),
	(2, 'Channel19', '/yolo_ch2'),
	(3, 'Channel20', '/yolo_ch3'),
	(4, 'Channel21', '/yolo_ch4'),
	(6, 'Channel22', '/yolo_ch5'),
	(7, 'Channel23', '/yolo_ch6'),
	(8, 'Channel24', '/yolo_ch7'),
	(9, 'Channel25', '/yolo_ch8'),
	(10, 'Channel26', '/yolo_ch9'),
	(11, 'Channel27', '/yolo_ch10'),
	(12, 'Channel28', '/yolo_ch11'),
	(13, 'Channel29', '/yolo_ch12'),
	(14, 'Channel30', '/yolo_ch13'),
	(15, 'Channel31', '/yolo_ch14'),
	(16, 'Channel32', '/yolo_ch15');
/*!40000 ALTER TABLE `website_channels_goalshour` ENABLE KEYS */;


-- Dumping structure for table sm.website_channels_megatvhd
CREATE TABLE IF NOT EXISTS `website_channels_megatvhd` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '0',
  `flash_id` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- Dumping data for table sm.website_channels_megatvhd: ~16 rows (approximately)
DELETE FROM `website_channels_megatvhd`;
/*!40000 ALTER TABLE `website_channels_megatvhd` DISABLE KEYS */;
INSERT INTO `website_channels_megatvhd` (`ID`, `name`, `flash_id`) VALUES
	(1, 'Channel18', '/yolo_ch1'),
	(2, 'Channel19', '/yolo_ch2'),
	(3, 'Channel20', '/yolo_ch3'),
	(4, 'Channel21', '/yolo_ch4'),
	(6, 'Channel22', '/yolo_ch5'),
	(7, 'Channel23', '/yolo_ch6'),
	(8, 'Channel24', '/yolo_ch7'),
	(9, 'Channel25', '/yolo_ch8'),
	(10, 'Channel26', '/yolo_ch9'),
	(11, 'Channel27', '/yolo_ch10'),
	(12, 'Channel28', '/yolo_ch11'),
	(13, 'Channel29', '/yolo_ch12'),
	(14, 'Channel30', '/yolo_ch13'),
	(15, 'Channel31', '/yolo_ch14'),
	(16, 'Channel32', '/yolo_ch15'),
	(17, 'Channel1-iguide', '3gr5gxx65akwo94 ');
/*!40000 ALTER TABLE `website_channels_megatvhd` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
