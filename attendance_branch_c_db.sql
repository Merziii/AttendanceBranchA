-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 13, 2026 at 02:31 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance_branch_c_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `id` int(11) NOT NULL,
  `StudentID` varchar(20) NOT NULL,
  `StudentName` varchar(100) NOT NULL,
  `BranchCode` char(1) NOT NULL,
  `Date` date NOT NULL DEFAULT curdate(),
  `Status` varchar(10) NOT NULL DEFAULT 'Present',
  `Synced` tinyint(4) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id`, `StudentID`, `StudentName`, `BranchCode`, `Date`, `Status`, `Synced`) VALUES
(1, '2024-31', 'Renz Macaraeg', 'C', '2026-03-09', 'Present', 1),
(2, '2024-32', 'Hazel Concepcion', 'C', '2026-03-09', 'Present', 1),
(3, '2024-33', 'Jomar Buenaventura', 'C', '2026-03-09', 'Absent', 1),
(4, '2024-34', 'Melissa Aguilar', 'C', '2026-03-10', 'Absent', 1),
(5, '2024-35', 'Nico Velasquez', 'C', '2026-03-10', 'Present', 1),
(6, '2024-36', 'Patricia Sta. Ana', 'C', '2026-03-10', 'Present', 1),
(7, '2024-37', 'Alvin Delos Reyes', 'C', '2026-03-11', 'Present', 1),
(8, '2024-38', 'Charmaine Vidal', 'C', '2026-03-11', 'Absent', 1),
(9, '2024-39', 'Ronnie Espiritu', 'C', '2026-03-11', 'Present', 1),
(10, '2024-40', 'Glaiza Mendez', 'C', '2026-03-12', 'Present', 1),
(11, '2024-41', 'Ivan Tablante', 'C', '2026-03-12', 'Present', 1),
(12, '2024-42', 'Shiela Gatdula', 'C', '2026-03-13', 'Present', 0),
(13, '2024-43', 'Ronel Padilla', 'C', '2026-03-13', 'Absent', 0),
(14, '2024-44', 'Lyka Bernardo', 'C', '2026-03-13', 'Present', 0),
(15, '2024-45', 'Daryl Quizon', 'C', '2026-03-13', 'Present', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `no_dup` (`StudentID`,`BranchCode`,`Date`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
