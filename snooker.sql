-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Okt 19. 18:00
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `snooker`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `snooker`
--

CREATE TABLE `snooker` (
  `id` int(10) UNSIGNED NOT NULL,
  `Helyezes` int(3) DEFAULT NULL,
  `Nev` varchar(21) DEFAULT NULL,
  `Orszag` varchar(14) DEFAULT NULL,
  `Nyeremeny` int(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Snooker világranglista';

--
-- A tábla adatainak kiíratása `snooker`
--

INSERT INTO `snooker` (`id`, `Helyezes`, `Nev`, `Orszag`, `Nyeremeny`) VALUES
(1, 52, 'Akani Sunny', 'Thaiföld', 118500),
(2, 7, 'Allen Mark', 'Észak-Írország', 681000),
(3, 72, 'Anda Zhang', 'Kína', 44750),
(4, 76, 'Astley John', 'Anglia', 40000),
(5, 73, 'Baird Sam', 'Anglia', 44750),
(6, 13, 'Bingham Stuart', 'Anglia', 345500),
(7, 97, 'Bingyu Chang', 'Kína', 6750),
(8, 28, 'Brecel Luca', 'Belgium', 179000),
(9, 79, 'Brown Jordan', 'Észak-Írország', 29000),
(10, 78, 'Burden Alfred', 'Anglia', 32000),
(11, 50, 'Carrington Stuart', 'Anglia', 121750),
(12, 16, 'Carter Ali', 'Anglia', 289000),
(13, 81, 'Carty Ashley', 'Anglia', 22750),
(14, 86, 'Chandler Harvey', 'Anglia', 14475),
(15, 83, 'Chuan Leong Thor', 'Malajzia', 16500),
(16, 84, 'Clarke Jamie Rhys', 'Wales', 15500),
(17, 63, 'Craigie Sam', 'Anglia', 78500),
(18, 94, 'Dale Dominic', 'Wales', 8750),
(19, 41, 'Davis Mark', 'Anglia', 145725),
(20, 20, 'Day Ryan', 'Wales', 244250),
(21, 18, 'Ding Junhui', 'Kína', 270250),
(22, 64, 'Doherty Ken', 'Írország', 77250),
(23, 29, 'Donaldson Scott', 'Skócia', 176750),
(24, 21, 'Dott Graeme', 'Skócia', 237750),
(25, 66, 'Dunn Mike', 'Anglia', 74750),
(26, 53, 'Ebdon Peter', 'Anglia', 111750),
(27, 88, 'Feilong Chen', 'Kína', 13500),
(28, 22, 'Ford Tom', 'Anglia', 212250),
(29, 57, 'Fu Marco', 'Hong Kong', 104250),
(30, 51, 'Georgiou Michael', 'Ciprus', 119600),
(31, 11, 'Gilbert David', 'Anglia', 412000),
(32, 33, 'Gould Martin', 'Anglia', 160250),
(33, 99, 'Grace David', 'Anglia', 6750),
(34, 24, 'Guodong Xiao', 'Kína', 211600),
(35, 61, 'Hamilton Anthony', 'Anglia', 92250),
(36, 25, 'Haotian Lyu', 'Kína', 191750),
(37, 10, 'Hawkins Barry', 'Anglia', 427250),
(38, 91, 'Heathcote Louis', 'Anglia', 10750),
(39, 6, 'Higgins John', 'Skócia', 743000),
(40, 59, 'Higginson Andrew', 'Anglia', 96250),
(41, 60, 'Highfield Liam', 'Anglia', 96000),
(42, 89, 'Hirani Kishan', 'Wales', 13350),
(43, 44, 'Holt Michael', 'Anglia', 133500),
(44, 70, 'Honghao Luo', 'Kína', 65000),
(45, 95, 'Jiahui Si', 'Kína', 7500),
(46, 87, 'Jiankang Zhang', 'Kína', 13600),
(47, 71, 'Jones Jak', 'Wales', 54250),
(48, 48, 'Joyce Mark', 'Anglia', 125750),
(49, 30, 'King Mark', 'Anglia', 166500),
(50, 100, 'Langning Bai', 'Kína', 5000),
(51, 92, 'Lee Andy', 'Anglia', 9500),
(52, 43, 'Li Hang', 'Kína', 138000),
(53, 36, 'Liang Wenbo', 'Kína', 154500),
(54, 80, 'Lines Oliver', 'Anglia', 28000),
(55, 12, 'Lisowski Jack', 'Anglia', 392250),
(56, 34, 'Maflin Kurt', 'Norvégia', 158600),
(57, 14, 'Maguire Stephen', 'Skócia', 316000),
(58, 96, 'Mann Mitchell', 'Anglia', 7500),
(59, 32, 'McGill Anthony', 'Skócia', 160500),
(60, 54, 'McManus Alan', 'Skócia', 111250),
(61, 85, 'Miah Hammad', 'Anglia', 15475),
(62, 39, 'Milkins Robert', 'Anglia', 149600),
(63, 8, 'Murphy Shaun', 'Anglia', 506500),
(64, 62, 'Ning Lu', 'Kína', 87250),
(65, 67, 'O\'Brien Fergal', 'Írország', 70600),
(66, 68, 'O\'Connor Joe', 'Anglia', 69750),
(67, 42, 'O\'Donnell Martin', 'Anglia', 145250),
(68, 2, 'O\'Sullivan Ronnie', 'Anglia', 1116000),
(69, 65, 'Pengfei Tian', 'Kína', 75750),
(70, 15, 'Perry Joe', 'Anglia', 292500),
(71, 23, 'Robertson Jimmy', 'Anglia', 211725),
(72, 5, 'Robertson Neil', 'Ausztrália', 834500),
(73, 35, 'Saengkham Noppon', 'Thaiföld', 157000),
(74, 4, 'Selby Mark', 'Anglia', 863000),
(75, 27, 'Selt Matthew', 'Anglia', 180350),
(76, 49, 'Sijun Yuan', 'Kína', 123000),
(77, 74, 'Slessor Elliot', 'Anglia', 43500),
(78, 75, 'Steadman Craig', 'Anglia', 40500),
(79, 90, 'Stefanow Adam', 'Lengyelország', 12500),
(80, 46, 'Stevens Matthew', 'Wales', 129750),
(81, 1, 'Trump Judd', 'Anglia', 1270500),
(82, 37, 'Un-Nooh Thepchaiya', 'Thaiföld', 151225),
(83, 98, 'Ursenbacher Alexander', 'Svájc', 6750),
(84, 31, 'Vafaei Hossein', 'Irán', 161500),
(85, 45, 'Wakelin Chris', 'Anglia', 129975),
(86, 26, 'Walden Ricky', 'Anglia', 182750),
(87, 77, 'Walker Lee', 'Wales', 33000),
(88, 82, 'Wattana James', 'Thaiföld', 17500),
(89, 56, 'Wells Daniel', 'Wales', 104250),
(90, 58, 'White Michael', 'Wales', 98250),
(91, 3, 'Williams Mark', 'Wales', 1048250),
(92, 55, 'Williams Robbie', 'Anglia', 107500),
(93, 19, 'Wilson Gary', 'Anglia', 261100),
(94, 9, 'Wilson Kyren', 'Anglia', 470500),
(95, 40, 'Woollaston Ben', 'Anglia', 146350),
(96, 47, 'Xintong Zhao', 'Kína', 125750),
(97, 69, 'Xiwen Mei', 'Kína', 68000),
(98, 17, 'Yan Bingtao', 'Kína', 285000),
(99, 93, 'Zhengyi Fan', 'Kína', 9500),
(100, 38, 'Zhou Yuelong', 'Kína', 150250);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `snooker`
--
ALTER TABLE `snooker`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `snooker`
--
ALTER TABLE `snooker`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
