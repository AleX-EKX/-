-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Aug 01, 2022 at 06:14 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `baza`
--

-- --------------------------------------------------------

--
-- Table structure for table `mail`
--

CREATE TABLE `mail` (
  `data` varchar(100) NOT NULL,
  `cena` varchar(50) NOT NULL,
  `id_bt` varchar(30) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` int(12) NOT NULL,
  `email` text NOT NULL,
  `kod` varchar(100) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mail`
--

INSERT INTO `mail` (`data`, `cena`, `id_bt`, `name`, `phone`, `email`, `kod`) VALUES
('Вторник 17:30', '400 рублей', 'vt_btn_17', 'asdad', 214342, 'sadas@mail.ru', '9'),
('Понедельник 16:30', '400 рублей', 'pn_btn_16', 'safasfa', 214124, 'safdsadfas@mail.ru', '1'),
('Среда 16:30', '400 рублей', 'cr_btn_16', 'qwe', 42352345, 'rwrasd@mail.ru', '15');

-- --------------------------------------------------------

--
-- Table structure for table `technical_support`
--

CREATE TABLE `technical_support` (
  `email` varchar(100) NOT NULL,
  `otziv` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `technical_support`
--

INSERT INTO `technical_support` (`email`, `otziv`) VALUES
('aaa', 'aaa'),
('asa@mail.com', 'dsfbiagbdi213');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `user_permission` int(1) DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `login`, `pass`, `name`, `surname`, `user_permission`) VALUES
(1, 'admin', '123', '', '', 0),
(2, 'Леха', '123', 'Леха', 'Гудулин', 0),
(3, 'bob', '123', 'Bob', 'Olson', 1),
(4, 'bobik', '123', 'Bob', 'Olson', 0),
(5, 'ahmed', '123', 'ALEX', 'Marley', 0),
(6, 'Savok', '777', 'Светлана', 'Савок', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mail`
--
ALTER TABLE `mail`
  ADD PRIMARY KEY (`data`);

--
-- Indexes for table `technical_support`
--
ALTER TABLE `technical_support`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
