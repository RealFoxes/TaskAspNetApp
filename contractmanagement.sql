-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 05, 2020 at 07:09 PM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `contractmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `contracts`
--

CREATE TABLE `contracts` (
  `Id` int(11) NOT NULL,
  `Code` varchar(256) NOT NULL,
  `Name` varchar(256) NOT NULL,
  `Client` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `contracts`
--

INSERT INTO `contracts` (`Id`, `Code`, `Name`, `Client`) VALUES
(9, 'НеРога', 'Копыта', 'Роги и копыта');

-- --------------------------------------------------------

--
-- Table structure for table `stagecontracts`
--

CREATE TABLE `stagecontracts` (
  `Id` int(11) NOT NULL,
  `Name` varchar(256) NOT NULL,
  `DateStart` date NOT NULL,
  `DateEnd` date NOT NULL,
  `contractId` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stagecontracts`
--

INSERT INTO `stagecontracts` (`Id`, `Name`, `DateStart`, `DateEnd`, `contractId`) VALUES
(17, 'Получение копыт', '2020-10-08', '2020-10-23', 9),
(18, 'Получение рогов', '2020-10-08', '2020-10-23', 9);

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20201003180012_V1', '3.1.8'),
('20201003180814_V2', '3.1.8'),
('20201003181439_V3', '3.1.8'),
('20201003181800_V4', '3.1.8'),
('20201003182152_V5', '3.1.8'),
('20201003182554_V7', '3.1.8'),
('20201003202245_V8', '3.1.8'),
('20201003202411_V9', '3.1.8');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contracts`
--
ALTER TABLE `contracts`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `stagecontracts`
--
ALTER TABLE `stagecontracts`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_StageContracts_contractId` (`contractId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contracts`
--
ALTER TABLE `contracts`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `stagecontracts`
--
ALTER TABLE `stagecontracts`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `stagecontracts`
--
ALTER TABLE `stagecontracts`
  ADD CONSTRAINT `FK_StageContracts_Contracts_contractId` FOREIGN KEY (`contractId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
