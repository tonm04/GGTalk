/*
Navicat MySQL Data Transfer

Source Server         : ccc
Source Server Version : 50527
Source Host           : localhost:3306
Source Database       : ggtalk

Target Server Type    : MYSQL
Target Server Version : 50527
File Encoding         : 65001

Date: 2016-11-30 17:26:43
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for ChatMessageRecord
-- ----------------------------
DROP TABLE IF EXISTS `ChatMessageRecord`;
CREATE TABLE `ChatMessageRecord` (
  `AutoID` bigint(20) NOT NULL AUTO_INCREMENT,
  `SpeakerID` varchar(20) NOT NULL,
  `AudienceID` varchar(20) NOT NULL,
  `IsGroupChat` bit(20) NOT NULL,
  `IsNotice` bit(20) NOT NULL,
  `Content` blob NOT NULL,
  `OccureTime` datetime NOT NULL,
  PRIMARY KEY (`AutoID`),
  KEY `IX_ChatMessageRecord` (`SpeakerID`,`AudienceID`,`OccureTime`) USING BTREE,
  KEY `IX_ChatMessageRecord_1` (`AudienceID`,`OccureTime`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for GroupFile
-- ----------------------------
DROP TABLE IF EXISTS `GroupFile`;
CREATE TABLE `GroupFile` (
  `SID` varchar(50) NOT NULL,
  `FileName` varchar(4000) NOT NULL,
  `FileLength` bigint(255) NOT NULL,
  `SenderID` varchar(50) NOT NULL,
  `SenderName` varchar(50) NULL,
  `SendDate` varchar(50) NULL,
  `GroupID` varchar(50) NOT NULL,
  `RelayFilePath` varchar(4000)  NULL,
   
  PRIMARY KEY (`SID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;


-- ----------------------------
-- Table structure for GGGroup
-- ----------------------------
DROP TABLE IF EXISTS `GGGroup`;
CREATE TABLE `GGGroup` (
  `GroupID` varchar(20) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `CreatorID` varchar(20) NOT NULL,
  `Members` varchar(4000) NOT NULL,
  `Managers` varchar(4000) NULL,
  `NoSpeak` varchar(4000) NULL,
  `CreateTime` datetime NOT NULL,
  `Version` int(255) NOT NULL,
  `Announce` varchar(200) NOT NULL,
  PRIMARY KEY (`GroupID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;





-- ----------------------------
-- Table structure for GGUser
-- ----------------------------
DROP TABLE IF EXISTS `GGUser`;
CREATE TABLE `GGUser` (
  `UserID` varchar(50) NOT NULL,
  `PasswordMD5` varchar(100) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Friends` varchar(4000) NOT NULL,
  `Signature` varchar(100) NOT NULL,
  `HeadImageIndex` int(255) NOT NULL,
  `HeadImageData` blob,
  `Groups` varchar(100) NOT NULL,
  `CreateTime` datetime NOT NULL,
  `DefaultFriendCatalog` varchar(20) NOT NULL,
  `Version` int(255) NOT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
