-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 01, 2023 at 05:16 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `machine_tools`
--

-- --------------------------------------------------------

--
-- Table structure for table `machine`
--

CREATE TABLE `machine` (
  `ID` int(11) NOT NULL,
  `X_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `Y_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `Z_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `LAST_UPDATE` datetime DEFAULT NULL,
  `tool_info_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `machine`
--

INSERT INTO `machine` (`ID`, `X_OFFSET`, `Y_OFFSET`, `Z_OFFSET`, `LAST_UPDATE`, `tool_info_ID`) VALUES
(1, '0.0000', '0.0000', '80.7500', '2023-06-11 10:39:03', 4),
(2, '0.0000', '0.0000', '92.5300', '2023-06-18 17:32:25', 3),
(3, '4.0000', '0.0000', '120.2350', '2023-06-17 16:20:45', 2),
(4, '5.9620', '0.0000', '149.9300', '2023-06-18 19:31:42', 1);

-- --------------------------------------------------------

--
-- Table structure for table `magazine`
--

CREATE TABLE `magazine` (
  `ID` int(11) NOT NULL,
  `X_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `Y_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `Z_OFFSET` decimal(10,4) DEFAULT '0.0000',
  `LAST_UPDATE` datetime DEFAULT NULL,
  `tool_info_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `magazine`
--

INSERT INTO `magazine` (`ID`, `X_OFFSET`, `Y_OFFSET`, `Z_OFFSET`, `LAST_UPDATE`, `tool_info_ID`) VALUES
(1, '5.9900', '0.0000', '150.0500', '2023-06-18 18:31:42', 1),
(2, '4.0000', '0.0000', '120.2350', '2023-06-17 16:20:45', 2),
(3, '0.0000', '0.0000', '92.1234', '2023-06-18 15:32:25', 3),
(4, '0.0000', '0.0000', '80.7500', '2023-06-11 10:39:03', 4),
(5, '3.9650', '0.0000', '70.0920', '2023-06-18 12:20:34', 5);

-- --------------------------------------------------------

--
-- Table structure for table `tool_info`
--

CREATE TABLE `tool_info` (
  `ID` int(11) NOT NULL,
  `TOOL_NUMBER` int(11) NOT NULL,
  `TOOL_NAME` varchar(100) NOT NULL,
  `TOOL_TYPE` varchar(50) NOT NULL,
  `ON_MACHINE` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tool_info`
--

INSERT INTO `tool_info` (`ID`, `TOOL_NUMBER`, `TOOL_NAME`, `TOOL_TYPE`, `ON_MACHINE`) VALUES
(1, 102, 'End Mill D12', 'Milling', 'Machine 1'),
(2, 104, 'End Mill D8', 'Milling', 'Machine 2'),
(3, 201, 'Tap M10', 'Tapered', 'Machine 2'),
(4, 305, 'Drill D5.2', 'Drilling', 'Machine 1'),
(5, 435, 'Ball Nose D4', 'Milling', 'None');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `machine`
--
ALTER TABLE `machine`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_machine_offset_tool_info1_idx` (`tool_info_ID`);

--
-- Indexes for table `magazine`
--
ALTER TABLE `magazine`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_zoller_offset_tool_info_idx` (`tool_info_ID`);

--
-- Indexes for table `tool_info`
--
ALTER TABLE `tool_info`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `machine`
--
ALTER TABLE `machine`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `magazine`
--
ALTER TABLE `magazine`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tool_info`
--
ALTER TABLE `tool_info`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `machine`
--
ALTER TABLE `machine`
  ADD CONSTRAINT `fk_machine_offset_tool_info1` FOREIGN KEY (`tool_info_ID`) REFERENCES `tool_info` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `magazine`
--
ALTER TABLE `magazine`
  ADD CONSTRAINT `fk_zoller_offset_tool_info` FOREIGN KEY (`tool_info_ID`) REFERENCES `tool_info` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
