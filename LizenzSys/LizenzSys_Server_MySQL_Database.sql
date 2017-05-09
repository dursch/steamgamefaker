SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE IF NOT EXISTS `licence` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `mkey` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `hwid` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '0',
  `time` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '0',
  `till` varchar(50) COLLATE latin1_general_ci NOT NULL DEFAULT '0',
  `banned` tinyint(1) NOT NULL DEFAULT '0',
  `last_check` varchar(50) COLLATE latin1_general_ci NOT NULL,
  `tool` varchar(50) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci AUTO_INCREMENT=3 ;