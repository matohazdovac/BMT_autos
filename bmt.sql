-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 22, 2019 at 11:56 AM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bmt`
--

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

DROP TABLE IF EXISTS `korisnik`;
CREATE TABLE IF NOT EXISTS `korisnik` (
  `id_korisnik` int(11) NOT NULL AUTO_INCREMENT,
  `dat_rod` date NOT NULL,
  `broj_mobitela` varchar(30) COLLATE latin2_croatian_ci NOT NULL,
  `ime` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `mail` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `pbr_mjesto` int(10) NOT NULL,
  `prezime` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `username` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `password` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  PRIMARY KEY (`id_korisnik`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin2 COLLATE=latin2_croatian_ci;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`id_korisnik`, `dat_rod`, `broj_mobitela`, `ime`, `mail`, `pbr_mjesto`, `prezime`, `username`, `password`) VALUES
(1, '1996-09-27', '+385995774489', 'Mato', 'mato.hazdovac@gmail.com', 20225, 'Hazdovac', 'mato.hazdovac', '12345678');

-- --------------------------------------------------------

--
-- Table structure for table `mjesto`
--

DROP TABLE IF EXISTS `mjesto`;
CREATE TABLE IF NOT EXISTS `mjesto` (
  `naz_mjesto` varchar(255) COLLATE utf8_croatian_ci NOT NULL,
  `pbr` int(10) NOT NULL,
  `sif_zup` int(10) NOT NULL,
  PRIMARY KEY (`pbr`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `oglas`
--

DROP TABLE IF EXISTS `oglas`;
CREATE TABLE IF NOT EXISTS `oglas` (
  `cijena` double NOT NULL,
  `godina_proizvodnje` date NOT NULL,
  `id_korisnik` int(11) NOT NULL,
  `id_oglas` int(11) NOT NULL AUTO_INCREMENT,
  `id_slika` int(11) NOT NULL,
  `kilometri` double NOT NULL,
  `marka_auta` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `model_auta` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `serijski_broj` int(50) NOT NULL,
  `stanje_vozila` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  PRIMARY KEY (`id_oglas`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin2 COLLATE=latin2_croatian_ci;

--
-- Dumping data for table `oglas`
--

INSERT INTO `oglas` (`cijena`, `godina_proizvodnje`, `id_korisnik`, `id_oglas`, `id_slika`, `kilometri`, `marka_auta`, `model_auta`, `serijski_broj`, `stanje_vozila`) VALUES
(70000, '2014-11-12', 1, 1, 1, 200000, 'Volkswagen', 'Golf 6', 11111111, 'rabljeno'),
(143000, '2017-11-16', 1, 2, 2, 73000, 'Volkswagen', 'Golf 7', 22222, 'rabljeno'),
(101000, '2017-11-16', 1, 3, 3, 91000, 'Audi', 'A 3', 33333, 'rabljeno'),
(30000, '1999-11-16', 1, 4, 4, 350000, 'Volkswagen', 'Golf 3', 44444, 'ko novo'),
(51300, '2001-11-16', 1, 5, 5, 249000, 'Fiat', 'Punto', 55555, 'ko novo'),
(40000, '2004-11-16', 1, 6, 6, 400000, 'Ford', 'Focus', 66666, 'ko novo'),
(64900, '2009-11-16', 1, 7, 7, 128000, 'Volkswagen', 'Polo', 77777, 'ko novo');

-- --------------------------------------------------------

--
-- Table structure for table `registracija`
--

DROP TABLE IF EXISTS `registracija`;
CREATE TABLE IF NOT EXISTS `registracija` (
  `br_police_osiguranja` int(50) NOT NULL,
  `registracija` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `registrirano_do` date NOT NULL,
  `registrirano_od` date NOT NULL,
  `serijski_broj` int(50) NOT NULL,
  PRIMARY KEY (`serijski_broj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_croatian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `slika`
--

DROP TABLE IF EXISTS `slika`;
CREATE TABLE IF NOT EXISTS `slika` (
  `id_slika` int(11) NOT NULL AUTO_INCREMENT,
  `url_slika` varchar(255) COLLATE utf8_croatian_ci NOT NULL,
  PRIMARY KEY (`id_slika`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `zupanija`
--

DROP TABLE IF EXISTS `zupanija`;
CREATE TABLE IF NOT EXISTS `zupanija` (
  `nazzup` varchar(255) COLLATE latin2_croatian_ci NOT NULL,
  `sifzup` int(10) NOT NULL,
  PRIMARY KEY (`sifzup`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2 COLLATE=latin2_croatian_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
