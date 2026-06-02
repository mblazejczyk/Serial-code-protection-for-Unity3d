-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Czas generowania: 30 Kwi 2021, 21:40
-- Wersja serwera: 10.2.36-MariaDB
-- Wersja PHP: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `zaqvxmpl_bscp`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `serial_numbers`
--

CREATE TABLE `serial_numbers` (
  `id` int(11) NOT NULL,
  `SerialNumber` text COLLATE utf8_unicode_ci NOT NULL,
  `Name` text COLLATE utf8_unicode_ci NOT NULL,
  `isValid` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Zrzut danych tabeli `serial_numbers`
--

INSERT INTO `serial_numbers` (`id`, `SerialNumber`, `Name`, `isValid`) VALUES
(43, 'CZPN7B2QBVJE088F', '', 1),
(42, 'HGRNZ8ZN1G7IEBND', '', 1),
(38, 'ZZQ9L6LNVQJ6BZ0Q', '', 1),
(37, 'VPB3FDC298Y4H6ZH', '', 1),
(36, 'D4YODIICGUKC1RWG', '', 1),
(35, '0PWC6SGL0IR9SK1Q', '', 1),
(34, 'WG3DC1NDFO0DCQX9', '', 1),
(33, '8WETNXQ9I5MIXVGE', '', 1),
(32, 'XP8YG5ZOI4Q1MQT1', '', 1),
(31, 'NBG1I5Z3YXLS4W0F', '', 1),
(30, 'EYKNVG429735KDWA', '', 1),
(29, 'Q38YTJSRTSTNWW0N', '', 1),
(28, 'BWPUMZSKGCAI1XQA', '', 1),
(27, 'SL0LM8EN20SG3TB3', '', 1),
(26, '1XU8IPHO9G233DT5', '', 1),
(44, '9CN6HDQ7WLVSZABP', '', 1),
(45, 'KQN2QFKS793E63AJ', '', 1),
(46, 'Y5QPWUN7HBMCLAHS', '', 1);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `serial_numbers`
--
ALTER TABLE `serial_numbers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla tabel zrzutów
--

--
-- AUTO_INCREMENT dla tabeli `serial_numbers`
--
ALTER TABLE `serial_numbers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
