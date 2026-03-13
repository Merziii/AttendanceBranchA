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
-- Database: `attendance_branch_b_db`
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
(1, '2024-16', 'Sofia Bautista', 'B', '2026-03-09', 'Present', 1),
(2, '2024-17', 'Miguel Hernandez', 'B', '2026-03-09', 'Present', 1),
(3, '2024-18', 'Tricia Evangelista', 'B', '2026-03-09', 'Absent', 1),
(4, '2024-19', 'Lance Ocampo', 'B', '2026-03-10', 'Present', 1),
(5, '2024-20', 'Diane Ferrer', 'B', '2026-03-10', 'Present', 1),
(6, '2024-21', 'Kevin Abad', 'B', '2026-03-10', 'Absent', 1),
(7, '2024-22', 'Rachel Domingo', 'B', '2026-03-11', 'Absent', 1),
(8, '2024-23', 'Erwin Salazar', 'B', '2026-03-11', 'Present', 1),
(9, '2024-24', 'Janine Perez', 'B', '2026-03-11', 'Present', 1),
(10, '2024-25', 'Mark Tolentino', 'B', '2026-03-12', 'Present', 1),
(11, '2024-26', 'Pia Soriano', 'B', '2026-03-12', 'Present', 1),
(12, '2024-27', 'Aldrin Magno', 'B', '2026-03-13', 'Present', 0),
(13, '2024-28', 'Czarina dela Vega', 'B', '2026-03-13', 'Absent', 0),
(14, '2024-29', 'Jerome Ilagan', 'B', '2026-03-13', 'Present', 0),
(15, '2024-30', 'Vanessa Corpuz', 'B', '2026-03-13', 'Present', 0);

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
